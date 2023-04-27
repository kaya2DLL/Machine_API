using HotelFinder_DataAccess.Abstract;
using Mac.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder_DataAccess.Concrete
{
    public class DatasRepository : IDatasRepository
    {
        public PLCQualityCriterionDatas CreateMac(PLCQualityCriterionDatas Datas)
        {
            using (var macDbContext = new MacDbContext())
            {
                macDbContext.PLCQualityCriterionDatas.Add(Datas);
                macDbContext.SaveChanges();
                return Datas;
            }
        }
        public void DeleteMac(int id)
        {
                using (var macDbContext = new MacDbContext())
                {
                    var deletedDatas = GetMachineById(id);
                    macDbContext.PLCQualityCriterionDatas.Remove(deletedDatas);
                 macDbContext.SaveChanges();
                }
            }

        public List<PLCQualityCriterionDatas> GetAllMac()
        {
                using (var macDbContext = new MacDbContext())
                {

                    return macDbContext.PLCQualityCriterionDatas.ToList();
                }
            }

        public PLCQualityCriterionDatas GetMachineById(int id)
        {
                using (var macDbContext = new MacDbContext())
                {
                    return macDbContext.PLCQualityCriterionDatas.Find(id);
                }
            }

        public PLCQualityCriterionDatas UpdateMac(PLCQualityCriterionDatas Datas)
        {
                using (var macDbContext = new MacDbContext())
                {
                    macDbContext.PLCQualityCriterionDatas.Update(Datas);
                    macDbContext.SaveChanges();
                    return Datas;
                }
            }
    }
}
