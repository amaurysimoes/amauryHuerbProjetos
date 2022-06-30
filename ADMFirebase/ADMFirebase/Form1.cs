using System;
using System.Windows.Forms;
using MaterialSkin;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

//Ajustar para versão soft.NewApp
//Referência: https://www.youtube.com/watch?v=QE5UV8NyYqg&t=77s

namespace ADMFirebase
{
    public partial class ADMFirebase : MaterialSkin.Controls.MaterialForm
    {
        public ADMFirebase()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey400, Primary.Grey500,
                Primary.Grey500, Accent.LightGreen200,
                TextShade.BLACK
            );
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "BiUw2T3B4XDAa8JJLvtQIgDeEIXqhXzWppLzcrft",
            BasePath = "https://softnewapp-f2651-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void ADMFirebase_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("there was problem in the internet.");
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            softNewApp std = new softNewApp()
            {
                Cliente = nameTbox.Text,
                Pedido = rollTbox.Text,
                Quantidade = gradeTbox.Text,
                Local = secTbox.Text,
            };
            var setter = client.Set("SoftNewApp/"+rollTbox.Text,std);
            MessageBox.Show("data inserted sucessfully");
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var result = client.Get("SoftNewApp/" + rollTbox.Text);
            softNewApp std = result.ResultAs<softNewApp>();
            nameTbox.Text = std.Cliente;
            gradeTbox.Text = std.Quantidade;
            secTbox.Text = std.Local;
            MessageBox.Show("data retrieved sucessfully");

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            softNewApp std = new softNewApp()
            {
                Cliente = nameTbox.Text,
                Pedido = rollTbox.Text,
                Quantidade = gradeTbox.Text,
                Local = secTbox.Text,
            };
            var setter = client.Update("SoftNewApp/" + rollTbox.Text, std);
            MessageBox.Show("data inserted sucessfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = client.Delete("SoftNewApp/" + rollTbox.Text);
            MessageBox.Show("data deleted successfully");
        }
    }
}
