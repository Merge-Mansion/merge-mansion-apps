using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;
using GameLogic.Player;
using GameLogic;
using Metaplay.Core;

namespace Analytics
{
    [MetaBlockedMembers(new int[] { 6 })]
    [AnalyticsEvent(108, "Merge goals completed", 1, null, false, true, false)]
    public class AnalyticsEventMergeGoalsCompleted : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("goal_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("ID of the hotspot with completed merge goal")]
        public HotspotId HotspotId { get; set; }

        [JsonProperty("area_name")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Area where hotspot is located")]
        public string AreaName { get; set; }

        [Description("How many hotspots were completed thus far")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("merge_goals_completed")]
        public int CompletedHotSpots { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventMergeGoalsCompleted()
        {
        }

        public AnalyticsEventMergeGoalsCompleted(PlayerModel player, HotspotId hotspotId, string areaName, int completedHotSpots)
        {
        }

        [Description("MapSpot where the hotspot is located")]
        [JsonProperty("map_spot_id")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public string MapSpot { get; set; }

        [Description("Multistep Group Id of the hotspot task (may be empty)")]
        [JsonProperty("task_group_id")]
        [MetaMember(5, (MetaMemberFlags)0)]
        public string TaskGroup { get; set; }

        public AnalyticsEventMergeGoalsCompleted(PlayerModel player, HotspotId hotspotId, string areaName, int completedHotSpots, string mapSpot, string taskGroup)
        {
        }

        [JsonProperty("bonus_time_left")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("How much time is left for bonus")]
        public double? BonusTimeLeft { get; set; }

        [Description("Character id of the hotspot task (may be empty)")]
        [JsonProperty("character_id")]
        [MetaMember(8, (MetaMemberFlags)0)]
        public string Character { get; set; }

        [JsonProperty("bonus_rewards")]
        [MetaMember(9, (MetaMemberFlags)0)]
        [Description("Possible bonus rewards")]
        public AnalyticsPlayerBonusReward[] BonusRewards { get; set; }

        public AnalyticsEventMergeGoalsCompleted(PlayerModel player, HotspotId hotspotId, string areaName, int completedHotSpots, string mapSpot, string taskGroup, MetaDuration? bonusTimeLeft, string character, AnalyticsPlayerBonusReward[] bonusRewards)
        {
        }

        [Description("Completed hotspots in the current area")]
        [JsonProperty("completed_hotspots_in_area")]
        [MetaMember(10, (MetaMemberFlags)0)]
        public int CompletedHotspotsInArea { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        [JsonProperty("uncompleted_hotspots_in_area")]
        [Description("Uncompleted hotspots in the current area")]
        public int UncompletedHotspotsInArea { get; set; }

        public AnalyticsEventMergeGoalsCompleted(PlayerModel player, HotspotId hotspotId, string areaName, int completedHotSpots, int completedHotspotsInArea, int uncompletedHotspotsInArea, string mapSpot, string taskGroup, MetaDuration? bonusTimeLeft, string character, AnalyticsPlayerBonusReward[] bonusRewards)
        {
        }
    }
}