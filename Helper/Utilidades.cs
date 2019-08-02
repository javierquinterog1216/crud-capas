using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace Helper
{
    public static class Utilidades
    {
        public static List<T> ToList<T>(this DataTable obj)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(obj));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
