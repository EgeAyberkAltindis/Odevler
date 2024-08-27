using CA_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Cinema.Abstracts
{
    public interface ICinemaCRUD
    {
        //listeleme
        List<Cinema> GetCinemas();

        //ekleme

        public string AddCinema(Cinema cinema);
        
        //silme işlemi
        public string RemoveCinema(Cinema cinema);


    }
}
