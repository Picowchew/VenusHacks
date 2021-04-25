
namespace revised_Venus_Hackathon_Project
{
    partial class Form3
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
            this.labels2 = new System.Windows.Forms.Label();
            this.labelm1 = new System.Windows.Forms.Label();
            this.textBoxs2 = new System.Windows.Forms.TextBox();
            this.textBoxm1 = new System.Windows.Forms.TextBox();
            this.buttonimage2 = new System.Windows.Forms.Button();
            this.buttonsubmit2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonem = new System.Windows.Forms.Button();
            this.buttonlt = new System.Windows.Forms.Button();
            this.buttoneve = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labels2
            // 
            this.labels2.AutoSize = true;
            this.labels2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels2.Location = new System.Drawing.Point(12, 18);
            this.labels2.Name = "labels2";
            this.labels2.Size = new System.Drawing.Size(84, 25);
            this.labels2.TabIndex = 3;
            this.labels2.Text = "Subject";
            // 
            // labelm1
            // 
            this.labelm1.AutoSize = true;
            this.labelm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelm1.Location = new System.Drawing.Point(12, 74);
            this.labelm1.Name = "labelm1";
            this.labelm1.Size = new System.Drawing.Size(100, 25);
            this.labelm1.TabIndex = 4;
            this.labelm1.Text = "Message";
            // 
            // textBoxs2
            // 
            this.textBoxs2.Location = new System.Drawing.Point(138, 24);
            this.textBoxs2.Name = "textBoxs2";
            this.textBoxs2.Size = new System.Drawing.Size(334, 20);
            this.textBoxs2.TabIndex = 5;
            this.textBoxs2.TextChanged += new System.EventHandler(this.textBoxs2_TextChanged);
            // 
            // textBoxm1
            // 
            this.textBoxm1.Location = new System.Drawing.Point(138, 80);
            this.textBoxm1.Multiline = true;
            this.textBoxm1.Name = "textBoxm1";
            this.textBoxm1.Size = new System.Drawing.Size(334, 79);
            this.textBoxm1.TabIndex = 6;
            // 
            // buttonimage2
            // 
            this.buttonimage2.Location = new System.Drawing.Point(390, 188);
            this.buttonimage2.Name = "buttonimage2";
            this.buttonimage2.Size = new System.Drawing.Size(82, 23);
            this.buttonimage2.TabIndex = 7;
            this.buttonimage2.Text = "Upload Image";
            this.buttonimage2.UseVisualStyleBackColor = true;
            this.buttonimage2.Click += new System.EventHandler(this.buttonimage2_Click);
            // 
            // buttonsubmit2
            // 
            this.buttonsubmit2.Location = new System.Drawing.Point(382, 256);
            this.buttonsubmit2.Name = "buttonsubmit2";
            this.buttonsubmit2.Size = new System.Drawing.Size(90, 32);
            this.buttonsubmit2.TabIndex = 8;
            this.buttonsubmit2.Text = "Submit";
            this.buttonsubmit2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 20);
            this.textBox2.TabIndex = 9;
            // 
            // buttonem
            // 
            this.buttonem.Location = new System.Drawing.Point(12, 179);
            this.buttonem.Name = "buttonem";
            this.buttonem.Size = new System.Drawing.Size(100, 33);
            this.buttonem.TabIndex = 10;
            this.buttonem.Text = "Early Morning";
            this.buttonem.UseVisualStyleBackColor = true;
            // 
            // buttonlt
            // 
            this.buttonlt.Location = new System.Drawing.Point(12, 218);
            this.buttonlt.Name = "buttonlt";
            this.buttonlt.Size = new System.Drawing.Size(100, 31);
            this.buttonlt.TabIndex = 11;
            this.buttonlt.Text = "Late Night";
            this.buttonlt.UseVisualStyleBackColor = true;
            this.buttonlt.Click += new System.EventHandler(this.buttonlt_Click);
            // 
            // buttoneve
            // 
            this.buttoneve.Location = new System.Drawing.Point(12, 255);
            this.buttoneve.Name = "buttoneve";
            this.buttoneve.Size = new System.Drawing.Size(100, 33);
            this.buttoneve.TabIndex = 12;
            this.buttoneve.Text = "Evening";
            this.buttoneve.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(138, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 63);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttoneve);
            this.Controls.Add(this.buttonlt);
            this.Controls.Add(this.buttonem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonsubmit2);
            this.Controls.Add(this.buttonimage2);
            this.Controls.Add(this.textBoxm1);
            this.Controls.Add(this.textBoxs2);
            this.Controls.Add(this.labelm1);
            this.Controls.Add(this.labels2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labels2;
        private System.Windows.Forms.Label labelm1;
        private System.Windows.Forms.TextBox textBoxs2;
        private System.Windows.Forms.TextBox textBoxm1;
        private System.Windows.Forms.Button buttonimage2;
        private System.Windows.Forms.Button buttonsubmit2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonem;
        private System.Windows.Forms.Button buttonlt;
        private System.Windows.Forms.Button buttoneve;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}