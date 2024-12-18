namespace LaenderspielApp
{
    partial class Hauptfenster
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
            this.labelQuizThema = new System.Windows.Forms.Label();
            this.comboBoxThemen = new System.Windows.Forms.ComboBox();
            this.buttonSpielStart = new System.Windows.Forms.Button();
            this.labelFragen = new System.Windows.Forms.Label();
            this.labelFeedbackAntwort = new System.Windows.Forms.Label();
            this.labelPunktestand = new System.Windows.Forms.Label();
            this.labelFortschritt = new System.Windows.Forms.Label();
            this.listBoxBesteErgebnisse = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFlaggen = new System.Windows.Forms.PictureBox();
            this.groupBoxQuizAntworten = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonWeiter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlaggen)).BeginInit();
            this.groupBoxQuizAntworten.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuizThema
            // 
            this.labelQuizThema.AutoSize = true;
            this.labelQuizThema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizThema.Location = new System.Drawing.Point(43, 62);
            this.labelQuizThema.Name = "labelQuizThema";
            this.labelQuizThema.Size = new System.Drawing.Size(132, 25);
            this.labelQuizThema.TabIndex = 0;
            this.labelQuizThema.Text = "Quiz-Thema";
            // 
            // comboBoxThemen
            // 
            this.comboBoxThemen.FormattingEnabled = true;
            this.comboBoxThemen.Items.AddRange(new object[] {
            "Flagge",
            "Ländername",
            "Hauptstadt"});
            this.comboBoxThemen.Location = new System.Drawing.Point(48, 104);
            this.comboBoxThemen.Name = "comboBoxThemen";
            this.comboBoxThemen.Size = new System.Drawing.Size(121, 24);
            this.comboBoxThemen.TabIndex = 1;
            // 
            // buttonSpielStart
            // 
            this.buttonSpielStart.Location = new System.Drawing.Point(48, 219);
            this.buttonSpielStart.Name = "buttonSpielStart";
            this.buttonSpielStart.Size = new System.Drawing.Size(109, 44);
            this.buttonSpielStart.TabIndex = 2;
            this.buttonSpielStart.Text = "Starte das Quiz";
            this.buttonSpielStart.UseVisualStyleBackColor = true;
            this.buttonSpielStart.Click += new System.EventHandler(this.buttonSpielStart_Click);
            // 
            // labelFragen
            // 
            this.labelFragen.AutoSize = true;
            this.labelFragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFragen.Location = new System.Drawing.Point(6, 18);
            this.labelFragen.Name = "labelFragen";
            this.labelFragen.Size = new System.Drawing.Size(80, 25);
            this.labelFragen.TabIndex = 3;
            this.labelFragen.Text = "Fragen";
            // 
            // labelFeedbackAntwort
            // 
            this.labelFeedbackAntwort.AutoSize = true;
            this.labelFeedbackAntwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedbackAntwort.Location = new System.Drawing.Point(17, 400);
            this.labelFeedbackAntwort.Name = "labelFeedbackAntwort";
            this.labelFeedbackAntwort.Size = new System.Drawing.Size(107, 25);
            this.labelFeedbackAntwort.TabIndex = 5;
            this.labelFeedbackAntwort.Text = "Feedback";
            // 
            // labelPunktestand
            // 
            this.labelPunktestand.AutoSize = true;
            this.labelPunktestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPunktestand.Location = new System.Drawing.Point(26, 63);
            this.labelPunktestand.Name = "labelPunktestand";
            this.labelPunktestand.Size = new System.Drawing.Size(132, 25);
            this.labelPunktestand.TabIndex = 6;
            this.labelPunktestand.Text = "Punktestand";
            // 
            // labelFortschritt
            // 
            this.labelFortschritt.AutoSize = true;
            this.labelFortschritt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFortschritt.Location = new System.Drawing.Point(217, 63);
            this.labelFortschritt.Name = "labelFortschritt";
            this.labelFortschritt.Size = new System.Drawing.Size(108, 25);
            this.labelFortschritt.TabIndex = 7;
            this.labelFortschritt.Text = "Fortschritt";
            // 
            // listBoxBesteErgebnisse
            // 
            this.listBoxBesteErgebnisse.FormattingEnabled = true;
            this.listBoxBesteErgebnisse.ItemHeight = 16;
            this.listBoxBesteErgebnisse.Location = new System.Drawing.Point(38, 202);
            this.listBoxBesteErgebnisse.Name = "listBoxBesteErgebnisse";
            this.listBoxBesteErgebnisse.Size = new System.Drawing.Size(295, 180);
            this.listBoxBesteErgebnisse.TabIndex = 9;
            this.listBoxBesteErgebnisse.SelectedIndexChanged += new System.EventHandler(this.listBoxSpielergebnis_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelQuizThema);
            this.groupBox1.Controls.Add(this.comboBoxThemen);
            this.groupBox1.Controls.Add(this.buttonSpielStart);
            this.groupBox1.Location = new System.Drawing.Point(47, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 434);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxFlaggen);
            this.groupBox2.Controls.Add(this.groupBoxQuizAntworten);
            this.groupBox2.Controls.Add(this.buttonWeiter);
            this.groupBox2.Controls.Add(this.labelFragen);
            this.groupBox2.Controls.Add(this.labelFeedbackAntwort);
            this.groupBox2.Location = new System.Drawing.Point(307, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 455);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxFlaggen
            // 
            this.pictureBoxFlaggen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFlaggen.Location = new System.Drawing.Point(93, 22);
            this.pictureBoxFlaggen.Name = "pictureBoxFlaggen";
            this.pictureBoxFlaggen.Size = new System.Drawing.Size(268, 134);
            this.pictureBoxFlaggen.TabIndex = 17;
            this.pictureBoxFlaggen.TabStop = false;
            this.pictureBoxFlaggen.Click += new System.EventHandler(this.pictureBoxFlaggen_Click);
            // 
            // groupBoxQuizAntworten
            // 
            this.groupBoxQuizAntworten.Controls.Add(this.radioButton1);
            this.groupBoxQuizAntworten.Controls.Add(this.radioButton2);
            this.groupBoxQuizAntworten.Controls.Add(this.radioButton3);
            this.groupBoxQuizAntworten.Controls.Add(this.radioButton4);
            this.groupBoxQuizAntworten.Location = new System.Drawing.Point(22, 151);
            this.groupBoxQuizAntworten.Name = "groupBoxQuizAntworten";
            this.groupBoxQuizAntworten.Size = new System.Drawing.Size(153, 191);
            this.groupBoxQuizAntworten.TabIndex = 16;
            this.groupBoxQuizAntworten.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 115);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 20);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 155);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 20);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonWeiter
            // 
            this.buttonWeiter.Location = new System.Drawing.Point(208, 198);
            this.buttonWeiter.Name = "buttonWeiter";
            this.buttonWeiter.Size = new System.Drawing.Size(120, 39);
            this.buttonWeiter.TabIndex = 15;
            this.buttonWeiter.Text = "Weiter";
            this.buttonWeiter.UseVisualStyleBackColor = true;
            this.buttonWeiter.Click += new System.EventHandler(this.NutzerAntwortGewaehlt);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "Das große Länderquiz";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelPunktestand);
            this.groupBox3.Controls.Add(this.listBoxBesteErgebnisse);
            this.groupBox3.Controls.Add(this.labelFortschritt);
            this.groupBox3.Location = new System.Drawing.Point(733, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 455);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 719);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hauptfenster";
            this.Text = "Laender Quiz";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlaggen)).EndInit();
            this.groupBoxQuizAntworten.ResumeLayout(false);
            this.groupBoxQuizAntworten.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuizThema;
        private System.Windows.Forms.ComboBox comboBoxThemen;
        private System.Windows.Forms.Button buttonSpielStart;
        private System.Windows.Forms.Label labelFragen;
        private System.Windows.Forms.Label labelFeedbackAntwort;
        private System.Windows.Forms.Label labelPunktestand;
        private System.Windows.Forms.Label labelFortschritt;
        private System.Windows.Forms.ListBox listBoxBesteErgebnisse;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.GroupBox groupBoxQuizAntworten;
        private System.Windows.Forms.PictureBox pictureBoxFlaggen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}