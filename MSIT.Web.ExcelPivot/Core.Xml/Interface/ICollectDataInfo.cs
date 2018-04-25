using Core.BusinessEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Json.Interface
{
    public abstract class ICollectDataInfo<T>
    {
        public virtual List<T> CollectDataInfo(SPList SPList)
        {
            string fileData = File.ReadAllText(SPList.JsonFIleName);
            List<T> _spList = JsonConvert.DeserializeObject<List<T>>(fileData);
            return _spList;
        }
    }
}
