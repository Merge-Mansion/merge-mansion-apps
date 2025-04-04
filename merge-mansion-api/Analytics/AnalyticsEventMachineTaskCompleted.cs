using Metaplay.Core.Analytics;
using System.ComponentModel;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System;
using Code.GameLogic.GameEvents;
using Metaplay.Core.Math;
using GameLogic.Player;

namespace Analytics
{
    [AnalyticsEvent(191, "Mystery Machine task completed", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "event", "task" })]
    public class AnalyticsEventMachineTaskCompleted : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [Description("Event instance number, increments per event instance. Specific to the player's instances. See machine_event_instance_id for global id.")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("machine_event_instance")]
        public int MachineEventInstance { get; set; }

        [Description("Run number, increments every time machine is started")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("run_number")]
        public int RunNumber { get; set; }

        [Description("Id of task that was completed")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("How much permanent (machine level-based) score multiplier increased")]
        [JsonProperty("task_multiplier_added")]
        public double TaskMultiplierAdded { get; set; }

        [JsonProperty("task_multiplier_total")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Permanent (machine level-based) score multiplier after completing the task")]
        public double TaskMultiplierTotal { get; set; }

        [Description("How many times the recurring task has been completed, if this is a recurring task - otherwise null")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [JsonProperty("recurring_complete")]
        public int? RecurringComplete { get; set; }

        [JsonProperty("context")]
        [Description("String describing the context of the receiving action")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public string Context { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventMachineTaskCompleted()
        {
        }

        public AnalyticsEventMachineTaskCompleted(int machineEventInstance, int runNumber, MysteryMachineTaskId taskId, F64 levelMultiplierBefore, F64 levelMultiplierAfter, int? recurringComplete, AnalyticsContext context)
        {
        }

        [Description("Global instance id of the event. Can be used to track the same event across different players.")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [JsonProperty("machine_event_instance_id")]
        public string MachineEventInstanceId { get; set; }

        public AnalyticsEventMachineTaskCompleted(int machineEventInstance, string machineEventInstanceId, int runNumber, MysteryMachineTaskId taskId, F64 levelMultiplierBefore, F64 levelMultiplierAfter, int? recurringComplete, AnalyticsContext context)
        {
        }
    }
}