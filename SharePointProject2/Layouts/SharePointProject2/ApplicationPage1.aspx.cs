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

            
            //add materials
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



            foreach (var eqip in bd.Equipments)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                cell1.Text = eqip.EquipmentId.ToString();
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = eqip.DetailNumber.ToString();
                row.Cells.Add(cell2);


                TableCell cell3 = new TableCell();
                cell3.Text = eqip.Name;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = eqip.Quantity.ToString();
                row.Cells.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = eqip.Department;
                row.Cells.Add(cell5);

                Button button = new Button();
                button.Text = "Delete";
                button.Click += (s, e1) =>
                {
                    TPP lbd = new TPP();
                    lbd.Equipments.Attach(eqip);
                    lbd.Entry(eqip).State = System.Data.Entity.EntityState.Deleted;
                    lbd.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                };

                TableCell cell6 = new TableCell();
                cell6.Controls.Add(button);
                row.Cells.Add(cell6);

                equipments.Rows.Add(row);
            }


            //add rigging
            foreach (var rig in bd.Riggings)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                cell1.Text = rig.RiggingId.ToString();
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = rig.Name;
                row.Cells.Add(cell2);


                TableCell cell3 = new TableCell();
                cell3.Text = rig.TypeOfTool;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = rig.Quantity.ToString();
                row.Cells.Add(cell4);


                Button button = new Button();
                button.Text = "Delete";
                button.Click += (s, e1) =>
                {
                    TPP lbd = new TPP();
                    lbd.Riggings.Attach(rig);
                    lbd.Entry(rig).State = System.Data.Entity.EntityState.Deleted;
                    lbd.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                };

                TableCell cell5 = new TableCell();
                cell5.Controls.Add(button);
                row.Cells.Add(cell5);

                riggings.Rows.Add(row);
            }


            //add transitions
            foreach (var trans in bd.Transitions)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                cell1.Text = trans.TransitionId.ToString();
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = trans.TransitionNumber.ToString();
                row.Cells.Add(cell2);


                TableCell cell3 = new TableCell();
                cell3.Text = trans.Keyword;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = trans.TransitionType;
                row.Cells.Add(cell4);


                Button button = new Button();
                button.Text = "Delete";
                button.Click += (s, e1) =>
                {
                    TPP lbd = new TPP();
                    lbd.Transitions.Attach(trans);
                    lbd.Entry(trans).State = System.Data.Entity.EntityState.Deleted;
                    lbd.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                };

                TableCell cell5 = new TableCell();
                cell5.Controls.Add(button);
                row.Cells.Add(cell5);

                transitions.Rows.Add(row);
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            TPP bd = new TPP();
            bd.Materials.Add(new Material()
            {
                Assortment = this.materialAssortment.Text,
                DesignOfStandard = this.materialDesignOfStandard.Text,
                Name = this.materialName.Text,
                Stamp = this.materialStamp.Text
            });
            bd.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void addEquipment_Click(object sender, EventArgs e)
        {
            TPP bd = new TPP();
            bd.Equipments.Add(new Equipment()
            {
                Name = equipmentName.Text,
                Department = equipmentDepartment.Text,
                DetailNumber = int.Parse(equipmentDetailNumber.Text),
                Quantity = int.Parse(equipmentQuantity.Text)
            });
            bd.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void addRigging_Click(object sender, EventArgs e)
        {
            TPP bd = new TPP();
            bd.Riggings.Add(new Rigging()
            {
                Name = this.riggingName.Text,
                Quantity = int.Parse(this.riggingQuantity.Text),
                TypeOfTool = this.riggingTypeOfTool.Text
            });
            bd.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void addTransition_Click(object sender, EventArgs e)
        {

            TPP bd = new TPP();
            bd.Transitions.Add(new Transition()
            {
                Keyword = this.transitionKeyword.Text,
                TransitionNumber = int.Parse(this.transitionTransitionNumber.Text),
                TransitionType = this.transitionTransitionType.Text
            });
            bd.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }
    }
}
