﻿namespace Joltzis {
    partial class formStartMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStartMenu));
            pictureBox1 = new PictureBox();
            btnPlay = new Button();
            btnRank = new Button();
            btnConfig = new Button();
            txtbPlayerName = new TextBox();
            lbMenu1 = new Label();
            lbMenuWarning = new Label();
            panelConfig = new Panel();
            rdbtnHard = new RadioButton();
            rdbtnNormal = new RadioButton();
            rdbtnEasy = new RadioButton();
            label1 = new Label();
            pnBgListView = new Panel();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            dbJoltzisBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelConfig.SuspendLayout();
            pnBgListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbJoltzisBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_joltzisM;
            pictureBox1.Location = new Point(97, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 241);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnPlay
            // 
            btnPlay.Image = Properties.Resources.play_button_icon2;
            btnPlay.Location = new Point(89, 654);
            btnPlay.Name = "btnPlay";
            btnPlay.RightToLeft = RightToLeft.No;
            btnPlay.Size = new Size(82, 83);
            btnPlay.TabIndex = 1;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnRank
            // 
            btnRank.Image = Properties.Resources.ranking_icon2;
            btnRank.Location = new Point(89, 757);
            btnRank.Name = "btnRank";
            btnRank.Size = new Size(82, 83);
            btnRank.TabIndex = 2;
            btnRank.UseVisualStyleBackColor = true;
            btnRank.Click += btnRank_Click;
            // 
            // btnConfig
            // 
            btnConfig.Image = Properties.Resources.config_icon;
            btnConfig.Location = new Point(89, 860);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(82, 83);
            btnConfig.TabIndex = 3;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // txtbPlayerName
            // 
            txtbPlayerName.Location = new Point(206, 680);
            txtbPlayerName.Name = "txtbPlayerName";
            txtbPlayerName.Size = new Size(321, 31);
            txtbPlayerName.TabIndex = 4;
            txtbPlayerName.TextChanged += textBox1_TextChanged;
            // 
            // lbMenu1
            // 
            lbMenu1.AutoSize = true;
            lbMenu1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMenu1.Location = new Point(206, 642);
            lbMenu1.Name = "lbMenu1";
            lbMenu1.Size = new Size(285, 24);
            lbMenu1.TabIndex = 5;
            lbMenu1.Text = "Digite o nome de jogador:";
            lbMenu1.Click += lbMenu1_Click;
            // 
            // lbMenuWarning
            // 
            lbMenuWarning.AutoSize = true;
            lbMenuWarning.Font = new Font("Cascadia Mono", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbMenuWarning.ForeColor = Color.Red;
            lbMenuWarning.Location = new Point(163, 585);
            lbMenuWarning.Name = "lbMenuWarning";
            lbMenuWarning.Size = new Size(545, 37);
            lbMenuWarning.TabIndex = 6;
            lbMenuWarning.Text = "Digite um nome de jogador válido!";
            lbMenuWarning.Visible = false;
            lbMenuWarning.Click += label1_Click;
            // 
            // panelConfig
            // 
            panelConfig.BackColor = SystemColors.Control;
            panelConfig.Controls.Add(rdbtnHard);
            panelConfig.Controls.Add(rdbtnNormal);
            panelConfig.Controls.Add(rdbtnEasy);
            panelConfig.Controls.Add(label1);
            panelConfig.Location = new Point(197, 848);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(487, 107);
            panelConfig.TabIndex = 7;
            panelConfig.Visible = false;
            // 
            // rdbtnHard
            // 
            rdbtnHard.AutoSize = true;
            rdbtnHard.Location = new Point(383, 57);
            rdbtnHard.Name = "rdbtnHard";
            rdbtnHard.Size = new Size(76, 29);
            rdbtnHard.TabIndex = 3;
            rdbtnHard.TabStop = true;
            rdbtnHard.Text = "Hard";
            rdbtnHard.UseVisualStyleBackColor = true;
            rdbtnHard.Visible = false;
            // 
            // rdbtnNormal
            // 
            rdbtnNormal.AutoSize = true;
            rdbtnNormal.Checked = true;
            rdbtnNormal.Location = new Point(198, 57);
            rdbtnNormal.Name = "rdbtnNormal";
            rdbtnNormal.Size = new Size(96, 29);
            rdbtnNormal.TabIndex = 2;
            rdbtnNormal.TabStop = true;
            rdbtnNormal.Text = "Normal";
            rdbtnNormal.UseVisualStyleBackColor = true;
            rdbtnNormal.Visible = false;
            // 
            // rdbtnEasy
            // 
            rdbtnEasy.AutoSize = true;
            rdbtnEasy.Location = new Point(33, 57);
            rdbtnEasy.Name = "rdbtnEasy";
            rdbtnEasy.Size = new Size(72, 29);
            rdbtnEasy.TabIndex = 1;
            rdbtnEasy.TabStop = true;
            rdbtnEasy.Text = "Easy";
            rdbtnEasy.UseVisualStyleBackColor = true;
            rdbtnEasy.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 12);
            label1.Name = "label1";
            label1.Size = new Size(221, 29);
            label1.TabIndex = 0;
            label1.Text = "Difficult level:";
            label1.Click += label1_Click_1;
            // 
            // pnBgListView
            // 
            pnBgListView.BackColor = Color.DimGray;
            pnBgListView.Controls.Add(label3);
            pnBgListView.Controls.Add(label2);
            pnBgListView.Controls.Add(dataGridView1);
            pnBgListView.Enabled = false;
            pnBgListView.Location = new Point(181, 434);
            pnBgListView.Name = "pnBgListView";
            pnBgListView.Size = new Size(346, 557);
            pnBgListView.TabIndex = 8;
            pnBgListView.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 210, 81);
            label3.Location = new Point(38, 17);
            label3.Name = "label3";
            label3.Size = new Size(41, 47);
            label3.TabIndex = 1;
            label3.Text = "#";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 210, 81);
            label2.Location = new Point(125, 17);
            label2.Name = "label2";
            label2.Size = new Size(167, 47);
            label2.TabIndex = 1;
            label2.Text = "Ranking";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 210, 81);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(255, 192, 128);
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 210, 81);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(346, 477);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dbJoltzisBindingSource
            // 
            dbJoltzisBindingSource.DataSource = typeof(DbJoltzis);
            // 
            // formStartMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.BACKGROUN2;
            ClientSize = new Size(793, 1001);
            Controls.Add(pnBgListView);
            Controls.Add(panelConfig);
            Controls.Add(lbMenuWarning);
            Controls.Add(lbMenu1);
            Controls.Add(txtbPlayerName);
            Controls.Add(btnConfig);
            Controls.Add(btnRank);
            Controls.Add(btnPlay);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formStartMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JOLTZIS";
            Load += StartMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelConfig.ResumeLayout(false);
            panelConfig.PerformLayout();
            pnBgListView.ResumeLayout(false);
            pnBgListView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbJoltzisBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPlay;
        private Button btnRank;
        private Button btnConfig;
        private TextBox txtbPlayerName;
        private Label lbMenu1;
        private Label lbMenuWarning;
        private Panel panelConfig;
        private RadioButton rdbtnHard;
        private RadioButton rdbtnNormal;
        private RadioButton rdbtnEasy;
        private Label label1;
        private Panel pnBgListView;
        private DataGridView dataGridView1;
        private BindingSource dbJoltzisBindingSource;
        private Label label2;
        private Label label3;
    }
}