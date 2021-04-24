
namespace Venus_Hackathons_project
{
    partial class Tip
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
            this.label1t = new System.Windows.Forms.Label();
            this.label2t = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1t
            // 
            this.label1t.AutoSize = true;
            this.label1t.Location = new System.Drawing.Point(72, 61);
            this.label1t.Name = "label1t";
            this.label1t.Size = new System.Drawing.Size(43, 13);
            this.label1t.TabIndex = 0;
            this.label1t.Text = "Subject";
            // 
            // label2t
            // 
            this.label2t.AutoSize = true;
            this.label2t.Location = new System.Drawing.Point(72, 156);
            this.label2t.Name = "label2t";
            this.label2t.Size = new System.Drawing.Size(50, 13);
            this.label2t.TabIndex = 1;
            this.label2t.Text = "Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2t
            // 
            this.textBox2t.Location = new System.Drawing.Point(173, 153);
            this.textBox2t.Multiline = true;
            this.textBox2t.Name = "textBox2t";
            this.textBox2t.Size = new System.Drawing.Size(453, 118);
            this.textBox2t.TabIndex = 3;
            // 
            // Tip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2t);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2t);
            this.Controls.Add(this.label1t);
            this.Name = "Tip";
            this.Text = "Tip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1t;
        private System.Windows.Forms.Label label2t;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2t;
    }
}