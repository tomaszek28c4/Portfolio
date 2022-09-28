using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyzm1


{

    public class Restaurant
    {

    }

    public class User
    {
        public string Name { get; set; }

    }

    public class PaginateResults<T>
    {
        public List<T> Results { get; set; }

       public int ResultsFrom { get; set; }
        
        public int ResultsTo { get; set; }

        public int TotatalPages { get; set; }

        public int TotalResults { get; set; }
    }
}
