using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EPiServerSite4.Models.Pages
{
    [ContentType(DisplayName = "PageType2", GUID = "722c947f-2ee3-49f3-8026-50d974138ae3", Description = "")]
    public class PageType2 : PageData
    {
        [Display(
              Name = "Show teaser",
              Description = "",
              GroupName = SystemTabNames.Content,
              Order = 80)]
        public virtual bool ShowTeaser { get; set; }

        [Display(
                Name = "Selected categories",
                Description = "",
                GroupName = SystemTabNames.Content,
                Order = 90)]
        public virtual CategoryList SelectedCategories { get; set; }

        [Display(
            Name = "Event start time",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual DateTime EventStartTime { get; set; }
    }
}