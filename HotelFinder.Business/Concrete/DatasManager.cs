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
    public class DatasManager : IDatasService
    {
        private DatasRepository _datasRepository;

        public DatasManager(DatasRepository datasRepository)
        {
            _datasRepository = new DatasRepository();
        }

        public PLCQualityCriterionDatas CreateMac(PLCQualityCriterionDatas Datas)
        {
            return _datasRepository.CreateMac(Datas);
        }

        public void DeleteMac(int id)
        {
            _datasRepository.DeleteMac(id);
        }

        public List<PLCQualityCriterionDatas> GetAllMac()
        {
           return _datasRepository.GetAllMac();
        }

        public PLCQualityCriterionDatas GetMachineById(int id)
        {
            return _datasRepository.GetMachineById(id);
        }

        public PLCQualityCriterionDatas UpdateMac(PLCQualityCriterionDatas Datas)
        {
            return _datasRepository.UpdateMac(Datas);
        }
    }
}
