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

using System.Runtime.Serialization;
using GreenRound.Portable.Utilities.Patterns.Creational;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreenRound.Portable.Utilities.Test.Patterns
{
    [TestClass]
    public class PrototypePatternTest
    {
        private readonly string _dataExpected = "Data";
        private readonly string _deepDataExpected = "DeepData";
        private readonly string _shallowedDataExpected = "ShallowedData";
        private readonly string _shallowedDeepDataExpected = "ShallowedDeepData";
        private readonly string _deepCopiedDataExpected = "DeepCopiedData";
        private readonly string _deepCopiedDeepDataExpected = "DeepCopiedDeepData";

        [TestMethod]
        public void PrototypeTestMethod()
        {
            MyPrototype prototype = new MyPrototype("Data", new DeepData(_deepDataExpected));
            MyPrototype shallowPrototype = prototype.Clone();
            MyPrototype deepPrototype = prototype.DeepCopy();

            deepPrototype.FieldDeepData.DeepString = _deepCopiedDeepDataExpected;
            deepPrototype.FieldString = _deepCopiedDataExpected;

            shallowPrototype.FieldDeepData.DeepString = _shallowedDeepDataExpected;
            shallowPrototype.FieldString = _shallowedDataExpected;

            Assert.AreEqual(_shallowedDeepDataExpected, prototype.FieldDeepData.DeepString);
            Assert.AreEqual(_dataExpected,prototype.FieldString);

            Assert.AreEqual(_shallowedDeepDataExpected, shallowPrototype.FieldDeepData.DeepString);
            Assert.AreEqual(_shallowedDataExpected, shallowPrototype.FieldString);

            Assert.AreEqual(_deepCopiedDeepDataExpected, deepPrototype.FieldDeepData.DeepString);
            Assert.AreEqual(_deepCopiedDataExpected, deepPrototype.FieldString);
        }

        [DataContract]
        private class MyPrototype : Prototype<MyPrototype>
        {
            [DataMember]
            public string FieldString { get; set; }
            [DataMember]
            public DeepData FieldDeepData { get; set; }

            public MyPrototype(string fieldString, DeepData fieldObject)
            {
                FieldString = fieldString;
                FieldDeepData = fieldObject;
            }
        }

        [DataContract]
        private class DeepData
        {
            public string DeepString { get; set; }

            public DeepData(string deepString)
            {
                DeepString = deepString;
            }
        }
    }
}
