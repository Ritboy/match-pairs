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
    public partial class StatsForm : Form
    {
        public StatsForm(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("stats");
            label1.Text = "Статистика сброшена";
        }
    }
}
