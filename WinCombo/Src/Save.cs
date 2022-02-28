using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Web;

namespace WinCombo.Src
{
    internal class Save
    {
        IniFile ini = new IniFile(Environment.CurrentDirectory + @"\\Buffer.bin");
        Rsa rs = new Rsa();
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Pic { get; private set; }

        public string User { get; private set; }
        public string Check { get; private set; }

       
        public void GetUser(string nome, string verifica)
        {
            Data db = new Data();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT nome, sobrenome, img FROM `users` WHERE `usuario` = '{nome}'", db.GetMySqlConnection());
                db.conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                
                while (rd.Read())
                {
                    ini.Write("##", rs.Encryption(nome,rs.publicKey), "Byte");
                    ini.Write("@@", rs.Encryption(rd["nome"].ToString(),rs.publicKey), "Byte");
                    ini.Write("!!", rs.Encryption(rd["sobrenome"].ToString(),rs.publicKey), "Byte");
                    ini.Write("$$", HttpUtility.UrlEncode(rd["img"].ToString()), "Byte");
                    ini.Write("%%", rs.Encryption(verifica,rs.publicKey), "Byte");

                }
                db.conn.Close();
            }
            catch
            { 
                db.conn.Close();
                MessageBox.Show("Ouve um problema ao obter os dados do servidor,por favor reinicie o programa.","OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LoadIni()
        {

            try
            {
                if (!string.IsNullOrEmpty(ini.Read("@@", "Byte")))
                {
                    Nome = rs.Decryption(ini.Read("@@", "Byte"), rs.privateKey);
                }
                if (!string.IsNullOrEmpty(ini.Read("!!", "Byte")))
                {
                    Sobrenome = rs.Decryption(ini.Read("!!", "Byte"), rs.privateKey);
                }
                if (!string.IsNullOrEmpty(ini.Read("$$", "Byte")))
                {
                    Pic = HttpUtility.UrlDecode(ini.Read("$$", "Byte"));
                }
                if (!string.IsNullOrEmpty(ini.Read("##", "Byte")))
                {
                    User = rs.Decryption(ini.Read("##", "Byte").ToString(), rs.privateKey);
                }
                if (string.IsNullOrEmpty(ini.Read("%%", "Byte")))
                {
                    Check = false.ToString();
                }
                else
                {
                    Check = rs.Decryption(ini.Read("%%", "Byte").ToString(), rs.privateKey);
                }
            }
            catch
            {
                MessageBox.Show("Algum arquivo do systema esta corrompido, por favor reinstale o programa.", "ERRO FATAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
