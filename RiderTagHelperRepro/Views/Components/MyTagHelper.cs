using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RiderTagHelperRepro.Views.Components;

public class MyCustomTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Content.SetHtmlContent("Hello, World!");
    }
}
