using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texteditor.BL;
using WindowsFormsApp2.Interface;

namespace WindowsFormsApp2
{
    class MainPresentor
    {
        private string currentFilePath;
        private readonly IMainFormcs mineForm;
        private readonly MessegeServis messegeServis;
        private readonly IFileMeneger fileMeneger;

        public MainPresentor(IMainFormcs mineForm, MessegeServis messegeServis, IFileMeneger fileMeneger)
        {
            this.mineForm = mineForm;
            this.messegeServis = messegeServis;
            this.fileMeneger = fileMeneger;

            mineForm.SetSymboleCount(0);
            mineForm.ContentsChanged += MineForm_ContentsChanged;
            mineForm.FileOpenClick += MineForm_FileOpenClick;
            mineForm.FileSaveClick += MineForm_FileSaveClick;
        }

        private void MineForm_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string contents = mineForm.Content;
                fileMeneger.SaveContent(contents, currentFilePath);
                messegeServis.ShowMesege("Файл успешно сохранен!");
            }
            catch (Exception ex)
            {
                messegeServis.ShowError(ex.Message);
                throw;
            }
        }

        private void MineForm_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = mineForm.FilePath;
                bool isExist = fileMeneger.IsExist(filePath);
                if (!isExist)
                {
                    messegeServis.ShowExclamation("Выбранный файл не существует!");
                    return;
                }

                currentFilePath = filePath;

                string content = fileMeneger.GetContents(filePath);
                int count = fileMeneger.GetSymbleCount(content);

                mineForm.Content = content;
                mineForm.SetSymboleCount(count);
            }
            catch (Exception ex)
            {
                messegeServis.ShowError(ex.Message);
            }
           
        }

        private void MineForm_ContentsChanged(object sender, EventArgs e)
        {
            string content = mineForm.Content;
            int conte = fileMeneger.GetSymbleCount(content);
            mineForm.SetSymboleCount(conte);
        }
    }
}
