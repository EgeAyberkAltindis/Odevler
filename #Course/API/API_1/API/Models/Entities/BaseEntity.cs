using API.Models.Enums;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace API.Models.Entities
{
    public  abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate= DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }   
        public DateTime? DeletedDate { get; set;}
        public DateTime? ModifiedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
