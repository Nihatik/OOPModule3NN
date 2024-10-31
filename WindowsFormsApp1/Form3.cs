using AnimatedWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimatedWindow;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


    private void btnAW_BLEND_Click(object sender, EventArgs e)
    {
        // Скрываем окно
        this.Hide();

        // Запускаем анимацию с длительностью 3000 миллисекунд
        WinAPIClass.AnimateWindow(this, 3000,
            WinAPIClass.AnimateWindowFlags.AW_ACTIVATE | WinAPIClass.AnimateWindowFlags.AW_BLEND);

        // Обновляем кнопки после анимации
        btnAW_BLEND.Invalidate();
        btnHOR_AW_SLIDE.Invalidate();
        btnCenter_AW_SLIDE.Invalidate();
    }

    private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
    {
        // Скрываем окно
        this.Hide();

        // Запускаем горизонтальную анимацию с длительностью 3000 миллисекунд
        WinAPIClass.AnimateWindow(this, 3000,
            WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE | WinAPIClass.AnimateWindowFlags.AW_SLIDE);

        // Обновляем кнопки после анимации
        btnAW_BLEND.Invalidate();
        btnHOR_AW_SLIDE.Invalidate();
        btnCenter_AW_SLIDE.Invalidate();
    }

    private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
    {
        // Скрываем окно
        this.Hide();

        // Запускаем анимацию из центра с длительностью 3000 миллисекунд
        WinAPIClass.AnimateWindow(this, 3000,
            WinAPIClass.AnimateWindowFlags.AW_CENTER | WinAPIClass.AnimateWindowFlags.AW_SLIDE);

        // Обновляем кнопки после анимации
        btnAW_BLEND.Invalidate();
        btnHOR_AW_SLIDE.Invalidate();
        btnCenter_AW_SLIDE.Invalidate();
    }

}
}
