
namespace FloppyBird
{
    partial class HaunterPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaunterPokemon));
            this.ScoreIcon = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.OverGameICon = new System.Windows.Forms.Label();
            this.GroundIcon = new System.Windows.Forms.PictureBox();
            this.UpperPillar = new System.Windows.Forms.PictureBox();
            this.BottomPillar = new System.Windows.Forms.PictureBox();
            this.MainCharacterPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroundIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainCharacterPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreIcon
            // 
            this.ScoreIcon.AutoSize = true;
            this.ScoreIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreIcon.Location = new System.Drawing.Point(2, 409);
            this.ScoreIcon.Name = "ScoreIcon";
            this.ScoreIcon.Size = new System.Drawing.Size(88, 24);
            this.ScoreIcon.TabIndex = 4;
            this.ScoreIcon.Text = "Score: 0";
            // 
            // GameTime
            // 
            this.GameTime.Enabled = true;
            this.GameTime.Interval = 20;
            this.GameTime.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // OverGameICon
            // 
            this.OverGameICon.AutoSize = true;
            this.OverGameICon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverGameICon.Location = new System.Drawing.Point(193, 167);
            this.OverGameICon.Name = "OverGameICon";
            this.OverGameICon.Size = new System.Drawing.Size(162, 31);
            this.OverGameICon.TabIndex = 5;
            this.OverGameICon.Text = "Game Over";
            this.OverGameICon.Visible = false;
            this.OverGameICon.Click += new System.EventHandler(this.OverGameICon_Click);
            // 
            // GroundIcon
            // 
            this.GroundIcon.Image = global::FloppyBird.Properties.Resources.ground;
            this.GroundIcon.Location = new System.Drawing.Point(-3, 433);
            this.GroundIcon.Name = "GroundIcon";
            this.GroundIcon.Size = new System.Drawing.Size(570, 46);
            this.GroundIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GroundIcon.TabIndex = 3;
            this.GroundIcon.TabStop = false;
            // 
            // UpperPillar
            // 
            this.UpperPillar.Image = global::FloppyBird.Properties.Resources.pipedown;
            this.UpperPillar.Location = new System.Drawing.Point(466, 3);
            this.UpperPillar.Name = "UpperPillar";
            this.UpperPillar.Size = new System.Drawing.Size(53, 104);
            this.UpperPillar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpperPillar.TabIndex = 2;
            this.UpperPillar.TabStop = false;
            // 
            // BottomPillar
            // 
            this.BottomPillar.Image = global::FloppyBird.Properties.Resources.pipe;
            this.BottomPillar.Location = new System.Drawing.Point(336, 269);
            this.BottomPillar.Name = "BottomPillar";
            this.BottomPillar.Size = new System.Drawing.Size(53, 171);
            this.BottomPillar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomPillar.TabIndex = 1;
            this.BottomPillar.TabStop = false;
            this.BottomPillar.Click += new System.EventHandler(this.PillarPic2_Click);
            // 
            // MainCharacterPic
            // 
            this.MainCharacterPic.Image = global::FloppyBird.Properties.Resources.SeekPng_com_haunter_png_2294814;
            this.MainCharacterPic.Location = new System.Drawing.Point(12, 30);
            this.MainCharacterPic.Name = "MainCharacterPic";
            this.MainCharacterPic.Size = new System.Drawing.Size(49, 41);
            this.MainCharacterPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainCharacterPic.TabIndex = 0;
            this.MainCharacterPic.TabStop = false;
            // 
            // FloppyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 475);
            this.Controls.Add(this.OverGameICon);
            this.Controls.Add(this.ScoreIcon);
            this.Controls.Add(this.GroundIcon);
            this.Controls.Add(this.UpperPillar);
            this.Controls.Add(this.BottomPillar);
            this.Controls.Add(this.MainCharacterPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FloppyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haunter Demo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.GroundIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainCharacterPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainCharacterPic;
        private System.Windows.Forms.PictureBox BottomPillar;
        private System.Windows.Forms.PictureBox UpperPillar;
        private System.Windows.Forms.PictureBox GroundIcon;
        private System.Windows.Forms.Label ScoreIcon;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Label OverGameICon;
    }
}

