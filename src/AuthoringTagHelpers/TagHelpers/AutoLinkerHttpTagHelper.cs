using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AuthoringTagHelpers.TagHelpers
{
    [HtmlTargetElement("p")]
    public class AutoLinkerHttpTagHelper : TagHelper
    {
        public override int Order
        {
            get { return int.MinValue; }
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = await output.GetChildContentAsync();
            // Find Urls in the content and replace them with their anchor tag equivalent.
            output.Content.SetHtmlContent(Regex.Replace(
                 childContent.GetContent(),
                 @"\b(?:https?://)(\S+)\b",
                  "<a target=\"_blank\" href=\"$0\">$0</a>"));  // http link version}
        }
    }
}
