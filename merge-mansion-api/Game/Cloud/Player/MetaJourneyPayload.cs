using Metaplay.Core.Model;

namespace Game.Cloud.Player
{
    [MetaSerializable]
    public class MetaJourneyPayload
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaJourneyPayloadType Type { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string Payload { get; set; }
    }
}