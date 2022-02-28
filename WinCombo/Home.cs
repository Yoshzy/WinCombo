using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinCombo.Src;

namespace WinCombo
{
    public partial class Home : Form
    {
        Save sv = new Save();
        Form1 fm = new Form1();
        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            sv.LoadIni();
            ChartDespesa();
            ChartServicos();
            LoadPanels();

        }

        private double ConfrinhoSaldo()
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
            }catch
            {
                db.conn.Close();
                return valor;
               
               
                
            }
        }

        private int Faturas()
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

        private int Servicos()
        {
            int valor = 0;
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) AS sTotal FROM `servicos` WHERE `usuario` = '{sv.User}' AND `data` = '{DateTime.Now.Month + "-" + DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = int.Parse(read["sTotal"].ToString());

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
        private double Ganhos()
        {
            double valor = 0.00;
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT SUM(valor) AS gTotal FROM `servicos` WHERE `usuario` = '{sv.User}' AND `data` = '{DateTime.Now.Month + "-" + DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = Convert.ToDouble(read["gTotal"].ToString());

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


        private void timer1_Tick(object sender, EventArgs e)
        {
            data.Text = DateTime.Now.ToString();

            if (ConfrinhoSaldo() > 0 && ConfrinhoSaldo() == CofrinhoMeta())
            {
                
                    boxImg(Environment.CurrentDirectory + @"\Res\bank.png");
                    infodesc.Text = $"Parabéns {sv.Nome} você atingiu sua meta de {CofrinhoMeta().ToString("C")}! UHUL, Gaste com sabedoria.";

            }
            else
            {
                switch (DateTime.Now.Hour)
                {
                    case 00:
                    case 02:
                    case 03:
                    case 04:
                    case 05:
                        boxImg(Environment.CurrentDirectory + @"\Res\madruga.png");
                        infodesc.Text = $"Boa madrugada {sv.Nome} tudo bem com você?";
                        break;
                    case 06:
                    case 07:
                    case 08:
                    case 09:
                    case 10:
                    case 11:
                        boxImg(Environment.CurrentDirectory + @"\Res\alarme.png");
                        infodesc.Text = $"Bom dia {sv.Nome} tudo bem com você?";
                        break;
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                        boxImg(Environment.CurrentDirectory + @"\Res\praia.png");
                        infodesc.Text = $"Boa tarde {sv.Nome} tudo bem com você?";
                        break;
                    case 18:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                        boxImg(Environment.CurrentDirectory + @"\Res\noite.png");
                        infodesc.Text = $"Boa noite {sv.Nome} tudo bem com você?";
                        break;
                    default:
                        infodesc.Text = $"Ola {sv.Nome}";
                        break;

                }
            }

            }

        private void boxImg(string path)
        {
                if (File.Exists(path))
                {
                    picinfo.Image?.Dispose();
                    picinfo.Image = Image.FromFile(path, true);
                }
        }

        private string GetChartDate(int month)
        {
            string valor = string.Empty;
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT SUM(valor) AS vTotal FROM `faturas` WHERE `usuario` = '{sv.User}' AND `vencimento` = '{month+"-"+DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = read["vTotal"].ToString();

                }
                db.conn.Close();
               
                return valor;
            }
            catch(Exception ex)
            {
                db.conn.Close();
                MessageBox.Show(ex.ToString());
                return valor;
            }
        }
        private void ChartDespesa()
        {
            try
            {
                chartGastos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartGastos.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                chartGastos.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chartGastos.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

                chartGastos.Series["Despesas"].Label = "#VALY{C}";
                chartGastos.Series["Despesas"].LegendText = DateTime.Now.Year.ToString();
                chartGastos.Series["Despesas"].Points.AddXY("Jan", GetChartDate(1));
                chartGastos.Series["Despesas"].Points.AddXY("Fev", GetChartDate(2));
                chartGastos.Series["Despesas"].Points.AddXY("Mar", GetChartDate(3));
                chartGastos.Series["Despesas"].Points.AddXY("Abr", GetChartDate(4));
                chartGastos.Series["Despesas"].Points.AddXY("Mai", GetChartDate(5));
                chartGastos.Series["Despesas"].Points.AddXY("Jun", GetChartDate(6));
                chartGastos.Series["Despesas"].Points.AddXY("Jul", GetChartDate(7));
                chartGastos.Series["Despesas"].Points.AddXY("Ago", GetChartDate(8));
                chartGastos.Series["Despesas"].Points.AddXY("Set", GetChartDate(9));
                chartGastos.Series["Despesas"].Points.AddXY("Out", GetChartDate(10));
                chartGastos.Series["Despesas"].Points.AddXY("Nov", GetChartDate(11));
                chartGastos.Series["Despesas"].Points.AddXY("Dez", GetChartDate(12));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()) ;
            }
            
        }

        private double GetChartValue(int month)
        {

            double valor = 0;
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) AS vTotal FROM `servicos` WHERE `usuario` = '{sv.User}' AND `data` = '{month + "-" + DateTime.Now.Year}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    valor = double.Parse(read["vTotal"].ToString());

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
        private void ChartServicos()
        {
            try
            {
                chartJobs.Series["Serviços"].IsValueShownAsLabel = true;
                chartJobs.Legends["Legend1"].Title = DateTime.Now.Year.ToString();
                if (GetChartValue(1) > 0)
                {
                    chartJobs.Series["Serviços"].Points.AddXY("Jan", GetChartValue(1));
                }
                if (GetChartValue(2) > 0)
                {
                    chartJobs.Series["Serviços"].Points.AddXY("Fev", GetChartValue(2));
                }
                if (GetChartValue(3) > 0)
                {
                    chartJobs.Series["Serviços"].Points.AddXY("Mar", GetChartValue(3));
                }
                if (GetChartValue(4) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Abr", GetChartValue(4));
                }
                if (GetChartValue(5) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Mai", GetChartValue(5));
                }
                if (GetChartValue(6) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Jun", GetChartValue(6));
                }
                if (GetChartValue(7) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Jul", GetChartValue(7));
                }
                if (GetChartValue(8) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Ago", GetChartValue(8));
                }
                if (GetChartValue(9) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Set", GetChartValue(9));
                }
                if (GetChartValue(10) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Out", GetChartValue(10));
                }
                if (GetChartValue(11) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Nov", GetChartValue(11));
                }
                if (GetChartValue(12) > 0)
                {

                    chartJobs.Series["Serviços"].Points.AddXY("Dez", GetChartValue(12));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPanels()
        {
            saldoTexto.Text = ConfrinhoSaldo().ToString("C");
            fTexto.Text = Faturas().ToString();
            totalGasto.Text = Gastos().ToString("C");
            servicostext.Text = Servicos().ToString();
            ganhostexto.Text = Ganhos().ToString("C");
            dpMes.Text = CofrinhoMeta().ToString("C");

        }
    }
}
