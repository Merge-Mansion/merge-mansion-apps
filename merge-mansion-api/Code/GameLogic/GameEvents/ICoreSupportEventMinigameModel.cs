using Metaplay.Core.Model;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public interface ICoreSupportEventMinigameModel
    {
        CoreSupportEventMinigameId MinigameId { get; }
    }
}