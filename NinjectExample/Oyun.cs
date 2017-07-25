using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    class Oyun 
    {
        IOyuncuArayuz _oyuncu;

        public Oyun(IOyuncuArayuz oyuncu)
        {
            _oyuncu = oyuncu;
        }

        public void Init()
        {
            _oyuncu.Basla();
            _oyuncu.MerhabaDe();
            _oyuncu.Kos();
            _oyuncu.Devam();
        }
    }
}
