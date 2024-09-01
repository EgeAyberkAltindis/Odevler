using CA_NortwindVeriTabanı.Abstracts;
using CA_NortwindVeriTabanı.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NortwindVeriTabanı.Concretes
{
    public class Urun : IIslem
    {
        NorthwİndContext db = new NorthwİndContext();
        Product product= new Product();
        

        public void Islem1(int sayı)
        {
            var urunBilgisi = db.Products.Where(x => x.UnitPrice > sayı).Select(x => new
            {
                x.ProductId,
                x.UnitPrice,
                x.Category.Description,
                x.Category
            }).ToList();

            foreach (var item in urunBilgisi)
            {
                Console.WriteLine(item.ProductId + " " + item.UnitPrice + " " + item.Category.Description);
            }

        }

        public void Islem2(int sayı, int sayı2)
        {
            var urunBilgisi = db.Products.Where(x => x.UnitPrice > sayı&&x.UnitPrice<sayı2).Select(x => new
            {
                x.ProductId,
                x.UnitPrice,
                x.Category.Description,
                x.Category
            }).ToList();

            foreach (var item in urunBilgisi)
            {
                Console.WriteLine(item.ProductId + " " + item.UnitPrice + " " + item.Category.Description);
            }
            
        }
    }
}
