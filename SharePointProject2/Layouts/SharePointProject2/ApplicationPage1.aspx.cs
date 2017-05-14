using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using SharePointProject2.Model;
using System.Web.UI.WebControls;

namespace SharePointProject2.Layouts.SharePointProject2
{
    public partial class ApplicationPage1 : LayoutsPageBase
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            /*using (TPP bd = new TPP())
            {

            }*/
            /*TPP bd = new TPP();
            bd.Materials.Add(new Material()
            {
                Assortment = "erhrh",
                DesignOfStandard = "htdfdh",
                Name = "rth",
                Stamp = "hfhrfr"
            });
            bd.SaveChanges();*/
            TPP bd = new TPP();

            

            foreach(var mat in bd.Materials)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                cell1.Text = mat.MaterialId.ToString();
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = mat.Assortment;
                row.Cells.Add(cell2);


                TableCell cell3 = new TableCell();
                cell3.Text = mat.Name;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = mat.Stamp;
                row.Cells.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = mat.DesignOfStandard;
                row.Cells.Add(cell5);

                Button button = new Button();
                button.Text = "Delete";
                button.Click += (s, e1) =>
                {
                    TPP lbd = new TPP();
                    lbd.Materials.Attach(mat);
                    lbd.Entry(mat).State = System.Data.Entity.EntityState.Deleted;
                    lbd.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                };

                TableCell cell6 = new TableCell();
                cell6.Controls.Add(button);
                row.Cells.Add(cell6);

                materials.Rows.Add(row);
            }
            
            
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            TPP bd = new TPP();
            bd.Materials.Add(new Material()
            {
                Assortment = this.Assortment.Text,
                DesignOfStandard = this.DesignOfStandard.Text,
                Name = this.Name.Text,
                Stamp = this.Stamp.Text
            });
            bd.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }
    }
}
