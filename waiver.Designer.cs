
namespace bovid
{
    partial class waiver
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
            this.waiver_text = new System.Windows.Forms.Label();
            this.waiver_decline = new System.Windows.Forms.Button();
            this.waiver_agree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // waiver_text
            // 
            this.waiver_text.AutoSize = true;
            this.waiver_text.Location = new System.Drawing.Point(156, 31);
            this.waiver_text.Name = "waiver_text";
            this.waiver_text.Size = new System.Drawing.Size(161, 13);
            this.waiver_text.TabIndex = 0;
            this.waiver_text.Text = "placeholder for the fuckin waiver";
            this.waiver_text.Click += new System.EventHandler(this.waiver_text_Click);
            // 
            // waiver_decline
            // 
            this.waiver_decline.Location = new System.Drawing.Point(279, 80);
            this.waiver_decline.Name = "waiver_decline";
            this.waiver_decline.Size = new System.Drawing.Size(75, 23);
            this.waiver_decline.TabIndex = 1;
            this.waiver_decline.Text = "Decline";
            this.waiver_decline.UseVisualStyleBackColor = true;
            this.waiver_decline.Click += new System.EventHandler(this.waiver_decline_Click);
            // 
            // waiver_agree
            // 
            this.waiver_agree.Location = new System.Drawing.Point(112, 80);
            this.waiver_agree.Name = "waiver_agree";
            this.waiver_agree.Size = new System.Drawing.Size(75, 23);
            this.waiver_agree.TabIndex = 2;
            this.waiver_agree.Text = "Agree";
            this.waiver_agree.UseVisualStyleBackColor = true;
            this.waiver_agree.Click += new System.EventHandler(this.waiver_agree_Click);
            // 
            // waiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 154);
            this.Controls.Add(this.waiver_agree);
            this.Controls.Add(this.waiver_decline);
            this.Controls.Add(this.waiver_text);
            this.Name = "waiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "waiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label waiver_text;
        private System.Windows.Forms.Button waiver_decline;
        private System.Windows.Forms.Button waiver_agree;
    }
}