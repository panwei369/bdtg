using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
using Newtonsoft.Json;

namespace BaiDuTuiGuang.Controllers
{
    public class DataReportController : ApiController
    {
        DataReportBll bll = new DataReportBll();
        /// <summary>
        /// 收支统计表
        /// </summary>
        /// <param name="zhang"></param>
        /// <param name="qu"></param>
        /// <param name="da"></param>
        /// <returns></returns>
        [HttpGet]
        public PagingModel GetReceipts(string zhang, string qu, DateTime da,int page = 1, int limit = 10)
        {
            DataTable dt = bll.GetReceipts(zhang,qu,da);
            string json = JsonConvert.SerializeObject(dt);
            List<ReceiptsModel> list = JsonConvert.DeserializeObject<List<ReceiptsModel>>(json);
            int n = list.Count;
            list = list.Skip(limit * (page - 1)).Take(limit).ToList();
            DataTable dts = DataTableExtensions.ToDataTable(list, c => new object[] { list });
            PagingModel pag = new PagingModel()
            {
                code = 0,
                msg = "",
                count = n,
                data = dts
            };
            return pag;
        }
        /// <summary>
        /// 收支统计报表
        /// </summary>
        /// <param name="zhang"></param>
        /// <param name="qu"></param>
        /// <param name="da"></param>
        /// <returns></returns>
        [HttpGet]
        public PagingModel GetReceiptss()
        {
            DataTable dt = bll.GetReceiptss();
            string json = JsonConvert.SerializeObject(dt);
            List<ReceiptsModel> list = JsonConvert.DeserializeObject<List<ReceiptsModel>>(json);
            int n = list.Count;
            PagingModel pag = new PagingModel()
            {
                code = 0,
                msg = "",
                count = n,
                data = dt
            };
            return pag;
        }
        /// <summary>
        /// 余额统计表
        /// </summary>
        /// <param name="zhang"></param>
        /// <param name="qu"></param>
        /// <param name="da"></param>
        /// <returns></returns>
        [HttpGet]
        public PagingModel GetResidual(string qu)
        {
            DataTable dt = bll.GetResidual(qu);
            string json = JsonConvert.SerializeObject(dt);
            List<ResidualModel> list = JsonConvert.DeserializeObject<List<ResidualModel>>(json);
            int n = list.Count;
            PagingModel pag = new PagingModel()
            {
                code = 0,
                msg = "",
                count = n,
                data = dt
            };
            return pag;
        }
        /// <summary>
        /// 余额统计报表
        /// </summary>
        /// <param name="zhang"></param>
        /// <param name="qu"></param>
        /// <param name="da"></param>
        /// <returns></returns>
        [HttpGet]
        public PagingModel GetResiduals(string zhang)
        {
            DataTable dt = bll.GetResiduals(zhang);
            string json = JsonConvert.SerializeObject(dt);
            List<ResidualModel> list = JsonConvert.DeserializeObject<List<ResidualModel>>(json);
            int n = list.Count;
            PagingModel pag = new PagingModel()
            {
                code = 0,
                msg = "",
                count = n,
                data = dt
            };
            return pag;
        }
        /// <summary>
        /// 充值记录表
        /// </summary>
        /// <param name="zhang"></param>
        /// <param name="qu"></param>
        /// <param name="da"></param>
        /// <returns></returns>
        [HttpGet]
        public PagingModel GetStatistics(string qu, DateTime da)
        {
            DataTable dt = bll.GetStatistics( qu, da);
            string json = JsonConvert.SerializeObject(dt);
            List<StatisticsModel> list = JsonConvert.DeserializeObject<List<StatisticsModel>>(json);
            int n = list.Count;
            PagingModel pag = new PagingModel()
            {
                code = 0,
                msg = "",
                count = n,
                data = dt
            };
            return pag;
        }
        /// <summary>
        /// 充值统计表
        /// </summary>
        /// <param name="zhang"></param>
        /// <param name="qu"></param>
        /// <param name="da"></param>
        /// <returns></returns>
        [HttpGet]
        public PagingModel GetStatisticss(string zhang, DateTime da)
        {
            DataTable dt = bll.GetStatisticss(zhang, da);
            string json = JsonConvert.SerializeObject(dt);
            List<StatisticsModel> list = JsonConvert.DeserializeObject<List<StatisticsModel>>(json);
            int n = list.Count;
            PagingModel pag = new PagingModel()
            {
                code = 0,
                msg = "",
                count = n,
                data = dt
            };
            return pag;
        }
        /// <summary>
        /// 禁用账户余额表
        /// </summary>
        /// <param name="zhang"></param>
        /// <param name="qu"></param>
        /// <param name="da"></param>
        /// <returns></returns>
        [HttpGet]
        public PagingModel GetJin()
        {
            DataTable dt = bll.GetJin();
            string json = JsonConvert.SerializeObject(dt);
            List<ResidualModel> list = JsonConvert.DeserializeObject<List<ResidualModel>>(json);
            int n = list.Count;
            PagingModel pag = new PagingModel()
            {
                code = 0,
                msg = "",
                count = n,
                data = dt
            };
            return pag;
        }
    }
}
