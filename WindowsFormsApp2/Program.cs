using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texteditor.BL;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MineForm mineForm = new MineForm();
            MessegeServis messegeServis = new MessegeServis();
            FileMeneger fileMeneger = new FileMeneger();

            MainPresentor mainPresentor = new MainPresentor(mineForm, messegeServis, fileMeneger);
            Application.Run(mineForm);
        }
    }
}
