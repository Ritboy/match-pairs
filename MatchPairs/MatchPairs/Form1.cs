using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatchPairs
{
    public partial class Form1 : Form
    {
        CodeFile code;
        DateTime date1;
        string imgpath;

        public Form1()
        {
            InitializeComponent();
            imgpath = "Space";
            CreateGame(4, 4, imgpath);
        }
        private void CreateGame(int columns, int rows, string imagesPath)
        {
            if (columns * rows % 2 == 0)
            {
                code = new CodeFile(columns, rows, imagesPath);
                Change_Table(columns, rows);
                SetEvents(code);
                date1 = new DateTime();
                timer1.Start();
            }
            else
                MessageBox.Show("Неправильно выбран размер поля.\nКоличество ячеек должно быть чётным.", "Неправильное поле");

        }
        private void SetEvents(CodeFile code)
        {
            foreach (MyButton item in code.buttons)
            {
                item.Click += MyButton_Click;
            }
        }
        private void Change_Table(int columns, int rows)
        {
            panel1.Controls.Clear();
            TableLayoutPanel table = new TableLayoutPanel();
            panel1.Controls.Add(table);
            table.BackColor = Color.SeaGreen;
            table.Dock = DockStyle.Fill;
            table.Controls.Clear();
            table.ColumnCount = columns;
            table.RowCount = rows;
            int width = 100 / columns;
            int height = 100 / rows;
            for (int col = 0; col < columns; col++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, width));
                for (int row = 0; row < rows; row++)
                {
                    table.RowStyles.Add(new RowStyle(SizeType.Percent, height));
                }
            }
            table.Controls.AddRange(code.buttons);
        }
        
        private void MyButton_Click(object sender, EventArgs e)
        {
            if (code.theOpenButton != null)                            //Если какая-то кнопка уже открыта
            {
                if (!(sender as MyButton).IsOpened)
                {
                    (sender as MyButton).Show_Picture();
                    code.stats++;
                    label_count.Text = code.stats.ToString();
                    if ((sender as MyButton).imgName == code.theOpenButton.imgName)
                    {
                        (sender as MyButton).Enabled = false;
                        code.theOpenButton.Enabled = false;
                        code.completeButtons += 2;
                        if (code.completeButtons == code.buttons.Length)
                        {
                            FinishGame();
                        }
                    }
                    code.theOpenButton = null;
                }
            }
            else
            {
                if (!(sender as MyButton).IsOpened)
                {
                    code.CloseAllButtons();
                    (sender as MyButton).Show_Picture();
                    code.theOpenButton = (sender as MyButton);
                    code.stats++;
                    label_count.Text = code.stats.ToString();
                }
            }
        }
        private void FinishGame()
        {
            timer1.Stop();        
            MessageBox.Show("Время: " + timer_label.Text + "\n" + "Количество ходов: " + code.stats, "Поздравляю!");
            string stat = "Дата: " + DateTime.Now.ToString() + "; Поле: " + numericUpDown_column.Value.ToString() + " X " + numericUpDown_row.Value.ToString() + "; Время: " + timer_label.Text + "; Количество ходов: " + label_count.Text;
            BinaryWriter bw = new BinaryWriter(new FileStream(@"stats", FileMode.Append, FileAccess.Write));
            bw.Write(stat);
            bw.Close();
            label_count.Text = "0";
            CreateGame((int)numericUpDown_column.Value, (int)numericUpDown_row.Value, imgpath);
        }
        private void Create_button_Click(object sender, EventArgs e)
        {
            if (space_radioButton.Checked)
                imgpath = "Space";
            if (digits_radioButton.Checked)
                imgpath = "Digits";
            if (fruits_radioButton.Checked)
                imgpath = "Fruits";
            if (user_radioButton.Checked)
                imgpath = folderBrowserDialog1.SelectedPath;
            CreateGame((int)numericUpDown_column.Value, (int)numericUpDown_row.Value, imgpath);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddSeconds(1);
            timer_label.Text = date1.ToString("mm:ss");
        }

        private void stats_button_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"stats", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                List<string> stats = new List<string>();
                while (fs.Position != fs.Length)
                    stats.Add(br.ReadString());
                string str = String.Empty;
                for (int i = 0; i < stats.Count; i++)
                {
                    str += i + 1 + ". " + stats[i] + "\n";
                }
                br.Close();
                StatsForm f = new StatsForm(str);
                f.ShowDialog(this);
            }
            catch (FileNotFoundException)
            {
                StatsForm f = new StatsForm("Статистика сброшена");
                f.ShowDialog(this);
            }
        }

        private void userPictures_button_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                imgpath = folderBrowserDialog1.SelectedPath;
                CreateGame((int)numericUpDown_column.Value, (int)numericUpDown_row.Value, imgpath);
                user_radioButton.Checked = true;
            }
        }

        private void resetStats_Button_Click(object sender, EventArgs e)
        {
            File.Delete(@"stats");
        }
    }
}
