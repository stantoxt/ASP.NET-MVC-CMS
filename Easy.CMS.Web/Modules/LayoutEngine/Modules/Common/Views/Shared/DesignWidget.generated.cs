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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Easy.Constant;
    using Easy.Extend;
    using Easy.Web.CMS;
    using Easy.Web.Extend;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Modules/Common/Views/Shared/DesignWidget.cshtml")]
    public partial class _Modules_Common_Views_Shared_DesignWidget_cshtml : Easy.Web.Page.ViewPage<Easy.Web.CMS.Widget.DesignWidgetViewModel>
    {
        public _Modules_Common_Views_Shared_DesignWidget_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
  
    var toggleClasssAction = Url.Action("ToggleClass", "Widget", new { module = "admin", Model.Widget.ID });

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("style", Tuple.Create(" style=\"", 171), Tuple.Create("\"", 204)
            
            #line 5 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
, Tuple.Create(Tuple.Create("", 179), Tuple.Create<System.Object, System.Int32>(Model.Widget.CustomStyle
            
            #line default
            #line hidden
, 179), false)
);

WriteLiteral(">\r\n    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 216), Tuple.Create("\"", 270)
, Tuple.Create(Tuple.Create("", 224), Tuple.Create("widget", 224), true)
, Tuple.Create(Tuple.Create(" ", 230), Tuple.Create("widget-design", 231), true)
            
            #line 6 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
, Tuple.Create(Tuple.Create(" ", 244), Tuple.Create<System.Object, System.Int32>(Model.Widget.CustomClass
            
            #line default
            #line hidden
, 245), false)
);

WriteAttribute("id", Tuple.Create("\r\n         id=\"", 271), Tuple.Create("\"", 309)
, Tuple.Create(Tuple.Create("", 286), Tuple.Create("widget_", 286), true)
            
            #line 7 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
, Tuple.Create(Tuple.Create("", 293), Tuple.Create<System.Object, System.Int32>(Model.Widget.ID
            
            #line default
            #line hidden
, 293), false)
);

WriteLiteral("\r\n         data-widgetid=\"");

            
            #line 8 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                   Write(Model.Widget.ID);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 368), Tuple.Create("\"", 447)
, Tuple.Create(Tuple.Create("", 376), Tuple.Create("zoneToolbar", 376), true)
            
            #line 9 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
, Tuple.Create(Tuple.Create(" ", 387), Tuple.Create<System.Object, System.Int32>(Model.Widget.LayoutID.IsNullOrEmpty() ? "blue" : "green"
            
            #line default
            #line hidden
, 388), false)
);

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"tools\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                
            
            #line default
            #line hidden
            
            #line 11 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                 if (Model.Widget.LayoutID.IsNotNullAndWhiteSpace())
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"badge\"");

WriteLiteral(">布局</span>\r\n");

            
            #line 14 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <i");

WriteLiteral(" class=\"glyphicon glyphicon-move sort-handle\"");

WriteLiteral(" title=\"拖动\"");

WriteLiteral(">\r\n                </i>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 760), Tuple.Create("\"", 904)
            
            #line 17 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
, Tuple.Create(Tuple.Create("", 767), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", "Widget", new {module = "admin", Model.Widget.ID, ReturnUrl = Url.Action("Design", "Page", new {ID = Model.PageID})})
            
            #line default
            #line hidden
, 767), false)
);

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-edit\"");

WriteLiteral("\r\n                   title=\"编辑\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 21 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(Url.Action("Copy", "Widget", new { widgetId = Model.Widget.ID }));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"container\"");

WriteLiteral("\r\n                   title=\"复制\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-copy copy-widget\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 26 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"container\"");

WriteLiteral("\r\n                   title=\"切换容器\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-transfer transfer-container toggl" +
"e-widget-class\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 31 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"full\"");

WriteLiteral("\r\n                   title=\"减小外边距\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-fullscreen toggle-widget-class\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 36 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"full\"");

WriteLiteral("\r\n                   title=\"增加边距\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-th-large toggle-widget-class\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 41 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"align-center\"");

WriteLiteral("\r\n                   title=\"文字居中\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-align-center toggle-widget-class\"" +
"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 46 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"align-right\"");

WriteLiteral("\r\n                   title=\"文字右对齐\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-align-right toggle-widget-class\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 51 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"border\"");

WriteLiteral("\r\n                   title=\"外边框\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-unchecked toggle-widget-class\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 56 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"image-border\"");

WriteLiteral("\r\n                   title=\"图片加边框\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-picture toggle-widget-class\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 61 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"image-circle\"");

WriteLiteral("\r\n                   title=\"图片圆角\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-adjust toggle-widget-class\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("\r\n                   data-action=\"");

            
            #line 66 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                           Write(toggleClasssAction);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-class=\"box-shadow\"");

WriteLiteral("\r\n                   title=\"阴影\"");

WriteLiteral("\r\n                   class=\"glyphicon glyphicon-tags toggle-widget-class\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-action=\"");

            
            #line 70 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                                                     Write(Url.Action("SaveCustomStyle", "Widget", new {module = "admin", Model.Widget.ID}));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" \r\n                   title=\"自定义样式(设置背景图片等)\"");

WriteLiteral(" class=\"glyphicon glyphicon-erase custom-style-editor\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"delete glyphicon glyphicon-trash\"");

WriteLiteral(" title=\"删除\"");

WriteLiteral("\r\n                   data-url=\"");

            
            #line 73 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                        Write(Url.Action("DeleteWidget", "Widget", new {module = "admin"}));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                   data-id=\"");

            
            #line 74 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                       Write(Model.Widget.ID);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></a>\r\n                <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">|</span>\r\n                <span>");

            
            #line 76 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                 Write(Model.Widget.WidgetName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                \r\n            </div>\r\n        </div>\r\n");

            
            #line 80 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
        
            
            #line default
            #line hidden
            
            #line 80 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
         if (Model.Widget.Title.IsNotNullAndWhiteSpace())
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 84 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
               Write(Model.Widget.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 87 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
               Write(Html.DisPlayWidget(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 90 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 93 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
       Write(Html.DisPlayWidget(Model));

            
            #line default
            #line hidden
            
            #line 93 "..\..\Modules\Common\Views\Shared\DesignWidget.cshtml"
                                      
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
