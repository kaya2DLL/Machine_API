
using HotelFinder.Business.Abstract;
using HotelFinder.Entities;
using HotelFinder_DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class MacManager : IMacService
    {
        private MacRepository _macRepository;

        public MacManager(MacRepository macRepository)
        {
            _macRepository = new MacRepository();
        }


        public Connection CreateMac(Connection machine)
        {
            return _macRepository.CreateMac(machine);
        }

        public void DeleteMac(int id)
        {
               _macRepository.DeleteMac(id);
            
        }

        public List<Connection> GetAllMacs()
        {
            return _macRepository.GetAllMacs();
        }

        public Connection GetMacById(int id)
        {
            return _macRepository.GetMacById(id);
        }

        public Connection UpdateMac(Connection machine)
        {
            return _macRepository.UpdateMac(machine);
           
        }
    }
}
