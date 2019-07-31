using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Interface;

namespace WindowsFormsApp2
{
    public partial class MineForm : Form, IMainFormcs
    {
        public MineForm()
        {
            InitializeComponent();

            butOpenFile.Click += new EventHandler(ButOpenFile_Click);
            buttSave.Click += ButtSave_Click;
            textBOX.Click += TextBOX_Click;
            butSelectFile.Click += ButSelectFile_Click;
            numericUpDown1.Click += NumericUpDown1_Click;
        }

        private void ButSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл|*.txt|Все файлы|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {


                if (true)
                {
                    filePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void NumericUpDown1_Click(object sender, EventArgs e)
        {
            textBOX.Font = new Font("Calibri", (float)numericUpDown1.Value);
        }

        private void TextBOX_Click(object sender, EventArgs e)
        {
            if (ContentsChanged != null)
            {
                ContentsChanged(this, EventArgs.Empty);
            }   
        }

        private void ButtSave_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null)
            {
                FileSaveClick(this, EventArgs.Empty);
            }
        }

        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null)
            {
                FileOpenClick(this, EventArgs.Empty);
            }
        }

        public string FilePath { get { return filePath.Text; } }

        public string Content { get { return textBOX.Text; } set { textBOX.Text = value; } }

        public void SetSymboleCount(int conut)
        {
           
        }
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentsChanged;

    }
}
