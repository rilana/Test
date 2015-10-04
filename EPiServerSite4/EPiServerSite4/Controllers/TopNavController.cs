using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServerSite4.Models.Blocks;

namespace EPiServerSite4.Controllers
{
    public class TopNavController : BlockController<TopNavBlock>
    {
        public override ActionResult Index(TopNavBlock currentBlock)
        {
            var pageChildren = Enumerable.Empty<PageData>();

            // Get the content repository
            IContentRepository contentRepository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>();

            // Get the children of the page specified in the ParentPage property of the block
            if (!PageReference.IsNullOrEmpty(currentBlock.ParentPage))
            {
                pageChildren = contentRepository.GetChildren<PageData>(currentBlock.ParentPage);
            }

            return PartialView(new TopNavViewModel(currentBlock, pageChildren));
        }
    }
}
