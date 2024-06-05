﻿namespace DragaliaAPI.Models.Results;

public enum ResultCode
{
    Success = 1,
    CommonAuthError = 100,
    CommonMaintenance,
    CommonAccountBan,
    CommonAccountSystemBan,
    CommonAccountComplianceBan,
    CommonMaterialShort = 106,
    CommonInvalidateJson = 109,
    CommonDeployHashError,
    CommonResourceVersionError,
    CommonChangeDate,
    CommonUserStatusError,
    CommonIllegalToolError,
    CommonDoubleSubmitError,
    CommonStoneShort,
    CommonDataValidationError,
    CommonDataNotFoundError = 120,
    CommonDbError,
    CommonServerError,
    CommonAppVersionError,
    CommonAppVersionErrorIos,
    CommonAppVersionErrorAndroid,
    CommonActionLogError = 127,
    CommomWebHttpError = 129,
    CommonDeserializeError = 134,
    CommonTimeout,
    CommonSessionRestoreError,
    CommonSessionDuplicateError,
    CommonPlatformError = 139,
    CommonTutorialSummonChangeDate,
    CommonInvalidArgument = 150,
    ResponseDataNotFound,
    MemcachedDeleteError,
    ServiceResponseCategoryUnexpected = 154,
    SessionViewerIdNotFound,
    SessionSessionIdNotFound,
    SessionSessionNotFound,
    RedisConnectionFailed,
    SafetyNetError = 160,
    BaasUserIdDuplicated,
    CommonFraudError,
    IdTokenError,
    IdTokenNotLoaded,
    CommonLogFileError,
    SafetyNetRetry,
    CommonPushAccountError = 170,
    CommonSessionDeviceIdError,
    NamechangePenalty,
    RequestPaymentTargetError,
    UserInfoWeaponMaxQuanityUpperLimitError = 1001,
    UserInfoWeaponMaxQuanityExtensionError,
    UserInfoDragonMaxQuanityUpperLimitError,
    UserInfoDragonMaxQuanityExtensionError,
    TutorialUnfinished,
    TutorialStepShort,
    TutorialStepMismatchError,
    TutorialOtherAccessError,
    LoginTimeUnexpected,
    NamechangeNgwordError,
    SignupUuidDuplicated,
    SignupCreateViewerIdFailed,
    VirtualCurrencyLimitOver,
    NamechangeContinuityNumericerror,
    StaminaLimitOverError,
    SkipPointShort,
    UserInfoAmuletMaxQuanityUpperLimitError,
    UserInfoAmuletMaxQuanityExtensionError,
    TutorialStepGrantCharaMismatch,
    CharaTemporaryPointDataNotFound = 4001,
    CharaLevelMasterUndefinedError,
    CharaGrowStatusPlusCountOver,
    CharaGrowStatusPlusCountLimit,
    CharaGrowSameMaterialIdError,
    CharaGrowNotOpenPieceError = 4007,
    CharaGrowNotGetableExpAndPlus,
    CharaGrowNotBoostMaterial,
    CharaGrowManaPieceReleased,
    CharaGrowManaPieceNotMeetCondition,
    CharaGrowManaPieceDuplicated,
    CharaGrowLimitBreakCountOver,
    CharaGrowLimitBreakCountLimit,
    CharaGrowGettableLimitBreakCountError,
    AlbumTypeNotFound,
    CharaGrowAwakeRarityLimit,
    CharaGrowAwakeRarityOver,
    CharaGrowAwakeRaritySame,
    CharaGrowAwakeRarityInvalid,
    CharaGrowInvalidTemporaryChara,
    CharaGrowAwakeInvalidTemporaryChara,
    CharaGrowNoStatusPlusCount,
    CharaPlatinumGrowItemUseError,
    CharaPlatinumEventCharaGrowError,
    CharaUnitSetAbilityCrestError = 4101,
    CharaUnitSetNameInputTextNgwordError,
    DragonSellNotFound = 5001,
    DragonSellLocked,
    DragonSellEquiping,
    DragonReinforceLocked,
    DragonReinforceLimitLevel,
    DragonReinforceEquiping,
    DragonLevelMasterUndefinedError,
    DragonGrowSameMaterialIdError,
    DragonGrowSameDragonKeyIdError,
    DragonGrowRequiredMaterialError,
    DragonGrowNotBoostMaterial,
    DragonGrowLimitBreakCountLimit,
    DragonGrowBuildupUseCountLimit,
    DragonContactReliabilityLimit = 5015,
    DragonContactGiftPurchasableToday,
    DragonContactGiftOddsNotFound,
    DragonContactGiftNotPurchasableItem,
    DragonContactGiftItemNotHave,
    DragonGrowNotLimitBreakMaterial = 5021,
    DragonGrowUseMaterialDifferenceRarity,
    DragonSellSupportEquiping,
    DragonReinforceSupportEquiping,
    DragonContactGiftItemCountLimit,
    DragonGrowSphereIsDifferent,
    WeaponSellNotFound = 6001,
    WeaponSellLocked,
    WeaponSellEquiping,
    WeaponReinforceLocked,
    WeaponReinforceLimitLevel,
    WeaponReinforceEquiping,
    WeaponLevelMasterUndefinedError,
    WeaponGrowSameMaterialIdError,
    WeaponGrowSameDragonKeyIdError,
    WeaponGrowRequiredMaterialError,
    WeaponGrowNotBoostMaterial,
    WeaponGrowLimitBreakCountLimit,
    WeaponGrowBuildupUseCountLimit,
    WeaponGrowNotLimitBreakMaterial,
    WeaponGrowUseMaterialDifferenceRarity,
    WeaponSellSupportEquiping,
    WeaponReinforceSupportEquiping,
    WeaponBodyIsNotPlayable = 6101,
    WeaponBodyBuildupPieceUnablePiece,
    WeaponBodyBuildupPieceStepError,
    WeaponBodyBuildupPieceShortLevel,
    WeaponBodyBuildupPieceShortLimitBreakCount,
    WeaponBodyBuildupPieceShortLimitOverCount,
    WeaponBodyCraftOutOfPeriod,
    WeaponBodyCraftShortWeaponBody,
    WeaponBodyCraftShortAllUnlockWeaponBody,
    FriendTargetNone = 7001,
    FriendTargetAlready,
    FriendIdsearchError = 7004,
    FriendDeleteError,
    FriendCountOtherLimit,
    FriendCountLimit,
    FriendApplyCountOtherLimit,
    FriendApplyCountLimit,
    FriendApplyLimitError,
    FriendApplyExists,
    FriendApplyError,
    MemberReinforceSameBaseAndMaterrial = 8001,
    PartyUnexpected,
    PartySettingTemporaryCharaError,
    PartySettingCharaEquippedWeaponError,
    PartySettingCharaDuplicated,
    PartySettingSameAmuletId,
    PartySettingAmuletDoubleNotReleased,
    UnitGrowNoStatusPlusCount,
    PartySettingEquippedSkinWeaponError,
    PartySettingSkillCostOver,
    PartySettingEquippedTalismanError,
    PartySwitchSettingCharaShort = 8051,
    PartySwitchSettingCharaDuplicatedCharaId,
    PartySwitchSettingDragonDuplicated,
    PartyNameInputTextNgwordError = 8101,
    AbilityCrestSetNameInputTextNgwordError,
    WeaponBodyEquipableOver = 8201,
    WeaponBodyCrestSlotCountOver,
    AbilityCrestEquipableOver,
    PartySettingCharaEquippedAbilityCrestError,
    SummonUseStoneInfoNotFound = 9001,
    SummonTypeUnexpected,
    SummonTicketUpeerLimitOverError,
    SummonTicketShort,
    SummonTicketLimtTimeNotFound,
    SummonTicketLimitTimeUnexpected,
    SummonStoneShort,
    SummonRealityUnexpected,
    SummonPointShort,
    SummonPointLimit,
    SummonOutOfPeriod,
    SummonNotFound,
    SummonMasterDataNotFound,
    SummonEntityTypeUnexpected,
    SummonEffectSettingError,
    SummonEffectPresageOddsError,
    SummonEffectLotCountError,
    SummonDrawLimit,
    SummonCannotReset,
    SummonBeginnerNotTargetSummonId,
    SummonBeginnerNotTargetUser,
    SummonTicketLimitTimeUnexpectedCampaignSsr,
    SummonPointTradePointShort = 9101,
    SummonPointOutOfPeriod,
    FortPlantEffectTypeNotFound = 10001,
    FortPlantEffectIdNotFound,
    FortPlantDetailNotFound,
    FortPassiveTableNameUnexpected,
    FortMoveNotStorable,
    FortMoveNotMovable,
    FortMapProhibitedArea,
    FortMapNotFree,
    FortLevelupRankShort,
    FortLevelupNotStart,
    FortLevelupIncomplete,
    FortLevelupCarpenterBusy,
    FortLevelupAlreadyWorking,
    FortIncomeNotFound,
    FortIncomeError,
    FortIncomeCooltime,
    FortExtendCarpenterLimit,
    FortBuildRankShort,
    FortBuildPassedTheTime,
    FortBuildNumLimit,
    FortBuildNotStart,
    FortBuildNotFound,
    FortBuildIncomplete,
    FortBuildCarpenterBusy,
    ExchengeTicketUpeerLimitOverError = 11001,
    ExchengeTicketLimtTimeNotFound,
    ExchengeEntitySettingUnexpected,
    ExchangeComplete,
    TreasureTradeGroupUnexpected = 11100,
    TreasureTradeGroupLimitError,
    TradeUpeerLimitOverError,
    TradeOutThePeriod,
    TicketUseError,
    TicketShort,
    TradeClearQuestError,
    TreasureTradeTradeCountError,
    TreasureTradeNeedUnitNotFound,
    TreasureTradeNeedUnitLocked,
    EventTradeNotReachedLimit = 11501,
    EventTradeNoPreviousData,
    EventTradeItemKindTypeNotFound,
    EventOutThePeriod,
    EventCharaNotFound,
    EventTradeNotClearTargetQuest,
    EventTradeCharaSkinIsNotTrade,
    EventTradeCharaSkinNotMultipleExchange,
    TradeIncreaseUpeerLimitOverError = 11601,
    ItemUseError = 12001,
    ItemUseAlready,
    StoryNotUnread = 13001,
    StoryNotReadThePrevious,
    StoryNotGet,
    StoryCountNotEnough,
    StampEquipDataNotFound = 14001,
    NomalMissionIdOutThePeriod = 15002,
    NomalMissionIdNotFound,
    NomalMissionIdReceiveLock,
    DailyMissionIdNotFound = 15100,
    DailyMissionIdOutThePeriod,
    DailyMissionIdReceiveLock,
    PeriodMissionIdOutThePeriod = 15200,
    PeriodMissionIdNotFound,
    PeriodMissionIdReceiveLock,
    BeginnerMissionIdOutTheBeginner = 15300,
    BeginnerMissionIdNotFound,
    BeginnerMissionIdReceiveLock,
    SpecialMissionIdNotPurchased = 15400,
    SpecialMissionIdNotFound,
    SpecialMissionIdReceiveLock,
    MainStoryMissionIdOutThePeriod = 15500,
    MainStoryMissionIdNotFound,
    MainStoryMissionIdNotUnlocked,
    MemoryEventMissionIdOutThePeriod = 15600,
    MemoryEventMissionIdNotFound,
    MemoryEventMissionIdNotUnlocked,
    DrillMissionIdOutThePeriod = 15700,
    DrillMissionIdNotFound,
    DrillMissionIdNotUnlocked,
    DrillMissionGroupNotUnlocked,
    MissionIdOutTheBeginner = 15800,
    MissionIdNotFound,
    MissionIdReceiveLock,
    MissionIdOutThePeriod,
    MatchingRoomIdNotFound = 16001,
    MatchingRegistRoomSerachError,
    MatchingRegistHostSerachError,
    MatchingForceexit = 16005,
    MatchingEntryTypeUnexpected,
    MatchingDeleteroom,
    MatchingPenaltyUser,
    MatchingGuildNotJoin,
    PhotonMatchingHostNotFound = 16101,
    PhotonMatchingGuidKeyNotFound,
    PhotonMatchingGuidKeyMissmatch,
    PresentNotFound = 17001,
    PresentNotFoundError,
    AmuletSellNotFound = 18001,
    AmuletSellLocked,
    AmuletSellEquiping,
    AmuletReinforceLocked,
    AmuletReinforceLimitLevel,
    AmuletReinforceEquiping,
    AmuletLevelMasterUndefinedError,
    AmuletGrowSameMaterialIdError,
    AmuletGrowSameKeyIdError,
    AmuletGrowRequiredMaterialError,
    AmuletGrowNotBoostMaterial,
    AmuletGrowLimitBreakCountLimit,
    AmuletGrowBuildupUseCountLimit,
    AmuletGrowNotLimitBreakMaterial,
    AmuletGrowUseMaterialDifferenceRarity,
    AmuletSellSupportEquiping,
    AmuletReinforceSupportEquiping,
    AbilityCrestIsNotPlayable = 18101,
    AbilityCrestBuildupPieceUnablePiece,
    AbilityCrestBuildupPieceStepError,
    AbilityCrestBuildupPieceShortLevel,
    AbilityCrestBuildupPieceShortLimitBreakCount,
    AbilityCrestBuildupPlusCountCountError,
    CraftRupiShort = 19001,
    CraftDateRangeError,
    CraftWeaponLocked,
    CraftWeaponEquiping,
    CraftLimitBreakShort,
    CraftWeaponLevelShort,
    CraftFortLevelShort,
    CraftWeaponSupportEquiping,
    CraftWeaponHasPlusCount,
    CraftWeaponHasAlreadyKeyId,
    CraftWeaponNotApplicableKeyId,
    CraftWeaponNumberOfKeyCountDifferent,
    CraftWeaponCanNotBeDisassembled,
    BattleRetryLimit = 20001,
    BattleResultNotFound,
    BattleNotSupportQuest,
    BattleNotSupportAndMultiQuest,
    BattleNotReleaseQuest,
    BattleNotPlayableTimeQuestGroupInterval,
    BattleNotPlayableTimeQuestGroup,
    BattleNotPlayableTimeQuestDataInterval,
    BattleNotPlayableTimeQuestData,
    BattleNotMultiQuest,
    BattleNotEntryEventRaid,
    BattleNotEntryEventMaze,
    BattleNotEntryEventBuild,
    BattleCountLimitOver,
    UserDungeonDataProcessed,
    RandomDungeonAreaUnexpected,
    RandomDungeonAreaNotFound,
    QuestMissionCompleteTypeUnexpected,
    QuestUseTemporaryCharaRunout = 20020,
    QuestStaminaSingleShort,
    QuestStaminaMultiShort,
    QuestMaxPartyPowerShort,
    QuestSkipTicketNotSatisfy,
    QuestSkipTicketNotUsable,
    BattleNotEntryEvent,
    DungeonRepeatNotPlayable,
    QuestElementalInvalidate,
    QuestWeaponTypeInvalidate,
    QuestWeaponSkinWeaponTypeError,
    DungeonStartNotViaMatcing = 20100,
    DungeonRewardCmdUnexpected,
    DungeonOddsNumberUnexpected,
    DungeonEnemyOddsNotFound = 20105,
    DungeonDropPatternUnexpected,
    DungeonDropOddsUnexpected,
    DungeonAreaNotFound,
    DungeonAreaInvalidError,
    DungeonTypePartyDragonSoloNotPlayable = 20200,
    DungeonTypePartyDragonRelayNotPlayable,
    DungeonTypePartyDragonUseEnhanceChara,
    DungeonTypePartySoloUnit,
    QuestSelectBonusCommonError = 20501,
    QuestSelectBonusAlreadyReceivedError,
    QuestSelectBonusReceivableLimit,
    QuestStoryAlreadyReadError = 21001,
    QuestTreasureAlreadyOpenError = 22001,
    CastleStoryAlreadyReadError = 23001,
    CastleStoryOutOfPeriod,
    ShopPurchaseLock = 24001,
    ShopPurchaceLimitOver,
    ShopPaymentTypeInvalid,
    ShopGetBonusStaminaAlreadyReceived,
    ShopGetBonusStoneAlreadyReceived,
    ShopAstralRaidNotHeld,
    ShopAstralItemLimitOver,
    ShopPurchaseLockNotFound,
    ItemSummonExecCountOver = 25001,
    ItemSummonFreeCampaignOutOfPeriod,
    QuestWallNotPlayableWallLevel = 26001,
    QuestWallNotPlayableTime,
    QuestWallResultNotFound,
    AstralItemShort = 27001,
    GuildLockError = 28001,
    GuildPenalty,
    GuildAlreadyJoin,
    GuildAlreadyJoinRequest,
    GuildNotFound,
    GuildNotJoin,
    GuildJoinRequestNotFound,
    GuildJoiningConditionTypeMissmatch,
    GuildPositionTypeMissmatch,
    GuildJoinRequestLimit,
    GuildMemberCountLimit,
    GuildInputTextNgwordError,
    GuildInputTextContinuityNumericerror,
    GuildInputGuildNameError,
    GuildInputGuildIntroductionError,
    GuildInputGuildBoardError,
    GuildInviteNotFound = 28101,
    GuildInviteNotAuthority,
    GuildInviteNotReceiveUser,
    GuildInviteAlreadySend,
    GuildInviteSendLimit,
    GuildInviteSendBlockUser,
    GuildInviteReceivePositionTypeMissmatch,
    GuildNotAccess,
    LotteryTicketShort = 29001,
    LotteryTicketUpeerLimitOverError,
    LotteryTicketOutOfPeriod,
    LotteryOutOfPeriod,
    GatherItemShort = 30001,
    GatherItemUpeerLimitOverError,
    GatherItemTakeQuestLimitOverError,
    CommonEditSkillError = 31001,
    CharaEditSkillCannotUnlock,
    CharaEditSkillNotUnlocked,
    CharaEditSkillDefaultUnlocked,
    StorySkipNotUnlocked = 32001,
    StorySkipCommonError,
    BattleRoyalNotReleaseChara = 33001,
    BattleRoyalCommonError,
    UserBattleRoyalProcessed,
    BattleRoyalNotUsableWeaponSkin,
    BattleRoyalReleaseCharaSkinPickupEndError = 33101,
    BattleRoyalReleaseCharaSkinPickupStartError,
    WalkerOutThePeriod = 34001,
    ExchangeTicketShort = 35001,
    ExchangeTicketUpperLimitOverError,
    TalismanSellLocked = 36001,
    TalismanSellEquiping,
    TalismanSellSupportEquiping,
    TalismanSellNotFound,
    RaidEventRewardNotMeetCondition = 50001,
    RaidEventRewardNotExists,
    RaidEventItemShort,
    RaidEventItemLimit,
    RaidEventItemIdNotFound,
    MazeEventRewardNotMeetCondition = 51001,
    MazeEventRewardNotExists,
    MazeEventItemShort,
    MazeEventItemLimit,
    BuildEventItemShort = 52001,
    BuildEventItemLimit,
    BuildEventBuildCountLimitOver,
    CollectEventItemShort = 53001,
    CollectEventItemLimit,
    Clb01_EVENT_ITEM_SHORT = 54001,
    Clb01_EVENT_ITEM_LIMIT,
    ExRushEventItemShort = 55001,
    ExRushEventItemLimit,
    SimpleEventItemShort = 56001,
    SimpleEventItemLimit,
    ExHunterEventItemShort = 57001,
    ExHunterEventItemLimit,
    EventStoryAlreadyReadError = 58001,
    CombatEventItemShort = 58101,
    CombatEventItemLimit,
    EarnEventItemShort = 58201,
    EarnEventItemLimit,
    MemoryEventNotFound = 59001,
    MemoryEventNotActive,
    MemoryEventSameBaseEventActive,
    EntityUpeerLimitOverError = 60001,
    EntitySettingIdMissmatch,
    EntityRaidEventDataNotFound,
    EntityNotFoundError,
    EntityMazeEventDataNotFound,
    EntityLimitQuanitySettingError,
    EntityGiveSettingTypeUnexpected,
    EntityDuplicated,
    EntityCharaDuplicated,
    EnemyBookDuplicated,
    EntityBuildEventDataNotFound,
    EntityCollectEventDataNotFound,
    EntityClb01_EVENT_DATA_NOT_FOUND,
    EntityExRushEventDataNotFound,
    EntitySimpleEventDataNotFound,
    EntityExHunterEventDataNotFound,
    EntityCombatEventDataNotFound,
    EntityEarnEventDataNotFound,
    ModelUpdateTargetNotFound = 61001,
    ModelMultipleRecordsError,
    ModelAlbumStateUnexpected,
    TransitionSameDeviceError = 63003,
    TransitionLinkedDataNotFound = 63005,
    NpfVcmError = 65001,
    NpfVcmPaymentRequired,
    NpfVcmConsumeForbidden,
    EventEntryQuestStoryError = 66001,
    DmodeDungeonCommonError = 67001,
    DmodeDungeonUnuseableChara,
    DmodeDungeonStateError,
    DmodeDungeonRecoverError,
    DmodeDungeonFloorAlreadyEnd,
    DmodeDungeonFloorAuthKeyError,
    DmodeDungeonFloorRequestFloorNumError,
    DmodeDungeonFloorItemParamInconsistent,
    DmodeDungeonFloorDragonParamInconsistent,
    DmodeDungeonSkipFloorError = 67101,
    DmodeDungeonSkipClearFloorError,
    DmodeDungeonSkipDailyCountError,
    DmodeExpeditionUnuseableChara = 67201,
    DmodeExpeditionStateError,
    DmodeExpeditionTargetFloorError,
    DmodeExpeditionFinishFloorError,
    DmodeStoryAlreadyReadError = 67501,
    DmodeStoryOutOfPeriod,
    DmodeStoryReadConditionError,
    DmodeBuildupPassiveLevelError = 67601,
    MaintenanceStamp = 70001,
    MaintenanceShopTrade,
    MaintenanceShopStone,
    MaintenanceShopItem,
    MaintenanceShop,
    MaintenanceQuestMulti,
    MaintenanceQuestMain,
    MaintenanceQuestId,
    MaintenanceQuestEvent,
    MaintenancePartyEdit = 70012,
    MaintenanceMuseum,
    MaintenanceMission,
    MaintenanceLimitBreakWeapon,
    MaintenanceLimitBreakDragon,
    MaintenanceItem,
    MaintenanceSummon,
    MaintenanceFriend,
    MaintenanceFortKnightsStory,
    MaintenanceFortFort,
    MaintenanceFortDragonStory,
    MaintenanceFortDragonContact,
    MaintenanceFort,
    MaintenanceBuildupWeaponBody,
    MaintenanceBuildupManaCircle,
    MaintenanceBuildupDragon,
    MaintenanceBuildupChara,
    MaintenanceBuildup,
    MaintenanceFortCastleStory,
    MaintenanceCraft,
    MaintenanceShopSpecial,
    MaintenanceShopMaterial,
    MaintenanceShopMaterialSummon,
    MaintenanceShopMaterialShop,
    MaintenanceShopNormal,
    MaintenanceShopNormalDia,
    MaintenanceShopNormalStamina,
    MaintenanceShopNormalExtension,
    MaintenanceShopGetBonusStone,
    MaintenanceShopGetBonusStamina,
    MaintenanceBuildupAbilityCrest,
    MaintenanceLimitBreakAmulet,
    MaintenancePaymentIos,
    MaintenancePaymentAndroid,
    MaintenanceShopAbilityCrestTrade,
    MaintenanceQuestWall,
    MaintenanceResetPlusCount,
    MaintenanceResetPlusCountChara,
    MaintenanceResetPlusCountWeapon,
    MaintenanceResetPlusCountDragon,
    MaintenanceResetPlusCountAbilityCrest,
    MaintenanceGuild,
    MaintenanceShopBonus,
    MaintenanceShopBonusStone,
    MaintenanceShopBonusStamina,
    MaintenanceShopBonusQuest,
    MaintenanceBattleRoyalEvent,
    MaintenanceBattleRoyal,
    MaintenanceStorySkip,
    MaintenanceExchangeTicket,
    MaintenanceDmodeAll,
    MaintenanceDmodeBuildupServitor,
    MaintenanceDmodeExpedition,
    MaintenanceDmodeQuest,
    MaintenanceDmodeStory,
    SystemError = 99999
}