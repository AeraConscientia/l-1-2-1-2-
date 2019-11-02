using System;
using System.Windows.Forms;

namespace l_1._1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /*
         * Содержательная область: классы
         * Интерфейсная часть: 
         * 
         * за каждой формой 3 файла: изображение, код автоматический (designer.cs), функционально (кнопки. Button (событие(клик), написать обработчик 
         * событий)
         */

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
