/*
   Copyright 2015 Kevin Giffone

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using GreenRound.Portable.Utilities.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DescriptionAttribute = GreenRound.Portable.Utilities.Attribute.DescriptionAttribute;

namespace GreenRound.Portable.Utilities.Test.Attribute
{
    [TestClass]
    public class DescriptionAttributeTest
    {
        [TestMethod]
        public void DescriptionAttributeEnumTestMethod()
        {
            Assert.AreEqual("Foo",EnumTest.test1.GetDescription());
            Assert.AreEqual("Bar", EnumTest.test2.GetDescription());
            Assert.AreEqual(string.Empty, EnumTest.test3.GetDescription());
        }

        [TestMethod]
        public void DescriptionAttributeEqualTestMethod()
        {
            DescriptionAttribute attribute1 = new DescriptionAttribute("equal");
            DescriptionAttribute attribute2 = new DescriptionAttribute("equal");
            DescriptionAttribute attribute3 = new DescriptionAttribute("notEqual");

            Assert.AreEqual(true, attribute1.Equals(attribute2));
            Assert.AreEqual(false, attribute1.Equals(attribute3));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DescriptionAttributeMissingTestMethod()
        {
            EnumTest.test4.GetDescription();
        }

        private enum EnumTest
        {
            [Description("Foo")]
            test1,
            [Description("Bar")]
            test2,
            [Description]
            test3,
            test4
        }

    }
}
