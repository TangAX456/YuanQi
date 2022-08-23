#pragma checksum "F:\ScoreManager\ScoreManager.WebApp\Views\Teacher\RoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b60df99a8fefacd3638dad4e9ddf28e3fdf9c0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_RoleList), @"mvc.1.0.view", @"/Views/Teacher/RoleList.cshtml")]
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
#line 1 "F:\ScoreManager\ScoreManager.WebApp\Views\_ViewImports.cshtml"
using ScoreManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ScoreManager\ScoreManager.WebApp\Views\_ViewImports.cshtml"
using ScoreManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b60df99a8fefacd3638dad4e9ddf28e3fdf9c0f", @"/Views/Teacher/RoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebc828530f807eb7ccfc8fb1955cabd08d258795", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Teacher_RoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\ScoreManager\ScoreManager.WebApp\Views\Teacher\RoleList.cshtml"
  
    ViewData["Title"] = "教师角色";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""layui-fluid"">
    <div class=""layui-row layui-col-space15"">
        <div class=""layui-col-md12"">
            <div class=""layui-card"">
                <div class=""layui-card-header"">
                    <button class=""layui-btn layui-btn-danger"" onclick=""delAll()""><i class=""layui-icon""></i>批量删除</button>
                    <button class=""layui-btn"" onclick=""xadmin.open('添加角色','/Teacher/AddRole',600,400)""><i class=""layui-icon""></i>添加</button>
                </div>
                <div class=""layui-card-body "">
                    <table class=""layui-table layui-form"">
                        <thead>
                            <tr>
                                <th>
                                    <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 805, "\"", 812, 0);
            EndWriteAttribute();
            WriteLiteral(@" lay-skin=""primary"">
                                </th>
                                <th>ID</th>
                                <th>角色名称</th>
                                <th>角色描述</th>
                                <th>加入时间</th>
                                <th>状态</th>
                                <th>操作</th>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <input type=""checkbox""");
            BeginWriteAttribute("name", " name=\"", 1347, "\"", 1354, 0);
            EndWriteAttribute();
            WriteLiteral(@" lay-skin=""primary"">
                                </td>
                                <td>1</td>
                                <td>admin</td>
                                <td>123456789</td>
                               
                                <td>2017-01-01 11:11:42</td>
                                <td class=""td-status"">
                                    <span class=""layui-btn layui-btn-normal layui-btn-mini"">已启用</span>
                                </td>
                                <td class=""td-manage"">
                                    <a onclick=""member_stop(this,'10001')"" href=""javascript:;"" title=""启用"">
                                        <i class=""layui-icon"">&#xe601;</i>
                                    </a>
                                    <a title=""编辑"" onclick=""xadmin.open('编辑','admin-edit.html')"" href=""javascript:;"">
                                        <i class=""layui-icon"">&#xe642;</i>
                                    </a>
       ");
            WriteLiteral(@"                             <a title=""删除"" onclick=""member_del(this,'要删除的id')"" href=""javascript:;"">
                                        <i class=""layui-icon"">&#xe640;</i>
                                    </a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class=""layui-card-body "">
                    <div class=""page"">
                        <div>
                            <a class=""prev""");
            BeginWriteAttribute("href", " href=\"", 2922, "\"", 2929, 0);
            EndWriteAttribute();
            WriteLiteral(">&lt;&lt;</a>\r\n                            <a class=\"num\"");
            BeginWriteAttribute("href", " href=\"", 2987, "\"", 2994, 0);
            EndWriteAttribute();
            WriteLiteral(">1</a>\r\n                            <span class=\"current\">2</span>\r\n                            <a class=\"num\"");
            BeginWriteAttribute("href", " href=\"", 3105, "\"", 3112, 0);
            EndWriteAttribute();
            WriteLiteral(">3</a>\r\n                            <a class=\"num\"");
            BeginWriteAttribute("href", " href=\"", 3163, "\"", 3170, 0);
            EndWriteAttribute();
            WriteLiteral(">489</a>\r\n                            <a class=\"next\"");
            BeginWriteAttribute("href", " href=\"", 3224, "\"", 3231, 0);
            EndWriteAttribute();
            WriteLiteral(@">&gt;&gt;</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    

    /*用户-停用*/
    function member_stop(obj, id) {
        layer.confirm('确认要停用吗？', function(index) {

            if ($(obj).attr('title') == '启用') {

                //发异步把用户状态进行更改
                $(obj).attr('title', '停用')
                $(obj).find('i').html('&#xe62f;');

                $(obj).parents(""tr"").find("".td-status"").find('span').addClass('layui-btn-disabled').html('已停用');
                layer.msg('已停用!', { icon: 5, time: 1000 });

            } else {
                $(obj).attr('title', '启用')
                $(obj).find('i').html('&#xe601;');

                $(obj).parents(""tr"").find("".td-status"").find('span').removeClass('layui-btn-disabled').html('已启用');
                layer.msg('已启用!', { icon: 5, time: 1000 });
            }

        });
    }

    /*用户-删除*/
    function member_del(obj, id) ");
            WriteLiteral(@"{
        layer.confirm('确认要删除吗？', function(index) {
            //发异步删除数据
            $(obj).parents(""tr"").remove();
            layer.msg('已删除!', { icon: 1, time: 1000 });
        });
    }



    function delAll(argument) {

        var data = tableCheck.getData();

        layer.confirm('确认要删除吗？' + data, function(index) {
            //捉到所有被选中的，发异步进行删除
            layer.msg('删除成功', { icon: 1 });
            $("".layui-form-checked"").not('.header').parents('tr').remove();
        });
    }
</script>
<script>
    var _hmt = _hmt || []; (function() {
        var hm = document.createElement(""script"");
        hm.src = ""https://hm.baidu.com/hm.js?b393d153aeb26b46e9431fabaf0f6190"";
        var s = document.getElementsByTagName(""script"")[0];
        s.parentNode.insertBefore(hm, s);
    })();</script>
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
