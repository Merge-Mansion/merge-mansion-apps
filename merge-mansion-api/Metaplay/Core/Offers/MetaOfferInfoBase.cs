using System;
using System.Collections.Generic;
using Metaplay.Core.Config;
using Metaplay.Core.InAppPurchase;
using Metaplay.Core.Model;
using Metaplay.Core.Player;
using Metaplay.Core.Rewards;

namespace Metaplay.Core.Offers
{
    [MetaSerializable]
    [MetaReservedMembers(100, 200)]
    public abstract class MetaOfferInfoBase : IGameConfigData<MetaOfferId>, IGameConfigData, IHasGameConfigKey<MetaOfferId>, IGameConfigPostLoad, IRefersToMetaOffers
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public MetaOfferId OfferId { get; set; }

        [MetaMember(101, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(103, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfoBase> InAppProduct { get; set; }

        [MetaMember(104, (MetaMemberFlags)0)]
        public List<MetaPlayerRewardBase> Rewards { get; set; }

        [MetaMember(110, (MetaMemberFlags)0)]
        public int? MaxActivationsPerPlayer { get; set; }

        [MetaMember(107, (MetaMemberFlags)0)]
        public int? MaxPurchasesPerPlayer { get; set; }

        [MetaMember(105, (MetaMemberFlags)0)]
        public int? MaxPurchasesPerOfferGroup { get; set; }

        [MetaMember(106, (MetaMemberFlags)0)]
        public int? MaxPurchasesPerActivation { get; set; }

        [MetaMember(108, (MetaMemberFlags)0)]
        public List<MetaRef<PlayerSegmentInfoBase>> Segments { get; set; }

        [MetaMember(109, (MetaMemberFlags)0)]
        public List<PlayerCondition> AdditionalConditions { get; set; }

        [MetaMember(111, (MetaMemberFlags)0)]
        public bool IsSticky { get; set; }
        public MetaOfferId ConfigKey => OfferId;
        public virtual bool RequireInAppProduct => true;

        protected MetaOfferInfoBase()
        {
        }

        protected MetaOfferInfoBase(MetaOfferId offerId, string displayName, string description, MetaRef<InAppProductInfoBase> inAppProduct, List<MetaPlayerRewardBase> rewards, int? maxActivationsPerPlayer, int? maxPurchasesPerPlayer, int? maxPurchasesPerOfferGroup, int? maxPurchasesPerActivation, List<MetaRef<PlayerSegmentInfoBase>> segments, List<PlayerCondition> additionalConditions, bool isSticky)
        {
        }

        protected MetaOfferInfoBase(MetaOfferSourceConfigItemBase source)
        {
        }

        public virtual string CustomReferencePriceForDashboard { get; }
    }
}