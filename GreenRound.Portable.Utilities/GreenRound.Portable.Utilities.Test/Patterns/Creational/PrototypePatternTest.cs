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
            MyPrototypeBase prototypeBase = new MyPrototypeBase("Data", new DeepData(_deepDataExpected));
            MyPrototypeBase shallowPrototypeBase = prototypeBase.Clone();
            MyPrototypeBase deepPrototypeBase = prototypeBase.DeepCopy();

            deepPrototypeBase.FieldDeepData.DeepString = _deepCopiedDeepDataExpected;
            deepPrototypeBase.FieldString = _deepCopiedDataExpected;

            shallowPrototypeBase.FieldDeepData.DeepString = _shallowedDeepDataExpected;
            shallowPrototypeBase.FieldString = _shallowedDataExpected;

            Assert.AreEqual(_shallowedDeepDataExpected, prototypeBase.FieldDeepData.DeepString);
            Assert.AreEqual(_dataExpected,prototypeBase.FieldString);

            Assert.AreEqual(_shallowedDeepDataExpected, shallowPrototypeBase.FieldDeepData.DeepString);
            Assert.AreEqual(_shallowedDataExpected, shallowPrototypeBase.FieldString);

            Assert.AreEqual(_deepCopiedDeepDataExpected, deepPrototypeBase.FieldDeepData.DeepString);
            Assert.AreEqual(_deepCopiedDataExpected, deepPrototypeBase.FieldString);
        }

        [DataContract]
        private class MyPrototypeBase : PrototypeBase<MyPrototypeBase>
        {
            [DataMember]
            public string FieldString { get; set; }
            [DataMember]
            public DeepData FieldDeepData { get; set; }

            public MyPrototypeBase(string fieldString, DeepData fieldObject)
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
