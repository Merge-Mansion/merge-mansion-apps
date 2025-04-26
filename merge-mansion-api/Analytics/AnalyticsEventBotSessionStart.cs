using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System;

namespace Analytics
{
    [AnalyticsEvent(168, "Bot session start", 1, null, true, true, false)]
    public class AnalyticsEventBotSessionStart : AnalyticsServersideEventBase
    {
        [JsonProperty("bot_session_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public int SessionId;
        public sealed override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("bot_configuration_id")]
        public string ConfigId { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventBotSessionStart()
        {
        }

        public AnalyticsEventBotSessionStart(string configurationId, int sessionId)
        {
        }
    }
}