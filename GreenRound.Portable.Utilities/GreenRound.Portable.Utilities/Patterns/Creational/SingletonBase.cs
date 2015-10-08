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

namespace GreenRound.Portable.Utilities.Patterns.Creational
{
    /// <summary>
    /// Inherit from this class to ensure only one instance of a given class is instanciated
    /// </summary>
    /// <typeparam name="T">The class that must be a singleton</typeparam>
    public class SingletonBase<T> where T : class 
    {
        /// <summary>
        /// The singleton instance. the default contructor of the class T is used to build the instance.
        /// </summary>
        private static readonly Lazy<T> _instance = new Lazy<T>(() => Activator.CreateInstance<T>());

        /// <summary>
        /// Return the singleton instance.
        /// </summary>
        public static T Instance
        {
            get { return _instance.Value; }
        }
    }
}
