using Metaplay.Core.Model;

namespace GameLogic.Config.Map.Characters
{
    [MetaSerializable]
    public enum MapCharacterPositionId
    {
        None = 0,
        DrivewayGateFirstMapCharacterPosition = 199,
        DrivewayGateGenericGameplay = 200,
        DrivewayGateMaddieOpenTheGate = 201,
        DrivewayGateMaddieInFrontOfTheGate = 202,
        DrivewayGateRoddyInFrontOfTheGate = 203,
        DrivewayGateMaddieInFrontOfTheMansionSign = 204,
        DrivewayGateGrandmaInFrontOfTheMansionSign = 205,
        DrivewayGateRemoveTree = 206,
        DrivewayFirstMapCharacterPosition = 399,
        DrivewayStatue = 400,
        DrivewayRemoveTrash1 = 401,
        DrivewayUpperHalf = 402,
        MansionStairsRemoveTrash = 403,
        DrivewaySecondRoddyAndMaddieEventMaddie = 404,
        DrivewaySecondRoddyAndMaddieEventRoddy = 405,
        DrivewayStatueEventMaddie = 406,
        DrivewayStatueEventGrandma = 407,
        DrivewayThirdRoddyAndMaddieEventMaddie = 408,
        DrivewayThirdRoddyAndMaddieEventRoddy = 409,
        GarageFirstMapCharacterPosition = 599,
        GarageEntrance = 600,
        GarageCarMaddie = 601,
        GarageCarGrandma = 602,
        GarageTraderTableMaddie = 603,
        GarageTraderTableGrandma = 604,
        GarageOutside = 605,
        GarageWorkshop = 606,
        GarageTopCorner = 607,
        GarageLocker = 608,
        GrandmasHouseFirstMapCharacterPosition = 799,
        GrandmasHouseGrandma = 800,
        GrandmasHouseMaddie = 801,
        GardenRightFirstMapCharacterPosition = 999,
        GardenRightStairs = 1000,
        GardenRightFountainMaddie = 1001,
        GardenRightTopCorner = 1002,
        GardenRightPathToWaterGarden = 1003,
        GardenRightPathToSideEntrance = 1004,
        GardenRightFountainGrandma = 1005,
        WaterGardenFirstMapCharacterPosition = 1199,
        WaterGardenBridge = 1200,
        WaterGardenPath1 = 1201,
        WaterGardenPath2 = 1202,
        WaterGardenPath3 = 1203,
        WaterGardenTopOfStairs = 1204,
        WaterGardenStatueMaddie = 1205,
        WaterGardenStatueGrandma = 1206,
        BeachRightFirstMapCharacterPosition = 1399,
        BeachRightPath1 = 1400,
        BeachRightPath2 = 1401,
        BeachRightPath3 = 1402,
        BeachRightTotemMaddie = 1403,
        BeachRightTotemGrandma = 1404,
        BeachRightHouse = 1405,
        BeachRightWorkshop = 1406,
        BeachRightTikiStatues = 1407,
        BeachRightFirePit = 1408,
        BeachRightWorkshopMaddie = 1409,
        BeachRightWorkshopGrandma = 1410,
        MansionRightFillerFirstMapCharacterPosition = 1599,
        MansionRightFillerStatueMaddie = 1600,
        MansionRightFillerStatueGrandma = 1601,
        MansionRightFillerPoolMaddie = 1602,
        MansionRightFillerPoolGrandma = 1603,
        MansionRightFillerEntrance = 1604,
        MansionRightFillerEntrancePath1 = 1605,
        MansionRightFillerPathTowardsStatue = 1606,
        MansionRightFillerLowerPath1 = 1607,
        MansionRightFillerPathTowardsPool = 1608,
        MansionRightFillerGardenBench = 1609,
        MansionRightFillerStairsToPatio = 1610,
        MansionRightFillerLowerPath2 = 1611,
        MansionRightFillerLowerPath3 = 1612,
        MansionRightFillerLowerPath4 = 1613,
        MansionRightFillerPatio1 = 1614,
        MansionRightFillerPatio2 = 1615,
        MansionSideEntranceFirstMapCharacterPosition = 1799,
        MansionSideEntrancePath1 = 1800,
        MansionSideEntrancePath2 = 1801,
        MansionSideEntrancePath3 = 1802,
        MansionSideEntrancePath4 = 1803,
        BeachHarbourFirstMapCharacterPosition = 1999,
        BeachHarbourPath1 = 2000,
        BeachHarbourPath2 = 2001,
        MansionPlazaFirstMapCharacterPosition = 2199,
        MansionPlazaPath1 = 2200,
        MansionPlazaPath2 = 2201,
        MansionPlazaPath3 = 2202,
        MansionPlazaYard1 = 2203,
        MansionPlazaYard2 = 2204,
        MansionPlazaYard3 = 2205,
        MansionPlazaBirdPool = 2206,
        MansionPlazaMansionDoor = 2207,
        MansionPlazaExit = 2208,
        GardenRight20FirstMapCharacterPosition = 2399,
        GardenRight20Entry = 2400,
        GardenRight20FountainMaddie = 2401,
        GardenRight20TopCorner = 2402,
        GardenRight20PathToRight = 2403,
        GardenRight20PathToSideEntrance = 2404,
        GardenRight20FountainGrandma = 2405,
        YachtPierFirstMapCharacterPosition = 2599,
        YachtPierEntryMaddie = 2600,
        YachtPierBridgeMaddie = 2601,
        YachtPierIslandMaddie = 2602,
        YachtPierMainPierMaddie = 2603,
        YachtPierSidePierMaddie = 2604,
        YachtPierMainPierEndMaddie = 2605,
        OldWellFirstMapCharacterPosition = 2799,
        OldWellPathwayMaddie = 2800,
        OldWellRescueDogMaddie = 2801,
        OldWellRescueDogGrandma = 2802,
        OldWellPathWayMaddie = 2803,
        OldWellEntryMaddie = 2804,
        OldWellPergolaMaddie = 2805,
        OldWellFlowerCartMaddie = 2806,
        OldWellPondMaddie = 2807,
        PoolHouseFirstMapCharacterPosition = 2999,
        PoolHouseOutsideMaddie = 3000,
        PoolHouseEntryMaddie = 3001,
        PoolHouseUpperLevelMaddie = 3002,
        BBQAreaFirstMapCharacterPosition = 3199,
        BBQAreaEntryMaddie = 3200,
        BBQAreaLoungeMaddie = 3201,
        BBQAreaKitchenMaddie = 3202,
        BBQAreaSidePathMaddie = 3203,
        LoveStoryAreaFirstMapCharacterPosition = 3399,
        LoveStoryAreaEntryMaddie = 3400,
        LoveStoryAreaFirstPathMaddie = 3401,
        LoveStoryAreaBenchMaddie = 3402,
        AreaMazeFirstMapCharacterPosition = 3599,
        AreaMazeEntryMaddie = 3600,
        AreaMazePathMaddie = 3601,
        AreaMazeGateMaddie = 3602,
        AreaMazeSmallGateMaddie = 3603,
        AreaMazeCenterMaddie = 3604,
        AreaMazeFountainMaddie = 3605,
        AreaLighthouseFirstMapCharacterPosition = 3799,
        AreaLighthouseEntryMaddie = 3800,
        AreaLighthousePathMaddie = 3801,
        AreaLighthouseLighthouseTopMaddie = 3802,
        AreaMansionGrandHallFirstMapCharacterPositionMap = 3999,
        AreaMansionGrandHallOutdoorMaddieDialogue = 4000,
        AreaMansionGrandHallOutdoorGrandmaDialogue = 4001,
        AreaMansionGrandHallFirstMapCharacterPositionDialogue = 4002,
        AreaMansionGrandHallIndoorCenterMaddieDialogue = 4003,
        AreaMansionGrandHallIndoorCenterGrandmaDialogue = 4004,
        AreaMansionGrandHallIndoorEntryVictoriaDialogue = 4005,
        AreaMansionGrandHallIndoorEntryVictoriaMap = 4006,
        AreaMansionGrandHallIndoorCenterMaddieMap = 4007,
        AreaMansionGrandHallLeftPathMaddieMap = 4008,
        AreaMansionGrandHallRightPathMaddieMap = 4009,
        AreaMansionGrandHallTopPathMaddieMap = 4010,
        AreaMansionGrandHallClockPathMaddieMap = 4011,
        AreaMansionHallwayFirstMapCharacterPositionMap = 4199,
        AreaMansionHallwayEntryMaddieDialogue = 4200,
        AreaMansionHallwayEntryGrandmaDialogue = 4201,
        AreaMansionHallwayEntryWinstonDialogue = 4202,
        AreaMansionHallwayEntryJackieDialogue = 4203,
        AreaMansionHallwayStatueMaddieDialogue = 4204,
        AreaMansionHallwayCenterMaddieDialogue = 4205,
        AreaMansionHallwayCenterGrandmaDialogue = 4206,
        AreaMansionHallwayCenterJackieDialogue = 4207,
        AreaStudyFirstMapCharacterPositionMap = 4399,
        AreaStudyEntryMaddieDialogue = 4400,
        AreaStudyEntryGrandmaDialogue = 4401,
        AreaStudyEntryHoldenDialogue = 4402,
        AreaStudyCenterMaddieDialogue = 4403,
        AreaLighthouseTopFirstMapCharacterPositionMap = 4599,
        AreaLighthouseTopEntryMaddieMap = 4600,
        AreaSaunaBurnFirstMapCharacterPositionMap = 4799,
        AreaSaunaBurnEntryMaddieMap = 4800,
        AreaStudySrFirstMapCharacterPositionMap = 4999,
        AreaStudySrEntryMaddieMap = 5000,
        AreaDiningRoomFirstMapCharacterPositionMap = 5199,
        AreaDiningRoomEntryMaddieMap = 5200,
        AreaBathroomFirstMapCharacterPositionMap = 5399,
        AreaBathroomEntryMaddieMap = 5400,
        AreaBathroomEntryAshDialogue = 5401,
        AreaBathroomCenterMaddieDialogue = 5402,
        AreaGalleryFirstMapCharacterPositionMap = 5599,
        AreaGalleryEntryDialogueMaddie = 5600,
        AreaGallerySecondDialogueMaddie = 5601,
        AreaGalleryEntryDialogueWinston = 5602,
        AreaPetHomeFirstMapCharacterPositionMap = 5799,
        AreaPetHomeEntryMapGoldie = 5800,
        AreaLandingRoomFirstMapCharacterPositionMap = 5999,
        AreaLandingRoomEntryMapMaddie = 6000,
        AreaLandingRoomSecondDialogueMaddie = 6001,
        DrivewayGatePetPreview = 207,
        AreaPetHomeMapLilReggie = 5801,
        AreaLandingRoomEntryHolden = 6001,
        AreaLoungFirstMapCharacterPositionMap = 6199,
        AreaLoungEntryMapMaddie = 6200,
        AreaLoungEntryWinston = 6201,
        AreaLoungSecondDialogueMaddie = 6202,
        AreaRanchStablesExteriorFirstMapCharacterPosition = 6399,
        AreaRanchStablesExteriorEntryMapMaddie = 6400,
        AreaRanchStablesExteriorAppleBasket = 6401,
        AreaRanchStablesExteriorWater = 6402,
        AreaRanchStablesExteriorBeforeBridge = 6403,
        AreaRanchStablesExteriorAfterBridge = 6404,
        AreaRanchStablesExteriorBehindFence = 6405,
        AreaRanchStablesExteriorAppleBasketMaddie = 6406,
        AreaRanchStablesExteriorWaterMaddie = 6407,
        AreaRanchStablesExteriorBeforeBridgeMaddie = 6408,
        AreaRanchStablesExteriorAfterBridgeMaddie = 6409,
        AreaRanchStablesExteriorBehindFenceMaddie = 6410,
        AreaRanchStablesExteriorFirstMapCharacterPositionMaddie = 6411,
        AreaMansionSecretSocietyFirstMapCharacterPosition = 6599,
        AreaMansionSecretSocietyEntryMapMaddie = 6600,
        AreaMansionSecretSocietyJackieEntry = 6601,
        AreaMansionDanceFloorFirstMapCharacterPosition = 6799,
        AreaMansionDanceFloorEntryMapMaddie = 6800,
        AreaMansionDanceFloorCharacter = 6801,
        AreaMansionDanceFloorEntrance = 6802,
        AreaPetHomeMapCoco = 5802,
        AreaPetHomePetPreview = 5803,
        AreaMansionSpeakEasyFirstMapCharacterPosition = 6999,
        AreaMansionSpeakEasyEntryMapMaddie = 7000,
        AreaMansionSpeakEasyCharacter = 7001,
        AreaMansionMusicianRoomFirstMapCharacterPosition = 7199,
        AreaMansionMusicianRoomEntryMapMaddie = 7200,
        AreaMansionMusicianRoomCharacter = 7201,
        AreaPetHomeMapBuddy = 5804,
        AreaRanchStablesInteriorFirstMapCharacterPosition = 7399,
        AreaRanchStablesInteriorEntryMapMaddie = 7400,
        AreaRanchStablesInteriorCharacter = 7401,
        MaddieRoomFirstMapCharacterPosition = 7599,
        MaddieRoomEntryMapMaddie = 7600,
        MaddieRoomCharacter = 7601,
        MaddieRoomGrandma = 7602,
        LibraryFirstMapCharacterPosition = 7799,
        LibraryEntryMapMaddie = 7800,
        LibraryCharacter = 7801,
        AreaPetHomeMapAmy = 5805,
        AreaTombFirstMapCharacterPosition = 7999,
        AreaTombEntryMapMaddie = 8000,
        AreaTombCharacter = 8001,
        AreaPetHomeMapPatches = 5806,
        CinemaFirstMapCharacterPosition = 8199,
        CinemaEntryMapMaddie = 8200,
        CinemaCharacter = 8201,
        AreaAtticFirstMapCharacterPosition = 8399,
        AreaAtticEntryMapMaddie = 8400,
        AreaAtticCharacter = 8401,
        AreaShackExteriorFirstMapCharacterPosition = 8599,
        AreaShackExteriorEntryMapMaddie = 8600,
        AreaShackExteriorMaddie = 8601,
        AreaShackExteriorCharacter = 8602,
        AreaShackInteriorFirstMapCharacterPosition = 8799,
        AreaShackInteriorEntryMapMaddie = 8800,
        AreaShackInteriorCharacter = 8801,
        AreaBeachBarFirstMapCharacterPosition = 8999,
        AreaBeachBarEntryMapMaddie = 9000,
        AreaBeachBarCharacter = 9001,
        AreaPetHomeMapTofu = 5807,
        OfficeFirstMapCharacterPosition = 9199,
        OfficeEntryMapMaddie = 9200,
        OfficeCharacter = 9201,
        AreaTinCanTelescope = 9202,
        AreaTinCanKiosk = 9203,
        AreaTinCanPier = 9204,
        AreaTinCanMainEntrance = 9205,
        AreaTinCanCellarEntrance = 9206,
        AreaTinCanBridge = 9207,
        FactoryBoulevardFirstMapCharacterPosition = 9799,
        FactoryBoulevardEntryMapMaddie = 9800,
        FactoryBoulevardMaddieFactoryDoor = 9801,
        FactoryBoulevardMaddieDamWall = 9802,
        FactoryBoulevardMaddiePathLeft = 9803,
        FactoryBoulevardMaddieGarden = 9804,
        FactoryBoulevardMaddieKiosk = 9805,
        FactoryBoulevardCharacter = 9806,
        AreaPetHomeMapPablo = 5808,
        DebRoomFirstMapCharacterPosition = 9999,
        DebRoomEntryMapMaddie = 10000,
        DebRoomDebMapSpot1 = 10001,
        WestWingMaddie1 = 10002,
        DebRoomMaddie2 = 10003,
        PerfumeryFirstMapCharacterPosition = 10199,
        PerfumeryEntryMapMaddie = 10200,
        PerfumeryMaddieDistillery = 10201,
        PerfumeryCharacter = 10202
    }
}