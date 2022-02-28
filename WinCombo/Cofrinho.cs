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
    public partial class Cofrinho : Form
    {
        Save sv = new Save();
        public Cofrinho()
        {
            InitializeComponent();
        }

        private void Cofrinho_Load(object sender, EventArgs e)
        {
            sv.LoadIni();
            loadV();
            MetaPro();
            valorAdd.Text = "Saldo";
            valorAdd.ForeColor = Color.Gray;
            boxMeta.Text = "Meta";
            boxMeta.ForeColor = Color.Gray;
           
        }

        private double CounterValor()
        {
        double valor = 0.00;
        Data db = new Data();
        try
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT valor From `cofrinho` WHERE `usuario` = '{sv.User}'", db.GetMySqlConnection());
            db.conn.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                valor = Convert.ToDouble(read["valor"].ToString());
            }
            db.conn.Close();
            return valor;
        }
        catch
        {
            db.conn.Close();
            return valor;

            }
        }
        private void loadV()
        {
            labelValor.Text = CounterValor().ToString("C");
            valorDel.Text = CounterValor().ToString("C");
            valormeta.Text = CofrinhoMeta().ToString("C");
        }

        private void MetaPro()
        {

                barmeta.Maximum = Convert.ToInt32(CofrinhoMeta());
                barmeta.Value = Convert.ToInt32(CounterValor());
        
               
        }
        private double CofrinhoMeta()
        {
            double valor = 0.00;
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT meta FROM `cofrinho` WHERE `usuario` = '{sv.User}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = Convert.ToDouble(read["meta"].ToString());

                }
                db.conn.Close();
                return valor;
            }
            catch
            {
                db.conn.Close();
                return valor;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `cofrinho`( `usuario`, `valor`, `meta`) VALUES ('{sv.User}','0', @meta)", db.GetMySqlConnection());
                cmd.Parameters.Add("@meta", MySqlDbType.VarChar).Value = boxMeta.Text;
                db.conn.Open();
                if (IsInteger(double.Parse(boxMeta.Text)))
                {
                    if (!CheckBox1())
                    {
                        if (!Fatorador1())
                        {
                            if (checkName())
                            {
                                MessageBox.Show("Já existe um cofrinho na sua conta, delete para criar outro.", "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else
                            {

                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    loadV();
                                    MetaPro();
                                    MessageBox.Show("Cofrinho criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show($"{sv.Nome} Você não pode usar numeros quebrados, apenas numeros inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.conn.Close();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.conn.Close();
            }

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"UPDATE cofrinho SET `valor` = '{Convert.ToDouble(valorAdd.Text) + GetValor(sv.User)}' WHERE `usuario` = '{sv.User}'", db.GetMySqlConnection());

                db.conn.Open();
                if (Convert.ToDouble(valorAdd.Text) + GetValor(sv.User) <= CofrinhoMeta())
                {
                    if (!CheckBox2())
                    {
                        if (!Fatorador2())
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {

                                loadV();
                                MetaPro();
                                MessageBox.Show("Valor adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show($"{sv.Nome} não é possível incluir esse valor pois ira passar do valor da meta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                db.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckBox1()
        {
            try
            {
                
                string meta = boxMeta.Text;
                if (meta.Equals("") || meta.Equals("Meta"))
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
        
        private bool CheckBox2()
        {
            try
            {

                string valor = valorAdd.Text;
                if (valor.Equals("") || valor.Equals("Valor"))
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
            boxMeta.Clear();
            valorAdd.Clear();
        }

        public bool IsInteger(double d)
        {
            if (d == (int)d) return true;
            else return false;
        }
        private bool checkName()
        {
            Data db = new Data();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `cofrinho` WHERE `usuario` = @nome", db.GetMySqlConnection());

            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = sv.User;

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

        private bool Fatorador1()
        {
            string refatorador = boxMeta.Text.ToLower();
            char[] re = { '.', ',', '-', '=', '/', '*', '&', '^', '%', '$', '#', '@', '!', '{', '}', '[', ']', '+', '<', '>', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            if (refatorador.Trim(re).Equals(""))
            {
                MessageBox.Show("Insira um valor correto!", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxMeta.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool Fatorador2()
        {
            string refatorador = valorAdd.Text.ToLower();
            char[] re = { '.', ',', '-', '=', '/', '*', '&', '^', '%', '$', '#', '@', '!', '{', '}', '[', ']', '+', '<', '>', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            if (refatorador.Trim(re).Equals(""))
            {
                MessageBox.Show("Insira um valor correto!", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxMeta.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void boxMeta_MouseEnter(object sender, EventArgs e)
        {
            boxMeta.Text = String.Empty;
        }

        private void valorAdd_MouseEnter(object sender, EventArgs e)
        {
           valorAdd.Text = String.Empty;
        }

        private void boxMeta_MouseClick(object sender, MouseEventArgs e)
        {
            boxMeta.ForeColor = Color.Black;
        }

        private void valorAdd_MouseClick(object sender, MouseEventArgs e)
        {
            valorAdd.ForeColor = Color.Black;
        }
        private double GetValor(string nome)
        {
            double valor = 0.00;
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT valor From `cofrinho` WHERE `usuario` = '{nome}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = Convert.ToDouble(read["valor"].ToString());
                }
                db.conn.Close();
                return valor;
            }
            catch
            {
                db.conn.Close();
                return valor;

            }
        }
       

        private void btnRetirada_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {

                if (MessageBox.Show($"{sv.Nome} Voce deseja mesmo excluir?", "AVISO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.conn.Open();
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM `cofrinho` WHERE `usuario` = '{sv.User}'", db.GetMySqlConnection());
                    cmd.ExecuteNonQuery();
                    loadV();
                    MetaPro();

                    db.conn.Close();
                }
            }
            catch
            {
                MessageBox.Show($"Ocorreu um problema, tente denovo mais tarde.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}

