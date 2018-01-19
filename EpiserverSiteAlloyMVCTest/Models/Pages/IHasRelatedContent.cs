using EPiServer.Core;

namespace EpiserverSiteAlloyMVCTest.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
