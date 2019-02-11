namespace ExcelManipulater
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
            this.btn_ImportFile = new System.Windows.Forms.Button();
            this.cmb_SortBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_SortStyles = new System.Windows.Forms.ComboBox();
            this.btn_SortFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ImportFile
            // 
            this.btn_ImportFile.Location = new System.Drawing.Point(125, 76);
            this.btn_ImportFile.Name = "btn_ImportFile";
            this.btn_ImportFile.Size = new System.Drawing.Size(75, 23);
            this.btn_ImportFile.TabIndex = 1;
            this.btn_ImportFile.Text = "Import File";
            this.btn_ImportFile.UseVisualStyleBackColor = true;
            this.btn_ImportFile.Click += new System.EventHandler(this.btn_ImportFile_Click);
            // 
            // cmb_SortBy
            // 
            this.cmb_SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SortBy.FormattingEnabled = true;
            this.cmb_SortBy.Location = new System.Drawing.Point(206, 78);
            this.cmb_SortBy.Name = "cmb_SortBy";
            this.cmb_SortBy.Size = new System.Drawing.Size(121, 21);
            this.cmb_SortBy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which column to sort by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "How to sort it";
            // 
            // cmb_SortStyles
            // 
            this.cmb_SortStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SortStyles.FormattingEnabled = true;
            this.cmb_SortStyles.Location = new System.Drawing.Point(333, 78);
            this.cmb_SortStyles.Name = "cmb_SortStyles";
            this.cmb_SortStyles.Size = new System.Drawing.Size(121, 21);
            this.cmb_SortStyles.TabIndex = 4;
            // 
            // btn_SortFile
            // 
            this.btn_SortFile.Location = new System.Drawing.Point(460, 76);
            this.btn_SortFile.Name = "btn_SortFile";
            this.btn_SortFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SortFile.TabIndex = 6;
            this.btn_SortFile.Text = "Sort file";
            this.btn_SortFile.UseVisualStyleBackColor = true;
            this.btn_SortFile.Click += new System.EventHandler(this.btn_SortFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 180);
            this.Controls.Add(this.btn_SortFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_SortStyles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_SortBy);
            this.Controls.Add(this.btn_ImportFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ImportFile;
        private System.Windows.Forms.ComboBox cmb_SortBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_SortStyles;
        private System.Windows.Forms.Button btn_SortFile;
    }
}

