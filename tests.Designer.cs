
namespace bovid
{
    partial class tests
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
            this.bp1 = new System.Windows.Forms.TextBox();
            this.bp2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bp_label = new System.Windows.Forms.Label();
            this.hr_label = new System.Windows.Forms.Label();
            this.hr = new System.Windows.Forms.TextBox();
            this.os2_label = new System.Windows.Forms.Label();
            this.o2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bp1
            // 
            this.bp1.Location = new System.Drawing.Point(57, 106);
            this.bp1.Name = "bp1";
            this.bp1.Size = new System.Drawing.Size(100, 20);
            this.bp1.TabIndex = 0;
            this.bp1.TextChanged += new System.EventHandler(this.bp1_TextChanged);
            // 
            // bp2
            // 
            this.bp2.Location = new System.Drawing.Point(57, 167);
            this.bp2.Name = "bp2";
            this.bp2.Size = new System.Drawing.Size(100, 20);
            this.bp2.TabIndex = 1;
            this.bp2.TextChanged += new System.EventHandler(this.bp2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "systole";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "diastole";
            // 
            // bp_label
            // 
            this.bp_label.AutoSize = true;
            this.bp_label.Location = new System.Drawing.Point(54, 42);
            this.bp_label.Name = "bp_label";
            this.bp_label.Size = new System.Drawing.Size(106, 13);
            this.bp_label.TabIndex = 4;
            this.bp_label.Text = "BLOOD PRESSURE";
            this.bp_label.Click += new System.EventHandler(this.bp_label_Click);
            // 
            // hr_label
            // 
            this.hr_label.AutoSize = true;
            this.hr_label.Location = new System.Drawing.Point(54, 217);
            this.hr_label.Name = "hr_label";
            this.hr_label.Size = new System.Drawing.Size(76, 13);
            this.hr_label.TabIndex = 5;
            this.hr_label.Text = "HEART RATE";
            // 
            // hr
            // 
            this.hr.Location = new System.Drawing.Point(57, 253);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(100, 20);
            this.hr.TabIndex = 6;
            this.hr.TextChanged += new System.EventHandler(this.hr_TextChanged);
            // 
            // os2_label
            // 
            this.os2_label.AutoSize = true;
            this.os2_label.Location = new System.Drawing.Point(54, 299);
            this.os2_label.Name = "os2_label";
            this.os2_label.Size = new System.Drawing.Size(125, 13);
            this.os2_label.TabIndex = 7;
            this.os2_label.Text = "OXYGEN SATURATION";
            this.os2_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // o2
            // 
            this.o2.Location = new System.Drawing.Point(57, 333);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(100, 20);
            this.o2.TabIndex = 8;
            this.o2.TextChanged += new System.EventHandler(this.o2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "to be filled by screener";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 431);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.o2);
            this.Controls.Add(this.os2_label);
            this.Controls.Add(this.hr);
            this.Controls.Add(this.hr_label);
            this.Controls.Add(this.bp_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bp2);
            this.Controls.Add(this.bp1);
            this.Name = "tests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tests";
            this.Load += new System.EventHandler(this.tests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bp1;
        private System.Windows.Forms.TextBox bp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bp_label;
        private System.Windows.Forms.Label hr_label;
        private System.Windows.Forms.TextBox hr;
        private System.Windows.Forms.Label os2_label;
        private System.Windows.Forms.TextBox o2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}