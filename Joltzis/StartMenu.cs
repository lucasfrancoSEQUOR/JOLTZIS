using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joltzis {

    public partial class StartMenu : Form {

        int difficultModifierInterval;

        public StartMenu() {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void btnPlay_Click(object sender, EventArgs e) {
            if (rdbtnEasy.Checked) { difficultModifierInterval = 500; }
            if (rdbtnNormal.Checked) { difficultModifierInterval = 300; }
            if (rdbtnHard.Checked) { difficultModifierInterval = 180; }

            if (txtbPlayerName.Text == "") {
                lbMenuWarning.Visible = true;
            } else {
                Form1 janela_jogo = new Form1(difficultModifierInterval);
                janela_jogo.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void lbMenu1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }

        private void btnConfig_Click(object sender, EventArgs e) {
            if (panelConfig.Visible == true) {
                panelConfig.Visible = false;
                rdbtnEasy.Visible = false;
                rdbtnNormal.Visible = false;
                rdbtnHard.Visible = false;
            } else {
                panelConfig.Visible = true;
                rdbtnEasy.Visible = true;
                rdbtnNormal.Visible = true;
                rdbtnHard.Visible = true;
            }
        }
    }
}
