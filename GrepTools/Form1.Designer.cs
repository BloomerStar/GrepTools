namespace GrepTools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.GrepTextBox = new System.Windows.Forms.TextBox();
            this.SelectFileTextBox = new System.Windows.Forms.TextBox();
            this.FileSelectDialog = new System.Windows.Forms.Button();
            this.ExecComboBox = new System.Windows.Forms.ComboBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GrepTextBox
            // 
            resources.ApplyResources(this.GrepTextBox, "GrepTextBox");
            this.GrepTextBox.Name = "GrepTextBox";
            // 
            // SelectFileTextBox
            // 
            resources.ApplyResources(this.SelectFileTextBox, "SelectFileTextBox");
            this.SelectFileTextBox.Name = "SelectFileTextBox";
            // 
            // FileSelectDialog
            // 
            resources.ApplyResources(this.FileSelectDialog, "FileSelectDialog");
            this.FileSelectDialog.Name = "FileSelectDialog";
            this.FileSelectDialog.UseVisualStyleBackColor = true;
            this.FileSelectDialog.Click += new System.EventHandler(this.FileSelectDialog_Click);
            // 
            // ExecComboBox
            // 
            this.ExecComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.ExecComboBox, "ExecComboBox");
            this.ExecComboBox.Name = "ExecComboBox";
            // 
            // RunBtn
            // 
            resources.ApplyResources(this.RunBtn, "RunBtn");
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.ExecComboBox);
            this.Controls.Add(this.FileSelectDialog);
            this.Controls.Add(this.SelectFileTextBox);
            this.Controls.Add(this.GrepTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GrepTextBox;
        private System.Windows.Forms.TextBox SelectFileTextBox;
        private System.Windows.Forms.Button FileSelectDialog;
        private System.Windows.Forms.ComboBox ExecComboBox;
        private System.Windows.Forms.Button RunBtn;
    }
}