namespace TextEditor
{
    public partial class Form1 : Form
    {
        public string fileName;
        public bool isFileChanged;
        public Form1()
        {
            InitializeComponent();
        }

        public void Init()
        {
            fileName = "";
            isFileChanged = false;
            UpdateTitleWithFile();
        }

        public void CreateNewDocument(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            textBox1.Text = "";
            fileName = "";
            UpdateTitleWithFile();
        }

        public void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            SaveUnsavedFile();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        textBox1.Text = sr.ReadToEnd();
                        sr.Close();
                        isFileChanged = false;
                    }

                    fileName = openFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Error reading file.");
                }
            }
            UpdateTitleWithFile();
        }

        public void SaveFile(string _fileName)
        {
            if (_fileName == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _fileName = saveFileDialog1.FileName;
                }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(_fileName + ".txt"))
                {
                    sw.Write(textBox1.Text);
                    fileName = _fileName;
                    sw.Close();
                    isFileChanged = false;
                }
            }
            catch
            {
                MessageBox.Show("Error writing into file.");
            }
            UpdateTitleWithFile();
        }

        public void Save(object sender, EventArgs e)
        {
            SaveFile(fileName);
        }

        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile("");
        }

        public void UpdateTitleWithFile()
        {
            if (fileName != "")
            {
                this.Text = fileName + " - Notepad";
            }
            else
            {
                this.Text = "Untitled - Notepad";
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace("*", "");
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }

        public void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Save file.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(fileName);
                }
            }
        }

        public void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CopyText()
        {
            Clipboard.SetText(textBox1.SelectedText);
        }

        public void CutText()
        {
            Clipboard.SetText(textBox1.SelectedText);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }

        public void PasteText()
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.TextLength - textBox1.SelectionStart);
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnPasteText(object sender, EventArgs e)
        {
            PasteText();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }
    }
}