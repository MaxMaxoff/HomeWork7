using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class fmMain : Form
    {
        Game game;

        public fmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game();
            MessageBox.Show("Число от до 100 загадано, Ваш ход!");

            txbxLog.Clear();
            txbxLog.Text = "Число от 1 до 100 загадано, Ваш ход!";
            btCheck.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (game.Status(Int32.Parse(maskedTBNumber.Text)) == 0)
            {
                ShowMessageBox("Угадали!");
                btCheck.Enabled = false;
            }
            else if (game.Status(Int32.Parse(maskedTBNumber.Text)) < 0) ShowMessageBox($"{maskedTBNumber.Text}: мое число меньше!");
            else if (game.Status(Int32.Parse(maskedTBNumber.Text)) > 0) ShowMessageBox($"{maskedTBNumber.Text}: мое число больше!");
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message);

            txbxLog.AppendText(Environment.NewLine);
            txbxLog.AppendText(message);
            Console.WriteLine(game.Number);
        }

        private void maskedTBNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTBNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (game.Status(Int32.Parse(maskedTBNumber.Text)) == 0)
            {
                ShowMessageBox("Угадали!");
                btCheck.Enabled = false;
            }
            else if (game.Status(Int32.Parse(maskedTBNumber.Text)) < 0) ShowMessageBox($"{maskedTBNumber.Text}: мое число меньше!");
            else if (game.Status(Int32.Parse(maskedTBNumber.Text)) > 0) ShowMessageBox($"{maskedTBNumber.Text}: мое число больше!");
        }

        private void BtCheck_Click(object sender, EventArgs e)
        {
            
        }
    }
}
