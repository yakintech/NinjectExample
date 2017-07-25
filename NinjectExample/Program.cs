using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
        

            //Ninject çekirdeği oluşturuyoruz.
            IKernel kernel = new StandardKernel();
            kernel.Bind<IOyuncuArayuz>().To<Ninja>();
            kernel.Bind<ISavas>().To<GucluSavasci>();
            var oyun = kernel.Get<Oyun>();


            oyun.Init();
          
    

        }
    }
}
