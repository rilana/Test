using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EPiServerSite4.Models.Pages
{
    [ContentType(DisplayName = "StandardPageEE", GUID = "68e2853f-6dfc-4b57-b8e1-2cdacfdf1ce5", Description = "")]
    public class StandardPageEE : PageData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }

                // Define a Content Area to enable the editor to drop a navigation block into
                public virtual ContentArea TopNavContentArea { get; set; }
         
    }
}