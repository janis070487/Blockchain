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
using System.Security.Cryptography;

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
            if (!symbolCheck(MultiTextBloc1BlocNumber.Text))
            {
                MultiTextBloc1BlocNumber.Undo();
            }
            blockchain.block[0].number = MultiTextBloc1BlocNumber.Text;
        }

        private void MultiTextBloc1Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[0].Nonce = MultiTextBloc1Nonce.Text;
        }

        private void MultiLineBloc1Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[0].textt = MultiLineBloc1Data.Text;
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
            if (!symbolCheck(MultiTextBloc2BlocNumber.Text))
            {
                MultiTextBloc2BlocNumber.Undo();
            }
            blockchain.block[1].number = MultiTextBloc2BlocNumber.Text;
        }

        private void MultiTextBloc2Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[2].Nonce = MultiTextBloc2Nonce.Text;
        }

        private void MultiLineBloc2Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[2].textt = MultiLineBloc2Data.Text;
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
            if (!symbolCheck(MultiTextBloc3BlocNumber.Text))
            {
                MultiTextBloc3BlocNumber.Undo();
            }
            blockchain.block[2].number = MultiTextBloc3BlocNumber.Text;
        }

        private void MultiTextBloc3Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[2].Nonce = MultiTextBloc3Nonce.Text;
        }

        private void MultiLineBloc3Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[2].textt = MultiLineBloc3Data.Text;
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
            if (!symbolCheck(MultiTextBloc4BlocNumber.Text))
            {
                MultiTextBloc4BlocNumber.Undo();
            }
            blockchain.block[3].number = MultiTextBloc4BlocNumber.Text;
        }

        private void MultiTextBloc4Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[3].Nonce = MultiTextBloc4Nonce.Text;
        }

        private void MultiLineBloc4Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[3].textt = MultiLineBloc4Data.Text;
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
            if (!symbolCheck(MultiTextBloc5BlocNumber.Text))
            {
                MultiTextBloc5BlocNumber.Undo();
            }
            blockchain.block[4].number = MultiTextBloc5BlocNumber.Text;
        }

        private void MultiTextBloc5Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[4].Nonce = MultiTextBloc5Nonce.Text;
        }

        private void MultiLineBloc5Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[4].textt = MultiLineBloc5Data.Text;
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
            if (!symbolCheck(MultiTextBloc6BlocNumber.Text))
            {
                MultiTextBloc6BlocNumber.Undo();
            }
            blockchain.block[5].number = MultiTextBloc6BlocNumber.Text;
        }

            private void MultiTextBloc6Nonce_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[5].Nonce = MultiTextBloc6Nonce.Text;
        }

        private void MultiLineBloc6Data_TextChanged(object sender, EventArgs e)
        {
            blockchain.block[5].textt = MultiLineBloc6Data.Text;
        }

       
        private void btnBloc6Main_Click(object sender, EventArgs e)
        {

        }

        private void btnBloc6MainAll_Click(object sender, EventArgs e)
        {

        }
        //__________________________________________________________________________
        public bool symbolCheck(string newSms)
        {
            if (newSms != "")
            {
                bool status = int.TryParse(newSms, out int value);
                if (!status)
                {
                    MessageBox.Show("Neatļauts simbols!",
                        "Brīdinājums",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    return false;
                }
                return true;
            }
            else
            {
                return true;
            }
        }
        //___________________________________________________________________________
        public byte[] Maining(byte[] data, int proofOfEmployment, int maximumattempts)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] dataByte = data;
            
           byte[] answer = sha256(dataByte);
            return null;
        }
    }
}
