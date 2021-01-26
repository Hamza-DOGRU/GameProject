using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IManager
    {
        public void Add()
        {
            Console.WriteLine("Oyuncu Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi");
        }
    }
}
