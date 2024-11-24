using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APInetframework_1.ViewModels.RequestModels
{
    public class CreateCategoryRequestModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}