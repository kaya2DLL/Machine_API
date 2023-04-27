using HotelFinder.Entities;
using HotelFinder_DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder_DataAccess.Concrete
{
    public class MacRepository : IMacRepository
    {
        public Connection CreateMac(Connection machine)
        {
            using ( var macDbContext =new MacDbContext())
            {
                macDbContext.Connections.Add(machine);
                macDbContext.SaveChanges();
                return machine;
            }
        }

        public void DeleteMac(int id)
        {
            using (var macDbContext = new MacDbContext())
            {
                var deletedHotel=GetMacById(id);
                macDbContext.Connections.Remove(deletedHotel);
                macDbContext.SaveChanges();
            }
        }

        public List<Connection> GetAllMacs()
        {
            using (var macDbContext = new MacDbContext())
            {
                
                return macDbContext.Connections.ToList();
            }
        }

        public Connection GetMacById(int id)
        {
            using (var macDbContext = new  MacDbContext())
            {
                return macDbContext.Connections.Find(id);
            }
        }

        public Connection UpdateMac(Connection machine)
        {
            using (var macDbContext = new MacDbContext())
            {
                macDbContext.Connections.Update(machine);
                macDbContext.SaveChanges();
                return machine;
            }
        }
    }
}
