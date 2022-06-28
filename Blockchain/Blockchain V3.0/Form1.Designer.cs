namespace Blockchain_V3._0
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.tabPageBlockchain = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageSetings = new System.Windows.Forms.TabPage();
            this.LabelMax = new MaterialSkin.Controls.MaterialLabel();
            this.BoxMaximumTray = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.LabelhowManyZeros = new MaterialSkin.Controls.MaterialLabel();
            this.BoxhowManyZeros = new MaterialSkin.Controls.MaterialMultiLineTextBox();

            //_____________________________________________________________________________________________

            this.TextBlocFrequency = new MaterialSkin.Controls.MaterialLabel[cik];
            this.TextBlocTime = new MaterialSkin.Controls.MaterialLabel[cik];
            this.TextBlocHash = new MaterialSkin.Controls.MaterialLabel[cik];
            this.TextBlocPrev = new MaterialSkin.Controls.MaterialLabel[cik];
            this.TextBlocData = new MaterialSkin.Controls.MaterialLabel[cik];
            this.TextBlocNonce = new MaterialSkin.Controls.MaterialLabel[cik];
            this.TextBlocBlocNumber = new MaterialSkin.Controls.MaterialLabel[cik];
            this.MultiTextBlocBlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox[cik];
            this.MultiTextBlocNonce = new MaterialSkin.Controls.MaterialMultiLineTextBox[cik];
            this.MultiLineBlocData = new MaterialSkin.Controls.MaterialMultiLineTextBox[cik];
            this.MultiTextBlocHashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox[cik];
            this.MultiLineBlocHash = new MaterialSkin.Controls.MaterialMultiLineTextBox[cik];
            this.btnBlocMainAll = new MaterialSkin.Controls.MaterialButton[cik];
            this.btnBlocMain = new MaterialSkin.Controls.MaterialButton[cik];


            this.grupBloc = new System.Windows.Forms.GroupBox[cik];
            this.howRow = (cik / 3);
            if (howRow == 0)
                this.howRow = 1;
            if (cik % 3 != 0)
                this.howRow++;

            point = new System.Drawing.Point[howRow * 3];
            for (int i = 0; i < howRow; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int x = j * 431;
                    int y = i * 629 + 3;
                    point[counter] = new System.Drawing.Point(x, y);
                    this.counter++;
                }

            }
            for (int i = 0; i < cik; i++)
            {
                this.grupBloc[i] = new System.Windows.Forms.GroupBox();


                this.grupBloc[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
                this.grupBloc[i].Location = new System.Drawing.Point(point[i].X, point[i].Y);
                this.grupBloc[i].Name = $"groupBox{i + 1}";
                this.grupBloc[i].Size = new System.Drawing.Size(425, 612);
                this.grupBloc[i].TabIndex = 5;
                this.grupBloc[i].TabStop = false;
                this.grupBloc[i].Text = $"Block {i + 1}";
                this.panel1.Controls.Add(this.grupBloc[i]);
            }


            //_____________________________________________________________________________________________

            this.materialTabControl1.SuspendLayout();
            this.tabPageBlockchain.SuspendLayout();
            this.tabPageSetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blockchain-1.png");
            this.imageList1.Images.SetKeyName(1, "blockchain-2.png");
            this.imageList1.Images.SetKeyName(2, "file.png");
            this.imageList1.Images.SetKeyName(3, "info.png");
            this.imageList1.Images.SetKeyName(4, "setting.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageFile);
            this.materialTabControl1.Controls.Add(this.tabPageInfo);
            this.materialTabControl1.Controls.Add(this.tabPageBlockchain);
            this.materialTabControl1.Controls.Add(this.tabPageSetings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1354, 1033);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageFile
            // 
            this.tabPageFile.ImageKey = "file.png";
            this.tabPageFile.Location = new System.Drawing.Point(4, 39);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(1346, 990);
            this.tabPageFile.TabIndex = 0;
            this.tabPageFile.Text = " File";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.ImageKey = "info.png";
            this.tabPageInfo.Location = new System.Drawing.Point(4, 39);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(1346, 990);
            this.tabPageInfo.TabIndex = 1;
            this.tabPageInfo.Text = "  Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageBlockchain
            // 
            this.tabPageBlockchain.Controls.Add(this.panel1);
            this.tabPageBlockchain.ImageKey = "blockchain-2.png";
            this.tabPageBlockchain.Location = new System.Drawing.Point(4, 39);
            this.tabPageBlockchain.Name = "tabPageBlockchain";
            this.tabPageBlockchain.Size = new System.Drawing.Size(1346, 990);
            this.tabPageBlockchain.TabIndex = 2;
            this.tabPageBlockchain.Text = "  Blockchain";
            this.tabPageBlockchain.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 

            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, howRow * 629 + 600);
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(howRow * 629 + 6, 1200);
            this.panel1.MinimumSize = new System.Drawing.Size(howRow * 629 + 6, 1200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(howRow * 629 + 6, 1200);
            this.panel1.TabIndex = 0;
            //---------------------------------------------------------------------------------------
            for (int i = 0; i < grupBloc.Length; i++)
            {
                this.panel1.Controls.Add(this.grupBloc[i]);
            }
            for (int i = 0; i < grupBloc.Length; i++)
            {
                this.TextBlocFrequency[i] = new MaterialSkin.Controls.MaterialLabel();

                this.TextBlocFrequency[i].AutoSize = true;
                this.TextBlocFrequency[i].Depth = 0;
                this.TextBlocFrequency[i].Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.TextBlocFrequency[i].Location = new System.Drawing.Point(162, 556);
                this.TextBlocFrequency[i].MaximumSize = new System.Drawing.Size(150, 30);
                this.TextBlocFrequency[i].MinimumSize = new System.Drawing.Size(150, 30);
                this.TextBlocFrequency[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.TextBlocFrequency[i].Name = $"TextBloc{i}Timeprev";
                this.TextBlocFrequency[i].Size = new System.Drawing.Size(1, 0);
                this.TextBlocFrequency[i].TabIndex = 16;
                this.grupBloc[i].Controls.Add(this.TextBlocFrequency[i]);

                this.TextBlocTime[i] = new MaterialSkin.Controls.MaterialLabel();
                this.TextBlocTime[i].AutoSize = true;
                this.TextBlocTime[i].Depth = 0;
                this.TextBlocTime[i].Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.TextBlocTime[i].Location = new System.Drawing.Point(6, 556);
                this.TextBlocTime[i].MaximumSize = new System.Drawing.Size(150, 30);
                this.TextBlocTime[i].MinimumSize = new System.Drawing.Size(150, 30);
                this.TextBlocTime[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.TextBlocTime[i].Name = $"TextBloc{i}Time";
                this.TextBlocTime[i].Size = new System.Drawing.Size(1, 0);
                this.TextBlocTime[i].TabIndex = 15;
                this.grupBloc[i].Controls.Add(this.TextBlocTime[i]);

                this.TextBlocHash[i] = new MaterialSkin.Controls.MaterialLabel();
                this.TextBlocHash[i].AutoSize = true;
                this.TextBlocHash[i].Depth = 0;
                this.TextBlocHash[i].Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.TextBlocHash[i].Location = new System.Drawing.Point(6, 433);
                this.TextBlocHash[i].MaximumSize = new System.Drawing.Size(100, 30);
                this.TextBlocHash[i].MinimumSize = new System.Drawing.Size(100, 30);
                this.TextBlocHash[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.TextBlocHash[i].Name = $"TextBloc{i}Hash";
                this.TextBlocHash[i].Size = new System.Drawing.Size(38, 19);
                this.TextBlocHash[i].TabIndex = 8;
                this.TextBlocHash[i].Text = "Hash";
                this.grupBloc[i].Controls.Add(this.TextBlocHash[i]);

                this.TextBlocPrev[i] = new MaterialSkin.Controls.MaterialLabel();
                this.TextBlocPrev[i].AutoSize = true;
                this.TextBlocPrev[i].Depth = 0;
                this.TextBlocPrev[i].Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.TextBlocPrev[i].Location = new System.Drawing.Point(6, 388);
                this.TextBlocPrev[i].MaximumSize = new System.Drawing.Size(100, 30);
                this.TextBlocPrev[i].MinimumSize = new System.Drawing.Size(100, 30);
                this.TextBlocPrev[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.TextBlocPrev[i].Name = $"TextBloc{i}Prev";
                this.TextBlocPrev[i].Size = new System.Drawing.Size(32, 19);
                this.TextBlocPrev[i].TabIndex = 7;
                this.TextBlocPrev[i].Text = "Prev";
                this.grupBloc[i].Controls.Add(this.TextBlocPrev[i]);

                this.TextBlocData[i] = new MaterialSkin.Controls.MaterialLabel();
                this.TextBlocData[i].AutoSize = true;
                this.TextBlocData[i].Depth = 0;
                this.TextBlocData[i].Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.TextBlocData[i].Location = new System.Drawing.Point(6, 123);
                this.TextBlocData[i].MaximumSize = new System.Drawing.Size(100, 30);
                this.TextBlocData[i].MinimumSize = new System.Drawing.Size(100, 30);
                this.TextBlocData[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.TextBlocData[i].Name = $"TextBloc{i}Data";
                this.TextBlocData[i].Size = new System.Drawing.Size(35, 19);
                this.TextBlocData[i].TabIndex = 6;
                this.TextBlocData[i].Text = "Data";
                this.grupBloc[i].Controls.Add(this.TextBlocData[i]);

                this.TextBlocNonce[i] = new MaterialSkin.Controls.MaterialLabel();
                this.TextBlocNonce[i].AutoSize = true;
                this.TextBlocNonce[i].Depth = 0;
                this.TextBlocNonce[i].Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.TextBlocNonce[i].Location = new System.Drawing.Point(6, 78);
                this.TextBlocNonce[i].MaximumSize = new System.Drawing.Size(100, 30);
                this.TextBlocNonce[i].MinimumSize = new System.Drawing.Size(100, 30);
                this.TextBlocNonce[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.TextBlocNonce[i].Name = $"TextBloc{i}Nonce";
                this.TextBlocNonce[i].Size = new System.Drawing.Size(46, 19);
                this.TextBlocNonce[i].TabIndex = 4;
                this.TextBlocNonce[i].Text = "Nonce";
                this.grupBloc[i].Controls.Add(this.TextBlocNonce[i]);

                this.TextBlocBlocNumber[i] = new MaterialSkin.Controls.MaterialLabel();
                this.TextBlocBlocNumber[i].AutoSize = true;
                this.TextBlocBlocNumber[i].Depth = 0;
                this.TextBlocBlocNumber[i].Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.TextBlocBlocNumber[i].Location = new System.Drawing.Point(6, 33);
                this.TextBlocBlocNumber[i].MaximumSize = new System.Drawing.Size(100, 30);
                this.TextBlocBlocNumber[i].MinimumSize = new System.Drawing.Size(100, 30);
                this.TextBlocBlocNumber[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.TextBlocBlocNumber[i].Name = $"TextBloc{i}Number";
                this.TextBlocBlocNumber[i].Size = new System.Drawing.Size(90, 19);
                this.TextBlocBlocNumber[i].TabIndex = 1;
                this.TextBlocBlocNumber[i].Text = "Bloc number";
                this.grupBloc[i].Controls.Add(this.TextBlocBlocNumber[i]);

                this.MultiTextBlocBlocNumber[i] = new MaterialSkin.Controls.MaterialMultiLineTextBox();
                this.MultiTextBlocBlocNumber[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.MultiTextBlocBlocNumber[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.MultiTextBlocBlocNumber[i].Depth = 0;
                this.MultiTextBlocBlocNumber[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.MultiTextBlocBlocNumber[i].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.MultiTextBlocBlocNumber[i].Location = new System.Drawing.Point(112, 33);
                this.MultiTextBlocBlocNumber[i].MaximumSize = new System.Drawing.Size(300, 30);
                this.MultiTextBlocBlocNumber[i].MaxLength = 15;
                this.MultiTextBlocBlocNumber[i].MinimumSize = new System.Drawing.Size(300, 30);
                this.MultiTextBlocBlocNumber[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.MultiTextBlocBlocNumber[i].Multiline = false;
                this.MultiTextBlocBlocNumber[i].Name = $"{i}";
                this.MultiTextBlocBlocNumber[i].ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
                this.MultiTextBlocBlocNumber[i].Size = new System.Drawing.Size(300, 30);
                this.MultiTextBlocBlocNumber[i].TabIndex = 5;
                this.MultiTextBlocBlocNumber[i].Text = $"{i + 1}";
                this.MultiTextBlocBlocNumber[i].TextChanged += new System.EventHandler(this.BlockNumber_TextChangedk);
                this.grupBloc[i].Controls.Add(this.MultiTextBlocBlocNumber[i]);


                this.MultiTextBlocNonce[i] = new MaterialSkin.Controls.MaterialMultiLineTextBox();
                this.MultiTextBlocNonce[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.MultiTextBlocNonce[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.MultiTextBlocNonce[i].Depth = 0;
                this.MultiTextBlocNonce[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.MultiTextBlocNonce[i].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.MultiTextBlocNonce[i].Location = new System.Drawing.Point(112, 78);
                this.MultiTextBlocNonce[i].MaximumSize = new System.Drawing.Size(300, 30);
                this.MultiTextBlocNonce[i].MaxLength = 20;
                this.MultiTextBlocNonce[i].MinimumSize = new System.Drawing.Size(300, 30);
                this.MultiTextBlocNonce[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.MultiTextBlocNonce[i].Multiline = false;
                this.MultiTextBlocNonce[i].Name = $"{i}";
                this.MultiTextBlocNonce[i].ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
                this.MultiTextBlocNonce[i].Size = new System.Drawing.Size(300, 30);
                this.MultiTextBlocNonce[i].TabIndex = 9;
                this.MultiTextBlocNonce[i].Text = "";
                this.MultiTextBlocNonce[i].TextChanged += new System.EventHandler(this.BlockNonce_TextChangedk);
                this.grupBloc[i].Controls.Add(this.MultiTextBlocNonce[i]);

                this.MultiLineBlocData[i] = new MaterialSkin.Controls.MaterialMultiLineTextBox();
                this.MultiLineBlocData[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.MultiLineBlocData[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.MultiLineBlocData[i].Depth = 0;
                this.MultiLineBlocData[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.MultiLineBlocData[i].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.MultiLineBlocData[i].Location = new System.Drawing.Point(112, 123);
                this.MultiLineBlocData[i].MaximumSize = new System.Drawing.Size(300, 250);
                this.MultiLineBlocData[i].MinimumSize = new System.Drawing.Size(300, 250);
                this.MultiLineBlocData[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.MultiLineBlocData[i].Name = $"{i}";
                this.MultiLineBlocData[i].Size = new System.Drawing.Size(300, 250);
                this.MultiLineBlocData[i].TabIndex = 10;
                this.MultiLineBlocData[i].Text = "";
                this.MultiLineBlocData[i].TextChanged += new System.EventHandler(this.BlockData_TextChangedk);
                this.grupBloc[i].Controls.Add(this.MultiLineBlocData[i]);

                this.MultiTextBlocHashPrev[i] = new MaterialSkin.Controls.MaterialMultiLineTextBox();
                this.MultiTextBlocHashPrev[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.MultiTextBlocHashPrev[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.MultiTextBlocHashPrev[i].Depth = 0;
                this.MultiTextBlocHashPrev[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.MultiTextBlocHashPrev[i].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.MultiTextBlocHashPrev[i].Location = new System.Drawing.Point(112, 387);
                this.MultiTextBlocHashPrev[i].MaximumSize = new System.Drawing.Size(300, 35);
                this.MultiTextBlocHashPrev[i].MinimumSize = new System.Drawing.Size(300, 35);
                this.MultiTextBlocHashPrev[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.MultiTextBlocHashPrev[i].Name = $"MultiTextBloc{i}HashPrev";
                this.MultiTextBlocHashPrev[i].ReadOnly = true;
                this.MultiTextBlocHashPrev[i].ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
                this.MultiTextBlocHashPrev[i].Size = new System.Drawing.Size(300, 35);
                this.MultiTextBlocHashPrev[i].TabIndex = 11;
                this.MultiTextBlocHashPrev[i].Text = "";
                this.grupBloc[i].Controls.Add(this.MultiTextBlocHashPrev[i]);

                this.MultiLineBlocHash[i] = new MaterialSkin.Controls.MaterialMultiLineTextBox();
                this.MultiLineBlocHash[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.MultiLineBlocHash[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.MultiLineBlocHash[i].Depth = 0;
                this.MultiLineBlocHash[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.MultiLineBlocHash[i].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.MultiLineBlocHash[i].Location = new System.Drawing.Point(112, 433);
                this.MultiLineBlocHash[i].MaximumSize = new System.Drawing.Size(300, 35);
                this.MultiLineBlocHash[i].MinimumSize = new System.Drawing.Size(300, 35);
                this.MultiLineBlocHash[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.MultiLineBlocHash[i].Name = $"MultiLineBloc{i}Hash";
                this.MultiLineBlocHash[i].ReadOnly = true;
                this.MultiLineBlocHash[i].ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
                this.MultiLineBlocHash[i].Size = new System.Drawing.Size(300, 35);
                this.MultiLineBlocHash[i].TabIndex = 12;
                this.MultiLineBlocHash[i].Text = "";
                this.grupBloc[i].Controls.Add(this.MultiLineBlocHash[i]);

                this.btnBlocMainAll[i] = new MaterialSkin.Controls.MaterialButton();
                this.btnBlocMainAll[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                this.btnBlocMainAll[i].Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                this.btnBlocMainAll[i].Depth = 0;
                this.btnBlocMainAll[i].HighEmphasis = true;
                this.btnBlocMainAll[i].Icon = null;
                this.btnBlocMainAll[i].Location = new System.Drawing.Point(254, 502);
                this.btnBlocMainAll[i].Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                this.btnBlocMainAll[i].MaximumSize = new System.Drawing.Size(150, 35);
                this.btnBlocMainAll[i].MinimumSize = new System.Drawing.Size(150, 35);
                this.btnBlocMainAll[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.btnBlocMainAll[i].Name = $"{i}";
                this.btnBlocMainAll[i].NoAccentTextColor = System.Drawing.Color.Empty;
                this.btnBlocMainAll[i].Size = new System.Drawing.Size(150, 35);
                this.btnBlocMainAll[i].TabIndex = 14;
                this.btnBlocMainAll[i].Text = "Main All";
                this.btnBlocMainAll[i].Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                this.btnBlocMainAll[i].UseAccentColor = false;
                this.btnBlocMainAll[i].UseVisualStyleBackColor = true;
                this.btnBlocMainAll[i].Click += new System.EventHandler(this.btnBlockMainAll_Click);
                this.grupBloc[i].Controls.Add(this.btnBlocMainAll[i]);

                this.btnBlocMain[i] = new MaterialSkin.Controls.MaterialButton();
                this.btnBlocMain[i].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                this.btnBlocMain[i].Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                this.btnBlocMain[i].Depth = 0;
                this.btnBlocMain[i].HighEmphasis = true;
                this.btnBlocMain[i].Icon = null;
                this.btnBlocMain[i].Location = new System.Drawing.Point(9, 502);
                this.btnBlocMain[i].Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                this.btnBlocMain[i].MaximumSize = new System.Drawing.Size(150, 35);
                this.btnBlocMain[i].MinimumSize = new System.Drawing.Size(150, 35);
                this.btnBlocMain[i].MouseState = MaterialSkin.MouseState.HOVER;
                this.btnBlocMain[i].Name = $"{i}";
                this.btnBlocMain[i].NoAccentTextColor = System.Drawing.Color.Empty;
                this.btnBlocMain[i].Size = new System.Drawing.Size(150, 35);
                this.btnBlocMain[i].TabIndex = 13;
                this.btnBlocMain[i].Text = "Main";
                this.btnBlocMain[i].Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                this.btnBlocMain[i].UseAccentColor = false;
                this.btnBlocMain[i].UseVisualStyleBackColor = true;
                this.btnBlocMain[i].Click += new System.EventHandler(this.btnBloc1Main_Click);
                this.grupBloc[i].Controls.Add(this.btnBlocMain[i]);
            }

            //---------------------------------------------------------------------------------------
            // 
            // tabPageSetings
            // 
            this.tabPageSetings.Controls.Add(this.LabelMax);
            this.tabPageSetings.Controls.Add(this.BoxMaximumTray);
            this.tabPageSetings.Controls.Add(this.LabelhowManyZeros);
            this.tabPageSetings.Controls.Add(this.BoxhowManyZeros);
            this.tabPageSetings.ImageKey = "setting.png";
            this.tabPageSetings.Location = new System.Drawing.Point(4, 39);
            this.tabPageSetings.Name = "tabPageSetings";
            this.tabPageSetings.Size = new System.Drawing.Size(1346, 990);
            this.tabPageSetings.TabIndex = 3;
            this.tabPageSetings.Text = "  Setings";
            this.tabPageSetings.UseVisualStyleBackColor = true;
            // 
            // LabelMax
            // 
            this.LabelMax.AutoSize = true;
            this.LabelMax.Depth = 0;
            this.LabelMax.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelMax.Location = new System.Drawing.Point(242, 135);
            this.LabelMax.MaximumSize = new System.Drawing.Size(100, 30);
            this.LabelMax.MinimumSize = new System.Drawing.Size(100, 30);
            this.LabelMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.Size = new System.Drawing.Size(217, 19);
            this.LabelMax.TabIndex = 13;
            this.LabelMax.Text = "Maximum number of attempts";
            // 
            // BoxMaximumTray
            // 
            this.BoxMaximumTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BoxMaximumTray.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxMaximumTray.Depth = 0;
            this.BoxMaximumTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxMaximumTray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoxMaximumTray.Location = new System.Drawing.Point(487, 134);
            this.BoxMaximumTray.MaximumSize = new System.Drawing.Size(300, 30);
            this.BoxMaximumTray.MaxLength = 15;
            this.BoxMaximumTray.MinimumSize = new System.Drawing.Size(300, 30);
            this.BoxMaximumTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.BoxMaximumTray.Multiline = false;
            this.BoxMaximumTray.Name = "BoxMaximumTray";
            this.BoxMaximumTray.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BoxMaximumTray.Size = new System.Drawing.Size(300, 30);
            this.BoxMaximumTray.TabIndex = 12;
            this.BoxMaximumTray.Text = "10000000";
            this.BoxMaximumTray.TextChanged += new System.EventHandler(this.MaximumTray_TextChangedk);
            // 
            // LabelhowManyZeros
            // 
            this.LabelhowManyZeros.AutoSize = true;
            this.LabelhowManyZeros.Depth = 0;
            this.LabelhowManyZeros.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelhowManyZeros.Location = new System.Drawing.Point(242, 82);
            this.LabelhowManyZeros.MaximumSize = new System.Drawing.Size(100, 30);
            this.LabelhowManyZeros.MinimumSize = new System.Drawing.Size(100, 30);
            this.LabelhowManyZeros.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelhowManyZeros.Name = "LabelhowManyZeros";
            this.LabelhowManyZeros.Size = new System.Drawing.Size(178, 19);
            this.LabelhowManyZeros.TabIndex = 11;
            this.LabelhowManyZeros.Text = "Proof of work complexity";
            // 
            // BoxhowManyZeros
            // 
            this.BoxhowManyZeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BoxhowManyZeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxhowManyZeros.Depth = 0;
            this.BoxhowManyZeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxhowManyZeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoxhowManyZeros.Location = new System.Drawing.Point(487, 81);
            this.BoxhowManyZeros.MaximumSize = new System.Drawing.Size(300, 30);
            this.BoxhowManyZeros.MaxLength = 1;
            this.BoxhowManyZeros.MinimumSize = new System.Drawing.Size(300, 30);
            this.BoxhowManyZeros.MouseState = MaterialSkin.MouseState.HOVER;
            this.BoxhowManyZeros.Multiline = false;
            this.BoxhowManyZeros.Name = "BoxhowManyZeros";
            this.BoxhowManyZeros.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BoxhowManyZeros.Size = new System.Drawing.Size(300, 30);
            this.BoxhowManyZeros.TabIndex = 10;
            this.BoxhowManyZeros.Text = "4";
            this.BoxhowManyZeros.TextChanged += new System.EventHandler(this.howManyZeros_TextChangedk);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 7200);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            // this.DrawerTabControl = this.materialTabControl1;
            this.MaximumSize = new System.Drawing.Size(1360, 1200);
            this.MinimumSize = new System.Drawing.Size(1360, 726);
            this.Name = "Form1";
            this.Text = "Blockchain Demo";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageBlockchain.ResumeLayout(false);
            this.tabPageSetings.ResumeLayout(false);
            this.tabPageSetings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        //_____________________________________________________________________________________________
        private System.Windows.Forms.GroupBox[] grupBloc;

        private int howRow;
        private int counter;
        private System.Drawing.Point[] point;

        private MaterialSkin.Controls.MaterialLabel[] TextBlocFrequency;
        private MaterialSkin.Controls.MaterialLabel[] TextBlocTime;
        private MaterialSkin.Controls.MaterialLabel[] TextBlocHash;
        private MaterialSkin.Controls.MaterialLabel[] TextBlocPrev;
        private MaterialSkin.Controls.MaterialLabel[] TextBlocData;
        private MaterialSkin.Controls.MaterialLabel[] TextBlocNonce;
        private MaterialSkin.Controls.MaterialLabel[] TextBlocBlocNumber;
        private MaterialSkin.Controls.MaterialMultiLineTextBox[] MultiTextBlocBlocNumber;
        private MaterialSkin.Controls.MaterialMultiLineTextBox[] MultiTextBlocNonce;
        private MaterialSkin.Controls.MaterialMultiLineTextBox[] MultiLineBlocData;
        private MaterialSkin.Controls.MaterialMultiLineTextBox[] MultiTextBlocHashPrev;
        private MaterialSkin.Controls.MaterialMultiLineTextBox[] MultiLineBlocHash;
        private MaterialSkin.Controls.MaterialButton[] btnBlocMainAll;
        private MaterialSkin.Controls.MaterialButton[] btnBlocMain;

        //_____________________________________________________________________________________________

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageBlockchain;
        private System.Windows.Forms.TabPage tabPageSetings;
        private MaterialSkin.Controls.MaterialLabel LabelMax;
        private MaterialSkin.Controls.MaterialMultiLineTextBox BoxMaximumTray;
        private MaterialSkin.Controls.MaterialLabel LabelhowManyZeros;
        private MaterialSkin.Controls.MaterialMultiLineTextBox BoxhowManyZeros;
        public System.Windows.Forms.Panel panel1;
    }
}

