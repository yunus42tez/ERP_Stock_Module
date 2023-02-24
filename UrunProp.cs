namespace ERP_Stock_Module
{
    internal class UrunProp
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public int Adet { get; set; }

        public int KategoriId { get; set; }
        public KategoriProp KategoriProp { get; set; }
    }
}