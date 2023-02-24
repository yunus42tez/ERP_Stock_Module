using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Stock_Module
{
    internal class UrunIslem
    {
        public static DataContext db = new DataContext();

        public static void Ekle()
        {
            Console.WriteLine("Ürün Ekle");
            Console.Write("Ürün Adı: ");
            string urunAdi = Console.ReadLine();

            Console.Write("Ürün Fiyatı: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ürün Açıklaması: ");
            string aciklama = Console.ReadLine();

            Console.Write("Ürün Adedi: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kategori Id: ");
            int kategoriId = Convert.ToInt32(Console.ReadLine());
            UrunProp urunProp = new UrunProp();
            urunProp.UrunAdi = urunAdi;
            urunProp.Fiyat = fiyat;
            urunProp.Aciklama = aciklama;
            urunProp.Adet = adet;
            urunProp.KategoriId = kategoriId;
            db.UrunProps.Add(urunProp);
            db.SaveChangesAsync();

            Console.WriteLine("Ürün Ekleme Başarılı");
        }

        public static void Listele()
        {
            var urunProp = db.UrunProps.ToList();
            Console.WriteLine("Ürün Listesi");
            Console.WriteLine("------------");
            foreach (var item in urunProp)
            {
                Console.WriteLine(item.Id + "\t" + "ÜRÜN ADI: " + item.UrunAdi + "\t" + "FİYAT: " + item.Fiyat + "\t" + "ÜRÜN AÇIKLAMASI: " + item.Aciklama + "\t" + "ADET: " + item.Adet + "\t" + "KATEGORİ ID: " + item.KategoriId);
            }
        }

        public static void Sil()
        {
            Console.WriteLine("Ürün Sil");
            Console.Write("Ürün Id");
            int id = Convert.ToInt32(Console.ReadLine());
            var urunProp = db.UrunProps.Find(id);
            db.UrunProps.Remove(urunProp);
            Console.WriteLine("Ürün Silme Başarılı");
        }
    }
}