using System;
using AsReaderGunSDK;
using Foundation;
using ObjCRuntime;
using AsRingAccessorySDK;
//[Static]
//[Verify (ConstantsInterfaceAssociation)]
//partial interface Constants
//{
//	// extern double AsRingAccessorySDKVersionNumber;
//	[Field ("AsRingAccessorySDKVersionNumber", "__Internal")]
//	double AsRingAccessorySDKVersionNumber { get; }

//	// extern const unsigned char [] AsRingAccessorySDKVersionString;
//	[Field ("AsRingAccessorySDKVersionString", "__Internal")]
//	byte[] AsRingAccessorySDKVersionString { get; }
//}

// @interface LockParam : NSObject
namespace AsReaderGunSDK
{
    [BaseType(typeof(NSObject))]
    interface LockParam
    {
        // @property (nonatomic) BOOL killPassword;
        [Export("killPassword")]
        bool KillPassword { get; set; }

        // @property (nonatomic) BOOL accessPassword;
        [Export("accessPassword")]
        bool AccessPassword { get; set; }

        // @property (nonatomic) BOOL epc;
        [Export("epc")]
        bool Epc { get; set; }

        // @property (nonatomic) BOOL tid;
        [Export("tid")]
        bool Tid { get; set; }

        // @property (nonatomic) BOOL user;
        [Export("user")]
        bool User { get; set; }

        // -(int)value;
        [Export("value")]
        int Value { get; }
    }

    // @interface AsResultCode : NSObject
    [BaseType(typeof(NSObject))]
    interface AsResultCode
    {
        // +(NSString *)msg:(ResultCode)code;
        [Static]
        [Export("msg:")]
        string Msg(ResultCode code);
    }

    // @interface AsResultData : NSObject
    [BaseType(typeof(NSObject))]
    interface AsResultData
    {
        // -(id)initWithResultCode:(ResultCode)result data:(NSData *)data;
        [Export("initWithResultCode:data:")]
        IntPtr Constructor(ResultCode result, NSData data);

        // -(ResultCode)result;
        [Export("result")]
        ResultCode Result { get; }

        // -(NSData *)data;
        [Export("data")]
        NSData Data { get; }
    }

    // @interface AsSelectMaskParam : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface AsSelectMaskParam : INSCoding
    {
        // -(int)index;
        [Export("index")]
        int Index { get; }

        // @property (nonatomic) MaskTargetType target;
        [Export("target", ArgumentSemantic.Assign)]
        MaskTargetType Target { get; set; }

        // @property (nonatomic) MaskActionType action;
        [Export("action", ArgumentSemantic.Assign)]
        MaskActionType Action { get; set; }

        // @property (nonatomic) MemoryBank bank;
        [Export("bank", ArgumentSemantic.Assign)]
        MemoryBank Bank { get; set; }

        // @property (nonatomic) int offset;
        [Export("offset")]
        int Offset { get; set; }

        // @property (nonatomic, strong) NSString * mask;
        [Export("mask", ArgumentSemantic.Strong)]
        string Mask { get; set; }

        // @property (nonatomic) int length;
        [Export("length")]
        int Length { get; set; }

        // @property (nonatomic) BOOL used;
        [Export("used")]
        bool Used { get; set; }

        // -(id)initWithIndex:(int)index;
        [Export("initWithIndex:")]
        IntPtr Constructor(int index);

        // -(id)initWithParameterIndex:(int)index target:(MaskTargetType)maskTarget action:(MaskActionType)maskAction bank:(MemoryBank)maskBank offset:(int)maskOffset mask:(NSString *)maskData used:(BOOL)usedMask;
        [Export("initWithParameterIndex:target:action:bank:offset:mask:used:")]
        IntPtr Constructor(int index, MaskTargetType maskTarget, MaskActionType maskAction, MemoryBank maskBank, int maskOffset, string maskData, bool usedMask);

        // -(id)initWithParameterLength:(int)index target:(MaskTargetType)maskTarget action:(MaskActionType)maskAction bank:(MemoryBank)maskBank offset:(int)maskOffset mask:(NSString *)maskData length:(int)maskLength used:(BOOL)usedMask;
        [Export("initWithParameterLength:target:action:bank:offset:mask:length:used:")]
        IntPtr Constructor(int index, MaskTargetType maskTarget, MaskActionType maskAction, MemoryBank maskBank, int maskOffset, string maskData, int maskLength, bool usedMask);
    }

    // @interface AsSelectMaskEPCParam : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface AsSelectMaskEPCParam : INSCoding
    {
        // @property (nonatomic) int offset;
        [Export("offset")]
        int Offset { get; set; }

        // @property (nonatomic) int length;
        [Export("length")]
        int Length { get; set; }

        // @property (nonatomic, strong) NSString * mask;
        [Export("mask", ArgumentSemantic.Strong)]
        string Mask { get; set; }
    }

    // @interface LbtItem : NSObject
    [BaseType(typeof(NSObject))]
    interface LbtItem : INSCoding
    {
        //@property(strong, nonatomic) NSString* frequency;
        [Export("frequency", ArgumentSemantic.Strong)]
        string Frequency {get; set;}
        
        // @property (nonatomic) int mSlot;
        [Export("mSlot")]
        int MSlot { get; set; }

        // @property (nonatomic) BOOL mIsUsed;
        [Export("mIsUsed")]
        bool MIsUsed { get; set; }

        // -(id)initWithSlot:(int)slot isUsed:(BOOL)isUsed;
        [Export("initWithSlot:isUsed:")]
        IntPtr Constructor(int slot, bool isUsed);
    }

    // @protocol AsReaderGUNReadDataDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AsReaderGUNReadDataDelegate
    {
        // @required -(void)readData:(NSData *)data;
        [Abstract]
        [Export("readData:")]
        void ReadData(NSData data);
    }

