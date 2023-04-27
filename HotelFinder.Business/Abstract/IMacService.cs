using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Abstract
{
    public interface IMacService
    {
        List<Connection> GetAllMacs();

        Connection GetMacById(int id);

        Connection  CreateMac(Connection machine);

        Connection UpdateMac(Connection machine);

        void DeleteMac(int id);
    }
}
