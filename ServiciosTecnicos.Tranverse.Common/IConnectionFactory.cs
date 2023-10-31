using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Tranverse.Common
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnection { get; }
    }
}
