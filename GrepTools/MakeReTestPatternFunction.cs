using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSystem;
using ErrorSystem;
using TextReader = CSharpUtility.File.TextReader;

namespace GrepTools
{
    class MakeReTestPatternFunction : IGrepExecution
    {
        public string FunctionName { get; }

        public MakeReTestPatternFunction()
        {
            FunctionName = "MakeReTestPattern";
        }

        public void Execute(string keyword, string targetText)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                TextReader reader = new TextReader(Encoding.UTF8, LoggerService.Logger);
                var res = reader.TryGetTxtString("extract.txt",out keyword);
                if (!res)
                    ErrorHandler.Instance.OnError(-1,"Text NotFound");
            }

            var keywordList = keyword.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            var textList = targetText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            var reTestPatternData = "";
            foreach (var targetKey in keywordList)
            {
                if (string.IsNullOrEmpty(targetKey))
                    continue;
                var res = textList.Where(x => x.Contains(targetKey));
                foreach (var extractedText in res)
                {
                    reTestPatternData += extractedText + Environment.NewLine;
                }
            }

            if (String.IsNullOrEmpty(reTestPatternData))
                return;
            using (StreamWriter writer = new StreamWriter("testPattern.txt", false))
            {
                writer.WriteLine(reTestPatternData);

            }
        }
    }
}
