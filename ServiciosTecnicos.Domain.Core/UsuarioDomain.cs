using ServiciosTecnicos.Domain.Entity;
using ServiciosTecnicos.Domain.Interface;
using ServiciosTecnicos.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Domain.Core
{
    public class UsuarioDomain : IUsuarioDomain
    {
        private readonly IUserRepository _userRepository;
        public UsuarioDomain(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Users Authenticate(string username, string password)
        {
            return _userRepository.Authenticate(username, password);
        }
    }
}
