using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskPatterns
{
    class Receiver
    {
        public void InfoDescription() 
        {
            Console.WriteLine("Информация о видео получена!\n");
        }

        public void InfoDownload() 
        {
            Console.WriteLine("Видео успешно скачено!\n");
        }
    }
}
