using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Library
{
    public class dbManager
    {
        private static dbManager instance;
        LoggerClass logger = LoggerClass.getInstance();

        private dbManager()
        {
        }

        public static dbManager getInstance()
        {
            if (instance == null)
            {
                instance = new dbManager();
            }
            return instance;
        }

        public List<string> GetTables()
        {
            List<string> l = new List<string>();
            l.Add("table 1");
            logger.logging("select list of tables from db");
            return l;
        }

        public string Select(string tablename)
        {
            logger.logging("select info from " + tablename + " from db");
            return "select";
        }
    }
}