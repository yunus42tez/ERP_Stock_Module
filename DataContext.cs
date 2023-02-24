using System.Data.Entity;

namespace ERP_Stock_Module
{
    internal class DataContext : DbContext
    {
        public DataContext() : base("connection")
        {
        }

        public DbSet<KategoriProp> KategoriProps { get; set; }
        public DbSet<UrunProp> UrunProps { get; set; }
    }
}