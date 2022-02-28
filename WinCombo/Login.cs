using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinCombo.Src;

namespace WinCombo
{
    public partial class Login : Form
    {
        Form1 fm = new Form1();
        Save sv = new Save();
        public Login()
        {
            InitializeComponent();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {
              
                if (CheckConnection())
                {
                    string user = nomebox.Text;
                    string senha = senhabox.Text;
                    string check = checkinfo.Checked.ToString();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `usuario` = @usn and `senha` = @sn", db.GetMySqlConnection());
                    cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user;
                    cmd.Parameters.Add("@sn", MySqlDbType.VarChar).Value = senha;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                        sv.GetUser(user, check);
                        fm.ShowDialog();
                        db.conn.Close();
                    }
                    else
                    {

                        if (user.Trim().Equals(""))
                        {
                            MessageBox.Show("Insira o nome de usuario!", "Usuario em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        else if (senha.Trim().Equals(""))
                        {
                            MessageBox.Show("Insira sua senha!", "Senha em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        else
                        {
                            MessageBox.Show("Usuario ou senha incorretos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Problemas de Conexão", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            } catch (Exception ex)
            {
                db.conn.Close();
                MessageBox.Show(ex.ToString());
            }


        }

        private void exitlogin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CheckInfo()
        {
            bool verificador = bool.Parse(sv.Check);
            if (verificador)
            {
                nomebox.Text = sv.User;
                checkinfo.Checked = true;
            }
            else
            {
                nomebox.Text = "";
                checkinfo.Checked = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sv.LoadIni();
            CheckInfo();
        }

        private bool CheckConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/"))
                    return true;
            }
            catch
            {
                return false;
                
            }
        }
    }
}
