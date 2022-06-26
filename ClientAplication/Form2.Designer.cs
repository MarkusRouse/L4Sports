namespace ClientAplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pctBox1Aplicación = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1Aplicación)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox1Aplicación
            // 
            this.pctBox1Aplicación.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctBox1Aplicación.Image = ((System.Drawing.Image)(resources.GetObject("pctBox1Aplicación.Image")));
            this.pctBox1Aplicación.Location = new System.Drawing.Point(12, 12);
            this.pctBox1Aplicación.Name = "pctBox1Aplicación";
            this.pctBox1Aplicación.Size = new System.Drawing.Size(199, 99);
            this.pctBox1Aplicación.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox1Aplicación.TabIndex = 0;
            this.pctBox1Aplicación.TabStop = false;
            this.pctBox1Aplicación.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctBox1Aplicación);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1Aplicación)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox1Aplicación;
    }
}