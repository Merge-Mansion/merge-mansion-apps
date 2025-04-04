using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using System;
using Metaplay.Core.Math;

namespace Analytics
{
    [AnalyticsEvent(209, "The Great Escape Minigame", 1, null, false, true, false)]
    public class AnalyticsEventTheGreatEscapeMinigame : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("progress")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("The progress made during the run")]
        public int Progress { get; set; }

        [JsonProperty("requirement")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("The required progress to complete the minigame")]
        public int Requirement { get; set; }

        [Description("If minigame is completed or not")]
        [JsonProperty("completed")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public bool Completed { get; set; }

        [Description("The number of bars destroyed")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("bars_destroyed")]
        public int BarsDestroyed { get; set; }

        [Description("The number of taps the user made")]
        [JsonProperty("number_of_taps")]
        [MetaMember(5, (MetaMemberFlags)0)]
        public int NumberOfTaps { get; set; }

        [Description("The number of seconds player used during the run")]
        [JsonProperty("timer_seconds")]
        [MetaMember(6, (MetaMemberFlags)0)]
        public F32 TimerSeconds { get; set; }

        [JsonProperty("tries")]
        [Description("The number of tries player had in minigame")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public int Tries { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventTheGreatEscapeMinigame()
        {
        }

        public AnalyticsEventTheGreatEscapeMinigame(int progress, int requirement, bool completed, int barsDestroyed, int numberOfTaps, F32 timerSeconds, int tries)
        {
        }

        [JsonProperty("mini_game_name")]
        [Description("Minigame name")]
        [MetaMember(8, (MetaMemberFlags)0)]
        public string MinigameName { get; set; }
    }
}