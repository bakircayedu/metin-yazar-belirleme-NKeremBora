namespace NLPProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenTextFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtTextPath = new System.Windows.Forms.TextBox();
            this.LBTextInfo = new System.Windows.Forms.ListBox();
            this.btnReadStack = new System.Windows.Forms.Button();
            this.btnReadHeap = new System.Windows.Forms.Button();
            this.btnReadHashTable = new System.Windows.Forms.Button();
            this.LBHeap = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenTextFile
            // 
            this.btnOpenTextFile.Location = new System.Drawing.Point(-3, -1);
            this.btnOpenTextFile.Name = "btnOpenTextFile";
            this.btnOpenTextFile.Size = new System.Drawing.Size(181, 29);
            this.btnOpenTextFile.TabIndex = 0;
            this.btnOpenTextFile.Text = "Dosyayi Seciniz";
            this.btnOpenTextFile.UseVisualStyleBackColor = true;
            this.btnOpenTextFile.Click += new System.EventHandler(this.btnOpenTextFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtTextPath
            // 
            this.txtTextPath.Location = new System.Drawing.Point(-3, 28);
            this.txtTextPath.Name = "txtTextPath";
            this.txtTextPath.Size = new System.Drawing.Size(310, 27);
            this.txtTextPath.TabIndex = 1;
            // 
            // LBTextInfo
            // 
            this.LBTextInfo.FormattingEnabled = true;
            this.LBTextInfo.ItemHeight = 20;
            this.LBTextInfo.Location = new System.Drawing.Point(366, 104);
            this.LBTextInfo.Name = "LBTextInfo";
            this.LBTextInfo.Size = new System.Drawing.Size(369, 384);
            this.LBTextInfo.TabIndex = 2;
            // 
            // btnReadStack
            // 
            this.btnReadStack.Location = new System.Drawing.Point(447, 28);
            this.btnReadStack.Name = "btnReadStack";
            this.btnReadStack.Size = new System.Drawing.Size(181, 29);
            this.btnReadStack.TabIndex = 3;
            this.btnReadStack.Text = "Stack\'e Oku";
            this.btnReadStack.UseVisualStyleBackColor = true;
            this.btnReadStack.Click += new System.EventHandler(this.btnReadStack_Click);
            // 
            // btnReadHeap
            // 
            this.btnReadHeap.Location = new System.Drawing.Point(997, 26);
            this.btnReadHeap.Name = "btnReadHeap";
            this.btnReadHeap.Size = new System.Drawing.Size(222, 29);
            this.btnReadHeap.TabIndex = 4;
            this.btnReadHeap.Text = "En Sik Kullanilan Kelimeri Getir";
            this.btnReadHeap.UseVisualStyleBackColor = true;
            this.btnReadHeap.Click += new System.EventHandler(this.btnReadHeap_Click);
            // 
            // btnReadHashTable
            // 
            this.btnReadHashTable.Location = new System.Drawing.Point(45, 241);
            this.btnReadHashTable.Name = "btnReadHashTable";
            this.btnReadHashTable.Size = new System.Drawing.Size(181, 29);
            this.btnReadHashTable.TabIndex = 5;
            this.btnReadHashTable.Text = "Hash Tablo Olustur";
            this.btnReadHashTable.UseVisualStyleBackColor = true;
            this.btnReadHashTable.Click += new System.EventHandler(this.btnReadHashTable_Click);
            // 
            // LBHeap
            // 
            this.LBHeap.FormattingEnabled = true;
            this.LBHeap.ItemHeight = 20;
            this.LBHeap.Location = new System.Drawing.Point(810, 83);
            this.LBHeap.Name = "LBHeap";
            this.LBHeap.Size = new System.Drawing.Size(424, 404);
            this.LBHeap.TabIndex = 6;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(810, 28);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(125, 27);
            this.txtSayi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 588);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.LBHeap);
            this.Controls.Add(this.btnReadHashTable);
            this.Controls.Add(this.btnReadHeap);
            this.Controls.Add(this.btnReadStack);
            this.Controls.Add(this.LBTextInfo);
            this.Controls.Add(this.txtTextPath);
            this.Controls.Add(this.btnOpenTextFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenTextFile;
        private OpenFileDialog openFileDialog1;
        private TextBox txtTextPath;
        private ListBox LBTextInfo;
        private Button btnReadStack;
        private Button btnReadHeap;
        private Button btnReadHashTable;
        private ListBox LBHeap;
        private TextBox txtSayi;
    }
}