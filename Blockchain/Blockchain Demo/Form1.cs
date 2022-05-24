﻿using MaterialSkin;
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
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MultiTextBloc1BlocNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiTextBloc1Nonce_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiLineBloc1Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiTextBloc1HashPrev_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiLineBloc1Hash_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBloc1Main_Click(object sender, EventArgs e)
        {

        }

        private void btnBloc1MainAll_Click(object sender, EventArgs e)
        {

        }

        private void MultiTextBloc2BlocNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiTextBloc2Nonce_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiLineBloc2Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiTextBloc2HashPrev_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiLineBloc2Hash_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBloc2Main_Click(object sender, EventArgs e)
        {

        }

        private void btnBloc2MainAll_Click(object sender, EventArgs e)
        {

        }

        private void MultiTextBloc3BlocNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiTextBloc3Nonce_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiLineBloc3Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiTextBloc3HashPrev_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiLineBloc3Hash_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBloc3Main_Click(object sender, EventArgs e)
        {

        }
    }
}
