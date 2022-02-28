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
using System.Drawing.Drawing2D;

namespace WinCombo
{

    public partial class Conta : Form
    {
        Save sv = new Save();
        public Conta()
        {
            InitializeComponent();
        }

       
        private void UserInfo()
        {
            userText.Text = sv.Nome;
            sobretext.Text = sv.Sobrenome;
            userLabel.Text = sv.User;
            LoadMysq();
            circleEdit.Load(sv.Pic);
            CirclePic.Load(sv.Pic);
        }

        private void LoadMysq()
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT email, empresa, reg_date FROM `users` WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                db.conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbEmail.Text = reader["email"].ToString();
                    lbEmpresa.Text = reader["empresa"].ToString();
                    lbDate.Text = reader["reg_date"].ToString();
                }
                db.conn.Close();
            }
            catch
            {
                db.conn.Close();
                MessageBox.Show("Falha ao obter os dados da conta, tente novamente mais tarde", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void Conta_Load(object sender, EventArgs e)
        {
            sv.LoadIni();
            UserInfo();
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {
                if (MessageBox.Show($"{sv.Nome} você deseja mesmo excluir sua conta?", "AVISO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE * FROM `users` WHERE `usuario` = @user", db.GetMySqlConnection());
                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                    db.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sua conta foi excluida, obrigado por usar o Combo!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login lg = new Login();
                    lg.ShowDialog();
                }
                db.conn.Close();
            }
            catch
            {
                db.conn.Close();
                MessageBox.Show("Algo deu errado, tente novamente mais tarde.", "OPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckBoxeUs()
        {
            try
            {
                string nome = userBox.Text;
                if (nome.Equals(""))
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
        private bool CheckBoxeEm()
        {
            try
            {
                string email = mailBox.Text;
                if (email.Equals(""))
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
            userBox.Clear();
            empresaBox.Clear();
            mailBox.Clear();
            picBox.Clear();
            boxSenha.Clear();
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {

            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET `usuario` = @nome WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = userBox.Text;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                db.conn.Open();
                if (!CheckBoxeUs())
                {
                    if (checkName())
                    {
                        MessageBox.Show("Já existe uma conta com esse usuário, escolha outro.", "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            sv.GetUser(userBox.Text, sv.Check);
                            UCofrinho(userBox.Text);
                            UFatura(userBox.Text);
                            UServicos(userBox.Text);
                            sv.LoadIni();
                            MessageBox.Show("Usuário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CleanBoxes();
                            UserInfo();
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
            catch
            {

            }
        }

        private bool checkName()
        {
            Data db = new Data();
            bool valor = false;
            try
            {

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `usuario` = @user",db.GetMySqlConnection());
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = userBox.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    valor = true;
                }
                return valor;
                db.conn.Close();
            }
            catch
            {
                db.conn.Close();
                return false;
            }
        }

        private bool checkEmail()
        {
            Data db = new Data();
            bool valor = false;
            try
            {

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @email", db.GetMySqlConnection());
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = mailBox.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    valor = true;
                }
                return valor;
                db.conn.Close();
            }
            catch
            {
                db.conn.Close();
                return false;
            }
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET `email` = @email WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = mailBox.Text;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                db.conn.Open();
                if (!CheckBoxeEm())
                {
                    if (checkEmail())
                    {
                        MessageBox.Show("Já existe uma conta com esse email, escolha outro.", "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            sv.GetUser(sv.User, sv.Check);
                            sv.LoadIni();
                            MessageBox.Show("Email alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CleanBoxes();
                            UserInfo();
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
            catch
            {

            }
        }

        private bool CheckBoxSenha()
        {
            string senha = boxSenha.Text;
            if (senha.Equals(""))
            {
                return true;
            } else
            {
                return false;
            }
        }
        private bool CheckBoxEmpresa()
        {
            string empresa = empresaBox.Text;
            if (empresa.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckBoxPic()
        {
            string pic = picBox.Text;
            if (pic.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET `empresa` = @empresa WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@empresa", MySqlDbType.VarChar).Value = empresaBox.Text;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                db.conn.Open();
                if (!CheckBoxEmpresa())
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        sv.GetUser(sv.User, sv.Check);
                        sv.LoadIni();
                        MessageBox.Show("Empresa alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanBoxes();
                        UserInfo();
                        db.conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("Algo deu errado revise os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.conn.Close();
                }
            }
            catch
            {

            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET `img` = @img WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@img", MySqlDbType.VarChar).Value = picBox.Text;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                db.conn.Open();
                if (!CheckBoxPic())
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        sv.GetUser(sv.User, sv.Check);
                        sv.LoadIni();
                        MessageBox.Show("Imagem alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanBoxes();
                        UserInfo();
                        db.conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("Algo deu errado revise os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.conn.Close();
                }
            }
            catch
            {

            }
        }

        private void UCofrinho(string nome)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE cofrinho SET `usuario` = @usn WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                db.conn.Open();
                cmd.ExecuteNonQuery();
                db.conn.Close();

            }
            catch
            {

            }
        }
        private void UFatura(string nome)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE faturas SET `usuario` = @usn WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                db.conn.Open();
                cmd.ExecuteNonQuery();
                db.conn.Close();

            }
            catch
            {

            }
        }

        private void UServicos(string nome)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE servicos SET `usuario` = @usn WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;
                db.conn.Open();
                cmd.ExecuteNonQuery();
                db.conn.Close();

            }
            catch
            {

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET `senha` = @senha WHERE `usuario` = @user", db.GetMySqlConnection());
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = boxSenha.Text;
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = sv.User;

                db.conn.Open();
                if (!CheckBoxSenha())
                {
                    
                  
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            
                            MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CleanBoxes();
                            db.conn.Close();

                        }
                        else
                        {
                            MessageBox.Show("Algo deu errado revise os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            db.conn.Close();
                        }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.conn.Close();
                }
            }
            catch
            {
                db.conn.Close();
                MessageBox.Show("Ocorreu um erro , tente mais tarde!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
        }
    }
