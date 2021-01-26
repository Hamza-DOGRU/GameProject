using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class RegistorManager
    {
       public void Add(IManager manager)
        {
            manager.Add();
            
        }
        public void Delete(IManager manager)
        {
            manager.Delete();
        }
        public void Update(IManager manager)
        {
            manager.Update();
        }


    }
}
