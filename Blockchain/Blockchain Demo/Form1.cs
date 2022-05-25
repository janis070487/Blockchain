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

namespace Blockchain_Demo
{
    public partial class Form1 : MaterialForm
    {

        private Blockchain blockchain = new Blockchain(6);   // objekts blokcahain
        public Form1()
        {
            InitializeComponent();
            Init();   // Izsaucam metodi kas inicializē visus elementus
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        private void Init()  //metode kas inicializē
        {
            //blockchain = new Blockchain(3); // Izveidojam blockchain objektu ar 3 blokiem
        }




        //___________________________________   Bloks 1 ________________________________________________


        private void MultiTextBloc1BlocNumber_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(1);
        }

        private void MultiTextBloc1Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(1);
        }

        private void MultiLineBloc1Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(1);
        }

     

        private void btnBloc1Main_Click(object sender, EventArgs e)
        {

        }

        private void btnBloc1MainAll_Click(object sender, EventArgs e)
        {

        }
        //___________________________________   Bloks 2 ________________________________________________

        private void MultiTextBloc2BlocNumber_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(2);
        }

        private void MultiTextBloc2Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(2);
        }

        private void MultiLineBloc2Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(2);
        }

      

        private void btnBloc2Main_Click(object sender, EventArgs e)
        {

        }

        private void btnBloc2MainAll_Click(object sender, EventArgs e)
        {

        }
        //___________________________________   Bloks 3 ________________________________________________


        private void MultiTextBloc3BlocNumber_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(3);
        }

        private void MultiTextBloc3Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(3);
        }

        private void MultiLineBloc3Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(3);
        }

      

        private void btnBloc3Main_Click(object sender, EventArgs e)
        {

        }
        private void btnBloc3MainAll_Click(object sender, EventArgs e)
        {

        }

        //___________________________________   Bloks 4 ________________________________________________


        private void MultiTextBloc4BlocNumber_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(4);
        }

        private void MultiTextBloc4Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(4);
        }

        private void MultiLineBloc4Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(4);
        }

        private void btnBloc4Main_Click(object sender, EventArgs e)
        {

        }

        private void btnBloc4MainAll_Click(object sender, EventArgs e)
        {

        }
        //___________________________________   Bloks 5 ________________________________________________

        private void MultiTextBloc5BlocNumber_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(5);
        }

        private void MultiTextBloc5Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(5);
        }

        private void MultiLineBloc5Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(5);
        }

        private void btnBloc5Main_Click(object sender, EventArgs e)
        {

        }

        private void btnBloc5MainAll_Click(object sender, EventArgs e)
        {

        }
        //___________________________________   Bloks 6 ________________________________________________
        private void MultiTextBloc6BlocNumber_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(6);
        }

        private void MultiTextBloc6Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(6);
        }

        private void MultiLineBloc6Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.ResetBlockData(6);
        }

       
        private void btnBloc6Main_Click(object sender, EventArgs e)
        {

        }

        private void btnBloc6MainAll_Click(object sender, EventArgs e)
        {

        }
    }
}
