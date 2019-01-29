using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class MetodosParaMapeo
    {
        public static string mapeoStringSeguro(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
            {
                return reader.GetString(colIndex);
            }
            else
            {
                return string.Empty;
            }             
        }
    }
}
