using ServiciosTecnicos.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Infrastructure.Interface
{
    public interface IUserRepository
    {
        Users Authenticate(string username, string password);
    }
}
