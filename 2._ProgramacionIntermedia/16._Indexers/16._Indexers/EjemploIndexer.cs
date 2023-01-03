using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Indexers
{
    //definición de un indexer
    internal class EjemploIndexer
    {
        private int[] lisItemsId = new int[100];

        public int this[int i]
        {
            get { return lisItemsId[i]; }   
            set { lisItemsId[i] = value;}
        }
    }
}
