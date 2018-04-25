using Core.BusinessEntities;
using MSIT.Web.ExcelPivot.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MSIT.Web.BenefitsCalculator.Controllers
{
    public class SBOSvcCtrController : Controller
    {
        // GET: SBOSvcCtr
        public ActionResult Index()
        {

            IEnumerable<SCRequestModel> scRequestModelList = null;
            var modelObj = new SCRequest();
            var SCRequestData = new Collection<SCRequest>();
            PivotService _pivotService = new PivotService();

            try
            {
                SCRequestData = _pivotService.GetAllSCRequestData(modelObj);

                scRequestModelList = (from item in SCRequestData
                                      select new SCRequestModel
                                      {
                                          Number = item.Number,
                                          Resolved_Month = item.Resolved_Month,
                                          TTRwithExcludesInMinutes = item.TTRwithExcludesInMinutes,
                                          RawTTRInMInutes = item.RawTTRInMInutes,
                                          Open_Month = item.Open_Month,
                                          Opened_By = item.Opened_By,
                                          Impact = item.Impact,
                                          Escalation = item.Escalation,
                                          Due_Date = item.Due_Date,
                                          Priority = item.Priority,
                                          Request_State = item.Request_State,
                                          Requested_For = item.Requested_For,
                                          Short_Description = item.Short_Description,
                                          Stage = item.Stage,
                                          State = item.State,
                                          BPIT = item.BPIT,
                                          Assignment_Group = item.Assignment_Group
                                      }).Take(500);

                DataTable dt = new DataTable();

                DataColumn col1 = new DataColumn();
                col1.DataType = System.Type.GetType("System.String");
                col1.ColumnName = "Number";

                DataColumn col2 = new DataColumn();
                col2.DataType = System.Type.GetType("System.String");
                col2.ColumnName = "Resolved_Month";

                DataColumn col3 = new DataColumn();
                col3.DataType = System.Type.GetType("System.Int32");
                col3.ColumnName = "TTRwithExcludesInMinutes";

                DataColumn col4 = new DataColumn();
                col4.DataType = System.Type.GetType("System.Int32");
                col4.ColumnName = "RawTTRInMInutes";

                DataColumn col5 = new DataColumn();
                col5.DataType = System.Type.GetType("System.String");
                col5.ColumnName = "Open_Month";

                DataColumn col6 = new DataColumn();
                col6.DataType = System.Type.GetType("System.String");
                col6.ColumnName = "Opened_By";

                DataColumn col7 = new DataColumn();
                col7.DataType = System.Type.GetType("System.String");
                col7.ColumnName = "Impact";

                DataColumn col8 = new DataColumn();
                col8.DataType = System.Type.GetType("System.String");
                col8.ColumnName = "Escalation";

                DataColumn col9 = new DataColumn();
                col9.DataType = System.Type.GetType("System.DateTime");
                col9.ColumnName = "Due_Date";

                DataColumn col10 = new DataColumn();
                col10.DataType = System.Type.GetType("System.String");
                col10.ColumnName = "Priority";

                DataColumn col11 = new DataColumn();
                col11.DataType = System.Type.GetType("System.String");
                col11.ColumnName = "Request_State";

                DataColumn col12 = new DataColumn();
                col12.DataType = System.Type.GetType("System.String");
                col12.ColumnName = "Requested_For";

                DataColumn col13 = new DataColumn();
                col13.DataType = System.Type.GetType("System.String");
                col13.ColumnName = "Short_Description";

                DataColumn col14 = new DataColumn();
                col14.DataType = System.Type.GetType("System.String");
                col14.ColumnName = "Stage";

                DataColumn col15 = new DataColumn();
                col15.DataType = System.Type.GetType("System.String");
                col15.ColumnName = "State";

                DataColumn col16 = new DataColumn();
                col16.DataType = System.Type.GetType("System.String");
                col16.ColumnName = "BPIT";

                DataColumn col17 = new DataColumn();
                col17.DataType = System.Type.GetType("System.String");
                col17.ColumnName = "Assignment_Group";

                dt.Columns.Add(col1);
                dt.Columns.Add(col2);
                dt.Columns.Add(col3);
                dt.Columns.Add(col4);
                dt.Columns.Add(col5);
                dt.Columns.Add(col6);
                dt.Columns.Add(col7);
                dt.Columns.Add(col8);
                dt.Columns.Add(col9);
                dt.Columns.Add(col10);
                dt.Columns.Add(col11);
                dt.Columns.Add(col12);
                dt.Columns.Add(col13);
                dt.Columns.Add(col14);
                dt.Columns.Add(col15);
                dt.Columns.Add(col16);
                dt.Columns.Add(col17);

                foreach (var item in scRequestModelList)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = item.Number;
                    dr[1] = item.Resolved_Month;
                    dr[2] = item.TTRwithExcludesInMinutes;
                    dr[3] = item.RawTTRInMInutes;
                    dr[4] = item.Open_Month;
                    dr[5] = item.Opened_By;
                    dr[6] = item.Impact;
                    dr[7] = item.Escalation;
                    dr[8] = item.Due_Date;
                    dr[9] = item.Priority;
                    dr[10] = item.Request_State;
                    dr[11] = item.Requested_For;
                    dr[12] = item.Short_Description;
                    dr[13] = item.Stage;
                    dr[14] = item.State;
                    dr[15] = item.BPIT;
                    dr[16] = item.Assignment_Group;
                    dt.Rows.Add(dr);
                }

                var result = new StringBuilder();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    result.Append(dt.Columns[i].ColumnName);
                    result.Append(i == dt.Columns.Count - 1 ? "\n" : ",");
                }

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        result.Append(row[i].ToString());
                        result.Append(i == dt.Columns.Count - 1 ? "\n" : ",");
                    }
                }
                Session["firstTimeSC"] = result;
                string newFileName = AppDomain.CurrentDomain.BaseDirectory + "SBOSvcCtr_Jennifer.csv";
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View();


        }
    }
}