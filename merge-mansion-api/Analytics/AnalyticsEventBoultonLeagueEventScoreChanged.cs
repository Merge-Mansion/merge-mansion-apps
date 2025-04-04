using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using Metaplay.Core;
using System;

namespace Analytics
{
    [AnalyticsEventKeywords(new string[] { "event" })]
    [AnalyticsEvent(203, "Boulton League event score changed", 1, null, true, true, false)]
    public class AnalyticsEventBoultonLeagueEventScoreChanged : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [Description("Event id")]
        [JsonProperty("event_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public BoultonLeagueEventId EventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Leaderboard division id")]
        [JsonProperty("division_id")]
        public EntityId DivisionId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("League stage number")]
        [JsonProperty("stage_number")]
        public int StageNumber { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("score_amount")]
        [Description("Amount of points/score gained")]
        public int ScoreAmount { get; set; }

        [Description("Source of points/score gained")]
        [JsonProperty("score_source_type")]
        [MetaMember(5, (MetaMemberFlags)0)]
        public BoultonLeagueEventScoreSourceType ScoreSourceType { get; set; }

        [Description("New total score")]
        [JsonProperty("total_score")]
        [MetaMember(6, (MetaMemberFlags)0)]
        public int TotalScore { get; set; }

        [JsonProperty("stage_demotion_score_threshold")]
        [Description("Possible score requirement to avoid demotion to the previous league stage after the event concludes")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public int StageDemotionScoreThreshold { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [JsonProperty("stage_promotion_score_threshold")]
        [Description("Possible score requirement for promotion to the next league stage after the event concludes")]
        public int StagePromotionScoreThreshold { get; set; }
        public override string EventDescription { get; }

        private AnalyticsEventBoultonLeagueEventScoreChanged()
        {
        }

        public AnalyticsEventBoultonLeagueEventScoreChanged(BoultonLeagueEventModel eventModel, int scoreAmount, BoultonLeagueEventScoreSourceType scoreSourceType)
        {
        }

        [MetaMember(9, (MetaMemberFlags)0)]
        [JsonProperty("division_rank")]
        [Description("Leaderboard division rank")]
        public int DivisionRank { get; set; }
    }
}