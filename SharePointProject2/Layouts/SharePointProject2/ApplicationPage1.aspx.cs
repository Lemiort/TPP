﻿using System;
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

            SPSite site = SPControl.GetContextSite(Context);
            SPWeb web = site.OpenWeb();
            SPUser currentUser = web.CurrentUser;
            this.routeNameOfDeveloper.Text = currentUser.LoginName;


            //add materials
            foreach (var mat in bd.Materials)
            {
                //fill dropdowns
                technologicalProcessMaterial.Items.Add(
                    new ListItem(mat.MaterialId.ToString(), mat.MaterialId.ToString()));

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


            //fill Equipment table
            foreach (var eqip in bd.Equipments)
            {
                //add to dropdown
                operationEquipment.Items.Add(
                    new ListItem(eqip.EquipmentId.ToString(), eqip.EquipmentId.ToString()));

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
                //add to dropdowns
                operationRigging.Items.Add(
                    new ListItem(rig.RiggingId.ToString(), rig.RiggingId.ToString()));

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



            //fill operations table
            foreach (var oper in bd.Operations)
            {
                //add to dropdowns
                technologicalProcessOperation.Items.Add(
                    new ListItem(oper.OperationId.ToString(), oper.OperationId.ToString()));

                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                cell1.Text = oper.OperationId.ToString();
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = oper.Name;
                row.Cells.Add(cell2);


                TableCell cell3 = new TableCell();
                cell3.Text = oper.Number.ToString();
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = oper.TransitionId.ToString();
                row.Cells.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = oper.TransitionName;
                row.Cells.Add(cell5);


                TableCell cell6 = new TableCell();
                cell6.Text = oper.EquipmentId.ToString();
                row.Cells.Add(cell6);

                TableCell cell7 = new TableCell();
                cell7.Text = oper.RiggingId.ToString();
                row.Cells.Add(cell7);

                TableCell cell8 = new TableCell();
                cell8.Text = oper.DepartmentNumber.ToString();
                row.Cells.Add(cell8);

                TableCell cell9 = new TableCell();
                cell9.Text = oper.SiteNumber.ToString();
                row.Cells.Add(cell9);

                TableCell cell10 = new TableCell();
                cell10.Text = oper.WorkplaceNumber.ToString();
                row.Cells.Add(cell10);

                Button button = new Button();
                button.Text = "Delete";
                button.Click += (s, e1) =>
                {
                    TPP lbd = new TPP();
                    lbd.Operations.Attach(oper);
                    lbd.Entry(oper).State = System.Data.Entity.EntityState.Deleted;
                    lbd.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                };

                TableCell cell11 = new TableCell();
                cell11.Controls.Add(button);
                row.Cells.Add(cell11);

                operations.Rows.Add(row);
            }


            //add transitions
            foreach (var trans in bd.Transitions)
            {
                //add to dropdowns
                operationTransition.Items.Add(
                    new ListItem(trans.TransitionId.ToString(), trans.TransitionId.ToString()));

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

            //fill TechnologicalProcesses
            foreach (var tp in bd.TechnologicalProcesseses)
            {
                //add to routes
                this.routeTechProc.Items.Add(
                    new ListItem(tp.TechProcId.ToString(), tp.TechProcId.ToString()));

                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                cell1.Text = tp.TechProcId.ToString();
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = tp.Name;
                row.Cells.Add(cell2);


                TableCell cell3 = new TableCell();
                cell3.Text = tp.OperationId.ToString();
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = tp.MaterialId.ToString();
                row.Cells.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = tp.TypeByExecution;
                row.Cells.Add(cell5);

                TableCell cell6 = new TableCell();
                cell6.Text = tp.ActNumber.ToString();
                row.Cells.Add(cell6);


                Button button = new Button();
                button.Text = "Delete";
                button.Click += (s, e1) =>
                {
                    TPP lbd = new TPP();
                    lbd.TechnologicalProcesseses.Attach(tp);
                    lbd.Entry(tp).State = System.Data.Entity.EntityState.Deleted;
                    lbd.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                };

                TableCell cell7 = new TableCell();
                cell5.Controls.Add(button);
                row.Cells.Add(cell7);

                technologicalProcesses.Rows.Add(row);
            }


            //fill route
            foreach (var route in bd.Routes)
            {

                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                cell1.Text = route.RouteId.ToString();
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = route.TechProcId.ToString();
                row.Cells.Add(cell2);


                TableCell cell3 = new TableCell();
                cell3.Text = route.NameTechProc;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                //SPUser developer = web.Users.GetByID(route.NameOfDeveloper);
                //cell4.Text = developer.LoginName;
                cell4.Text = route.NameOfDeveloper.ToString();
                row.Cells.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = route.DetailsDesignation;
                row.Cells.Add(cell5);

                TableCell cell6 = new TableCell();
                cell6.Text = route.DetailsName;
                row.Cells.Add(cell6);

                Button button = new Button();
                button.Text = "Delete";
                button.Click += (s, e1) =>
                {
                    TPP lbd = new TPP();
                    lbd.Routes.Attach(route);
                    lbd.Entry(route).State = System.Data.Entity.EntityState.Deleted;
                    lbd.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                };

                TableCell cell7 = new TableCell();
                cell7.Controls.Add(button);
                row.Cells.Add(cell7);

                routes.Rows.Add(row);
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

        protected void technologicalProcessAdd_Click(object sender, EventArgs e)
        {
            TPP bd = new TPP();
            bd.TechnologicalProcesseses.Add(new TechnologicalProcesses()
            {
                Name = this.technologicalProcessName.Text,
                Operation = bd.Operations.Find(int.Parse(this.technologicalProcessOperation.SelectedValue)),
                Material = bd.Materials.Find(int.Parse(this.technologicalProcessMaterial.SelectedValue)),
                TypeByExecution = this.technologicalProcessTypeByExecution.Text,
                ActNumber = int.Parse(this.technologicalProcessNumber.Text)
            });
            bd.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void addOperation_Click(object sender, EventArgs e)
        {
            TPP bd = new TPP();
            bd.Operations.Add(new Operation()
            {
                DepartmentNumber = int.Parse(this.operationDepartmentNumber.Text),
                Equipment = bd.Equipments.Find(int.Parse(this.operationEquipment.SelectedValue)),
                Name = this.operationName.Text,
                Number = int.Parse(this.operationNumber.Text),
                Rigging = bd.Riggings.Find(int.Parse(this.operationRigging.SelectedValue)),
                SiteNumber = int.Parse(this.operationSiteNumber.Text),
                Transition = bd.Transitions.Find(int.Parse(this.operationTransition.SelectedValue)),
                TransitionName = this.operationTransitionName.Text,
                WorkplaceNumber = int.Parse(operationWorkplaceNumber.Text)
            });
            bd.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void addRoute_Click(object sender, EventArgs e)
        {
            SPWeb theSite = SPControl.GetContextWeb(Context);
            SPUser theUser = theSite.CurrentUser;
            //string strUserName = theUser.LoginName;

            TPP bd = new TPP();
            bd.Routes.Add(new Route()
            {
                TechnologicalProcesses = bd.TechnologicalProcesseses.Find(int.Parse(this.routeTechProc.SelectedValue)),
                NameOfDeveloper = theUser.ID,
                DetailsDesignation = this.routeDetailsDesignation.Text,
                DetailsName = this.routeDetailsName.Text
            });
            bd.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }
    }
}
