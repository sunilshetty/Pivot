using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessEntities
{
    public class SCRequest : BaseCollection
    {
        public string Number { get; set; }

        public string Resolved_Month { get; set; }

        public int TTRwithExcludesInMinutes { get; set; }

        public int RawTTRInMInutes { get; set; }

        public string Open_Month { get; set; }

        public string Opened_By { get; set; }

        public string Impact { get; set; }

        public string Escalation { get; set; }

        public DateTime Due_Date { get; set; }

        public string Priority { get; set; }

        public string Request_State { get; set; }

        public string Requested_For { get; set; }

        public string Short_Description { get; set; }

        public string Stage { get; set; }

        public string State { get; set; }

        public string BPIT { get; set; }

        public string Assignment_Group { get; set; }

    }
}
