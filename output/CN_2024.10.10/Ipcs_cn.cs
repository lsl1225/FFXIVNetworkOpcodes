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
        PlayerSpawn = 0x03C5,
        NpcSpawn = 0x021A,
        NpcSpawn2 = 0x024B,
        ActorFreeSpawn = 0x02A2,
        ObjectSpawn = 0x012B,
        ObjectDespawn = 0x0119,
        CreateTreasure = 0x00E5,
        OpenTreasure = 0x01FA,
        TreasureFadeOut = 0x0366,
        ActorMove = 0x02BB,
        _record_unk10_ = 0x0286,
        Transfer = 0x00A5,
        Effect = 0x029E,
        AoeEffect8 = 0x0301,
        AoeEffect16 = 0x02BE,
        AoeEffect24 = 0x00C5,
        AoeEffect32 = 0x0372,
        ActorCast = 0x0247,
        ActorControl = 0x0311,
        ActorControlTarget = 0x030E,
        ActorControlSelf = 0x01A9,
        DirectorVars = 0x01D3,
        EnvironmentControl = 0x0191,
        _record_unk29_ = 0x025F,
        LandSetMap = 0x0114,
        _record_unk31_ = 0x033B,
        EventStart = 0x01E5,
        EventFinish = 0x02D0,
        EventPlay = 0x039A,
        EventPlay4 = 0x01A2,
        EventPlay8 = 0x0124,
        EventPlay16 = 0x0370,
        EventPlay32 = 0x03DF,
        EventPlay64 = 0x03CF,
        EventPlay128 = 0x009B,
        EventPlay255 = 0x0272,
        BattleTalk2 = 0x0379,
        BattleTalk4 = 0x033D,
        BattleTalk8 = 0x01CC,
        BalloonTalk2 = 0x03C9,
        BalloonTalk4 = 0x0309,
        BalloonTalk8 = 0x01BE,
        SystemLogMessage = 0x0087,
        SystemLogMessage32 = 0x016F,
        SystemLogMessage48 = 0x02B3,
        SystemLogMessage80 = 0x02DB,
        SystemLogMessage144 = 0x019A,
        NpcYell = 0x00E4,
        ActorSetPos = 0x0232,
        PrepareZoning = 0x0313,
        WeatherChange = 0x018A,
        UpdateParty = 0x03C5,
        UpdateAlliance = 0x020B,
        UpdateSpAlliance = 0x021D,
        UpdateHpMpTp = 0x00DE,
        StatusEffectList = 0x0080,
        StatusEffectList2 = 0x01F1,
        StatusEffectList3 = 0x00A4,
        EurekaStatusEffectList = 0x010C,
        BossStatusEffectList = 0x0103,
        EffectResult = 0x0179,
        EffectResult4 = 0x012D,
        EffectResult8 = 0x009C,
        EffectResult16 = 0x033C,
        EffectResultBasic = 0x0123,
        EffectResultBasic4 = 0x00CD,
        EffectResultBasic8 = 0x0358,
        EffectResultBasic16 = 0x03CC,
        EffectResultBasic32 = 0x0331,
        EffectResultBasic64 = 0x03CD,
        PartyPos = 0x01F2,
        AlliancePos = 0x00F3,
        SpAlliancePos = 0x016A,
        PlaceMarker = 0x01FC,
        PlaceFieldMarkerPreset = 0x0213,
        PlaceFieldMarker = 0x0374,
        ActorGauge = 0x024C,
        CharaVisualEffect = 0x03C6,
        Fall = 0x03E7,
        UpdateHate = 0x02E8,
        UpdateHater = 0x02A8,
        FirstAttack = 0x02A1,
        ModelEquip = 0x00EF,
        EquipDisplayFlags = 0x03C1,
        UnMount = 0x022A,
        Mount = 0x03C7,
        PlayMotionSync = 0x00E9,
        CountdownInitiate = 0x0146,
        CountdownCancel = 0x00B2,
        InitZone = 0x025D,
        Examine = 0x02DD,
        ExamineSearchInfo = 0x0184,
        InventoryActionAck = 0x03AC,
        MarketBoardItemListing = 0x0171,
        MarketBoardItemListingCount = 0x0323,
        MarketBoardItemListingHistory = 0x0382,
        MarketBoardSearchResult = 0x0335,
        MarketBoardPurchase = 0x00C6,
        PlayerSetup = 0x0212,
        PlayerStats = 0x03E6,
        Playtime = 0x0298,
        UpdateClassInfo = 0x038E,
        UpdateInventorySlot = 0x03A8,
        UpdateSearchInfo = 0x03A3,
        WardLandInfo = 0x024A,
        CEDirector = 0x02C9,
        Logout = 0x00E0,
        FreeCompanyInfo = 0x016C,
        FreeCompanyDialog = 0x01F8,
        AirshipStatusList = 0x033A,
        AirshipStatus = 0x00BD,
        AirshipExplorationResult = 0x0156,
        SubmarineStatusList = 0x031C,
        SubmarineProgressionStatus = 0x0079,
        SubmarineExplorationResult = 0x00EB,
        CFPreferredRole = 0x023C,
        CompanyAirshipStatus = 0x018B,
        CompanySubmersibleStatus = 0x0371,
        ContentFinderNotifyPop = 0x00BF,
        FateInfo = 0x00A3,
        UpdateRecastTimes = 0x0349,
        SocialList = 0x03B0,
        IslandWorkshopSupplyDemand = 0x03BB,
        RSV = 0x016D,
        RSF = 0x00BE,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x0239,
        ActionRequestGroundTargeted = 0x014D,
        ChatHandler = 0x00C7,
        ClientTrigger = 0x01F8,
        InventoryModifyHandler = 0x0201,
        MarketBoardPurchaseHandler = 0x016D,
        SetSearchInfoHandler = 0x03CA,
        UpdatePositionHandler = 0x02F0,
        UpdatePositionInstance = 0x021A,
        WorldTravel = 0x0307,
        ClientCountdownInitiate = 0x006B,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}