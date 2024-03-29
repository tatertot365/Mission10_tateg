#pragma checksum "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867750efdf302d977f054a4ad7dffd118ff816fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mission09_BookStore.Models.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace Mission09_BookStore.Models
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867750efdf302d977f054a4ad7dffd118ff816fc", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a35bf27d84b724ffeb148703a3e0574755d2f7e8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your cart</h2>

<!--I added the table being dark and that the background changes to a light grey when the user hoevers over an item-->
<table class=""table table-dark table-hover"">
    <thead>
        <tr>
            <th>Book</th>
            <th>Quantity</th>
            <td>Cost</td>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 20 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
         for (int i = 0; i < Model.basket.Items.Count; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
             if (i == Model.basket.Items.Count - 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- I added an if statement that uses bootstrap that shows the newest item added to the cart using a bootstrap badge that says new -->\n                <tr>\n                    <td>");
#nullable restore
#line 26 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
                   Write(Model.basket.Items[i].Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"badge badge-secondary p-1 m-1\">New</span></td>\n                    <td>");
#nullable restore
#line 27 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
                   Write(Model.basket.Items[i].Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
                   Write(Model.basket.Items[i].Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
                    Write(Model.basket.Items[i].Quantity * Model.basket.Items[i].Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 31 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 35 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
                   Write(Model.basket.Items[i].Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 36 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
                   Write(Model.basket.Items[i].Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 37 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
                   Write(Model.basket.Items[i].Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 38 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
                    Write(Model.basket.Items[i].Quantity * Model.basket.Items[i].Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 40 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n        <tfoot>\n            <tr>\n                <td colspan=\"3\">Total:</td>\n                <td>");
#nullable restore
#line 46 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
               Write(Model.basket.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n        </tfoot>\n    </table>\n\n<div>\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1732, "\"", 1755, 1);
#nullable restore
#line 52 "/Users/tategillespie/Desktop/IS 413/Missions/Mission10-Bookstore/Mission09-BookStore/Pages/Cart.cshtml"
WriteAttributeValue("", 1739, Model.ReturnUrl, 1739, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission09_BookStore.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission09_BookStore.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission09_BookStore.Pages.CartModel>)PageContext?.ViewData;
        public Mission09_BookStore.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
