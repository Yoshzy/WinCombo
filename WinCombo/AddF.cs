using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinCombo.Src;
using MySql.Data.MySqlClient;

namespace WinCombo
{
    public partial class AddF : Form
    {
        Save sv = new Save();
        private Faturas _faturas;
        public AddF(Faturas faturas)
        {
            InitializeComponent();
            _faturas = faturas;
        }
        private void AddF_Load(object sender, EventArgs e)
        {
            
            sv.LoadIni();
            LoadCombo();
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (comboFMes.SelectedIndex)
            {
                case 0:
                    CreateF(1);
                    break;
                case 1:
                    CreateF(2);
                    break;
                case 2:
                    CreateF(3);
                    break;
                case 3:
                    CreateF(4);
                    break;
                case 4:
                    CreateF(5);
                    break;
                case 5:
                    CreateF(6);
                    break;
                case 6:
                    CreateF(7);
                    break;
                case 7:
                    CreateF(8);
                    break;
                case 8:
                    CreateF(9);
                    break;
                case 9:
                    CreateF(10);
                    break;
                case 10:
                    CreateF(11);
                    break;
                case 11:
                    CreateF(12);
                    break;
                default:
                    MessageBox.Show("Data invalida!");
                    break;

            }
        }

        private void CreateF(int month)
        {
            Data db = new Data();
            Faturas ft = new Faturas();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `faturas`(`nome`, `usuario`, `valor`, `vencimento`, `info`, `ano`) VALUES (@nome, @user, @valor, @vencimento, @info, {DateTime.Now.Year})", db.GetMySqlConnection());
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = fNomeBox.Text;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                cmd.Parameters.Add("@valor", MySqlDbType.VarChar).Value = valorFBox.Text;
                cmd.Parameters.Add("@vencimento", MySqlDbType.VarChar).Value = $"{month}-{DateTime.Now.Year}";
                cmd.Parameters.Add("@info", MySqlDbType.VarChar).Value = DescBox.Text;
                db.conn.Open();

                if (!CheckBoxes())
                {
                    if (!Fatorador())
                    {
                        if (checkName(month))
                        {
                            MessageBox.Show("Já existe uma fatura com esse nome neste mês, escolha outro.", "Fatura Duplicada", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                _faturas.LoadGrid(sv.User);
                                _faturas.LoadPanels();
                                MessageBox.Show("Fatura adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CleanBoxes();
                                db.conn.Close();

                            }
                            else
                            {
                                MessageBox.Show("Algo deu errado revise os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                db.conn.Close();
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.conn.Close();
            }
        }
        private void LoadCombo()
        {

            try
            {
                comboFMes.DropDownStyle = ComboBoxStyle.DropDownList;
                comboFMes.Items.Add("Janeiro");
                comboFMes.Items.Add("Fevereiro");
                comboFMes.Items.Add("Março");
                comboFMes.Items.Add("Abril");
                comboFMes.Items.Add("Maio");
                comboFMes.Items.Add("Junho");
                comboFMes.Items.Add("Julho");
                comboFMes.Items.Add("Agosto");
                comboFMes.Items.Add("Setembro");
                comboFMes.Items.Add("Outubro");
                comboFMes.Items.Add("Novembro");
                comboFMes.Items.Add("Dezembro");
                comboFMes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckBoxes()
        {
            try
            {
                string nome = fNomeBox.Text;
                string valor = valorFBox.Text;
                string desc = DescBox.Text;
                if (nome.Equals("") || valor.Equals("") || desc.Equals(""))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return false;
        }
        private void CleanBoxes()
        {
            fNomeBox.Clear();
            valorFBox.Clear();
            DescBox.Clear();
        }


        private bool checkName(int month)
        {
            Data db = new Data();

            string nome = fNomeBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `faturas` WHERE `nome` = @nome AND `usuario` = '{sv.User}' AND `vencimento` = '{month}-{DateTime.Now.Year}'", db.GetMySqlConnection());

            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Fatorador()
        {
            string refatorador = valorFBox.Text.ToLower();
            char[] re = { '.', ',', '-', '=', '/', '*', '&', '^', '%', '$', '#', '@', '!', '{', '}', '[', ']', '+', '<', '>', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            if (refatorador.Trim(re).Equals(""))
            {
                MessageBox.Show("Insira um valor correto!", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorFBox.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
