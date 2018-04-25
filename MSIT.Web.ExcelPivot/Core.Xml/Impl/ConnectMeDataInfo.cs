using Core.BusinessEntities;
using Core.Json.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Xml.Impl
{
    class ConnectMeDataInfo : ICollectDataInfo<SPList>
    {
        public virtual List<SPList> CollectDataInfo(SPList SPList)
        {
            return null;
        }
    }
}
