using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace GreenRound.Portable.Utilities.Logging
{
    //TODO : document
    interface ILogOutputDestination
    {
        string Name { get; set; }

        void Write(string line);
    }
}
