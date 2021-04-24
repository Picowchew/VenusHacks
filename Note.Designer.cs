
namespace Venus_Hackathons_project
{
    partial class Note
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
            this.label1n = new System.Windows.Forms.Label();
            this.label2n = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1n
            // 
            this.label1n.AutoSize = true;
            this.label1n.Location = new System.Drawing.Point(100, 146);
            this.label1n.Name = "label1n";
            this.label1n.Size = new System.Drawing.Size(50, 13);
            this.label1n.TabIndex = 0;
            this.label1n.Text = "Message";
            // 
            // label2n
            // 
            this.label2n.AutoSize = true;
            this.label2n.Location = new System.Drawing.Point(100, 67);
            this.label2n.Name = "label2n";
            this.label2n.Size = new System.Drawing.Size(43, 13);
            this.label2n.TabIndex = 1;
            this.label2n.Text = "Subject";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 139);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 103);
            this.textBox2.TabIndex = 3;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2n);
            this.Controls.Add(this.label1n);
            this.Name = "Note";
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1n;
        private System.Windows.Forms.Label label2n;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}