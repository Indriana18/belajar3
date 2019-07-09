using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiUAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            List<produk> list = new List<produk>();
            Console.Clear();
            do
            {
               
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine("1. Tambah Produk");
                Console.WriteLine("2. Hapus Produk");
                Console.WriteLine("3. Tampilkan Produk");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("\nNomor Menu [1...4] : ");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Create(list);
                        break;
                    case 2:
                        Delete(list);
                        break;
                    case 3:
                        Tampil(list);
                        break;
                    default:
                        Console.WriteLine("Pilihan yang anda masukkan salah");
                        break;
                }
            } while (n != 4);
        }

        static void Create(List<produk> list)
        {
            Console.WriteLine("Kode Produk    : ");
            string kode = Console.ReadLine().ToString();
            Console.WriteLine("Nama Produk   : ");
            string nama = Console.ReadLine().ToString();
            Console.WriteLine("Harga Beli   : ");
            string beli = Console.ReadLine().ToString();
            Console.WriteLine("Harga Jual   : ");
            string jual = Console.ReadLine().ToString();

            list.Add(new produk { Kode = kode, Nama = nama, Beli = beli, Jual = jual });
            Console.WriteLine();
        }

       

        static void Delete(List<produk> list)
        {
            Console.WriteLine("Hapus data produk ");
            Console.Write("Masukkan kode : ");
            String kode = Console.ReadLine().ToString();

            list.Remove(list.SingleOrDefault(f => f.Kode == kode));
            Console.WriteLine("Kode Produk Tidak ditemukan \n\n");
        }


        static void Tampil(List<produk> list)
        {
            Console.WriteLine("Data Produk");
            foreach (produk prd in list)
            {
                Console.Write("{0}, {1}, {2}, {3}", prd.Kode, prd.Nama, prd.Beli, prd.Jual);
                Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
}
