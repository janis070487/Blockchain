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
using System.Threading;

namespace Blockchain_Demo
{
    public partial class Form1 : MaterialForm
    {
        public Core core = new Core(6);
        public bool flage = false;
        //public Color colorError = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        public Color colorError = Color.Red;
        // public Color colorOk = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        public Color colorOk = Color.White;
       
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Init();
        }
        private void Init()  
        {
            MultiTextBloc1BlocNumber.Text = "1";
            MultiTextBloc2BlocNumber.Text = "2";
            MultiTextBloc3BlocNumber.Text = "3";
            MultiTextBloc4BlocNumber.Text = "4";
            MultiTextBloc5BlocNumber.Text = "5";
            MultiTextBloc6BlocNumber.Text = "6";
             core.blockchain.block[0].blockTxt.prewHashSum =
            "0000000000000000000000000000000000000000000000000000000000000000";
            MultiTextBloc1HashPrev.Text = core.blockchain.block[0].blockTxt.prewHashSum;
            core.howManyZeros = 4;                                  // iestata uzdevuma prasibas
            core.maximumNumberOfAttempts = 10000000;                 //iestata maksimālo meiģinājumu skaitu
            core.LoadFirstDataInBloc();
            core.ResetData();
            PrintNonce();
            Test();
            flage = true;
            core.resetInfo += PrintStatistic;
            core.resetInfo += Test;
           
            


        }
        

