#pragma checksum "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5926a299d34ace04a04f8a36dcb41a5c1b134b07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_ShowInventory), @"mvc.1.0.view", @"/Views/Inventory/ShowInventory.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\_ViewImports.cshtml"
using InventoryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\_ViewImports.cshtml"
using InventoryApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5926a299d34ace04a04f8a36dcb41a5c1b134b07", @"/Views/Inventory/ShowInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb7864d2c5639e7cea0ce74955da6728c43b935f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inventory_ShowInventory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventoryApp.Models.Classes.ClsParameter>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/bower_components/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
  
    ViewData["Title"] = "Result of Inventory" + " " + DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"callout callout-danger notification\">\r\n    <p class=\"showMgs\"></p>\r\n</div>\r\n\r\n<button type=\"button\" class=\"btn btn-default SpeceType hide\" data-toggle=\"modal\" data-target=\"#modal-default\"></button>\r\n\r\n<input type=\"hidden\" id=\"whsCode\"");
            BeginWriteAttribute("value", " value=\"", 496, "\"", 518, 1);
#nullable restore
#line 15 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
WriteAttributeValue("", 504, Model.whsCode, 504, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"itmsGrpCod\"");
            BeginWriteAttribute("value", " value=\"", 560, "\"", 585, 1);
#nullable restore
#line 16 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
WriteAttributeValue("", 568, Model.itmsGrpCod, 568, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"itemName\"");
            BeginWriteAttribute("value", " value=\"", 625, "\"", 648, 1);
#nullable restore
#line 17 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
WriteAttributeValue("", 633, Model.itemName, 633, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"categoryCode\"");
            BeginWriteAttribute("value", " value=\"", 692, "\"", 719, 1);
#nullable restore
#line 18 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
WriteAttributeValue("", 700, Model.categoryCode, 700, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"subCategoryCode\"");
            BeginWriteAttribute("value", " value=\"", 766, "\"", 796, 1);
#nullable restore
#line 19 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
WriteAttributeValue("", 774, Model.subCategoryCode, 774, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"stockVal\"");
            BeginWriteAttribute("value", " value=\"", 836, "\"", 859, 1);
