using CA_Cinema.Abstracts;
using CA_Cinema.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Cinema.Models
{
    public class Cinema:BaseClass,ICinemaCRUD
    {
        public string  Description { get; set; }
        public  int  Duration { get; set; }
        public string Categories { get; set; }

        public string AddCinema(Cinema cinema)
        {
            CinemaData.cinemaList.Add(cinema);

            return "ürün eklendi";
        }

        public List<Cinema> GetCinemas()
        {
            return CinemaData.cinemaList;
        }

        public string RemoveCinema(Cinema cinema)
        {
            CinemaData.cinemaList.Remove(cinema);

            return "ürün silindi";
        }
    }
}
