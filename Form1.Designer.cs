namespace LitteQuizMaster
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuiz = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCloseQuiz = new System.Windows.Forms.Button();
            this.btnAntwortSetzen = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblInfoWahr = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo5 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.lblMoeglicheAntwort4 = new System.Windows.Forms.Label();
            this.lblMoeglicheAntwort3 = new System.Windows.Forms.Label();
            this.lblMoeglicheAntwort2 = new System.Windows.Forms.Label();
            this.lblMoeglicheAntwort1 = new System.Windows.Forms.Label();
            this.lblMoeglicheAntwort5 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.lblFragestellung = new System.Windows.Forms.Label();
            this.lblTitelFrage = new System.Windows.Forms.Label();
            this.lblTitelQuiz = new System.Windows.Forms.Label();
            this.tabStatistik = new System.Windows.Forms.TabPage();
            this.btnCloseStatistik = new System.Windows.Forms.Button();
            this.lblTitelHighscoreList = new System.Windows.Forms.Label();
            this.lsbHighscore = new System.Windows.Forms.ListBox();
            this.txtAnzeigeErreichbarePunkte = new System.Windows.Forms.TextBox();
            this.txtAnzeigeErreichtePunkte = new System.Windows.Forms.TextBox();
            this.lblTextErreichbarePunktzahl = new System.Windows.Forms.Label();
            this.lblTextPunktzahl = new System.Windows.Forms.Label();
            this.lblTitelStatistik = new System.Windows.Forms.Label();
            this.tabNeueFragen = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCloseEditor = new System.Windows.Forms.Button();
            this.btnUeberschreiben = new System.Windows.Forms.Button();
            this.lblFragenListe = new System.Windows.Forms.Label();
            this.lstFragenliste = new System.Windows.Forms.ListBox();
            this.btnFrageLöschern = new System.Windows.Forms.Button();
            this.btnSpeicherFrage = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAntwortInfo1 = new System.Windows.Forms.Label();
            this.lblKennzeichnungFrage = new System.Windows.Forms.Label();
            this.txtNeueFrage = new System.Windows.Forms.TextBox();
            this.lblFragenEditorTitel = new System.Windows.Forms.Label();
            this.btnNeuFrageEditor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabQuiz.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabStatistik.SuspendLayout();
            this.tabNeueFragen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuiz);
            this.tabControl1.Controls.Add(this.tabStatistik);
            this.tabControl1.Controls.Add(this.tabNeueFragen);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1374, 914);
            this.tabControl1.TabIndex = 0;
            // 
            // tabQuiz
            // 
            this.tabQuiz.BackColor = System.Drawing.Color.Bisque;
            this.tabQuiz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabQuiz.Controls.Add(this.btnStart);
            this.tabQuiz.Controls.Add(this.btnCloseQuiz);
            this.tabQuiz.Controls.Add(this.btnAntwortSetzen);
            this.tabQuiz.Controls.Add(this.btnNext);
            this.tabQuiz.Controls.Add(this.lblInfoWahr);
            this.tabQuiz.Controls.Add(this.tableLayoutPanel1);
            this.tabQuiz.Controls.Add(this.lblFragestellung);
            this.tabQuiz.Controls.Add(this.lblTitelFrage);
            this.tabQuiz.Controls.Add(this.lblTitelQuiz);
            this.tabQuiz.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuiz.Location = new System.Drawing.Point(4, 33);
            this.tabQuiz.Name = "tabQuiz";
            this.tabQuiz.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabQuiz.Size = new System.Drawing.Size(1366, 877);
            this.tabQuiz.TabIndex = 0;
            this.tabQuiz.Text = "Quiz";
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStart.Location = new System.Drawing.Point(826, 678);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 49);
            this.btnStart.TabIndex = 36;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCloseQuiz
            // 
            this.btnCloseQuiz.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCloseQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseQuiz.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseQuiz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCloseQuiz.Location = new System.Drawing.Point(1026, 678);
            this.btnCloseQuiz.Name = "btnCloseQuiz";
            this.btnCloseQuiz.Size = new System.Drawing.Size(129, 49);
            this.btnCloseQuiz.TabIndex = 35;
            this.btnCloseQuiz.Text = "Schließen";
            this.btnCloseQuiz.UseVisualStyleBackColor = true;
            this.btnCloseQuiz.Click += new System.EventHandler(this.btnCloseQuiz_Click);
            // 
            // btnAntwortSetzen
            // 
            this.btnAntwortSetzen.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAntwortSetzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntwortSetzen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntwortSetzen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAntwortSetzen.Location = new System.Drawing.Point(244, 678);
            this.btnAntwortSetzen.Name = "btnAntwortSetzen";
            this.btnAntwortSetzen.Size = new System.Drawing.Size(129, 49);
            this.btnAntwortSetzen.TabIndex = 34;
            this.btnAntwortSetzen.Text = "Setzen";
            this.btnAntwortSetzen.UseVisualStyleBackColor = true;
            this.btnAntwortSetzen.Click += new System.EventHandler(this.btnAntwortSetzen_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Location = new System.Drawing.Point(74, 678);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(129, 49);
            this.btnNext.TabIndex = 33;
            this.btnNext.Text = "Nächste";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblInfoWahr
            // 
            this.lblInfoWahr.AutoSize = true;
            this.lblInfoWahr.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoWahr.Location = new System.Drawing.Point(956, 155);
            this.lblInfoWahr.Name = "lblInfoWahr";
            this.lblInfoWahr.Size = new System.Drawing.Size(59, 23);
            this.lblInfoWahr.TabIndex = 32;
            this.lblInfoWahr.Text = "wahr:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.62867F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.37133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMoeglicheAntwort4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMoeglicheAntwort3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMoeglicheAntwort2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMoeglicheAntwort1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMoeglicheAntwort5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton5, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(84, 195);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 415);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(846, 169);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(21, 20);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(846, 252);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(21, 20);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(846, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(21, 20);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton1.Location = new System.Drawing.Point(846, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 20);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblInfo1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(3, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(101, 23);
            this.lblInfo1.TabIndex = 2;
            this.lblInfo1.Text = "Antwort 1:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(3, 83);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(101, 23);
            this.lblInfo2.TabIndex = 3;
            this.lblInfo2.Text = "Antwort 2:";
            // 
            // lblInfo5
            // 
            this.lblInfo5.AutoSize = true;
            this.lblInfo5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo5.Location = new System.Drawing.Point(3, 332);
            this.lblInfo5.Name = "lblInfo5";
            this.lblInfo5.Size = new System.Drawing.Size(101, 23);
            this.lblInfo5.TabIndex = 6;
            this.lblInfo5.Text = "Antwort 5:";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo3.Location = new System.Drawing.Point(3, 166);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(101, 23);
            this.lblInfo3.TabIndex = 4;
            this.lblInfo3.Text = "Antwort 3:";
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo4.Location = new System.Drawing.Point(3, 249);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(101, 23);
            this.lblInfo4.TabIndex = 5;
            this.lblInfo4.Text = "Antwort 4:";
            // 
            // lblMoeglicheAntwort4
            // 
            this.lblMoeglicheAntwort4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoeglicheAntwort4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMoeglicheAntwort4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoeglicheAntwort4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoeglicheAntwort4.Location = new System.Drawing.Point(134, 249);
            this.lblMoeglicheAntwort4.Name = "lblMoeglicheAntwort4";
            this.lblMoeglicheAntwort4.Size = new System.Drawing.Size(706, 42);
            this.lblMoeglicheAntwort4.TabIndex = 11;
            // 
            // lblMoeglicheAntwort3
            // 
            this.lblMoeglicheAntwort3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoeglicheAntwort3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMoeglicheAntwort3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoeglicheAntwort3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoeglicheAntwort3.Location = new System.Drawing.Point(134, 166);
            this.lblMoeglicheAntwort3.Name = "lblMoeglicheAntwort3";
            this.lblMoeglicheAntwort3.Size = new System.Drawing.Size(706, 42);
            this.lblMoeglicheAntwort3.TabIndex = 18;
            // 
            // lblMoeglicheAntwort2
            // 
            this.lblMoeglicheAntwort2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoeglicheAntwort2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMoeglicheAntwort2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoeglicheAntwort2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoeglicheAntwort2.Location = new System.Drawing.Point(134, 83);
            this.lblMoeglicheAntwort2.Name = "lblMoeglicheAntwort2";
            this.lblMoeglicheAntwort2.Size = new System.Drawing.Size(706, 42);
            this.lblMoeglicheAntwort2.TabIndex = 19;
            // 
            // lblMoeglicheAntwort1
            // 
            this.lblMoeglicheAntwort1.BackColor = System.Drawing.Color.Bisque;
            this.lblMoeglicheAntwort1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoeglicheAntwort1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMoeglicheAntwort1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoeglicheAntwort1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoeglicheAntwort1.Location = new System.Drawing.Point(134, 0);
            this.lblMoeglicheAntwort1.Name = "lblMoeglicheAntwort1";
            this.lblMoeglicheAntwort1.Size = new System.Drawing.Size(706, 42);
            this.lblMoeglicheAntwort1.TabIndex = 20;
            // 
            // lblMoeglicheAntwort5
            // 
            this.lblMoeglicheAntwort5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoeglicheAntwort5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMoeglicheAntwort5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoeglicheAntwort5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoeglicheAntwort5.Location = new System.Drawing.Point(134, 332);
            this.lblMoeglicheAntwort5.Name = "lblMoeglicheAntwort5";
            this.lblMoeglicheAntwort5.Size = new System.Drawing.Size(706, 42);
            this.lblMoeglicheAntwort5.TabIndex = 21;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(846, 335);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(21, 20);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // lblFragestellung
            // 
            this.lblFragestellung.BackColor = System.Drawing.Color.PeachPuff;
            this.lblFragestellung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFragestellung.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFragestellung.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFragestellung.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFragestellung.Location = new System.Drawing.Point(184, 88);
            this.lblFragestellung.Name = "lblFragestellung";
            this.lblFragestellung.Size = new System.Drawing.Size(943, 67);
            this.lblFragestellung.TabIndex = 29;
            // 
            // lblTitelFrage
            // 
            this.lblTitelFrage.AutoSize = true;
            this.lblTitelFrage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelFrage.Location = new System.Drawing.Point(80, 100);
            this.lblTitelFrage.Name = "lblTitelFrage";
            this.lblTitelFrage.Size = new System.Drawing.Size(85, 29);
            this.lblTitelFrage.TabIndex = 28;
            this.lblTitelFrage.Text = "Frage:";
            // 
            // lblTitelQuiz
            // 
            this.lblTitelQuiz.AutoSize = true;
            this.lblTitelQuiz.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelQuiz.Location = new System.Drawing.Point(542, 42);
            this.lblTitelQuiz.Name = "lblTitelQuiz";
            this.lblTitelQuiz.Size = new System.Drawing.Size(80, 36);
            this.lblTitelQuiz.TabIndex = 27;
            this.lblTitelQuiz.Text = "Quiz";
            // 
            // tabStatistik
            // 
            this.tabStatistik.BackColor = System.Drawing.Color.Bisque;
            this.tabStatistik.Controls.Add(this.btnCloseStatistik);
            this.tabStatistik.Controls.Add(this.lblTitelHighscoreList);
            this.tabStatistik.Controls.Add(this.lsbHighscore);
            this.tabStatistik.Controls.Add(this.txtAnzeigeErreichbarePunkte);
            this.tabStatistik.Controls.Add(this.txtAnzeigeErreichtePunkte);
            this.tabStatistik.Controls.Add(this.lblTextErreichbarePunktzahl);
            this.tabStatistik.Controls.Add(this.lblTextPunktzahl);
            this.tabStatistik.Controls.Add(this.lblTitelStatistik);
            this.tabStatistik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatistik.Location = new System.Drawing.Point(4, 33);
            this.tabStatistik.Name = "tabStatistik";
            this.tabStatistik.Size = new System.Drawing.Size(1366, 877);
            this.tabStatistik.TabIndex = 2;
            this.tabStatistik.Text = "Statistik";
            // 
            // btnCloseStatistik
            // 
            this.btnCloseStatistik.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCloseStatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseStatistik.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseStatistik.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCloseStatistik.Location = new System.Drawing.Point(1089, 705);
            this.btnCloseStatistik.Name = "btnCloseStatistik";
            this.btnCloseStatistik.Size = new System.Drawing.Size(129, 49);
            this.btnCloseStatistik.TabIndex = 38;
            this.btnCloseStatistik.Text = "Schließen";
            this.btnCloseStatistik.UseVisualStyleBackColor = true;
            this.btnCloseStatistik.Click += new System.EventHandler(this.btnCloseStatistik_Click);
            // 
            // lblTitelHighscoreList
            // 
            this.lblTitelHighscoreList.AutoSize = true;
            this.lblTitelHighscoreList.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelHighscoreList.Location = new System.Drawing.Point(933, 178);
            this.lblTitelHighscoreList.Name = "lblTitelHighscoreList";
            this.lblTitelHighscoreList.Size = new System.Drawing.Size(158, 24);
            this.lblTitelHighscoreList.TabIndex = 7;
            this.lblTitelHighscoreList.Text = "Highscore Liste";
            // 
            // lsbHighscore
            // 
            this.lsbHighscore.BackColor = System.Drawing.Color.Bisque;
            this.lsbHighscore.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbHighscore.FormattingEnabled = true;
            this.lsbHighscore.ItemHeight = 23;
            this.lsbHighscore.Location = new System.Drawing.Point(938, 220);
            this.lsbHighscore.Name = "lsbHighscore";
            this.lsbHighscore.Size = new System.Drawing.Size(282, 372);
            this.lsbHighscore.TabIndex = 6;
            // 
            // txtAnzeigeErreichbarePunkte
            // 
            this.txtAnzeigeErreichbarePunkte.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtAnzeigeErreichbarePunkte.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnzeigeErreichbarePunkte.Location = new System.Drawing.Point(314, 271);
            this.txtAnzeigeErreichbarePunkte.Name = "txtAnzeigeErreichbarePunkte";
            this.txtAnzeigeErreichbarePunkte.Size = new System.Drawing.Size(330, 33);
            this.txtAnzeigeErreichbarePunkte.TabIndex = 4;
            // 
            // txtAnzeigeErreichtePunkte
            // 
            this.txtAnzeigeErreichtePunkte.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtAnzeigeErreichtePunkte.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnzeigeErreichtePunkte.Location = new System.Drawing.Point(314, 174);
            this.txtAnzeigeErreichtePunkte.Name = "txtAnzeigeErreichtePunkte";
            this.txtAnzeigeErreichtePunkte.Size = new System.Drawing.Size(330, 33);
            this.txtAnzeigeErreichtePunkte.TabIndex = 3;
            // 
            // lblTextErreichbarePunktzahl
            // 
            this.lblTextErreichbarePunktzahl.AutoSize = true;
            this.lblTextErreichbarePunktzahl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextErreichbarePunktzahl.Location = new System.Drawing.Point(62, 277);
            this.lblTextErreichbarePunktzahl.Name = "lblTextErreichbarePunktzahl";
            this.lblTextErreichbarePunktzahl.Size = new System.Drawing.Size(199, 24);
            this.lblTextErreichbarePunktzahl.TabIndex = 2;
            this.lblTextErreichbarePunktzahl.Text = "Erreichbare Punkte:";
            // 
            // lblTextPunktzahl
            // 
            this.lblTextPunktzahl.AutoSize = true;
            this.lblTextPunktzahl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextPunktzahl.Location = new System.Drawing.Point(62, 177);
            this.lblTextPunktzahl.Name = "lblTextPunktzahl";
            this.lblTextPunktzahl.Size = new System.Drawing.Size(175, 24);
            this.lblTextPunktzahl.TabIndex = 1;
            this.lblTextPunktzahl.Text = "Erreichte Punkte:";
            // 
            // lblTitelStatistik
            // 
            this.lblTitelStatistik.AutoSize = true;
            this.lblTitelStatistik.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelStatistik.Location = new System.Drawing.Point(506, 29);
            this.lblTitelStatistik.Name = "lblTitelStatistik";
            this.lblTitelStatistik.Size = new System.Drawing.Size(126, 36);
            this.lblTitelStatistik.TabIndex = 0;
            this.lblTitelStatistik.Text = "Statistik";
            // 
            // tabNeueFragen
            // 
            this.tabNeueFragen.BackColor = System.Drawing.Color.Bisque;
            this.tabNeueFragen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabNeueFragen.Controls.Add(this.btnNeuFrageEditor);
            this.tabNeueFragen.Controls.Add(this.btnEdit);
            this.tabNeueFragen.Controls.Add(this.btnCloseEditor);
            this.tabNeueFragen.Controls.Add(this.btnUeberschreiben);
            this.tabNeueFragen.Controls.Add(this.lblFragenListe);
            this.tabNeueFragen.Controls.Add(this.lstFragenliste);
            this.tabNeueFragen.Controls.Add(this.btnFrageLöschern);
            this.tabNeueFragen.Controls.Add(this.btnSpeicherFrage);
            this.tabNeueFragen.Controls.Add(this.label11);
            this.tabNeueFragen.Controls.Add(this.label10);
            this.tabNeueFragen.Controls.Add(this.label9);
            this.tabNeueFragen.Controls.Add(this.label8);
            this.tabNeueFragen.Controls.Add(this.label7);
            this.tabNeueFragen.Controls.Add(this.label6);
            this.tabNeueFragen.Controls.Add(this.radioButton10);
            this.tabNeueFragen.Controls.Add(this.radioButton9);
            this.tabNeueFragen.Controls.Add(this.radioButton8);
            this.tabNeueFragen.Controls.Add(this.radioButton7);
            this.tabNeueFragen.Controls.Add(this.radioButton6);
            this.tabNeueFragen.Controls.Add(this.textBox5);
            this.tabNeueFragen.Controls.Add(this.textBox4);
            this.tabNeueFragen.Controls.Add(this.textBox2);
            this.tabNeueFragen.Controls.Add(this.textBox3);
            this.tabNeueFragen.Controls.Add(this.textBox1);
            this.tabNeueFragen.Controls.Add(this.label5);
            this.tabNeueFragen.Controls.Add(this.label4);
            this.tabNeueFragen.Controls.Add(this.label3);
            this.tabNeueFragen.Controls.Add(this.label2);
            this.tabNeueFragen.Controls.Add(this.lblAntwortInfo1);
            this.tabNeueFragen.Controls.Add(this.lblKennzeichnungFrage);
            this.tabNeueFragen.Controls.Add(this.txtNeueFrage);
            this.tabNeueFragen.Controls.Add(this.lblFragenEditorTitel);
            this.tabNeueFragen.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNeueFragen.Location = new System.Drawing.Point(4, 33);
            this.tabNeueFragen.Name = "tabNeueFragen";
            this.tabNeueFragen.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabNeueFragen.Size = new System.Drawing.Size(1366, 877);
            this.tabNeueFragen.TabIndex = 1;
            this.tabNeueFragen.Text = "FragenEditor";
            this.tabNeueFragen.Click += new System.EventHandler(this.tabNeueFragen_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.Location = new System.Drawing.Point(468, 697);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 58);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Anzeigen";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCloseEditor
            // 
            this.btnCloseEditor.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCloseEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEditor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseEditor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCloseEditor.Location = new System.Drawing.Point(1099, 697);
            this.btnCloseEditor.Name = "btnCloseEditor";
            this.btnCloseEditor.Size = new System.Drawing.Size(183, 58);
            this.btnCloseEditor.TabIndex = 41;
            this.btnCloseEditor.Text = "Schließen";
            this.btnCloseEditor.UseVisualStyleBackColor = true;
            this.btnCloseEditor.Click += new System.EventHandler(this.btnCloseEditor_Click);
            // 
            // btnUeberschreiben
            // 
            this.btnUeberschreiben.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnUeberschreiben.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUeberschreiben.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUeberschreiben.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUeberschreiben.Location = new System.Drawing.Point(679, 697);
            this.btnUeberschreiben.Name = "btnUeberschreiben";
            this.btnUeberschreiben.Size = new System.Drawing.Size(183, 58);
            this.btnUeberschreiben.TabIndex = 40;
            this.btnUeberschreiben.Text = "Überschreiben";
            this.btnUeberschreiben.UseVisualStyleBackColor = true;
            this.btnUeberschreiben.Click += new System.EventHandler(this.btnUeberarbeiten_Click);
            // 
            // lblFragenListe
            // 
            this.lblFragenListe.AutoSize = true;
            this.lblFragenListe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFragenListe.Location = new System.Drawing.Point(28, 517);
            this.lblFragenListe.Name = "lblFragenListe";
            this.lblFragenListe.Size = new System.Drawing.Size(172, 24);
            this.lblFragenListe.TabIndex = 39;
            this.lblFragenListe.Text = "Liste der Fragen:";
            // 
            // lstFragenliste
            // 
            this.lstFragenliste.BackColor = System.Drawing.Color.PeachPuff;
            this.lstFragenliste.FormattingEnabled = true;
            this.lstFragenliste.ItemHeight = 25;
            this.lstFragenliste.Location = new System.Drawing.Point(220, 517);
            this.lstFragenliste.Name = "lstFragenliste";
            this.lstFragenliste.Size = new System.Drawing.Size(968, 104);
            this.lstFragenliste.TabIndex = 38;
            // 
            // btnFrageLöschern
            // 
            this.btnFrageLöschern.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnFrageLöschern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrageLöschern.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrageLöschern.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFrageLöschern.Location = new System.Drawing.Point(894, 697);
            this.btnFrageLöschern.Name = "btnFrageLöschern";
            this.btnFrageLöschern.Size = new System.Drawing.Size(183, 58);
            this.btnFrageLöschern.TabIndex = 37;
            this.btnFrageLöschern.Text = "Löschen";
            this.btnFrageLöschern.UseVisualStyleBackColor = true;
            this.btnFrageLöschern.Click += new System.EventHandler(this.btnFrageLöschern_Click);
            // 
            // btnSpeicherFrage
            // 
            this.btnSpeicherFrage.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnSpeicherFrage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeicherFrage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeicherFrage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSpeicherFrage.Location = new System.Drawing.Point(64, 697);
            this.btnSpeicherFrage.Name = "btnSpeicherFrage";
            this.btnSpeicherFrage.Size = new System.Drawing.Size(183, 58);
            this.btnSpeicherFrage.TabIndex = 36;
            this.btnSpeicherFrage.Text = "Speichern";
            this.btnSpeicherFrage.UseVisualStyleBackColor = true;
            this.btnSpeicherFrage.Click += new System.EventHandler(this.btnSpeicherFrage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1082, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Richtige Antwort:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1136, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "wahr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1136, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "wahr";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1136, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "wahr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1136, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "wahr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1136, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "wahr";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton10.Location = new System.Drawing.Point(1082, 445);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(21, 20);
            this.radioButton10.TabIndex = 20;
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton9.Location = new System.Drawing.Point(1082, 386);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(21, 20);
            this.radioButton9.TabIndex = 19;
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton8.Location = new System.Drawing.Point(1082, 331);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(21, 20);
            this.radioButton8.TabIndex = 18;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton7.Location = new System.Drawing.Point(1082, 274);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(21, 20);
            this.radioButton7.TabIndex = 17;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton6.Location = new System.Drawing.Point(1082, 217);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(21, 20);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.MistyRose;
            this.textBox5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(220, 438);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(823, 44);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.MistyRose;
            this.textBox4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(220, 380);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(823, 44);
            this.textBox4.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MistyRose;
            this.textBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(220, 268);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(823, 44);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MistyRose;
            this.textBox3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(220, 325);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(823, 44);
            this.textBox3.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(220, 211);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(823, 44);
            this.textBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Antwort 5:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Antwort 4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Antwort 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Antwort 2:";
            // 
            // lblAntwortInfo1
            // 
            this.lblAntwortInfo1.AutoSize = true;
            this.lblAntwortInfo1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntwortInfo1.Location = new System.Drawing.Point(64, 215);
            this.lblAntwortInfo1.Name = "lblAntwortInfo1";
            this.lblAntwortInfo1.Size = new System.Drawing.Size(108, 24);
            this.lblAntwortInfo1.TabIndex = 6;
            this.lblAntwortInfo1.Text = "Antwort 1:";
            // 
            // lblKennzeichnungFrage
            // 
            this.lblKennzeichnungFrage.AutoSize = true;
            this.lblKennzeichnungFrage.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKennzeichnungFrage.Location = new System.Drawing.Point(64, 112);
            this.lblKennzeichnungFrage.Name = "lblKennzeichnungFrage";
            this.lblKennzeichnungFrage.Size = new System.Drawing.Size(136, 26);
            this.lblKennzeichnungFrage.TabIndex = 5;
            this.lblKennzeichnungFrage.Text = "Neue Frage:";
            // 
            // txtNeueFrage
            // 
            this.txtNeueFrage.BackColor = System.Drawing.Color.RosyBrown;
            this.txtNeueFrage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeueFrage.Location = new System.Drawing.Point(220, 111);
            this.txtNeueFrage.Multiline = true;
            this.txtNeueFrage.Name = "txtNeueFrage";
            this.txtNeueFrage.Size = new System.Drawing.Size(823, 64);
            this.txtNeueFrage.TabIndex = 4;
            // 
            // lblFragenEditorTitel
            // 
            this.lblFragenEditorTitel.AutoSize = true;
            this.lblFragenEditorTitel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFragenEditorTitel.Location = new System.Drawing.Point(324, 28);
            this.lblFragenEditorTitel.Name = "lblFragenEditorTitel";
            this.lblFragenEditorTitel.Size = new System.Drawing.Size(610, 36);
            this.lblFragenEditorTitel.TabIndex = 0;
            this.lblFragenEditorTitel.Text = "Neue Fragen erstellen / Fragen bearbeiten";
            // 
            // btnNeuFrageEditor
            // 
            this.btnNeuFrageEditor.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnNeuFrageEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeuFrageEditor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuFrageEditor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNeuFrageEditor.Location = new System.Drawing.Point(269, 697);
            this.btnNeuFrageEditor.Name = "btnNeuFrageEditor";
            this.btnNeuFrageEditor.Size = new System.Drawing.Size(183, 58);
            this.btnNeuFrageEditor.TabIndex = 43;
            this.btnNeuFrageEditor.Text = "Neu";
            this.btnNeuFrageEditor.UseVisualStyleBackColor = true;
            this.btnNeuFrageEditor.Click += new System.EventHandler(this.btnNeuFrageEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 914);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Kleiner Quizmaster";
            this.tabControl1.ResumeLayout(false);
            this.tabQuiz.ResumeLayout(false);
            this.tabQuiz.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabStatistik.ResumeLayout(false);
            this.tabStatistik.PerformLayout();
            this.tabNeueFragen.ResumeLayout(false);
            this.tabNeueFragen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCloseQuiz;
        private System.Windows.Forms.Button btnAntwortSetzen;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblInfoWahr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo5;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label lblInfo4;
        private System.Windows.Forms.Label lblMoeglicheAntwort4;
        private System.Windows.Forms.Label lblMoeglicheAntwort3;
        private System.Windows.Forms.Label lblMoeglicheAntwort2;
        private System.Windows.Forms.Label lblMoeglicheAntwort1;
        private System.Windows.Forms.Label lblMoeglicheAntwort5;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label lblFragestellung;
        private System.Windows.Forms.Label lblTitelFrage;
        private System.Windows.Forms.Label lblTitelQuiz;
        private System.Windows.Forms.TabPage tabNeueFragen;
        private System.Windows.Forms.TextBox txtNeueFrage;
        private System.Windows.Forms.Label lblFragenEditorTitel;
        private System.Windows.Forms.Label lblKennzeichnungFrage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAntwortInfo1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSpeicherFrage;
        private System.Windows.Forms.Button btnFrageLöschern;
        private System.Windows.Forms.Label lblFragenListe;
        private System.Windows.Forms.ListBox lstFragenliste;
        private System.Windows.Forms.Button btnUeberschreiben;
        private System.Windows.Forms.Button btnCloseEditor;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tabStatistik;
        private System.Windows.Forms.Label lblTitelStatistik;
        private System.Windows.Forms.TextBox txtAnzeigeErreichtePunkte;
        private System.Windows.Forms.Label lblTextErreichbarePunktzahl;
        private System.Windows.Forms.Label lblTextPunktzahl;
        private System.Windows.Forms.TextBox txtAnzeigeErreichbarePunkte;
        private System.Windows.Forms.ListBox lsbHighscore;
        private System.Windows.Forms.Label lblTitelHighscoreList;
        protected System.Windows.Forms.TabPage tabQuiz;
        private System.Windows.Forms.Button btnCloseStatistik;
        private System.Windows.Forms.Button btnNeuFrageEditor;
    }
}

