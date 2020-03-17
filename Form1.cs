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
				string[] words = fileText.Split(new char[] { ' ', '\n' });
                string censorshipString = File.ReadAllText(names, Encoding.GetEncoding(1251)) + 
                                          File.ReadAllText(surnames, Encoding.GetEncoding(1251)) + 
                                          File.ReadAllText(cities, Encoding.GetEncoding(1251));
                string[] censorship = censorshipString.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                char[] specialSymbols = "`~!@\"#№$;%:^?&*()-_=+[]{}'\\|/.,\r".ToCharArray();
                for (int i = 0; i < words.Length; i++) {
                    // проверка на присутствие телефона
                    bool separator = false;
                    byte numbers = 0;
                    for (int j = 0; j < words[i].Length; j++) {
                        if (char.IsDigit(words[i][j])) {
                            numbers++;
                            if (numbers > 11)
                                break;
                            if (separator) {
                                separator = false;
                            }
                        }
                        else if (!separator) {
                            separator = true;
                        }
                        else {
                            break;
                        }
                    }
                    if (numbers == 11) {
                        if (words[i].EndsWith("\r"))
                            words[i] = "[censored]\r";
                        else
                            words[i] = "[censored]";
                    }
                    else {
                        // проверка на присутствие имени, фамилии или города
                        for (int j = 0; j < censorship.Length; j++) {
                            if (words[i].Trim(specialSymbols).ToLower() == censorship[j]) {
                                if (words[i].EndsWith("\r"))
                                    words[i] = "[censored]\r";
                                else
                                    words[i] = "[censored]";
                                break;
                            } 
                        }
                    }
                }
                fileText = "";
                for (int i = 0; i < words.Length; i++) {
                    fileText += words[i];
                    if (words[i].EndsWith("\r"))
                        fileText += "\n";
                    else
                        fileText += " ";
                }
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
