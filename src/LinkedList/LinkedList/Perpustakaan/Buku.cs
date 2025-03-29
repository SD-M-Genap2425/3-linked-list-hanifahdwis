using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string Judul { get; }
        public string Penulis { get; }
        public int Tahun { get; }

        public Buku(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;
        }
    }

    public class BukuNode
    {
        public Buku Data { get; }
        public BukuNode? Next { get; set; }

        public BukuNode(Buku buku)
        {
            Data = buku;
            Next = null;
        }
    }

    public class KoleksiPerpustakaan
    {
        private BukuNode? head;

        public void TambahBuku(Buku buku)
        {
            BukuNode nodeBaru = new BukuNode(buku);
            nodeBaru.Next = head;
            head = nodeBaru;
        }

        public bool HapusBuku(string judul)
        {
            if (head == null) return false;

            if (head.Data.Judul == judul)
            {
                head = head.Next;
                return true;
            }

            BukuNode? current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Judul == judul)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public Buku[] CariBuku(string kataKunci)
        {
            List<Buku> hasil = new List<Buku>();
            BukuNode? current = head;

            while (current != null)
            {
                if (current.Data.Judul.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasil.Add(current.Data);
                }
                current = current.Next;
            }

            return hasil.ToArray();
        }

        public string TampilkanKoleksi()
        {
            BukuNode? current = head;
            List<string> daftarBuku = new List<string>();

            while (current != null)
            {
                daftarBuku.Add($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
                current = current.Next;
            }

            return string.Join("\n", daftarBuku);
        }
    }
}