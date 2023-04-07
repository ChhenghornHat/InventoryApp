#pragma checksum "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74e1215d94113a9f24d39d196f1545cc5d86dbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Index), @"mvc.1.0.view", @"/Views/Inventory/Index.cshtml")]
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
#nullable restore
#line 1 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74e1215d94113a9f24d39d196f1545cc5d86dbe", @"/Views/Inventory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb7864d2c5639e7cea0ce74955da6728c43b935f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inventory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 3 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
  
    ViewData["Title"] = "Result of Inventory" + " " + DateTime.Now;

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

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""box box-primary collapseses"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Search</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus pluses""></i>
                    </button>
                </div>
                <!-- /.box-tools -->
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label>WareHouse</label>
     ");
            WriteLiteral(@"                       <select class=""form-control select2"" id=""whsCodes"" multiple=""multiple"" data-placeholder=""Select a State"" style=""width: 100%;"" required>
                            </select>
                        </div>
                    </div>

                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label>Stock</label><br/>
                            <input type=""radio"" name=""in_stock"" class=""radioBtnClass"" id=""zero"" value=""0"" checked/>
                            <label style=""font-weight: 500"" for=""zero"">Default</label> |
                            <input type=""radio"" name=""in_stock"" class=""radioBtnClass"" id=""one"" value=""1""/>
                            <label style=""font-weight: 500"" for=""one"">In-stock Only</label>
                        </div>
                    </div>

                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <label>Choose Brand</");
            WriteLiteral("label>\r\n                            <select class=\"form-control select2\" id=\"brand\" style=\"width: 100%;\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74e1215d94113a9f24d39d196f1545cc5d86dbe7033", async() => {
                WriteLiteral("Choose Brand");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74e1215d94113a9f24d39d196f1545cc5d86dbe8679", async() => {
                WriteLiteral("All");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74e1215d94113a9f24d39d196f1545cc5d86dbe10323", async() => {
                WriteLiteral("All");
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
                            <label for=""codeorname"">Item Code or Name</label>
                            <input type=""text"" class=""form-control"" id=""codeorname"" placeholder=""Enter item code or name"">
                            <input type=""hidden"" id=""database""");
            BeginWriteAttribute("value", " value=\"", 3759, "\"", 3829, 1);
#nullable restore
#line 85 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
WriteAttributeValue("", 3767, HttpContextAccessor.HttpContext.Session.GetString("Database"), 3767, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" id=\"usercode\"");
            BeginWriteAttribute("value", " value=\"", 3895, "\"", 3965, 1);
#nullable restore
#line 86 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
WriteAttributeValue("", 3903, HttpContextAccessor.HttpContext.Session.GetString("UserCode"), 3903, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" id=\"username\"");
            BeginWriteAttribute("value", " value=\"", 4031, "\"", 4101, 1);
#nullable restore
#line 87 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
WriteAttributeValue("", 4039, HttpContextAccessor.HttpContext.Session.GetString("Username"), 4039, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" id=\"ip\"");
            BeginWriteAttribute("value", " value=\"", 4161, "\"", 4225, 1);
#nullable restore
#line 88 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
WriteAttributeValue("", 4169, HttpContextAccessor.HttpContext.Session.GetString("Ip"), 4169, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" id=\"cmpName\"");
            BeginWriteAttribute("value", " value=\"", 4290, "\"", 4363, 1);
#nullable restore
#line 89 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
WriteAttributeValue("", 4298, HttpContextAccessor.HttpContext.Session.GetString("CompanyName"), 4298, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" id=\"priceList\"");
            BeginWriteAttribute("value", " value=\"", 4430, "\"", 4499, 1);
#nullable restore
#line 90 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
WriteAttributeValue("", 4438, HttpContextAccessor.HttpContext.Session.GetString("U_Price"), 4438, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>

                    <div class=""col-lg-2"">
                        <label style=""visibility: hidden"">Search</label>
                        <button type=""submit"" class=""btn btn-primary btn-flat"" id=""searchBtn"" style=""width:100%"" disabled=""disabled"">Search <small class=""fa fa-search""></small></button>
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
                <table id=""tblInventory"" class=""table table-bordered "" style=""width:100%""></table>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->

</div>
<!-- /.row -->

<div class=""modal fade"" id=""modal-space"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""mo");
            WriteLiteral(@"dal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">Image and Space</h4>
            </div>
            <div class=""modal-body"">
                <!-- Swiper -->
                <div class=""swiper mySwiper"">
                    <div class=""swiper-wrapper"">
                    </div>
                    <div class=""swiper-pagination""></div>
                </div>
                <br>
                <textarea class=""form-control"" id=""space"" rows=""15"" readonly></textarea>
                <h4 class=""space-msg""></h4>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger close-modal"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<");
            WriteLiteral(@"!-- Swiper JS -->
<script src=""https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.js""></script>

<!-- Initialize Swiper -->
<script>
    var swiper = new Swiper("".mySwiper"", {
        effect: ""coverflow"",
        grabCursor: true,
        centeredSlides: true,
        slidesPerView: ""auto"",
        autoplay: {
            delay: 2500,
            disableOnInteraction: false,
        },
        coverflowEffect: {
            rotate: 50,
            stretch: 0,
            depth: 100,
            modifier: 1,
            slideShadows: true,
        },
        pagination: {
            el: "".swiper-pagination"",
        },
    });
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74e1215d94113a9f24d39d196f1545cc5d86dbe17694", async() => {
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
            WriteLiteral(@"

<script type=""text/javascript"">

    let listInventory = [];
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
    
    $('#searchBtn').click(function(e) {
        e.preventDefault();

        $('.collapseses').addClass('collapsed-box');
        $('.pluses').removeClass('fa-minus');
        $('.pluses').addClass('fa-plus');
        loadInventory();
        InvLog();
    });
    
    $(document).keypress(function(event){
        let keycode = (event.keyCode ? event.keyCode : event.which);
        if(keycode == '13'){
           //alert('You pressed a ENTER key.');
           event.preventDefault();
           if ($('#brand').val() == '0' && $('#category')");
            WriteLiteral(@".val() == '0' && $('#subcategory').val() == '0' && $('#codeorname').val() == '') {
               alert(""Please choose one item to continue"");
           } else {
               $('.collapseses').addClass('collapsed-box');
              $('.pluses').removeClass('fa-minus');
              $('.pluses').addClass('fa-plus');
              loadInventory();
              InvLog();
           }
          
        }
    });

    let stock_value = 0;
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
        let database = $('#database').val();
 ");
            WriteLiteral("       let priceList = $(\'#priceList\').val();\r\n\r\n        let warehouses = warehouse.toString();\r\n        if (codeorname === \"\") {\r\n            codeorname = \'empty\';\r\n        }\r\n        \r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 252 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
             Write(Url.Action("GetInventory", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            data: { whsCode: warehouses, itmsGrpCod: brand, itemName: codeorname, categoryCode: category, subCategoryCode: subcategory, stockVal: stock_value, database: database, priceList: priceList },
            beforeSend: function () {
                setTimer();
            },
            success: function (data) {
                // check whether data have or not
                if (data == """") {
                    if ($.fn.DataTable.isDataTable(""#tblInventory"")) {
                        $('#tblInventory').DataTable().clear().destroy();
                        $('#tblInventory').html('');
                    }
                    $('#tblInventory').html('<h4 class=""text-danger text-center"">No matching records found!</h4>');
                    clearTimer();
                    
                } else {
                    $('#tblInventory').html('');
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

                    function responsive(maxWidth) {
                        if ($.fn.DataTable.isDataTable(""#tblInventory"")) {
                            $('#tblInventory').DataTable().clear().destroy();
                            $('#tblInventory').html('');
                        }
                        if (maxWidth.matches) {
                            let table = $('#tb");
            WriteLiteral(@"lInventory').DataTable({
                                ""columns"": cols,
                                ""responsive"": true,
                                ""lengthChange"": false,
                                ""autoWidth"": true,
                                ""searching"": false,
                                ""paging"": false,
                                ""scrollY"": '60vh',
                                ""scrollX"": false,
                                ""scrollCollapse"": true,
                                ""columnDefs"": [
                                    { visible: false, targets: 1 },
                                ],
                                buttons: [
                                    { extend: 'excel', className: 'btn bg-olive btn-flat' },
                                ],
                                dom:
                                    ""<'row'<'col-md-0'l><'col-md-6'B><'col-md-6'f>>"" +
                                    ""<'row'<'col-md-12'tr>>"" +
      ");
            WriteLiteral(@"                              ""<'row'<'col-md-5'i><'col-md-7'p>>"",
                            });

                            table.rows.add(listInventory).draw();

                            table.on('click', 'tr', function () {
                                //var data = table.row(this).data();
                                // below some operations with the data
                                // How can I set the row color as red?
                                $(this).addClass('bg-green').siblings().removeClass('bg-green');
                            });
                        } else {
                            if ($.fn.DataTable.isDataTable(""#tblInventory"")) {
                                $('#tblInventory').DataTable().clear().destroy();
                                $('#tblInventory').html('');
                            }
                            let table = $('#tblInventory').DataTable({
                                ""columns"": cols,
                            ");
            WriteLiteral(@"    ""responsive"": false,
                                ""lengthChange"": true,
                                ""autoWidth"": true,
                                ""searching"": true,
                                ""paging"": false,
                                ""scrollY"": '60vh',
                                ""scrollX"": true,
                                ""scrollCollapse"": true,
                                ""columnDefs"": [
                                    { visible: false, targets: 1 }
                                ],
                                buttons: [
                                    { extend: 'excel', className: 'btn bg-olive btn-flat' },
                                ],
                                dom:
                                    ""<'row'<'col-md-0'l><'col-md-6'B><'col-md-6'f>>"" +
                                    ""<'row'<'col-md-12'tr>>"" +
                                    ""<'row'<'col-md-5'i><'col-md-7'p>>"",
                            });

    ");
            WriteLiteral(@"                        table.rows.add(listInventory).draw();

                            table.on('click', 'tr', function () {
                                //var data = table.row(this).data();
                                // below some operations with the data
                                // How can I set the row color as red?
                                $(this).addClass('bg-green').siblings().removeClass('bg-green');
                            });
                        }
                    }

                    let maxWidth = window.matchMedia(""(max-width: 768px)"");

                    responsive(maxWidth);
                    maxWidth.addListener(responsive);
                }

            },
            complete: function() {
                resetTimer();
            }

        });
    }

    $(document).on('dblclick', 'td', function() {
        var table = $(this).closest('table').DataTable();
        var folderName = table.row($(this).closest('tr')).data()[");
            WriteLiteral(@"'ItemCode'];
        var space = table.row($(this).closest('tr')).data()['SpaceOrType'];
        
        $('#modal-space').modal({
            backdrop: 'static',
            keyboard: true,
            show: true
        });
        if (space !== """") {
            $('#space').css('display', 'block');
            $('#space').text(space);
            $('.space-msg').text('');
        } else {
            $('#space').css('display', 'none');
            $('.space-msg').text('No space or type');
        }
        
        $.ajax({
            url: '");
#nullable restore
#line 400 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
             Write(Url.Action("CallImage", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            data: {folderName: folderName},
            beforeSend: function() {
                setTimer();
            },
            success: function(data) {
                resetTimer();
                for (let i = 0;i < data.length;i++) {
                    $(`<div class=""swiper-slide"">
                           <img src=""${data[i].imageName}""/>
                       </div>`).appendTo('.swiper-wrapper');
                }
           },
           error: function(data){
               resetTimer();
               $(`<div class=""swiper-slide"">
                  <h3>No image found!</h3>
              </div>`).appendTo('.swiper-wrapper');
           }
        });
        
        $('.close-modal, .close').click(function() {
            $('.swiper-slide').remove();
        });
        
    });
    
    $(document).on('click', 'li', function() {
        var table = $(this).closest('table').DataTable();
        var fol");
            WriteLiteral(@"derName = table.row($(this).closest('li')).data()['ItemCode'];
        var space = table.row($(this).closest('li')).data()['SpaceOrType'];
        
        $('#modal-space').modal({
            backdrop: 'static',
            keyboard: true,
            show: true
        });
        if (space !== """") {
            $('#space').css('display', 'block');
            $('#space').text(space);
            $('.space-msg').text('');
        } else {
            $('#space').css('display', 'none');
            $('.space-msg').text('No space or type');
        }
        
        $.ajax({
            url: '");
#nullable restore
#line 449 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
             Write(Url.Action("CallImage", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            data: {folderName: folderName},
            beforeSend: function() {
                setTimer();
            },
            success: function(data) {
                resetTimer();
                for (let i = 0;i < data.length;i++) {
                    $(`<div class=""swiper-slide"">
                           <img src=""${data[i].imageName}"" alt=""img-slide""/>
                       </div>`).appendTo('.swiper-wrapper');
                }
           },
           error: function(){
               resetTimer();
               $(`<div class=""swiper-slide"">
                  <h3>No image found!</h3>
              </div>`).appendTo('.swiper-wrapper');
           }
        });
        
        $('.close-modal, .close').click(function() {
            $('.swiper-slide').remove();
        });
        
    });
    
    function InvLog() {
        
        $.ajax({
            url: '");
#nullable restore
#line 481 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
             Write(Url.Action("IvnLog", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'POST',
            dataType: 'JSON',
            data: {brand: $('#brand option:selected').text(), 
                category: $('#category option:selected').text(), 
                subCategory: $('#subcategory option:selected').text(),
                code: $('#codeorname').val(),
                usercode: $('#usercode').val(),
                username: $('#username').val(),
                ip: $('#ip').val(),
                cmpName: $('#cmpName').val(),
            },
            beforeSend: function() {
                console.log(""Loading..."");
            },
            success: function(data) {
                console.log(data)
            }
        });
    }

    $(window).scroll(function() {
        let scrollTop = $(window).scrollTop();
        if(scrollTop > 50) {
            $('.to-top').addClass('active');        } 
        else {
            $('.to-top').removeClass('active');
        }
    });

</script>

<script type=""text/javascript"">
   ");
            WriteLiteral(@" $(document).ready(function() {
        $('.select2').select2();

        let codeOrName = $('input[type=""text""]').val();
        
        if (codeOrName === '') {
            $('button[type=""submit""]').prop('disabled', true);
        }
        
        $('#brand').change(function () {
            let category = $('#category').val(); 
            if ($(this).val() === '0' && category === '0' && codeOrName === """") {
                $('button[type=""submit""]').prop('disabled', true);
            } else {
                $('button[type=""submit""]').prop('disabled', false);
            }
        });

        $('#category').change(function () {
            let brand = $('#brand').val();
            if ($(this).val() === '0' && brand === '0' && codeOrName === """") {
                $('button[type=""submit""]').prop('disabled', true);
            } else {
                $('button[type=""submit""]').prop('disabled', false);
            }
        });

        $('#category').change(function () {
 ");
            WriteLiteral("           let id = $(\'#category\').val();\r\n            let database = $(\'#database\').val();\r\n            $.ajax({\r\n                url: \'");
#nullable restore
#line 545 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
                 Write(Url.Action("GetCategoryFilter", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'GET',
                dataType: 'JSON',
                data: { code: id, database: database },
                success: function (data) {
                    //console.log(data)
                    $('#subcategory').empty();
                    $('#subcategory').append('<option value=""0"" selected=""selected"">Choose sub category</option>');
                    for (let i = 0; i < data.length; i++) {
                        $('#subcategory').append('<option value=""' + data[i].subCategoryCode + '"">' + data[i].subCategoryName + '</option>');
                    }
                }
            })
        });

        $('input[type=""text""]').keyup(function () {
            let value = $(this).val();
            let brand = $('#brand').val();
            let category = $('#category').val();
            if (value.length >= 3 && value != '') {
                $(':input[type=""submit""]').prop('disabled', false);
            } else {
                if (brand != '0' || cate");
            WriteLiteral(@"gory != '0') {
                    $(':input[type=""submit""]').prop('disabled', false);
                } else {
                    $(':input[type=""submit""]').prop('disabled', true);
                }
            }

        });

        //Fetch Warehouse
        $.ajax({
            url: '");
#nullable restore
#line 578 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
             Write(Url.Action("GetWareHouse", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            success: function (data) {
                //console.log(data)
                let whsCode = '1,2,3,4';
                let test = whsCode.split(',');
                
                //console.log(test)
                for (let i = 0; i < data.length; i++) {
                    //console.log(data[i].whsCode);
                    // $('#whsCodes').append('<option value=""' + data[i].whsCode + '"" selected>' + data[i].whsName + '</option>');
                    
                    $('#whsCodes').append(`<option value=""${data[i].whsCode}"" ${data[i].whsCode == 1 ? 'selected' : ''}>${data[i].whsName}</option>`);
                    //console.log(test[i]);
                }
            }
        });

        //Fetch Brand
        $.ajax({
            url: '");
#nullable restore
#line 599 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
             Write(Url.Action("GetBrand", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            success: function (data) {
                for (let i = 0; i < data.length; i++) {
                    //console.log(data[i].itmsGrpCod);
                    $('#brand').append('<option value=""' + data[i].itmsGrpCod + '"">' + data[i].itmsGrpNam + '</option>');
                }
            }
        });

        //Fetch Category
        $.ajax({
            url: '");
#nullable restore
#line 612 "D:\PTC-Computer\InventoryApp\InventoryApp\Views\Inventory\Index.cshtml"
             Write(Url.Action("GetCategory", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: 'GET',
            dataType: 'JSON',
            success: function (data) {
                for (let i = 0; i < data.length; i++) {
                    //console.log(data[i].code);
                    $('#category').append('<option value=""' + data[i].categoryCode + '"">' + data[i].categoryName + '</option>');
                }
            }
        });
    });
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
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
