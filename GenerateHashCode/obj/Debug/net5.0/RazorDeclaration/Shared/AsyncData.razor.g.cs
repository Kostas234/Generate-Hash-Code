// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GenerateHashCode.Shared
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
    public partial class AsyncData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\GitRepository\Generate-Hash-Code\GenerateHashCode\Shared\AsyncData.razor"
 
  string text = string.Empty;
  [Parameter] public Task<string> TextService { get; set; }

  protected override async Task OnInitializedAsync()
  {
    text = await TextService;
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
