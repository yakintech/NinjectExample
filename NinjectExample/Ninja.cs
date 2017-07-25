using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    class Ninja : IOyuncuArayuz
    {
        ISavas _savas;

        public Ninja(ISavas savas)
        {
            _savas = savas;
        }

        public void Basla()
        {
        
        }

        public void Devam()
        {
          
        }

        public void Kos()
        {
        
        }

        public void MerhabaDe()
        {
           
        }
    }
}
