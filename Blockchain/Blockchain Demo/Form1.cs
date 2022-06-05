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
//_________________________________________ Jautājumi _______________________________
/*
 1.   vai class Sha256FromBlocData metode GetSha25 ir pareizi pieņemt metodē izmainīt to
      un tad atgriest to pašu kā rezultātu. Vai labāk izveidot jaunu un atgriest jaunu;

 2.   vai ir gatava iespēja Block metodē SetAnswerBlockTxt()  convertējot ar sekojošo rindiņu
        panāk lai kreisās nules neizdzēš
        blockTxt.hashSum += Convert.ToString(blockdata.hashSum[i], toBase: 16);
       vai to pašam jaizdomā kā to darīt.   Ja nav tad es zinu kā!!

3.    Kā var piemēram no objekta block izmainīt forms1 control tekstus lai var tikt no metodes Test
 * */
namespace Blockchain_Demo
{
    public partial class Form1 : MaterialForm
    {
        public Core core = new Core(6);
        public bool flage = false;
        //private Blockchain blockchain = new Blockchain(6);   // objekts blokcahain
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
            core.ResetData();
            Test();
            flage = true;
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
        }

        private void btnBloc1MainAll_Click(object sender, EventArgs e)
        {

        }
        //___________________________________   Bloks 2 ________________________________________________

        private void MultiTextBloc2BlocNumber_TextChanged(object sender, EventArgs e)
        {
            if (flage)
            {
                core.blockchain.block[1].blockTxt.number = MultiTextBloc2BlocNumber.Text;
                core.ResetData();
                Test();
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

        }

        private void btnBloc2MainAll_Click(object sender, EventArgs e)
        {

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
                core.blockchain.block[3].blockTxt.data = MultiLineBloc4Data.Text;
                core.ResetData();
                Test();
            }
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
                core.blockchain.block[3].blockTxt.nonce = MultiTextBloc3Nonce.Text;
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

        }

        private void btnBloc4MainAll_Click(object sender, EventArgs e)
        {

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

        }

        private void btnBloc5MainAll_Click(object sender, EventArgs e)
        {

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

        }

        private void btnBloc6MainAll_Click(object sender, EventArgs e)
        {

        }


        //___________________________Pagaidu variants____________________________________________

        public void Test()
        {
            MultiTextBloc1HashPrev.Text = core.blockchain.block[0].blockTxt.prewHashSum;
            MultiLineBloc1Hash.Text = core.blockchain.block[0].blockTxt.hashSum;

            MultiTextBloc2HashPrev.Text = core.blockchain.block[1].blockTxt.prewHashSum;
            MultiLineBloc2Hash.Text = core.blockchain.block[1].blockTxt.hashSum;

            MultiTextBloc3HashPrev.Text = core.blockchain.block[2].blockTxt.prewHashSum;
            MultiLineBloc3Hash.Text = core.blockchain.block[2].blockTxt.hashSum;

            MultiTextBloc4HashPrev.Text = core.blockchain.block[3].blockTxt.prewHashSum;
            MultiLineBloc4Hash.Text = core.blockchain.block[3].blockTxt.hashSum;

            MultiTextBloc5HashPrev.Text = core.blockchain.block[4].blockTxt.prewHashSum;
            MultiLineBloc5Hash.Text = core.blockchain.block[4].blockTxt.hashSum;

            MultiTextBloc6HashPrev.Text = core.blockchain.block[5].blockTxt.prewHashSum;
            MultiLineBloc6Hash.Text = core.blockchain.block[5].blockTxt.hashSum;
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