    // @interface AsReaderGUN : AsRingAccessoryBaseSDK
    [BaseType(typeof(AsRingAccessoryBaseSDK))]
    interface AsReaderGUN
    {
        [Wrap("WeakDelegate")]
        AsReaderGUNReadDataDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AsReaderGUNReadDataDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) NSString * deviceModel;
        [Export("deviceModel", ArgumentSemantic.Strong)]
        string DeviceModel { get; set; }

        // @property (assign, nonatomic) BOOL isConnect;
        [Export("isConnect")]
        bool IsConnect { get; set; }

        // -(instancetype)initWithDeviceModel:(NSString *)deviceModel;
        [Export("initWithDeviceModel:")]
        IntPtr Constructor(string deviceModel);

        // -(NSString *)address;
        [Export("address")]
        string Address { get; }

        // -(void)disconnect;
        [Export("disconnect")]
        void Disconnect();

        // -(void)writeData:(NSData *)data;
        [Export("writeData:")]
        void WriteData(NSData data);

        // -(NSString *)getAsReaderGUNVersion;
        [Export("getAsReaderGUNVersion")]
        string AsReaderGUNVersion { get; }
    }

    // @interface AsPacket : NSObject
    [BaseType(typeof(NSObject))]
    interface AsPacket
    {
        // @property (nonatomic) NSInteger errorCode;
        [Export("errorCode")]
        nint ErrorCode { get; set; }

        // @property (nonatomic, strong) NSData * data;
        [Export("data", ArgumentSemantic.Strong)]
        NSData Data { get; set; }

        // -(id)initWithPacketType:(PacketType)type subType:(uint8_t)subType;
        [Export("initWithPacketType:subType:")]
        IntPtr Constructor(PacketType type, byte subType);

        // -(PacketType)type;
        [Export("type")]
        PacketType Type { get; }

        // -(uint8_t)subType;
        [Export("subType")]
        byte SubType { get; }

        // -(void)signal;
        [Export("signal")]
        void Signal();

        // -(void)wait;
        [Export("wait")]
        void Wait();

        // -(BOOL)equalPacket:(PacketType)type subType:(uint8_t)subType;
        [Export("equalPacket:subType:")]
        bool EqualPacket(PacketType type, byte subType);

        // -(BOOL)checkTimeoutInterval:(int)interval withTimeout:(int)maxTimeout;
        [Export("checkTimeoutInterval:withTimeout:")]
        bool CheckTimeoutInterval(int interval, int maxTimeout);
    }

    // @interface AsPacketManager : NSObject
    [BaseType(typeof(NSObject))]
    interface AsPacketManager
    {
        // -(void)addPacket:(AsPacket *)packet;
        [Export("addPacket:")]
        void AddPacket(AsPacket packet);

        // -(AsPacket *)waitPacket:(PacketType)type subType:(uint8_t)subType;
        [Export("waitPacket:subType:")]
        AsPacket WaitPacket(PacketType type, byte subType);

        // -(AsPacket *)findPacket:(PacketType)type subType:(uint8_t)subType;
        [Export("findPacket:subType:")]
        AsPacket FindPacket(PacketType type, byte subType);

        // -(AsPacket *)firstPacket;
        [Export("firstPacket")]
        AsPacket FirstPacket { get; }

        // -(void)removePacket:(AsPacket *)packet;
        [Export("removePacket:")]
        void RemovePacket(AsPacket packet);

        // -(BOOL)isWaitPacket;
        [Export("isWaitPacket")]
        bool IsWaitPacket { get; }
    }

    // @interface AsBarcodeType : NSObject
    [BaseType(typeof(NSObject))]
    interface AsBarcodeType
    {
        // +(BarcodeType)getBarcodeType:(unsigned char)byte;
        [Static]
        [Export("getBarcodeType:")]
        BarcodeType GetBarcodeType(byte @byte);

        // +(BarcodeType)getNotRFPRISMABarcodeType:(unsigned char)byte;
        [Static]
        [Export("getNotRFPRISMABarcodeType:")]
        BarcodeType GetNotRFPRISMABarcodeType(byte @byte);

        // +(NSString *)getBarcodeString:(BarcodeType)barcodeType;
        [Static]
        [Export("getBarcodeString:")]
        string GetBarcodeString(BarcodeType barcodeType);
    }

    // @protocol AsReaderDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AsReaderDelegate
    {
        // @optional -(void)readerInitialized:(AsReader *)reader;
        [Export("readerInitialized:")]
        void ReaderInitialized(AsReader reader);

        // @optional -(void)updateDeviceState:(ResultCode)error;
        [Export("updateDeviceState:")]
        void UpdateDeviceState(ResultCode error);

        // @optional -(void)readTag:(NSString *)tag rssi:(float)rssi phase:(float)phase frequency:(float)frequency;
        [Export("readTag:rssi:phase:frequency:")]
        void ReadTag(string tag, float rssi, float phase, float frequency);

        // @optional -(void)changedActionState:(CommandType)action resultCode:(NSInteger)resultCode;
        [Export("changedActionState:resultCode:")]
        void ChangedActionState(CommandType action, nint resultCode);

        // @optional -(void)detectBarcode:(BarcodeType)barcodeType codeId:(NSString *)codeId barcode:(NSString *)barcode;
        [Export("detectBarcode:codeId:barcode:")]
        void DetectBarcode(BarcodeType barcodeType, string codeId, string barcode);

        // @optional -(void)detectBarcode:(BarcodeType)barcodeType codeId:(NSString *)codeId barcodeData:(NSData *)barcodeData;
        [Export("detectBarcode:codeId:barcodeData:")]
        void DetectBarcode(BarcodeType barcodeType, string codeId, NSData barcodeData);

        // @optional -(void)accessResult:(ResultCode)error actionState:(CommandType)action epc:(NSString *)epc data:(NSString *)data rssi:(float)rssi phase:(float)phase;
        [Export("accessResult:actionState:epc:data:rssi:phase:")]
        void AccessResult(ResultCode error, CommandType action, string epc, string data, float rssi, float phase);

        // @optional -(void)commandComplete:(CommandType)command;
        [Export("commandComplete:")]
        void CommandComplete(CommandType command);

        // @optional -(BOOL)onAsReaderLeftModeKeyEvent:(BOOL)status;
        [Export("onAsReaderLeftModeKeyEvent:")]
        bool OnAsReaderLeftModeKeyEvent(bool status);

        // @optional -(BOOL)onAsReaderRightModeKeyEvent:(BOOL)status;
        [Export("onAsReaderRightModeKeyEvent:")]
        bool OnAsReaderRightModeKeyEvent(bool status);

        // @optional -(BOOL)onAsReaderTriggerKeyEvent:(BOOL)status;
        [Export("onAsReaderTriggerKeyEvent:")]
        bool OnAsReaderTriggerKeyEvent(bool status);
    }

    // @interface AsProtocolAsReader : NSObject
    [BaseType(typeof(NSObject))]
    interface AsProtocolAsReader
    {
        [Wrap("WeakDelegate")]
        AsReaderDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AsReaderDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL isBarcodeMode;
        [Export("isBarcodeMode")]
        bool IsBarcodeMode { get; set; }

        // @property (assign, nonatomic) int dataType;
        [Export("dataType")]
        int DataType { get; set; }

        // @property (assign, nonatomic) int versionCode;
        [Export("versionCode")]
        int VersionCode { get; set; }

        // @property (assign, nonatomic) BOOL isReportRssi;
        [Export("isReportRssi")]
        bool IsReportRssi { get; set; }

        // @property (assign, nonatomic) ScanMode scanMode;
        [Export("scanMode", ArgumentSemantic.Assign)]
        ScanMode ScanMode { get; set; }

        // -(id)initWithAsReaderGUN:(AsReaderGUN *)asReaderGUN delegate:(id<AsReaderDelegate>)receiver;
        [Export("initWithAsReaderGUN:delegate:")]
        IntPtr Constructor(AsReaderGUN asReaderGUN, AsReaderDelegate receiver);

        // -(void)disconnect;
        [Export("disconnect")]
        void Disconnect();

        // -(CommandType)getAction;
        [Export("getAction")]
        CommandType Action { get; }

        // -(NSString *)getProperty:(PropertyType)type;
        [Export("getProperty:")]
        string GetProperty(PropertyType type);

        // -(NSString *)getProperty:(PropertyType)type withParameter:(NSString *)param;
        [Export("getProperty:withParameter:")]
        string GetProperty(PropertyType type, string param);

        // -(ResultCode)setProperty:(PropertyType)type;
        [Export("setProperty:")]
        ResultCode SetProperty(PropertyType type);

        // -(ResultCode)setProperty:(PropertyType)type withParameter:(NSString *)param;
        [Export("setProperty:withParameter:")]
        ResultCode SetProperty(PropertyType type, string param);

        // -(ResultCode)command:(CommandType)command;
        [Export("command:")]
        ResultCode Command(CommandType command);

        // -(ResultCode)command:(CommandType)command withParameter:(NSString *)param;
        [Export("command:withParameter:")]
        ResultCode Command(CommandType command, string param);

        // -(AsResultData *)commandSync:(CommandType)command withParameter:(NSString *)param;
        [Export("commandSync:withParameter:")]
        AsResultData CommandSync(CommandType command, string param);

        // -(ResultCode)debug:(DebugType)debugType;
        [Export("debug:")]
        ResultCode Debug(DebugType debugType);

        // -(ResultCode)debug:(DebugType)debugType withParameter:(NSString *)param;
        [Export("debug:withParameter:")]
        ResultCode Debug(DebugType debugType, string param);

        // -(AsResultData *)debugSync:(DebugType)command withParameter:(NSString *)param;
        [Export("debugSync:withParameter:")]
        AsResultData DebugSync(DebugType command, string param);

        // -(void)wakeUpBarcode;
        [Export("wakeUpBarcode")]
        void WakeUpBarcode();

        // -(ResultCode)postSSI:(SSICommand)command;
        [Export("postSSI:")]
        ResultCode PostSSI(SSICommand command);

        // -(ResultCode)postSSI:(SSICommand)command withData:(NSData *)data;
        [Export("postSSI:withData:")]
        ResultCode PostSSI(SSICommand command, NSData data);

        // -(AsResultData *)sendSSI:(SSICommand)command;
        [Export("sendSSI:")]
        AsResultData SendSSI(SSICommand command);

        // -(AsResultData *)sendSSI:(SSICommand)command withData:(NSData *)data;
        [Export("sendSSI:withData:")]
        AsResultData SendSSI(SSICommand command, NSData data);

        // -(NSData *)getBarcodeProperty:(PropertyType)type withParameter:(NSData *)param;
        [Export("getBarcodeProperty:withParameter:")]
        NSData GetBarcodeProperty(PropertyType type, NSData param);

        // -(AsResultData *)setBarcodeProperty:(PropertyType)type withParameter:(NSData *)param;
        [Export("setBarcodeProperty:withParameter:")]
        AsResultData SetBarcodeProperty(PropertyType type, NSData param);

        // -(void)setBarcodeContinueMode:(BOOL)isContinueMode;
        [Export("setBarcodeContinueMode:")]
        void SetBarcodeContinueMode(bool isContinueMode);

        // -(void)receiveData;
        [Export("receiveData")]
        void ReceiveData();

        // -(void)setReaderType:(ReaderType)readertype;
        [Export("setReaderType:")]
        void SetReaderType(ReaderType readertype);
    }

    // @interface AsModuleAsReader : NSObject
    [BaseType(typeof(NSObject))]
    interface AsModuleAsReader
    {
        // -(id)initWithProtocol:(AsProtocolAsReader *)protocol;
        [Export("initWithProtocol:")]
        IntPtr Constructor(AsProtocolAsReader protocol);

        // -(NSString *)regionName;
        [Export("regionName")]
        string RegionName { get; }

        // -(NSString *)UHFVersion;
        [Export("UHFVersion")]
        string UHFVersion { get; }

        // -(NSString *)firmwareVersion;
        [Export("firmwareVersion")]
        string FirmwareVersion { get; }

        // -(CMinMaxValue)powerGainRange;
        [Export("powerGainRange")]
        CMinMaxValue PowerGainRange { get; }

        // -(ResultCode)readMemory:(MemoryBank)bank offset:(int)offset length:(int)length;
        [Export("readMemory:offset:length:")]
        ResultCode ReadMemory(MemoryBank bank, int offset, int length);

        // -(ResultCode)writeMemory:(MemoryBank)bank offset:(int)offset value:(NSString *)value;
        [Export("writeMemory:offset:value:")]
        ResultCode WriteMemory(MemoryBank bank, int offset, string value);

        // -(ResultCode)lock:(int)action mask:(int)mask;
        [Export("lock:mask:")]
        ResultCode Lock(int action, int mask);

        // -(ResultCode)permaLock:(int)action mask:(int)mask;
        [Export("permaLock:mask:")]
        ResultCode PermaLock(int action, int mask);

        // -(ResultCode)kill:(NSString *)killPassword;
        [Export("kill:")]
        ResultCode Kill(string killPassword);

        // -(ResultCode)blockWrite:(MemoryBank)bank offset:(int)offset value:(NSString *)value;
        [Export("blockWrite:offset:value:")]
        ResultCode BlockWrite(MemoryBank bank, int offset, string value);

        // -(ResultCode)blockErase:(MemoryBank)bank offset:(int)offset length:(int)length;
        [Export("blockErase:offset:length:")]
        ResultCode BlockErase(MemoryBank bank, int offset, int length);

        // -(ResultCode)saveStoredTag:(NSString *)tag;
        [Export("saveStoredTag:")]
        ResultCode SaveStoredTag(string tag);

        // -(MaskTargetType)getMaskTarget:(int)index;
        [Export("getMaskTarget:")]
        MaskTargetType GetMaskTarget(int index);

        // -(void)setMaskTarget:(int)index maskTargetType:(MaskTargetType)target;
        [Export("setMaskTarget:maskTargetType:")]
        void SetMaskTarget(int index, MaskTargetType target);

        // -(MaskActionType)getMaskAction:(int)index;
        [Export("getMaskAction:")]
        MaskActionType GetMaskAction(int index);

        // -(void)setMaskAction:(int)index maskActionType:(MaskActionType)action;
        [Export("setMaskAction:maskActionType:")]
        void SetMaskAction(int index, MaskActionType action);

        // -(MemoryBank)getMaskBank:(int)index;
        [Export("getMaskBank:")]
        MemoryBank GetMaskBank(int index);

        // -(void)setMaskBank:(int)index maskBank:(MemoryBank)bank;
        [Export("setMaskBank:maskBank:")]
        void SetMaskBank(int index, MemoryBank bank);

        // -(int)getMaskOffset:(int)index;
        [Export("getMaskOffset:")]
        int GetMaskOffset(int index);

        // -(void)setMaskOffset:(int)index maskOffset:(int)offset;
        [Export("setMaskOffset:maskOffset:")]
        void SetMaskOffset(int index, int offset);

        // -(NSArray *)getMask:(int)index;
        [Export("getMask:")]
        NSObject[] GetMask(int index);

        // -(void)setMask:(int)index mask:(NSString *)mask;
        [Export("setMask:mask:")]
        void SetMask(int index, string mask);

        // -(void)setMask:(int)index mask:(NSString *)mask length:(int)length;
        [Export("setMask:mask:length:")]
        void SetMask(int index, string mask, int length);

        // -(BOOL)getMaskUsed:(int)index;
        [Export("getMaskUsed:")]
        bool GetMaskUsed(int index);

        // -(void)setMaskUsed:(int)index used:(BOOL)used;
        [Export("setMaskUsed:used:")]
        void SetMaskUsed(int index, bool used);

        // -(void)clearEpcMask;
        [Export("clearEpcMask")]
        void ClearEpcMask();

        // -(void)saveEpcMask;
        [Export("saveEpcMask")]
        void SaveEpcMask();

        // -(unsigned long long)getEpcMaskCount;
        [Export("getEpcMaskCount")]
        ulong EpcMaskCount { get; }

        // -(void)addEpcMask:(AsSelectMaskEPCParam *)param;
        [Export("addEpcMask:")]
        void AddEpcMask(AsSelectMaskEPCParam param);

        // -(AsSelectMaskEPCParam *)getEpcMask:(int)index;
        [Export("getEpcMask:")]
        AsSelectMaskEPCParam GetEpcMask(int index);

        // -(BOOL)getEpcMaskMatchMode;
        [Export("getEpcMaskMatchMode")]
        bool EpcMaskMatchMode { get; }

        // -(void)setEpcMaskMatchMode:(BOOL)enabled;
        [Export("setEpcMaskMatchMode:")]
        void SetEpcMaskMatchMode(bool enabled);

        // -(unsigned long long)getLBTMask;
        [Export("getLBTMask")]
        ulong LBTMask { get; }

        // -(unsigned long long)getLBT;
        [Export("getLBT")]
        ulong LBT { get; }

        // -(void)setLBT:(long)table;
        [Export("setLBT:")]
        void SetLBT(nint table);

        // -(unsigned long long)getLBTFrequency:(int)index;
        [Export("getLBTFrequency:")]
        ulong GetLBTFrequency(int index);

        // -(void)setTagDataType:(int)tagData;
        [Export("setTagDataType:")]
        void SetTagDataType(int tagData);

        // -(NSData *)getBarcodeParam:(NSData *)data;
        [Export("getBarcodeParam:")]
        NSData GetBarcodeParam(NSData data);

        // -(ResultCode)setBarcodeParam:(NSData *)data;
        [Export("setBarcodeParam:")]
        ResultCode SetBarcodeParam(NSData data);

        // -(int)barcodePowerState;
        // -(void)setBarcodePowerState:(int)state;
        [Export("barcodePowerState")]
        int BarcodePowerState { get; set; }

        // -(int)getBarcodeState;
        [Export("getBarcodeState")]
        int GetBarcodeState();

        // -(_Bool)getBarcodeMode;
        [Export("getBarcodeMode")]
        bool GetBarcodeMode();

        // -(void)setVersionCode:(int)versionCode;
        [Export("setVersionCode:")]
        void SetVersionCode(int versionCode);

        // -(void)setDebugMode:(BOOL)enabled;
        [Export("setDebugMode:")]
        void SetDebugMode(bool enabled);

        // -(BOOL)getDebugConfig:(NSString *)barcode;
        [Export("getDebugConfig:")]
        bool GetDebugConfig(string barcode);

        // -(void)setReaderType:(ReaderType)readertype;
        [Export("setReaderType:")]
        void SetReaderType(ReaderType readertype);
    }

    // @interface AsParamName : NSObject
    [BaseType(typeof(NSObject))]
    interface AsParamName
    {
        // +(NSString *)getTag:(ParamName)paramName;
        [Static]
        [Export("getTag:")]
        string GetTag(ParamName paramName);

        // +(NSString *)getName:(ParamName)paramName;
        [Static]
        [Export("getName:")]
        string GetName(ParamName paramName);

        // +(ParamName)startWith:(NSString *)tag;
        [Static]
        [Export("startWith:")]
        ParamName StartWith(string tag);
    }

    // @interface AsParamValue : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface AsParamValue : INSCoding
    {
        // @property (assign, readwrite) ParamName paramName;
        [Export("paramName", ArgumentSemantic.Assign)]
        ParamName ParamName { get; set; }

        // @property (assign, readwrite) unsigned int value;
        [Export("value")]
        uint Value { get; set; }

        // -(void)setEnabled:(BOOL)value;
        [Export("setEnabled:")]
        void SetEnabled(bool value);
    }

    // @interface AsReader : NSObject
    [BaseType(typeof(NSObject))]
    interface AsReader
    {
        // -(id)initWithAsReaderGUN:(AsReaderGUN *)device delegate:(id<AsReaderDelegate>)delegate;
        [Export("initWithAsReaderGUN:delegate:")]
        IntPtr Constructor(AsReaderGUN device, AsReaderDelegate @delegate);

        // -(void)disconnect;
        [Export("disconnect")]
        void Disconnect();

        // -(CommandType)getAction;
        [Export("getAction")]
        CommandType Action { get; }

        // -(void)setDelegate:(id<AsReaderDelegate>)delegate;
        [Export("setDelegate:")]
        void SetDelegate(AsReaderDelegate @delegate);

        // -(void)setScanMode:(ScanMode)scanMode;
        [Export("setScanMode:")]
        void SetScanMode(ScanMode scanMode);

        // -(ScanMode)getScanMode;
        [Export("getScanMode")]
        ScanMode ScanMode { get; }

        // -(ResultCode)inventory;
        [Export("inventory")]
        ResultCode Inventory { get; }

        // -(ResultCode)readMemory:(MemoryBank)bank offset:(int)offset length:(int)length;
        [Export("readMemory:offset:length:")]
        ResultCode ReadMemory(MemoryBank bank, int offset, int length);

        // -(ResultCode)writeMemory:(MemoryBank)bank offset:(int)offset value:(NSString *)value;
        [Export("writeMemory:offset:value:")]
        ResultCode WriteMemory(MemoryBank bank, int offset, string value);

        // -(ResultCode)lock:(LockParam *)param;
        [Export("lock:")]
        ResultCode Lock(LockParam param);

        // -(ResultCode)unlock:(LockParam *)param;
        [Export("unlock:")]
        ResultCode Unlock(LockParam param);

        // -(ResultCode)permaLock:(LockParam *)param;
        [Export("permaLock:")]
        ResultCode PermaLock(LockParam param);

        // -(ResultCode)kill:(NSString *)killPassword;
        [Export("kill:")]
        ResultCode Kill(string killPassword);

        // -(ResultCode)blockWrite:(MemoryBank)bank offset:(int)offset value:(NSString *)value;
        [Export("blockWrite:offset:value:")]
        ResultCode BlockWrite(MemoryBank bank, int offset, string value);

        // -(ResultCode)blockErase:(MemoryBank)bank offset:(int)offset length:(int)length;
        [Export("blockErase:offset:length:")]
        ResultCode BlockErase(MemoryBank bank, int offset, int length);

        // -(ResultCode)stop;
        [Export("stop")]
        ResultCode Stop { get; }

        // -(ResultCode)stopSync;
        [Export("stopSync")]
        ResultCode StopSync { get; }

        // -(ResultCode)softReset;
        [Export("softReset")]
        ResultCode SoftReset { get; }

        // -(ResultCode)hardReset;
        [Export("hardReset")]
        ResultCode HardReset { get; }

        // -(ResultCode)defaultParameter;
        [Export("defaultParameter")]
        ResultCode DefaultParameter { get; }

        // -(ResultCode)saveParameter;
        [Export("saveParameter")]
        ResultCode SaveParameter { get; }

        // -(ResultCode)setDebugMode:(BOOL)enabled;
        [Export("setDebugMode:")]
        ResultCode SetDebugMode(bool enabled);

        // -(ResultCode)loadDebugMessage;
        [Export("loadDebugMessage")]
        ResultCode LoadDebugMessage { get; }

        // -(ResultCode)enterBypassMode;
        [Export("enterBypassMode")]
        ResultCode EnterBypassMode { get; }

        // -(ResultCode)enterBarcodeBypassMode;
        [Export("enterBarcodeBypassMode")]
        ResultCode EnterBarcodeBypassMode { get; }

        // -(ResultCode)leaveBypassMode;
        [Export("leaveBypassMode")]
        ResultCode LeaveBypassMode { get; }

        // -(NSString *)regionName;
        [Export("regionName")]
        string RegionName { get; }

        // -(NSString *)rFModuleVersion;
        [Export("rFModuleVersion")]
        string RFModuleVersion { get; }

        // -(NSString *)firmwareVersion;
        [Export("firmwareVersion")]
        string FirmwareVersion { get; }

        // -(CMinMaxValue)powerGainRange;
        [Export("powerGainRange")]
        CMinMaxValue PowerGainRange { get; }

        // -(int)storedCount;
        [Export("storedCount")]
        int StoredCount { get; }

        // -(int)batteryStatus;
        [Export("batteryStatus")]
        int BatteryStatus { get; }

        // -(ResultCode)clearEpcMask;
        [Export("clearEpcMask")]
        ResultCode ClearEpcMask { get; }

        // -(ResultCode)saveEpcMask;
        [Export("saveEpcMask")]
        ResultCode SaveEpcMask { get; }

        // -(int)epcMaskCount;
        [Export("epcMaskCount")]
        int EpcMaskCount { get; }

        // -(ResultCode)addEpcMask:(int)offset length:(int)length mask:(NSString *)mask;
        [Export("addEpcMask:length:mask:")]
        ResultCode AddEpcMask(int offset, int length, string mask);

        // -(ResultCode)addEpcMask:(AsSelectMaskEPCParam *)mask;
        [Export("addEpcMask:")]
        ResultCode AddEpcMask(AsSelectMaskEPCParam mask);

        // -(AsSelectMaskEPCParam *)getEpcMask:(int)index;
        [Export("getEpcMask:")]
        AsSelectMaskEPCParam GetEpcMask(int index);

        // -(NSArray *)getLBTMask;
        [Export("getLBTMask")]
        NSObject[] LBTMask { get; }

        // -(NSArray *)getLBT;
        [Export("getLBT")]
        NSObject[] LBT { get; }

        // -(void)setLBT:(NSArray *)table;
        [Export("setLBT:")]
        void SetLBT(NSObject[] table);

        // -(NSString *)getLBTFrequency:(int)slot;
        [Export("getLBTFrequency:")]
        string GetLBTFrequency(int slot);

        // -(ResultCode)startBuzzerWithBuzzerTime:(int)buzzerTime;
        [Export("startBuzzerWithBuzzerTime:")]
        ResultCode StartBuzzerWithBuzzerTime(int buzzerTime);

        // -(ResultCode)startVibratorWithVibratorTime:(int)vibratorTime;
        [Export("startVibratorWithVibratorTime:")]
        ResultCode StartVibratorWithVibratorTime(int vibratorTime);

        // -(void)wakeUpBarcode;
        [Export("wakeUpBarcode")]
        void WakeUpBarcode();

        // -(ResultCode)startDecode;
        [Export("startDecode")]
        ResultCode StartDecode { get; }

        // -(ResultCode)stopDecode;
        [Export("stopDecode")]
        ResultCode StopDecode { get; }

        // -(ResultCode)setBarcodeParam:(AsParamValue *)paramData;
        [Export("setBarcodeParam:")]
        ResultCode SetBarcodeParam(AsParamValue paramData);

        // -(NSArray *)getBarcodeParams:(NSArray *)paramData;
        [Export("getBarcodeParams:")]
        NSObject[] GetBarcodeParams(NSObject[] paramData);

        // -(AsParamValue *)getBarcodeParam:(NSNumber *)paramData;
        [Export("getBarcodeParam:")]
        AsParamValue GetBarcodeParam(NSNumber paramData);

        // -(ResultCode)aimOff;
        [Export("aimOff")]
        ResultCode AimOff { get; }

        // -(ResultCode)aimOn;
        [Export("aimOn")]
        ResultCode AimOn { get; }

        // -(NSString *)getRevision;
        [Export("getRevision")]
        string Revision { get; }

        // -(ResultCode)ledOff;
        [Export("ledOff")]
        ResultCode LedOff { get; }

        // -(ResultCode)ledOn;
        [Export("ledOn")]
        ResultCode LedOn { get; }

        // -(BOOL)usedSelectionMask:(int)index;
        [Export("usedSelectionMask:")]
        bool UsedSelectionMask(int index);

        // -(AsSelectMaskParam *)getSelectionMask:(int)index;
        [Export("getSelectionMask:")]
        AsSelectMaskParam GetSelectionMask(int index);

        // -(void)setSelectionMask:(int)index withParam:(AsSelectMaskParam *)param;
        [Export("setSelectionMask:withParam:")]
        void SetSelectionMask(int index, AsSelectMaskParam param);

        // -(void)removeSelectionMask:(int)index;
        [Export("removeSelectionMask:")]
        void RemoveSelectionMask(int index);

        // -(void)clearSelectionMask;
        [Export("clearSelectionMask")]
        void ClearSelectionMask();

        // @property (nonatomic, strong) AsReaderGUN * mAsReaderGUN;
        [Export("mAsReaderGUN", ArgumentSemantic.Strong)]
        AsReaderGUN MAsReaderGUN { get; set; }

        // @property (assign, nonatomic) BuzzerState buzzer;
        [Export("buzzer", ArgumentSemantic.Assign)]
        BuzzerState Buzzer { get; set; }

        // @property (assign, nonatomic) VibratorState vibrator;
        [Export("vibrator", ArgumentSemantic.Assign)]
        VibratorState Vibrator { get; set; }

        // @property (assign, nonatomic) RegionType region;
        [Export("region", ArgumentSemantic.Assign)]
        RegionType Region { get; set; }

        // @property (assign, nonatomic) int operationTime;
        [Export("operationTime")]
        int OperationTime { get; set; }

        // @property (assign, nonatomic) int inventoryTime;
        [Export("inventoryTime")]
        int InventoryTime { get; set; }

        // @property (assign, nonatomic) int idleTime;
        [Export("idleTime")]
        int IdleTime { get; set; }

        // @property (assign, nonatomic) int sleepTime;
        [Export("sleepTime")]
        int SleepTime { get; set; }

        // @property (assign, nonatomic) int sameReportTime;
        [Export("sameReportTime")]
        int SameReportTime { get; set; }

        // @property (assign, nonatomic) int autoOffTime;
        [Export("autoOffTime")]
        int AutoOffTime { get; set; }

        // @property (nonatomic, strong) NSString * accessPassword;
        [Export("accessPassword", ArgumentSemantic.Strong)]
        string AccessPassword { get; set; }

        // @property (assign, nonatomic) SessionType inventorySession;
        [Export("inventorySession", ArgumentSemantic.Assign)]
        SessionType InventorySession { get; set; }

        // @property (assign, nonatomic) SessionFlag sessionFlag;
        [Export("sessionFlag", ArgumentSemantic.Assign)]
        SessionFlag SessionFlag { get; set; }

        // @property (nonatomic, strong) AsSelectMaskParam * selectionMask;
        [Export("selectionMask", ArgumentSemantic.Strong)]
        AsSelectMaskParam SelectionMask { get; set; }

        // @property (nonatomic, strong) NSDate * time;
        [Export("time", ArgumentSemantic.Strong)]
        NSDate Time { get; set; }

        // @property (nonatomic, strong) NSString * serialNumber;
        [Export("serialNumber", ArgumentSemantic.Strong)]
        string SerialNumber { get; set; }

        // @property (assign, nonatomic) BOOL remoteMode;
        [Export("remoteMode")]
        bool RemoteMode { get; set; }

        // @property (assign, nonatomic) BOOL continuousMode;
        [Export("continuousMode")]
        bool ContinuousMode { get; set; }

        // @property (assign, nonatomic) int limitTagCount;
        [Export("limitTagCount")]
        int LimitTagCount { get; set; }

        // @property (assign, nonatomic) int powerGain;
        [Export("powerGain")]
        int PowerGain { get; set; }

        // @property (assign, nonatomic) BOOL isUseKeyAction;
        [Export("isUseKeyAction")]
        bool IsUseKeyAction { get; set; }

        // @property (assign, nonatomic) SelectFlag useSelectionMask;
        [Export("useSelectionMask", ArgumentSemantic.Assign)]
        SelectFlag UseSelectionMask { get; set; }

        // @property (assign, nonatomic) BOOL reportMode;
        [Export("reportMode")]
        bool ReportMode { get; set; }

        // @property (assign, nonatomic) BOOL storedMode;
        [Export("storedMode")]
        bool StoredMode { get; set; }

        // @property (assign, nonatomic) BOOL rssiMode;
        [Export("rssiMode")]
        bool RssiMode { get; set; }

        // @property (assign, nonatomic) BOOL epcMaskMatchMode;
        [Export("epcMaskMatchMode")]
        bool EpcMaskMatchMode { get; set; }

        // -(MaskTargetType)getMaskTarget:(int)index;
        [Export("getMaskTarget:")]
        MaskTargetType GetMaskTarget(int index);

        // -(void)setMaskTarget:(int)index maskTargetType:(MaskTargetType)target;
        [Export("setMaskTarget:maskTargetType:")]
        void SetMaskTarget(int index, MaskTargetType target);

        // -(MaskActionType)getMaskAction:(int)index;
        [Export("getMaskAction:")]
        MaskActionType GetMaskAction(int index);

        // -(void)setMaskAction:(int)index maskActionType:(MaskActionType)action;
        [Export("setMaskAction:maskActionType:")]
        void SetMaskAction(int index, MaskActionType action);

        // -(MemoryBank)getMaskBank:(int)index;
        [Export("getMaskBank:")]
        MemoryBank GetMaskBank(int index);

        // -(void)setMaskBank:(int)index maskBank:(MemoryBank)bank;
        [Export("setMaskBank:maskBank:")]
        void SetMaskBank(int index, MemoryBank bank);

        // -(int)getMaskOffset:(int)index;
        [Export("getMaskOffset:")]
        int GetMaskOffset(int index);

        // -(void)setMaskOffset:(int)index maskOffset:(int)offset;
        [Export("setMaskOffset:maskOffset:")]
        void SetMaskOffset(int index, int offset);

        // -(NSArray *)getMask:(int)index;
        [Export("getMask:")]
        NSObject[] GetMask(int index);

        // -(void)setMask:(int)index mask:(NSString *)mask;
        [Export("setMask:mask:")]
        void SetMask(int index, string mask);

        // -(void)setMask:(int)index mask:(NSString *)mask length:(int)length;
        [Export("setMask:mask:length:")]
        void SetMask(int index, string mask, int length);

        // -(BOOL)getMaskUsed:(int)index;
        [Export("getMaskUsed:")]
        bool GetMaskUsed(int index);

        // -(void)setMaskUsed:(int)index used:(BOOL)used;
        [Export("setMaskUsed:used:")]
        void SetMaskUsed(int index, bool used);

        // @property (assign, nonatomic) AlgorithmType algorithm;
        [Export("algorithm", ArgumentSemantic.Assign)]
        AlgorithmType Algorithm { get; set; }

        // -(AlgorithmType)getAlgorithm;
        //[Export ("getAlgorithm")]
        //AlgorithmType Algorithm { get; }

        // @property (assign, nonatomic) int minQ;
        [Export("minQ")]
        int MinQ { get; set; }

        // @property (assign, nonatomic) int maxQ;
        [Export("maxQ")]
        int MaxQ { get; set; }

        // @property (assign, nonatomic) int qValue;
        [Export("qValue")]
        int QValue { get; set; }

        // @property (assign, nonatomic) int linkProfileValue;
        [Export("linkProfileValue")]
        int LinkProfileValue { get; set; }

        // @property (assign, nonatomic) int defaultLinkProfileValue;
        [Export("defaultLinkProfileValue")]
        int DefaultLinkProfileValue { get; set; }

        // @property (assign, nonatomic) int maskTypeValue;
        [Export("maskTypeValue")]
        int MaskTypeValue { get; set; }

        // -(NSString *)getRegister;
        [Export("getRegister")]
        string Register { get; }

        // -(void)setRegister:(NSString *)value;
        [Export("setRegister:")]
        void SetRegister(string value);

        // -(ResultCode)setBarcodeMode:(BOOL)enabled isKeyAction:(BOOL)isKeyOn;
        [Export("setBarcodeMode:isKeyAction:")]
        ResultCode SetBarcodeMode(bool enabled, bool isKeyOn);

        // -(BOOL)isBarcodeModule;
        [Export("isBarcodeModule")]
        bool IsBarcodeModule { get; }

        // -(BOOL)isRFIDModule;
        [Export("isRFIDModule")]
        bool IsRFIDModule { get; }

        // -(void)setBarcodeContinueMode:(BOOL)isContinueMode;
        [Export("setBarcodeContinueMode:")]
        void SetBarcodeContinueMode(bool isContinueMode);

        // -(void)setTagDataType:(int)value;
        [Export("setTagDataType:")]
        void SetTagDataType(int value);

        // -(void)setPropBarcodeMode:(BOOL)mode;
        [Export("setPropBarcodeMode:")]
        void SetPropBarcodeMode(bool mode);

        // -(ReaderType)getReaderType;
        [Export("getReaderType")]
        ReaderType ReaderType { get; }
    }

    // @interface AsDataUtil : NSObject
    [BaseType(typeof(NSObject))]
    interface AsDataUtil
    {
        // +(NSString *)dump:(NSData *)data;
        [Static]
        [Export("dump:")]
        string Dump(NSData data);

        // +(NSString *)getHexString:(NSData *)data;
        [Static]
        [Export("getHexString:")]
        string GetHexString(NSData data);

        // +(NSString *)getHexString:(NSData *)data offset:(int)offset length:(int)length;
        [Static]
        [Export("getHexString:offset:length:")]
        string GetHexString(NSData data, int offset, int length);

        // +(NSInteger)indexOf:(NSData *)data find:(uint8_t)value;
        [Static]
        [Export("indexOf:find:")]
        nint IndexOf(NSData data, byte value);

        // +(NSInteger)indexOfWithArray:(NSData *)data find:(NSData *)values;
        [Static]
        [Export("indexOfWithArray:find:")]
        nint IndexOfWithArray(NSData data, NSData values);

        // +(NSRange)findDataWidthRange:(NSData *)data withPrefix:(uint8_t)prefix withSuffix1:(uint8_t)suffix1 withSuffix2:(uint8_t)suffix2;
        [Static]
        [Export("findDataWidthRange:withPrefix:withSuffix1:withSuffix2:")]
        NSRange FindDataWidthRange(NSData data, byte prefix, byte suffix1, byte suffix2);
    }

    // @interface NSStringHexToBytes (NSString)
    //[Category]
    //[BaseType (typeof(NSString))]
    //interface NSString_NSStringHexToBytes
    //{
    //	// -(NSData *)hexToBytes;
    //	[Export ("hexToBytes")]
    //	NSData HexToBytes { get; }
    //}

    // @interface AsMaskActionType : NSObject
    [BaseType(typeof(NSObject))]
    interface AsMaskActionType
    {
        // +(NSString *)toString:(MaskActionType)actionType targetType:(MaskTargetType)targetType;
        [Static]
        [Export("toString:targetType:")]
        string ToString(MaskActionType actionType, MaskTargetType targetType);
    }

    // @interface AsParamHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface AsParamHelper
    {
        // +(NSData *)setBytesWithParamValue:(AsParamValue *)paramName;
        [Static]
        [Export("setBytesWithParamValue:")]
        NSData SetBytesWithParamValue(AsParamValue paramName);

        // +(NSData *)getBytesWithParamName:(NSNumber *)paramName;
        [Static]
        [Export("getBytesWithParamName:")]
        NSData GetBytesWithParamName(NSNumber paramName);

        // +(NSData *)getBytesWithParamNames:(NSArray *)paramNames;
        [Static]
        [Export("getBytesWithParamNames:")]
        NSData GetBytesWithParamNames(NSObject[] paramNames);

        // +(AsParamValue *)getParam:(NSData *)data;
        [Static]
        [Export("getParam:")]
        AsParamValue GetParam(NSData data);

        // +(NSArray *)getParamList:(NSData *)data;
        [Static]
        [Export("getParamList:")]
        NSObject[] GetParamList(NSData data);
    }
}
//[Static]
//[Verify (ConstantsInterfaceAssociation)]
//partial interface Constants
//{
//	// extern double AsReaderGunSDKVersionNumber;
//	[Field ("AsReaderGunSDKVersionNumber", "__Internal")]
//	double AsReaderGunSDKVersionNumber { get; }

//	// extern const unsigned char [] AsReaderGunSDKVersionString;
//	[Field ("AsReaderGunSDKVersionString", "__Internal")]
//	byte[] AsReaderGunSDKVersionString { get; }
//}
