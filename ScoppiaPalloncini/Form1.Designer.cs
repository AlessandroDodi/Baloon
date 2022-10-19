namespace ScoppiaPalloncini
{
    partial class schermata
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schermata));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.punteggio = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.vittoria = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.palloncino0 = new System.Windows.Forms.PictureBox();
            this.palloncino5 = new System.Windows.Forms.PictureBox();
            this.palloncino8 = new System.Windows.Forms.PictureBox();
            this.palloncino7 = new System.Windows.Forms.PictureBox();
            this.palloncino4 = new System.Windows.Forms.PictureBox();
            this.palloncino3 = new System.Windows.Forms.PictureBox();
            this.palloncino6 = new System.Windows.Forms.PictureBox();
            this.palloncino2 = new System.Windows.Forms.PictureBox();
            this.palloncino1 = new System.Windows.Forms.PictureBox();
            this.tempo = new System.Windows.Forms.Label();
            this.tempo1 = new System.Windows.Forms.Label();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.gioca = new System.Windows.Forms.Label();
            this.regole = new System.Windows.Forms.Label();
            this.testoRegole = new System.Windows.Forms.TextBox();
            this.esc = new System.Windows.Forms.Label();
            this.indietro = new System.Windows.Forms.Label();
            this.simple = new System.Windows.Forms.Label();
            this.normal = new System.Windows.Forms.Label();
            this.hard = new System.Windows.Forms.Label();
            this.indietro2 = new System.Windows.Forms.Label();
            this.titolo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titolo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // punteggio
            // 
            this.punteggio.AutoSize = true;
            this.punteggio.BackColor = System.Drawing.Color.Transparent;
            this.punteggio.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.punteggio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.punteggio.Location = new System.Drawing.Point(1726, 979);
            this.punteggio.Name = "punteggio";
            this.punteggio.Size = new System.Drawing.Size(38, 40);
            this.punteggio.TabIndex = 2;
            this.punteggio.Text = "0";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.BackColor = System.Drawing.Color.Transparent;
            this.P.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.P.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.P.Location = new System.Drawing.Point(1586, 979);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(143, 40);
            this.P.TabIndex = 1;
            this.P.Text = "SCORE:";
            // 
            // vittoria
            // 
            this.vittoria.AutoSize = true;
            this.vittoria.BackColor = System.Drawing.Color.Transparent;
            this.vittoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vittoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F);
            this.vittoria.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vittoria.Location = new System.Drawing.Point(20, 843);
            this.vittoria.Name = "vittoria";
            this.vittoria.Size = new System.Drawing.Size(667, 120);
            this.vittoria.TabIndex = 3;
            this.vittoria.Text = "SCORE: 100";
            this.vittoria.Visible = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(1891, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 17);
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // palloncino0
            // 
            this.palloncino0.BackColor = System.Drawing.Color.Transparent;
            this.palloncino0.Image = ((System.Drawing.Image)(resources.GetObject("palloncino0.Image")));
            this.palloncino0.Location = new System.Drawing.Point(494, 1006);
            this.palloncino0.Name = "palloncino0";
            this.palloncino0.Size = new System.Drawing.Size(50, 50);
            this.palloncino0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino0.TabIndex = 5;
            this.palloncino0.TabStop = false;
            this.palloncino0.Click += new System.EventHandler(this.palloncino0_Click);
            // 
            // palloncino5
            // 
            this.palloncino5.BackColor = System.Drawing.Color.Transparent;
            this.palloncino5.Image = ((System.Drawing.Image)(resources.GetObject("palloncino5.Image")));
            this.palloncino5.Location = new System.Drawing.Point(998, 997);
            this.palloncino5.Name = "palloncino5";
            this.palloncino5.Size = new System.Drawing.Size(50, 50);
            this.palloncino5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino5.TabIndex = 6;
            this.palloncino5.TabStop = false;
            this.palloncino5.Click += new System.EventHandler(this.palloncino5_Click);
            // 
            // palloncino8
            // 
            this.palloncino8.BackColor = System.Drawing.Color.Transparent;
            this.palloncino8.Image = ((System.Drawing.Image)(resources.GetObject("palloncino8.Image")));
            this.palloncino8.Location = new System.Drawing.Point(1352, 1006);
            this.palloncino8.Name = "palloncino8";
            this.palloncino8.Size = new System.Drawing.Size(50, 50);
            this.palloncino8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino8.TabIndex = 7;
            this.palloncino8.TabStop = false;
            this.palloncino8.Click += new System.EventHandler(this.palloncino8_Click);
            // 
            // palloncino7
            // 
            this.palloncino7.BackColor = System.Drawing.Color.Transparent;
            this.palloncino7.Image = ((System.Drawing.Image)(resources.GetObject("palloncino7.Image")));
            this.palloncino7.Location = new System.Drawing.Point(1239, 997);
            this.palloncino7.Name = "palloncino7";
            this.palloncino7.Size = new System.Drawing.Size(50, 50);
            this.palloncino7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino7.TabIndex = 8;
            this.palloncino7.TabStop = false;
            this.palloncino7.Click += new System.EventHandler(this.palloncino7_Click);
            // 
            // palloncino4
            // 
            this.palloncino4.BackColor = System.Drawing.Color.Transparent;
            this.palloncino4.Image = ((System.Drawing.Image)(resources.GetObject("palloncino4.Image")));
            this.palloncino4.Location = new System.Drawing.Point(890, 997);
            this.palloncino4.Name = "palloncino4";
            this.palloncino4.Size = new System.Drawing.Size(50, 50);
            this.palloncino4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino4.TabIndex = 9;
            this.palloncino4.TabStop = false;
            this.palloncino4.Click += new System.EventHandler(this.palloncino4_Click);
            // 
            // palloncino3
            // 
            this.palloncino3.BackColor = System.Drawing.Color.Transparent;
            this.palloncino3.Image = ((System.Drawing.Image)(resources.GetObject("palloncino3.Image")));
            this.palloncino3.Location = new System.Drawing.Point(781, 997);
            this.palloncino3.Name = "palloncino3";
            this.palloncino3.Size = new System.Drawing.Size(50, 50);
            this.palloncino3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino3.TabIndex = 10;
            this.palloncino3.TabStop = false;
            this.palloncino3.Click += new System.EventHandler(this.palloncino3_Click);
            // 
            // palloncino6
            // 
            this.palloncino6.BackColor = System.Drawing.Color.Transparent;
            this.palloncino6.Image = ((System.Drawing.Image)(resources.GetObject("palloncino6.Image")));
            this.palloncino6.Location = new System.Drawing.Point(1110, 997);
            this.palloncino6.Name = "palloncino6";
            this.palloncino6.Size = new System.Drawing.Size(50, 50);
            this.palloncino6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino6.TabIndex = 11;
            this.palloncino6.TabStop = false;
            this.palloncino6.Click += new System.EventHandler(this.palloncino6_Click);
            // 
            // palloncino2
            // 
            this.palloncino2.BackColor = System.Drawing.Color.Transparent;
            this.palloncino2.Image = ((System.Drawing.Image)(resources.GetObject("palloncino2.Image")));
            this.palloncino2.Location = new System.Drawing.Point(654, 997);
            this.palloncino2.Name = "palloncino2";
            this.palloncino2.Size = new System.Drawing.Size(50, 50);
            this.palloncino2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino2.TabIndex = 12;
            this.palloncino2.TabStop = false;
            this.palloncino2.Click += new System.EventHandler(this.palloncino2_Click);
            // 
            // palloncino1
            // 
            this.palloncino1.BackColor = System.Drawing.Color.Transparent;
            this.palloncino1.Image = ((System.Drawing.Image)(resources.GetObject("palloncino1.Image")));
            this.palloncino1.Location = new System.Drawing.Point(567, 1006);
            this.palloncino1.Name = "palloncino1";
            this.palloncino1.Size = new System.Drawing.Size(50, 50);
            this.palloncino1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palloncino1.TabIndex = 13;
            this.palloncino1.TabStop = false;
            this.palloncino1.Click += new System.EventHandler(this.palloncino1_Click);
            // 
            // tempo
            // 
            this.tempo.AutoSize = true;
            this.tempo.BackColor = System.Drawing.Color.Transparent;
            this.tempo.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.tempo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tempo.Location = new System.Drawing.Point(33, 1006);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(122, 40);
            this.tempo.TabIndex = 14;
            this.tempo.Text = "TIME:";
            // 
            // tempo1
            // 
            this.tempo1.AutoSize = true;
            this.tempo1.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.tempo1.ForeColor = System.Drawing.SystemColors.Control;
            this.tempo1.Location = new System.Drawing.Point(175, 1006);
            this.tempo1.Name = "tempo1";
            this.tempo1.Size = new System.Drawing.Size(38, 40);
            this.tempo1.TabIndex = 15;
            this.tempo1.Text = "0";
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.Image = ((System.Drawing.Image)(resources.GetObject("bomb.Image")));
            this.bomb.Location = new System.Drawing.Point(12, 9);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(109, 109);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomb.TabIndex = 16;
            this.bomb.TabStop = false;
            this.bomb.Visible = false;
            this.bomb.Click += new System.EventHandler(this.bomb_Click);
            // 
            // gioca
            // 
            this.gioca.AutoSize = true;
            this.gioca.Font = new System.Drawing.Font("MS Gothic", 60F, System.Drawing.FontStyle.Bold);
            this.gioca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gioca.Location = new System.Drawing.Point(767, 231);
            this.gioca.Name = "gioca";
            this.gioca.Size = new System.Drawing.Size(198, 80);
            this.gioca.TabIndex = 17;
            this.gioca.Text = "PLAY";
            this.gioca.Click += new System.EventHandler(this.gioca_Click);
            // 
            // regole
            // 
            this.regole.AutoSize = true;
            this.regole.Font = new System.Drawing.Font("MS Gothic", 60F, System.Drawing.FontStyle.Bold);
            this.regole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regole.Location = new System.Drawing.Point(767, 358);
            this.regole.Name = "regole";
            this.regole.Size = new System.Drawing.Size(239, 80);
            this.regole.TabIndex = 18;
            this.regole.Text = "RULES";
            this.regole.Click += new System.EventHandler(this.regole_Click);
            // 
            // testoRegole
            // 
            this.testoRegole.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.testoRegole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testoRegole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.testoRegole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testoRegole.Location = new System.Drawing.Point(503, 466);
            this.testoRegole.Multiline = true;
            this.testoRegole.Name = "testoRegole";
            this.testoRegole.ReadOnly = true;
            this.testoRegole.Size = new System.Drawing.Size(805, 243);
            this.testoRegole.TabIndex = 19;
            this.testoRegole.Text = resources.GetString("testoRegole.Text");
            // 
            // esc
            // 
            this.esc.AutoSize = true;
            this.esc.Font = new System.Drawing.Font("MS Gothic", 60F, System.Drawing.FontStyle.Bold);
            this.esc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.esc.Location = new System.Drawing.Point(767, 478);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(198, 80);
            this.esc.TabIndex = 20;
            this.esc.Text = "ESCI";
            this.esc.Click += new System.EventHandler(this.esc_Click);
            // 
            // indietro
            // 
            this.indietro.AutoSize = true;
            this.indietro.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.indietro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.indietro.Location = new System.Drawing.Point(827, 692);
            this.indietro.Name = "indietro";
            this.indietro.Size = new System.Drawing.Size(101, 40);
            this.indietro.TabIndex = 21;
            this.indietro.Text = "BACK";
            this.indietro.Click += new System.EventHandler(this.indietro_Click);
            // 
            // simple
            // 
            this.simple.AutoSize = true;
            this.simple.Font = new System.Drawing.Font("MS Gothic", 60F, System.Drawing.FontStyle.Bold);
            this.simple.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.simple.Location = new System.Drawing.Point(55, 216);
            this.simple.Name = "simple";
            this.simple.Size = new System.Drawing.Size(280, 80);
            this.simple.TabIndex = 22;
            this.simple.Text = "SIMPLE";
            this.simple.Click += new System.EventHandler(this.simple_Click);
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Font = new System.Drawing.Font("MS Gothic", 60F, System.Drawing.FontStyle.Bold);
            this.normal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.normal.Location = new System.Drawing.Point(55, 316);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(280, 80);
            this.normal.TabIndex = 23;
            this.normal.Text = "NORMAL";
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Font = new System.Drawing.Font("MS Gothic", 60F, System.Drawing.FontStyle.Bold);
            this.hard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hard.Location = new System.Drawing.Point(69, 423);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(198, 80);
            this.hard.TabIndex = 24;
            this.hard.Text = "HARD";
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // indietro2
            // 
            this.indietro2.AutoSize = true;
            this.indietro2.Font = new System.Drawing.Font("MS Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.indietro2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.indietro2.Location = new System.Drawing.Point(76, 537);
            this.indietro2.Name = "indietro2";
            this.indietro2.Size = new System.Drawing.Size(101, 40);
            this.indietro2.TabIndex = 25;
            this.indietro2.Text = "BACK";
            this.indietro2.Click += new System.EventHandler(this.indietro2_Click);
            // 
            // titolo
            // 
            this.titolo.Image = ((System.Drawing.Image)(resources.GetObject("titolo.Image")));
            this.titolo.Location = new System.Drawing.Point(478, 31);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(811, 154);
            this.titolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titolo.TabIndex = 26;
            this.titolo.TabStop = false;
            // 
            // schermata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.titolo);
            this.Controls.Add(this.indietro2);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.simple);
            this.Controls.Add(this.indietro);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.testoRegole);
            this.Controls.Add(this.regole);
            this.Controls.Add(this.gioca);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.tempo1);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.palloncino1);
            this.Controls.Add(this.palloncino2);
            this.Controls.Add(this.palloncino6);
            this.Controls.Add(this.palloncino3);
            this.Controls.Add(this.palloncino4);
            this.Controls.Add(this.palloncino7);
            this.Controls.Add(this.palloncino8);
            this.Controls.Add(this.palloncino5);
            this.Controls.Add(this.palloncino0);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.vittoria);
            this.Controls.Add(this.P);
            this.Controls.Add(this.punteggio);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "schermata";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.palloncino0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palloncino1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titolo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label punteggio;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label vittoria;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox palloncino0;
        private System.Windows.Forms.PictureBox palloncino5;
        private System.Windows.Forms.PictureBox palloncino8;
        private System.Windows.Forms.PictureBox palloncino7;
        private System.Windows.Forms.PictureBox palloncino4;
        private System.Windows.Forms.PictureBox palloncino3;
        private System.Windows.Forms.PictureBox palloncino6;
        private System.Windows.Forms.PictureBox palloncino2;
        private System.Windows.Forms.PictureBox palloncino1;
        private System.Windows.Forms.Label tempo;
        private System.Windows.Forms.Label tempo1;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Label gioca;
        private System.Windows.Forms.Label regole;
        private System.Windows.Forms.TextBox testoRegole;
        private System.Windows.Forms.Label esc;
        private System.Windows.Forms.Label indietro;
        private System.Windows.Forms.Label simple;
        private System.Windows.Forms.Label normal;
        private System.Windows.Forms.Label hard;
        private System.Windows.Forms.Label indietro2;
        private System.Windows.Forms.PictureBox titolo;
    }
}

