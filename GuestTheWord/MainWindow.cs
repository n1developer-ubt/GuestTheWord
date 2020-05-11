using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestTheWord.Properties;

namespace GuestTheWord
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            nudWordsSelect.DataBindings.Add("Value", nudWordsFlash, "Maximum");
            LoadSettings();
        }

        private void LoadSettings()
        {
            nudWordsSelect.Value = Settings.Default.SelectWords;
            nudWordsFlash.Value = Settings.Default.FlashWords;
            nudHideWords.Value = Settings.Default.Hide;
            if(!Settings.Default.Words.Trim().Equals(""))
                txtWords.Text = Settings.Default.Words;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.FlashWords = (int)nudWordsFlash.Value;
            Settings.Default.SelectWords = (int)nudWordsSelect.Value;
            Settings.Default.Words = txtWords.Text;
            Settings.Default.Hide = (int) nudHideWords.Value;
            Settings.Default.Save();
            MessageBox.Show("Setting Saved!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private int Index = -1;
        private List<List<string>> _splitWords = null;
        private async void btnStart_Click(object sender, EventArgs e)
        {
            var words = Settings.Default.Words.Split('\n').Where(x=>!string.IsNullOrEmpty(x.Trim())).ToList();

            if (Settings.Default.SelectWords > words.Count)
            {
                MessageBox.Show("Number of words are less then number of words to be selected!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Random rand = new Random();
            var selectWords = Settings.Default.SelectWords;
            var flashWords = Settings.Default.FlashWords;

            words = words.OrderBy(x => rand.Next()).Take(selectWords).ToList();


            _splitWords = new List<List<string>>();


            while (words.Count != 0)
            {
                List<string> toAdd = null;

                try
                {
                    toAdd = words.OrderBy(x => rand.Next()).Take(flashWords).ToList();
                }
                catch (Exception exception)
                {
                    toAdd = words;
                }

                _splitWords.Add(toAdd);
                words.RemoveAll(x=>toAdd.Contains(x));
            }

            Index++;

            lblCurrentWords.Text = ToText(_splitWords[Index]);
            await Wait();
            lblCurrentWords.Text = "";
        }

        private async Task Wait()
        {
            await Task.Run(() => Thread.Sleep(Settings.Default.Hide * 1000));
        }

        private string ToText(List<string> list)
        {
            string text = "";

            list.ForEach(x =>
            {
                if (text.Equals(""))
                    text = x;
                else
                {
                    text += ", " + x;
                }
            });

            return text;
        }

        private async Task Next()
        {
            if (Index < 0)
            {
                MessageBox.Show("Game Not Started Yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Index == _splitWords.Count-1)
            {
                MessageBox.Show("Game Over","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(!Match(_splitWords[Index], txtAnswer.Text.Split(',').ToList()))
            {
                MessageBox.Show("Enter Correct Words", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblCurrentWords.Text = ToText(_splitWords[++Index]);
            txtAnswer.Text = "";
            await Wait();
            lblCurrentWords.Text = "";
        }

        private bool Match(List<string> x, List<string> y)
        {
            if (x == null || y == null)
                return false;

            if (x.Count != y.Count)
                return false;

            for (int i = 0; i < x.Count; i++)
            {
                if (!x[i].ToLower().Trim().Equals(y[i].ToLower().Trim()))
                    return false;
            }

            return true;
        }

        private async void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Next();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Index = -1;
            lblCurrentWords.Text = "Words, Will, Appear, Here";
            txtAnswer.Reset();
        }
    }
}
