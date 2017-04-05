using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MatchPairs
{
    /*Первоначально задумывалось, что кнопка будет хранить в себе целое изображение и при необходимости открывать, но в процессе теста оказалось, что в таком
     * случае происходит ошибка OutOfMemoryException, т.е. невозможно в себе хранить все изображения в массиве кнопок, ибо не хватает памяти.
     * Поэтому был реализован другой конструктор, который принимает путь нужного изображения, а когда нужно будет откурыть изображение кнопка будет каждый
     * раз подгружать изображение, от этого при открытии кнопки могут быть подтормаживания.
     * Тем не менее я решил оставить поле, предназначенное для изображения и конструктор, принмающий изображение, хотя в программе это не используется. */

    class MyButton: Button
    {
        public Image img;
        public string imgName;
        public bool IsOpen;

        public MyButton() : base()
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.Dock = DockStyle.Fill;
            this.UseVisualStyleBackColor = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public MyButton(Image img) : base()      //не используется
        {
            this.img = img;
            this.SetStyle(ControlStyles.Selectable, false);
            this.Dock = DockStyle.Fill;
            this.UseVisualStyleBackColor = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public MyButton(string imgPath) : base()
        {
            
            this.imgName = imgPath;

            this.SetStyle(ControlStyles.Selectable, false);
            this.Dock = DockStyle.Fill;
            this.UseVisualStyleBackColor = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void Show_Picture()
        {
            try
            {
                this.BackgroundImage = Image.FromFile(imgName);
                this.IsOpen = true;
            }
            catch 
            {
                MessageBox.Show("Не удаётся открыть выбранные изображения.\nВ выбранной папке должны находится только изображения.", "Ошибка");
            }   
        }
        public void Hide_Picture()
        {
            this.BackgroundImage = null;
            this.IsOpen = false;
        }
        public void SetImage(Image im)
        {
            this.img = im;
        }
        public bool IsOpened
        {
            get { return IsOpen; }
        }
    }
}
