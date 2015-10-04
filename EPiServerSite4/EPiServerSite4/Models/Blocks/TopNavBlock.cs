using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiServerSite4.Models.Blocks
{
    [ContentType(DisplayName = "TopNavBlock", GUID = "d724b5cb-d1ed-4bc0-a107-3e3c3eff4318", Description = "")]
    public class TopNavBlock : BlockData
    {
        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Parent Page",
            Description = "Select the parent of the pages you want to display.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual PageReference ParentPage { get; set; }
    }
}