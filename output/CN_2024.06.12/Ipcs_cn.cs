// Generated by https://github.com/gamous/FFXIVNetworkOpcodes
namespace FFXIVOpcodes.CN
{
    public enum ServerLobbyIpcType : ushort
    {
    
    };
    
    public enum ClientLobbyIpcType : ushort
    {
    
    };
    
    public enum ServerZoneIpcType : ushort
    {
        PlayerSpawn = 0x0210,
        NpcSpawn = 0x0261,
        NpcSpawn2 = 0x0326,
        ActorFreeSpawn = 0x0200,
        ObjectSpawn = 0x0253,
        ObjectDespawn = 0x00A1,
        CreateTreasure = 0x02CD,
        OpenTreasure = 0x01ED,
        TreasureFadeOut = 0x034E,
        ActorMove = 0x03E5,
        _record_unk10_ = 0x00FB,
        Transfer = 0x02E1,
        Effect = 0x011A,
        AoeEffect8 = 0x0255,
        AoeEffect16 = 0x01AB,
        AoeEffect24 = 0x0338,
        AoeEffect32 = 0x00F1,
        ActorCast = 0x02C5,
        ActorControl = 0x019B,
        ActorControlTarget = 0x01EF,
        ActorControlSelf = 0x033F,
        DirectorVars = 0x0243,
        ContentDirectorSync = 0x0213,
        _record_unk23_ = 0x02C3,
        EnvironmentControl = 0x00E7,
        _record_unk29_ = 0x01DE,
        LandSetMap = 0x027C,
        _record_unk31_ = 0x01B1,
        EventStart = 0x01C8,
        EventFinish = 0x01D2,
        EventPlay = 0x0230,
        EventPlay4 = 0x02FB,
        EventPlay8 = 0x034B,
        EventPlay16 = 0x0279,
        EventPlay32 = 0x0384,
        EventPlay64 = 0x031C,
        EventPlay128 = 0x0312,
        EventPlay255 = 0x0069,
        BattleTalk2 = 0x02F9,
        BattleTalk4 = 0x03CE,
        BattleTalk8 = 0x02C8,
        BalloonTalk2 = 0x0302,
        BalloonTalk4 = 0x037C,
        BalloonTalk8 = 0x0324,
        SystemLogMessage = 0x03B5,
        SystemLogMessage32 = 0x0266,
        SystemLogMessage48 = 0x00DB,
        SystemLogMessage80 = 0x0134,
        SystemLogMessage144 = 0x035A,
        NpcYell = 0x00F0,
        ActorSetPos = 0x006D,
        PrepareZoning = 0x0346,
        WeatherChange = 0x0344,
        UpdateParty = 0x0210,
        UpdateAlliance = 0x0117,
        UpdateSpAlliance = 0x038F,
        UpdateHpMpTp = 0x0137,
        StatusEffectList = 0x0248,
        StatusEffectList2 = 0x017E,
        StatusEffectList3 = 0x03E3,
        EurekaStatusEffectList = 0x036A,
        BossStatusEffectList = 0x0299,
        EffectResult = 0x0298,
        EffectResult4 = 0x00A8,
        EffectResult8 = 0x0205,
        EffectResult16 = 0x00EE,
        EffectResultBasic = 0x00CB,
        EffectResultBasic4 = 0x012D,
        EffectResultBasic8 = 0x0138,
        EffectResultBasic16 = 0x00A6,
        EffectResultBasic32 = 0x01C2,
        EffectResultBasic64 = 0x0274,
        PartyPos = 0x00D7,
        AlliancePos = 0x02FD,
        SpAlliancePos = 0x0281,
        PlaceMarker = 0x01FE,
        PlaceFieldMarkerPreset = 0x0270,
        PlaceFieldMarker = 0x01C9,
        ActorGauge = 0x0207,
        CharaVisualEffect = 0x01FB,
        Fall = 0x0397,
        UpdateHate = 0x0206,
        UpdateHater = 0x03DE,
        FirstAttack = 0x0314,
        ModelEquip = 0x01CA,
        EquipDisplayFlags = 0x00B2,
        UnMount = 0x03BE,
        Mount = 0x020C,
        PlayMotionSync = 0x0173,
        CountdownInitiate = 0x01CF,
        CountdownCancel = 0x010A,
        InitZone = 0x00E1,
        Examine = 0x0233,
        ExamineSearchInfo = 0x0227,
        InventoryActionAck = 0x0080,
        MarketBoardItemListing = 0x0079,
        MarketBoardItemListingCount = 0x032E,
        MarketBoardItemListingHistory = 0x012C,
        MarketBoardSearchResult = 0x023D,
        MarketBoardPurchase = 0x0104,
        PlayerSetup = 0x01F3,
        PlayerStats = 0x0303,
        Playtime = 0x0193,
        UpdateClassInfo = 0x00C6,
        UpdateInventorySlot = 0x0187,
        UpdateSearchInfo = 0x02DA,
        WardLandInfo = 0x0389,
        CEDirector = 0x00AF,
        Logout = 0x03D6,
        FreeCompanyInfo = 0x013F,
        FreeCompanyDialog = 0x02DF,
        AirshipStatusList = 0x01F6,
        AirshipStatus = 0x0342,
        AirshipExplorationResult = 0x0208,
        SubmarineStatusList = 0x01BE,
        SubmarineProgressionStatus = 0x0197,
        SubmarineExplorationResult = 0x00AC,
        CFPreferredRole = 0x02F1,
        CompanyAirshipStatus = 0x0398,
        CompanySubmersibleStatus = 0x0377,
        ContentFinderNotifyPop = 0x02C7,
        FateInfo = 0x01B9,
        UpdateRecastTimes = 0x01AA,
        SocialList = 0x01D6,
        IslandWorkshopSupplyDemand = 0x014E,
        RSV = 0x02C4,
        RSF = 0x0294,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0319,
        ActionRequestGroundTargeted = 0x025B,
        ChatHandler = 0x03A6,
        ClientTrigger = 0x03E0,
        InventoryModifyHandler = 0x006C,
        MarketBoardPurchaseHandler = 0x0146,
        SetSearchInfoHandler = 0x00BB,
        UpdatePositionHandler = 0x0126,
        UpdatePositionInstance = 0x0246,
        Heartbeat = 0x0374,
        WorldTravel = 0x0092,
        ClientCountdownInitiate = 0x0079,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
