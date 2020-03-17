using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TextCensoring {
    public partial class FileCensoring : Form {
        string names = "./names.txt";
        string surnames = "./surnames.txt";
        string cities = "./cities.txt";

        string fileText = default;
        string fileName = default;
        string newFileName = default;
        
        public FileCensoring()
        {
            fileText = File.ReadAllText(cities, Encoding.GetEncoding(1251));
            File.WriteAllText(cities, fileText.ToLower());
            InitializeComponent();
        }

        private void Chose_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = openFileDialog.FileName;
            fileText = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            file_name.Text = openFileDialog.SafeFileName;
            open_catalog.Visible = false;
            open_file.Visible = false;
            newFileName = default;
        }

        private void Censoring_Click(object sender, EventArgs e)
        {
            if (fileName != default && newFileName == default && 
                File.Exists(names) && File.Exists(surnames) && File.Exists(cities)) {
                wait_label.Visible = true;
                wait_label.Refresh();

                // скрытие конфиденциальных данных
                // конец скрытия конфиденциальных данных

                newFileName = openFileDialog.FileName.Insert(openFileDialog.FileName.Length - 4, "_censored");
                File.WriteAllText(newFileName, fileText);
                wait_label.Visible = false;
                open_catalog.Visible = true;
                open_file.Visible = true;
            }
        }

        private void Open_catalog_Click(object sender, EventArgs e)
        {
            if (File.Exists(newFileName))
                Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + newFileName));
        }

        private void Open_file_Click(object sender, EventArgs e)
        {
            if (File.Exists(newFileName))
                Process.Start(new ProcessStartInfo("notepad.exe", newFileName));
        }
    }
}
