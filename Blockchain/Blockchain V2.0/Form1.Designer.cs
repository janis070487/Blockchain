namespace Blockchain_V2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent(int cik = 6)
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelMaximum = new MaterialSkin.Controls.MaterialTabControl();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabBloc = new System.Windows.Forms.TabPage();
            this.panelBlockchain = new System.Windows.Forms.Panel();
           // this.groupBox6 = new System.Windows.Forms.GroupBox();
           // this.grup5bloc = new System.Windows.Forms.GroupBox();
          //  this.groupBox4 = new System.Windows.Forms.GroupBox();
          // this.groupBox3 = new System.Windows.Forms.GroupBox();
          //  this.groupBox2 = new System.Windows.Forms.GroupBox();
          //  this.grup1bloc = new System.Windows.Forms.GroupBox();
            this.tabSeting = new System.Windows.Forms.TabPage();
            this.LabelMax = new MaterialSkin.Controls.MaterialLabel();
            this.BoxMaximumTray = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.LabelhowManyZeros = new MaterialSkin.Controls.MaterialLabel();
            this.BoxhowManyZeros = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);

            //_____________________________________________________________________________________________
            this.grupBloc = new System.Windows.Forms.GroupBox[cik];
            this.howRow = (cik / 3);
            if(howRow == 0)
                this.howRow = 1;
            if(cik % 3 != 0)
                this.howRow++;

            point = new System.Drawing.Point[howRow * 3];
           for(int i = 0; i < howRow; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int x = j * 431;
                    int y = i * 629 + 3; 
                    point[i] = new System.Drawing.Point(x, y);
                    this.counter++;
                }
               
            }
            for (int i = 0; i < cik; i++)
            {
                this.panelBlockchain.Controls.Add(this.grupBloc[i]);
            }
             
            for(int i = 0; i < cik; i++)
            {
                this.grupBloc[i] = new System.Windows.Forms.GroupBox();


                this.grupBloc[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
                this.grupBloc[i].Location = new System.Drawing.Point(point[i].X, point[i].Y);
                this.grupBloc[i].Name = $"groupBox{i + 1}";
                this.grupBloc[i].Size = new System.Drawing.Size(425, 612);
                this.grupBloc[i].TabIndex = 5;
                this.grupBloc[i].TabStop = false;
                this.grupBloc[i].Text = "Block 6";
            }


            //_____________________________________________________________________________________________

            // this.LableBloc6Timeprev = new MaterialSkin.Controls.MaterialLabel();
            //  this.labelBloc6Time = new MaterialSkin.Controls.MaterialLabel();
            //  this.btnBloc6MainAll = new MaterialSkin.Controls.MaterialButton();
            //  this.btnBloc6Main = new MaterialSkin.Controls.MaterialButton();
            //  this.MultiLineBloc6Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //   this.MultiTextBloc6HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //   this.MultiLineBloc6Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //    this.MultiTextBloc6Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //   this.TextBloc6Hash = new MaterialSkin.Controls.MaterialLabel();
            //    this.TextBloc66Prev = new MaterialSkin.Controls.MaterialLabel();
            //   this.TextBloc6Data = new MaterialSkin.Controls.MaterialLabel();
            //  this.MultiTextBloc6BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc6Nonce = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc6BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            //  this.LableBloc5Timeprev = new MaterialSkin.Controls.MaterialLabel();
            //  this.labelBloc5Time = new MaterialSkin.Controls.MaterialLabel();
            //  this.btnBloc5MainAll = new MaterialSkin.Controls.MaterialButton();
            //  this.btnBloc5Main = new MaterialSkin.Controls.MaterialButton();
            //  this.MultiLineBloc5Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiTextBloc5HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiLineBloc5Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiTextBloc5Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc5Hash = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc6Prev = new MaterialSkin.Controls.MaterialLabel();
            //   this.TextBloc5Data = new MaterialSkin.Controls.MaterialLabel();
            //  this.MultiTextBloc5BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc5Nonce = new MaterialSkin.Controls.MaterialLabel();
            // this.TextBloc5BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            // this.LableBloc4Timeprev = new MaterialSkin.Controls.MaterialLabel();
            //   this.labelBloc4Time = new MaterialSkin.Controls.MaterialLabel();
            //   this.btnBloc4MainAll = new MaterialSkin.Controls.MaterialButton();
            //  this.btnBloc4Main = new MaterialSkin.Controls.MaterialButton();
            //  this.MultiLineBloc4Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiTextBloc4HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiLineBloc4Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiTextBloc4Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc4Hash = new MaterialSkin.Controls.MaterialLabel();
            // this.TextBloc4Prev = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc4Data = new MaterialSkin.Controls.MaterialLabel();
            //  this.MultiTextBloc4BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc4Nonce = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc4BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            //  this.LableBloc3Timeprev = new MaterialSkin.Controls.MaterialLabel();
            // this.labelBloc3Time = new MaterialSkin.Controls.MaterialLabel();
            // this.btnBloc3MainAll = new MaterialSkin.Controls.MaterialButton();
            //  this.btnBloc3Main = new MaterialSkin.Controls.MaterialButton();
            // this.MultiLineBloc3Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //   this.MultiTextBloc3HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiLineBloc3Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiTextBloc3Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc3Hash = new MaterialSkin.Controls.MaterialLabel();
            //   this.TextBloc3Prev = new MaterialSkin.Controls.MaterialLabel();
            //   this.TextBloc3Data = new MaterialSkin.Controls.MaterialLabel();
            // this.MultiTextBloc3BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            // this.TextBloc3Nonce = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc3BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            //  this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            //  this.LableBloc2Timeprev = new MaterialSkin.Controls.MaterialLabel();
            //  this.labelBloc2Time = new MaterialSkin.Controls.MaterialLabel();
            //  this.btnBloc2MainAll = new MaterialSkin.Controls.MaterialButton();
            //  this.btnBloc2Main = new MaterialSkin.Controls.MaterialButton();
            //  this.MultiLineBloc2Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiTextBloc2HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiLineBloc2Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //   this.MultiTextBloc2Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //   this.TextBloc2Hash = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc2Prev = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc2Data = new MaterialSkin.Controls.MaterialLabel();
            //   this.MultiTextBloc2BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc2Nonce = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc2BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            // this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            //  this.LableBloc1Timeprev = new MaterialSkin.Controls.MaterialLabel();
            //  this.labelBloc1Time = new MaterialSkin.Controls.MaterialLabel();
            //   this.btnBloc1MainAll = new MaterialSkin.Controls.MaterialButton();
            //   this.btnBloc1Main = new MaterialSkin.Controls.MaterialButton();
            //   this.MultiLineBloc1Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //   this.MultiTextBloc1HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiLineBloc1Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.MultiTextBloc1Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc1Hash = new MaterialSkin.Controls.MaterialLabel();
            // this.TextBloc1Prev = new MaterialSkin.Controls.MaterialLabel();
            // this.TextBloc1Data = new MaterialSkin.Controls.MaterialLabel();
            //  this.MultiTextBloc1BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            //  this.TextBloc1Nonce = new MaterialSkin.Controls.MaterialLabel();
            //  this.TextBloc1BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LabelMaximum.SuspendLayout();
            this.tabBloc.SuspendLayout();
            this.panelBlockchain.SuspendLayout();
            this.tabSeting.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelMaximum
            // 
            this.LabelMaximum.Controls.Add(this.tabFile);
            this.LabelMaximum.Controls.Add(this.tabInfo);
            this.LabelMaximum.Controls.Add(this.tabBloc);
            this.LabelMaximum.Controls.Add(this.tabSeting);
            this.LabelMaximum.Depth = 0;
            this.LabelMaximum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMaximum.ImageList = this.imageList1;
            this.LabelMaximum.Location = new System.Drawing.Point(3, 64);
            this.LabelMaximum.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMaximum.Multiline = true;
            this.LabelMaximum.Name = "LabelMaximum";
            this.LabelMaximum.SelectedIndex = 0;
            this.LabelMaximum.Size = new System.Drawing.Size(1354, 653);
            this.LabelMaximum.TabIndex = 0;
            // 
            // tabFile
            // 
            this.tabFile.ImageKey = "file.png";
            this.tabFile.Location = new System.Drawing.Point(4, 39);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(1346, 610);
            this.tabFile.TabIndex = 0;
            this.tabFile.Text = "  File";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.ImageKey = "info.png";
            this.tabInfo.Location = new System.Drawing.Point(4, 39);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(1346, 610);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "  Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tabBloc
            // 
            this.tabBloc.Controls.Add(this.panelBlockchain);
            this.tabBloc.ImageKey = "blockchain-2.png";
            this.tabBloc.Location = new System.Drawing.Point(4, 39);
            this.tabBloc.Name = "tabBloc";
            this.tabBloc.Size = new System.Drawing.Size(1346, 610);
            this.tabBloc.TabIndex = 2;
            this.tabBloc.Text = "  Blockchain";
            this.tabBloc.UseVisualStyleBackColor = true;
            // 
            // panelBlockchain
            // 
            this.panelBlockchain.AutoScroll = true;
            this.panelBlockchain.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panelBlockchain.AutoScrollMinSize = new System.Drawing.Size(0, 2500);
            this.panelBlockchain.AutoSize = true;
         //   this.panelBlockchain.Controls.Add(this.groupBox6);
           // this.panelBlockchain.Controls.Add(this.grup5bloc);
          //  this.panelBlockchain.Controls.Add(this.groupBox4);
         //   this.panelBlockchain.Controls.Add(this.groupBox3);
          //  this.panelBlockchain.Controls.Add(this.groupBox2);
          //  this.panelBlockchain.Controls.Add(this.grup1bloc);
            this.panelBlockchain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBlockchain.Location = new System.Drawing.Point(0, 0);
            this.panelBlockchain.MaximumSize = new System.Drawing.Size(2000, 1200);
            this.panelBlockchain.MinimumSize = new System.Drawing.Size(2000, 1200);
            this.panelBlockchain.Name = "panelBlockchain";
            this.panelBlockchain.Size = new System.Drawing.Size(2000, 1200);
            this.panelBlockchain.TabIndex = 0;
          // for(int i = 0; i < grupBloc.Length; i++)
         //   {
          //      this.panelBlockchain.Controls.Add(this.grupBloc[i]);
          //  }
            // 
            // grup1bloc
            // 
          //  this.grup1bloc.Location = new System.Drawing.Point(0, 0);
           // this.grup1bloc.Name = "grup1bloc";
           // this.grup1bloc.Size = new System.Drawing.Size(200, 100);
           // this.grup1bloc.TabIndex = 5;
           // this.grup1bloc.TabStop = false;
            // 
            // tabSeting
            // 
            this.tabSeting.Controls.Add(this.LabelMax);
            this.tabSeting.Controls.Add(this.BoxMaximumTray);
            this.tabSeting.Controls.Add(this.LabelhowManyZeros);
            this.tabSeting.Controls.Add(this.BoxhowManyZeros);
            this.tabSeting.ImageKey = "setting.png";
            this.tabSeting.Location = new System.Drawing.Point(4, 39);
            this.tabSeting.Name = "tabSeting";
            this.tabSeting.Size = new System.Drawing.Size(1346, 610);
            this.tabSeting.TabIndex = 3;
            this.tabSeting.Text = "  Setings";
            this.tabSeting.UseVisualStyleBackColor = true;
            // 
            // LabelMax
            // 
            this.LabelMax.AutoSize = true;
            this.LabelMax.Depth = 0;
            this.LabelMax.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelMax.Location = new System.Drawing.Point(181, 145);
            this.LabelMax.MaximumSize = new System.Drawing.Size(100, 30);
            this.LabelMax.MinimumSize = new System.Drawing.Size(100, 30);
            this.LabelMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.Size = new System.Drawing.Size(217, 19);
            this.LabelMax.TabIndex = 9;
            this.LabelMax.Text = "Maximum number of attempts";
            // 
            // BoxMaximumTray
            // 
            this.BoxMaximumTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BoxMaximumTray.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxMaximumTray.Depth = 0;
            this.BoxMaximumTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxMaximumTray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoxMaximumTray.Location = new System.Drawing.Point(418, 145);
            this.BoxMaximumTray.MaximumSize = new System.Drawing.Size(300, 30);
            this.BoxMaximumTray.MaxLength = 15;
            this.BoxMaximumTray.MinimumSize = new System.Drawing.Size(300, 30);
            this.BoxMaximumTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.BoxMaximumTray.Multiline = false;
            this.BoxMaximumTray.Name = "BoxMaximumTray";
            this.BoxMaximumTray.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BoxMaximumTray.Size = new System.Drawing.Size(300, 30);
            this.BoxMaximumTray.TabIndex = 8;
            this.BoxMaximumTray.Text = "10000000";
            // 
            // LabelhowManyZeros
            // 
            this.LabelhowManyZeros.AutoSize = true;
            this.LabelhowManyZeros.Depth = 0;
            this.LabelhowManyZeros.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelhowManyZeros.Location = new System.Drawing.Point(181, 75);
            this.LabelhowManyZeros.MaximumSize = new System.Drawing.Size(100, 30);
            this.LabelhowManyZeros.MinimumSize = new System.Drawing.Size(100, 30);
            this.LabelhowManyZeros.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelhowManyZeros.Name = "LabelhowManyZeros";
            this.LabelhowManyZeros.Size = new System.Drawing.Size(178, 19);
            this.LabelhowManyZeros.TabIndex = 7;
            this.LabelhowManyZeros.Text = "Proof of work complexity";
            // 
            // BoxhowManyZeros
            // 
            this.BoxhowManyZeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BoxhowManyZeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxhowManyZeros.Depth = 0;
            this.BoxhowManyZeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxhowManyZeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoxhowManyZeros.Location = new System.Drawing.Point(418, 75);
            this.BoxhowManyZeros.MaximumSize = new System.Drawing.Size(300, 30);
            this.BoxhowManyZeros.MaxLength = 1;
            this.BoxhowManyZeros.MinimumSize = new System.Drawing.Size(300, 30);
            this.BoxhowManyZeros.MouseState = MaterialSkin.MouseState.HOVER;
            this.BoxhowManyZeros.Multiline = false;
            this.BoxhowManyZeros.Name = "BoxhowManyZeros";
            this.BoxhowManyZeros.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BoxhowManyZeros.Size = new System.Drawing.Size(300, 30);
            this.BoxhowManyZeros.TabIndex = 6;
            this.BoxhowManyZeros.Text = "4";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
          //  this.imageList1.Images.SetKeyName(0, "blockchain-1.png");
            //this.imageList1.Images.SetKeyName(1, "blockchain-2.png");
            //this.imageList1.Images.SetKeyName(2, "file.png");
            //this.imageList1.Images.SetKeyName(3, "info.png");
            //this.imageList1.Images.SetKeyName(4, "setting.png");


            //_____________________________________________________________________________________________



            //_____________________________________________________________________________________________






            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.LabelMaximum);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.LabelMaximum;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Blockhchain";
            this.LabelMaximum.ResumeLayout(false);
            this.tabBloc.ResumeLayout(false);
            this.tabBloc.PerformLayout();
            this.panelBlockchain.ResumeLayout(false);
            this.tabSeting.ResumeLayout(false);
            this.tabSeting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

       

        private MaterialSkin.Controls.MaterialTabControl LabelMaximum;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabBloc;
        private System.Windows.Forms.TabPage tabSeting;
        //_____________________________________________________________________________________________
        private System.Windows.Forms.GroupBox[] grupBloc;

        private int howRow;
        private int counter;
        private System.Drawing.Point[] point;
        //_____________________________________________________________________________________________
        //   private System.Windows.Forms.GroupBox grup1bloc;
        //   private MaterialSkin.Controls.MaterialLabel TextBloc1BlocNumber;
        //   private MaterialSkin.Controls.MaterialLabel TextBloc1Nonce;
        //  private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc1BlocNumber;
        //   private MaterialSkin.Controls.MaterialLabel TextBloc1Data;
        //   private MaterialSkin.Controls.MaterialLabel TextBloc1Hash;
        //   private MaterialSkin.Controls.MaterialLabel TextBloc1Prev;
        //  private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc1Hash;
        //  private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc1HashPrev;
        //  private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc1Data;
        //   private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc1Nonce;
        //  private MaterialSkin.Controls.MaterialButton btnBloc1MainAll;
        //  private MaterialSkin.Controls.MaterialButton btnBloc1Main;
        //  private MaterialSkin.Controls.MaterialLabel materialLabel2;
        //  private MaterialSkin.Controls.MaterialLabel labelBloc1Time;
        //  private System.Windows.Forms.GroupBox groupBox3;
        //  private MaterialSkin.Controls.MaterialLabel materialLabel16;
        //  private MaterialSkin.Controls.MaterialLabel materialLabel19;
        // private MaterialSkin.Controls.MaterialLabel LableBloc3Timeprev;
        //  private MaterialSkin.Controls.MaterialLabel labelBloc3Time;
        //   private MaterialSkin.Controls.MaterialButton btnBloc3MainAll;
        //  private MaterialSkin.Controls.MaterialButton btnBloc3Main;
        //   private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc3Hash;
        //  private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc3HashPrev;
        // private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc3Data;
        // private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc3Nonce;
        // private MaterialSkin.Controls.MaterialLabel TextBloc3Hash;
        //private MaterialSkin.Controls.MaterialLabel TextBloc3Prev;
        //private MaterialSkin.Controls.MaterialLabel TextBloc3Data;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc3BlocNumber;
        //private MaterialSkin.Controls.MaterialLabel TextBloc3Nonce;
        //private MaterialSkin.Controls.MaterialLabel TextBloc3BlocNumber;
        //private System.Windows.Forms.GroupBox groupBox2;
        //private MaterialSkin.Controls.MaterialLabel materialLabel8;
        //private MaterialSkin.Controls.MaterialLabel LableBloc2Timeprev;
        //private MaterialSkin.Controls.MaterialLabel labelBloc2Time;
        //private MaterialSkin.Controls.MaterialButton btnBloc2MainAll;
        //private MaterialSkin.Controls.MaterialButton btnBloc2Main;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc2Hash;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc2HashPrev;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc2Data;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc2Nonce;
        //private MaterialSkin.Controls.MaterialLabel TextBloc2Hash;
        //private MaterialSkin.Controls.MaterialLabel TextBloc2Prev;
        //private MaterialSkin.Controls.MaterialLabel TextBloc2Data;
        // private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc2BlocNumber;
        //private MaterialSkin.Controls.MaterialLabel TextBloc2Nonce;
        //private MaterialSkin.Controls.MaterialLabel TextBloc2BlocNumber;
        public System.Windows.Forms.Panel panelBlockchain;
      //  private System.Windows.Forms.GroupBox groupBox4;
       // private MaterialSkin.Controls.MaterialLabel LableBloc4Timeprev;
        //private MaterialSkin.Controls.MaterialLabel labelBloc4Time;
        //private MaterialSkin.Controls.MaterialButton btnBloc4MainAll;
        //private MaterialSkin.Controls.MaterialButton btnBloc4Main;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc4Hash;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc4HashPrev;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc4Data;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc4Nonce;
        //private MaterialSkin.Controls.MaterialLabel TextBloc4Hash;
       // private MaterialSkin.Controls.MaterialLabel TextBloc4Prev;
        //private MaterialSkin.Controls.MaterialLabel TextBloc4Data;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc4BlocNumber;
        //private MaterialSkin.Controls.MaterialLabel TextBloc4Nonce;
        //private MaterialSkin.Controls.MaterialLabel TextBloc4BlocNumber;
        //private System.Windows.Forms.GroupBox grup5bloc;
        //private MaterialSkin.Controls.MaterialLabel LableBloc5Timeprev;
        //private MaterialSkin.Controls.MaterialLabel labelBloc5Time;
        //private MaterialSkin.Controls.MaterialButton btnBloc5MainAll;
        //private MaterialSkin.Controls.MaterialButton btnBloc5Main;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc5Hash;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc5HashPrev;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc5Data;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc5Nonce;
        //private MaterialSkin.Controls.MaterialLabel TextBloc5Hash;
        //private MaterialSkin.Controls.MaterialLabel TextBloc6Prev;
        //private MaterialSkin.Controls.MaterialLabel TextBloc5Data;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc5BlocNumber;
        //private MaterialSkin.Controls.MaterialLabel TextBloc5Nonce;
        //private MaterialSkin.Controls.MaterialLabel TextBloc5BlocNumber;
        //private System.Windows.Forms.GroupBox groupBox6;
        //private MaterialSkin.Controls.MaterialLabel LableBloc6Timeprev;
        //private MaterialSkin.Controls.MaterialLabel labelBloc6Time;
        //private MaterialSkin.Controls.MaterialButton btnBloc6MainAll;
        //private MaterialSkin.Controls.MaterialButton btnBloc6Main;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc6Hash;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc6HashPrev;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc6Data;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc6Nonce;
        //private MaterialSkin.Controls.MaterialLabel TextBloc6Hash;
        //private MaterialSkin.Controls.MaterialLabel TextBloc66Prev;
        //private MaterialSkin.Controls.MaterialLabel TextBloc6Data;
        //private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc6BlocNumber;
        //private MaterialSkin.Controls.MaterialLabel TextBloc6Nonce;
       // private MaterialSkin.Controls.MaterialLabel TextBloc6BlocNumber;
        private MaterialSkin.Controls.MaterialMultiLineTextBox BoxhowManyZeros;
        private MaterialSkin.Controls.MaterialLabel LabelhowManyZeros;
        private MaterialSkin.Controls.MaterialLabel LabelMax;
        private MaterialSkin.Controls.MaterialMultiLineTextBox BoxMaximumTray;
    }
}

