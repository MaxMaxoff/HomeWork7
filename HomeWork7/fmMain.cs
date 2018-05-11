using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Максим Торопов
/// Ярославль
/// Домашняя работа 7 урока
/// 
/// а) Добавить в программу “Удвоитель” подсчет количества отданных команд удвоителю.
/// б) Добавить меню и команду “Играть”. При нажатии появляется сообщение, какое число должен получить игрок.
/// Игрок должен постараться получить это число за минимальное количество ходов.
/// в) * Добавить кнопку “Отменить”, которая отменяет последние ходы.
/// </summary>
namespace HomeWork7
{
    public partial class fmMain : Form
    {
        Doubler t;

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
            t = new Doubler();
            lbFinish.Text = $"Цель: {t.Finish.ToString()}";

            MessageBox.Show(lbFinish.Text);

            txbxLog.Text = String.Empty;   
            txbxLog.AppendText(t.Log("NewGame"));
            UpdateGameStatus();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            t.Increment();

            txbxLog.AppendText(Environment.NewLine);
            txbxLog.AppendText(t.Log("Plus"));
            UpdateGameStatus();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            t.Doubling();

            txbxLog.AppendText(Environment.NewLine);
            txbxLog.AppendText(t.Log("Doubling"));
            UpdateGameStatus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            t.Reset();

            txbxLog.AppendText(Environment.NewLine);
            txbxLog.AppendText(t.Log("Reset"));
            UpdateGameStatus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (t.Steps > 0)
            {
                // Remove last line
                txbxLog.Text = txbxLog.Text.Remove(txbxLog.Text.LastIndexOf(Environment.NewLine));

                // StepBack using last line
                t.Back(txbxLog.Lines.GetValue(txbxLog.Lines.Length - 1).ToString());

                UpdateGameStatus();
            };
        }

        private void UpdateGameStatus()
        {
            lbCurrent.Text = $"Текущее: {t.Current.ToString()}";
            lbStep.Text = $"Шаг: {t.Steps.ToString()}";

            if (t.Current > t.Finish)
            {
                btnPlus.Enabled = false;
                btnMulti.Enabled = false;
                btnReset.Enabled = false;
                btnBack.Enabled = false;
                MessageBox.Show("Вы проиграли!");
            }
            if (t.Current == t.Finish)
            {
                btnPlus.Enabled = false;
                btnMulti.Enabled = false;
                btnReset.Enabled = false;
                btnBack.Enabled = false;
                MessageBox.Show("Вы выиграли!");
            }
            if (t.Current < t.Finish)
            {
                btnPlus.Enabled = true;
                btnMulti.Enabled = true;
                btnReset.Enabled = true;
                btnBack.Enabled = true;
            }
        }
    }
}
