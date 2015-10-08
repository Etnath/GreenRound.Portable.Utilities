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

using System.IO;
using System.Runtime.Serialization;

namespace GreenRound.Portable.Utilities.Patterns.Creational
{
    /// <summary>
    /// Inherit from this class to implement the prototype pattern
    /// </summary>
    /// <typeparam name="T">The class that implements the prototype pattern</typeparam>
    [DataContract] //TODO: change to Serializable when SerializableAttribute is implemented
    public abstract class PrototypeBase<T> : IPrototype<T> where T : class
    {
        /// <summary>
        /// Returns a shallow copy of itself
        /// </summary>
        ///<returns></returns>
        public T Clone()
        {
            return (T) MemberwiseClone();
        }

        /// <summary>
        /// Return a deep copy of itself
        /// </summary>
        /// <returns></returns>
        public T DeepCopy()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            { 
                DataContractSerializer serializer = new DataContractSerializer(typeof(T)); //TODO: change to a binary formetter for better performance.            
                serializer.WriteObject(memoryStream,this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                return (T)serializer.ReadObject(memoryStream);
            }
        }
    }
}
