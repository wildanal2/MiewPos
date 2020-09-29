using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiewPos.Addons
{
   public class ItemBarang
    {
        public String uid,nama,merk;
        public int stok,hargakulak,hargaecer,hargabakul;

        public ItemBarang() { }

        public ItemBarang(string uid, string nama, string merk, int stok, int hargakulak, int hargaecer, int hargabakul)
        {
            this.uid = uid;
            this.nama = nama;
            this.merk = merk;
            this.stok = stok;
            this.hargakulak = hargakulak;
            this.hargaecer = hargaecer;
            this.hargabakul = hargabakul;
        }
    }
}
