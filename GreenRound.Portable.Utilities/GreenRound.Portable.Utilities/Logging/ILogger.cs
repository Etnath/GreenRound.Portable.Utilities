using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.Logging
{

    //TODO : document
    interface ILogger
    {
        IEnumerable<ILogOutputDestination> OutputDestinations { get; }
        LoggingLevel GlobalLevel { get; set; }
        string GlobalLayout { get; set; }

        void LogLine(string line);
        void LogLine(string line, LoggingLevel level);
        void LogLine(string line, LoggingLevel level, string layout);
        void LogLine(string line, LoggingLevel level, string layout, ILogOutputDestination destination);

        void LogFatal(string line);
        void LogFatal(string line, string layout);
        void LogFatal(string line, string layout, ILogOutputDestination destination);

        void LogError(string line);
        void LogError(string line, string layout);
        void LogError(string line, string layout, ILogOutputDestination destination);

        void LogWarning(string line);
        void LogWarning(string line, string layout);
        void LogWarning(string line, string layout, ILogOutputDestination destination);

        void LogTrace(string line);
        void LogTrace(string line, string layout);
        void LogTrace(string line, string layout, ILogOutputDestination destination);
    }
}
