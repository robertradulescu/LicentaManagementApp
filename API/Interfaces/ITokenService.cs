using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    //any class that implements this interface, will implement the interfaces's properties, methods and events
    public interface ITokenService
    {

        string CreateToken(AppUser user);

    }
}