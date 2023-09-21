namespace Joltzis {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            panelPause = new PictureBox();
            pbNextBlock = new PictureBox();
            btnExit = new Button();
            btnResume = new Button();
            label3 = new Label();
            lbPause = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelPause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNextBlock).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 1000);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo_joltzis;
            pictureBox2.Location = new Point(510, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 103);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(569, 222);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 2;
            label1.Text = "Score:   0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(564, 283);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 3;
            label2.Text = "Next block:";
            label2.Click += label2_Click;
            // 
            // panelPause
            // 
            panelPause.Enabled = false;
            panelPause.Image = Properties.Resources.BACKGROUN2;
            panelPause.Location = new Point(3, 0);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(793, 1000);
            panelPause.TabIndex = 5;
            panelPause.TabStop = false;
            panelPause.Visible = false;
            panelPause.Click += panelPause_Click;
            // 
            // pbNextBlock
            // 
            pbNextBlock.Location = new Point(550, 332);
            pbNextBlock.Name = "pbNextBlock";
            pbNextBlock.Size = new Size(215, 198);
            pbNextBlock.TabIndex = 9;
            pbNextBlock.TabStop = false;
            pbNextBlock.Click += pbNextBlock_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Enabled = false;
            btnExit.Font = new Font("Cascadia Mono SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(261, 799);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(286, 74);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit to menu";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnResume
            // 
            btnResume.BackColor = Color.Teal;
            btnResume.Enabled = false;
            btnResume.Font = new Font("Cascadia Code SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnResume.ForeColor = Color.White;
            btnResume.Location = new Point(262, 702);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(286, 74);
            btnResume.TabIndex = 10;
            btnResume.Text = "Resume";
            btnResume.UseVisualStyleBackColor = false;
            btnResume.Visible = false;
            btnResume.Click += btnResume_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(583, 913);
            label3.Name = "label3";
            label3.Size = new Size(182, 64);
            label3.TabIndex = 14;
            label3.Text = "Press 'Esc' \r\nto pause";
            // 
            // lbPause
            // 
            lbPause.AutoSize = true;
            lbPause.BackColor = Color.Transparent;
            lbPause.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbPause.Location = new Point(280, 332);
            lbPause.Name = "lbPause";
            lbPause.Size = new Size(250, 95);
            lbPause.TabIndex = 15;
            lbPause.Text = "Pause";
            lbPause.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 1001);
            Controls.Add(lbPause);
            Controls.Add(btnExit);
            Controls.Add(btnResume);
            Controls.Add(panelPause);
            Controls.Add(pbNextBlock);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JOLTZIS";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelPause).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNextBlock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private BindingSource bindingSource1;
        private Label label2;
        private PictureBox panelPause;
        private PictureBox pbNextBlock;
        private Button btnExit;
        private Button btnResume;
        private Label label3;
        private Label lbPause;
        public string txtPlayerName;

    }
}