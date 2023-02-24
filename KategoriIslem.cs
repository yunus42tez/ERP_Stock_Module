using System;
using System.Linq;

namespace ERP_Stock_Module

{
    internal class KategoriIslem
    {
        public static DataContext db = new DataContext();

        public static void Ekle()
        {
            Console.WriteLine("Kategori Ekle");
            Console.Write("Kategori Adı: ");
            string KategoriAdi = Console.ReadLine();
            KategoriProp kategori = new KategoriProp();
            kategori.KategoriAdi = KategoriAdi;
            db.KategoriProps.Add(kategori);
            db.SaveChanges();
            Console.WriteLine("1 Yeni Kategori Eklendi");
        }

        public static void Listele()
        {
            var kategori = db.KategoriProps.ToList();
            Console.WriteLine("Kategori Listesi");
            Console.WriteLine("----------------");
            Console.WriteLine("Id\t\tKategori Adı");
            foreach (var item in kategori)
            {
                Console.WriteLine(item.Id + "\t" + item.KategoriAdi);
            }
        }

        public static void Sil()
        {
            Console.WriteLine("Kategori Sil");
            Console.Write("Kategori Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var kategori = db.KategoriProps.Find(id);
            db.KategoriProps.Remove(kategori);
            db.SaveChanges();
            Console.WriteLine("Kategori Silme Başarılı");
        }
    }
}