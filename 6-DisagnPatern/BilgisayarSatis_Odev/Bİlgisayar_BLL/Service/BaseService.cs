using Bilgisayar_Dal.DataBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bİlgisayar_BLL.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseData
    {
        List<T> data = new List<T>(); 
        public List<T> GetAll(T models)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            return data.ToList();
        }
    }
}
