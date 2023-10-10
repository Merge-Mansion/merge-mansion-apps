using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using System;
using System.Collections.Generic;
using GameLogic.Player.Board;
using GameLogic.Player.Items;
using System.Runtime.Serialization;
using GameLogic.Player.Rewards;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(8)]
    public class CollectibleBoardEventModel : ExtendableEventState<CollectibleBoardEventId, CollectibleBoardEventInfo>, IBoardEventModel, IPointsEvent
    {
        public static int InitialLevel;
        private static int InitialLevelProgress;
        private static byte InitialBoolFields;
        private static int InitialEnterMergeBoardCount;
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override CollectibleBoardEventId ActivableId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Level { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int LevelProgress { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<CollectibleBoardEventClaimedLevelData> ClaimedLevels { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MergeBoard MergeBoard { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        protected byte BoolFields { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<IBoardItem> PocketItems { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public int EnterMergeBoardCount { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<EventTaskId> AvailableTaskIds { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public int CompletedTaskCount { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        protected byte BoolFields2 { get; set; }
        public bool PortalItemGiven { get; set; }
        public bool PreviewNoted { get; set; }
        public bool StartNoted { get; set; }
        public bool EndNoted { get; set; }
        public bool EnterBoardDialogueTriggered { get; set; }
        public bool EndOfEventLevelsClaimed { get; set; }
        public bool EndDialogueTriggered { get; set; }
        public bool ActiveDecorationNoted { get; set; }
        public bool IsPlayable { get; set; }
        public bool RequestExtension { get; set; }
        public bool CanBeResolved { get; set; }
        public bool FtueNoted { get; set; }

        [IgnoreDataMember]
        public CollectibleBoardEventInfo Info { get; }

        [IgnoreDataMember]
        public IBoardEventInfo EventInfo { get; }

        [IgnoreDataMember]
        public override ExtendableEventParams ExtendableEventParams { get; }

        [IgnoreDataMember]
        MetaActivableState.Activation? Code.GameLogic.GameEvents.IBoardEventModel.LatestActivation { get; }

        [IgnoreDataMember]
        bool Code.GameLogic.GameEvents.IBoardEventModel.RequestExtension { get; set; }

        public CollectibleBoardEventModel()
        {
        }

        public CollectibleBoardEventModel(CollectibleBoardEventInfo info)
        {
        }

        [MetaMember(12, (MetaMemberFlags)0)]
        protected HashSet<int> PhotoTakenItems { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        protected HashSet<int> CaughtFishes { get; set; }
        public bool FishCaught { get; set; }
        public bool CameraNoted { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        protected HashSet<int> FishCatchPopupSeenItems { get; set; }
        public IStringId Id { get; }
        public int Points { get; }
    }
}