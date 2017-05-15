<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationPage1.aspx.cs" Inherits="SharePointProject2.Layouts.SharePointProject2.ApplicationPage1" DynamicMasterPageFile="~masterurl/default.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">

</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">

    <!-- Meaterials table-->
    <div>
        <asp:Panel runat="server">
            <asp:Table ID="materials" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableCell>MaterialId</asp:TableCell>
                    <asp:TableCell>Assortment</asp:TableCell>
                    <asp:TableCell>Name</asp:TableCell>
                    <asp:TableCell>Stamp</asp:TableCell>
                    <asp:TableCell>DesignOfStandard</asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </asp:Panel>
    </div>
    <!--add material panel-->
    <div> 
        <asp:Panel runat="server">
           <asp:Label ID="Label1" runat="server" Text="Assortment"></asp:Label>
            <br />
            <asp:TextBox ID="materialAssortment" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="materialName" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label3" runat="server" Text="Stamp"></asp:Label>
            <br />
            <asp:TextBox ID="materialStamp" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label4" runat="server" Text="DesignOfStandard"></asp:Label>
            <br />
            <asp:TextBox ID="materialDesignOfStandard" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="materialAddButton" runat="server" Text="Add"  OnClick="AddButton_Click"/>
        </asp:Panel>
    </div>



    <!--equipment table-->
    <div>
        <asp:Panel runat="server">
            <asp:Table ID="equipments" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableCell>EquipmentId</asp:TableCell>
                    <asp:TableCell>DetailNumber</asp:TableCell>
                    <asp:TableCell>Name</asp:TableCell>
                    <asp:TableCell>Quantity</asp:TableCell>
                    <asp:TableCell>Department</asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </asp:Panel>
    </div>
    <!-- add equipment panel-->
    <div> 
        <asp:Panel runat="server">
           <asp:Label ID="Label5" runat="server" Text="DetailNumber"></asp:Label>
            <br />
            <asp:TextBox ID="equipmentDetailNumber" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label6" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="equipmentName" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label7" runat="server" Text="Quantity"></asp:Label>
            <br />
            <asp:TextBox ID="equipmentQuantity" runat="server"></asp:TextBox>
            <br />

             <asp:Label ID="Label8" runat="server" Text="Department"></asp:Label>
            <br />
            <asp:TextBox ID="equipmentDepartment" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="addEquipment" runat="server" Text="Add"  OnClick="addEquipment_Click"/>
        </asp:Panel>
    </div>

    <!--Rigging table-->
    <div>
        <asp:Panel runat="server">
            <asp:Table ID="riggings" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableCell>RiggingId</asp:TableCell>
                    <asp:TableCell>Name</asp:TableCell>
                    <asp:TableCell>TypeOfTool</asp:TableCell>
                    <asp:TableCell>Quantity</asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </asp:Panel>
    </div>
    <!-- add rigging panel-->
    <div> 
        <asp:Panel runat="server">
           <asp:Label ID="Label9" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="riggingName" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label10" runat="server" Text="TypeOfTool"></asp:Label>
            <br />
            <asp:TextBox ID="riggingTypeOfTool" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label11" runat="server" Text="Quantity"></asp:Label>
            <br />
            <asp:TextBox ID="riggingQuantity" runat="server"></asp:TextBox>
            <br />


            <asp:Button ID="addRigging" runat="server" Text="Add"  OnClick="addRigging_Click"/>
        </asp:Panel>
    </div>


     <!--Transitions table-->
    <div>
        <asp:Panel runat="server">
            <asp:Table ID="transitions" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableCell>TransitionId</asp:TableCell>
                    <asp:TableCell>TransitionNumber</asp:TableCell>
                    <asp:TableCell>Keyword</asp:TableCell>
                    <asp:TableCell>TransitionType</asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </asp:Panel>
    </div>
    <!-- add transitions panel-->
    <div> 
        <asp:Panel runat="server">
           <asp:Label ID="Label12" runat="server" Text="TransitionNumber"></asp:Label>
            <br />
            <asp:TextBox ID="transitionTransitionNumber" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label13" runat="server" Text="Keyword"></asp:Label>
            <br />
            <asp:TextBox ID="transitionKeyword" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label14" runat="server" Text="TransitionType"></asp:Label>
            <br />
            <asp:TextBox ID="transitionTransitionType" runat="server"></asp:TextBox>
            <br />


            <asp:Button ID="addTransition" runat="server" Text="Add"  OnClick="addTransition_Click"/>
        </asp:Panel>
    </div>



    <!--Operation table-->
    <div>
        <asp:Panel runat="server">
            <asp:Table ID="operations" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableCell>OperationId</asp:TableCell>
                    <asp:TableCell>Name</asp:TableCell>
                    <asp:TableCell>Number</asp:TableCell>
                    <asp:TableCell>TransitionId</asp:TableCell>
                    <asp:TableCell>TransitionName</asp:TableCell>
                    <asp:TableCell>EquipmentId</asp:TableCell>
                    <asp:TableCell>RiggingId</asp:TableCell>
                    <asp:TableCell>DepartmentNumber</asp:TableCell>
                    <asp:TableCell>SiteNumber</asp:TableCell>
                    <asp:TableCell>WorkplaceNumber</asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </asp:Panel>
    </div>
    <!-- add operation panel-->
    <div> 
        <asp:Panel runat="server">
           <asp:Label ID="Label20" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="operationName" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label21" runat="server" Text="Number"></asp:Label>
            <br />
            <asp:TextBox ID="operationNumber" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label22" runat="server" Text="Transition"></asp:Label>
            <br />
            <asp:DropDownList ID="operationTransition" runat="server"></asp:DropDownList>
            <br />

            <asp:Label ID="Label23" runat="server" Text="TransitionName"></asp:Label>
            <br />
            <asp:TextBox ID="operationTransitionName" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label24" runat="server" Text="Equipment"></asp:Label>
            <br />
            <asp:DropDownList ID="operationEquipment" runat="server"></asp:DropDownList>
            <br />

            <asp:Label ID="Label25" runat="server" Text="Rigging"></asp:Label>
            <br />
            <asp:DropDownList ID="operationRigging" runat="server"></asp:DropDownList>
            <br />

            <asp:Label ID="Label26" runat="server" Text="DepartmentNumber"></asp:Label>
            <br />
            <asp:TextBox ID="operationDepartmentNumber" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label27" runat="server" Text="SiteNumber"></asp:Label>
            <br />
            <asp:TextBox ID="operationSiteNumber" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label28" runat="server" Text="WorkplaceNumber"></asp:Label>
            <br />
            <asp:TextBox ID="operationWorkplaceNumber" runat="server"></asp:TextBox>
            <br />


            <asp:Button ID="addOperation" runat="server" Text="Add"  OnClick="addOperation_Click"/>
        </asp:Panel>
    </div>


     <!--TechnologicalProcesses  table-->
    <div>
        <asp:Panel runat="server">
            <asp:Table ID="technologicalProcesses" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableCell>TechProcId</asp:TableCell>
                    <asp:TableCell>Name</asp:TableCell>
                    <asp:TableCell>OperationId</asp:TableCell>
                    <asp:TableCell>MaterialId</asp:TableCell>
                    <asp:TableCell>TypeByExecution</asp:TableCell>
                    <asp:TableCell>ActNumber</asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </asp:Panel>
    </div>
    <!-- add TechnologicalProcesses panel-->
    <div> 
        <asp:Panel runat="server">
           <asp:Label ID="Label15" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="technologicalProcessName" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label16" runat="server" Text="Operation"></asp:Label>
            <br />
            <asp:DropDownList ID="technologicalProcessOperation" runat="server"></asp:DropDownList>
            <br />

            <asp:Label ID="Label17" runat="server" Text="Material"></asp:Label>
            <br />
            <asp:DropDownList ID="technologicalProcessMaterial" runat="server"></asp:DropDownList>
            <br />

            <asp:Label ID="Label18" runat="server" Text="TypeByExecution"></asp:Label>
            <br />
            <asp:TextBox ID="technologicalProcessTypeByExecution" runat="server"></asp:TextBox>
            <br />

             <asp:Label ID="Label19" runat="server" Text="ActNumber"></asp:Label>
            <br />
            <asp:TextBox ID="technologicalProcessNumber" runat="server"></asp:TextBox>
            <br />


            <asp:Button ID="technologicalProcessAdd" runat="server" Text="Add"  OnClick="technologicalProcessAdd_Click"/>
        </asp:Panel>
    </div>



    <!--route table-->
    <div>
        <asp:Panel runat="server">
            <asp:Table ID="routes" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableCell>RouteId</asp:TableCell>
                    <asp:TableCell>TechProcId</asp:TableCell>
                    <asp:TableCell>Number</asp:TableCell>
                    <asp:TableCell>NameTechProc</asp:TableCell>
                    <asp:TableCell>NameOfDeveloper</asp:TableCell>
                    <asp:TableCell>DetailsDesignation</asp:TableCell>
                    <asp:TableCell>DetailsName</asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </asp:Panel>
    </div>
    <!-- add route panel-->
    <div> 
        <asp:Panel runat="server">
           <asp:Label ID="Label29" runat="server" Text="TechProc"></asp:Label>
            <br />
            <asp:DropDownList ID="routeTechProc" runat="server"></asp:DropDownList>
            <br />

            <asp:Label ID="Label31" runat="server" Text="NameTechProc"></asp:Label>
            <br />
            <asp:TextBox ID="routeNameTechProc" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label32" runat="server" Text="NameOfDeveloper"></asp:Label>
            <br />
            <asp:TextBox ID="routeNameOfDeveloper" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label33" runat="server" Text="DetailsDesignation"></asp:Label>
            <br />
            <asp:TextBox ID="routeDetailsDesignation" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label34" runat="server" Text="DetailsName"></asp:Label>
            <br />
            <asp:TextBox ID="routeDetailsName" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="addRoute" runat="server" Text="Add"  OnClick="addRoute_Click"/>
        </asp:Panel>
    </div>
</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
Страница приложения
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
Моя страница приложения
</asp:Content>
