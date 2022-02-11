using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextStats {
    public partial class MainForm : Form {

        delegate void OpenFileDialogCallback(OpenFileDialog path);

        private static readonly Regex _newWordRegex = new Regex(@"\b[\s,\.\-:;]*"); //you can change this regex depending on how you define a word

        public MainForm() {
            InitializeComponent();
        }

        private void BrowseBtnClick(object sender, EventArgs e) {
            ShowOpenFileDialog((OpenFileDialog dialog)=> {
                string content = GetContentFromStream(dialog.OpenFile());

                if (String.IsNullOrEmpty(content)) {
                    ContentLabel.Text = 
                        $"File path: \n {dialog.FileName} \n\n" +
                        $"File is empty";
                    return;
                }

                string[] words = stringToWordArray(content);

                ContentLabel.Text = 
                    $"File path: \n {dialog.FileName} \n\n" +
                    $"Word count: {words.Length} \n\n" +
                    $"Longest Word: {CalcLongestWord(words)}\n\n" +
                    $"Shortest Word: {CalcShortestWord(words)}\n\n" +
                    $"Average Word Length: {CalcAverageWordLength(words)}";
            });
        }

        private void ShowOpenFileDialog(OpenFileDialogCallback openFileDialogCallback) {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    openFileDialogCallback?.Invoke(openFileDialog);
                }
            }
        }

        private string GetContentFromStream(Stream stream) {
            using (StreamReader reader = new StreamReader(stream)) {
                return reader.ReadToEnd();
            }
        }

        private string[] stringToWordArray(string str) {
            return _newWordRegex.Split(str).Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        private string CalcLongestWord(string[] words) {
            string longestWord = string.Empty;

            foreach (string word in words) {
                if (word.Length > longestWord.Length) {
                    longestWord = word;
                }
            }

            return longestWord;
        }

        private string CalcShortestWord(string[] words) {
            string shortestWord = "";
            int wordLength = int.MaxValue;

            foreach (string word in words) {
                if (word.Length < wordLength) {
                    shortestWord = word;
                    wordLength = word.Length;
                }
            }

            return shortestWord;
        }

        private float CalcAverageWordLength(string[] words) {
            int totalWordLength = 0;

            foreach (string word in words) {
                totalWordLength += word.Length;
            }

            return totalWordLength / (float) words.Length;
        }
    }
}
