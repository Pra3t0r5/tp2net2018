<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportPlan.aspx.cs" Inherits="UI.WebMvc.Views.Shared.ReportPlan" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script runat="server">
        void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Business.Entities.Curso> customers = null;
                Business.Logic.CursoLogic dc = new Business.Logic.CursoLogic();
                    customers = dc.GetAll();
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/ReporteCursos.rdlc");
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rdc = new ReportDataSource("Cursos", customers);
                    ReportViewer1.LocalReport.DataSources.Add(rdc);
                    ReportViewer1.LocalReport.Refresh();
                
            }
        }
    </script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="544px">
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
