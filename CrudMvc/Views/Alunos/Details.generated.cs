﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using CrudMvc;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Alunos/Details.cshtml")]
    public partial class _Views_Alunos_Details_cshtml : System.Web.Mvc.WebViewPage<CrudMvc.Models.Aluno>
    {
        public _Views_Alunos_Details_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Alunos\Details.cshtml"
  
    ViewBag.Title = "Detalhes";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <h4>Aluno</h4>\r\n    <hr />\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 26 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nascimento));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nascimento));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ativo));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 58 "..\..\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ativo));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n");

WriteLiteral("    ");

            
            #line 64 "..\..\Views\Alunos\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = Model.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("    ");

            
            #line 65 "..\..\Views\Alunos\Details.cshtml"
Write(Html.ActionLink("Voltar", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n");

        }
    }
}
#pragma warning restore 1591
