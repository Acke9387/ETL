namespace ETL
{
    partial class frmClassAnalytics
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
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Groupbox1 = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Textbox1
            // 
            this.Textbox1.Location = new System.Drawing.Point(20, 32);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(327, 20);
            this.Textbox1.TabIndex = 1;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(376, 19);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(125, 62);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Select Directory";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(411, 427);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(121, 48);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "Run Analysis";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(31, 221);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(507, 186);
            this.ListBox1.TabIndex = 5;
            // 
            // Groupbox1
            // 
            this.Groupbox1.Controls.Add(this.Textbox1);
            this.Groupbox1.Controls.Add(this.Button1);
            this.Groupbox1.Location = new System.Drawing.Point(31, 81);
            this.Groupbox1.Name = "Groupbox1";
            this.Groupbox1.Size = new System.Drawing.Size(507, 100);
            this.Groupbox1.TabIndex = 7;
            this.Groupbox1.TabStop = false;
            this.Groupbox1.Text = "Select a Folder that has all of your files";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(149, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 39);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Class Analytics";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(51, 427);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(121, 48);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "Populate Files";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // frmClassAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Groupbox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmClassAnalytics";
            this.Text = "Class Analytics";
            this.Groupbox1.ResumeLayout(false);
            this.Groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.GroupBox Groupbox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button Button3;
    }
}

