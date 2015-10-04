using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiServerSite3.Models.Blocks
{
    [ContentType(DisplayName = "TopNavBlock", GUID = "0e1d7b1a-8a79-4362-88d1-d6f64a204a48", Description = "")]
    public class TopNavBlock : BlockData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
               public virtual PageReference ParentPage { get; set; }
         
    }
}