using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepTools
{
    interface IGrepExecution
    {
        string FunctionName { get; }
        void Execute(string keyword, string targetText);
    }
}
