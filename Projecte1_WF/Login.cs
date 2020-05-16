using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using AccesDades_BC;
using System.Security.Cryptography;
using System.Collections.Specialized;

namespace Projecte1_WF
{
    public partial class Login : Form
    {
        public static string Llave = "jwey89e09ewhfo24";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contrassenyaencriptada = Encriptar(tbContrassenya.Text, Llave);

            DataSet ds = new DataSet();

            string query = "SELECT Users.idUser, Users.Login, Users.Photo, UserCategories.AccessLevel FROM UserCategories INNER JOIN Users ON UserCategories.idUserCategory = Users.idUserCategory WHERE(Users.Login = '" + tbUsuari.Text + "') AND(Users.Password = '" + contrassenyaencriptada + "')";

            DataAccess instance = new DataAccess();

            ds = instance.PortarPerConsulta(query);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                System.Configuration.Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("appSettings");
                
                ConfigurationManager.AppSettings.Set("_accesslevel", ds.Tables[0].Rows[0]["accesslevel"].ToString());
                ConfigurationManager.AppSettings.Set("_Login", ds.Tables[0].Rows[0]["Login"].ToString());
                ConfigurationManager.AppSettings.Set("_Photo", ds.Tables[0].Rows[0]["Photo"].ToString());

                PantallaPrincipal menu = new PantallaPrincipal();
                menu.Show();
            } else
            {
                missatgerror.Visible = true;
            }
        }

        public string Encriptar(string dato, string llave)
        {
            byte[] keyArray;
            byte[] encriptar = Encoding.UTF8.GetBytes(dato);

            keyArray = Encoding.UTF8.GetBytes(llave);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultado = cTransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
            tdes.Clear();

            return Convert.ToBase64String(resultado, 0, resultado.Length);
        }

        public string Decriptar(string dato, string llave)
        {
            byte[] keyArray;
            byte[] decriptar = Convert.FromBase64String(dato);

            keyArray = Encoding.UTF8.GetBytes(llave);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultado = cTransform.TransformFinalBlock(decriptar, 0, decriptar.Length);
            tdes.Clear();

            return Encoding.UTF8.GetString(resultado);
        }

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    