#pragma checksum "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\Pages\ParameterParent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "259d6c15459cd69abbc24b7b2a17172044dff2ce"
// <auto-generated/>
#pragma warning disable 1591
namespace GenerateHashCode.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using GenerateHashCode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using GenerateHashCode.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/parameter-parent")]
    public partial class ParameterParent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Child component (without attribute values)</h1>\r\n\r\n");
            __builder.OpenComponent<GenerateHashCode.Shared.ParameterChild>(1);
            __builder.AddAttribute(2, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\Pages\ParameterParent.razor"
                       title

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<h1>Child component (with attribute values)</h1>\r\n\r\n");
            __builder.OpenComponent<GenerateHashCode.Shared.ParameterChild>(5);
            __builder.AddAttribute(6, "Title", "Set by Parent");
            __builder.AddAttribute(7, "Body", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GenerateHashCode.Pages.PanelBody>(
#nullable restore
#line 10 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\Pages\ParameterParent.razor"
                        new PanelBody() { Text = "Set by parent.", Style = "italic" }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\Pages\ParameterParent.razor"
      
    private string title = "Test";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
