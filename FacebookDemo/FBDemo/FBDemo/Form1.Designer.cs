namespace FBDemo
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
            this.btnGetProfileData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetProfileData
            // 
            this.btnGetProfileData.Location = new System.Drawing.Point(12, 12);
            this.btnGetProfileData.Name = "btnGetProfileData";
            this.btnGetProfileData.Size = new System.Drawing.Size(75, 23);
            this.btnGetProfileData.TabIndex = 0;
            this.btnGetProfileData.Text = "Get Profile";
            this.btnGetProfileData.UseVisualStyleBackColor = true;
            this.btnGetProfileData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 299);
            this.Controls.Add(this.btnGetProfileData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetProfileData;
    }
}

