using System;
using Foundation;
using ObjCRuntime;

// @interface AsRingAccessoryBaseSDK : NSObject
namespace AsRingAccessorySDK
{
    [BaseType(typeof(NSObject))]
    interface AsRingAccessoryBaseSDK
    {
        // -(instancetype)initWithDeviceModel:(NSString *)deviceModel;
        [Export("initWithDeviceModel:")]
        IntPtr Constructor(string deviceModel);

        // -(void)rX:(NSData *)readData;
        [Export("rX:")]
        void RX(NSData readData);

        // -(void)tX:(NSData *)transmitData;
        [Export("tX:")]
        void TX(NSData transmitData);

        // -(void)pluggedDevice:(BOOL)plug;
        [Export("pluggedDevice:")]
        void PluggedDevice(bool plug);

        // -(NSString *)getAsRingDeviceSDKVersion;
        [Export("getAsRingDeviceSDKVersion")]
        string AsRingDeviceSDKVersion { get; }
    }

    // @interface FloderModel : NSObject
    [BaseType(typeof(NSObject))]
    interface FloderModel
    {
        // @property (readonly, nonatomic, strong) FloderModel * superFloder;
        [Export("superFloder", ArgumentSemantic.Strong)]
        FloderModel SuperFloder { get; }

        // @property (nonatomic, strong) NSString * floderName;
        [Export("floderName", ArgumentSemantic.Strong)]
        string FloderName { get; set; }

        // @property (nonatomic, strong) NSDate * createTime;
        [Export("createTime", ArgumentSemantic.Strong)]
        NSDate CreateTime { get; set; }

        // @property (readonly, nonatomic, strong) NSString * path;
        [Export("path", ArgumentSemantic.Strong)]
        string Path { get; }

        // @property (nonatomic, strong) NSMutableArray * files;
        [Export("files", ArgumentSemantic.Strong)]
        NSMutableArray Files { get; set; }

        // -(instancetype)initWithSuperFloder:(FloderModel *)superFloder;
        [Export("initWithSuperFloder:")]
        IntPtr Constructor(FloderModel superFloder);

        // -(id)selectFileWithIndex:(NSUInteger)index;
        [Export("selectFileWithIndex:")]
        NSObject SelectFileWithIndex(nuint index);
    }

    // @interface FileModel : NSObject
    [BaseType(typeof(NSObject))]
    interface FileModel
    {
        // @property (readonly, nonatomic, strong) FloderModel * superFloder;
        [Export("superFloder", ArgumentSemantic.Strong)]
        FloderModel SuperFloder { get; }

        // @property (nonatomic, strong) NSString * fileName;
        [Export("fileName", ArgumentSemantic.Strong)]
        string FileName { get; set; }

        // @property (nonatomic, strong) NSString * fileType;
        [Export("fileType", ArgumentSemantic.Strong)]
        string FileType { get; set; }

        // @property (nonatomic, strong) NSDate * createTime;
        [Export("createTime", ArgumentSemantic.Strong)]
        NSDate CreateTime { get; set; }

        // @property (readonly, nonatomic, strong) NSString * path;
        [Export("path", ArgumentSemantic.Strong)]
        string Path { get; }

        // @property (assign, nonatomic) NSUInteger byte;
        [Export("byte")]
        nuint Byte { get; set; }

        // @property (nonatomic, strong) NSData * data;
        [Export("data", ArgumentSemantic.Strong)]
        NSData Data { get; set; }

        // -(instancetype)initWithSuperFloder:(FloderModel *)superFloder;
        [Export("initWithSuperFloder:")]
        IntPtr Constructor(FloderModel superFloder);
    }

    // @protocol AsRingDebugListener <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AsRingDebugListener
    {
        // @required -(void)whenReciveDebugData:(NSData *)data;
        [Abstract]
        [Export("whenReciveDebugData:")]
        void WhenReciveDebugData(NSData data);

        // @required -(void)whenSendDebugData:(NSData *)data;
        [Abstract]
        [Export("whenSendDebugData:")]
        void WhenSendDebugData(NSData data);
    }

    // @protocol AsRingDeviceSDKDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AsRingDeviceSDKDelegate
    {
        // @required -(void)pluggedAsRing:(BOOL)plug;
        [Abstract]
        [Export("pluggedAsRing:")]
        void PluggedAsRing(bool plug);

        // @required -(void)onAsRingError:(NSError *)error;
        [Abstract]
        [Export("onAsRingError:")]
        void OnAsRingError(NSError error);

        // @required -(void)asRingDeviceRx:(NSData *)reciveData;
        [Abstract]
        [Export("asRingDeviceRx:")]
        void AsRingDeviceRx(NSData reciveData);

        // @required -(void)asRingRx:(NSData *)reciveData;
        [Abstract]
        [Export("asRingRx:")]
        void AsRingRx(NSData reciveData);

        // @required -(void)asRingModeTransition:(BOOL)success;
        [Abstract]
        [Export("asRingModeTransition:")]
        void AsRingModeTransition(bool success);

        // @required -(void)onFileReceived:(FileModel *)file;
        [Abstract]
        [Export("onFileReceived:")]
        void OnFileReceived(FileModel file);

        // @required -(void)onFloderReceived:(FloderModel *)floder;
        [Abstract]
        [Export("onFloderReceived:")]
        void OnFloderReceived(FloderModel floder);

        // @required -(void)onDeviceDebug:(BOOL)isOpen;
        [Abstract]
        [Export("onDeviceDebug:")]
        void OnDeviceDebug(bool isOpen);
    }

