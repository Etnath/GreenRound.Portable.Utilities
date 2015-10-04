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
		    MyPrototype prototype = new MyPrototype("Data", new DeepData("DeepData"));
            MyPrototype shallowPrototype = prototype.Clone();
            MyPrototype deepPrototype = prototype.DeepCopy();

            deepPrototype.FieldDeepData.DeepString = "DeepCopiedDeepData";
		    deepPrototype.FieldString = "DeepCopiedData";

            shallowPrototype.FieldDeepData.DeepString = "ShallowedDeepData";
		    shallowPrototype.FieldString = "ShallowedData";

            Console.WriteLine("Original");
            Console.WriteLine(prototype.FieldDeepData.DeepString);
            Console.WriteLine(prototype.FieldString);
            Console.WriteLine(string.Empty);

            Console.WriteLine("Shallow Copy");
            Console.WriteLine(shallowPrototype.FieldDeepData.DeepString);
            Console.WriteLine(shallowPrototype.FieldString);
            Console.WriteLine(string.Empty);

            Console.WriteLine("Deep Copy");
            Console.WriteLine(deepPrototype.FieldDeepData.DeepString);
            Console.WriteLine(deepPrototype.FieldString);

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
