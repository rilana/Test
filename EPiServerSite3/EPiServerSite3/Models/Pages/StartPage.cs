using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EPiServerSite3.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "4220fc56-ce8c-4bc7-987b-47e2584ea724", Description = "")]
    public class StartPage : PageData
    {
        
                //[CultureSpecific]
                //[Display(
                //    Name = "Main body",
                //    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                //    GroupName = SystemTabNames.Content,
                //    Order = 1)]
                //public virtual XhtmlString MainBody { get; set; }
        [Range(1, 12)]
        public virtual int Mounth { get; set; }

        // Define a Content Area to enable the editor to drop a navigation block into
        public virtual ContentArea TopNavContentArea { get; set; }
    }
}