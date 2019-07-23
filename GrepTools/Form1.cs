using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CSharpUtility.File;
using CSharpUtility.SystemProvider;
using LogSystem;

namespace GrepTools
{
    public partial class Form1 : Form
    {
        private Dictionary<string, IGrepExecution> _functorMap;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SystemCenter.Instance.StartUp();
            _functorMap = new Dictionary<string, IGrepExecution>();

            DeleteFunction delFunc = new DeleteFunction();
            EntryComboBox(delFunc);
            ExtractGrepFunction extractFunc = new ExtractGrepFunction();
            EntryComboBox(extractFunc);
            MakeReTestPatternFunction reTestPatternFunc = new MakeReTestPatternFunction();
            EntryComboBox(reTestPatternFunc);

            ExecComboBox.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FileSelectDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectFileTextBox.Text = dialog.FileName;
            }
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            var selectedFunction = ExecComboBox.SelectedItem.ToString();
            if (_functorMap.ContainsKey(selectedFunction))
            {
                TextReader reader = new TextReader(Encoding.UTF8,LoggerService.Logger);

                var targetText = "";
                targetText = reader.GetTxtString(SelectFileTextBox.Text);

                _functorMap[selectedFunction].Execute(GrepTextBox.Text, targetText);
            }

            
        }

        private void EntryComboBox(IGrepExecution grepFunc)
        {
            _functorMap[grepFunc.FunctionName] = grepFunc;

            ExecComboBox.Items.Add(grepFunc.FunctionName);
        }
    }
}