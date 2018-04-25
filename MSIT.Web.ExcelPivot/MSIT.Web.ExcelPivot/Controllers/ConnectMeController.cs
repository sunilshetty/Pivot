using Core.BusinessEntities;
using MSIT.Web.ExcelPivot.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSIT.Web.BenefitsCalculator.Controllers
{
    public class ConnectMeController : Controller
    {
        // GET: ConnectMe
        public ActionResult ConnectMe()
        {
            IEnumerable<ConnectMe> _connectMe = null;
            var modelObj = new ConnectMe();
            var SCRequestData = new Collection<ConnectMe>();
            PivotService _pivotService = new PivotService();
            SCRequestData = _pivotService.GetAllConnectMe(modelObj);
            _connectMe = (from item in SCRequestData
                          select new ConnectMe
                          {
                              SessionDate = item.SessionDate,

                              alias = item.alias,

                              sessionId = item.sessionId,

                              chatId = item.chatId,

                              SessionStartTime = item.SessionStartTime,

                              ChatStartTime = item.ChatStartTime,

                              ChatRequestedTime = item.ChatRequestedTime,

                              ChatEndTime = item.ChatEndTime,

                              BOTTime = item.BOTTime,

                              AgentChatWaitTime = item.AgentChatWaitTime,

                              PostCallWork = item.PostCallWork,

                              AgentAbandoned = item.AgentAbandoned,

                              CallAvoided = item.CallAvoided,

                              AgentChatDuration = item.AgentChatDuration,

                              SessionDuration = item.SessionDuration,

                              Country = item.Country,

                              Topic = item.Topic,

                              SupervisorActivity = item.SupervisorActivity,

                              AgentChatMonth = item.AgentChatMonth,

                              SessionMonth = item.SessionMonth,
                          });
            var result = new StringBuilder();
            foreach (var item in _connectMe)
            {
                result.Append(item.SessionDate + "," + item.alias + "," + item.sessionId + "," + item.chatId + "," + item.SessionStartTime + "," + item.ChatStartTime + "," + item.ChatRequestedTime + "," + item.ChatEndTime + "," + item.BOTTime + "," + item.AgentChatWaitTime + "," + item.PostCallWork + "," + item.AgentAbandoned + "," + item.CallAvoided + "," + item.AgentChatDuration + "," + item.SessionDuration + "," + item.Country + "," + item.Topic + "," + item.SupervisorActivity + "," + item.AgentChatMonth + "," + item.SessionMonth + "\n");
            }
            System.IO.File.WriteAllText(@"D:\Pivot\PivotExcel05-01-2017\PivotExcel\MSIT.Web.ExcelPivot\MSIT.Web.ExcelPivot\data.csv", Convert.ToString(result));
            string newFileName = AppDomain.CurrentDomain.BaseDirectory + "data.csv";
            return View();
        }
    }
}