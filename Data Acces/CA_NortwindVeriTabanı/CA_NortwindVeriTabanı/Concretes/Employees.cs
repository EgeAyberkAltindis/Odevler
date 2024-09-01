using CA_NortwindVeriTabanı.Abstracts;
using CA_NortwindVeriTabanı.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CA_NortwindVeriTabanı.Concretes
{
    public class Employees :  IBilgiler
    {
        NorthwİndContext db = new NorthwİndContext();
        /// <summary>
        /// bir isim yazarsan bu adın sana özeliklerini gösterir
        /// </summary>
        /// <param name="ad"></param>
        public void Isım(string ad)
            
        {
            
            var employeesIsım = db.Employees.Select(x => new
            {
                x.EmployeeId,
                x.FirstName,
                x.LastName,
                x.PostalCode,
                x.Country,
                x.BirthDate,
                x.City,
            }).ToList();
            foreach (var item in employeesIsım)
            {
                Console.WriteLine(item.EmployeeId+" "+item.FirstName + " " + item.LastName + " " + item.PostalCode + " " + item.Country+" "+item.BirthDate+" "+item.City);
            }
        }
        /// <summary>
        /// isim ve soy isim yazarsan sana özellikleini gösterir
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        public void IsımSoyad(string ad, string soyad)
        {
            var employeesIsımSoyad = db.Employees.Select(x => new
            {
                x.EmployeeId,
                x.FirstName,
                x.LastName,
                x.PostalCode,
                x.Country,
                x.BirthDate,
                x.City,
            }).ToList();
            foreach (var item in employeesIsımSoyad)
            {
                Console.WriteLine(item.FirstName + " " + item.EmployeeId + " " + item.LastName + " " + item.PostalCode + " " + item.Country + " " + item.BirthDate + " " + item.City);
            }
        }
    }
}
