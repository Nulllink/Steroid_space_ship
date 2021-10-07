
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
            this.components = new System.ComponentModel.Container();
            this.panel_pause = new System.Windows.Forms.Panel();
            this.scoregame = new System.Windows.Forms.Label();
            this.menuexit = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lifetime = new System.Windows.Forms.Label();
            this.panel_pause.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pause
            // 
            this.panel_pause.BackColor = System.Drawing.Color.DimGray;
            this.panel_pause.Controls.Add(this.lifetime);
            this.panel_pause.Controls.Add(this.scoregame);
            this.panel_pause.Controls.Add(this.menuexit);
            this.panel_pause.Controls.Add(this.go);
            this.panel_pause.Location = new System.Drawing.Point(0, 0);
            this.panel_pause.Name = "panel_pause";
            this.panel_pause.Size = new System.Drawing.Size(800, 450);
            this.panel_pause.TabIndex = 1;
            this.panel_pause.Visible = false;
            this.panel_pause.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_pause_Paint);
            // 
            // scoregame
            // 
            this.scoregame.AutoSize = true;
            this.scoregame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoregame.ForeColor = System.Drawing.Color.White;
            this.scoregame.Location = new System.Drawing.Point(15, 20);
            this.scoregame.Name = "scoregame";
            this.scoregame.Size = new System.Drawing.Size(129, 25);
            this.scoregame.TabIndex = 2;
            this.scoregame.Text = "Счёт игры:";
            this.scoregame.Click += new System.EventHandler(this.score_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lifetime
            // 
            this.lifetime.AutoSize = true;
            this.lifetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lifetime.ForeColor = System.Drawing.Color.White;
            this.lifetime.Location = new System.Drawing.Point(13, 57);
            this.lifetime.Name = "lifetime";
            this.lifetime.Size = new System.Drawing.Size(146, 25);
            this.lifetime.TabIndex = 2;
            this.lifetime.Text = "Время игры:";
            this.lifetime.Click += new System.EventHandler(this.lifetime_Click);
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
            this.panel_pause.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pause;
        private System.Windows.Forms.Button menuexit;
        private System.Windows.Forms.Button go;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label scoregame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lifetime;
    }
}