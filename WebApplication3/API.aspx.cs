using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class API : System.Web.UI.Page
    {
        class phan_hoi
        {
            public string msg;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string kq = "";
            phan_hoi p=new phan_hoi();
            try
            {
                int N = int.Parse(this.Request.Form["N"]);
                lib_TinhTienDien.cls_TienDien tg = new lib_TinhTienDien.cls_TienDien();
                tg.N = N;
                tg.TinhTienDien();


                double TienPhaiTra = tg.tiendien;
                kq = $"Số tiền phải trả: " + TienPhaiTra + " đồng";

                p.msg = kq;
            }
            catch (Exception ex)
            {
                kq = $"Lỗi : {ex.Message}";
                p.msg = kq;
            }
            finally
            {
                string json = JsonConvert.SerializeObject(p);
                this.Response.Write(json);

            }
        }
    }
}