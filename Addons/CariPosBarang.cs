using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiewPos.Addons
{
    public class CariPosBarang
    {
        public bool isFound = false;
        public int posisi;

        public CariPosBarang() {}
        public CariPosBarang(bool isFound, int posisi)
        {
            this.isFound = isFound;
            this.posisi = posisi;
        }
    }
}
