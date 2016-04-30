namespace MSPDT.Windows
{
    partial class InputForm
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
            this.txtInputed = new System.Windows.Forms.TextBox();
            this.txtContents = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputed
            // 
            this.txtInputed.Location = new System.Drawing.Point(5, 18);
            this.txtInputed.Name = "txtInputed";
            this.txtInputed.Size = new System.Drawing.Size(259, 21);
            this.txtInputed.TabIndex = 0;
            // 
            // txtContents
            // 
            this.txtContents.AutoSize = true;
            this.txtContents.Location = new System.Drawing.Point(5, 3);
            this.txtContents.Name = "txtContents";
            this.txtContents.Size = new System.Drawing.Size(77, 12);
            this.txtContents.TabIndex = 1;
            this.txtContents.Text = "TEXT CONTENT";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(270, 18);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 22);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 45);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtContents);
            this.Controls.Add(this.txtInputed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputForm";
            this.Text = "TITLE";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputed;
        private System.Windows.Forms.Label txtContents;
        private System.Windows.Forms.Button btnOK;
    }
}