        //___________________________________   Bloks 1 ________________________________________________

        
        private void MultiTextBloc1BlocNumber_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[0].blockTxt.number = MultiTextBloc1BlocNumber.Text;
                core.ResetData();
                Test();
            }
         
        }

        private void MultiTextBloc1Nonce_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[0].blockTxt.nonce = MultiTextBloc1Nonce.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiLineBloc1Data_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[0].blockTxt.data = MultiLineBloc1Data.Text;
                core.ResetData();
                Test();
            }
        }



        private void btnBloc1Main_Click(object sender, EventArgs e)
        {
            BtnMainBlock(1);
        }

        private void btnBloc1MainAll_Click(object sender, EventArgs e)
        {
            btnMainAllBlock();
        }
        //___________________________________   Bloks 2 ________________________________________________

        private void MultiTextBloc2BlocNumber_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[1].blockTxt.number = MultiTextBloc2BlocNumber.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiTextBloc2Nonce_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[1].blockTxt.nonce = MultiTextBloc2Nonce.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiLineBloc2Data_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[1].blockTxt.data = MultiLineBloc2Data.Text;
                core.ResetData();
                Test();
            }
        }



        private void btnBloc2Main_Click(object sender, EventArgs e)
        {
            BtnMainBlock(2);
        }

        private void btnBloc2MainAll_Click(object sender, EventArgs e)
        {
            btnMainAllBlock();
        }
        //___________________________________   Bloks 3 ________________________________________________


        private void MultiTextBloc3BlocNumber_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[2].blockTxt.number = MultiTextBloc3BlocNumber.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiTextBloc3Nonce_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[2].blockTxt.nonce = MultiTextBloc3Nonce.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiLineBloc3Data_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[2].blockTxt.data = MultiLineBloc3Data.Text;
                core.ResetData();
                Test();
            }
        }



            private void btnBloc3Main_Click(object sender, EventArgs e)
        {
            BtnMainBlock(3);
        }
        private void btnBloc3MainAll_Click(object sender, EventArgs e)
        {
            btnMainAllBlock();
        }

        //___________________________________   Bloks 4 ________________________________________________


        private void MultiTextBloc4BlocNumber_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[3].blockTxt.number = MultiTextBloc4BlocNumber.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiTextBloc4Nonce_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[3].blockTxt.nonce = MultiTextBloc4Nonce.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiLineBloc4Data_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[3].blockTxt.data = MultiLineBloc4Data.Text;
                core.ResetData();
                Test();
            }
        }

        private void btnBloc4Main_Click(object sender, EventArgs e)
        {
            BtnMainBlock(4);
        }

        private void btnBloc4MainAll_Click(object sender, EventArgs e)
        {
            btnMainAllBlock();
        }


        //___________________________________   Bloks 5 ________________________________________________

        private void MultiTextBloc5BlocNumber_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[4].blockTxt.number = MultiTextBloc5BlocNumber.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiTextBloc5Nonce_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[4].blockTxt.nonce = MultiTextBloc5Nonce.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiLineBloc5Data_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[4].blockTxt.data = MultiLineBloc5Data.Text;
                core.ResetData();
                Test();
            }
        }

        private void btnBloc5Main_Click(object sender, EventArgs e)
        {
            BtnMainBlock(5);
        }

        private void btnBloc5MainAll_Click(object sender, EventArgs e)
        {
            btnMainAllBlock();
        }
        //___________________________________   Bloks 6 ________________________________________________
        private void MultiTextBloc6BlocNumber_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[5].blockTxt.number = MultiTextBloc6BlocNumber.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiTextBloc6Nonce_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[5].blockTxt.nonce = MultiTextBloc6Nonce.Text;
                core.ResetData();
                Test();
            }
        }

        private void MultiLineBloc6Data_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[5].blockTxt.data = MultiLineBloc6Data.Text;
                core.ResetData();
                Test();
            }
        }


        private void btnBloc6Main_Click(object sender, EventArgs e)
        {
            BtnMainBlock(6);
        }

        private void btnBloc6MainAll_Click(object sender, EventArgs e)
        {
            btnMainAllBlock();
        }
        //________________________________ setings ___________________________________________
        private void BoxhowManyZeros_TextChanged(object sender, EventArgs e)
        {
           core.howManyZeros = core.CheckValue(BoxhowManyZeros.Text);
            core.ResetData();
            Test();
        }

        private void BoxMaximumTray_TextChanged(object sender, EventArgs e)
        {
           core.maximumNumberOfAttempts = core.CheckValue(BoxMaximumTray.Text);
        }

        //_________________________________ Pogu apstrades funkcījas ___________________________
        public void BtnMainBlock(int blockNumber)
        {
            core.MainingStartOneBlock(blockNumber);
            core.ResetData();
            Test();
        }
        public void btnMainAllBlock()
        {
            
            core.MainingStartAllBlocks();
            core.ResetData();
            Test();
        }
        //__________________________ Statistika _________________________________________________
        public void PrintStatistic()
        {
            labelBloc1Time.Text     = $"Total time: {core.info[0].totalTime}";
            LableBloc1Timeprev.Text = $"Maining F: {core.info[0].averageUnitsPerSecond} Hz";

            labelBloc2Time.Text = $"Total time: {core.info[1].totalTime}";
            LableBloc2Timeprev.Text = $"Maining F: {core.info[1].averageUnitsPerSecond} Hz";

            labelBloc3Time.Text = $"Total time: {core.info[2].totalTime}";
            LableBloc3Timeprev.Text = $"Maining F: {core.info[2].averageUnitsPerSecond} Hz";

            labelBloc4Time.Text = $"Total time: {core.info[3].totalTime}";
            LableBloc4Timeprev.Text = $"Maining F: {core.info[3].averageUnitsPerSecond} Hz";

            labelBloc5Time.Text = $"Total time: {core.info[4].totalTime}";
            LableBloc5Timeprev.Text = $"Maining F: {core.info[4].averageUnitsPerSecond} Hz";

            labelBloc6Time.Text = $"Total time: {core.info[5].totalTime}";
            LableBloc6Timeprev.Text = $"Maining F: {core.info[5].averageUnitsPerSecond} Hz";
        }

        //___________________________Pagaidu variants____________________________________________
        public void PrintNonce()
        {
            MultiTextBloc1Nonce.Text = core.blockchain.block[0].blockTxt.nonce;
            MultiTextBloc2Nonce.Text = core.blockchain.block[1].blockTxt.nonce;
            MultiTextBloc3Nonce.Text = core.blockchain.block[2].blockTxt.nonce;
            MultiTextBloc4Nonce.Text = core.blockchain.block[3].blockTxt.nonce;
            MultiTextBloc5Nonce.Text = core.blockchain.block[4].blockTxt.nonce;
            MultiTextBloc6Nonce.Text = core.blockchain.block[5].blockTxt.nonce;
        }
        public void Test()
        {
            flage = false;
            MultiTextBloc1HashPrev.Text = core.blockchain.block[0].blockTxt.prewHashSum;
            MultiLineBloc1Hash.Text = core.blockchain.block[0].blockTxt.hashSum;
            MultiTextBloc1Nonce.Text = core.blockchain.block[0].blockTxt.nonce;


            MultiTextBloc2HashPrev.Text = core.blockchain.block[1].blockTxt.prewHashSum;
            MultiLineBloc2Hash.Text = core.blockchain.block[1].blockTxt.hashSum;
            MultiTextBloc2Nonce.Text = core.blockchain.block[1].blockTxt.nonce;

            MultiTextBloc3HashPrev.Text = core.blockchain.block[2].blockTxt.prewHashSum;
            MultiLineBloc3Hash.Text = core.blockchain.block[2].blockTxt.hashSum;
            MultiTextBloc3Nonce.Text = core.blockchain.block[2].blockTxt.nonce;

            MultiTextBloc4HashPrev.Text = core.blockchain.block[3].blockTxt.prewHashSum;
            MultiLineBloc4Hash.Text = core.blockchain.block[3].blockTxt.hashSum;
            MultiTextBloc4Nonce.Text = core.blockchain.block[3].blockTxt.nonce;

            MultiTextBloc5HashPrev.Text = core.blockchain.block[4].blockTxt.prewHashSum;
            MultiLineBloc5Hash.Text = core.blockchain.block[4].blockTxt.hashSum;
            MultiTextBloc5Nonce.Text = core.blockchain.block[4].blockTxt.nonce;


            MultiTextBloc6HashPrev.Text = core.blockchain.block[5].blockTxt.prewHashSum;
            MultiLineBloc6Hash.Text = core.blockchain.block[5].blockTxt.hashSum;
            MultiTextBloc6Nonce.Text = core.blockchain.block[5].blockTxt.nonce;
            flage = true;
            // __ saliek krāsas
            // /*
            if (core.blockchain.block[0].status)
            {
                grup1bloc.ForeColor = colorOk;
                grup1bloc.Text = "Block 1";
            }
            else
            {
                grup1bloc.ForeColor = colorError;
                grup1bloc.Text = "Block 1   __ ERROR __";
            }
            if (core.blockchain.block[1].status)
            {
                groupBox2.ForeColor = colorOk;
                groupBox2.Text = "Block 2";
            }
            else
            {
                groupBox2.ForeColor = colorError;
                groupBox2.Text = "Block 2   __ ERROR __";   
            }
            if (core.blockchain.block[2].status)
            {
                groupBox3.ForeColor = colorOk;
                groupBox3.Text = "Block 3";
            }
            else
            {
                groupBox3.ForeColor = colorError;
                groupBox3.Text = "Block 3   __ ERROR __";
            }
            if (core.blockchain.block[3].status)
            {
                groupBox4.ForeColor = colorOk;
                groupBox4.Text = "Block 4";
            }
            else
            {
                groupBox4.ForeColor = colorError;
                groupBox4.Text = "Block 4   __ ERROR __";
            }
            if (core.blockchain.block[4].status)
            {
                grup5bloc.ForeColor = colorOk;
                grup5bloc.Text = "Block 5";
            }
            else
            {
                grup5bloc.ForeColor = colorError;
                grup5bloc.Text = "Block 5   __ ERROR __";
            }
            if (core.blockchain.block[5].status)
            {
                groupBox6.ForeColor = colorOk;
                groupBox6.Text = "Block 6";
            }
            else
            {
                groupBox6.ForeColor = colorError;
                groupBox6.Text = "Block 6   __ ERROR __";
            }
            Refresh();
            //*/
        }

        






        //___________________________________________________________________________
        // public byte[] Maining(byte[] data, int proofOfEmployment, int maximumattempts)
        //  {
        //    SHA256 sha256 = new SHA256CryptoServiceProvider();
        ///   byte[] dataByte = data;

        //byte[] answer = sha256(dataByte);
        //   return null;
        //  }
        //___________________________________________________________________________

        //___________________________________________________________________________
    }
}
