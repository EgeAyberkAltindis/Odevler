using MODEL.Abstract;
using MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Concretes
{
    public class BaseEntiy : IEntity<string>
    {
        public BaseEntiy()
        {
            CreatedDate = DateTime.Now;
            RequestedComputerName=System.Environment.MachineName;
            CreatedIpAdress = "192.192.192.2";
            Status=Enums.DataStatus.Active;
            MasterId=Guid.NewGuid().ToString();  
        }
        public int Id { get ; set ; }
        public string MasterId { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public string RequestedComputerName { get ; set ; }
        public string CreatedIpAdress { get ; set ; }
        public DateTime? UpdateTime { get ; set ; }
        public string? UpdatedRequestedComptuerName { get ; set ; }
        public string? RequestedIpAdress { get ; set ; }
        public DataStatus Status { get ; set ; }
    }
}
