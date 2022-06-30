
namespace practice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBWeight = new System.Windows.Forms.TextBox();
            this.txtBHeight = new System.Windows.Forms.TextBox();
            this.BMI = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "WEIGHT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 499);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEIGHT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBWeight
            // 
            this.txtBWeight.Location = new System.Drawing.Point(398, 390);
            this.txtBWeight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBWeight.Name = "txtBWeight";
            this.txtBWeight.Size = new System.Drawing.Size(164, 24);
            this.txtBWeight.TabIndex = 2;
            // 
            // txtBHeight
            // 
            this.txtBHeight.Location = new System.Drawing.Point(398, 495);
            this.txtBHeight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBHeight.Name = "txtBHeight";
            this.txtBHeight.Size = new System.Drawing.Size(164, 24);
            this.txtBHeight.TabIndex = 3;
            this.txtBHeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BMI
            // 
            this.BMI.BackColor = System.Drawing.Color.Red;
            this.BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI.ForeColor = System.Drawing.Color.Yellow;
            this.BMI.Location = new System.Drawing.Point(287, 598);
            this.BMI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(238, 49);
            this.BMI.TabIndex = 4;
            this.BMI.Text = "calculate BMI";
            this.BMI.UseVisualStyleBackColor = false;
            this.BMI.Click += new System.EventHandler(this.BMI_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::practice.Properties.Resources.what_is_body_mass_index_bmi;
            this.pictureBox2.Location = new System.Drawing.Point(256, 136);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::practice.Properties.Resources.health;
            this.pictureBox1.Location = new System.Drawing.Point(93, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 943);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.txtBHeight);
            this.Controls.Add(this.txtBWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBWeight;
        private System.Windows.Forms.TextBox txtBHeight;
        private System.Windows.Forms.Button BMI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

