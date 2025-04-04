using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.InAppPurchase;
using System;
using Metaplay.Core.Offers;

namespace Analytics
{
    [MetaBlockedMembers(new int[] { 6 })]
    [AnalyticsEvent(192, "Shop Item IAP Impression", 1, null, false, true, false)]
    public class AnalyticsEventShopItemIapImpression : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Item Id")]
        public InAppProductId ShopItemIapId { get; set; }

        [Description("Platform Id")]
        [JsonProperty("iap_platform_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public string PlatformId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("placement")]
        [Description("Placement Id")]
        public OfferPlacementId PlacementId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("automatic_show")]
        [Description("Shown automatically")]
        public bool AutomaticallyShown { get; set; }

        [Description("Impression Id")]
        [JsonProperty("impression_id")]
        [MetaMember(5, (MetaMemberFlags)0)]
        public string ImpressionId { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventShopItemIapImpression()
        {
        }

        public AnalyticsEventShopItemIapImpression(InAppProductId shopItemIapId, string platformId, OfferPlacementId placementId, bool automaticallyShown, string impressionId)
        {
        }
    }
}