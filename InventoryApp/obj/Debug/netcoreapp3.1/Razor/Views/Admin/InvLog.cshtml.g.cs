#pragma checksum "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Admin\InvLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b46c6d07e6429c0a6a109230fa862dde4e88ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_InvLog), @"mvc.1.0.view", @"/Views/Admin/InvLog.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\_ViewImports.cshtml"
using InventoryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\_ViewImports.cshtml"
using InventoryApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b46c6d07e6429c0a6a109230fa862dde4e88ba0", @"/Views/Admin/InvLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb7864d2c5639e7cea0ce74955da6728c43b935f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_InvLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/bower_components/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Admin\InvLog.cshtml"
  
    ViewBag.Title = "PTC Computer";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""loading"">
    <div class=""lds-roller"">
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
    </div>
</div>

<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Inventory Log
        <small>Control panel</small>
    </h1>
    <ol class=""breadcrumb"">
");
            WriteLiteral(@"        <li class=""active"">Inventory Log</li>
    </ol>
</section>

<!-- Main content -->
<section class=""content"">
    
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Search</h3>
    
                    <div class=""box-tools pull-right"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                    </div>
                    <!-- /.box-tools -->
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <div class=""row"">

                        <div class=""col-lg-3"">
                            <div class=""form-group"">
                                <label>From Date:</label>

                                <div class=""input-group date""");
            WriteLiteral(@">
                                    <div class=""input-group-addon"">
                                        <i class=""fa fa-calendar""></i>
                                    </div>
                                    <input type=""text"" class=""form-control pull-right"" id=""dateFrom"" required=""required"">
                                </div>
                                <!-- /.input group -->
                            </div>
                        </div>
                        
                        <div class=""col-lg-3"">
                            <div class=""form-group"">
                                <label>Date To:</label>

                                <div class=""input-group date"">
                                    <div class=""input-group-addon"">
                                        <i class=""fa fa-calendar""></i>
                                    </div>
                                    <input type=""text"" class=""form-control pull-right"" id=""fromTo"" required=""requ");
            WriteLiteral(@"ired"">
                                </div>
                                <!-- /.input group -->
                            </div>
                        </div>
                        
                        <div class=""col-lg-3"">
                            <div class=""form-group"">
                                <label>Choose company</label>
                                <select class=""form-control select2"" id=""company"" style=""width: 100%;"">
                                </select>
                            </div>
                        </div>
                        
                        <div class=""col-lg-2"">
                            <div class=""form-group"">
                                <label>Choose type</label>
                                <select class=""form-control select2"" id=""type"" style=""width: 100%;"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b46c6d07e6429c0a6a109230fa862dde4e88ba08711", async() => {
                WriteLiteral("All");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b46c6d07e6429c0a6a109230fa862dde4e88ba09903", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b46c6d07e6429c0a6a109230fa862dde4e88ba011097", async() => {
                WriteLiteral("Search");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
    
                        <div class=""col-lg-1"">
                            <label style=""visibility: hidden"">Search</label>
                            <button type=""submit"" class=""btn btn-primary btn-flat"" id=""searchBtn"" style=""width:100%""><small class=""fa fa-search""></small> Search</button>
                        </div>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
    
        <div class=""col-lg-12"">
            <div class=""box box-primary"">
                <div class=""box-body"">
                    <table id=""tblInventoryLog"" class=""table table-bordered"" style=""width:100%""></table>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
    
    </div>
    <!-- /.row -->
    
</");
            WriteLiteral("section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b46c6d07e6429c0a6a109230fa862dde4e88ba013351", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- bootstrap datepicker -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b46c6d07e6429c0a6a109230fa862dde4e88ba014424", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">

    $('.inventoryLogSubNav').addClass('active');

    let listInventoryLog = [];
    let cols = [];
    
    function setTimer() {
        $('.loading').addClass('active');
    }

    function clearTimer() {
        $('.loading').removeClass('active');
    }

    function resetTimer() {
        let timer = null;

        if (timer) { clearTimeout(timer) }
            timer = setTimeout(function () {
            clearTimer();
        }, timer);

    }
    
    //Date picker
    $('#dateFrom').datepicker(""setDate"", new Date());
    $('#fromTo').datepicker(""setDate"", new Date());
    
    $(document).keypress(function(event){
        let keycode = (event.keyCode ? event.keyCode : event.which);
        if(keycode == '13'){
           //alert('You pressed a ENTER key.');
           event.preventDefault();
           getInvLog();
        }
    });
    
    $('#searchBtn').click(function() {
        getInvLog();
    });
    
    function ge");
            WriteLiteral("tInvLog() {\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 174 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Admin\InvLog.cshtml"
             Write(Url.Action("GetHistoryLog", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            data: {type: $('#type').val(), cpmName: $('#company option:selected').text(), dateFrom: $('#dateFrom').val(), dateTo: $('#fromTo').val()},
            beforeSend: function () {
                setTimer();
            },
            success: function (data) {
                //console.log(data);
                if (data == """") {
                    if ($.fn.DataTable.isDataTable(""#tblInventoryLog"")) {
                        $('#tblInventoryLog').DataTable().clear().destroy();
                        $('#tblInventoryLog').html('');
                    }
                    $('#tblInventoryLog').html('<h4 class=""text-danger text-center"">No matching records found!</h4>')
                    resetTimer();
                } else {
                    $('#tblInventoryLog').html('');
                    listInventoryLog = [];
                    listInventoryLog = data;
                    let inventoryRecord = listInventoryLog");
            WriteLiteral(@"[0];
    
                    let keys = Object.keys(inventoryRecord);
    
                    cols = [];
                    keys.forEach(function (k) {
                        cols.push({
                            title: k,
                            data: k
                        });
    
                    });
    
                    if ($.fn.DataTable.isDataTable(""#tblInventoryLog"")) {
                        $('#tblInventoryLog').DataTable().clear().destroy();
                        $('#tblInventoryLog').html('');
                    }
    
                    let table = $('#tblInventoryLog').DataTable({
                        ""columns"": cols,
                        ""responsive"": true,
                        ""lengthChange"": false,
                        ""autoWidth"": true,
                        ""searching"": true,
                        ""paging"": false,
                        ""scrollY"": '50vh',
                        ""scrollX"": false,
                        ""s");
            WriteLiteral(@"crollCollapse"": true,
                        buttons: [
                            { extend: 'excel', className: 'btn bg-olive btn-flat' }
                        ],
                        dom:
                            ""<'row'<'col-md-0'l><'col-md-6'B><'col-md-6'f>>"" +
                            ""<'row'<'col-md-12'tr>>"" +
                            ""<'row'<'col-md-5'i><'col-md-7'p>>"",
                    })
    
                    table.rows.add(listInventoryLog).draw();
                    
                    table.on('click', 'tr', function () {
                        //var data = table.row(this).data();
                        // below some operations with the data
                        // How can I set the row color as red?
                        $(this).addClass('bg-green').siblings().removeClass('bg-green');
                    });
                    
                    resetTimer();
                }
                
            }
        });
    }
    
    $.a");
            WriteLiteral("jax({\r\n        url: \'");
#nullable restore
#line 248 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Admin\InvLog.cshtml"
         Write(Url.Action("GetCompanyName", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
        type: 'GET',
        dataType: 'JSON',
        success: function(data) {
            //console.log(data);
            for(let i = 0;i < data.length;i++){
                $('#company').append('<option value=' + data[i].dbName + '>' + data[i].cmpName + '</option>');
            }
        }
    });
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
