using CA_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Cinema.Data
{
    internal class CinemaData
    {
        public static List<Cinema> cinemaList = new List<Cinema>
        {
            new Cinema{Id=1,Name="The Shawshank Redemption",Categories="Crime",Duration=142 },
            new Cinema{Id=2,Name="Back to the Future",Categories="Adventure",Duration=114 }
        };

    }
}
