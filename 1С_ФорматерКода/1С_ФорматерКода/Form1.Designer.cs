namespace _1С_ФорматерКода
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputText_label = new System.Windows.Forms.Label();
            this.Format_button = new System.Windows.Forms.Button();
            this.ouptputText_label = new System.Windows.Forms.Label();
            this.inputText_richTextBox = new System.Windows.Forms.RichTextBox();
            this.outputText_richTextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Text_tabPage = new System.Windows.Forms.TabPage();
            this.File_tabPage = new System.Windows.Forms.TabPage();
            this.File_Status_label = new System.Windows.Forms.Label();
            this.File_Encoding_comboBox = new System.Windows.Forms.ComboBox();
            this.File_Encoding_label = new System.Windows.Forms.Label();
            this.File_button = new System.Windows.Forms.Button();
            this.File_textBox = new System.Windows.Forms.TextBox();
            this.Folder_tabPage = new System.Windows.Forms.TabPage();
            this.Folder_Status_label = new System.Windows.Forms.Label();
            this.Folder_Encoding_comboBox = new System.Windows.Forms.ComboBox();
            this.Folder_Encoding_label = new System.Windows.Forms.Label();
            this.SubFodlers_checkBox = new System.Windows.Forms.CheckBox();
            this.Folder_SearchPattern_textBox = new System.Windows.Forms.TextBox();
            this.Folder_SearchPattern_label = new System.Windows.Forms.Label();
            this.Folder_button = new System.Windows.Forms.Button();
            this.Folder_textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Text_tabPage.SuspendLayout();
            this.File_tabPage.SuspendLayout();
            this.Folder_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputText_label
            // 
            this.inputText_label.AutoSize = true;
            this.inputText_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputText_label.Location = new System.Drawing.Point(0, 0);
            this.inputText_label.Name = "inputText_label";
            this.inputText_label.Size = new System.Drawing.Size(140, 13);
            this.inputText_label.TabIndex = 1;
            this.inputText_label.Text = "Код для форматирования:";
            // 
            // Format_button
            // 
            this.Format_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Format_button.Location = new System.Drawing.Point(0, 0);
            this.Format_button.Name = "Format_button";
            this.Format_button.Size = new System.Drawing.Size(624, 23);
            this.Format_button.TabIndex = 2;
            this.Format_button.Text = "Форматировать";
            this.Format_button.UseVisualStyleBackColor = true;
            this.Format_button.Click += new System.EventHandler(this.Format_button_Click);
            // 
            // ouptputText_label
            // 
            this.ouptputText_label.AutoSize = true;
            this.ouptputText_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.ouptputText_label.Location = new System.Drawing.Point(0, 0);
            this.ouptputText_label.Name = "ouptputText_label";
            this.ouptputText_label.Size = new System.Drawing.Size(152, 13);
            this.ouptputText_label.TabIndex = 3;
            this.ouptputText_label.Text = "Результат форматирования:";
            // 
            // inputText_richTextBox
            // 
            this.inputText_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputText_richTextBox.Location = new System.Drawing.Point(0, 13);
            this.inputText_richTextBox.Name = "inputText_richTextBox";
            this.inputText_richTextBox.Size = new System.Drawing.Size(610, 180);
            this.inputText_richTextBox.TabIndex = 5;
            this.inputText_richTextBox.Text = "";
            // 
            // outputText_richTextBox
            // 
            this.outputText_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputText_richTextBox.Location = new System.Drawing.Point(0, 13);
            this.outputText_richTextBox.Name = "outputText_richTextBox";
            this.outputText_richTextBox.Size = new System.Drawing.Size(610, 177);
            this.outputText_richTextBox.TabIndex = 6;
            this.outputText_richTextBox.Text = "";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.inputText_richTextBox);
            this.splitContainer.Panel1.Controls.Add(this.inputText_label);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.outputText_richTextBox);
            this.splitContainer.Panel2.Controls.Add(this.ouptputText_label);
            this.splitContainer.Size = new System.Drawing.Size(610, 387);
            this.splitContainer.SplitterDistance = 193;
            this.splitContainer.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Text_tabPage);
            this.tabControl.Controls.Add(this.File_tabPage);
            this.tabControl.Controls.Add(this.Folder_tabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 23);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(624, 419);
            this.tabControl.TabIndex = 8;
            // 
            // Text_tabPage
            // 
            this.Text_tabPage.Controls.Add(this.splitContainer);
            this.Text_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Text_tabPage.Name = "Text_tabPage";
            this.Text_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Text_tabPage.Size = new System.Drawing.Size(616, 393);
            this.Text_tabPage.TabIndex = 0;
            this.Text_tabPage.Text = "Текст";
            this.Text_tabPage.UseVisualStyleBackColor = true;
            // 
            // File_tabPage
            // 
            this.File_tabPage.Controls.Add(this.File_Status_label);
            this.File_tabPage.Controls.Add(this.File_Encoding_comboBox);
            this.File_tabPage.Controls.Add(this.File_Encoding_label);
            this.File_tabPage.Controls.Add(this.File_button);
            this.File_tabPage.Controls.Add(this.File_textBox);
            this.File_tabPage.Location = new System.Drawing.Point(4, 22);
            this.File_tabPage.Name = "File_tabPage";
            this.File_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.File_tabPage.Size = new System.Drawing.Size(616, 393);
            this.File_tabPage.TabIndex = 1;
            this.File_tabPage.Text = "Файл";
            this.File_tabPage.UseVisualStyleBackColor = true;
            // 
            // File_Status_label
            // 
            this.File_Status_label.AutoSize = true;
            this.File_Status_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.File_Status_label.Location = new System.Drawing.Point(3, 377);
            this.File_Status_label.Name = "File_Status_label";
            this.File_Status_label.Size = new System.Drawing.Size(87, 13);
            this.File_Status_label.TabIndex = 4;
            this.File_Status_label.Text = "File_Status_label";
            // 
            // File_Encoding_comboBox
            // 
            this.File_Encoding_comboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.File_Encoding_comboBox.FormattingEnabled = true;
            this.File_Encoding_comboBox.Location = new System.Drawing.Point(3, 59);
            this.File_Encoding_comboBox.Name = "File_Encoding_comboBox";
            this.File_Encoding_comboBox.Size = new System.Drawing.Size(610, 21);
            this.File_Encoding_comboBox.TabIndex = 3;
            this.File_Encoding_comboBox.SelectedIndexChanged += new System.EventHandler(this.File_Encoding_comboBox_SelectedIndexChanged);
            // 
            // File_Encoding_label
            // 
            this.File_Encoding_label.AutoSize = true;
            this.File_Encoding_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.File_Encoding_label.Location = new System.Drawing.Point(3, 46);
            this.File_Encoding_label.Name = "File_Encoding_label";
            this.File_Encoding_label.Size = new System.Drawing.Size(65, 13);
            this.File_Encoding_label.TabIndex = 2;
            this.File_Encoding_label.Text = "Кодировка:";
            // 
            // File_button
            // 
            this.File_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.File_button.Location = new System.Drawing.Point(3, 23);
            this.File_button.Name = "File_button";
            this.File_button.Size = new System.Drawing.Size(610, 23);
            this.File_button.TabIndex = 1;
            this.File_button.Text = "Обзор...";
            this.File_button.UseVisualStyleBackColor = true;
            this.File_button.Click += new System.EventHandler(this.File_button_Click);
            // 
            // File_textBox
            // 
            this.File_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.File_textBox.Location = new System.Drawing.Point(3, 3);
            this.File_textBox.Name = "File_textBox";
            this.File_textBox.ReadOnly = true;
            this.File_textBox.Size = new System.Drawing.Size(610, 20);
            this.File_textBox.TabIndex = 0;
            // 
            // Folder_tabPage
            // 
            this.Folder_tabPage.Controls.Add(this.Folder_Status_label);
            this.Folder_tabPage.Controls.Add(this.Folder_Encoding_comboBox);
            this.Folder_tabPage.Controls.Add(this.Folder_Encoding_label);
            this.Folder_tabPage.Controls.Add(this.SubFodlers_checkBox);
            this.Folder_tabPage.Controls.Add(this.Folder_SearchPattern_textBox);
            this.Folder_tabPage.Controls.Add(this.Folder_SearchPattern_label);
            this.Folder_tabPage.Controls.Add(this.Folder_button);
            this.Folder_tabPage.Controls.Add(this.Folder_textBox);
            this.Folder_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Folder_tabPage.Name = "Folder_tabPage";
            this.Folder_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Folder_tabPage.Size = new System.Drawing.Size(616, 393);
            this.Folder_tabPage.TabIndex = 2;
            this.Folder_tabPage.Text = "Каталог";
            this.Folder_tabPage.UseVisualStyleBackColor = true;
            // 
            // Folder_Status_label
            // 
            this.Folder_Status_label.AutoSize = true;
            this.Folder_Status_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Folder_Status_label.Location = new System.Drawing.Point(3, 377);
            this.Folder_Status_label.Name = "Folder_Status_label";
            this.Folder_Status_label.Size = new System.Drawing.Size(100, 13);
            this.Folder_Status_label.TabIndex = 16;
            this.Folder_Status_label.Text = "Folder_Status_label";
            // 
            // Folder_Encoding_comboBox
            // 
            this.Folder_Encoding_comboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Folder_Encoding_comboBox.FormattingEnabled = true;
            this.Folder_Encoding_comboBox.Location = new System.Drawing.Point(3, 109);
            this.Folder_Encoding_comboBox.Name = "Folder_Encoding_comboBox";
            this.Folder_Encoding_comboBox.Size = new System.Drawing.Size(610, 21);
            this.Folder_Encoding_comboBox.TabIndex = 15;
            this.Folder_Encoding_comboBox.SelectedIndexChanged += new System.EventHandler(this.Folder_Encoding_comboBox_SelectedIndexChanged);
            // 
            // Folder_Encoding_label
            // 
            this.Folder_Encoding_label.AutoSize = true;
            this.Folder_Encoding_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Folder_Encoding_label.Location = new System.Drawing.Point(3, 96);
            this.Folder_Encoding_label.Name = "Folder_Encoding_label";
            this.Folder_Encoding_label.Size = new System.Drawing.Size(65, 13);
            this.Folder_Encoding_label.TabIndex = 14;
            this.Folder_Encoding_label.Text = "Кодировка:";
            // 
            // SubFodlers_checkBox
            // 
            this.SubFodlers_checkBox.AutoSize = true;
            this.SubFodlers_checkBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubFodlers_checkBox.Location = new System.Drawing.Point(3, 79);
            this.SubFodlers_checkBox.Name = "SubFodlers_checkBox";
            this.SubFodlers_checkBox.Size = new System.Drawing.Size(610, 17);
            this.SubFodlers_checkBox.TabIndex = 13;
            this.SubFodlers_checkBox.Text = "+ Подкаталоги";
            this.SubFodlers_checkBox.UseVisualStyleBackColor = true;
            // 
            // Folder_SearchPattern_textBox
            // 
            this.Folder_SearchPattern_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Folder_SearchPattern_textBox.Location = new System.Drawing.Point(3, 59);
            this.Folder_SearchPattern_textBox.Name = "Folder_SearchPattern_textBox";
            this.Folder_SearchPattern_textBox.Size = new System.Drawing.Size(610, 20);
            this.Folder_SearchPattern_textBox.TabIndex = 12;
            this.Folder_SearchPattern_textBox.Text = "*.txt";
            // 
            // Folder_SearchPattern_label
            // 
            this.Folder_SearchPattern_label.AutoSize = true;
            this.Folder_SearchPattern_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Folder_SearchPattern_label.Location = new System.Drawing.Point(3, 46);
            this.Folder_SearchPattern_label.Name = "Folder_SearchPattern_label";
            this.Folder_SearchPattern_label.Size = new System.Drawing.Size(89, 13);
            this.Folder_SearchPattern_label.TabIndex = 11;
            this.Folder_SearchPattern_label.Text = "Фильтр поиска:";
            this.toolTip.SetToolTip(this.Folder_SearchPattern_label, "* - для любых файлов\r\n*.txt - для текстовых файлов");
            // 
            // Folder_button
            // 
            this.Folder_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Folder_button.Location = new System.Drawing.Point(3, 23);
            this.Folder_button.Name = "Folder_button";
            this.Folder_button.Size = new System.Drawing.Size(610, 23);
            this.Folder_button.TabIndex = 10;
            this.Folder_button.Text = "Обзор...";
            this.Folder_button.UseVisualStyleBackColor = true;
            this.Folder_button.Click += new System.EventHandler(this.Folder_button_Click);
            // 
            // Folder_textBox
            // 
            this.Folder_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Folder_textBox.Location = new System.Drawing.Point(3, 3);
            this.Folder_textBox.Name = "Folder_textBox";
            this.Folder_textBox.Size = new System.Drawing.Size(610, 20);
            this.Folder_textBox.TabIndex = 9;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Format_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "1C Форматер кода";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.Text_tabPage.ResumeLayout(false);
            this.File_tabPage.ResumeLayout(false);
            this.File_tabPage.PerformLayout();
            this.Folder_tabPage.ResumeLayout(false);
            this.Folder_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inputText_label;
        private System.Windows.Forms.Button Format_button;
        private System.Windows.Forms.Label ouptputText_label;
        private System.Windows.Forms.RichTextBox inputText_richTextBox;
        private System.Windows.Forms.RichTextBox outputText_richTextBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Text_tabPage;
        private System.Windows.Forms.TabPage File_tabPage;
        private System.Windows.Forms.TabPage Folder_tabPage;
        private System.Windows.Forms.Button File_button;
        private System.Windows.Forms.TextBox File_textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button Folder_button;
        private System.Windows.Forms.TextBox Folder_textBox;
        private System.Windows.Forms.CheckBox SubFodlers_checkBox;
        private System.Windows.Forms.TextBox Folder_SearchPattern_textBox;
        private System.Windows.Forms.Label Folder_SearchPattern_label;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox File_Encoding_comboBox;
        private System.Windows.Forms.Label File_Encoding_label;
        private System.Windows.Forms.Label Folder_Encoding_label;
        private System.Windows.Forms.ComboBox Folder_Encoding_comboBox;
        private System.Windows.Forms.Label Folder_Status_label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label File_Status_label;
    }
}

