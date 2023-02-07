using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class GoodAndServiceDAO
    {
        private static GoodAndServiceDAO instance;
        private static readonly object instanceLock = new object();
        private GoodAndServiceDAO() { }
        public static GoodAndServiceDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    {
                        if (instance == null)
                        {
                            instance = new GoodAndServiceDAO();
                        }
                    }
                    return instance;
                }
            }
        }
    }
}
