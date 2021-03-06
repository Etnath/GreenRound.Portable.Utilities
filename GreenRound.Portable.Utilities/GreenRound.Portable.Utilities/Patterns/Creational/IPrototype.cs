﻿/*
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

namespace GreenRound.Portable.Utilities.Patterns.Creational
{
    /// <summary>
    /// Interface for class that wants to follow the prototype pattern
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPrototype<T> where T : class 
    {
        /// <summary>
        /// Returns a shallow copy of itself
        /// </summary>
        ///<returns></returns>
        T Clone();
        /// <summary>
        /// Return a deep copy of itself
        /// </summary>
        /// <returns></returns>
        T DeepCopy();
    }
}
