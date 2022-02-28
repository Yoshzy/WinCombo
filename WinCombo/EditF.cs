using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinCombo.Src;

namespace WinCombo
{
    public partial class EditF : Form
    {
        Faturas _faturas;
        Save sv = new Save();
        string Token = string.Empty;
        public EditF(Faturas faturas)
        {
            InitializeComponent();
            _faturas = faturas;
        }

        private void LoadMes()
        {
            comboFMes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFatura.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFMes.Items.Add("Janeiro");
            comboFMes.Items.Add("Fevereiro");
            comboFMes.Items.Add("Março");
            comboFMes.Items.Add("Abril");
            comboFMes.Items.Add("Maio");
            comboFMes.Items.Add("Junho");
            comboFMes.Items.Add("Julho");
            comboFMes.Items.Add("Agosto");
            comboFMes.Items.Add("Outubro");
            comboFMes.Items.Add("Novembro");
            comboFMes.Items.Add("Dezembro");
            comboFMes.SelectedIndex = 0;

        }

        private void EditF_Load(object sender, EventArgs e)
        {
            LoadMes();
            sv.LoadIni();
        }

        private void SelectFatura(int num)
        {
            try
            {

                comboFatura.Items.Clear();
                comboFatura.Refresh();
                Data db = new Data();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `faturas` WHERE `usuario` = '{sv.User}' AND `vencimento` = '{num}-{DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    comboFatura.Items.Add(rd["nome"].ToString());
                    
                }
                db.conn.Close();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            switch (comboFMes.SelectedIndex)
            {
                case 0:
                    SelectFatura(1);
                    break;
                case 1:
                    SelectFatura(2);
                    break;
                case 2:
                    SelectFatura(3);
                    break;
                case 3:
                    SelectFatura(4);
                    break;
                case 4:
                    SelectFatura(5);
                    break;
                case 5:
                    SelectFatura(6);
                    break;
                case 6:
                    SelectFatura(7);
                    break;
                case 7:
                    SelectFatura(8);
                    break;
                case 8:
                    SelectFatura(9);
                    break;
                case 9:
                    SelectFatura(10);
                    break;
                case 10:
                    SelectFatura(11);
                    break;
                case 11:
                    SelectFatura(12);
                    break;
                default:
                    MessageBox.Show("Valor Invalido!", "Ops", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (comboFMes.SelectedIndex)
            {
                case 0:
                    InsertData(1);
                    break;
                case 1:
                    InsertData(2);
                    break;
                case 2:
                    InsertData(3);
                    break;
                case 3:
                    InsertData(4);
                    break;
                case 4:
                    InsertData(5);
                    break;
                case 5:
                    InsertData(6);
                    break;
                case 6:
                    InsertData(7);
                    break;
                case 7:
                    InsertData(8);
                    break;
                case 8:
                    InsertData(9);
                    break;
                case 9:
                    InsertData(10);
                    break;
                case 10:
                    InsertData(11);
                    break;
                case 11:
                    InsertData(12);
                    break;
                default:
                    MessageBox.Show("Valor Invalido!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void InsertData(int month)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"UPDATE faturas SET `nome` = @nome, `valor` = @valor, `info` = @desc WHERE `usuario` = '{sv.User}' AND `nome` =  '{this.comboFatura.GetItemText(this.comboFatura.SelectedItem)}' AND `vencimento` = '{month}-{DateTime.Now.Year}'", db.GetMySqlConnection());
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = fNomeBox.Text;
                cmd.Parameters.Add("@valor", MySqlDbType.VarChar).Value = valorFBox.Text;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = DescBox.Text;

                db.conn.Open();


                if (!CheckBoxes())
                {
                    if (!Fatorador())
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {

                            _faturas.LoadGrid(sv.User);
                            _faturas.LoadPanels();
                            MessageBox.Show("Fatura Editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.conn.Close();
                }
            }
            catch (Exception ex)
            {
                db.conn.Close();
                MessageBox.Show(ex.Message);
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
