
namespace FloppyBird
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.StartIcon = new System.Windows.Forms.Button();
            this.ExitIcon = new System.Windows.Forms.Button();
            this.ControlsIcon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Label();
            this.tiempoRGB = new System.Windows.Forms.Timer(this.components);
            this.ImagenControles = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenControles)).BeginInit();
            this.SuspendLayout();
            // 
            // StartIcon
            // 
            this.StartIcon.Location = new System.Drawing.Point(68, 104);
            this.StartIcon.Name = "StartIcon";
            this.StartIcon.Size = new System.Drawing.Size(89, 38);
            this.StartIcon.TabIndex = 0;
            this.StartIcon.Text = "Start";
            this.StartIcon.UseVisualStyleBackColor = true;
            this.StartIcon.Click += new System.EventHandler(this.StartIcon_Click);
            // 
            // ExitIcon
            // 
            this.ExitIcon.Location = new System.Drawing.Point(224, 105);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(89, 38);
            this.ExitIcon.TabIndex = 1;
            this.ExitIcon.Text = "Exit";
            this.ExitIcon.UseVisualStyleBackColor = true;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // ControlsIcon
            // 
            this.ControlsIcon.Location = new System.Drawing.Point(147, 178);
            this.ControlsIcon.Name = "ControlsIcon";
            this.ControlsIcon.Size = new System.Drawing.Size(89, 38);
            this.ControlsIcon.TabIndex = 2;
            this.ControlsIcon.Text = "Controls";
            this.ControlsIcon.UseVisualStyleBackColor = true;
            this.ControlsIcon.Click += new System.EventHandler(this.ControlsIcon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To Haunter Demo";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.Location = new System.Drawing.Point(325, 260);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(69, 23);
            this.Credits.TabIndex = 5;
            this.Credits.Text = "Greaser";
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // tiempoRGB
            // 
            this.tiempoRGB.Enabled = true;
            this.tiempoRGB.Tick += new System.EventHandler(this.tiempoRGB_Tick);
            // 
            // ImagenControles
            // 
            this.ImagenControles.ErrorImage = global::FloppyBird.Properties.Resources.spacebargif;
            this.ImagenControles.Image = global::FloppyBird.Properties.Resources.spacebargif;
            this.ImagenControles.Location = new System.Drawing.Point(68, 149);
            this.ImagenControles.Name = "ImagenControles";
            this.ImagenControles.Size = new System.Drawing.Size(245, 136);
            this.ImagenControles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenControles.TabIndex = 4;
            this.ImagenControles.TabStop = false;
            this.ImagenControles.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(407, 292);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.ImagenControles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ControlsIcon);
            this.Controls.Add(this.ExitIcon);
            this.Controls.Add(this.StartIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenControles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartIcon;
        private System.Windows.Forms.Button ExitIcon;
        private System.Windows.Forms.Button ControlsIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImagenControles;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Timer tiempoRGB;
    }
}