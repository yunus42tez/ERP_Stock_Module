using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Stock_Module
{
    internal class Islemler
    {
        public static void Kategori()
        {
            bool islemDurum = true;
            while (islemDurum)
            {
                Console.WriteLine("Kategori İşlemi Seçiniz");
                Console.WriteLine("Kategori Ekle    (1)");
                Console.WriteLine("Kategori Listele (2)");
                Console.WriteLine("Kategori Sil     (3)");
                Console.WriteLine("İşlem Seçiniz: ");

                char islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        KategoriIslem.Ekle();
                        break;

                    case '2':
                        KategoriIslem.Listele();
                        break;

                    case '3':
                        KategoriIslem.Sil();
                        break;

                    default:
                        islemDurum = false;
                        Console.WriteLine("Tanımsız İşlem");
                        Console.ReadLine();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void Urun()
        {
            bool islemDurum = true;
            while (islemDurum)
            {
                Console.WriteLine("Ürün İşlemi Seçiniz");
                Console.WriteLine("Ürün Ekle    (1)");
                Console.WriteLine("Ürün Listele (2)");
                Console.WriteLine("Ürün Sil     (3)");
                Console.WriteLine("İşleminiz: ");
                char islem = Convert.ToChar(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        UrunIslem.Ekle();
                        break;

                    case '2':
                        UrunIslem.Listele();
                        break;

                    case '3':
                        UrunIslem.Sil();
                        break;

                    case '4':
                        islemDurum = false;
                        break;

                    default:
                        Console.WriteLine("Tanımsız İşlem");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}