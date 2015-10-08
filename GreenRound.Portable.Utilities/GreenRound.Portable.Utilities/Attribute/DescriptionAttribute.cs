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

//TODO: Document
namespace GreenRound.Portable.Utilities.Attribute
{
    [AttributeUsage(AttributeTargets.All)]
    public class DescriptionAttribute : System.Attribute
    {
        private string _description;

        public string Description
        {
            get { return _description; }
        }

        protected string DescriptionValue
        {
            get { return _description; }
            set { _description = value; }
        }


        public DescriptionAttribute(string description)
        {
            _description = description;
        }

        public DescriptionAttribute() : this(String.Empty)
        {
            
        }

        public override bool Equals(object obj)
        {
            DescriptionAttribute descriptionAttribute = obj as DescriptionAttribute;
            if (descriptionAttribute != null
                && descriptionAttribute.Description == this.Description)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
