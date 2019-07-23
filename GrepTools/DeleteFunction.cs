using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpUtility.File;

namespace GrepTools
{
    public class DeleteFunction : IGrepExecution
    {
        public DeleteFunction()
        {
            FunctionName = "Delete";
        }

        public string FunctionName { get; }

        public void Execute(string keyword, string targetText)
        {
            var textList = targetText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            string newTextData="";
            foreach (var textLine in textList)
            {
                var text = textLine.Contains(keyword);
                // Hitすれば削除対象
                if (textLine.Contains(keyword))
                    continue;
                newTextData += textLine + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(newTextData))
                return;
            File.AppendAllText(@"Result.txt", newTextData);
        }
    }
}
