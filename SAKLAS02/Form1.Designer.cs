namespace SAKLAS02
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnor = new System.Windows.Forms.PictureBox();
            this.btnmax = new System.Windows.Forms.PictureBox();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.btnclos = new System.Windows.Forms.PictureBox();
            this.splash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnnor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("MicrogrammaDMedExt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAKLAS 0.2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 420);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnnor
            // 
            this.btnnor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnnor.Location = new System.Drawing.Point(923, 0);
            this.btnnor.Name = "btnnor";
            this.btnnor.Size = new System.Drawing.Size(25, 25);
            this.btnnor.TabIndex = 5;
            this.btnnor.TabStop = false;
            this.btnnor.Visible = false;
            this.btnnor.Click += new System.EventHandler(this.btnnor_Click);
            this.btnnor.MouseEnter += new System.EventHandler(this.btnnor_MouseEnter);
            this.btnnor.MouseLeave += new System.EventHandler(this.btnnor_MouseLeave);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnmax.Location = new System.Drawing.Point(923, 0);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(25, 25);
            this.btnmax.TabIndex = 4;
            this.btnmax.TabStop = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            this.btnmax.MouseEnter += new System.EventHandler(this.btnmax_MouseEnter);
            this.btnmax.MouseLeave += new System.EventHandler(this.btnmax_MouseLeave);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnmin.Location = new System.Drawing.Point(894, 0);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(25, 25);
            this.btnmin.TabIndex = 3;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            this.btnmin.MouseEnter += new System.EventHandler(this.btnmin_MouseEnter);
            this.btnmin.MouseLeave += new System.EventHandler(this.btnmin_MouseLeave);
            // 
            // btnclos
            // 
            this.btnclos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnclos.Location = new System.Drawing.Point(954, 0);
            this.btnclos.Name = "btnclos";
            this.btnclos.Size = new System.Drawing.Size(25, 25);
            this.btnclos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclos.TabIndex = 2;
            this.btnclos.TabStop = false;
            this.btnclos.Click += new System.EventHandler(this.btnclos_Click);
            this.btnclos.MouseEnter += new System.EventHandler(this.btnclos_MouseEnter);
            this.btnclos.MouseLeave += new System.EventHandler(this.btnclos_MouseLeave);
            // 
            // splash
            // 
            this.splash.BackColor = System.Drawing.Color.Transparent;
            this.splash.Image = global::SAKLAS02.Properties.Resources.fundo_01;
            this.splash.Location = new System.Drawing.Point(197, 0);
            this.splash.Name = "splash";
            this.splash.Size = new System.Drawing.Size(782, 420);
            this.splash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splash.TabIndex = 6;
            this.splash.TabStop = false;
            this.splash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splash_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(980, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnnor);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnclos);
            this.Controls.Add(this.splash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAKLAS 0.2";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnnor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnclos;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox btnmax;
        private System.Windows.Forms.PictureBox btnnor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox splash;
    }
}

