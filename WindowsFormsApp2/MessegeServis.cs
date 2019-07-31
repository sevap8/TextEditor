using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Interface;

namespace WindowsFormsApp2
{
    class MessegeServis : IMessegeServis
    {
        public void ShowMesege(string messege)
        {
            MessageBox.Show(messege, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупиждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string errore)
        {
            MessageBox.Show(errore, "Ошибку", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
