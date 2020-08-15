#pragma checksum "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Shared\BookList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6526ce79f2bc70a2e7b5a1aa19524f264f22000"
// <auto-generated/>
#pragma warning disable 1591
namespace HMS.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using HMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using HMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using HMS.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\_Imports.razor"
using HMS.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class BookList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "checkbox");
            __builder.AddAttribute(2, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Shared\BookList.razor"
                                  displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayButtons = __value, displayButtons));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n   ");
            __Blazor.HMS.Client.Shared.BookList.TypeInference.CreateGenericList_0(__builder, 5, 6, 
#nullable restore
#line 4 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Shared\BookList.razor"
                      book

#line default
#line hidden
#nullable disable
            , 7, (book_) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n           ");
                __builder2.OpenComponent<HMS.Client.Shared.IndividualBookList>(9);
                __builder2.AddAttribute(10, "book", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HMS.Client.Helpers.Books>(
#nullable restore
#line 6 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Shared\BookList.razor"
                                      book_ 

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "DisplayButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Shared\BookList.razor"
                                                              displayButtons

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "DeleteBooks", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<HMS.Client.Helpers.Books>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<HMS.Client.Helpers.Books>(this, 
#nullable restore
#line 6 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Shared\BookList.razor"
                                                                                           DeleteBook

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n       ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\SIMBA\source\repos\HMS\HMS\Client\Shared\BookList.razor"
       
    [Parameter] public List<Books> book { get; set; }
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    bool displayButtons = false;
    private async Task DeleteBook(Books books)
    {
        var confirmed = await js.Confirm($"Are you sure you want to delete {books.Tittle } ?");
        if (confirmed)
        {
            book.Remove(books);
        }


    }


    protected override void OnInitialized()
    {
        Console.WriteLine("OnInitialized. book.count =" + book.Count.ToString());
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("OnParametersSet. book.count =" + book.Count.ToString());
    }
    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("OnAfterRender. firstrender =" + firstRender.ToString());
    }
    protected override bool ShouldRender()
    {
        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.HMS.Client.Shared.BookList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TIem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TIem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TIem> __arg1)
        {
        __builder.OpenComponent<global::HMS.Client.Shared.GenericList<TIem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "ElementTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
