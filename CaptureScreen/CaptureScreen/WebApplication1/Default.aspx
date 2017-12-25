<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
     <%--   <div>
            <object classid="clsid:204238B4-851F-410c-8396-36698C2A88B0" width="442" height="49"
                id="downLoad">
            </object>
            <input onclick="downLoad.DownFile('http://192.168.2.132/PowerCloud/WebPacsImage/2012101920350083.zip','c:\\test')"
                type="button" value="Click" />
        </div>--%>
        
        
        
        
        
        
          <div>
            <table id="tb1" cellpadding="0" cellspacing="0" border="1">
                <tr>
                    <td colspan="2">
                        <object id="cutPic" classid="clsid:A24FBD8D-E9D0-445B-9612-2D23263D9F16"  width="442" height="80">
                        </object>
                    </td>
                </tr>
            </table>
        </div>
        <script language="JavaScript" type="text/javascript">
        var cutPic = window.document.getElementById("cutPic");
        cutPic.call();
        </script>

    </form>
</body>
</html>
