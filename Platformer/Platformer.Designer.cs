﻿namespace Platformer
{
    partial class Platformer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Platformer));
            this.screen = new System.Windows.Forms.Panel();
            this.Block = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Block)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.screen.Controls.Add(this.Block);
            this.screen.Controls.Add(this.player);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(821, 391);
            this.screen.TabIndex = 0;
            // 
            // Block
            // 
            this.Block.BackColor = System.Drawing.Color.Gray;
            this.Block.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Block.BackgroundImage")));
            this.Block.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Block.Location = new System.Drawing.Point(187, 239);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(471, 38);
            this.Block.TabIndex = 3;
            this.Block.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(39, 239);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(25, 25);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.White;
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Location = new System.Drawing.Point(0, 391);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(821, 45);
            this.ground.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Platformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 436);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.ground);
            this.Name = "Platformer";
            this.Text = "Platform";
            this.Load += new System.EventHandler(this.Platformer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Platformer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Platformer_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Block)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Block;
        private System.Windows.Forms.Panel ground;
    }
}

