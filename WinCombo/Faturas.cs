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
using SautinSoft.Document;
using SautinSoft;
using System.IO;

namespace WinCombo
{
    public partial class Faturas : Form
    {
        Save sv = new Save();
        public Faturas()
        {
            InitializeComponent();

        }

        public void LoadGrid(string nome)
        {
            Data db = new Data();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                db.conn.Open();
                adapter.SelectCommand = new MySqlCommand($"SELECT * FROM `faturas` WHERE `usuario` = '{nome}'", db.GetMySqlConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;

                datagridf.DataSource = bsource;

                this.datagridf.Columns[0].Visible = false;
                this.datagridf.Columns[2].Visible = false;
                this.datagridf.Columns[6].Visible = false;
                datagridf.Columns[1].Width = 200;
                datagridf.Columns[3].Width = 200;
                datagridf.Columns[4].Width = 200;
                datagridf.Columns[5].Width = 250;
                datagridf.Columns[1].HeaderText = "Fatura";
                datagridf.Columns[3].HeaderText = "Valor";
                datagridf.Columns[4].HeaderText = "Mês/Ano";
                datagridf.Columns[5].HeaderText = "Descrição";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void Faturas_Load(object sender, EventArgs e)
        {

            sv.LoadIni();
            LoadFormAdd();
            LoadGrid(sv.User);
            LoadPanels();
            LoadMSearch();



        }



        private double GetTotalAtual()
        {
            Data db = new Data();
            double valor = 0.00;

            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT SUM(valor) AS vTotal FROM `faturas` WHERE `usuario` = '{sv.User}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = Convert.ToDouble(read["vTotal"].ToString());

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
        private double GetTotalFAtual()
        {
            Data db = new Data();
            int valor = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) AS vTotal FROM `faturas` WHERE `usuario` = '{sv.User}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = int.Parse(read["vTotal"].ToString());

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
        private double GetTotalAno()
        {
            Data db = new Data();
            double valor = 0.00;

            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT SUM(valor) AS vTotal FROM `faturas` WHERE `usuario` = '{sv.User}' and `ano` = '{DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = Convert.ToDouble(read["vTotal"].ToString());

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
        private double GetTotalAnoF()
        {
            Data db = new Data();
            int valor = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) AS vTotal FROM `faturas` WHERE `usuario` = '{sv.User}' and `ano` = '{DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = int.Parse(read["vTotal"].ToString());

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
        public void LoadPanels()
        {
            try
            {
                ValorTotal.Text = GetTotalAtual().ToString("C");
                valorTotalF.Text = GetTotalFAtual().ToString();
                GastoTAno.Text = GetTotalAno().ToString("C");
                string ano = labelano.Text;
                ano = ano.Replace("ano", DateTime.Now.Year.ToString());
                labelano.Text = ano;
                string anof = FTotalAno.Text;
                anof = anof.Replace("ano", DateTime.Now.Year.ToString());
                FTotalAno.Text = anof;
                Fano.Text = GetTotalAnoF().ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnEditF_Click(object sender, EventArgs e)
        {
            EditF editf = new EditF(this);
            editf.TopLevel = false;
            editf.TopMost = true;
            editf.FormBorderStyle = FormBorderStyle.None;
            editf.Dock = DockStyle.Fill;
            panelAddF.Controls.Add(editf);
            editf.BringToFront();
            editf.Show();

        }

        private void btnPannelF_Click(object sender, EventArgs e)
        {
            LoadFormAdd();
        }

        private void LoadFormAdd()
        {
            AddF addF = new AddF(this);
            addF.TopLevel = false;
            addF.TopMost = true;
            addF.FormBorderStyle = FormBorderStyle.None;
            addF.Dock = DockStyle.Fill;
            panelAddF.Controls.Add(addF);
            addF.BringToFront();
            addF.Show();
        }

        private void LoadMSearch()
        {
            comboSearc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSearc.Items.Add("Todos");
            comboSearc.Items.Add("Janeiro");
            comboSearc.Items.Add("Fevereiro");
            comboSearc.Items.Add("Março");
            comboSearc.Items.Add("Abril");
            comboSearc.Items.Add("Maio");
            comboSearc.Items.Add("Junho");
            comboSearc.Items.Add("Julho");
            comboSearc.Items.Add("Agosto");
            comboSearc.Items.Add("Outubro");
            comboSearc.Items.Add("Novembro");
            comboSearc.Items.Add("Dezembro");
            comboSearc.SelectedIndex = 0;

        }
        private void GridSearch(int mont)
        {

            Data db = new Data();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                db.conn.Open();
                adapter.SelectCommand = new MySqlCommand($"SELECT * FROM `faturas` WHERE `usuario` = '{sv.User}' AND `vencimento` = '{mont}-{DateTime.Now.Year}'", db.GetMySqlConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;

                datagridf.DataSource = bsource;

                this.datagridf.Columns[0].Visible = false;
                this.datagridf.Columns[2].Visible = false;
                this.datagridf.Columns[6].Visible = false;
                datagridf.Columns[1].Width = 200;
                datagridf.Columns[3].Width = 200;
                datagridf.Columns[4].Width = 200;
                datagridf.Columns[5].Width = 250;
                datagridf.Columns[1].HeaderText = "Fatura";
                datagridf.Columns[3].HeaderText = "Valor";
                datagridf.Columns[4].HeaderText = "Mês/Ano";
                datagridf.Columns[5].HeaderText = "Descrição";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            switch (comboSearc.SelectedIndex)
            {
                case 0:
                    LoadGrid(sv.User);
                    break;
                case 1:
                    GridSearch(1);
                    break;
                case 2:
                    GridSearch(2);
                    break;
                case 3:
                    GridSearch(3);
                    break;
                case 4:
                    GridSearch(4);
                    break;
                case 5:
                    GridSearch(5);
                    break;
                case 6:
                    GridSearch(6);
                    break;
                case 7:
                    GridSearch(7);
                    break;
                case 8:
                    GridSearch(8);
                    break;
                case 9:
                    GridSearch(9);
                    break;
                case 10:
                    GridSearch(10);
                    break;
                case 12:
                    GridSearch(11);
                    break;
                case 13:
                    GridSearch(12);
                    break;
            }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            try
            {

                if (MessageBox.Show($"{sv.Nome} você deseja mesmo excluir?", "AVISO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        db.conn.Open();
                        DataRow row = (datagridf.SelectedRows[0].DataBoundItem as DataRowView).Row;
                        MySqlCommand cmd = new MySqlCommand($"DELETE FROM `faturas` WHERE ID = {row["id"]} AND usuario = '{sv.User}'", db.GetMySqlConnection());
                    cmd.ExecuteNonQuery();
                        LoadGrid(sv.User);
                        LoadPanels();

                    db.conn.Close();
                }
            }
            catch
            {
                MessageBox.Show($"{sv.Nome} você deve clicar na seta para selecionar a coluna inteira e efetuar a exclusão!","Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentCore dc = new DocumentCore();
                dc.Content.End.Insert("Relatório de Faturas \n", new CharacterFormat() { FontName = "Verdana", Size = 45.5f, UnderlineStyle = UnderlineType.Single });

                dc.Content.End.Insert($" \nTotal de gastos até o momento:{GetTotalAtual().ToString("C")}   \nGastos de {DateTime.Now.Year}: {GetTotalAno().ToString("C")}  \nTotal de faturas até o momento: {GetTotalAnoF().ToString()} \nTotal de fatuas de {DateTime.Now.Year}: {GetTotalFAtual().ToString()}", new CharacterFormat() { FontName = "Verdana", Size = 20.5f });
                dc.Content.End.Insert("\nRelatório do mês\n", new CharacterFormat() { FontName = "Verdana", Size = 45.5f, UnderlineStyle = UnderlineType.Single });
                dc.Content.End.Insert($" \nFaturas do mês:{FaturasMes().ToString()}   \nGastos do mês: {Gastos().ToString("C")}", new CharacterFormat() { FontName = "Verdana", Size = 20.5f });
                dc.Save(@"pdf\fatura.pdf");
                MessageBox.Show("Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\pdf\fatura.pdf");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private int FaturasMes()
        {
            int valor = 0;
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) AS vTotal FROM `faturas` WHERE `usuario` = '{sv.User}' AND `vencimento` = '{DateTime.Now.Month + "-" + DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = int.Parse(read["vTotal"].ToString());

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
        private double Gastos()
        {
            double valor = 0.00;
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT SUM(valor) AS vTotal FROM `faturas` WHERE `usuario` = '{sv.User}' AND `vencimento` = '{DateTime.Now.Month + "-" + DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = Convert.ToDouble(read["vTotal"].ToString());

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
    }

}
