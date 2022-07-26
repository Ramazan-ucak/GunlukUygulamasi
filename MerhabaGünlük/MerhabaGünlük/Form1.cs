using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaGünlük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TSCB_size.Text = richTextBox1.Font.Size.ToString();
            FontFamily[] fonts = FontFamily.Families;
            foreach(FontFamily family in fonts)
            {
                TSCB_font.Items.Add(family.Name);
            }
            TSCB_font.SelectedItem = richTextBox1.Font.FontFamily.Name;
            saveFileDialog1.Filter = "Zengin Metin Biçimi | *.rtf";
        }

        private void TSMI_Ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                richTextBox1.LoadFile(path);
            }
        }

        private void TSMI_Kaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                richTextBox1.SaveFile(path);
            }
        }

        private void TSMI_font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.Font = fontDialog1.Font;
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void TSMI_Renk_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                
                richTextBox1.SelectionColor = colorDialog1.Color;
               
            }
        }

        private void TSCB_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily[] fonts = FontFamily.Families;
            int index = TSCB_font.SelectedIndex;
            float size = float.Parse(TSCB_size.Text);
            richTextBox1.SelectionFont = new Font(fonts[index], size);
        }

        private void TSCB_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily[] fonts = FontFamily.Families;
            int index = TSCB_font.SelectedIndex;
            float size = float.Parse(TSCB_size.Text);
            richTextBox1.SelectionFont = new Font(fonts[index], size);
        }

        private void TSMI_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                TSMI_color.ForeColor = colorDialog1.Color;
            }
        }

        private void TSMI_bold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
                TSMI_bold.BackColor = SystemColors.Control;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
                TSMI_bold.BackColor = Color.Silver;
            }
        }
    }
}
