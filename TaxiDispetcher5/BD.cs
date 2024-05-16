using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDispetcher5;
using Курсач_Джураева_1125;

namespace BD
{
    public class DB
    {
        static TaxiContext peremennaya;
        public static TaxiContext GetInstance()
        {
            if (peremennaya == null)
                peremennaya = new TaxiContext();
            return peremennaya;
        }

        static TaxiContext instance;
        public static TaxiContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaxiContext();
                return instance;
            }

        }


    }
}
