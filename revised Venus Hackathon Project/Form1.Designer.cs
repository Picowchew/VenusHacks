
namespace revised_Venus_Hackathon_Project
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
            this.labelt = new System.Windows.Forms.Label();
            this.buttont = new System.Windows.Forms.Button();
            this.buttonn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelt.Location = new System.Drawing.Point(317, 25);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(112, 31);
            this.labelt.TabIndex = 0;
            this.labelt.Text = "Training";
            // 
            // buttont
            // 
            this.buttont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttont.Location = new System.Drawing.Point(545, 98);
            this.buttont.Name = "buttont";
            this.buttont.Size = new System.Drawing.Size(98, 49);
            this.buttont.TabIndex = 1;
            this.buttont.Text = "Tip";
            this.buttont.UseVisualStyleBackColor = true;
            this.buttont.Click += new System.EventHandler(this.buttont_Click);
            // 
            // buttonn
            // 
            this.buttonn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonn.Location = new System.Drawing.Point(548, 224);
            this.buttonn.Name = "buttonn";
            this.buttonn.Size = new System.Drawing.Size(95, 50);
            this.buttonn.TabIndex = 2;
            this.buttonn.Text = "Note";
            this.buttonn.UseVisualStyleBackColor = true;
            this.buttonn.Click += new System.EventHandler(this.buttonn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonn);
            this.Controls.Add(this.buttont);
            this.Controls.Add(this.labelt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.Button buttont;
        private System.Windows.Forms.Button buttonn;
    }
}

