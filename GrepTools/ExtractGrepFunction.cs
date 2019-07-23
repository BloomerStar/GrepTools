using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpUtility.File;

namespace GrepTools
{
    class ExtractGrepFunction : IGrepExecution
    {

        public string FunctionName { get; }

        public ExtractGrepFunction()
        {
            FunctionName = "Extract";
        }

        public void Execute(string keyword, string targetText)
        {
           var keywordList = keyword.Split(new string[] { "..." }, StringSplitOptions.None);
            var textList = targetText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            StrExtractInfo info = new StrExtractInfo(keywordList[0],keywordList[1]);
            string extractTextData = "";
            foreach (var textLine in textList)
            {
                var resText = TextSearcher.Extract(textLine, info);
                if (String.IsNullOrEmpty(resText))
                    continue;
                extractTextData += resText + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(extractTextData))
                return;
            File.AppendAllText(@"extract.txt", extractTextData);
        }
    }
}
