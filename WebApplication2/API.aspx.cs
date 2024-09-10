using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class API : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string kq = "";
            try
            {
                int N = int.Parse(this.Request.Form["N"]);
                lib_TinhTienDien.cls_TienDien tg = new lib_TinhTienDien.cls_TienDien();
                tg.N = N;
                tg.TinhTienDien();


                double TienPhaiTra = tg.tiendien;
                kq = ("Số tiền phải trả: " + TienPhaiTra + " đồng");
            }
            catch (Exception ex)
            {
                kq = $"Lỗi : {ex.Message}";
            }
            finally
            {
                this.Response.Write(kq);

            }
        }
    }
}