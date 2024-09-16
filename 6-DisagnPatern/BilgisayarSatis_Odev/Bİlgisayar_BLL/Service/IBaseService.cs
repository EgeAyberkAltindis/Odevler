using Bilgisayar_Dal.DataBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bİlgisayar_BLL.Service
{
    public interface IBaseService<T> where T : BaseData
    {
        List<T> GetAll(T models);
    }
}
