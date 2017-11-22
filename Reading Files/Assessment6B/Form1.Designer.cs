namespace Assessment6B
{
    partial class FileReaderApplicationForm
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
            this.lblUserPromptInputOpenFile = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserOutputListBox = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxFileData = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserPromptInputOpenFile
            // 
            this.lblUserPromptInputOpenFile.AutoSize = true;
            this.lblUserPromptInputOpenFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPromptInputOpenFile.Location = new System.Drawing.Point(31, 199);
            this.lblUserPromptInputOpenFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPromptInputOpenFile.Name = "lblUserPromptInputOpenFile";
            this.lblUserPromptInputOpenFile.Size = new System.Drawing.Size(134, 19);
            this.lblUserPromptInputOpenFile.TabIndex = 0;
            this.lblUserPromptInputOpenFile.Text = "Click to open file";
            this.lblUserPromptInputOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserPromptInputOpenFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(371, 19);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(373, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to our File reader application";
            // 
            // lblUserOutputListBox
            // 
            this.lblUserOutputListBox.AutoSize = true;
            this.lblUserOutputListBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOutputListBox.Location = new System.Drawing.Point(732, 103);
            this.lblUserOutputListBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserOutputListBox.Name = "lblUserOutputListBox";
            this.lblUserOutputListBox.Size = new System.Drawing.Size(209, 19);
            this.lblUserOutputListBox.TabIndex = 2;
            this.lblUserOutputListBox.Text = "The file data is shown here";
            this.lblUserOutputListBox.Click += new System.EventHandler(this.lblUserOutputListBox_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(207, 191);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(136, 37);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Firebrick;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(373, 370);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 37);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(605, 370);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxFileData
            // 
            this.listBoxFileData.FormattingEnabled = true;
            this.listBoxFileData.ItemHeight = 17;
            this.listBoxFileData.Location = new System.Drawing.Point(605, 144);
            this.listBoxFileData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxFileData.Name = "listBoxFileData";
            this.listBoxFileData.Size = new System.Drawing.Size(502, 123);
            this.listBoxFileData.TabIndex = 6;
            // 
            // openFile
            // 
            this.openFile.FileName = "NameOfTheFile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1019, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "© Ahmed Matoussi";
            // 
            // FileReaderApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1182, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFileData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblUserOutputListBox);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUserPromptInputOpenFile);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FileReaderApplicationForm";
            this.Text = "File Reader Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserPromptInputOpenFile;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUserOutputListBox;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxFileData;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label2;
    }
}