    // @interface AsRingDeviceSDK : NSObject
    [BaseType(typeof(NSObject))]
    interface AsRingDeviceSDK
    {
        [Wrap("WeakDelegate")]
        AsRingDeviceSDKDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AsRingDeviceSDKDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<AsRingDebugListener> debugListener;
        [Export("debugListener", ArgumentSemantic.Weak)]
        AsRingDebugListener DebugListener { get; set; }

        // @property (readonly, assign, nonatomic) BOOL isOpened;
        [Export("isOpened")]
        bool IsOpened { get; }

        // +(AsRingDeviceSDK *)sharedAsRingDeviceSDK;
        [Static]
        [Export("sharedAsRingDeviceSDK")]
        AsRingDeviceSDK SharedAsRingDeviceSDK { get; }

        // -(void)asRingTx:(NSData *)transmitData;
        [Export("asRingTx:")]
        void AsRingTx(NSData transmitData);

        // -(void)addSDkMap:(NSDictionary *)addSDkMapDic;
        [Export("addSDkMap:")]
        void AddSDkMap(NSDictionary addSDkMapDic);

        // -(void)transmitData:(NSData *)transmitData sdk:(AsRingAccessoryBaseSDK *)sdk;
        [Export("transmitData:sdk:")]
        void TransmitData(NSData transmitData, AsRingAccessoryBaseSDK sdk);

        // -(void)tX:(NSData *)sendData msg_type:(unsigned char)msg_type cmd_code:(unsigned char)cmd_code;
        [Export("tX:msg_type:cmd_code:")]
        void TX(NSData sendData, byte msg_type, byte cmd_code);

        // -(void)setAsRingControlLogOn:(BOOL)on;
        [Export("setAsRingControlLogOn:")]
        void SetAsRingControlLogOn(bool on);

        // -(void)setAsRingLogOn:(BOOL)on;
        [Export("setAsRingLogOn:")]
        void SetAsRingLogOn(bool on);

        // -(NSString *)getAsRingModelNumber;
        [Export("getAsRingModelNumber")]
        string AsRingModelNumber { get; }

        // -(NSString *)getAsRingSerialNumber;
        [Export("getAsRingSerialNumber")]
        string AsRingSerialNumber { get; }

        // -(NSString *)getAsRingFirmwareRevision;
        [Export("getAsRingFirmwareRevision")]
        string AsRingFirmwareRevision { get; }

        // -(NSString *)getAsRingHardwareRevision;
        [Export("getAsRingHardwareRevision")]
        string AsRingHardwareRevision { get; }

        // -(NSArray *)getAllDevice;
        [Export("getAllDevice")]
        NSObject[] AllDevice { get; }

        // -(NSArray *)getAllConnectDevice;
        [Export("getAllConnectDevice")]
        NSObject[] AllConnectDevice { get; }

        // -(void)disConnectWithAddress:(NSString *)address;
        [Export("disConnectWithAddress:")]
        void DisConnectWithAddress(string address);

        // -(void)disConnect;
        [Export("disConnect")]
        void DisConnect();

        // -(NSString *)getAsRingSDKVersion;
        [Export("getAsRingSDKVersion")]
        string AsRingSDKVersion { get; }

        // -(void)modeTransition;
        [Export("modeTransition")]
        void ModeTransition();

        // -(void)createFileWith:(FileModel *)file;
        [Export("createFileWith:")]
        void CreateFileWith(FileModel file);

        // -(void)createFloderWith:(FloderModel *)floder;
        [Export("createFloderWith:")]
        void CreateFloderWith(FloderModel floder);

        // -(void)deleteFileWith:(FileModel *)file;
        [Export("deleteFileWith:")]
        void DeleteFileWith(FileModel file);

        // -(void)deleteFloderWith:(FloderModel *)floder;
        [Export("deleteFloderWith:")]
        void DeleteFloderWith(FloderModel floder);

        // -(void)selectFileWith:(FileModel *)file;
        [Export("selectFileWith:")]
        void SelectFileWith(FileModel file);

        // -(void)selectFloderWith:(FloderModel *)floder;
        [Export("selectFloderWith:")]
        void SelectFloderWith(FloderModel floder);

        // -(void)deviceDebug;
        [Export("deviceDebug")]
        void DeviceDebug();

        // -(void)loadRootFloder;
        [Export("loadRootFloder")]
        void LoadRootFloder();
    }

    // @interface Device : NSObject
    [BaseType(typeof(NSObject))]
    interface Device
    {
        // @property (readonly, nonatomic, strong) NSString * deviceModel;
        [Export("deviceModel", ArgumentSemantic.Strong)]
        string DeviceModel { get; }

        // @property (readonly, nonatomic, strong) NSString * deviceAddress;
        [Export("deviceAddress", ArgumentSemantic.Strong)]
        string DeviceAddress { get; }

        // @property (readonly, nonatomic, strong) AsRingAccessoryBaseSDK * deviceSDK;
        [Export("deviceSDK", ArgumentSemantic.Strong)]
        AsRingAccessoryBaseSDK DeviceSDK { get; }

        // -(instancetype)initWithdeviceModel:(NSString *)deviceModel DeviceAddress:(NSString *)deviceAddress SDK:(AsRingAccessoryBaseSDK *)deviceSDK;
        [Export("initWithdeviceModel:DeviceAddress:SDK:")]
        IntPtr Constructor(string deviceModel, string deviceAddress, AsRingAccessoryBaseSDK deviceSDK);
    }
}
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
