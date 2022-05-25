namespace Blockchain_Demo
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabBloc = new System.Windows.Forms.TabPage();
            this.grup1bloc = new System.Windows.Forms.GroupBox();
            this.TextBloc1BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            this.panelBlockchain = new System.Windows.Forms.Panel();
            this.tabSeting = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TextBloc1Nonce = new MaterialSkin.Controls.MaterialLabel();
            this.MultiTextBloc1BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TextBloc1Data = new MaterialSkin.Controls.MaterialLabel();
            this.TextBloc1Prev = new MaterialSkin.Controls.MaterialLabel();
            this.TextBloc1Hash = new MaterialSkin.Controls.MaterialLabel();
            this.MultiTextBloc1Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiLineBloc1Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiTextBloc1HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiLineBloc1Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnBloc1Main = new MaterialSkin.Controls.MaterialButton();
            this.btnBloc1MainAll = new MaterialSkin.Controls.MaterialButton();
            this.labelBloc1Time = new MaterialSkin.Controls.MaterialLabel();
            this.LableBloc1Timeprev = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.LableBloc2Timeprev = new MaterialSkin.Controls.MaterialLabel();
            this.labelBloc2Time = new MaterialSkin.Controls.MaterialLabel();
            this.btnBloc2MainAll = new MaterialSkin.Controls.MaterialButton();
            this.btnBloc2Main = new MaterialSkin.Controls.MaterialButton();
            this.MultiLineBloc2Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiTextBloc2HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiLineBloc2Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiTextBloc2Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TextBloc2Hash = new MaterialSkin.Controls.MaterialLabel();
            this.TextBloc2Prev = new MaterialSkin.Controls.MaterialLabel();
            this.TextBloc2Data = new MaterialSkin.Controls.MaterialLabel();
            this.MultiTextBloc2BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TextBloc2Nonce = new MaterialSkin.Controls.MaterialLabel();
            this.TextBloc2BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.LableBloc3Timeprev = new MaterialSkin.Controls.MaterialLabel();
            this.labelBloc3Time = new MaterialSkin.Controls.MaterialLabel();
            this.btnBloc3MainAll = new MaterialSkin.Controls.MaterialButton();
            this.btnBloc3Main = new MaterialSkin.Controls.MaterialButton();
            this.MultiLineBloc3Hash = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiTextBloc3HashPrev = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiLineBloc3Data = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.MultiTextBloc3Nonce = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TextBloc3Hash = new MaterialSkin.Controls.MaterialLabel();
            this.TextBloc3Prev = new MaterialSkin.Controls.MaterialLabel();
            this.TextBloc3Data = new MaterialSkin.Controls.MaterialLabel();
            this.MultiTextBloc3BlocNumber = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TextBloc3Nonce = new MaterialSkin.Controls.MaterialLabel();
            this.TextBloc3BlocNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabBloc.SuspendLayout();
            this.grup1bloc.SuspendLayout();
            this.panelBlockchain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabFile);
            this.materialTabControl1.Controls.Add(this.tabInfo);
            this.materialTabControl1.Controls.Add(this.tabBloc);
            this.materialTabControl1.Controls.Add(this.tabSeting);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1360, 720);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabFile
            // 
            this.tabFile.ImageKey = "file.png";
            this.tabFile.Location = new System.Drawing.Point(4, 39);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(1352, 717);
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
            this.tabInfo.Size = new System.Drawing.Size(1352, 717);
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
            this.tabBloc.Size = new System.Drawing.Size(1352, 677);
            this.tabBloc.TabIndex = 2;
            this.tabBloc.Text = "  Blockchain";
            this.tabBloc.UseVisualStyleBackColor = true;
            // 
            // grup1bloc
            // 
            this.grup1bloc.Controls.Add(this.materialLabel2);
            this.grup1bloc.Controls.Add(this.LableBloc1Timeprev);
            this.grup1bloc.Controls.Add(this.labelBloc1Time);
            this.grup1bloc.Controls.Add(this.btnBloc1MainAll);
            this.grup1bloc.Controls.Add(this.btnBloc1Main);
            this.grup1bloc.Controls.Add(this.MultiLineBloc1Hash);
            this.grup1bloc.Controls.Add(this.MultiTextBloc1HashPrev);
            this.grup1bloc.Controls.Add(this.MultiLineBloc1Data);
            this.grup1bloc.Controls.Add(this.MultiTextBloc1Nonce);
            this.grup1bloc.Controls.Add(this.TextBloc1Hash);
            this.grup1bloc.Controls.Add(this.TextBloc1Prev);
            this.grup1bloc.Controls.Add(this.TextBloc1Data);
            this.grup1bloc.Controls.Add(this.MultiTextBloc1BlocNumber);
            this.grup1bloc.Controls.Add(this.TextBloc1Nonce);
            this.grup1bloc.Controls.Add(this.TextBloc1BlocNumber);
            this.grup1bloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.grup1bloc.Location = new System.Drawing.Point(0, 3);
            this.grup1bloc.Name = "grup1bloc";
            this.grup1bloc.Size = new System.Drawing.Size(425, 612);
            this.grup1bloc.TabIndex = 0;
            this.grup1bloc.TabStop = false;
            this.grup1bloc.Text = "Block";
            // 
            // TextBloc1BlocNumber
            // 
            this.TextBloc1BlocNumber.AutoSize = true;
            this.TextBloc1BlocNumber.Depth = 0;
            this.TextBloc1BlocNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc1BlocNumber.Location = new System.Drawing.Point(6, 33);
            this.TextBloc1BlocNumber.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1BlocNumber.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1BlocNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc1BlocNumber.Name = "TextBloc1BlocNumber";
            this.TextBloc1BlocNumber.Size = new System.Drawing.Size(100, 30);
            this.TextBloc1BlocNumber.TabIndex = 1;
            this.TextBloc1BlocNumber.Text = "Bloc number";
            // 
            // panelBlockchain
            // 
            this.panelBlockchain.AutoScroll = true;
            this.panelBlockchain.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panelBlockchain.AutoScrollMinSize = new System.Drawing.Size(0, 2500);
            this.panelBlockchain.AutoSize = true;
            this.panelBlockchain.Controls.Add(this.groupBox1);
            this.panelBlockchain.Controls.Add(this.groupBox2);
            this.panelBlockchain.Controls.Add(this.grup1bloc);
            this.panelBlockchain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBlockchain.Location = new System.Drawing.Point(0, 0);
            this.panelBlockchain.MaximumSize = new System.Drawing.Size(2000, 1200);
            this.panelBlockchain.MinimumSize = new System.Drawing.Size(2000, 1200);
            this.panelBlockchain.Name = "panelBlockchain";
            this.panelBlockchain.Size = new System.Drawing.Size(2000, 1200);
            this.panelBlockchain.TabIndex = 0;
            // 
            // tabSeting
            // 
            this.tabSeting.ImageKey = "setting.png";
            this.tabSeting.Location = new System.Drawing.Point(4, 39);
            this.tabSeting.Name = "tabSeting";
            this.tabSeting.Size = new System.Drawing.Size(1352, 717);
            this.tabSeting.TabIndex = 3;
            this.tabSeting.Text = "  Setings";
            this.tabSeting.UseVisualStyleBackColor = true;
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
            // TextBloc1Nonce
            // 
            this.TextBloc1Nonce.AutoSize = true;
            this.TextBloc1Nonce.Depth = 0;
            this.TextBloc1Nonce.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc1Nonce.Location = new System.Drawing.Point(6, 78);
            this.TextBloc1Nonce.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1Nonce.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1Nonce.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc1Nonce.Name = "TextBloc1Nonce";
            this.TextBloc1Nonce.Size = new System.Drawing.Size(100, 30);
            this.TextBloc1Nonce.TabIndex = 4;
            this.TextBloc1Nonce.Text = "Nonce";
            // 
            // MultiTextBloc1BlocNumber
            // 
            this.MultiTextBloc1BlocNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc1BlocNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc1BlocNumber.Depth = 0;
            this.MultiTextBloc1BlocNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc1BlocNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc1BlocNumber.Hint = "";
            this.MultiTextBloc1BlocNumber.Location = new System.Drawing.Point(112, 33);
            this.MultiTextBloc1BlocNumber.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1BlocNumber.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1BlocNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc1BlocNumber.Name = "MultiTextBloc1BlocNumber";
            this.MultiTextBloc1BlocNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc1BlocNumber.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1BlocNumber.TabIndex = 5;
            this.MultiTextBloc1BlocNumber.Text = "";
            this.MultiTextBloc1BlocNumber.TextChanged += new System.EventHandler(this.MultiTextBloc1BlocNumber_TextChanged);
            // 
            // TextBloc1Data
            // 
            this.TextBloc1Data.AutoSize = true;
            this.TextBloc1Data.Depth = 0;
            this.TextBloc1Data.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc1Data.Location = new System.Drawing.Point(6, 123);
            this.TextBloc1Data.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1Data.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc1Data.Name = "TextBloc1Data";
            this.TextBloc1Data.Size = new System.Drawing.Size(100, 30);
            this.TextBloc1Data.TabIndex = 6;
            this.TextBloc1Data.Text = "Data";
            // 
            // TextBloc1Prev
            // 
            this.TextBloc1Prev.AutoSize = true;
            this.TextBloc1Prev.Depth = 0;
            this.TextBloc1Prev.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc1Prev.Location = new System.Drawing.Point(6, 388);
            this.TextBloc1Prev.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1Prev.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1Prev.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc1Prev.Name = "TextBloc1Prev";
            this.TextBloc1Prev.Size = new System.Drawing.Size(100, 30);
            this.TextBloc1Prev.TabIndex = 7;
            this.TextBloc1Prev.Text = "Prev";
            // 
            // TextBloc1Hash
            // 
            this.TextBloc1Hash.AutoSize = true;
            this.TextBloc1Hash.Depth = 0;
            this.TextBloc1Hash.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc1Hash.Location = new System.Drawing.Point(6, 433);
            this.TextBloc1Hash.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1Hash.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc1Hash.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc1Hash.Name = "TextBloc1Hash";
            this.TextBloc1Hash.Size = new System.Drawing.Size(100, 30);
            this.TextBloc1Hash.TabIndex = 8;
            this.TextBloc1Hash.Text = "Hash";
            // 
            // MultiTextBloc1Nonce
            // 
            this.MultiTextBloc1Nonce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc1Nonce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc1Nonce.Depth = 0;
            this.MultiTextBloc1Nonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc1Nonce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc1Nonce.Hint = "";
            this.MultiTextBloc1Nonce.Location = new System.Drawing.Point(112, 78);
            this.MultiTextBloc1Nonce.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1Nonce.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1Nonce.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc1Nonce.Name = "MultiTextBloc1Nonce";
            this.MultiTextBloc1Nonce.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc1Nonce.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1Nonce.TabIndex = 9;
            this.MultiTextBloc1Nonce.Text = "";
            this.MultiTextBloc1Nonce.TextChanged += new System.EventHandler(this.MultiTextBloc1Nonce_TextChanged);
            // 
            // MultiLineBloc1Data
            // 
            this.MultiLineBloc1Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiLineBloc1Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiLineBloc1Data.Depth = 0;
            this.MultiLineBloc1Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiLineBloc1Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiLineBloc1Data.Hint = "";
            this.MultiLineBloc1Data.Location = new System.Drawing.Point(112, 123);
            this.MultiLineBloc1Data.MaximumSize = new System.Drawing.Size(300, 250);
            this.MultiLineBloc1Data.MinimumSize = new System.Drawing.Size(300, 250);
            this.MultiLineBloc1Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiLineBloc1Data.Name = "MultiLineBloc1Data";
            this.MultiLineBloc1Data.Size = new System.Drawing.Size(300, 250);
            this.MultiLineBloc1Data.TabIndex = 10;
            this.MultiLineBloc1Data.Text = "";
            this.MultiLineBloc1Data.TextChanged += new System.EventHandler(this.MultiLineBloc1Data_TextChanged);
            // 
            // MultiTextBloc1HashPrev
            // 
            this.MultiTextBloc1HashPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc1HashPrev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc1HashPrev.Depth = 0;
            this.MultiTextBloc1HashPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc1HashPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc1HashPrev.Hint = "";
            this.MultiTextBloc1HashPrev.Location = new System.Drawing.Point(112, 387);
            this.MultiTextBloc1HashPrev.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1HashPrev.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1HashPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc1HashPrev.Name = "MultiTextBloc1HashPrev";
            this.MultiTextBloc1HashPrev.ReadOnly = true;
            this.MultiTextBloc1HashPrev.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc1HashPrev.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc1HashPrev.TabIndex = 11;
            this.MultiTextBloc1HashPrev.Text = "";
            this.MultiTextBloc1HashPrev.TextChanged += new System.EventHandler(this.MultiTextBloc1HashPrev_TextChanged);
            // 
            // MultiLineBloc1Hash
            // 
            this.MultiLineBloc1Hash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiLineBloc1Hash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiLineBloc1Hash.Depth = 0;
            this.MultiLineBloc1Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiLineBloc1Hash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiLineBloc1Hash.Hint = "";
            this.MultiLineBloc1Hash.Location = new System.Drawing.Point(112, 433);
            this.MultiLineBloc1Hash.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiLineBloc1Hash.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiLineBloc1Hash.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiLineBloc1Hash.Name = "MultiLineBloc1Hash";
            this.MultiLineBloc1Hash.ReadOnly = true;
            this.MultiLineBloc1Hash.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiLineBloc1Hash.Size = new System.Drawing.Size(300, 30);
            this.MultiLineBloc1Hash.TabIndex = 12;
            this.MultiLineBloc1Hash.Text = "";
            this.MultiLineBloc1Hash.TextChanged += new System.EventHandler(this.MultiLineBloc1Hash_TextChanged);
            // 
            // btnBloc1Main
            // 
            this.btnBloc1Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBloc1Main.Depth = 0;
            this.btnBloc1Main.DrawShadows = true;
            this.btnBloc1Main.HighEmphasis = true;
            this.btnBloc1Main.Icon = null;
            this.btnBloc1Main.Location = new System.Drawing.Point(9, 502);
            this.btnBloc1Main.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBloc1Main.MaximumSize = new System.Drawing.Size(150, 35);
            this.btnBloc1Main.MinimumSize = new System.Drawing.Size(150, 35);
            this.btnBloc1Main.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBloc1Main.Name = "btnBloc1Main";
            this.btnBloc1Main.Size = new System.Drawing.Size(150, 35);
            this.btnBloc1Main.TabIndex = 13;
            this.btnBloc1Main.Text = "Main";
            this.btnBloc1Main.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBloc1Main.UseAccentColor = false;
            this.btnBloc1Main.UseVisualStyleBackColor = true;
            this.btnBloc1Main.Click += new System.EventHandler(this.btnBloc1Main_Click);
            // 
            // btnBloc1MainAll
            // 
            this.btnBloc1MainAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBloc1MainAll.Depth = 0;
            this.btnBloc1MainAll.DrawShadows = true;
            this.btnBloc1MainAll.HighEmphasis = true;
            this.btnBloc1MainAll.Icon = null;
            this.btnBloc1MainAll.Location = new System.Drawing.Point(254, 502);
            this.btnBloc1MainAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBloc1MainAll.MaximumSize = new System.Drawing.Size(150, 35);
            this.btnBloc1MainAll.MinimumSize = new System.Drawing.Size(150, 35);
            this.btnBloc1MainAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBloc1MainAll.Name = "btnBloc1MainAll";
            this.btnBloc1MainAll.Size = new System.Drawing.Size(150, 35);
            this.btnBloc1MainAll.TabIndex = 14;
            this.btnBloc1MainAll.Text = "Main All";
            this.btnBloc1MainAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBloc1MainAll.UseAccentColor = false;
            this.btnBloc1MainAll.UseVisualStyleBackColor = true;
            this.btnBloc1MainAll.Click += new System.EventHandler(this.btnBloc1MainAll_Click);
            // 
            // labelBloc1Time
            // 
            this.labelBloc1Time.AutoSize = true;
            this.labelBloc1Time.Depth = 0;
            this.labelBloc1Time.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelBloc1Time.Location = new System.Drawing.Point(6, 556);
            this.labelBloc1Time.MaximumSize = new System.Drawing.Size(100, 30);
            this.labelBloc1Time.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelBloc1Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBloc1Time.Name = "labelBloc1Time";
            this.labelBloc1Time.Size = new System.Drawing.Size(100, 30);
            this.labelBloc1Time.TabIndex = 15;
            this.labelBloc1Time.Text = "xxx";
            // 
            // LableBloc1Timeprev
            // 
            this.LableBloc1Timeprev.AutoSize = true;
            this.LableBloc1Timeprev.Depth = 0;
            this.LableBloc1Timeprev.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LableBloc1Timeprev.Location = new System.Drawing.Point(164, 556);
            this.LableBloc1Timeprev.MaximumSize = new System.Drawing.Size(100, 30);
            this.LableBloc1Timeprev.MinimumSize = new System.Drawing.Size(100, 30);
            this.LableBloc1Timeprev.MouseState = MaterialSkin.MouseState.HOVER;
            this.LableBloc1Timeprev.Name = "LableBloc1Timeprev";
            this.LableBloc1Timeprev.Size = new System.Drawing.Size(100, 30);
            this.LableBloc1Timeprev.TabIndex = 16;
            this.LableBloc1Timeprev.Text = "xxx";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(304, 556);
            this.materialLabel2.MaximumSize = new System.Drawing.Size(100, 30);
            this.materialLabel2.MinimumSize = new System.Drawing.Size(100, 30);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(100, 30);
            this.materialLabel2.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.LableBloc2Timeprev);
            this.groupBox2.Controls.Add(this.labelBloc2Time);
            this.groupBox2.Controls.Add(this.btnBloc2MainAll);
            this.groupBox2.Controls.Add(this.btnBloc2Main);
            this.groupBox2.Controls.Add(this.MultiLineBloc2Hash);
            this.groupBox2.Controls.Add(this.MultiTextBloc2HashPrev);
            this.groupBox2.Controls.Add(this.MultiLineBloc2Data);
            this.groupBox2.Controls.Add(this.MultiTextBloc2Nonce);
            this.groupBox2.Controls.Add(this.TextBloc2Hash);
            this.groupBox2.Controls.Add(this.TextBloc2Prev);
            this.groupBox2.Controls.Add(this.TextBloc2Data);
            this.groupBox2.Controls.Add(this.MultiTextBloc2BlocNumber);
            this.groupBox2.Controls.Add(this.TextBloc2Nonce);
            this.groupBox2.Controls.Add(this.TextBloc2BlocNumber);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(431, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 612);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Block 2";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(304, 556);
            this.materialLabel8.MaximumSize = new System.Drawing.Size(100, 30);
            this.materialLabel8.MinimumSize = new System.Drawing.Size(100, 30);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(100, 30);
            this.materialLabel8.TabIndex = 17;
            // 
            // LableBloc2Timeprev
            // 
            this.LableBloc2Timeprev.AutoSize = true;
            this.LableBloc2Timeprev.Depth = 0;
            this.LableBloc2Timeprev.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LableBloc2Timeprev.Location = new System.Drawing.Point(164, 556);
            this.LableBloc2Timeprev.MaximumSize = new System.Drawing.Size(100, 30);
            this.LableBloc2Timeprev.MinimumSize = new System.Drawing.Size(100, 30);
            this.LableBloc2Timeprev.MouseState = MaterialSkin.MouseState.HOVER;
            this.LableBloc2Timeprev.Name = "LableBloc2Timeprev";
            this.LableBloc2Timeprev.Size = new System.Drawing.Size(100, 30);
            this.LableBloc2Timeprev.TabIndex = 16;
            this.LableBloc2Timeprev.Text = "xxx";
            // 
            // labelBloc2Time
            // 
            this.labelBloc2Time.AutoSize = true;
            this.labelBloc2Time.Depth = 0;
            this.labelBloc2Time.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelBloc2Time.Location = new System.Drawing.Point(6, 556);
            this.labelBloc2Time.MaximumSize = new System.Drawing.Size(100, 30);
            this.labelBloc2Time.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelBloc2Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBloc2Time.Name = "labelBloc2Time";
            this.labelBloc2Time.Size = new System.Drawing.Size(100, 30);
            this.labelBloc2Time.TabIndex = 15;
            this.labelBloc2Time.Text = "xxx";
            // 
            // btnBloc2MainAll
            // 
            this.btnBloc2MainAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBloc2MainAll.Depth = 0;
            this.btnBloc2MainAll.DrawShadows = true;
            this.btnBloc2MainAll.HighEmphasis = true;
            this.btnBloc2MainAll.Icon = null;
            this.btnBloc2MainAll.Location = new System.Drawing.Point(254, 502);
            this.btnBloc2MainAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBloc2MainAll.MaximumSize = new System.Drawing.Size(150, 35);
            this.btnBloc2MainAll.MinimumSize = new System.Drawing.Size(150, 35);
            this.btnBloc2MainAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBloc2MainAll.Name = "btnBloc2MainAll";
            this.btnBloc2MainAll.Size = new System.Drawing.Size(150, 35);
            this.btnBloc2MainAll.TabIndex = 14;
            this.btnBloc2MainAll.Text = "Main All";
            this.btnBloc2MainAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBloc2MainAll.UseAccentColor = false;
            this.btnBloc2MainAll.UseVisualStyleBackColor = true;
            this.btnBloc2MainAll.Click += new System.EventHandler(this.btnBloc2MainAll_Click);
            // 
            // btnBloc2Main
            // 
            this.btnBloc2Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBloc2Main.Depth = 0;
            this.btnBloc2Main.DrawShadows = true;
            this.btnBloc2Main.HighEmphasis = true;
            this.btnBloc2Main.Icon = null;
            this.btnBloc2Main.Location = new System.Drawing.Point(9, 502);
            this.btnBloc2Main.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBloc2Main.MaximumSize = new System.Drawing.Size(150, 35);
            this.btnBloc2Main.MinimumSize = new System.Drawing.Size(150, 35);
            this.btnBloc2Main.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBloc2Main.Name = "btnBloc2Main";
            this.btnBloc2Main.Size = new System.Drawing.Size(150, 35);
            this.btnBloc2Main.TabIndex = 13;
            this.btnBloc2Main.Text = "Main";
            this.btnBloc2Main.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBloc2Main.UseAccentColor = false;
            this.btnBloc2Main.UseVisualStyleBackColor = true;
            this.btnBloc2Main.Click += new System.EventHandler(this.btnBloc2Main_Click);
            // 
            // MultiLineBloc2Hash
            // 
            this.MultiLineBloc2Hash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiLineBloc2Hash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiLineBloc2Hash.Depth = 0;
            this.MultiLineBloc2Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiLineBloc2Hash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiLineBloc2Hash.Hint = "";
            this.MultiLineBloc2Hash.Location = new System.Drawing.Point(112, 433);
            this.MultiLineBloc2Hash.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiLineBloc2Hash.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiLineBloc2Hash.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiLineBloc2Hash.Name = "MultiLineBloc2Hash";
            this.MultiLineBloc2Hash.ReadOnly = true;
            this.MultiLineBloc2Hash.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiLineBloc2Hash.Size = new System.Drawing.Size(300, 30);
            this.MultiLineBloc2Hash.TabIndex = 12;
            this.MultiLineBloc2Hash.Text = "";
            this.MultiLineBloc2Hash.TextChanged += new System.EventHandler(this.MultiLineBloc2Hash_TextChanged);
            // 
            // MultiTextBloc2HashPrev
            // 
            this.MultiTextBloc2HashPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc2HashPrev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc2HashPrev.Depth = 0;
            this.MultiTextBloc2HashPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc2HashPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc2HashPrev.Hint = "";
            this.MultiTextBloc2HashPrev.Location = new System.Drawing.Point(112, 387);
            this.MultiTextBloc2HashPrev.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2HashPrev.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2HashPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc2HashPrev.Name = "MultiTextBloc2HashPrev";
            this.MultiTextBloc2HashPrev.ReadOnly = true;
            this.MultiTextBloc2HashPrev.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc2HashPrev.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2HashPrev.TabIndex = 11;
            this.MultiTextBloc2HashPrev.Text = "";
            this.MultiTextBloc2HashPrev.TextChanged += new System.EventHandler(this.MultiTextBloc2HashPrev_TextChanged);
            // 
            // MultiLineBloc2Data
            // 
            this.MultiLineBloc2Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiLineBloc2Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiLineBloc2Data.Depth = 0;
            this.MultiLineBloc2Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiLineBloc2Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiLineBloc2Data.Hint = "";
            this.MultiLineBloc2Data.Location = new System.Drawing.Point(112, 123);
            this.MultiLineBloc2Data.MaximumSize = new System.Drawing.Size(300, 250);
            this.MultiLineBloc2Data.MinimumSize = new System.Drawing.Size(300, 250);
            this.MultiLineBloc2Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiLineBloc2Data.Name = "MultiLineBloc2Data";
            this.MultiLineBloc2Data.Size = new System.Drawing.Size(300, 250);
            this.MultiLineBloc2Data.TabIndex = 10;
            this.MultiLineBloc2Data.Text = "";
            this.MultiLineBloc2Data.TextChanged += new System.EventHandler(this.MultiLineBloc2Data_TextChanged);
            // 
            // MultiTextBloc2Nonce
            // 
            this.MultiTextBloc2Nonce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc2Nonce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc2Nonce.Depth = 0;
            this.MultiTextBloc2Nonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc2Nonce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc2Nonce.Hint = "";
            this.MultiTextBloc2Nonce.Location = new System.Drawing.Point(112, 78);
            this.MultiTextBloc2Nonce.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2Nonce.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2Nonce.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc2Nonce.Name = "MultiTextBloc2Nonce";
            this.MultiTextBloc2Nonce.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc2Nonce.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2Nonce.TabIndex = 9;
            this.MultiTextBloc2Nonce.Text = "";
            this.MultiTextBloc2Nonce.TextChanged += new System.EventHandler(this.MultiTextBloc2Nonce_TextChanged);
            // 
            // TextBloc2Hash
            // 
            this.TextBloc2Hash.AutoSize = true;
            this.TextBloc2Hash.Depth = 0;
            this.TextBloc2Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc2Hash.Location = new System.Drawing.Point(6, 433);
            this.TextBloc2Hash.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2Hash.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2Hash.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc2Hash.Name = "TextBloc2Hash";
            this.TextBloc2Hash.Size = new System.Drawing.Size(100, 30);
            this.TextBloc2Hash.TabIndex = 8;
            this.TextBloc2Hash.Text = "Hash";
            // 
            // TextBloc2Prev
            // 
            this.TextBloc2Prev.AutoSize = true;
            this.TextBloc2Prev.Depth = 0;
            this.TextBloc2Prev.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc2Prev.Location = new System.Drawing.Point(6, 388);
            this.TextBloc2Prev.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2Prev.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2Prev.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc2Prev.Name = "TextBloc2Prev";
            this.TextBloc2Prev.Size = new System.Drawing.Size(100, 30);
            this.TextBloc2Prev.TabIndex = 7;
            this.TextBloc2Prev.Text = "Prev";
            // 
            // TextBloc2Data
            // 
            this.TextBloc2Data.AutoSize = true;
            this.TextBloc2Data.Depth = 0;
            this.TextBloc2Data.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc2Data.Location = new System.Drawing.Point(6, 123);
            this.TextBloc2Data.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2Data.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc2Data.Name = "TextBloc2Data";
            this.TextBloc2Data.Size = new System.Drawing.Size(100, 30);
            this.TextBloc2Data.TabIndex = 6;
            this.TextBloc2Data.Text = "Data";
            // 
            // MultiTextBloc2BlocNumber
            // 
            this.MultiTextBloc2BlocNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc2BlocNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc2BlocNumber.Depth = 0;
            this.MultiTextBloc2BlocNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc2BlocNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc2BlocNumber.Hint = "";
            this.MultiTextBloc2BlocNumber.Location = new System.Drawing.Point(112, 33);
            this.MultiTextBloc2BlocNumber.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2BlocNumber.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2BlocNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc2BlocNumber.Name = "MultiTextBloc2BlocNumber";
            this.MultiTextBloc2BlocNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc2BlocNumber.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc2BlocNumber.TabIndex = 5;
            this.MultiTextBloc2BlocNumber.Text = "";
            this.MultiTextBloc2BlocNumber.TextChanged += new System.EventHandler(this.MultiTextBloc2BlocNumber_TextChanged);
            // 
            // TextBloc2Nonce
            // 
            this.TextBloc2Nonce.AutoSize = true;
            this.TextBloc2Nonce.Depth = 0;
            this.TextBloc2Nonce.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc2Nonce.Location = new System.Drawing.Point(6, 78);
            this.TextBloc2Nonce.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2Nonce.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2Nonce.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc2Nonce.Name = "TextBloc2Nonce";
            this.TextBloc2Nonce.Size = new System.Drawing.Size(100, 30);
            this.TextBloc2Nonce.TabIndex = 4;
            this.TextBloc2Nonce.Text = "Nonce";
            // 
            // TextBloc2BlocNumber
            // 
            this.TextBloc2BlocNumber.AutoSize = true;
            this.TextBloc2BlocNumber.Depth = 0;
            this.TextBloc2BlocNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc2BlocNumber.Location = new System.Drawing.Point(6, 33);
            this.TextBloc2BlocNumber.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2BlocNumber.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc2BlocNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc2BlocNumber.Name = "TextBloc2BlocNumber";
            this.TextBloc2BlocNumber.Size = new System.Drawing.Size(100, 30);
            this.TextBloc2BlocNumber.TabIndex = 1;
            this.TextBloc2BlocNumber.Text = "Bloc number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel16);
            this.groupBox1.Controls.Add(this.materialLabel19);
            this.groupBox1.Controls.Add(this.LableBloc3Timeprev);
            this.groupBox1.Controls.Add(this.labelBloc3Time);
            this.groupBox1.Controls.Add(this.btnBloc3MainAll);
            this.groupBox1.Controls.Add(this.btnBloc3Main);
            this.groupBox1.Controls.Add(this.MultiLineBloc3Hash);
            this.groupBox1.Controls.Add(this.MultiTextBloc3HashPrev);
            this.groupBox1.Controls.Add(this.MultiLineBloc3Data);
            this.groupBox1.Controls.Add(this.MultiTextBloc3Nonce);
            this.groupBox1.Controls.Add(this.TextBloc3Hash);
            this.groupBox1.Controls.Add(this.TextBloc3Prev);
            this.groupBox1.Controls.Add(this.TextBloc3Data);
            this.groupBox1.Controls.Add(this.MultiTextBloc3BlocNumber);
            this.groupBox1.Controls.Add(this.TextBloc3Nonce);
            this.groupBox1.Controls.Add(this.TextBloc3BlocNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(862, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 612);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Block 3";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(304, 611);
            this.materialLabel16.MaximumSize = new System.Drawing.Size(100, 30);
            this.materialLabel16.MinimumSize = new System.Drawing.Size(100, 30);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(100, 30);
            this.materialLabel16.TabIndex = 20;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.Location = new System.Drawing.Point(304, 556);
            this.materialLabel19.MaximumSize = new System.Drawing.Size(100, 30);
            this.materialLabel19.MinimumSize = new System.Drawing.Size(100, 30);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(100, 30);
            this.materialLabel19.TabIndex = 17;
            // 
            // LableBloc3Timeprev
            // 
            this.LableBloc3Timeprev.AutoSize = true;
            this.LableBloc3Timeprev.Depth = 0;
            this.LableBloc3Timeprev.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LableBloc3Timeprev.Location = new System.Drawing.Point(164, 556);
            this.LableBloc3Timeprev.MaximumSize = new System.Drawing.Size(100, 30);
            this.LableBloc3Timeprev.MinimumSize = new System.Drawing.Size(100, 30);
            this.LableBloc3Timeprev.MouseState = MaterialSkin.MouseState.HOVER;
            this.LableBloc3Timeprev.Name = "LableBloc3Timeprev";
            this.LableBloc3Timeprev.Size = new System.Drawing.Size(100, 30);
            this.LableBloc3Timeprev.TabIndex = 16;
            this.LableBloc3Timeprev.Text = "xxx";
            // 
            // labelBloc3Time
            // 
            this.labelBloc3Time.AutoSize = true;
            this.labelBloc3Time.Depth = 0;
            this.labelBloc3Time.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelBloc3Time.Location = new System.Drawing.Point(6, 556);
            this.labelBloc3Time.MaximumSize = new System.Drawing.Size(100, 30);
            this.labelBloc3Time.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelBloc3Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBloc3Time.Name = "labelBloc3Time";
            this.labelBloc3Time.Size = new System.Drawing.Size(100, 30);
            this.labelBloc3Time.TabIndex = 15;
            this.labelBloc3Time.Text = "xxx";
            // 
            // btnBloc3MainAll
            // 
            this.btnBloc3MainAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBloc3MainAll.Depth = 0;
            this.btnBloc3MainAll.DrawShadows = true;
            this.btnBloc3MainAll.HighEmphasis = true;
            this.btnBloc3MainAll.Icon = null;
            this.btnBloc3MainAll.Location = new System.Drawing.Point(254, 502);
            this.btnBloc3MainAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBloc3MainAll.MaximumSize = new System.Drawing.Size(150, 35);
            this.btnBloc3MainAll.MinimumSize = new System.Drawing.Size(150, 35);
            this.btnBloc3MainAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBloc3MainAll.Name = "btnBloc3MainAll";
            this.btnBloc3MainAll.Size = new System.Drawing.Size(150, 35);
            this.btnBloc3MainAll.TabIndex = 14;
            this.btnBloc3MainAll.Text = "Main All";
            this.btnBloc3MainAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBloc3MainAll.UseAccentColor = false;
            this.btnBloc3MainAll.UseVisualStyleBackColor = true;
            // 
            // btnBloc3Main
            // 
            this.btnBloc3Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBloc3Main.Depth = 0;
            this.btnBloc3Main.DrawShadows = true;
            this.btnBloc3Main.HighEmphasis = true;
            this.btnBloc3Main.Icon = null;
            this.btnBloc3Main.Location = new System.Drawing.Point(9, 502);
            this.btnBloc3Main.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBloc3Main.MaximumSize = new System.Drawing.Size(150, 35);
            this.btnBloc3Main.MinimumSize = new System.Drawing.Size(150, 35);
            this.btnBloc3Main.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBloc3Main.Name = "btnBloc3Main";
            this.btnBloc3Main.Size = new System.Drawing.Size(150, 35);
            this.btnBloc3Main.TabIndex = 13;
            this.btnBloc3Main.Text = "Main";
            this.btnBloc3Main.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBloc3Main.UseAccentColor = false;
            this.btnBloc3Main.UseVisualStyleBackColor = true;
            this.btnBloc3Main.Click += new System.EventHandler(this.btnBloc3Main_Click);
            // 
            // MultiLineBloc3Hash
            // 
            this.MultiLineBloc3Hash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiLineBloc3Hash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiLineBloc3Hash.Depth = 0;
            this.MultiLineBloc3Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiLineBloc3Hash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiLineBloc3Hash.Hint = "";
            this.MultiLineBloc3Hash.Location = new System.Drawing.Point(112, 433);
            this.MultiLineBloc3Hash.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiLineBloc3Hash.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiLineBloc3Hash.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiLineBloc3Hash.Name = "MultiLineBloc3Hash";
            this.MultiLineBloc3Hash.ReadOnly = true;
            this.MultiLineBloc3Hash.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiLineBloc3Hash.Size = new System.Drawing.Size(300, 30);
            this.MultiLineBloc3Hash.TabIndex = 12;
            this.MultiLineBloc3Hash.Text = "";
            this.MultiLineBloc3Hash.TextChanged += new System.EventHandler(this.MultiLineBloc3Hash_TextChanged);
            // 
            // MultiTextBloc3HashPrev
            // 
            this.MultiTextBloc3HashPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc3HashPrev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc3HashPrev.Depth = 0;
            this.MultiTextBloc3HashPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc3HashPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc3HashPrev.Hint = "";
            this.MultiTextBloc3HashPrev.Location = new System.Drawing.Point(112, 387);
            this.MultiTextBloc3HashPrev.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3HashPrev.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3HashPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc3HashPrev.Name = "MultiTextBloc3HashPrev";
            this.MultiTextBloc3HashPrev.ReadOnly = true;
            this.MultiTextBloc3HashPrev.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc3HashPrev.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3HashPrev.TabIndex = 11;
            this.MultiTextBloc3HashPrev.Text = "";
            this.MultiTextBloc3HashPrev.TextChanged += new System.EventHandler(this.MultiTextBloc3HashPrev_TextChanged);
            // 
            // MultiLineBloc3Data
            // 
            this.MultiLineBloc3Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiLineBloc3Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiLineBloc3Data.Depth = 0;
            this.MultiLineBloc3Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiLineBloc3Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiLineBloc3Data.Hint = "";
            this.MultiLineBloc3Data.Location = new System.Drawing.Point(112, 123);
            this.MultiLineBloc3Data.MaximumSize = new System.Drawing.Size(300, 250);
            this.MultiLineBloc3Data.MinimumSize = new System.Drawing.Size(300, 250);
            this.MultiLineBloc3Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiLineBloc3Data.Name = "MultiLineBloc3Data";
            this.MultiLineBloc3Data.Size = new System.Drawing.Size(300, 250);
            this.MultiLineBloc3Data.TabIndex = 10;
            this.MultiLineBloc3Data.Text = "";
            this.MultiLineBloc3Data.TextChanged += new System.EventHandler(this.MultiLineBloc3Data_TextChanged);
            // 
            // MultiTextBloc3Nonce
            // 
            this.MultiTextBloc3Nonce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc3Nonce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc3Nonce.Depth = 0;
            this.MultiTextBloc3Nonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc3Nonce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc3Nonce.Hint = "";
            this.MultiTextBloc3Nonce.Location = new System.Drawing.Point(112, 78);
            this.MultiTextBloc3Nonce.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3Nonce.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3Nonce.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc3Nonce.Name = "MultiTextBloc3Nonce";
            this.MultiTextBloc3Nonce.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc3Nonce.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3Nonce.TabIndex = 9;
            this.MultiTextBloc3Nonce.Text = "";
            this.MultiTextBloc3Nonce.TextChanged += new System.EventHandler(this.MultiTextBloc3Nonce_TextChanged);
            // 
            // TextBloc3Hash
            // 
            this.TextBloc3Hash.AutoSize = true;
            this.TextBloc3Hash.Depth = 0;
            this.TextBloc3Hash.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc3Hash.Location = new System.Drawing.Point(6, 433);
            this.TextBloc3Hash.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3Hash.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3Hash.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc3Hash.Name = "TextBloc3Hash";
            this.TextBloc3Hash.Size = new System.Drawing.Size(100, 30);
            this.TextBloc3Hash.TabIndex = 8;
            this.TextBloc3Hash.Text = "Hash";
            // 
            // TextBloc3Prev
            // 
            this.TextBloc3Prev.AutoSize = true;
            this.TextBloc3Prev.Depth = 0;
            this.TextBloc3Prev.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc3Prev.Location = new System.Drawing.Point(6, 388);
            this.TextBloc3Prev.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3Prev.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3Prev.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc3Prev.Name = "TextBloc3Prev";
            this.TextBloc3Prev.Size = new System.Drawing.Size(100, 30);
            this.TextBloc3Prev.TabIndex = 7;
            this.TextBloc3Prev.Text = "Prev";
            // 
            // TextBloc3Data
            // 
            this.TextBloc3Data.AutoSize = true;
            this.TextBloc3Data.Depth = 0;
            this.TextBloc3Data.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc3Data.Location = new System.Drawing.Point(6, 123);
            this.TextBloc3Data.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3Data.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc3Data.Name = "TextBloc3Data";
            this.TextBloc3Data.Size = new System.Drawing.Size(100, 30);
            this.TextBloc3Data.TabIndex = 6;
            this.TextBloc3Data.Text = "Data";
            // 
            // MultiTextBloc3BlocNumber
            // 
            this.MultiTextBloc3BlocNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiTextBloc3BlocNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiTextBloc3BlocNumber.Depth = 0;
            this.MultiTextBloc3BlocNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiTextBloc3BlocNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiTextBloc3BlocNumber.Hint = "";
            this.MultiTextBloc3BlocNumber.Location = new System.Drawing.Point(112, 33);
            this.MultiTextBloc3BlocNumber.MaximumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3BlocNumber.MinimumSize = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3BlocNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiTextBloc3BlocNumber.Name = "MultiTextBloc3BlocNumber";
            this.MultiTextBloc3BlocNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MultiTextBloc3BlocNumber.Size = new System.Drawing.Size(300, 30);
            this.MultiTextBloc3BlocNumber.TabIndex = 5;
            this.MultiTextBloc3BlocNumber.Text = "";
            this.MultiTextBloc3BlocNumber.TextChanged += new System.EventHandler(this.MultiTextBloc3BlocNumber_TextChanged);
            // 
            // TextBloc3Nonce
            // 
            this.TextBloc3Nonce.AutoSize = true;
            this.TextBloc3Nonce.Depth = 0;
            this.TextBloc3Nonce.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc3Nonce.Location = new System.Drawing.Point(6, 78);
            this.TextBloc3Nonce.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3Nonce.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3Nonce.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc3Nonce.Name = "TextBloc3Nonce";
            this.TextBloc3Nonce.Size = new System.Drawing.Size(100, 30);
            this.TextBloc3Nonce.TabIndex = 4;
            this.TextBloc3Nonce.Text = "Nonce";
            // 
            // TextBloc3BlocNumber
            // 
            this.TextBloc3BlocNumber.AutoSize = true;
            this.TextBloc3BlocNumber.Depth = 0;
            this.TextBloc3BlocNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBloc3BlocNumber.Location = new System.Drawing.Point(6, 33);
            this.TextBloc3BlocNumber.MaximumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3BlocNumber.MinimumSize = new System.Drawing.Size(100, 30);
            this.TextBloc3BlocNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBloc3BlocNumber.Name = "TextBloc3BlocNumber";
            this.TextBloc3BlocNumber.Size = new System.Drawing.Size(100, 30);
            this.TextBloc3BlocNumber.TabIndex = 1;
            this.TextBloc3BlocNumber.Text = "Bloc number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Blockhchain";
            this.materialTabControl1.ResumeLayout(false);
            this.tabBloc.ResumeLayout(false);
            this.tabBloc.PerformLayout();
            this.grup1bloc.ResumeLayout(false);
            this.grup1bloc.PerformLayout();
            this.panelBlockchain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabBloc;
        private System.Windows.Forms.TabPage tabSeting;
        private System.Windows.Forms.GroupBox grup1bloc;
        private MaterialSkin.Controls.MaterialLabel TextBloc1BlocNumber;
        private MaterialSkin.Controls.MaterialLabel TextBloc1Nonce;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc1BlocNumber;
        private MaterialSkin.Controls.MaterialLabel TextBloc1Data;
        private MaterialSkin.Controls.MaterialLabel TextBloc1Hash;
        private MaterialSkin.Controls.MaterialLabel TextBloc1Prev;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc1Hash;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc1HashPrev;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc1Data;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc1Nonce;
        private MaterialSkin.Controls.MaterialButton btnBloc1MainAll;
        private MaterialSkin.Controls.MaterialButton btnBloc1Main;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel LableBloc1Timeprev;
        private MaterialSkin.Controls.MaterialLabel labelBloc1Time;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel LableBloc3Timeprev;
        private MaterialSkin.Controls.MaterialLabel labelBloc3Time;
        private MaterialSkin.Controls.MaterialButton btnBloc3MainAll;
        private MaterialSkin.Controls.MaterialButton btnBloc3Main;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc3Hash;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc3HashPrev;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc3Data;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc3Nonce;
        private MaterialSkin.Controls.MaterialLabel TextBloc3Hash;
        private MaterialSkin.Controls.MaterialLabel TextBloc3Prev;
        private MaterialSkin.Controls.MaterialLabel TextBloc3Data;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc3BlocNumber;
        private MaterialSkin.Controls.MaterialLabel TextBloc3Nonce;
        private MaterialSkin.Controls.MaterialLabel TextBloc3BlocNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel LableBloc2Timeprev;
        private MaterialSkin.Controls.MaterialLabel labelBloc2Time;
        private MaterialSkin.Controls.MaterialButton btnBloc2MainAll;
        private MaterialSkin.Controls.MaterialButton btnBloc2Main;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc2Hash;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc2HashPrev;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineBloc2Data;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc2Nonce;
        private MaterialSkin.Controls.MaterialLabel TextBloc2Hash;
        private MaterialSkin.Controls.MaterialLabel TextBloc2Prev;
        private MaterialSkin.Controls.MaterialLabel TextBloc2Data;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiTextBloc2BlocNumber;
        private MaterialSkin.Controls.MaterialLabel TextBloc2Nonce;
        private MaterialSkin.Controls.MaterialLabel TextBloc2BlocNumber;
        public System.Windows.Forms.Panel panelBlockchain;
    }
}

