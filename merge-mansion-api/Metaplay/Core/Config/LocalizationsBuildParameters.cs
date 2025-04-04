using Metaplay.Core.Model;
using Metaplay.Core.Forms;

namespace Metaplay.Core.Config
{
    [MetaReservedMembers(101, 200)]
    [MetaSerializable]
    public abstract class LocalizationsBuildParameters : IMetaIntegration<LocalizationsBuildParameters>, IMetaIntegration, IGameDataBuildParameters
    {
        [MetaFormLayoutOrderHint(-1)]
        [MetaFormExcludeDerivedType(new string[] { "Metaplay.Core.Config.GoogleSheetBuildSource" })]
        [MetaMember(101, (MetaMemberFlags)0)]
        [MetaValidateRequired]
        public GameConfigBuildSource DefaultSource;
        protected LocalizationsBuildParameters()
        {
        }
    }
}