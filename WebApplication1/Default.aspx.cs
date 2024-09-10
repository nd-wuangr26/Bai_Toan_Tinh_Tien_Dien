using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(TextBox1.Text);

            lib_TinhTienDien.cls_TienDien tg = new lib_TinhTienDien.cls_TienDien();
            tg.N = N;
            tg.TinhTienDien();

            double TienPhaiTra = tg.tiendien;
            ketqua.InnerHtml=("Số tiền phải trả: " + TienPhaiTra + " đồng");
        }
    }
}