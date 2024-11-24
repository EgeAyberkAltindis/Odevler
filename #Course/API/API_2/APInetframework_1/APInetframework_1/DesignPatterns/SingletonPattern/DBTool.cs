using APInetframework_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI.WebControls;

namespace APInetframework_1.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        public DBTool()
        {
                
        }
        static NorthwindEntities _dbInstance;
        public static NorthwindEntities DBInstance
        {
            get
            {
                if(_dbInstance == null ) _dbInstance = new NorthwindEntities();
                return _dbInstance;
            }
        }
    }
}