#nullable restore
#line 20 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
WriteAttributeValue("", 844, Model.stockVal, 844, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

<div class=""row"">
    <div class=""col-lg-7"">
        <div class=""box box-primary collapsed-box collapseses"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Search</h3>

            <div class=""box-tools pull-right"">
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                    <i class=""fa fa-plus pluses""></i>
                </button>
            </div>
            <!-- /.box-tools -->
        </div>
        <!-- /.box-header -->
        <div class=""box-body"">
");
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label>WareHouse</label>
                            <select class=""form-control select2"" id=""whsCodes"" multiple=""multiple"" data-placeholder=""Select a State"" style=""width: 100%;"" required>
                            </select>
                        </div>
                    </div>

                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label>Stock</label><br />
                            <input type=""radio"" name=""in_stock"" class=""radioBtnClass"" id=""zero"" value=""0"" checked />
                            <label style=""font-weight: 500"" for=""zero"">Default</label> |
                            <input type=""radio"" name=""in_stock"" class=""radioBtnClass"" id=""one"" value=""1"" />
                            <label style=""font-weight: 500"" for=""one"">In-stock Only</label>
             ");
            WriteLiteral(@"           </div>
                    </div>

                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <label>Choose Brand</label>
                            <select class=""form-control select2"" id=""brand"" style=""width: 100%;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5926a299d34ace04a04f8a36dcb41a5c1b134b079481", async() => {
                WriteLiteral("Choose brand");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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

                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <label>Choose Category</label>
                            <select class=""form-control select2"" id=""category"" style=""width: 100%;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5926a299d34ace04a04f8a36dcb41a5c1b134b0711127", async() => {
                WriteLiteral("Choose category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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

                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <label>Choose Sub Category</label>
                            <select class=""form-control select2"" id=""subcategory"" style=""width: 100%;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5926a299d34ace04a04f8a36dcb41a5c1b134b0712784", async() => {
                WriteLiteral("Choose sub category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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

                    <div class=""col-lg-4"">
                        <div class=""form-group"">
                            <label for=""searchCodeorName"">Item Code or Name</label>
                            <input type=""text"" class=""form-control"" id=""codeorname"" placeholder=""Enter item code or name"">
                        </div>
                    </div>

                    <div class=""col-lg-2"">
                        <label style=""visibility: hidden"">Search</label>
                            <button type=""submit"" class=""btn btn-primary btn-flat"" id=""searchBtn"" style=""width:100%""><small class=""fa fa-search""></small> Search</button>
                    </div>
                </div>
");
            WriteLiteral(@"        </div>
        <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
    <div class=""col-lg-6""></div>

    <div class=""col-xs-12"">
        <div class=""box box-primary"">
            <div class=""box-body"">
                <table id=""tblInventory"" class=""table table-bordered table-hover"" style=""width:100%""></table>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->

</div>
<!-- /.row -->

<div class=""loading"">
    <div class=""lds-roller""><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>
</div>

<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""mod");
            WriteLiteral(@"al-title"">Space or Type</h4>
            </div>
            <div class=""modal-body"">
                <textarea class=""form-control"" id=""msg"" rows=""15"" disabled></textarea>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5926a299d34ace04a04f8a36dcb41a5c1b134b0716491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    var listInventory = [];\r\n    let cols = [];\r\n\r\n    $.ajax({\r\n        url: \'");
#nullable restore
#line 152 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
         Write(Url.Action("getInventory","Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
        type: 'GET',
        dataType: 'JSON',
        data: { whsCode: $('#whsCode').val(), itmsGrpCod: $('#itmsGrpCod').val(), itemName: $('#itemName').val(), categoryCode: $('#categoryCode').val(), subCategoryCode: $('#subCategoryCode').val(), stockVal: $('#stockVal').val() },
        success: function (data) {

            if(data == '') {
                window.location.replace('");
#nullable restore
#line 159 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
                                    Write(Url.Action("DataNotFound","Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
            }else{
                listInventory = [];

                listInventory = data;
                let inventoryRecord = listInventory[0];

                let keys = Object.keys(inventoryRecord);

                keys.forEach(function (k) {
                    cols.push({
                        title: k,
                        data: k
                    });

                });

                var table = $('#tblInventory').DataTable({
                    ""columns"": cols,
                    ""responsive"": {
                        breakpoints: [
                            { name: 'desktop', width: Infinity },
                            { name: 'tablet', width: 1024 },
                            { name: 'fablet', width: 768 },
                            { name: 'phone', width: 480 }
                        ]
                    },
                    ""responsive"": true,

                    //""responsive"": {
                    //    details: {
           ");
            WriteLiteral(@"         //        type: 'column',
                    //        target: -1
                    //    }
                    //},
                    //""columnDefs"": [{
                    //    className: 'dtr-control',
                    //    orderable: false,
                    //    targets: -1
                    //}],

                    ""lengthChange"": false, 
                    ""autoWidth"": true, 
                    ""searching"": true, 
                    ""paging"": true,
                    ""scrollY"": '60vh',
                    ""scrollX"": true,
                    ""scrollCollapse"": true,
                    buttons: [
                        { extend: 'excel', className: 'btn bg-olive btn-flat' }
                    ],
                    dom:
                        ""<'row'<'col-lg-0'l><'col-md-6'B><'col-md-6'f>>"" +
                        ""<'row'<'col-lg-12'tr>>"" +
                        ""<'row'<'col-lg-5'i><'col-md-7'p>>"",
                    lengthMenu: [
          ");
            WriteLiteral(@"              [25]
                    ],
                });
                
                table.rows.add(listInventory).draw();

            }
        }

    });
    
    $('#searchBtn').click(function(e) {
        e.preventDefault();
        loading();
        $('.collapseses').addClass('collapsed-box');
        $('.pluses').removeClass('fa-minus');
        $('.pluses').addClass('fa-plus');
        loadInventory();
    });

    var stock_value = 0;
    $(""input[type='radio'].radioBtnClass"").change(function () {
        if ($(""input[type='radio'].radioBtnClass"").is(':checked')) {
            stock_value = $(""input[type='radio'].radioBtnClass:checked"").val();
        }
    });
  
    function loadInventory() {
        
        let warehouse = $('#whsCodes').val();
        let brand = $('#brand').val();
        let category = $('#category').val();
        let subcategory = $('#subcategory').val();
        let codeorname = $('#codeorname').val();

        let warehouses = ");
            WriteLiteral("warehouse.toString();\r\n        if (codeorname == \'\') {\r\n            codeorname = \'empty\';\r\n        }\r\n        \r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 256 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
             Write(Url.Action("getInInventory","Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            data: { whsCodes: warehouses, itmsGrpCods: brand, itemNames: codeorname, categoryCodes: category, subCategoryCodes: subcategory, stockVal: stock_value },
            success: function (data) {
                //console.log(data);
                
                if (data == '') {
                    $('.showMgs').text('Data not found!');
                    $('.notification').addClass('active');
                    setTimeout(function () {
                        $('.notification').removeClass('active');
                        $('.showMgsNo').text('');
                    }, 3000)

                    if ($.fn.DataTable.isDataTable(""#tblInventory"")) {
                        $('#tblInventory').DataTable().clear().destroy();
                        $('#tblInventory').html('');
                    }

                    
                } else {
                    listInventory = [];

                    listInventor");
            WriteLiteral(@"y = data;
                    let inventoryRecord = listInventory[0];

                    let keys = Object.keys(inventoryRecord);

                    cols = [];
                    keys.forEach(function (k) {
                        cols.push({
                            title: k,
                            data: k
                        });

                    });
                    
                    if ($.fn.DataTable.isDataTable(""#tblInventory"")) {
                        $('#tblInventory').DataTable().clear().destroy();
                        $('#tblInventory').html('');
                    }
                    
                    var table = $('#tblInventory').DataTable({
                        ""columns"": cols,
                        ""columns"": cols,
                        ""responsive"": {
                            breakpoints: [
                                { name: 'desktop', width: Infinity },
                                { name: 'tablet', width: 1024 },");
            WriteLiteral(@"
                                { name: 'fablet', width: 768 },
                                { name: 'phone', width: 480 }
                            ]
                        },
                        ""responsive"": true,
                        ""lengthChange"": false,
                        ""autoWidth"": true,
                        ""searching"": true,
                        ""paging"": true,
                        ""scrollY"": '60vh',
                        ""scrollX"": true,
                        ""scrollCollapse"": true,
                        buttons: [
                            { extend: 'excel', className: 'btn bg-olive btn-flat' }
                        ],
                        dom:
                            ""<'row'<'col-md-0'l><'col-md-6'B><'col-md-6'f>>"" +
                            ""<'row'<'col-md-12'tr>>"" +
                            ""<'row'<'col-md-5'i><'col-md-7'p>>"",
                        lengthMenu: [
                            [25]
                        ");
            WriteLiteral(@"],
                    });
                    
                    table.rows.add(listInventory).draw();

                    $('th:nth-child(1)').css('width', '40px');
                }

            }

        });
    }

    var msg = 'The spece or type is empty.';
    $('body').on('click', 'li', function () {
        var table = $(this).closest('table').DataTable();
        var text = table.row($(this).closest('li')).data()['SpaceOrType'];
        if (text != '') {
            $('#msg').text(text);
            $('.SpeceType').click();
            $('.notification').removeClass('active');
        } else {
            $('.showMgs').text(msg);
            $('.notification').addClass('active');
            setTimeout(function() {
                $('.notification').removeClass('active');
                $('.showMgs').text('');
            }, 5000);
        }
    });

    $('body').on('dblclick', 'td', function () {
        var table = $(this).closest('table').DataTable();
      ");
            WriteLiteral(@"  var text = table.row($(this).closest('tr')).data()['SpaceOrType'];
        if (text != '') {
            $('#msg').text(text);
            $('.SpeceType').click();
            $('.notification').removeClass('active');
        } else {
            $('.showMgs').text(msg);
            $('.notification').addClass('active');
            setTimeout(function() {
                $('.notification').removeClass('active');
                $('.showMgs').text('');
            }, 5000);        }
    });

    $(window).scroll(function() {
        var scrollTop = $(window).scrollTop();
        if(scrollTop > 300) {
            $('.to-top').addClass('active');        } 
        else {
            $('.to-top').removeClass('active');
        }
    });

    function loading() {
        $('.loading').addClass('active');

        setTimeout(function () {
            $('.loading').removeClass('active');
        }, 1200)
    }

    // Loading
    $(window).on('load', function () {
        loading(");
            WriteLiteral(@");
    });

</script>

<script type=""text/javascript"">

    $(document).ready(function () {

        //Initialize Select2 Elements
        $('.select2').select2();

        $(':input[type=""submit""]').prop('disabled', true);

        $('#brand').change(function () {
            let category = $('#category').val();
            if ($(this).val() == '0' && category == '0') {
                $('button[type=""submit""]').prop('disabled', true);
            } else {
                $('button[type=""submit""]').prop('disabled', false);
            }

        });

        $('#category').change(function () {
            let brand = $('#brand').val();
            if ($(this).val() == '0' && brand == '0') {
                $('button[type=""submit""]').prop('disabled', true);
            } else {
                $('button[type=""submit""]').prop('disabled', false);
            }
        });

        $('#category').change(function () {
            var id = $('#category').val();
            $.ajax");
            WriteLiteral("({\r\n                url: \'");
#nullable restore
#line 429 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
                 Write(Url.Action("getCategoryFilter","Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'GET',
                dataType: 'JSON',
                data: { code: id },
                success: function (data) {
                    $('#subcategory').empty();
                    $('#subcategory').append('<option value=""0"" selected=""selected"">Choose sub category</option>');
                    for (i = 0; i < data.length; i++) {
                        $('#subcategory').append('<option value=""' + data[i].subCategoryCode + '"">' + data[i].subCategoryName + '</option>');
                    }
                }
            })
        });


        $('input[type=""text""]').keyup(function () {
            var value = $(this).val();
            let brand = $('#brand').val();
            let category = $('#category').val();
            if (value.length >= 3 && value != '') {
                $(':input[type=""submit""]').prop('disabled', false);
            } else {
                if (brand != '0' || category != '0') {
                    $(':input[type=""submit""]').");
            WriteLiteral("prop(\'disabled\', false);\r\n                } else {\r\n                    $(\':input[type=\"submit\"]\').prop(\'disabled\', true);\r\n                }\r\n            }\r\n\r\n        });\r\n\r\n        //Fetch Warehouse\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 462 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
             Write(Url.Action("getWareHouse","Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            success: function (data) {
                //console.log(data)
                for (i = 0; i < data.length; i++) {
                    //console.log(data[i].whsCode);
                    $('#whsCodes').append('<option value=""' + data[i].whsCode + '"" selected>' + data[i].whsName + '</option>');
                }
            }
        });

        //Fetch Brand
        $.ajax({
            url: '");
#nullable restore
#line 476 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
             Write(Url.Action("getBrand","Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            success: function (data) {
                for (var i = 0; i < data.length; i++) {
                    //console.log(data[i].itmsGrpCod);
                    $('#brand').append('<option value=""' + data[i].itmsGrpCod + '"">' + data[i].itmsGrpNam + '</option>');
                }
            }
        });

        //Fetch Category
        $.ajax({
            url: '");
#nullable restore
#line 489 "C:\Users\Admin\source\repos\InventoryApp\InventoryApp\Views\Inventory\ShowInventory.cshtml"
             Write(Url.Action("getCategory","Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            success: function (data) {
                //console.log(data);
                for (var i = 0; i < data.length; i++) {
                    //console.log(data[i].code);
                    $('#category').append('<option value=""' + data[i].categoryCode + '"">' + data[i].categoryName + '</option>');
                }
            }
        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventoryApp.Models.Classes.ClsParameter> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
