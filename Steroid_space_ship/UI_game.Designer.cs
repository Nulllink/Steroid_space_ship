﻿
namespace Steroid_space_ship
{
    partial class UI_game
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
            this.panel_pause = new System.Windows.Forms.Panel();
            this.menuexit = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel_pause.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pause
            // 
            this.panel_pause.BackColor = System.Drawing.Color.DimGray;
            this.panel_pause.Controls.Add(this.menuexit);
            this.panel_pause.Controls.Add(this.go);
            this.panel_pause.Location = new System.Drawing.Point(0, 0);
            this.panel_pause.Name = "panel_pause";
            this.panel_pause.Size = new System.Drawing.Size(800, 450);
            this.panel_pause.TabIndex = 1;
            this.panel_pause.Visible = false;
            // 
            // menuexit
            // 
            this.menuexit.BackColor = System.Drawing.Color.Black;
            this.menuexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuexit.ForeColor = System.Drawing.Color.White;
            this.menuexit.Location = new System.Drawing.Point(330, 310);
            this.menuexit.Name = "menuexit";
            this.menuexit.Size = new System.Drawing.Size(140, 70);
            this.menuexit.TabIndex = 1;
            this.menuexit.Text = "Выйти в меню";
            this.menuexit.UseVisualStyleBackColor = false;
            this.menuexit.Click += new System.EventHandler(this.menuexit_Click);
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.Black;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.go.ForeColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(330, 150);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(140, 70);
            this.go.TabIndex = 0;
            this.go.Text = "Продолжить";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // UI_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Steroid_space_ship.Properties.Resources.background_game;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_pause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI_game";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_game_FormClosed);
            this.Load += new System.EventHandler(this.UI_game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UI_game_KeyDown);
            this.panel_pause.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pause;
        private System.Windows.Forms.Button menuexit;
        private System.Windows.Forms.Button go;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}