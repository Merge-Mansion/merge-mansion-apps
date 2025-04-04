using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using GameLogic.Banks;
using System;
using GameLogic;

namespace Analytics
{
    [AnalyticsEvent(160, "Currency Bank Impression", 1, null, false, true, false)]
    public class AnalyticsEventCurrencyBankImpression : AnalyticEventGeneralImpression
    {
        public override AnalyticsEventType EventType { get; }

        [Description("Currency Bank Id")]
        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public CurrencyBankId CurrencyBankId { get; set; }

        [Description("Currency Bank amount")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("currency_amount")]
        public long Amount { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("currency_type")]
        [Description("Currency Bank currency type")]
        public Currencies CurrencyType { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventCurrencyBankImpression()
        {
        }

        public AnalyticsEventCurrencyBankImpression(CurrencyBankId currencyBankId, Currencies currencyType, long amount, string platformId, string placementId, string impressionId)
        {
        }

        [Description("Event Offer Trigger Type")]
        [JsonProperty("trigger_type")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public string TriggerType { get; set; }

        public AnalyticsEventCurrencyBankImpression(CurrencyBankId currencyBankId, Currencies currencyType, long amount, string platformId, string placementId, string impressionId, string triggerType)
        {
        }
    }
}