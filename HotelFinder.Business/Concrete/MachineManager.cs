using HotelFinder_DataAccess.Concrete;
using Mac.Business.Abstract;
using Mac.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mac.Business.Concrete
{
    public class MachineManager : IMachineService
    {
        private MachineRepository _machineRepository;

        public MachineManager(MacRepository macRepository)
        {
            _machineRepository = new MachineRepository();
        }

        public Machines CreateMac(Machines Machines)
        {
            return _machineRepository.CreateMac(Machines);
        }

        public void DeleteMac(int id)
        {
            _machineRepository.DeleteMac(id);
        }

        public Machines GetMachineById(int id)
        {
            return _machineRepository.GetMachineById(id);
        }

        public List<Machines> GetAllMac()
        {
            return _machineRepository.GetAllMac();
        }

        public Machines UpdateMac(Machines Machines)
        {
            return _machineRepository.UpdateMac(Machines);
        }
    }
}
