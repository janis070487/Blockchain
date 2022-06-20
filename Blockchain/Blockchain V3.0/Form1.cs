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
        public int howBloc = 10;
        public CoreWinForm core;
        public Color colorError = Color.Red;
        public Color colorOk = Color.White;
        public Form1()
        {
            core = new CoreWinForm(howBloc);
            InitializeComponent(howBloc);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Init();
        }

        private void Init()
        {
            //flage = true;
            core.resetInfo += Print;
          //  core.blockchain.block[0].blockTxt.prewHashSum =
          // "0000000000000000000000000000000000000000000000000000000000000000";
          //  MultiTextBloc1HashPrev.Text = core.blockchain.block[0].blockTxt.prewHashSum;
            core.howManyZeros = 4;                                  // iestata uzdevuma prasibas
            core.maximumNumberOfAttempts = 10000000;                 //iestata maksimālo meiģinājumu skaitu
            core.LoadFirstDataInBloc();
            core.ResetData();
           // PrintNonce();
            Print();
            flage = true;
           // core.resetInfo += PrintStatistic;
            //core.resetInfo += Test;
        }

        private void btnBloc1Main_Click(object sender, EventArgs e)
        {
                Button btnMain = sender as Button;
                //MultiLineBlocData[Int32.Parse(btnMain.Name)].Text += $"BTN Main: {btnMain.Name}";

        }

        private void btnBlockMainAll_Click(object sender, EventArgs e)
        {
           
                Button btnMainAll = sender as Button;
               // MultiLineBlocData[Int32.Parse(btnMainAll.Name)].Text += $"BTN MainAll: {btnMainAll.Name}";
           
        }


        private void BlockNumber_TextChangedk(object sender, EventArgs e)
        {
            if (flage)
            {
                flage = false;
                MaterialMultiLineTextBox textBoxNumber = sender as MaterialMultiLineTextBox;
                core.ChangedNumber(textBoxNumber.Name, textBoxNumber.Text);
                flage = true;
            }
        }

        private void BlockNonce_TextChangedk(object sender, EventArgs e)
        {
            if (flage)
            {
                flage = false;
                MaterialMultiLineTextBox textBoxNonce = sender as MaterialMultiLineTextBox;
                core.ChangedNumber(textBoxNonce.Name, textBoxNonce.Text);
                flage = true;
            }
        }

        private void BlockData_TextChangedk(object sender, EventArgs e)
        {
            if (flage)
            {
                flage = false;
                MaterialMultiLineTextBox textBoxData = sender as MaterialMultiLineTextBox;
                core.ChangedNumber(textBoxData.Name, textBoxData.Text);
                flage = true;
            }
        }

        public void Print()
        {

            flage = false;

            for(int i = 0; i < core.blockchain.block.Length; i++)
            {
                MultiTextBlocBlocNumber[i].Text = core.blockchain.block[i].blockTxt.number;
                MultiTextBlocNonce[i].Text = core.blockchain.block[i].blockTxt.nonce;
                MultiLineBlocData[i].Text = core.blockchain.block[i].blockTxt.data;
                MultiTextBlocHashPrev[i].Text = core.blockchain.block[i].blockTxt.prewHashSum;
                MultiLineBlocHash[i].Text = core.blockchain.block[i].blockTxt.hashSum;
                TextBlocTime[i].Text = $"Total time: {core.info[0].totalTime}";
                TextBlocFrequency[i].Text = $"Maining F: {core.info[0].averageUnitsPerSecond} Hz";
                if (core.blockchain.block[0].status)
                {
                    grupBloc[i].ForeColor = colorOk;
                    grupBloc[i].Text = $"Block {i + 1}";
                }
                else
                {
                    grupBloc[i].ForeColor = colorError;
                    grupBloc[i].Text = $"Block {i + 1}   __ ERROR __";
                }
            }
            
            flage = true;
          
            Refresh();
            //*/

        }

    }
}
