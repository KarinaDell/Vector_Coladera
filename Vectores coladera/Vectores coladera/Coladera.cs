using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_coladera
{
    class Coladera
    {
        private int[] vector;

        public int[] Vector { get => vector; }

        public Coladera()
        {
            vector = new int[1000];
        }

        public void llenar()
        {
            for(int i = 0; i <1000; i++)
            {
                vector[i] = i + 1;
            }
        }

        public void eliminar()
        {
            for(int i = 1; i < 1000 - 1; i++)
            {
                int m = i + 1;
                for(int j = m+m; j < 1000; j += m)
                {

                vector[j-1] = 0;

                }
            }
        }
    }
}
