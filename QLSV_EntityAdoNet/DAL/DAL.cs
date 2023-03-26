using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV_EntityAdoNet.DTO;
using System.Windows.Forms;

namespace QLSV_EntityAdoNet.DAL
{
    class DAL
    {
        DataTable dt = null;
        QLSVEntities db = null;
        private static DAL instance;
        public static DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL();
                return instance;
            }
            private set { }
        }
        public DataTable CreatDataTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "Class", DataType = typeof(string)},
                new DataColumn{ColumnName = "Score", DataType = typeof(double)},
                new DataColumn{ColumnName = "Date", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Gender", DataType = typeof(bool)},
                new DataColumn{ColumnName = "Picture", DataType = typeof(bool)},
                new DataColumn{ColumnName = "HocBa", DataType = typeof(bool)},
                new DataColumn{ColumnName = "Cccd", DataType = typeof(bool)}
            });
            return dt;
        }
        public DataTable GetDataTableByList(List<SV> list)
        {
            dt = CreatDataTable();
            foreach (SV s in list)
            {
                string clname = GetClassByID((int)s.SVCLID);
                dt.Rows.Add(s.SVID, s.SVName, clname, s.SVDtb, s.SVNS, s.SVGender, s.SVPicture, s.SVHb, s.SVCccd);
            }
                
            return dt;
        }

        public DataTable GetRecord(string clname, string txt)
        {
            dt = CreatDataTable();
            if (clname != "All")
            {
                var list = (from s in QLSVEntities.Instance.SVs
                            join c in QLSVEntities.Instance.LopSHes
                            on s.SVCLID equals c.CLID
                            where c.CLName.Equals(clname) && s.SVName.Contains(txt)
                            select new { s.SVID, s.LopSH.CLName, s.SVName, s.SVDtb, s.SVNS, s.SVGender, s.SVPicture, s.SVHb, s.SVCccd }).ToList();
                foreach (var i in list)
                {
                    dt.Rows.Add(i.SVID, i.SVName, i.CLName, i.SVDtb, i.SVNS, i.SVGender, i.SVPicture, i.SVHb, i.SVCccd);
                }
            }
            else
            {
                var list = (from s in QLSVEntities.Instance.SVs
                            join c in QLSVEntities.Instance.LopSHes
                on s.SVCLID equals c.CLID
                            where  s.SVName.Contains(txt)
                            select new { s.SVID, s.LopSH.CLName, s.SVName, s.SVDtb, s.SVNS, s.SVGender, s.SVPicture, s.SVHb, s.SVCccd }).ToList();
                foreach (var i in list)
                {
                    dt.Rows.Add(i.SVID, i.SVName, i.CLName, i.SVDtb, i.SVNS, i.SVGender, i.SVPicture, i.SVHb, i.SVCccd);
                }
            }
            return dt;
        }
        public List<string> GetAllCl()
        {
            var dt = QLSVEntities.Instance.LopSHes;
            List<string> list = new List<string>();
            foreach (var i in dt)
            {
                list.Add(i.CLName);
            }
            return list;
        }
        public List<string> GetCBCL()
        {
            var dt = QLSVEntities.Instance.LopSHes;
            List<string> list = new List<string>() { "All" };

            foreach (var i in dt)
            {
                list.Add(i.CLName);
            }
            return list;
        }
        public DataTable GetSVBySearch(string clname, string txt)
        {
            dt = GetRecord(clname, txt);
            return dt;
        }
        public void DeleteSV(int id)
        {
            var sv = QLSVEntities.Instance.SVs.Where(s => s.SVID == id).FirstOrDefault();
            QLSVEntities.Instance.SVs.Remove(sv);
            QLSVEntities.Instance.SaveChanges();
        }
        public DataTable SortSV(string yc, DataTable dt)
        {
            List<SV> list = new List<SV>();
            foreach(DataRow i in dt.Rows)
            {
                int id = Convert.ToInt32(i["ID"].ToString());
                string name = i["Name"].ToString();
                int clid = GetIDClass(i["Class"].ToString());
                double score = Convert.ToDouble(i["Score"].ToString());
                DateTime ns = Convert.ToDateTime(i["Date"].ToString());
                bool gen = Convert.ToBoolean(i["Gender"].ToString());
                bool pic = Convert.ToBoolean(i["Picture"].ToString());
                bool hb = Convert.ToBoolean(i["HocBa"].ToString());
                bool cccd = Convert.ToBoolean(i["Cccd"].ToString());
                SV sv = new SV(id, clid, name, score, ns, gen, pic, hb, cccd);
                list.Add(sv);
            }    
            switch (yc)
            {
                case "Class":
                    list = list.OrderBy(s => s.SVCLID).ToList();
                    dt = GetDataTableByList(list);
                    break;
                case "Name":
                    list = list.OrderBy(s => s.SVName).ToList();
                    dt = GetDataTableByList(list);
                    break;
                case "ID":
                    list = list.OrderBy(s => s.SVID).ToList();
                    dt = GetDataTableByList(list);
                    break;
                case "Dtb":
                    list = list.OrderBy(s => s.SVDtb).ToList();
                    dt = GetDataTableByList(list);
                    break;
                case "NS":
                    list = list.OrderBy(s => s.SVNS).ToList();
                    dt = GetDataTableByList(list);
                    break;
                case "Gender":
                    list = list.OrderBy(s => s.SVGender).ToList();
                    dt = GetDataTableByList(list);
                    break;
            }
            return dt;
        }
        public int GetIDClass(string name)
        {
            return QLSVEntities.Instance.LopSHes.Where(s => s.CLName == name).FirstOrDefault().CLID;
        }
        public string GetClassByID(int id)
        {
            return QLSVEntities.Instance.LopSHes.Where(s => s.CLID == id).FirstOrDefault().CLName;
        }
        public SV GetSVByID(int svid)
        {
            var sv = QLSVEntities.Instance.SVs.Where(s => s.SVID == svid).FirstOrDefault();
            return sv;
        }
        public int AddSV(SV sv)
        {
            int kq = -1;
            if (sv != null)
            {
                QLSVEntities.Instance.SVs.Add(sv);
                kq = QLSVEntities.Instance.SaveChanges();
            }
            return kq;
        }
        
        public int UpdateSV(SV sv)
        {
            int kq = -1;
            if (sv != null)
            {
                SV s = QLSVEntities.Instance.SVs.Where(p => p.SVID == sv.SVID).FirstOrDefault();
                s.SVCLID = (int)sv.SVCLID;
                s.SVName = sv.SVName;
                s.SVNS = (DateTime)sv.SVNS;
                s.SVDtb = (double)sv.SVDtb;
                s.SVPicture = (bool)sv.SVPicture;
                s.SVGender = (bool)sv.SVGender;
                s.SVCccd = (bool)sv.SVCccd;
                s.SVHb = (bool)sv.SVHb;
                QLSVEntities.Instance.Entry(s).State = EntityState.Modified;
                kq = QLSVEntities.Instance.SaveChanges();
            }
            return kq;
        }
    }
}
