using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Inventori
{
    public class Item
    {
        public string Nama { get; set; }
        public int Kuantitas { get; set; }

        public Item(string nama, int kuantitas)
        {
            Nama = nama;
            Kuantitas = kuantitas;
        }
    }
    public class ManajemenInventori
    {
        private LinkedList<Item> daftarItem = new LinkedList<Item>();

        public void TambahItem(Item item)
        {
            daftarItem.AddLast(item);
        }

        public bool HapusItem(string nama)
        {
            foreach (var item in daftarItem)
            {
                if (item.Nama == nama)
                {
                    daftarItem.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public string TampilkanInventori()
        {
            string hasil = "";
            foreach (var item in daftarItem)
            {
                hasil += item.Nama + "; " + item.Kuantitas + Environment.NewLine;
            }
            return hasil.TrimEnd(); 
        }

    }
}
