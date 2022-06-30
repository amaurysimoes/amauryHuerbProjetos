using MaterialSkin;

namespace CShp_MaterialDesing
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            //======================tema 1 ======================
            //// Criando um material theme manager e adicionando o formulário
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //// Definindo um esquema de Cor para formulário com tom Azul
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.Blue500,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //);
            //=====================tema 2 =================================
            // Create a material theme manager and add the form to manage (this)
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            //// Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.Blue500,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //);
            //=========================tema 3 ======================================
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Orange700,
                TextShade.WHITE
            );

        }
    }
}
