using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

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
            AuthSecret = "mhjtSZzO2zI3nFb2uoHH0bjZjjXjARqCbgPcxbaB",
            BasePath = "https://cfireeng-2f516-default-rtdb.firebaseio.com/"
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
            Student std = new Student()
            {
                FullName = nameTbox.Text,
                RollNo = rollTbox.Text,
                Grade = gradeTbox.Text,
                Section = secTbox.Text,
            };
            var setter = client.Set("StudentList/"+rollTbox.Text,std);
            MessageBox.Show("data inserted sucessfully");
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var result = client.Get("StudentList/" + rollTbox.Text);
            Student std = result.ResultAs<Student>();
            nameTbox.Text = std.FullName;
            gradeTbox.Text = std.Grade;
            secTbox.Text = std.Section;
            MessageBox.Show("data retrieved sucessfully");

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Student std = new Student()
            {
                FullName = nameTbox.Text,
                RollNo = rollTbox.Text,
                Grade = gradeTbox.Text,
                Section = secTbox.Text,
            };
            var setter = client.Update("StudentList/" + rollTbox.Text, std);
            MessageBox.Show("data inserted sucessfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = client.Delete("StudentList/" + rollTbox.Text);
            MessageBox.Show("data deleted successfully");
        }
    }
}
