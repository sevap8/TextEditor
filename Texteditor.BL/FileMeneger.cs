using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texteditor.BL
{
    public interface IFileMeneger
    {
        bool IsExist(string filePath);
        int GetSymbleCount(string contents);
        string GetContents(string filePath);
        string GetContents(string filePath, Encoding encodint);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encodint);

    }
    public class FileMeneger : IFileMeneger
    {
        private readonly Encoding encodingDef = Encoding.GetEncoding(1251);

        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        public int GetSymbleCount(string contents)
        {
            int count = contents.Length;
            return count;
        }

        public string GetContents(string filePath)
        {
            return GetContents(filePath, encodingDef);
        }

        public string GetContents(string filePath, Encoding encodint)
        {
            string content = File.ReadAllText(filePath, encodint);
            return content;
        }

        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, encodingDef);
        }

        public void SaveContent(string content, string filePath, Encoding encodint)
        {
            File.WriteAllText(content, filePath, encodint);
        }
    }
}
