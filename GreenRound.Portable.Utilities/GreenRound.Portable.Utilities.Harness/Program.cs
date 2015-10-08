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

/*
    Description: Harness project is just here to test features implemented in the GreenRound.Portable.Utilities
*/

using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using GreenRound.Portable.Utilities.Patterns.Creational;

namespace GreenRound.Portable.Utilities.Harness
{
	class Program
	{
		static void Main(string[] args)
		{
		    MyPrototypeBase prototypeBase = new MyPrototypeBase("Data", new DeepData("DeepData"));
            MyPrototypeBase shallowPrototypeBase = prototypeBase.Clone();
            MyPrototypeBase deepPrototypeBase = prototypeBase.DeepCopy();

            deepPrototypeBase.FieldDeepData.DeepString = "DeepCopiedDeepData";
		    deepPrototypeBase.FieldString = "DeepCopiedData";

            shallowPrototypeBase.FieldDeepData.DeepString = "ShallowedDeepData";
		    shallowPrototypeBase.FieldString = "ShallowedData";

            Console.WriteLine("Original");
            Console.WriteLine(prototypeBase.FieldDeepData.DeepString);
            Console.WriteLine(prototypeBase.FieldString);
            Console.WriteLine(string.Empty);

            Console.WriteLine("Shallow Copy");
            Console.WriteLine(shallowPrototypeBase.FieldDeepData.DeepString);
            Console.WriteLine(shallowPrototypeBase.FieldString);
            Console.WriteLine(string.Empty);

            Console.WriteLine("Deep Copy");
            Console.WriteLine(deepPrototypeBase.FieldDeepData.DeepString);
            Console.WriteLine(deepPrototypeBase.FieldString);

		    Console.ReadKey();
		}
        public enum EnumTest
        {
            [Description("Foo")]
            test1,
            [Description("Bar")]
            test2,
            tset3
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
