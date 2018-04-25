using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessEntities
{
    public class ConnectMe : BaseCollection
    {
        public string SessionDate { get; set; }

        public string alias { get; set; }

        public string sessionId { get; set; }
        
        public string chatId { get; set; }

        public string SessionStartTime { get; set; }

        public string ChatStartTime { get; set; }

        public string ChatRequestedTime { get; set; }

        public string ChatEndTime { get; set; }

        public string BOTTime { get; set; }

        public string AgentChatWaitTime { get; set; }

        public string PostCallWork { get; set; }

        public string AgentAbandoned { get; set; }

        public string CallAvoided { get; set; }

        public string AgentChatDuration { get; set; }

        public string SessionDuration { get; set; }

        public string Country { get; set; }

        public string Topic { get; set; }

        public string SupervisorActivity { get; set; }

        public string AgentChatMonth { get; set; }

        public string SessionMonth { get; set; }
    }
}
