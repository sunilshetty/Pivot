using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using Core.BusinessEntities;

namespace DAO
{
    public class Repository : IRepository
    {
        #region Public Method(s)        
        public Collection<ConnectMe> GetAllConnectMe(ConnectMe request)
        {
            request.SPCalled = "[DBO].[GetConnectMe]";

            var dataCollection = new Collection<ConnectMe>();

            SqlDataReader reader = GetSPDetails(request);

            ConnectMe objFirst = new ConnectMe()
            {
                SessionDate = "SessionDate",
                alias = "Alias",
                sessionId = "Session ID",
                chatId = "ChatId",
                SessionStartTime = "SessionStartTime",
                ChatStartTime = "ChatStartTime",
                ChatRequestedTime = "ChatRequestedTime",
                ChatEndTime = "ChatEndTime",
                BOTTime = "BOTTime",
                AgentChatWaitTime = "AgentChatWaitTime",
                PostCallWork = "PostCallWork",
                AgentAbandoned = "AgentAbandoned",
                CallAvoided = "CallAvoided",
                AgentChatDuration = "AgentChatDuration",
                SessionDuration = "SessionDuration",
                Country = "Country",
                Topic = "Topic",
                SupervisorActivity = "SupervisorActivity",
                AgentChatMonth = "AgentChatMonth",
                SessionMonth = "SessionMonth"
            };
            dataCollection.Add(objFirst);
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    ConnectMe obj = new ConnectMe();
                    obj.SessionDate = reader["SessionDate"].ToString() == null ? "" : reader["SessionDate"].ToString();
                    obj.alias = reader["alias"].ToString() == null ? "" : reader["alias"].ToString();
                    obj.sessionId = "1";
                    obj.chatId = "1";
                    obj.SessionStartTime = reader["SessionStartTime"].ToString();
                    obj.ChatStartTime = reader["ChatStartTime"].ToString() == null ? "" : reader["ChatStartTime"].ToString();
                    obj.ChatRequestedTime = reader["ChatRequestedTime"].ToString() == null ? "" : reader["ChatRequestedTime"].ToString();
                    obj.ChatEndTime = reader["ChatEndTime"].ToString() == null ? "" : reader["ChatEndTime"].ToString();
                    obj.BOTTime = reader["BOTTime"].ToString() == null ? "" : reader["BOTTime"].ToString();
                    obj.AgentChatWaitTime = reader["AgentChatWaitTime"].ToString();
                    obj.PostCallWork = reader["PostCallWork"].ToString() == null ? "" : reader["PostCallWork"].ToString();
                    obj.AgentAbandoned = reader["AgentAbandoned"].ToString() == null ? "" : reader["AgentAbandoned"].ToString();
                    obj.CallAvoided = reader["CallAvoided"].ToString() == null ? "" : reader["CallAvoided"].ToString();
                    obj.AgentChatDuration = reader["AgentChatDuration"].ToString() == null ? "" : reader["AgentChatDuration"].ToString();
                    obj.SessionDuration = reader["SessionDuration"].ToString() == null ? "" : reader["SessionDuration"].ToString();
                    obj.Country = reader["Country"].ToString() == null ? "" : reader["Country"].ToString();
                    obj.Topic = reader["Topic"].ToString() == null ? "" : reader["Topic"].ToString();
                    obj.SupervisorActivity = reader["SupervisorActivity"].ToString() == null ? "" : reader["SupervisorActivity"].ToString();
                    obj.AgentChatMonth = reader["AgentChatMonth"].ToString() == null ? "" : reader["AgentChatMonth"].ToString();
                    obj.SessionMonth = reader["SessionMonth"].ToString() == null ? "" : reader["SessionMonth"].ToString();
                    dataCollection.Add(obj);
                }
                reader.NextResult();
            }
            return dataCollection;
        }

        public Collection<SCRequest> GetAllSCRequestData(SCRequest request)
        {
            request.SPCalled = "[DBO].[rpt_SCRequest_Lite]";

            var dataCollection = new Collection<SCRequest>();

            SqlDataReader reader = GetSPDetails(request);

            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    SCRequest obj = new SCRequest();
                    obj.Number = reader["number"].ToString() == null ? "" : reader["number"].ToString();
                    obj.Resolved_Month = reader["Resolved_Month"].ToString() == null ? "" : reader["Resolved_Month"].ToString();
                    obj.Resolved_Month = reader["TTRwithExcludesInMinutes"].ToString() == null ? "" : reader["TTRwithExcludesInMinutes"].ToString();
                    obj.TTRwithExcludesInMinutes = Convert.ToInt32(reader["TTRwithExcludesInMinutes"]);
                    obj.RawTTRInMInutes = Convert.ToInt32(reader["RawTTRInMInutes"]);
                    obj.Open_Month = reader["Open_Month"].ToString() == null ? "" : reader["Open_Month"].ToString();
                    obj.Opened_By = reader["Opened_By"].ToString() == null ? "" : reader["Opened_By"].ToString();
                    obj.Impact = reader["Impact"].ToString() == null ? "" : reader["Impact"].ToString();
                    obj.Escalation = reader["Escalation"].ToString() == null ? "" : reader["Escalation"].ToString();
                    obj.Due_Date = DateTime.Now;
                    obj.Priority = reader["Priority"].ToString() == null ? "" : reader["Priority"].ToString();
                    obj.Request_State = reader["Request_State"].ToString() == null ? "" : reader["Request_State"].ToString();
                    obj.Requested_For = reader["Requested_For"].ToString() == null ? "" : reader["Requested_For"].ToString();
                    obj.Short_Description = reader["Short_Description"].ToString() == null ? "" : reader["Short_Description"].ToString();
                    obj.Stage = reader["Stage"].ToString() == null ? "" : reader["Stage"].ToString();
                    obj.State = reader["State"].ToString() == null ? "" : reader["State"].ToString();
                    obj.BPIT = reader["BPIT"].ToString() == null ? "" : reader["BPIT"].ToString();
                    obj.Assignment_Group = reader["Assignment_Group"].ToString() == null ? "" : reader["Assignment_Group"].ToString();
                    dataCollection.Add(obj);
                }
                reader.NextResult();
            }
            return dataCollection;
        }

        private SqlConnection SqlConnectionString
        {
            get
            {
                return new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["Dev_SqlConnectionString"]);
            }
        }

        private SqlDataReader GetSPDetails(dynamic request)
        {
            var con = SqlConnectionString;

            con.Open();
            string query = request.SPCalled;
            var cmd = new SqlCommand
            {
                Connection = con,
                CommandText = query,
                CommandType = CommandType.StoredProcedure
            };

            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        #endregion

    }
}
