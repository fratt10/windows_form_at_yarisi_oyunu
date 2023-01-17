
namespace gorsel_programlama212701061
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_212701061 = new System.Windows.Forms.Button();
            this.textBox1_212701061 = new System.Windows.Forms.TextBox();
            this.label1_212701061 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_212701061
            // 
            this.button1_212701061.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_212701061.Location = new System.Drawing.Point(696, 72);
            this.button1_212701061.Name = "button1_212701061";
            this.button1_212701061.Size = new System.Drawing.Size(136, 36);
            this.button1_212701061.TabIndex = 0;
            this.button1_212701061.Text = "GİRİŞ";
            this.button1_212701061.UseVisualStyleBackColor = true;
            this.button1_212701061.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_212701061
            // 
            this.textBox1_212701061.Location = new System.Drawing.Point(856, 25);
            this.textBox1_212701061.Name = "textBox1_212701061";
            this.textBox1_212701061.Size = new System.Drawing.Size(100, 22);
            this.textBox1_212701061.TabIndex = 1;
            // 
            // label1_212701061
            // 
            this.label1_212701061.AutoSize = true;
            this.label1_212701061.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_212701061.Location = new System.Drawing.Point(579, 25);
            this.label1_212701061.Name = "label1_212701061";
            this.label1_212701061.Size = new System.Drawing.Size(253, 29);
            this.label1_212701061.TabIndex = 2;
            this.label1_212701061.Text = "Oyuncu Sayisini Giriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1124, 630);
            this.Controls.Add(this.label1_212701061);
            this.Controls.Add(this.textBox1_212701061);
            this.Controls.Add(this.button1_212701061);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_212701061;
        private System.Windows.Forms.TextBox textBox1_212701061;
        private System.Windows.Forms.Label label1_212701061;
    }
}

