using System;

namespace ERP_Stock_Module
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool sistemdurum = true;
            while (sistemdurum)
            {
                Console.WriteLine("Stok Yönetimi ERP Modülü");
                Console.WriteLine("------------------------");
                Console.WriteLine("Kategori İşlemleri (1)");
                Console.WriteLine("Ürün İşlemleri     (2)");
                Console.WriteLine("Sistemi Kapat      (x)");
                Console.WriteLine("İşlem Seçiniz: ");
                char islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        Islemler.Kategori();

                        break;

                    case '2':
                        Islemler.Urun();

                        break;

                    case 'x':
                        sistemdurum = false;
                        Console.WriteLine("Sistem Kapatılıyor...");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }
        }
    }
}