namespace FileOrganizer
{
    partial class frm_OrganizeWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OrganizeWindow));
            this.btn_Organize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_PathIn = new System.Windows.Forms.TextBox();
            this.btn_BrowsePathIn = new System.Windows.Forms.Button();
            this.lbl_PathIn = new System.Windows.Forms.Label();
            this.lbl_PathSave = new System.Windows.Forms.Label();
            this.txt_PathSave = new System.Windows.Forms.TextBox();
            this.btn_BrowsePathSave = new System.Windows.Forms.Button();
            this.ckb_SaveSameOrganize = new System.Windows.Forms.CheckBox();
            this.btn_ListFiles = new System.Windows.Forms.Button();
            this.lst_Files = new System.Windows.Forms.ListBox();
            this.ckb_Jpeg = new System.Windows.Forms.CheckBox();
            this.ckb_PNG = new System.Windows.Forms.CheckBox();
            this.ckb_BMP = new System.Windows.Forms.CheckBox();
            this.ckb_Dng = new System.Windows.Forms.CheckBox();
            this.ckb_Raw = new System.Windows.Forms.CheckBox();
            this.ckb_Mp3 = new System.Windows.Forms.CheckBox();
            this.ckb_Wma = new System.Windows.Forms.CheckBox();
            this.ckb_Wav = new System.Windows.Forms.CheckBox();
            this.ckb_Mpa = new System.Windows.Forms.CheckBox();
            this.ckb_Ogg = new System.Windows.Forms.CheckBox();
            this.ckb_Mp4 = new System.Windows.Forms.CheckBox();
            this.ckb_Avi = new System.Windows.Forms.CheckBox();
            this.ckb_Mpg = new System.Windows.Forms.CheckBox();
            this.ckb_M4v = new System.Windows.Forms.CheckBox();
            this.ckb_Wmv = new System.Windows.Forms.CheckBox();
            this.ckb_Csv = new System.Windows.Forms.CheckBox();
            this.ckb_Txt = new System.Windows.Forms.CheckBox();
            this.ckb_Xls = new System.Windows.Forms.CheckBox();
            this.ckb_XLSX = new System.Windows.Forms.CheckBox();
            this.ckb_Xlsm = new System.Windows.Forms.CheckBox();
            this.ckb_Doc = new System.Windows.Forms.CheckBox();
            this.ckb_Pdf = new System.Windows.Forms.CheckBox();
            this.ckb_Ppt = new System.Windows.Forms.CheckBox();
            this.ckb_Pptx = new System.Windows.Forms.CheckBox();
            this.ckb_Odp = new System.Windows.Forms.CheckBox();
            this.ckb_Cs = new System.Windows.Forms.CheckBox();
            this.ckb_C = new System.Windows.Forms.CheckBox();
            this.ckb_Cpp = new System.Windows.Forms.CheckBox();
            this.ckb_Php = new System.Windows.Forms.CheckBox();
            this.ckb_Py = new System.Windows.Forms.CheckBox();
            this.ckb_All = new System.Windows.Forms.CheckBox();
            this.cmb_MoveCopy = new System.Windows.Forms.ComboBox();
            this.lbl_MoveCopy = new System.Windows.Forms.Label();
            this.lst_FoldersNotIncluded = new System.Windows.Forms.ListBox();
            this.gbExtensions = new System.Windows.Forms.GroupBox();
            this.lst_FoldersIncluded = new System.Windows.Forms.ListBox();
            this.gbFolderOrganization = new System.Windows.Forms.GroupBox();
            this.ckb_CreateFileOrganizerFolder = new System.Windows.Forms.CheckBox();
            this.btn_DownFolder = new System.Windows.Forms.Button();
            this.btn_UpFolder = new System.Windows.Forms.Button();
            this.btn_RemoveExtension = new System.Windows.Forms.Button();
            this.btn_AddExtension = new System.Windows.Forms.Button();
            this.gbExtensions.SuspendLayout();
            this.gbFolderOrganization.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Organize
            // 
            this.btn_Organize.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Organize.Location = new System.Drawing.Point(280, 638);
            this.btn_Organize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Organize.Name = "btn_Organize";
            this.btn_Organize.Size = new System.Drawing.Size(88, 23);
            this.btn_Organize.TabIndex = 0;
            this.btn_Organize.Text = "Organize";
            this.btn_Organize.UseVisualStyleBackColor = true;
            this.btn_Organize.Click += new System.EventHandler(this.btn_Organize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(376, 638);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(88, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_PathIn
            // 
            this.txt_PathIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PathIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PathIn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_PathIn.Location = new System.Drawing.Point(12, 41);
            this.txt_PathIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_PathIn.Name = "txt_PathIn";
            this.txt_PathIn.Size = new System.Drawing.Size(357, 15);
            this.txt_PathIn.TabIndex = 2;
            // 
            // btn_BrowsePathIn
            // 
            this.btn_BrowsePathIn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowsePathIn.Location = new System.Drawing.Point(376, 38);
            this.btn_BrowsePathIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_BrowsePathIn.Name = "btn_BrowsePathIn";
            this.btn_BrowsePathIn.Size = new System.Drawing.Size(88, 20);
            this.btn_BrowsePathIn.TabIndex = 3;
            this.btn_BrowsePathIn.Text = "Browse";
            this.btn_BrowsePathIn.UseVisualStyleBackColor = true;
            this.btn_BrowsePathIn.Click += new System.EventHandler(this.btn_BrowsePathIn_Click);
            // 
            // lbl_PathIn
            // 
            this.lbl_PathIn.AutoSize = true;
            this.lbl_PathIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PathIn.Location = new System.Drawing.Point(12, 22);
            this.lbl_PathIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PathIn.Name = "lbl_PathIn";
            this.lbl_PathIn.Size = new System.Drawing.Size(113, 15);
            this.lbl_PathIn.TabIndex = 4;
            this.lbl_PathIn.Text = "Folder to Organize:";
            // 
            // lbl_PathSave
            // 
            this.lbl_PathSave.AutoSize = true;
            this.lbl_PathSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PathSave.Location = new System.Drawing.Point(12, 84);
            this.lbl_PathSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PathSave.Name = "lbl_PathSave";
            this.lbl_PathSave.Size = new System.Drawing.Size(90, 15);
            this.lbl_PathSave.TabIndex = 5;
            this.lbl_PathSave.Text = "Folder to Save:";
            // 
            // txt_PathSave
            // 
            this.txt_PathSave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PathSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PathSave.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_PathSave.Location = new System.Drawing.Point(12, 103);
            this.txt_PathSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_PathSave.Name = "txt_PathSave";
            this.txt_PathSave.Size = new System.Drawing.Size(357, 15);
            this.txt_PathSave.TabIndex = 6;
            // 
            // btn_BrowsePathSave
            // 
            this.btn_BrowsePathSave.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowsePathSave.Location = new System.Drawing.Point(376, 100);
            this.btn_BrowsePathSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_BrowsePathSave.Name = "btn_BrowsePathSave";
            this.btn_BrowsePathSave.Size = new System.Drawing.Size(88, 20);
            this.btn_BrowsePathSave.TabIndex = 7;
            this.btn_BrowsePathSave.Text = "Browse";
            this.btn_BrowsePathSave.UseVisualStyleBackColor = true;
            this.btn_BrowsePathSave.Click += new System.EventHandler(this.btn_BrowsePathSave_Click);
            // 
            // ckb_SaveSameOrganize
            // 
            this.ckb_SaveSameOrganize.AutoSize = true;
            this.ckb_SaveSameOrganize.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.ckb_SaveSameOrganize.Location = new System.Drawing.Point(15, 134);
            this.ckb_SaveSameOrganize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_SaveSameOrganize.Name = "ckb_SaveSameOrganize";
            this.ckb_SaveSameOrganize.Size = new System.Drawing.Size(115, 17);
            this.ckb_SaveSameOrganize.TabIndex = 8;
            this.ckb_SaveSameOrganize.Text = "Same to Organize";
            this.ckb_SaveSameOrganize.UseVisualStyleBackColor = true;
            this.ckb_SaveSameOrganize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_ListFiles
            // 
            this.btn_ListFiles.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListFiles.Location = new System.Drawing.Point(12, 638);
            this.btn_ListFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ListFiles.Name = "btn_ListFiles";
            this.btn_ListFiles.Size = new System.Drawing.Size(88, 23);
            this.btn_ListFiles.TabIndex = 10;
            this.btn_ListFiles.Text = "List Files";
            this.btn_ListFiles.UseVisualStyleBackColor = true;
            this.btn_ListFiles.Click += new System.EventHandler(this.btn_ListFiles_Click);
            // 
            // lst_Files
            // 
            this.lst_Files.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lst_Files.FormattingEnabled = true;
            this.lst_Files.Location = new System.Drawing.Point(12, 485);
            this.lst_Files.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lst_Files.Name = "lst_Files";
            this.lst_Files.Size = new System.Drawing.Size(452, 147);
            this.lst_Files.TabIndex = 11;
            // 
            // ckb_Jpeg
            // 
            this.ckb_Jpeg.AutoSize = true;
            this.ckb_Jpeg.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Jpeg.Location = new System.Drawing.Point(7, 47);
            this.ckb_Jpeg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Jpeg.Name = "ckb_Jpeg";
            this.ckb_Jpeg.Size = new System.Drawing.Size(49, 17);
            this.ckb_Jpeg.TabIndex = 13;
            this.ckb_Jpeg.Text = "JPEG";
            this.ckb_Jpeg.UseVisualStyleBackColor = true;
            // 
            // ckb_PNG
            // 
            this.ckb_PNG.AutoSize = true;
            this.ckb_PNG.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_PNG.Location = new System.Drawing.Point(7, 70);
            this.ckb_PNG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_PNG.Name = "ckb_PNG";
            this.ckb_PNG.Size = new System.Drawing.Size(47, 17);
            this.ckb_PNG.TabIndex = 14;
            this.ckb_PNG.Text = "PNG";
            this.ckb_PNG.UseVisualStyleBackColor = true;
            // 
            // ckb_BMP
            // 
            this.ckb_BMP.AutoSize = true;
            this.ckb_BMP.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_BMP.Location = new System.Drawing.Point(7, 93);
            this.ckb_BMP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_BMP.Name = "ckb_BMP";
            this.ckb_BMP.Size = new System.Drawing.Size(48, 17);
            this.ckb_BMP.TabIndex = 15;
            this.ckb_BMP.Text = "BMP";
            this.ckb_BMP.UseVisualStyleBackColor = true;
            // 
            // ckb_Dng
            // 
            this.ckb_Dng.AutoSize = true;
            this.ckb_Dng.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Dng.Location = new System.Drawing.Point(7, 116);
            this.ckb_Dng.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Dng.Name = "ckb_Dng";
            this.ckb_Dng.Size = new System.Drawing.Size(49, 17);
            this.ckb_Dng.TabIndex = 17;
            this.ckb_Dng.Text = "DNG";
            this.ckb_Dng.UseVisualStyleBackColor = true;
            // 
            // ckb_Raw
            // 
            this.ckb_Raw.AutoSize = true;
            this.ckb_Raw.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Raw.Location = new System.Drawing.Point(7, 139);
            this.ckb_Raw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Raw.Name = "ckb_Raw";
            this.ckb_Raw.Size = new System.Drawing.Size(49, 17);
            this.ckb_Raw.TabIndex = 18;
            this.ckb_Raw.Text = "RAW";
            this.ckb_Raw.UseVisualStyleBackColor = true;
            // 
            // ckb_Mp3
            // 
            this.ckb_Mp3.AutoSize = true;
            this.ckb_Mp3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Mp3.Location = new System.Drawing.Point(74, 47);
            this.ckb_Mp3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Mp3.Name = "ckb_Mp3";
            this.ckb_Mp3.Size = new System.Drawing.Size(48, 17);
            this.ckb_Mp3.TabIndex = 19;
            this.ckb_Mp3.Text = "MP3";
            this.ckb_Mp3.UseVisualStyleBackColor = true;
            // 
            // ckb_Wma
            // 
            this.ckb_Wma.AutoSize = true;
            this.ckb_Wma.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Wma.Location = new System.Drawing.Point(74, 70);
            this.ckb_Wma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Wma.Name = "ckb_Wma";
            this.ckb_Wma.Size = new System.Drawing.Size(53, 17);
            this.ckb_Wma.TabIndex = 20;
            this.ckb_Wma.Text = "WMA";
            this.ckb_Wma.UseVisualStyleBackColor = true;
            // 
            // ckb_Wav
            // 
            this.ckb_Wav.AutoSize = true;
            this.ckb_Wav.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Wav.Location = new System.Drawing.Point(74, 93);
            this.ckb_Wav.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Wav.Name = "ckb_Wav";
            this.ckb_Wav.Size = new System.Drawing.Size(49, 17);
            this.ckb_Wav.TabIndex = 21;
            this.ckb_Wav.Text = "WAV";
            this.ckb_Wav.UseVisualStyleBackColor = true;
            // 
            // ckb_Mpa
            // 
            this.ckb_Mpa.AutoSize = true;
            this.ckb_Mpa.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Mpa.Location = new System.Drawing.Point(74, 116);
            this.ckb_Mpa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Mpa.Name = "ckb_Mpa";
            this.ckb_Mpa.Size = new System.Drawing.Size(48, 17);
            this.ckb_Mpa.TabIndex = 22;
            this.ckb_Mpa.Text = "MPA";
            this.ckb_Mpa.UseVisualStyleBackColor = true;
            // 
            // ckb_Ogg
            // 
            this.ckb_Ogg.AutoSize = true;
            this.ckb_Ogg.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Ogg.Location = new System.Drawing.Point(74, 139);
            this.ckb_Ogg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Ogg.Name = "ckb_Ogg";
            this.ckb_Ogg.Size = new System.Drawing.Size(48, 17);
            this.ckb_Ogg.TabIndex = 23;
            this.ckb_Ogg.Text = "OGG";
            this.ckb_Ogg.UseVisualStyleBackColor = true;
            // 
            // ckb_Mp4
            // 
            this.ckb_Mp4.AutoSize = true;
            this.ckb_Mp4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Mp4.Location = new System.Drawing.Point(155, 47);
            this.ckb_Mp4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Mp4.Name = "ckb_Mp4";
            this.ckb_Mp4.Size = new System.Drawing.Size(48, 17);
            this.ckb_Mp4.TabIndex = 24;
            this.ckb_Mp4.Text = "MP4";
            this.ckb_Mp4.UseVisualStyleBackColor = true;
            // 
            // ckb_Avi
            // 
            this.ckb_Avi.AutoSize = true;
            this.ckb_Avi.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Avi.Location = new System.Drawing.Point(155, 70);
            this.ckb_Avi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Avi.Name = "ckb_Avi";
            this.ckb_Avi.Size = new System.Drawing.Size(42, 17);
            this.ckb_Avi.TabIndex = 25;
            this.ckb_Avi.Text = "AVI";
            this.ckb_Avi.UseVisualStyleBackColor = true;
            // 
            // ckb_Mpg
            // 
            this.ckb_Mpg.AutoSize = true;
            this.ckb_Mpg.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Mpg.Location = new System.Drawing.Point(155, 93);
            this.ckb_Mpg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Mpg.Name = "ckb_Mpg";
            this.ckb_Mpg.Size = new System.Drawing.Size(49, 17);
            this.ckb_Mpg.TabIndex = 26;
            this.ckb_Mpg.Text = "MPG";
            this.ckb_Mpg.UseVisualStyleBackColor = true;
            // 
            // ckb_M4v
            // 
            this.ckb_M4v.AutoSize = true;
            this.ckb_M4v.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_M4v.Location = new System.Drawing.Point(155, 116);
            this.ckb_M4v.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_M4v.Name = "ckb_M4v";
            this.ckb_M4v.Size = new System.Drawing.Size(49, 17);
            this.ckb_M4v.TabIndex = 27;
            this.ckb_M4v.Text = "M4V";
            this.ckb_M4v.UseVisualStyleBackColor = true;
            // 
            // ckb_Wmv
            // 
            this.ckb_Wmv.AutoSize = true;
            this.ckb_Wmv.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Wmv.Location = new System.Drawing.Point(155, 139);
            this.ckb_Wmv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Wmv.Name = "ckb_Wmv";
            this.ckb_Wmv.Size = new System.Drawing.Size(53, 17);
            this.ckb_Wmv.TabIndex = 28;
            this.ckb_Wmv.Text = "WMV";
            this.ckb_Wmv.UseVisualStyleBackColor = true;
            // 
            // ckb_Csv
            // 
            this.ckb_Csv.AutoSize = true;
            this.ckb_Csv.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Csv.Location = new System.Drawing.Point(238, 47);
            this.ckb_Csv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Csv.Name = "ckb_Csv";
            this.ckb_Csv.Size = new System.Drawing.Size(46, 17);
            this.ckb_Csv.TabIndex = 29;
            this.ckb_Csv.Text = "CSV";
            this.ckb_Csv.UseVisualStyleBackColor = true;
            // 
            // ckb_Txt
            // 
            this.ckb_Txt.AutoSize = true;
            this.ckb_Txt.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Txt.Location = new System.Drawing.Point(238, 70);
            this.ckb_Txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Txt.Name = "ckb_Txt";
            this.ckb_Txt.Size = new System.Drawing.Size(44, 17);
            this.ckb_Txt.TabIndex = 30;
            this.ckb_Txt.Text = "TXT";
            this.ckb_Txt.UseVisualStyleBackColor = true;
            // 
            // ckb_Xls
            // 
            this.ckb_Xls.AutoSize = true;
            this.ckb_Xls.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Xls.Location = new System.Drawing.Point(238, 93);
            this.ckb_Xls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Xls.Name = "ckb_Xls";
            this.ckb_Xls.Size = new System.Drawing.Size(43, 17);
            this.ckb_Xls.TabIndex = 31;
            this.ckb_Xls.Text = "XLS";
            this.ckb_Xls.UseVisualStyleBackColor = true;
            // 
            // ckb_XLSX
            // 
            this.ckb_XLSX.AutoSize = true;
            this.ckb_XLSX.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_XLSX.Location = new System.Drawing.Point(238, 116);
            this.ckb_XLSX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_XLSX.Name = "ckb_XLSX";
            this.ckb_XLSX.Size = new System.Drawing.Size(49, 17);
            this.ckb_XLSX.TabIndex = 32;
            this.ckb_XLSX.Text = "XLSX";
            this.ckb_XLSX.UseVisualStyleBackColor = true;
            // 
            // ckb_Xlsm
            // 
            this.ckb_Xlsm.AutoSize = true;
            this.ckb_Xlsm.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Xlsm.Location = new System.Drawing.Point(238, 139);
            this.ckb_Xlsm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Xlsm.Name = "ckb_Xlsm";
            this.ckb_Xlsm.Size = new System.Drawing.Size(53, 17);
            this.ckb_Xlsm.TabIndex = 33;
            this.ckb_Xlsm.Text = "XLSM";
            this.ckb_Xlsm.UseVisualStyleBackColor = true;
            // 
            // ckb_Doc
            // 
            this.ckb_Doc.AutoSize = true;
            this.ckb_Doc.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Doc.Location = new System.Drawing.Point(320, 47);
            this.ckb_Doc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Doc.Name = "ckb_Doc";
            this.ckb_Doc.Size = new System.Drawing.Size(49, 17);
            this.ckb_Doc.TabIndex = 34;
            this.ckb_Doc.Text = "DOC";
            this.ckb_Doc.UseVisualStyleBackColor = true;
            // 
            // ckb_Pdf
            // 
            this.ckb_Pdf.AutoSize = true;
            this.ckb_Pdf.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Pdf.Location = new System.Drawing.Point(320, 70);
            this.ckb_Pdf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Pdf.Name = "ckb_Pdf";
            this.ckb_Pdf.Size = new System.Drawing.Size(45, 17);
            this.ckb_Pdf.TabIndex = 35;
            this.ckb_Pdf.Text = "PDF";
            this.ckb_Pdf.UseVisualStyleBackColor = true;
            // 
            // ckb_Ppt
            // 
            this.ckb_Ppt.AutoSize = true;
            this.ckb_Ppt.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Ppt.Location = new System.Drawing.Point(320, 93);
            this.ckb_Ppt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Ppt.Name = "ckb_Ppt";
            this.ckb_Ppt.Size = new System.Drawing.Size(44, 17);
            this.ckb_Ppt.TabIndex = 36;
            this.ckb_Ppt.Text = "PPT";
            this.ckb_Ppt.UseVisualStyleBackColor = true;
            // 
            // ckb_Pptx
            // 
            this.ckb_Pptx.AutoSize = true;
            this.ckb_Pptx.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Pptx.Location = new System.Drawing.Point(320, 116);
            this.ckb_Pptx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Pptx.Name = "ckb_Pptx";
            this.ckb_Pptx.Size = new System.Drawing.Size(50, 17);
            this.ckb_Pptx.TabIndex = 37;
            this.ckb_Pptx.Text = "PPTX";
            this.ckb_Pptx.UseVisualStyleBackColor = true;
            // 
            // ckb_Odp
            // 
            this.ckb_Odp.AutoSize = true;
            this.ckb_Odp.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Odp.Location = new System.Drawing.Point(320, 139);
            this.ckb_Odp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Odp.Name = "ckb_Odp";
            this.ckb_Odp.Size = new System.Drawing.Size(48, 17);
            this.ckb_Odp.TabIndex = 38;
            this.ckb_Odp.Text = "ODP";
            this.ckb_Odp.UseVisualStyleBackColor = true;
            // 
            // ckb_Cs
            // 
            this.ckb_Cs.AutoSize = true;
            this.ckb_Cs.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Cs.Location = new System.Drawing.Point(402, 47);
            this.ckb_Cs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Cs.Name = "ckb_Cs";
            this.ckb_Cs.Size = new System.Drawing.Size(39, 17);
            this.ckb_Cs.TabIndex = 39;
            this.ckb_Cs.Text = "CS";
            this.ckb_Cs.UseVisualStyleBackColor = true;
            // 
            // ckb_C
            // 
            this.ckb_C.AutoSize = true;
            this.ckb_C.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_C.Location = new System.Drawing.Point(402, 70);
            this.ckb_C.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_C.Name = "ckb_C";
            this.ckb_C.Size = new System.Drawing.Size(33, 17);
            this.ckb_C.TabIndex = 40;
            this.ckb_C.Text = "C";
            this.ckb_C.UseVisualStyleBackColor = true;
            // 
            // ckb_Cpp
            // 
            this.ckb_Cpp.AutoSize = true;
            this.ckb_Cpp.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Cpp.Location = new System.Drawing.Point(402, 93);
            this.ckb_Cpp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Cpp.Name = "ckb_Cpp";
            this.ckb_Cpp.Size = new System.Drawing.Size(45, 17);
            this.ckb_Cpp.TabIndex = 41;
            this.ckb_Cpp.Text = "CPP";
            this.ckb_Cpp.UseVisualStyleBackColor = true;
            // 
            // ckb_Php
            // 
            this.ckb_Php.AutoSize = true;
            this.ckb_Php.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Php.Location = new System.Drawing.Point(402, 116);
            this.ckb_Php.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Php.Name = "ckb_Php";
            this.ckb_Php.Size = new System.Drawing.Size(46, 17);
            this.ckb_Php.TabIndex = 42;
            this.ckb_Php.Text = "PHP";
            this.ckb_Php.UseVisualStyleBackColor = true;
            // 
            // ckb_Py
            // 
            this.ckb_Py.AutoSize = true;
            this.ckb_Py.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Py.Location = new System.Drawing.Point(402, 139);
            this.ckb_Py.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_Py.Name = "ckb_Py";
            this.ckb_Py.Size = new System.Drawing.Size(38, 17);
            this.ckb_Py.TabIndex = 43;
            this.ckb_Py.Text = "PY";
            this.ckb_Py.UseVisualStyleBackColor = true;
            // 
            // ckb_All
            // 
            this.ckb_All.AutoSize = true;
            this.ckb_All.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_All.Location = new System.Drawing.Point(7, 21);
            this.ckb_All.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckb_All.Name = "ckb_All";
            this.ckb_All.Size = new System.Drawing.Size(115, 17);
            this.ckb_All.TabIndex = 44;
            this.ckb_All.Text = "All Files in Folder";
            this.ckb_All.UseVisualStyleBackColor = true;
            this.ckb_All.CheckedChanged += new System.EventHandler(this.ckb_All_CheckedChanged);
            // 
            // cmb_MoveCopy
            // 
            this.cmb_MoveCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MoveCopy.FormattingEnabled = true;
            this.cmb_MoveCopy.Items.AddRange(new object[] {
            "Move",
            "Copy"});
            this.cmb_MoveCopy.Location = new System.Drawing.Point(310, 130);
            this.cmb_MoveCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_MoveCopy.Name = "cmb_MoveCopy";
            this.cmb_MoveCopy.Size = new System.Drawing.Size(59, 23);
            this.cmb_MoveCopy.TabIndex = 45;
            // 
            // lbl_MoveCopy
            // 
            this.lbl_MoveCopy.AutoSize = true;
            this.lbl_MoveCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoveCopy.Location = new System.Drawing.Point(240, 134);
            this.lbl_MoveCopy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MoveCopy.Name = "lbl_MoveCopy";
            this.lbl_MoveCopy.Size = new System.Drawing.Size(68, 13);
            this.lbl_MoveCopy.TabIndex = 46;
            this.lbl_MoveCopy.Text = "Move/Copy:";
            // 
            // lst_FoldersNotIncluded
            // 
            this.lst_FoldersNotIncluded.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_FoldersNotIncluded.FormattingEnabled = true;
            this.lst_FoldersNotIncluded.Items.AddRange(new object[] {
            "Date",
            "Extension"});
            this.lst_FoldersNotIncluded.Location = new System.Drawing.Point(7, 28);
            this.lst_FoldersNotIncluded.Name = "lst_FoldersNotIncluded";
            this.lst_FoldersNotIncluded.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_FoldersNotIncluded.Size = new System.Drawing.Size(120, 56);
            this.lst_FoldersNotIncluded.TabIndex = 47;
            // 
            // gbExtensions
            // 
            this.gbExtensions.Controls.Add(this.ckb_All);
            this.gbExtensions.Controls.Add(this.ckb_Py);
            this.gbExtensions.Controls.Add(this.ckb_Php);
            this.gbExtensions.Controls.Add(this.ckb_Cpp);
            this.gbExtensions.Controls.Add(this.ckb_C);
            this.gbExtensions.Controls.Add(this.ckb_Cs);
            this.gbExtensions.Controls.Add(this.ckb_Odp);
            this.gbExtensions.Controls.Add(this.ckb_Pptx);
            this.gbExtensions.Controls.Add(this.ckb_Ppt);
            this.gbExtensions.Controls.Add(this.ckb_Pdf);
            this.gbExtensions.Controls.Add(this.ckb_Doc);
            this.gbExtensions.Controls.Add(this.ckb_Xlsm);
            this.gbExtensions.Controls.Add(this.ckb_XLSX);
            this.gbExtensions.Controls.Add(this.ckb_Xls);
            this.gbExtensions.Controls.Add(this.ckb_Txt);
            this.gbExtensions.Controls.Add(this.ckb_Csv);
            this.gbExtensions.Controls.Add(this.ckb_Wmv);
            this.gbExtensions.Controls.Add(this.ckb_M4v);
            this.gbExtensions.Controls.Add(this.ckb_Mpg);
            this.gbExtensions.Controls.Add(this.ckb_Avi);
            this.gbExtensions.Controls.Add(this.ckb_Mp4);
            this.gbExtensions.Controls.Add(this.ckb_Ogg);
            this.gbExtensions.Controls.Add(this.ckb_Mpa);
            this.gbExtensions.Controls.Add(this.ckb_Wav);
            this.gbExtensions.Controls.Add(this.ckb_Wma);
            this.gbExtensions.Controls.Add(this.ckb_Mp3);
            this.gbExtensions.Controls.Add(this.ckb_Raw);
            this.gbExtensions.Controls.Add(this.ckb_Dng);
            this.gbExtensions.Controls.Add(this.ckb_BMP);
            this.gbExtensions.Controls.Add(this.ckb_PNG);
            this.gbExtensions.Controls.Add(this.ckb_Jpeg);
            this.gbExtensions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExtensions.Location = new System.Drawing.Point(12, 303);
            this.gbExtensions.Name = "gbExtensions";
            this.gbExtensions.Size = new System.Drawing.Size(452, 163);
            this.gbExtensions.TabIndex = 48;
            this.gbExtensions.TabStop = false;
            this.gbExtensions.Text = "Extensions To Organize";
            // 
            // lst_FoldersIncluded
            // 
            this.lst_FoldersIncluded.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_FoldersIncluded.FormattingEnabled = true;
            this.lst_FoldersIncluded.Location = new System.Drawing.Point(176, 28);
            this.lst_FoldersIncluded.Name = "lst_FoldersIncluded";
            this.lst_FoldersIncluded.Size = new System.Drawing.Size(120, 56);
            this.lst_FoldersIncluded.TabIndex = 49;
            // 
            // gbFolderOrganization
            // 
            this.gbFolderOrganization.Controls.Add(this.ckb_CreateFileOrganizerFolder);
            this.gbFolderOrganization.Controls.Add(this.btn_DownFolder);
            this.gbFolderOrganization.Controls.Add(this.btn_UpFolder);
            this.gbFolderOrganization.Controls.Add(this.btn_RemoveExtension);
            this.gbFolderOrganization.Controls.Add(this.btn_AddExtension);
            this.gbFolderOrganization.Controls.Add(this.lst_FoldersIncluded);
            this.gbFolderOrganization.Controls.Add(this.lst_FoldersNotIncluded);
            this.gbFolderOrganization.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFolderOrganization.Location = new System.Drawing.Point(12, 166);
            this.gbFolderOrganization.Name = "gbFolderOrganization";
            this.gbFolderOrganization.Size = new System.Drawing.Size(331, 124);
            this.gbFolderOrganization.TabIndex = 50;
            this.gbFolderOrganization.TabStop = false;
            this.gbFolderOrganization.Text = "Folder Organization";
            // 
            // ckb_CreateFileOrganizerFolder
            // 
            this.ckb_CreateFileOrganizerFolder.AutoSize = true;
            this.ckb_CreateFileOrganizerFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_CreateFileOrganizerFolder.Location = new System.Drawing.Point(7, 95);
            this.ckb_CreateFileOrganizerFolder.Name = "ckb_CreateFileOrganizerFolder";
            this.ckb_CreateFileOrganizerFolder.Size = new System.Drawing.Size(217, 17);
            this.ckb_CreateFileOrganizerFolder.TabIndex = 51;
            this.ckb_CreateFileOrganizerFolder.Text = "Create a \'FileOrganizer\' folder before";
            this.ckb_CreateFileOrganizerFolder.UseVisualStyleBackColor = true;
            // 
            // btn_DownFolder
            // 
            this.btn_DownFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DownFolder.Location = new System.Drawing.Point(300, 59);
            this.btn_DownFolder.Name = "btn_DownFolder";
            this.btn_DownFolder.Size = new System.Drawing.Size(25, 25);
            this.btn_DownFolder.TabIndex = 53;
            this.btn_DownFolder.Text = "˅";
            this.btn_DownFolder.UseVisualStyleBackColor = true;
            this.btn_DownFolder.Click += new System.EventHandler(this.btn_DownFolder_Click);
            // 
            // btn_UpFolder
            // 
            this.btn_UpFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpFolder.Location = new System.Drawing.Point(300, 28);
            this.btn_UpFolder.Name = "btn_UpFolder";
            this.btn_UpFolder.Size = new System.Drawing.Size(25, 25);
            this.btn_UpFolder.TabIndex = 52;
            this.btn_UpFolder.Text = "^\r\n";
            this.btn_UpFolder.UseVisualStyleBackColor = true;
            this.btn_UpFolder.Click += new System.EventHandler(this.btn_UpFolder_Click);
            // 
            // btn_RemoveExtension
            // 
            this.btn_RemoveExtension.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveExtension.Location = new System.Drawing.Point(135, 61);
            this.btn_RemoveExtension.Name = "btn_RemoveExtension";
            this.btn_RemoveExtension.Size = new System.Drawing.Size(33, 23);
            this.btn_RemoveExtension.TabIndex = 51;
            this.btn_RemoveExtension.Text = "<<";
            this.btn_RemoveExtension.UseVisualStyleBackColor = true;
            this.btn_RemoveExtension.Click += new System.EventHandler(this.btn_RemoveExtension_Click);
            // 
            // btn_AddExtension
            // 
            this.btn_AddExtension.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddExtension.Location = new System.Drawing.Point(135, 28);
            this.btn_AddExtension.Name = "btn_AddExtension";
            this.btn_AddExtension.Size = new System.Drawing.Size(33, 23);
            this.btn_AddExtension.TabIndex = 50;
            this.btn_AddExtension.Text = ">>";
            this.btn_AddExtension.UseVisualStyleBackColor = true;
            this.btn_AddExtension.Click += new System.EventHandler(this.btn_AddExtension_Click);
            // 
            // frm_OrganizeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 671);
            this.Controls.Add(this.gbFolderOrganization);
            this.Controls.Add(this.gbExtensions);
            this.Controls.Add(this.lbl_MoveCopy);
            this.Controls.Add(this.cmb_MoveCopy);
            this.Controls.Add(this.lst_Files);
            this.Controls.Add(this.btn_ListFiles);
            this.Controls.Add(this.ckb_SaveSameOrganize);
            this.Controls.Add(this.btn_BrowsePathSave);
            this.Controls.Add(this.txt_PathSave);
            this.Controls.Add(this.lbl_PathSave);
            this.Controls.Add(this.lbl_PathIn);
            this.Controls.Add(this.btn_BrowsePathIn);
            this.Controls.Add(this.txt_PathIn);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Organize);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frm_OrganizeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Organizer";
            this.gbExtensions.ResumeLayout(false);
            this.gbExtensions.PerformLayout();
            this.gbFolderOrganization.ResumeLayout(false);
            this.gbFolderOrganization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Organize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txt_PathIn;
        private System.Windows.Forms.Button btn_BrowsePathIn;
        private System.Windows.Forms.Label lbl_PathIn;
        private System.Windows.Forms.Label lbl_PathSave;
        private System.Windows.Forms.TextBox txt_PathSave;
        private System.Windows.Forms.Button btn_BrowsePathSave;
        private System.Windows.Forms.CheckBox ckb_SaveSameOrganize;
        private System.Windows.Forms.Button btn_ListFiles;
        private System.Windows.Forms.ListBox lst_Files;
        private System.Windows.Forms.CheckBox ckb_Jpeg;
        private System.Windows.Forms.CheckBox ckb_PNG;
        private System.Windows.Forms.CheckBox ckb_BMP;
        private System.Windows.Forms.CheckBox ckb_Dng;
        private System.Windows.Forms.CheckBox ckb_Raw;
        private System.Windows.Forms.CheckBox ckb_Mp3;
        private System.Windows.Forms.CheckBox ckb_Wma;
        private System.Windows.Forms.CheckBox ckb_Wav;
        private System.Windows.Forms.CheckBox ckb_Mpa;
        private System.Windows.Forms.CheckBox ckb_Ogg;
        private System.Windows.Forms.CheckBox ckb_Mp4;
        private System.Windows.Forms.CheckBox ckb_Avi;
        private System.Windows.Forms.CheckBox ckb_Mpg;
        private System.Windows.Forms.CheckBox ckb_M4v;
        private System.Windows.Forms.CheckBox ckb_Wmv;
        private System.Windows.Forms.CheckBox ckb_Csv;
        private System.Windows.Forms.CheckBox ckb_Txt;
        private System.Windows.Forms.CheckBox ckb_Xls;
        private System.Windows.Forms.CheckBox ckb_XLSX;
        private System.Windows.Forms.CheckBox ckb_Xlsm;
        private System.Windows.Forms.CheckBox ckb_Doc;
        private System.Windows.Forms.CheckBox ckb_Pdf;
        private System.Windows.Forms.CheckBox ckb_Ppt;
        private System.Windows.Forms.CheckBox ckb_Pptx;
        private System.Windows.Forms.CheckBox ckb_Odp;
        private System.Windows.Forms.CheckBox ckb_Cs;
        private System.Windows.Forms.CheckBox ckb_C;
        private System.Windows.Forms.CheckBox ckb_Cpp;
        private System.Windows.Forms.CheckBox ckb_Php;
        private System.Windows.Forms.CheckBox ckb_Py;
        private System.Windows.Forms.CheckBox ckb_All;
        private System.Windows.Forms.ComboBox cmb_MoveCopy;
        private System.Windows.Forms.Label lbl_MoveCopy;
        private System.Windows.Forms.ListBox lst_FoldersNotIncluded;
        private System.Windows.Forms.GroupBox gbExtensions;
        private System.Windows.Forms.ListBox lst_FoldersIncluded;
        private System.Windows.Forms.GroupBox gbFolderOrganization;
        private System.Windows.Forms.Button btn_AddExtension;
        private System.Windows.Forms.Button btn_RemoveExtension;
        private System.Windows.Forms.Button btn_DownFolder;
        private System.Windows.Forms.Button btn_UpFolder;
        private System.Windows.Forms.CheckBox ckb_CreateFileOrganizerFolder;
    }
}

