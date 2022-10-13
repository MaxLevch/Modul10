using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10_3
{
    public class FileManager : IMailer, IReader, IWriter
    {

        public void Read()
        {
            Console.WriteLine("Чтение файла");
        }

        public void Write()
        {
            Console.WriteLine("Запись файла");
        }


        void IMailer.SendMail()
        {
            Console.WriteLine("Отправка почты");
        }
    }
}
