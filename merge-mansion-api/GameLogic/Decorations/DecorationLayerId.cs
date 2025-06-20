using Metaplay.Core.Model;

namespace GameLogic.Decorations
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum DecorationLayerId
    {
        None = 0,
        LDEPC2023RemoveFoliageTA1 = 1,
        LDEPC2023RemoveFoodTruckRustTA2 = 2,
        LDEPC2023PlaceCounterTA3 = 3,
        LDEPC2023PlaceRugsTA4 = 4,
        LDEPC2023PlaceRestaurantSignTA5 = 5,
        LDEPC2023PlaceStoolsTA6 = 6,
        LDEPC2023PlaceFoodTA7 = 7,
        LDEPC2023PlaceMarqueeTB1 = 8,
        LDEPC2023PlaceTablesTB2 = 9,
        LDEPC2023PlaceFlowersTB3 = 10,
        LDEPC2023PlacePartyFlagsTB4 = 11,
        LDEPC2023PlaceTrailerTB5 = 12,
        LDEPC2023PlaceHangingLightsTC1 = 13,
        LDEPC2023PlacePaintDecalsTC2 = 14,
        LDEPC2023PlaceRooftopOrnamentsTC3 = 15,
        LDEGB2023PlaceBushesTA1 = 16,
        LDEGB2023RemoveLumberLeftTA2 = 17,
        LDEGB2023PlaceTowerTA3 = 18,
        LDEGB2023PlaceBarTA4 = 19,
        LDEGB2023PlacePoolLadderTA5 = 20,
        LDEGB2023PlaceBambooFenceTA6 = 21,
        LDEGB2023PlaceWaterSlideWaterTA7 = 22,
        LDEGB2023PlaceWelcomeRugTB1 = 23,
        LDEGB2023PlaceWaterSlideTopTB2 = 24,
        LDEGB2023PlacePlantsTB3 = 25,
        LDEGB2023PlaceCurtainsTB4 = 26,
        LDEGB2023PlaceBalloonsTB5 = 27,
        LDEGB2023PlaceParasolsTC1 = 28,
        LDEGB2023PlaceLightsTC2 = 29,
        LDEGB2023PlaceFlamingoTC3 = 30,
        LDEPOHB2023_UnityRemovePlayboat1TA1 = 31,
        LDEPOHB2023_UnitySwapGrassTA2 = 32,
        LDEPOHB2023_UnityPlaceShipHullTA3 = 33,
        LDEPOHB2023_UnityPlaceShipCabinTA4 = 34,
        LDEPOHB2023_UnityPlaceShipRailingsTA5 = 35,
        LDEPOHB2023_UnityPlaceShipMastsTA6 = 36,
        LDEPOHB2023_UnityPlaceWaterPierTA7 = 37,
        LDEPOHB2023_UnityPlaceShipPaintTB1 = 38,
        LDEPOHB2023_UnityPlaceRocksTB2 = 39,
        LDEPOHB2023_UnityPlacePlantsTB3 = 40,
        LDEPOHB2023_UnityPlacePropsTB4 = 41,
        LDEPOHB2023_UnityPlaceSmallSailandFlagTB5 = 42,
        LDEPOHB2023_UnityPlaceShipGoldFramesTC1 = 43,
        LDEPOHB2023_UnityPlaceWaterfallTC2 = 44,
        LDEPOHB2023_UnityPlaceTentaclesTC3 = 45,
        LDE_HolidayCarols2023SwapTreePackagesTA1 = 48,
        LDE_HolidayCarols2023SwapJunkTA2 = 49,
        LDE_HolidayCarols2023SwapSignTA3 = 50,
        LDE_HolidayCarols2023SwapLumberLeftTA4 = 51,
        LDE_HolidayCarols2023PlaceMailboxTA5 = 52,
        LDE_HolidayCarols2023PlaceTablesTA6 = 53,
        LDE_HolidayCarols2023PlaceMistletoeTA7 = 54,
        LDE_HolidayCarols2023PlaceFenceTB1 = 55,
        LDE_HolidayCarols2023PlaceTableDrinksTB2 = 56,
        LDE_HolidayCarols2023PlaceTinselandFlowersTB3 = 57,
        LDE_HolidayCarols2023PlaceTreeDecosTB4 = 58,
        LDE_HolidayCarols2023PlaceTreeCandlesTB5 = 59,
        LDE_HolidayCarols2023PlaceBigSnowflakeTC1 = 60,
        LDE_HolidayCarols2023PlaceOrnamentsTC2 = 61,
        LDE_HolidayCarols2023PlaceStageOrnamentTC3 = 62,
        SP_MiniHorseMystery2024PetHomeTA1 = 63,
        SP_MiniHorseMystery2024PetHomeTA2 = 64,
        SP_StrayBonesMystery2024_TA1 = 46,
        SP_StrayBonesMystery2024_TA2 = 47,
        LDE_Hopeberry2024_TA0 = 65,
        LDE_Hopeberry2024_TA1 = 66,
        LDE_Hopeberry2024_TA2 = 67,
        LDE_Hopeberry2024_TA3 = 68,
        LDE_Hopeberry2024_TA4 = 69,
        LDE_Hopeberry2024_TA5 = 70,
        LDE_Hopeberry2024_TA6 = 71,
        LDE_Hopeberry2024_TA7 = 72,
        LDE_Hopeberry2024_TB1 = 73,
        LDE_Hopeberry2024_TB2 = 74,
        LDE_Hopeberry2024_TB3 = 75,
        LDE_Hopeberry2024_TC1 = 76,
        LDE_Hopeberry2024_TC2 = 77,
        LDE_Hopeberry2024_TC3 = 78,
        LDE_GreenAcresQuest2024_TA1 = 79,
        LDE_GreenAcresQuest2024_TA2 = 80,
        LDE_GreenAcresQuest2024_TA3 = 81,
        LDE_GreenAcresQuest2024_TA4 = 82,
        LDE_GreenAcresQuest2024_TA5 = 83,
        LDE_GreenAcresQuest2024_TA6 = 84,
        LDE_GreenAcresQuest2024_TA7 = 85,
        LDE_GreenAcresQuest2024_TB1 = 86,
        LDE_GreenAcresQuest2024_TB2 = 87,
        LDE_GreenAcresQuest2024_TB3 = 88,
        LDE_GreenAcresQuest2024_TC1 = 89,
        LDE_GreenAcresQuest2024_TC2 = 90,
        LDE_GreenAcresQuest2024_TC3 = 91,
        SP_MysteriousMaelstrom2024_TA1 = 92,
        SP_MysteriousMaelstrom2024_TA2 = 93,
        SP_AlpacaPet2024_TA1 = 94,
        SP_AlpacaPet2024_TA2 = 95,
        SP_AmyPet2025_TA1 = 96,
        SP_AmyPet2025_TA2 = 97,
        SP_RaccoonRiddle2025_TA1 = 98,
        SP_RaccoonRiddle2025_TA2 = 99,
        LDE_Rumors2025_TA1 = 100,
        LDE_Rumors2025_TA2 = 101,
        LDE_Rumors2025_TA3 = 102,
        LDE_Rumors2025_TA4 = 103,
        LDE_Rumors2025_TB1 = 104,
        LDE_Rumors2025_TB2 = 105,
        LDE_Rumors2025_TC1 = 106,
        LDE_Rumors2025_TC2 = 107,
        SP_PigPet2025_TA1 = 108,
        SP_PigPet2025_TA2 = 109,
        SP_GoatPet2025_TA1 = 110,
        SP_GoatPet2025_TA2 = 111
    }
}