using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPiServerSite3.Models.Blocks
{
    public class TopNavViewModel
    {
        // The TopNavBlock
        public TopNavBlock TopNavBlock { get; private set; }

        // The children of the ParentPage specifed in the TopNavBlock 
        public IEnumerable<PageData> PageChildren { get; set; }

        // Constructor
        public TopNavViewModel(TopNavBlock topNavBlock, IEnumerable<PageData> pageChildren)
        {
            TopNavBlock = topNavBlock;
            PageChildren = pageChildren;
        }
    }
}