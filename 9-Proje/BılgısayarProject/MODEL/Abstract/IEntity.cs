using MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Abstract
{
    public interface IEntity<T>
    {
        public int Id { get; set; }
        public T MasterId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string RequestedComputerName { get; set; }
        public string CreatedIpAdress { get; set; }

        public DateTime? UpdateTime { get; set; }
        public string?  UpdatedRequestedComptuerName { get; set; }

        public string? RequestedIpAdress { get; set; }

        public DataStatus Status { get; set; }


    }
}
