using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            CarregarCombos();

        }
        private void CarregarCombos()
        {

            cxDia.Items.Clear();
            cxMes.Items.Clear();
            cxAno.Items.Clear();

            // Dias (1 a 31)
            for (int d = 1; d <= 31; d++)
            {
                cxDia.Items.Add(d.ToString());
            }


            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                               "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            cxMes.Items.AddRange(meses);


            for (int a = 1900; a <= DateTime.Now.Year; a++)
            {
                cxAno.Items.Add(a.ToString());
            }


            if (cxDia.Items.Count > 0) cxDia.SelectedIndex = 0;
            if (cxMes.Items.Count > 0) cxMes.SelectedIndex = 0;
            if (cxAno.Items.Count > 0) cxAno.SelectedIndex = cxAno.Items.Count - 1;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            string dia = cxDia.SelectedItem?.ToString();
            string mes = cxMes.SelectedItem?.ToString();
            string ano = cxAno.SelectedItem?.ToString();

            string genero = "";
            if (GeneroF.Checked) genero = "Feminino";
            else if (GeneroM.Checked) genero = "Masculino";
            else if (Outro.Checked) genero = "Outro";


            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha) ||
                string.IsNullOrEmpty(dia) || string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(ano) ||
                string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show(
                $"Nome: {nome}\n" +
                $"Email: {email}\n" +
                $"Senha: {senha}\n" +
                $"Data Nasc: {dia}/{mes}/{ano}\n" +
                $"Gênero: {genero}",
                "Cadastro concluído");

        }
    }
}
