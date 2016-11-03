using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AuthoringTagHelpers.TagHelpers
{
    // [HtmlTargetElement("bold")]
    // [HtmlTargetElement(Attributes = "bold")]        /* Logical OR bold tag or bold attribute */

    // [HtmlTargetElement("bold", Attributes = "bold")] /* Logical AND bold tag with bold attribute */
    [HtmlTargetElement("MyBold")] /* Applies only to MyBold tag */
    public class BoldTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("bold");
            output.PreContent.SetHtmlContent("<strong>");
            output.PostContent.SetHtmlContent("</strong>");
        }
    }
}

/*
 * public IActionResult About()
{
    ViewData["Message"] = "Your application description page.";
    return View("AboutBoldOnly");
    // return View();
}
*/
