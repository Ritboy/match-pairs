using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RomaLibrary;

namespace MatchPairs
{
    class CodeFile
    {
        public MyButton[] buttons;
        public MyButton theOpenButton;
        public int openButtons;
        public int completeButtons;
        public int stats;

        public CodeFile(int columns, int rows, string imagesPath)
        {
            buttons = new MyButton[columns * rows];
            theOpenButton = null;
            openButtons = 0;
            completeButtons = 0;
            stats = 0;
            FillMassive(imagesPath);
        }

        private void FillMassive(string imagesPath)
        {
            string[] str = GeneratePics(imagesPath);
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new MyButton(str[i]);
            }
        }
        private string[] GeneratePics(string imagesPath)
        {
            string[] picsNamesMassive = Directory.GetFiles(imagesPath);
            MassivePro<string> mixer = new MassivePro<string>();
            picsNamesMassive = mixer.Mix(picsNamesMassive);
            string[] completePicsNamesMassive = new string[buttons.Length];
            for (int i = 0, j = 0; i < completePicsNamesMassive.Length; i++, j++)
            {
                try
                {
                    completePicsNamesMassive[i] = picsNamesMassive[j];
                    completePicsNamesMassive[++i] = picsNamesMassive[j];
                }
                catch (IndexOutOfRangeException)
                {
                    i--;
                    j = 0;
                }
            }
            return mixer.Mix(completePicsNamesMassive);
        }
        public void CloseAllButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Enabled)
                {
                    buttons[i].Hide_Picture();
                }
            }
        }
    }
}
