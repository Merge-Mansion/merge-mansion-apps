using System;
using Metaplay.Core.Model;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Metaplay.Core.Config
{
    [MetaSerializable]
    public class GameConfigLibraryPatch<TKey, TInfo> : GameConfigEntryPatch<GameConfigLibrary<TKey, TInfo>, Dictionary<TKey, TInfo>>, IGameConfigLibraryPatch
    {
        [JsonProperty("replacedItems")]
        private Dictionary<TKey, TInfo> _replacedItems;
        [JsonProperty("appendedItems")]
        private Dictionary<TKey, TInfo> _appendedItems;
        [MetaMember(1, (MetaMemberFlags)0)]
        [MaxCollectionSize(2147483647)]
        [JsonIgnore]
        private List<GameConfigDataContent<TInfo>> _replacedItemsForSerialization { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MaxCollectionSize(2147483647)]
        [JsonIgnore]
        private List<GameConfigDataContent<TInfo>> _appendedItemsForSerialization { get; set; }

        private GameConfigLibraryPatch()
        {
        }

        public GameConfigLibraryPatch(IEnumerable<TInfo> replacedItems, IEnumerable<TInfo> appendedItems)
        {
        }

        internal override void PatchContentDangerouslyInPlace(Dictionary<TKey, TInfo> entryContent)
        {
            throw new NotImplementedException();
        }
    }
}