using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class FieldDAO
    {
        private static FieldDAO instance;
        private static readonly object instanceLock = new object();
        private FieldDAO() { }
        public static FieldDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    {
                        if (instance == null)
                        {
                            instance = new FieldDAO();
                        }
                    }
                    return instance;
                }
            }
        }
    }
}
