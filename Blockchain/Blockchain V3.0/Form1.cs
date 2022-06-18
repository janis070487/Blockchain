using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockchain_V3._0
{
    public partial class Form1 : MaterialForm
    {
        public bool flage = false;
        public Form1()
        {
            InitializeComponent(6);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Init();
        }

        private void Init()
        {
            for (int i = 0; i < MultiTextBlocBlocNumber.Length; i++)
            {
                MultiTextBlocBlocNumber[i].Text = Convert.ToString(i + 1);
            }
        }

        private void btnBloc1Main_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MultiLineBlocData[0].Text = btn.Name ;
            
        }

    }
}
