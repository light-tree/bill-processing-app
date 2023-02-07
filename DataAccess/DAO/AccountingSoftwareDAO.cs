using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AccountingSoftwareDAO
    {
        private static AccountingSoftwareDAO instance;
        private static readonly object instanceLock = new object();
        private AccountingSoftwareDAO() { }
        public static AccountingSoftwareDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    {
                        if (instance == null)
                        {
                            instance = new AccountingSoftwareDAO();
                        }
                    }
                    return instance;
                }
            }
        }
    }
}
