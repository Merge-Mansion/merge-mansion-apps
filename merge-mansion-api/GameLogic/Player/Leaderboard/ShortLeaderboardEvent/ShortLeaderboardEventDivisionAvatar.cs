using Metaplay.Core.League.Player;
using Metaplay.Core.Model;
using System;
using Metaplay.Core.Player;

namespace GameLogic.Player.Leaderboard.ShortLeaderboardEvent
{
    [PlayerLeaguesEnabledCondition]
    [MetaSerializable]
    [MetaSerializableDerived(201)]
    public class ShortLeaderboardEventDivisionAvatar : PlayerDivisionAvatarBase, IMetacoreLeagueAvatar
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [ServerOnly]
        public string AssociationId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [ServerOnly]
        public PlayerSegmentId PlayerSegmentId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [ServerOnly]
        public int SegmentIdPriority { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        [ServerOnly]
        public string BotType { get; set; }

        private ShortLeaderboardEventDivisionAvatar()
        {
        }

        public ShortLeaderboardEventDivisionAvatar(string displayName, string associationId, PlayerSegmentId playerSegmentId, int segmentIdPriority, string botType)
        {
        }
    }
}