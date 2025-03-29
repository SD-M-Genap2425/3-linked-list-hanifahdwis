namespace LinkedList;
using LinkedList.Perpustakaan;
using LinkedList.ManajemenKaryawan;
using LinkedList.Inventori;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan
        KoleksiPerpustakaan perpustakaan = new KoleksiPerpustakaan();
        perpustakaan.TambahBuku(new Buku("The Hobbit", "J.R.R. Tolkien", 1937));
        perpustakaan.TambahBuku(new Buku("1984", "George Orwell", 1949));
        perpustakaan.TambahBuku(new Buku("The Catcher in the Rye", "J.D. Salinger", 1951));

        Console.WriteLine("Koleksi Buku Perpustakaan");
        perpustakaan.TampilkanKoleksi();
        Console.WriteLine();

        Console.Write("Masukkan kata kunci pencarian: ");
        string kataKunci = Console.ReadLine();
        Console.WriteLine("\nHasil Pencarian:");
        perpustakaan.CariBuku(kataKunci);
        Console.WriteLine();

        Console.Write("Masukkan judul buku yang ingin dihapus: ");
        string judulHapus = Console.ReadLine();
        bool sukses = perpustakaan.HapusBuku(judulHapus);
        Console.WriteLine(sukses ? "Buku berhasil dihapus." : "Buku tidak ditemukan.");
        Console.WriteLine();

        Console.WriteLine("Koleksi Buku Setelah Penghapusan");
        perpustakaan.TampilkanKoleksi();


        // Soal ManajemenKaryawan
        DaftarKaryawan daftar = new DaftarKaryawan();

        daftar.TambahKaryawan(new Karyawan("001", "John Doe", "Manager"));
        daftar.TambahKaryawan(new Karyawan("002", "Jane Doe", "HR"));
        daftar.TambahKaryawan(new Karyawan("003", "Bob Smith", "IT"));

        Console.WriteLine("Daftar Karyawan:");
        Console.WriteLine(daftar.TampilkanDaftar());

        Console.WriteLine("\nMencari karyawan dengan kata kunci 'Doe':");
        var hasilCari = daftar.CariKaryawan("Doe");
        foreach (var karyawan in hasilCari)
        {
            Console.WriteLine($"{karyawan.NomorKaryawan}; {karyawan.Nama}; {karyawan.Posisi}");
        }

        Console.WriteLine("\nMenghapus karyawan 002...");
        daftar.HapusKaryawan("002");
        Console.WriteLine("Daftar setelah penghapusan:");
        Console.WriteLine(daftar.TampilkanDaftar());


        // Soal Inventori
        ManajemenInventori inventori = new ManajemenInventori();

        inventori.TambahItem(new Item("Apple", 50));
        inventori.TambahItem(new Item("Orange", 30));
        inventori.TambahItem(new Item("Banana", 20));

        Console.WriteLine("Inventori Saat Ini:");
        Console.WriteLine(inventori.TampilkanInventori());
        Console.WriteLine("\nMenghapus 'Orange'...");
        inventori.HapusItem("Orange");
        Console.WriteLine("\nInventori Setelah Penghapusan:");
        Console.WriteLine(inventori.TampilkanInventori());
    }
}
