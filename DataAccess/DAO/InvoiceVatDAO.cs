using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class InvoiceVatDAO
    {
        private static InvoiceVatDAO instance;
        private static readonly object instanceLock = new object();
        private InvoiceVatDAO() { }
        public static InvoiceVatDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    {
                        if (instance == null)
                        {
                            instance = new InvoiceVatDAO();
                        }
                    }
                    return instance;
                }
            }
        }
    }
}
