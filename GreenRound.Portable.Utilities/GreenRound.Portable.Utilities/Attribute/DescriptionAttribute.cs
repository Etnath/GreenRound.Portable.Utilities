using System;

//TODO: Document and unit test
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
    }
}
