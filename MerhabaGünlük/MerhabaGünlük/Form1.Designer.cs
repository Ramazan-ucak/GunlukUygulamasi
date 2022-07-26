namespace MerhabaGünlük
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Ac = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Farklikaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_font = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Renk = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_yeni = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_ac = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_kaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSCB_font = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSCB_size = new System.Windows.Forms.ToolStripComboBox();
            this.TSMI_color = new System.Windows.Forms.ToolStripButton();
            this.TSMI_bold = new System.Windows.Forms.ToolStripButton();
            this.TSMI_Italic = new System.Windows.Forms.ToolStripButton();
            this.TSMI_undeline = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Ac,
            this.toolStripSeparator1,
            this.TSMI_Kaydet,
            this.TSMI_Farklikaydet,
            this.toolStripSeparator2,
            this.TSMI_Kapat});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSMI_Ac
            // 
            this.TSMI_Ac.Name = "TSMI_Ac";
            this.TSMI_Ac.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMI_Ac.Size = new System.Drawing.Size(188, 26);
            this.TSMI_Ac.Text = "Aç";
            this.TSMI_Ac.Click += new System.EventHandler(this.TSMI_Ac_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // TSMI_Kaydet
            // 
            this.TSMI_Kaydet.Name = "TSMI_Kaydet";
            this.TSMI_Kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_Kaydet.Size = new System.Drawing.Size(188, 26);
            this.TSMI_Kaydet.Text = "Kaydet";
            this.TSMI_Kaydet.Click += new System.EventHandler(this.TSMI_Kaydet_Click);
            // 
            // TSMI_Farklikaydet
            // 
            this.TSMI_Farklikaydet.Name = "TSMI_Farklikaydet";
            this.TSMI_Farklikaydet.Size = new System.Drawing.Size(188, 26);
            this.TSMI_Farklikaydet.Text = "Farklı Kaydet";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // TSMI_Kapat
            // 
            this.TSMI_Kapat.Name = "TSMI_Kapat";
            this.TSMI_Kapat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TSMI_Kapat.Size = new System.Drawing.Size(188, 26);
            this.TSMI_Kapat.Text = "Kapat";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_font,
            this.TSMI_Renk});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // TSMI_font
            // 
            this.TSMI_font.Name = "TSMI_font";
            this.TSMI_font.Size = new System.Drawing.Size(179, 26);
            this.TSMI_font.Text = "Font Ayarları";
            this.TSMI_font.Click += new System.EventHandler(this.TSMI_font_Click);
            // 
            // TSMI_Renk
            // 
            this.TSMI_Renk.Name = "TSMI_Renk";
            this.TSMI_Renk.Size = new System.Drawing.Size(179, 26);
            this.TSMI_Renk.Text = "Renk Ayarları";
            this.TSMI_Renk.Click += new System.EventHandler(this.TSMI_Renk_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1084, 375);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_yeni,
            this.tsbtn_ac,
            this.tsbtn_kaydet,
            this.toolStripSeparator3,
            this.TSCB_font,
            this.toolStripSeparator4,
            this.TSCB_size,
            this.TSMI_color,
            this.TSMI_bold,
            this.TSMI_Italic,
            this.TSMI_undeline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1119, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_yeni
            // 
            this.tsbtn_yeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_yeni.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_yeni.Image")));
            this.tsbtn_yeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_yeni.Name = "tsbtn_yeni";
            this.tsbtn_yeni.Size = new System.Drawing.Size(29, 25);
            this.tsbtn_yeni.Text = "toolStripButton1";
            // 
            // tsbtn_ac
            // 
            this.tsbtn_ac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_ac.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_ac.Image")));
            this.tsbtn_ac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ac.Name = "tsbtn_ac";
            this.tsbtn_ac.Size = new System.Drawing.Size(29, 25);
            this.tsbtn_ac.Text = "toolStripButton2";
            this.tsbtn_ac.Click += new System.EventHandler(this.TSMI_Ac_Click);
            // 
            // tsbtn_kaydet
            // 
            this.tsbtn_kaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_kaydet.Image")));
            this.tsbtn_kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_kaydet.Name = "tsbtn_kaydet";
            this.tsbtn_kaydet.Size = new System.Drawing.Size(29, 25);
            this.tsbtn_kaydet.Text = "toolStripButton3";
            this.tsbtn_kaydet.Click += new System.EventHandler(this.TSMI_Kaydet_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // TSCB_font
            // 
            this.TSCB_font.Name = "TSCB_font";
            this.TSCB_font.Size = new System.Drawing.Size(121, 28);
            this.TSCB_font.SelectedIndexChanged += new System.EventHandler(this.TSCB_font_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // TSCB_size
            // 
            this.TSCB_size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "36",
            "48",
            "72"});
            this.TSCB_size.Name = "TSCB_size";
            this.TSCB_size.Size = new System.Drawing.Size(121, 28);
            this.TSCB_size.SelectedIndexChanged += new System.EventHandler(this.TSCB_size_SelectedIndexChanged);
            // 
            // TSMI_color
            // 
            this.TSMI_color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_color.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TSMI_color.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_color.Image")));
            this.TSMI_color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_color.Name = "TSMI_color";
            this.TSMI_color.Size = new System.Drawing.Size(29, 25);
            this.TSMI_color.Text = "A";
            this.TSMI_color.Click += new System.EventHandler(this.TSMI_color_Click);
            // 
            // TSMI_bold
            // 
            this.TSMI_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TSMI_bold.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_bold.Image")));
            this.TSMI_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_bold.Name = "TSMI_bold";
            this.TSMI_bold.Size = new System.Drawing.Size(29, 25);
            this.TSMI_bold.Text = "K";
            this.TSMI_bold.Click += new System.EventHandler(this.TSMI_bold_Click);
            // 
            // TSMI_Italic
            // 
            this.TSMI_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_Italic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TSMI_Italic.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Italic.Image")));
            this.TSMI_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_Italic.Name = "TSMI_Italic";
            this.TSMI_Italic.Size = new System.Drawing.Size(29, 25);
            this.TSMI_Italic.Text = "I";
            // 
            // TSMI_undeline
            // 
            this.TSMI_undeline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_undeline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TSMI_undeline.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_undeline.Image")));
            this.TSMI_undeline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_undeline.Name = "TSMI_undeline";
            this.TSMI_undeline.Size = new System.Drawing.Size(29, 25);
            this.TSMI_undeline.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Ac;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Farklikaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kapat;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_font;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Renk;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_yeni;
        private System.Windows.Forms.ToolStripButton tsbtn_ac;
        private System.Windows.Forms.ToolStripButton tsbtn_kaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox TSCB_font;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox TSCB_size;
        private System.Windows.Forms.ToolStripButton TSMI_color;
        private System.Windows.Forms.ToolStripButton TSMI_bold;
        private System.Windows.Forms.ToolStripButton TSMI_Italic;
        private System.Windows.Forms.ToolStripButton TSMI_undeline;
    }
}

