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
using System.Reflection;
using GreenRound.Portable.Utilities.Attribute;

namespace GreenRound.Portable.Utilities.Helper
{
    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            return GetDescriptionString(value);
        }

        public static string GetDescriptionString(Enum value)
        {
            Type type = value.GetType();
            string enumName = Enum.GetName(type, value);
            if (enumName != null)
            {
                FieldInfo field = type.GetField(enumName);
                DescriptionAttribute attribute = System.Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    return attribute.Description;
                }
                else
                {
                    //TODO throw a more meaningful exception
                    throw new Exception();
                }
            }
            else
            {
                //TODO throw a more meaningful exception
                throw new Exception();
            }
        }
    }
}
