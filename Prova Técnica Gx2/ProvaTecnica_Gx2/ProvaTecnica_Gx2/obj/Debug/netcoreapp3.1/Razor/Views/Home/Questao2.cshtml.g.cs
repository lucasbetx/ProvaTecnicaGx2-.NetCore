#pragma checksum "C:\Users\Computador\Desktop\Prova Técnica Gx2\ProvaTecnica_Gx2\ProvaTecnica_Gx2\Views\Home\Questao2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e73747066a27d2569ef022953953c976e3147ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Questao2), @"mvc.1.0.view", @"/Views/Home/Questao2.cshtml")]
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
#line 1 "C:\Users\Computador\Desktop\Prova Técnica Gx2\ProvaTecnica_Gx2\ProvaTecnica_Gx2\Views\_ViewImports.cshtml"
using ProvaTecnica_Gx2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Computador\Desktop\Prova Técnica Gx2\ProvaTecnica_Gx2\ProvaTecnica_Gx2\Views\_ViewImports.cshtml"
using ProvaTecnica_Gx2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e73747066a27d2569ef022953953c976e3147ce", @"/Views/Home/Questao2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"586cc3600ce5f3219dbb9fe9a7e5f6323c098a80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Questao2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.0/jquery.mask.js""></script>
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""#"" crossorigin=""anonymous"">

<style>

    .cpfAcpt {
        color: green;
    }

    .cpfError {
        color: red;
    }

    #interno {
        background-color: white;
        border-bottom-left-radius: 10px;
        border-bottom-right-radius: 10px;
        padding: 30px;
        border-left-style: solid;
        border-right-style: solid;
        border-bottom-style: solid;
        text-align: center;
    }

    .Button {
        margin-top: 2%;
    }

    .TecCpf {
        text-align: center;
        background-color: #12AAAB;
        margin-top: 10%;
        border-top-left-radius: 10px;
        border-top-right-radius: 10px;
        border-color");
            WriteLiteral(@": black;
        border-style: solid;
        padding-top: 30px;
        color: white;
    }

    .modal-content {
        border-radius: 10px;
    }

    .modal-header {
        background-color: #12AAAB;
        color: white;
        border-right-style: solid;
        border-left-style: solid;
        border-top-style: solid;
        border-color: black;
    }

    .modal-body {
        border-right-style: solid;
        border-left-style: solid;
        border-top-style: solid;
    }

    .modal-footer {
        border-right-style: solid;
        border-left-style: solid;
        border-bottom-style: solid;
    }
</style>

<div class=""TecCpf"">

    <h4><strong><i class=""fa fa-user""></i> Prova Técnica - Teste CPF !</strong></h4> <br /><br />
</div>

<div id=""interno"">

    <input type=""text"" placeholder=""Insira seu CPF"" class=""cpfInput form-control-sm"" id=""Cpf"" autocomplete=""off"" /> <br />

    <button class=""buttonCpf Button btn btn-primary"" data-toggle=""modal"" data");
            WriteLiteral(@"-target=""#exampleModal"">Conferir Cpf</button>

</div>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel""><strong><i class=""fa fa-user""></i> Teste CPF</strong></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div hidden class=""cpfSuccess"">
                    CPF : <strong><label class=""showCpfEr"" id=""showCpfEr""></label></strong><br />
                    <label class=""cpfAcpt""><strong>CPF preenchido!!</strong></label>
                </div>
                <div hidden class=""showCpfSuc"">
                    <label class=""cpfError""");
            WriteLiteral(@"><strong>Erro! Por favor, insira o CPF!!</strong></label>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>


<script>

    $(""#Cpf"").mask(""999.999.999-99"");

    var confCpf;

    $('.buttonCpf').click(function () {

        confCpf = $("".cpfInput"").val();

        console.log(confCpf.length)

        //Na condição foi necessario colocar um diferente de 14, e não 11 como pedido, pois os pontos e hifen, que contam como caracteres.

        if (confCpf.length != ""14"") {
            $('.showCpfSuc').removeAttr('hidden')
            $('.cpfSuccess').attr('hidden', true)
        }
        else {
            $('.cpfSuccess').removeAttr('hidden')
            $('.showCpfSuc').attr('hidden', true)
            document.getElementById('showCpfEr').innerText = confCpf;
        }

    })

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
