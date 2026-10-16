using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Library
{
    public class DocSaver
    {
        private static DocSaver instance;
        LoggerClass logger = LoggerClass.getInstance();

        private DocSaver()
        {
        }

        public static DocSaver getInstance()
        {
            if (instance == null)
            {
                instance = new DocSaver();
            }
            return instance;
        }

        public void Save(string docName)
        {
            logger.logging("saving document: " + docName);
        }
    }
}