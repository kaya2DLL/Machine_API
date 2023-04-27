using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder_DataAccess.Abstract
{
    internal interface IMacRepository
    {
        List<Connection> GetAllMacs();

        Connection GetMacById(int id);

        Connection CreateMac(Connection machine);

        Connection   UpdateMac(Connection machine);

        void DeleteMac(int id);

    }
}
