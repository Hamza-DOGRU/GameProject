using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaingManager : IManager
    {
        public void Add()
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Kaldırıldı");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
