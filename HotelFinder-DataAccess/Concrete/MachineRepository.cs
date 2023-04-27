using HotelFinder.Entities;
using HotelFinder_DataAccess.Abstract;
using Mac.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder_DataAccess.Concrete
{
    public class MachineRepository : IMachineRepository
    {
        public Machines CreateMac(Machines Machines)
        {
            using (var macDbContext = new MacDbContext())
            {
                macDbContext.Machines.Add(Machines);
                macDbContext.SaveChanges();
                return Machines;
            }
        }

        public void DeleteMac(int id)
        {
            using (var macDbContext = new MacDbContext())
            {
                var deletedMachines = GetMachineById(id);
                macDbContext.Machines.Remove(deletedMachines);
                macDbContext.SaveChanges();
            }
        }

        public List<Machines> GetAllMac()
        {
            using (var macDbContext = new MacDbContext())
            {

                return macDbContext.Machines.ToList();
            }
        }

        public Machines GetMachineById(int id)
        {
            using (var macDbContext = new MacDbContext())
            {
                return macDbContext.Machines.Find(id);
               
            }
        }

        public Machines UpdateMac(Machines Machines)
        {
            using (var macDbContext = new MacDbContext())
            {
                macDbContext.Machines.Update(Machines);
                macDbContext.SaveChanges();
                return Machines;
            }
        }
    }
}
