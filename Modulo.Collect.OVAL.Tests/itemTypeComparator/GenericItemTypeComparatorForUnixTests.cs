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
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modulo.Collect.OVAL.SystemCharacteristics;
using Modulo.Collect.OVAL.SystemCharacteristics.comparators;
using Unix = Modulo.Collect.OVAL.SystemCharacteristics.Unix;


namespace Modulo.Collect.OVAL.Tests.itemTypeComparator
{
    [TestClass]
    public class GenericItemTypeComparatorForUnixTests
    {
        private const int FIRST_POSITION = 0;
        private const int SECOND_POSITION = 1;

        [TestMethod, Owner("lfernandes")]
        public void Should_be_possible_to_compare_two_runlevel_items_when_they_were_created_manually()
        {
            var differentRunlevelItems = CreateDifferentRunlevelItems();
            var equalRunLevelItems = CreateEqualRunlevelItems();

            Assert.IsFalse(
                new GenericItemTypeComparator()
                    .IsEquals(
                        differentRunlevelItems.ElementAt(FIRST_POSITION),
                        differentRunlevelItems.ElementAt(SECOND_POSITION)));

            Assert.IsTrue(
                new GenericItemTypeComparator()
                    .IsEquals(
                        equalRunLevelItems.ElementAt(FIRST_POSITION),
                        equalRunLevelItems.ElementAt(SECOND_POSITION)));
        }

        [TestMethod, Owner("lfernandes")]
        public void Should_be_possible_to_compare_two_unix_file_items_when_they_were_created_manually()
        {
            var differentFileItems = CreateDifferentRunlevelItems();
            var equalFileItems = CreateEqualRunlevelItems();

            Assert.IsFalse(
                new GenericItemTypeComparator()
                    .IsEquals(
                        differentFileItems.ElementAt(FIRST_POSITION),
                        differentFileItems.ElementAt(SECOND_POSITION)));

            Assert.IsTrue(
                new GenericItemTypeComparator()
                    .IsEquals(
                        equalFileItems.ElementAt(FIRST_POSITION),
                        equalFileItems.ElementAt(SECOND_POSITION)));
        }

        private Unix.runlevel_item[] CreateEqualRunlevelItems()
        {
            return new Unix.runlevel_item[]
            {
                new Unix.runlevel_item() 
                { 
                    service_name = EntityItemStringType("serviceName"),
                    runlevel = EntityItemStringType("runlevelValue"),
                    kill = EntityItemBoolType("killValue"),
                    start = EntityItemBoolType("startValue")
                },

                new Unix.runlevel_item() 
                { 
                    service_name = EntityItemStringType("serviceName"),
                    runlevel = EntityItemStringType("runlevelValue"),
                    kill = EntityItemBoolType("killValue"),
                    start = EntityItemBoolType("startValue")
                }
            };
        }

        private Unix.runlevel_item[] CreateDifferentRunlevelItems()
        {
            return new Unix.runlevel_item[]
            {
                new Unix.runlevel_item() { service_name = EntityItemStringType("ssh") },
                new Unix.runlevel_item() { service_name = EntityItemStringType("cups") }
            };
        }

        private Unix.file_item[] CreateEqualUnixFileItems()
        {
            return new Unix.file_item[]
            {
                new Unix.file_item() 
                { 
                    a_time = EntityItemIntType("201009211912"),
                    c_time = EntityItemIntType("200909211900"),
                    filename = EntityItemStringType("install.run"),
                    gexec = EntityItemBoolType("1"),
                    gread = EntityItemBoolType("0"),
                    group_id = EntityItemIntType("1020"),
                    gwrite = EntityItemBoolType("0"),
                    m_time = EntityItemIntType("20101"),
                    oexec = EntityItemBoolType("1"),
                    oread = EntityItemBoolType("0"),
                    owrite = EntityItemBoolType("0"),
                    path = EntityItemStringType("/home/usr"),
                    sgid = EntityItemBoolType("1"),
                    size = EntityItemIntType("1024"),
                    sticky = EntityItemBoolType("1"),
                    suid = EntityItemBoolType("1"),
                    type = EntityItemStringType("application"),
                    uexec = EntityItemBoolType("1"),
                    uread = EntityItemBoolType("0"),
                    user_id = EntityItemIntType("80"),
                    uwrite = EntityItemBoolType("0")
                },

                new Unix.file_item() 
                { 
                    a_time = EntityItemIntType("201009211912"),
                    c_time = EntityItemIntType("200909211900"),
                    filename = EntityItemStringType("install.run"),
                    gexec = EntityItemBoolType("1"),
                    gread = EntityItemBoolType("0"),
                    group_id = EntityItemIntType("1020"),
                    gwrite = EntityItemBoolType("0"),
                    m_time = EntityItemIntType("20101"),
                    oexec = EntityItemBoolType("1"),
                    oread = EntityItemBoolType("0"),
                    owrite = EntityItemBoolType("0"),
                    path = EntityItemStringType("/home/usr"),
                    sgid = EntityItemBoolType("1"),
                    size = EntityItemIntType("1024"),
                    sticky = EntityItemBoolType("1"),
                    suid = EntityItemBoolType("1"),
                    type = EntityItemStringType("application"),
                    uexec = EntityItemBoolType("1"),
                    uread = EntityItemBoolType("0"),
                    user_id = EntityItemIntType("80"),
                    uwrite = EntityItemBoolType("0")
                }
            };        
        }

        private Unix.file_item[] CreateDifferentFileItems()
        {
            return new Unix.file_item[]
            {
                new Unix.file_item() { filepath = EntityItemStringType("/home/usr/file1") },
                new Unix.file_item() { filepath = EntityItemStringType("/home/usr/file2") }
            };
        }

        private EntityItemStringType EntityItemStringType(string value)
        {
            return new EntityItemStringType() { Value = value };
        }

        private EntityItemBoolType EntityItemBoolType(string value)
        {
            return new EntityItemBoolType() { Value = value };
        }

        private EntityItemIntType EntityItemIntType(string value)
        {
            return new EntityItemIntType() { Value = value };
        }
    }    
}
