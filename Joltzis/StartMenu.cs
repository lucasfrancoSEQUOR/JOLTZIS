using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Joltzis {

    public partial class formStartMenu : Form {

        int difficultModifierInterval;
        string playerName;

        public formStartMenu() {
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

            playerName = txtbPlayerName.Text;

            if (txtbPlayerName.Text == "") {
                lbMenuWarning.Visible = true;
            } else {
                Form1 janela_jogo = new Form1(difficultModifierInterval, playerName);
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

        private void btnRank_Click(object sender, EventArgs e) {
            if (pnBgListView.Visible == true) {
                pnBgListView.Enabled = false;
                pnBgListView.Visible = false;
            } else {
                pnBgListView.Enabled = true;
                pnBgListView.Visible = true;
            }

            string myConnectionString = @"Data Source=SQO-106\MSSQLSERVER01;Initial Catalog=Joltzis;Integrated Security=True";

            string mySelectQuery = "SELECT TOP 10 nomeJogador, scoreJogador FROM dbo.tb_JogadorScore ORDER BY scoreJogador DESC";

            using (var connection = new SqlConnection(myConnectionString))
            using (var adapter = new SqlDataAdapter(mySelectQuery, connection)) {
                var table = new DataTable();
                adapter.Fill(table);
                this.dataGridView1.DataSource = table;
            }

            if (dataGridView1.Columns["scoreJogador"] != null)
                dataGridView1.Columns["scoreJogador"].HeaderText = "Score";
            if (dataGridView1.Columns["nomeJogador"] != null)
                dataGridView1.Columns["nomeJogador"].HeaderText = "Jogador";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
