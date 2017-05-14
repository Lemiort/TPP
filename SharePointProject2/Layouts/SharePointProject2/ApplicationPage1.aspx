﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
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

</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
Страница приложения
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
Моя страница приложения
</asp:Content>
