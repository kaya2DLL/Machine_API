using Mac.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder_DataAccess.Abstract
{
    internal interface IDatasRepository
    {
        List<PLCQualityCriterionDatas> GetAllMac();

        PLCQualityCriterionDatas GetMachineById(int id);

        PLCQualityCriterionDatas CreateMac(PLCQualityCriterionDatas Datas);

        PLCQualityCriterionDatas UpdateMac(PLCQualityCriterionDatas Datas);

        void DeleteMac(int id);
    }
}
