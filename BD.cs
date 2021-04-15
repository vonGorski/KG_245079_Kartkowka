using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KG_245079_Kartkowka
{
    public class Movie
    {
        public int id { set; get; }
        public string name { set; get; }
    }

    public class Theater : DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }
    }

}
