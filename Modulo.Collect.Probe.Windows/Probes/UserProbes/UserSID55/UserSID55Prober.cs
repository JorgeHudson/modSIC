﻿/*
 * Modulo Open Distributed SCAP Infrastructure Collector (modSIC)
 * 
 * Copyright (c) 2011, Modulo Solutions for GRC.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 * - Redistributions of source code must retain the above copyright notice,
 *   this list of conditions and the following disclaimer.
 *   
 * - Redistributions in binary form must reproduce the above copyright 
 *   notice, this list of conditions and the following disclaimer in the
 *   documentation and/or other materials provided with the distribution.
 *   
 * - Neither the name of Modulo Security, LLC nor the names of its
 *   contributors may be used to endorse or promote products derived from
 *   this software without specific  prior written permission.
 *   
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 * */
using System.Collections.Generic;
using System.Linq;
using Modulo.Collect.OVAL.Common;
using Modulo.Collect.OVAL.Definitions;
using Modulo.Collect.OVAL.SystemCharacteristics;
using Modulo.Collect.Probe.Common;
using Definitions = Modulo.Collect.OVAL.Definitions;
using Modulo.Collect.OVAL.Definitions.Windows;
using Modulo.Collect.Probe.Windows.WMI;
using Modulo.Collect.Probe.Windows.Providers;


namespace Modulo.Collect.Probe.Windows.UserSID55
{
    /// <summary>
    /// The user_sid55_object represents a set of users on a Windows system.  
    /// This set (which might contain only one user) is identified by a SID.
    /// </summary>
    [ProbeCapability(OvalObject="user_sid55", PlataformName=FamilyEnumeration.windows)]
    public class UserSID55Prober: ProbeBase, IProbe
    {
        private TargetInfo TargetInfo;

        protected override set GetSetElement(Definitions.ObjectType objectType)
        {
            return ((user_sid55_object)objectType).GetSetEntity();
        }

        protected override void OpenConnectionProvider(IList<IConnectionProvider> connectionContext, TargetInfo target)
        {
            this.TargetInfo = target;
            base.ConnectionProvider = base.ConnectionManager.Connect<FileConnectionProvider>(connectionContext, target);
        }

        protected override void ConfigureObjectCollector()
        {
            if (base.ItemTypeGenerator == null)
            {
                var wmiScope = ((FileConnectionProvider)ConnectionProvider).ConnectionScope;
                var accountProvider = new WindowsUsersProvider(new WmiDataProvider(wmiScope), this.TargetInfo);
                
                ItemTypeGenerator = new UserSID55ItemTypeGenerator(accountProvider);
                ObjectCollector = new UserSID55ObjectCollector(accountProvider);
            }
        }


        protected override IEnumerable<OVAL.Definitions.ObjectType> GetObjectsOfType(IEnumerable<Definitions.ObjectType> objectTypes)
        {
            return objectTypes.OfType<user_sid55_object>();
        }

        protected override ItemType CreateItemTypeWithErrorStatus(string errorMessage)
        {
            return new user_sid_item() { status = StatusEnumeration.error, message = PrepareErrorMessage(errorMessage) };
        }
    }
}
