using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ExcelFieldDAO
    {
        private static ExcelFieldDAO instance;
        private static readonly object instanceLock = new object();
        private ExcelFieldDAO() { }
        public static ExcelFieldDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    {
                        if (instance == null)
                        {
                            instance = new ExcelFieldDAO();
                        }
                    }
                    return instance;
                }
            }
        }
    }
}
