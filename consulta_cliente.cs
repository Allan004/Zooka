using MySql.Data.MySqlClient;
using SisVendas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooka
{
    class consulta_cliente
    {

        public DataTable Verificarcpf(string padrao)
        {
            string defi = padrao;
            string sql =  "SELECT * FROM cliente WHERE cpf_cliente Like @cpf";
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@cpf", $"%{defi}%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }




        }
    }
}
