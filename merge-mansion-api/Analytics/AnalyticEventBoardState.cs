using Metaplay.Core.Model;
using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using Merge;
using System;
using Code.GameLogic.GameEvents;
using GameLogic;
using GameLogic.Player;

namespace Analytics
{
    [MetaBlockedMembers(new int[] { 1, 2, 3, 8, 9, 10 })]
    [AnalyticsEvent(138, "Board state snapshot", 1, null, false, true, false)]
    public class AnalyticEventBoardState : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("partially_visible_board_items")]
        [Description("Partially visible Board items of all on-going boards")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(15, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, Dictionary<string, int>> PartiallyVisibleBoardItems { get; set; }

        [Description("Merge goals")]
        [JsonProperty("merge_goals")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public List<HotspotId> MergeGoals { get; set; }

        [JsonProperty("event_goals")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [Description("Event goals")]
        [MetaMember(5, (MetaMemberFlags)0)]
        public Dictionary<EventId, List<EventTaskId>> EventGoals { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [JsonProperty("board_items")]
        [Description("Board items of all on-going boards")]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> BoardItems { get; set; }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [Description("Inventory items")]
        [JsonProperty("inventory_items")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> InventoryItems { get; set; }

        [JsonProperty("pocket_items")]
        [MetaMember(16, (MetaMemberFlags)0)]
        [Description("Pocket items")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<MergeBoardId, Dictionary<string, int>> PocketItems { get; set; }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [JsonProperty("decorations")]
        [Description("Decorations")]
        [MetaMember(11, (MetaMemberFlags)0)]
        public List<AnalyticsBoardStateDecorationMetaData> Decorations { get; set; }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Inventory items from extra perk")]
        [JsonProperty("inventory_items_extra")]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> InventoryExtraItems { get; set; }

        [Description("Hidden items count")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [JsonProperty("hidden_item_count")]
        [MetaMember(13, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, int> HiddenItemCount { get; set; }

        [JsonProperty("gathered_from")]
        [MetaMember(14, (MetaMemberFlags)0)]
        [Description("Snapshot taken at session start or session end")]
        public AnalyticsSnapshotType SnapshotType { get; set; }
        public override string EventDescription { get; }

        public AnalyticEventBoardState()
        {
        }

        public AnalyticEventBoardState(PlayerModel player, AnalyticsSnapshotType snapshotType)
        {
        }

        [JsonProperty("producer_inventory_items")]
        [Description("Producer inventory items")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(17, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> ProducerInventoryItems { get; set; }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(18, (MetaMemberFlags)0)]
        [JsonProperty("rentable_inventory_items")]
        [Description("Rentable inventory items")]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> RentableInventoryItems { get; set; }

        [JsonProperty("pets")]
        [MetaMember(19, (MetaMemberFlags)0)]
        [Description("Pets")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public List<AnalyticsBoardStateDecorationMetaData> Pets { get; set; }
    }
}