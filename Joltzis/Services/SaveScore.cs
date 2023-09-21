using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joltzis {
    public class SaveScore {
        DbJoltzis Connection = new();
        SqlCommand cmd = new();

        public string InsertSQL = "INSERT INTO dbo.tb_JogadorScore(nomeJogador, scoreJogador) VALUES" +
                                "(@nomeJogador,@scoreJogador)";
        public string SqlMessage = string.Empty;


        public SaveScore(string nomeJogador, int scoreJogador) {
            cmd.CommandText = InsertSQL;

            cmd.Parameters.AddWithValue("@nomeJogador", nomeJogador);
            cmd.Parameters.AddWithValue("@scoreJogador", scoreJogador);

            try {
                cmd.Connection = Connection.OpenConection();
                cmd.ExecuteNonQuery();
                Connection.CloseConnection();
            } catch (SqlException error) {
                SqlMessage = "Erro: " + error;
            }
        }

    }
}
