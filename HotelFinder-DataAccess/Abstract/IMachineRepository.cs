using Mac.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder_DataAccess.Abstract
{
    internal interface IMachineRepository
    { 
        List<Machines> GetAllMac();

        Machines GetMachineById(int id);

        Machines CreateMac(Machines Machines);

        Machines UpdateMac(Machines Machines);

        void DeleteMac(int id);
    }
}
