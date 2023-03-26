using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using QLSV_EntityAdoNet.DTO;
using QLSV_EntityAdoNet.DAL;
namespace QLSV_EntityAdoNet.BAL
{
    class BAL
    {
        DataTable dt = null;
        QLSVEntities db = null;
        private static BAL instance;
        public static BAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BAL();
                return instance;
            }
            private set { }
        }
        public DataTable CreatDataTable()
        {
            return DAL.DAL.Instance.CreatDataTable();
        }
        public DataTable GetDataTableByList(List<SV> list)
        {
            
            return DAL.DAL.Instance.GetDataTableByList(list);
        }
        
        public DataTable GetRecord(string clname, string txt)
        {
            return DAL.DAL.Instance.GetRecord(clname, txt);
        }
        public List<string> GetAllCl()
        {
            return DAL.DAL.Instance.GetAllCl();
        }
        public List<string> GetCBCL()
        {
            return DAL.DAL.Instance.GetCBCL();
        }
        public DataTable GetSVBySearch(string clname, string txt)
        {
            return DAL.DAL.Instance.GetSVBySearch(clname, txt);
        }
        
        public DataTable SortSV(string yc, DataTable dt)
        {
            return DAL.DAL.Instance.SortSV(yc, dt);
        }
        public int GetIDClass(string name)
        {
            return DAL.DAL.Instance.GetIDClass(name);
        }
        public SV GetSVByID(int svid)
        {
            return DAL.DAL.Instance.GetSVByID(svid);
        }
        public void DeleteSV(int id)
        {
            DAL.DAL.Instance.DeleteSV(id);
        }
        public int AddSV(SV sv)
        {
            return DAL.DAL.Instance.AddSV(sv);
        }
        public int UpdateSV(SV sv)
        {
            return DAL.DAL.Instance.UpdateSV(sv);
        }
    }
}
