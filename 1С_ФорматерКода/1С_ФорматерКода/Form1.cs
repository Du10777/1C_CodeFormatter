using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace _1С_ФорматерКода
{
    public partial class Form1 : Form
    {
        string Version = "1.0.1";

        public Form1()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            ЗаполнитьКодировки();
            Folder_Status_label.Text = "";
            File_Status_label.Text = "";

            this.Text += " v" + Version;
        }

        void ЗаполнитьКодировки()
        {
            EncodingInfo[] list = Encoding.GetEncodings();
            for(int i = 0; i < list.Length; i++)
            {
                string EncodingName = list[i].CodePage + " - " +
                    list[i].Name + " - " +
                    list[i].DisplayName;
                File_Encoding_comboBox.Items.Add(EncodingName);
                Folder_Encoding_comboBox.Items.Add(EncodingName);

                if (list[i].CodePage == 1251)
                {
                    File_Encoding_comboBox.SelectedIndex = i;
                    Folder_Encoding_comboBox.SelectedIndex = i;
                }
            }
        }
        string CurrentFolderStatus;
        string CurrentFileStatus;
        Encoding FileEncoding;
        Encoding FolderEncoding;

        private void Format_button_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
                ФорматироватьТекст();
            if (tabControl.SelectedIndex == 1)
                new Thread(ФорматироватьФайл).Start();
            if (tabControl.SelectedIndex == 2)
                new Thread(ФорматироватьКаталог).Start();
        }
        private void File_button_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            File_textBox.Text = openFileDialog.FileName;
        }

        void ФорматироватьТекст()
        {
            string Code = inputText_richTextBox.Text;

            Code = Форматировать(Code);

            outputText_richTextBox.Text = Code;
        }
        void ФорматироватьФайл()
        {
            string inFileName = openFileDialog.FileName;
            string outFileName = Path.GetDirectoryName(inFileName) + @"\" + 
                Path.GetFileNameWithoutExtension(inFileName) + "_Форматированный" + 
                Path.GetExtension(inFileName);

            #region Защита от дурака
            if (inFileName.Length == 0)
            {
                MessageBox.Show("Файл не выбран");
                return;
            }
            if (!File.Exists(inFileName))
            {
                MessageBox.Show("Не могу найти файл: \r\n" + inFileName);
                return;
            }
            #endregion

            CurrentFileStatus = "Форматирую файл: " + inFileName;
            string Code = File.ReadAllText(inFileName, FileEncoding);
            Code = Форматировать(Code);
            File.WriteAllText(outFileName, Code, FileEncoding);

            CurrentFileStatus = "Готово!";
        }
        void ФорматироватьКаталог()
        {
            string inFolder = Folder_textBox.Text;
            string outFolder = inFolder + @"\Форматированный_Код";

            string searchPattern = Folder_SearchPattern_textBox.Text;

            SearchOption searchOption = SearchOption.TopDirectoryOnly;
            if (SubFodlers_checkBox.Checked)
                searchOption = SearchOption.AllDirectories;
            
            Encoding enc = Encoding.GetEncodings()[Folder_Encoding_comboBox.SelectedIndex].GetEncoding();

            #region Защита от дурака
            if (inFolder.Length == 0)
            {
                MessageBox.Show("Каталог не выбран");
                return;
            }
            if (!Directory.Exists(inFolder))
            {
                MessageBox.Show("Не могу найти каталог: \r\n" + inFolder);
                return;
            }
            if (searchPattern.Length == 0)
            {
                MessageBox.Show("Не введен фильтр поиска");
                return;
            }
            #endregion

            CurrentFolderStatus = "Поиск файлов...";
            string[] list = Directory.GetFiles(inFolder, searchPattern, searchOption);
            if (list.Length == 0)
            {
                string Message = "";
                Message += "Не нашел ни одного файла " + searchPattern + "\r\n";
                Message += "В каталоге: \r\n";
                Message += inFolder;
                MessageBox.Show(Message);
                return;
            }
            
            for(int i = 0; i < list.Length; i++)
            {
                string ShortFileName = list[i].Remove(0, inFolder.Length);

                CurrentFolderStatus = "(" + (i + 1) + " / " + (list.Length + 1) + ") " + ShortFileName;

                string outFileName = outFolder + ShortFileName;
                Directory.CreateDirectory(Path.GetDirectoryName(outFileName));

                string Code = File.ReadAllText(list[i], enc);
                Code = Форматировать(Code);
                File.WriteAllText(outFileName, Code, enc);
            }

            CurrentFolderStatus = "Готово!";
        }

        private void Folder_button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath.Length == 0)
                return;

            Folder_textBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Folder_Status_label.Text = CurrentFolderStatus;
            File_Status_label.Text = CurrentFileStatus;
        }

        private void File_Encoding_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileEncoding = Encoding.GetEncodings()[File_Encoding_comboBox.SelectedIndex].GetEncoding();
        }

        private void Folder_Encoding_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FolderEncoding = Encoding.GetEncodings()[Folder_Encoding_comboBox.SelectedIndex].GetEncoding();
        }
    }
}
