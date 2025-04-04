using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using Metaplay.Core;
using System;

namespace Analytics
{
    [AnalyticsEvent(161, "Player Mapping", 1, null, false, true, false)]
    public class AnalyticsEventPlayerMapping : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [Description("Real Player Id")]
        [JsonProperty("player_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public EntityId PlayerId { get; set; }
        public override string EventDescription { get; }

        private AnalyticsEventPlayerMapping()
        {
        }

        public AnalyticsEventPlayerMapping(EntityId playerId)
        {
        }
    }
}