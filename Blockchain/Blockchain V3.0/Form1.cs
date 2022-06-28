using MaterialSkin;
using MaterialSkin.Controls;
using System;

using System.Drawing;


namespace Blockchain_V3._0
{
    public partial class Form1 : MaterialForm
    {
        public bool flage = false;
        public int howBloc = 4;
        public CoreWinForm core;
        public Color colorError = Color.Red;
        public Color colorOk = Color.White;

        public Form1(int howBlock = 6)
        {
            this.howBloc = howBlock;
            InitializeComponent(howBloc);
            CoreWinForm core = new CoreWinForm(howBloc);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Init();
        }

        private void Init()
        {
            core = new CoreWinForm(howBloc);

            flage = false;
            core.howManyZeros = 4;                                  // iestata uzdevuma prasibas
            core.maximumNumberOfAttempts = 10000000;                 //iestata maksimālo meiģinājumu skaitu
            core.LoadFirstDataInBloc();
            core.resetInfo += Print;
            core.resetNonce += ResetNonce;
            core.resetNonce += ResetNonce;
            for (int i = 0; i < howBloc; i++)
            {
                MultiTextBlocNonce[i].Text = core.blockchain.block[i].blockTxt.nonce;
            }
            Print();
        }

        private void btnBloc1Main_Click(object sender, EventArgs e)
        {
            MaterialButton btn = sender as MaterialButton;
            core.Maining(Convert.ToInt32(btn.Name));
        }

        private void btnBlockMainAll_Click(object sender, EventArgs e)
        {
            MaterialButton btn = sender as MaterialButton;
            core.MainAll();
        }

        private void BlockNumber_TextChangedk(object sender, EventArgs e)
        {
            if (flage)
            {
                MaterialMultiLineTextBox textBoxNumber = sender as MaterialMultiLineTextBox;
                string answer;
                bool met = core.CheckValue(textBoxNumber.Text, out answer);
                if (met)
                {
                    core.ChangedNumber(textBoxNumber.Name, answer);
                }
                else
                {
                    ResetNumber(Convert.ToInt32(textBoxNumber.Name));
                }
            }
        }

        private void BlockNonce_TextChangedk(object sender, EventArgs e)
        {
            if (flage)
            {
                MaterialMultiLineTextBox textBoxNonce = sender as MaterialMultiLineTextBox;
                core.ChangedNonce(textBoxNonce.Name, textBoxNonce.Text);
            }
        }

        private void howManyZeros_TextChangedk(object sender, EventArgs e)
        {
            string zero = BoxhowManyZeros.Text;
            if (zero == "")
            {
                core.howManyZeros = 0;
            }
            else
            {
                core.howManyZeros = Convert.ToInt32(BoxhowManyZeros.Text);
            }
            core.ResetAllBlock();
            Print();
        }

        private void MaximumTray_TextChangedk(object sender, EventArgs e)
        {
            core.maximumNumberOfAttempts = Convert.ToInt32(BoxMaximumTray.Text);
        }

        private void BlockData_TextChangedk(object sender, EventArgs e)
        {
            if (flage)
            {
                MaterialMultiLineTextBox textBoxData = sender as MaterialMultiLineTextBox;
                core.ChangedData(textBoxData.Name, textBoxData.Text);
            }
        }
        public void ResetNonce()
        {
            flage = false;
            for (int i = 0; i < howBloc; i++)
            {
                MultiTextBlocNonce[i].Text = core.blockchain.block[i].blockTxt.nonce;
            }
            flage = true;
        }
        public void ResetNumber(int blockNumber)
        {
            flage = false;
            MultiTextBlocBlocNumber[blockNumber].Text = "0";
        }
        public void Print()
        {
            flage = false;
            for (int i = 0; i < core.blockchain.block.Length; i++)
            {
                MultiTextBlocHashPrev[i].Text = core.blockchain.block[i].blockTxt.prewHashSum;
                MultiLineBlocHash[i].Text = core.blockchain.block[i].blockTxt.hashSum;
                TextBlocTime[i].Text = $"Total time: {core.info[i].totalTime}";
                TextBlocFrequency[i].Text = $"Maining F: {core.info[i].averageUnitsPerSecond} Hz";
                if (core.blockchain.block[i].status)
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
            Refresh();
            flage = true;
        }
    }
}
