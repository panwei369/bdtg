using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DataReportBll
    {
        DataReportDal dal = new DataReportDal();
        //收支统计表
        public DataTable GetReceipts(string zhang, string qu, DateTime da)
        {
            string sql = "select RId,Datatime,DName,CName,Piont,Recharge,ShiRecharge,DaiRecharge,CaiRecharge,Balance,ZheBalance,XiaoFei,ZheXiao from bd_Receipts join bd_Channel on bd_Receipts.CId = bd_Channel.CId join bd_Deng on bd_Deng.DId = bd_Receipts.DId where 1=1";
            if (!string.IsNullOrEmpty(zhang))
            {
                sql += $"  and DName like '%{zhang}%'";
            }
            if (!string.IsNullOrEmpty(qu))
            {
                sql += $"  and CName like '%{qu}%'";
            }
            if (da != null)
            {
                sql += $"  and Datatime like '%{da}%'";
            }
            DataTable dt = dal.Index(sql);
            return dt;
        }
        //收支统计报表
        public DataTable GetReceiptss()
        {
            string sql = "select RId,Datatime,DName,Piont,Recharge,ShiRecharge,DaiRecharge,CaiRecharge,Balance,ZheBalance,XiaoFei,ZheXiao from bd_Receipts join bd_Channel on bd_Receipts.CId = bd_Channel.CId join bd_Deng on bd_Deng.DId = bd_Receipts.DId ";
            DataTable dt = dal.Index(sql);
            return dt;
        }
        //余额统计表
        public DataTable GetResidual(string qu)
        {
            string sql = "select YId,CName,AccountBalance,ZHeAccountBalance from bd_Residual join bd_Channel on bd_Residual.CId = bd_Channel.CId join bd_Deng on bd_Deng.DId = bd_Residual.DId where 1 = 1";
            if (!string.IsNullOrEmpty(qu))
            {
                sql += $"  and CName like '%{qu}%'";
            }
            DataTable dt = dal.Index(sql);
            return dt;
        }
        //余额统计报表
        public DataTable GetResiduals(string zhang)
        {
            string sql = "select YId,DName,CName,Piont,AccountBalance,ZHeAccountBalance,State from bd_Residual join bd_Channel on bd_Residual.CId = bd_Channel.CId join bd_Deng on bd_Deng.DId = bd_Residual.DId where 1 = 1";
            if (!string.IsNullOrEmpty(zhang))
            {
                sql += $"  and DName like '%{zhang} % '";
            }
            DataTable dt = dal.Index(sql);
            return dt;
        }
        //充值记录表
        public DataTable GetStatistics(string qu, DateTime da)
        {
            string sql = "select SId,CName,RechargeSt,ZheRechargeSt from bd_Statistics join bd_Channel on bd_Statistics.CId = bd_Channel.CId join bd_Deng on bd_Deng.DId = bd_Statistics.DId where 1 = 1";
            if (!string.IsNullOrEmpty(qu))
            {
                sql += $"  and CName like '%{qu}%'";
            }
            if (da != null)
            {
                sql += $"  and Datatime like '%{da}%'";
            }
            DataTable dt = dal.Index(sql);
            return dt;
        }
        //充值统计表
        public DataTable GetStatisticss(string zhang, DateTime da)
        {
            string sql = "select SId,DName,CName,Piont,RechargeSt,ZheRechargeSt,State from bd_Statistics join bd_Channel on bd_Statistics.CId = bd_Channel.CId join bd_Deng on bd_Deng.DId = bd_Statistics.DId where 1 = 1";
            if (!string.IsNullOrEmpty(zhang))
            {
                sql += $"  and DName like '%{zhang}%'";
            }
            if (da != null)
            {
                sql += $"  and Datatime like '%{da}%'";
            }
            DataTable dt = dal.Index(sql);
            return dt;
        }
        //禁用账户余额表
        public DataTable GetJin()
        {
            string sql = "select YId,DName,CName,Piont,AccountBalance,ZHeAccountBalance,State from bd_Residual join bd_Channel on bd_Residual.CId = bd_Channel.CId join bd_Deng on bd_Deng.DId = bd_Residual.DId where State=1";
            DataTable dt = dal.Index(sql);
            return dt;

        }
    }
}
