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
//_________________________________________ Jautājumi _______________________________
/*
 1.   vai class Sha256FromBlocData metode GetSha25 ir pareizi pieņemt metodē izmainīt to
      un tad atgriest to pašu kā rezultātu. Vai labāk izveidot jaunu un atgriest jaunu;

 2.   vai ir gatava iespēja Block metodē SetAnswerBlockTxt()  convertējot ar sekojošo rindiņu
        panāk lai kreisās nules neizdzēš
        blockTxt.hashSum += Convert.ToString(blockdata.hashSum[i], toBase: 16);
       vai to pašam jaizdomā kā to darīt.   Ja nav tad es zinu kā!!

3.    Kā var piemēram no objekta block izmainīt forms1 control tekstus lai var tikt no metodes Test

4.    Nesanāk sadalīt pa mapēm

5.    
 * */
namespace Blockchain_V2._0
{
    public partial class Form1 : MaterialForm
    {
     

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
    }
}