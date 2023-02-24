using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Stock_Module
{
    internal class KategoriProp
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public List<UrunProp> UrunProps { get; set; }
    }
}