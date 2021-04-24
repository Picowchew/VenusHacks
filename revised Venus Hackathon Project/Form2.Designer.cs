
namespace revised_Venus_Hackathon_Project
{
    partial class Form2
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
            this.textBoxs1 = new System.Windows.Forms.TextBox();
            this.textBoxm2 = new System.Windows.Forms.TextBox();
            this.labels1 = new System.Windows.Forms.Label();
            this.labelm2 = new System.Windows.Forms.Label();
            this.buttonimage = new System.Windows.Forms.Button();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxs1
            // 
            this.textBoxs1.Location = new System.Drawing.Point(252, 82);
            this.textBoxs1.Name = "textBoxs1";
            this.textBoxs1.Size = new System.Drawing.Size(371, 20);
            this.textBoxs1.TabIndex = 0;
            // 
            // textBoxm2
            // 
            this.textBoxm2.Location = new System.Drawing.Point(252, 151);
            this.textBoxm2.Multiline = true;
            this.textBoxm2.Name = "textBoxm2";
            this.textBoxm2.Size = new System.Drawing.Size(371, 79);
            this.textBoxm2.TabIndex = 1;
            // 
            // labels1
            // 
            this.labels1.AutoSize = true;
            this.labels1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels1.Location = new System.Drawing.Point(104, 82);
            this.labels1.Name = "labels1";
            this.labels1.Size = new System.Drawing.Size(84, 25);
            this.labels1.TabIndex = 2;
            this.labels1.Text = "Subject";
            // 
            // labelm2
            // 
            this.labelm2.AutoSize = true;
            this.labelm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelm2.Location = new System.Drawing.Point(104, 151);
            this.labelm2.Name = "labelm2";
            this.labelm2.Size = new System.Drawing.Size(100, 25);
            this.labelm2.TabIndex = 3;
            this.labelm2.Text = "Message";
            // 
            // buttonimage
            // 
            this.buttonimage.Location = new System.Drawing.Point(455, 273);
            this.buttonimage.Name = "buttonimage";
            this.buttonimage.Size = new System.Drawing.Size(168, 23);
            this.buttonimage.TabIndex = 4;
            this.buttonimage.Text = "Upload Image";
            this.buttonimage.UseVisualStyleBackColor = true;
            this.buttonimage.Click += new System.EventHandler(this.buttonimage_Click);
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Location = new System.Drawing.Point(533, 350);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(90, 32);
            this.buttonsubmit.TabIndex = 5;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(170, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.buttonimage);
            this.Controls.Add(this.labelm2);
            this.Controls.Add(this.labels1);
            this.Controls.Add(this.textBoxm2);
            this.Controls.Add(this.textBoxs1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxs1;
        private System.Windows.Forms.TextBox textBoxm2;
        private System.Windows.Forms.Label labels1;
        private System.Windows.Forms.Label labelm2;
        private System.Windows.Forms.Button buttonimage;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}