using System.Runtime.InteropServices;
using AsReaderGunSDK;

namespace AsReaderGunSDK
{
    public enum ResultCode : uint
    {
    	NoError = 0,
    	OtherError = 1,
    	Undefined = 2,
    	MemoryOverrun = 3,
    	MemoryLocked = 4,
    	InsufficientPower = 11,
    	NonSpecificError = 15,
    	InOperation = 57344,
    	OutOfRange = 57345,
    	NotConnected = 57600,
    	InvalidParameter = 57856,
    	InvalidResponse = 58112,
    	NotSupportFirmware = 60928,
    	Timeout = 61439,
    	HandleMismatch = 61441,
    	CRCError = 61442,
    	NoTagReply = 61443,
    	InvalidPassword = 61444,
    	ZeroKillPassword = 61445,
    	TagLost = 61446,
    	CommandFormatError = 61447,
    	ReadCountInvalid = 61448,
    	OutOfRetries = 61449,
    	ParamError = 65531,
    	Busy = 65532,
    	InvalidCommand = 65533,
    	LowBattery = 65534,
    	OperationFailed = 65535
    }

    public enum MemoryBank : uint
    {
    	Reserved,
    	Epc,
    	Tid,
    	User
    }

    public enum LockState : uint
    {
    	NoChange,
    	Unlock,
    	Lock,
    	PermaLock
    }

    public enum BuzzerState : uint
    {
    	Off,
    	Low,
    	High
    }

    public enum VibratorState : uint
    {
    	ff,
    	n
    }

    public enum RegionType : uint
    {
    	Korea,
    	Japan,
    	Euro,
    	Usa,
    	China,
    	Tiwan,
    	Brazil,
    	Malaysia,
    	Asia
    }

    public enum SessionType : uint
    {
    	Session_S0,
    	Session_S1,
    	Session_S2,
    	Session_S3
    }

    public enum SessionFlag : uint
    {
    	A,
    	B,
    	Ab
    }

    public enum SelectFlag : uint
    {
    	NotUsed,
    	Sl,
    	NotSl,
    	All
    }

    public enum MaskTargetType : uint
    {
    	MaskTarget_S0,
    	MaskTarget_S1,
    	MaskTarget_S2,
    	MaskTarget_S3,
    	L
    }

    public enum MaskActionType : uint
    {
    	Ab,
    	An,
    	Nb,
    	Mn,
    	Ba,
    	Bn,
    	Na,
    	Nm
    }

    public enum MaskType : uint
    {
    	NoMask,
    	Selection,
    	Epc
    }

    public enum ReaderType : uint
    {
    	Rfprisma = 0,
    	Asreader = 1
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct CMinMaxValue
    {
    	public int min;

    	public int max;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct CLockParam
    {
    	public LockState KillPassword;

    	public LockState AccessPassword;

    	public LockState EPC;

    	public LockState TID;

    	public LockState User;
    }

    public enum PacketType : uint
    {
    	Ssi = 0,
    	Response = 32,
    	ReqSetProperty = 119,
    	ResSetProperty = 87,
    	ReqGetProperty = 114,
    	ResGetProperty = 82,
    	Command = 97,
    	CommandAck = 65,
    	Event = 101,
    	Debug = 100,
    	DebugAck = 68,
    	ErrorAck = 69
    }

    public enum PropertyType : uint
    {
    	Buzzer = 98,
    	Vibrator = 113,
    	ContinuousMode = 99,
    	LimitTagCount = 108,
    	FirmwareVersion = 118,
    	PowerGain = 112,
    	PowerGainRange = 97,
    	Region = 103,
    	OperationTime = 105,
    	InventoryTime = 50,
    	IdleTime = 48,
    	SameTagReport = 49,
    	AutoOffTime = 116,
    	AccessPassword = 119,
    	InventorySession = 115,
    	SessionFlag = 102,
    	MaskTarget = 84,
    	MaskAction = 65,
    	MaskBank = 66,
    	MaskOffset = 79,
    	Mask = 77,
    	MaskUsed = 69,
    	MaskTrunc = 82,
    	UseSelectionMask = 85,
    	UHFVersion = 86,
    	KeyAction = 107,
    	BatteryStatus = 101,
    	Time = 114,
    	SerialNo = 83,
    	StoredMode = 73,
    	StoredTagCount = 67,
    	ReportMode = 109,
    	Algorithm = 71,
    	MinQ = 78,
    	MaxQ = 88,
    	Register = 106,
    	EpcMask = 100,
    	EpcMaskData = 68,
    	EpcMaskMode = 117,
    	Lbt = 76,
    	LBTFrequency = 70,
    	LBTMask = 57,
    	ReportRSSI = 56,
    	BarcodePower = 82,
    	RemoteMode = 104,
    	TagDataType = 35,
    	Barcode = 72,
    	BarcodeOpertationMode = 111,
    	BarcodeState = 120,
    	BarcodeRevision = 75,
    	QValue = 81,
    	LinkProfile = 52,
    	DefaultLinkProfile = 53,
    	MaskType = 87,
    	SleepTime = 121
    }

    public enum CommandType : uint
    {
    	Inventory = 102,
    	ReadMemory = 114,
    	WriteMemory = 119,
    	Kill = 107,
    	Lock = 108,
    	Unlock = 109,
    	PermaLock = 112,
    	BlockWrite = 87,
    	BlockErase = 69,
    	Stop = 115,
    	LoadStoredTag = 76,
    	SaveStoredTag = 84,
    	RemoveAllStoredTag = 68,
    	SoftReset = 98,
    	HardReset = 104,
    	DefaultParam = 97,
    	SaveParam = 83,
    	EnterBypass = 66,
    	EnterBarcodeBypass = 89,
    	LeaveBypass = 67,
    	DecodeStart = 100,
    	BuzzerStart = 117,
    	VibratorStart = 118
    }

    public enum EventType : uint
    {
    	TagValue = 84,
    	StoredTagValue = 70,
    	AccessResult = 65,
    	RemoteKey = 66,
    	BarcodeValue = 67
    }

    public enum DebugType : uint
    {
    	Message = 100,
    	Mode = 115,
    	BleVer = 103,
    	Config = 49,
    	Factory = 70
    }

    public enum ErrorType : uint
    {
    	ErrorModule = 69
    }

    public enum SSICommand : uint
    {
    	Unknown = 0,
    	AimOff = 196,
    	AimOn = 197,
    	Beep = 230,
    	CapabilitiesReply = 212,
    	CapabilitiesRequest = 211,
    	Ack = 208,
    	Nak = 209,
    	DecodeData = 243,
    	Event = 246,
    	LedOff = 232,
    	LedOn = 231,
    	ParamDefaults = 200,
    	ParamRequest = 199,
    	ParamSend = 198,
    	ReplyId = 166,
    	ReplyRevision = 164,
    	RequestId = 163,
    	RequestRevision = 163,
    	ScanEnable = 234,
    	ScanDisable = 233,
    	Sleep = 235,
    	StartDecode = 228,
    	StopDecode = 229,
    	RemoteKeyAction = 245
    }

    public enum ScanMode : uint
    {
    	RFIDScanMode,
    	BarcodeScanMode
    }

    public enum BarcodeType : uint
    {
    	NoRead,
    	AustralianPost,
    	AztecCode,
    	BooklandEAN,
    	BritishPost,
    	CanadianPost,
    	ChinaPost,
    	Codabar,
    	CodablockF,
    	Code11,
    	Code128,
    	Code16K,
    	Code32,
    	Code39,
    	Code49,
    	Code93,
    	Composite,
    	D2of5,
    	DataMatrix,
    	Ean128,
    	Ean13,
    	EAN13CouponCode,
    	Ean8,
    	I2of5,
    	Iata,
    	Isbt128,
    	ISBT128Concat,
    	JapanesePost,
    	KixPost,
    	KoreaPost,
    	MacroMicroPDF,
    	MaxiCode,
    	MicroPDF,
    	Msi,
    	MultipacketFormat,
    	Ocr,
    	ParameterFNC3,
    	Pdf417,
    	PlanetCode,
    	PlesseyCode,
    	PosiCode,
    	Postnet,
    	QRCode,
    	R2of5,
    	Rss,
    	ScanletWebcode,
    	Telepen,
    	Tlc39,
    	TriopticCode,
    	Upca,
    	Upce,
    	VeriCode,
    	X2of5,
    	RSSLimited,
    	ChineseSensible,
    	RSSExpanded
    }

    public enum ParamName : uint
    {
    	Unknown,
    	Default,
    	Revision,
    	RevisionDecoder,
    	RevisionDriver,
    	TerminalId,
    	Baudrate,
    	WordLength,
    	ReceiverTimeout,
    	RtsCts,
    	XonXoff,
    	AckNak,
    	TtlLevel,
    	ImageVga,
    	PowerUpBeeper,
    	BeepOnBELChar,
    	TriggerClick,
    	Beep,
    	BeepVolume,
    	BeepFreq,
    	BeepError,
    	BeepDuration,
    	Led,
    	LedPolarity,
    	BeepErrNumber,
    	BeepNumber,
    	BeepPolarity,
    	GoodReadDelay,
    	TriggerMode,
    	ManualTriggerMode,
    	IlluminationManual,
    	ReadTimeout,
    	LowPowerTimeout,
    	LedAfterDecode,
    	LedTimeout,
    	PresentSensitifity,
    	PresentaionMode,
    	IdleIllumination,
    	PresentationCenteringEnable,
    	PresentationCenteringTop,
    	PresentationCenteringBottom,
    	PresentationCenteringLeft,
    	PresentationCenteringRight,
    	PoorQuality1DCodes,
    	PoorQuality1PDFCodes,
    	CodeGate,
    	HandlHeldScanning,
    	PresentationScanning,
    	HandsFreeTimeout,
    	RereadDelay,
    	LedPowerLevel,
    	RereadDelay2D,
    	CharActMode,
    	ActiveChar,
    	EndCharAct,
    	CharActTimeout,
    	CharDeactMode,
    	DeactChar,
    	IlluminationLights,
    	ImagerTimeout,
    	AimerDelay,
    	AimerMode,
    	CenterWindow,
    	CenterWindowLeft,
    	CenterWindowRight,
    	CenterWindowTop,
    	CenterWindowBottom,
    	CenterWin40,
    	CenterWin60,
    	DecodeMode,
    	EnterSequence,
    	DefaultSequence,
    	RequireSequence,
    	MultipleSymbols,
    	NoRead,
    	PrintWeight,
    	VideoReverse,
    	WorkingOrientation,
    	AddAllCRSuffix,
    	AddPrefix,
    	ClearOnePrefix,
    	ClearAllPrefix,
    	AddSuffix,
    	ClearOneSuffix,
    	ClearAllSuffix,
    	FuncCodeTransmit,
    	IntercharacterDelay,
    	IntercharacterDelayLength,
    	CharacterTriggerDelay,
    	InterfunctionDelay,
    	IntermessageDealy,
    	DefaultDataFormat,
    	EnterDataFormat,
    	ClearOneDataFormat,
    	ClearAllDataFormat,
    	DataFormatter,
    	AlternateDataFormats1,
    	AlternateDataFormats2,
    	AlternateDataFormats3,
    	DataFormat,
    	AllSymbol,
    	CodabarDefault,
    	Codabar,
    	CodabarStartStopChar,
    	CodabarCheckChar,
    	CodabarConcatenation,
    	CodabarLengthMin,
    	CodabarLengthMax,
    	Code39Default,
    	Code39,
    	Code39StartStopChar,
    	Code39CheckChar,
    	Code39LengthMin,
    	Code39LengthMax,
    	Code39Append,
    	Code39Pharmaceutical,
    	Code39FullAscii,
    	Code39CodePage,
    	I2of5Default,
    	I2of5,
    	I2of5CheckDigit,
    	I2of5LengthMin,
    	I2of5LengthMax,
    	NEC2of5Default,
    	NEC2of5,
    	NEC2of5CheckDigit,
    	NEC2of5LengthMin,
    	NEC2of5LengthMax,
    	Code93Default,
    	Code93,
    	Code93LengthMin,
    	Code93LengthMax,
    	Code93Append,
    	Code93CodePage,
    	R2of5Default,
    	R2of5,
    	R2of5LengthMin,
    	R2of5LengthMax,
    	A2of5Default,
    	A2of5,
    	A2of5LengthMin,
    	A2of5LengthMax,
    	X2of5Default,
    	X2of5,
    	X2of5LengthMin,
    	X2of5LengthMax,
    	Code11Default,
    	Code11,
    	Code11CheckDigit,
    	Code11LengthMin,
    	Code11LengthMax,
    	Code128Default,
    	Code128,
    	IsbtConcatenation,
    	Code128LengthMin,
    	Code128LengthMax,
    	Code128Append,
    	Code128CodePage,
    	GS1128Default,
    	Gs1128,
    	GS1128LengthMin,
    	GS1128LengthMax,
    	TelepenDefault,
    	Telepen,
    	TelepenOutput,
    	TelepenLengthMin,
    	TelepenLengthMax,
    	UPCADefault,
    	Upca,
    	UPCACheckDigit,
    	UPCANumberSystem,
    	UPCA2DigitAdd,
    	UPCA5DigitAdd,
    	UPCAAddReq,
    	UPCAAddSep,
    	UPCACouponCode,
    	CouponGS1DataBarOutput,
    	ConvertUPCAtoEAN13,
    	UPCE0Default,
    	Upce0,
    	UPCE0Expand,
    	UPCE0CheckDigit,
    	UPCE0NumberSystem,
    	UPCE02DigitAdd,
    	UPCE05DigitAdd,
    	UPCE0AddReq,
    	UPCE0AddSep,
    	Upce1,
    	EAN13Default,
    	Ean13,
    	EAN13CheckDigit,
    	EAN132DigitAdd,
    	EAN135DigitAdd,
    	EAN13AddReq,
    	EAN13AddSep,
    	IsbnTranslate,
    	EAN8Default,
    	Ean8,
    	EAN8CheckDigit,
    	EAN82DigitAdd,
    	EAN85DigitAdd,
    	EAN8AddReq,
    	EAN8AddSep,
    	MSIDefault,
    	Msi,
    	MSICheckChar,
    	MSILengthMin,
    	MSILengthMax,
    	RSS14Default,
    	Rss14,
    	RSSLimitDefault,
    	RSSLimit,
    	RSSExpDefault,
    	RSSExp,
    	RSSExpLengthMin,
    	RSSExpLengthMax,
    	TriopticCode,
    	CodablockADefault,
    	CodablockA,
    	CodablockALengthMin,
    	CodablockALengthMax,
    	CodablockFDefault,
    	CodablockF,
    	CodablockFLengthMin,
    	CodablockFLengthMax,
    	PDF417Default,
    	Pdf417,
    	PDF417LengthMin,
    	PDF417LengthMax,
    	MacroPDF417,
    	MicroPDFDefault,
    	MicroPDF,
    	MicroPDFLengthMin,
    	MicroPDFLengthMax,
    	ComCode,
    	UPCEANVersion,
    	ComCodeLengthMin,
    	ComCodeLengthMax,
    	ComCodeEmulation,
    	GS1Emulation,
    	Tlc39,
    	ChinaPostDefault,
    	ChinaPost,
    	ChinaPostLengthMin,
    	ChinaPostLengthMax,
    	KoreaPostDefault,
    	KoreaPost,
    	KoreaPostLengthMin,
    	KoreaPostLengthMax,
    	KoreaPostCheckDigit,
    	QRCodeDefault,
    	QRCode,
    	QRCodeLengthMin,
    	QRCodeLengthMax,
    	QRCodeAppend,
    	QRCodePage,
    	MatrixDefault,
    	Matrix,
    	MatrixLengthMin,
    	MatrixLengthMax,
    	MatrixAppend,
    	MatrixCodePage,
    	MaxiCodeDefault,
    	MaxiCode,
    	MaxiCodeLengthMin,
    	MaxiCodeLengthMax,
    	AztecCodeDefault,
    	AztecCode,
    	AztecCodeLengthMin,
    	AztecCodeLengthMax,
    	AztecAppend,
    	AztecCodePage,
    	AztecCodeRunes,
    	HanXinCodeDefault,
    	HanXinCode,
    	HanXinCodeLengthMin,
    	HanXinCodeLengthMax,
    	PostalCodes,
    	AustralianPostInterpretation,
    	ImageDefault,
    	ImageStyle,
    	ImageBeep,
    	ImageExposure,
    	ImageFrameRate,
    	ImageGain,
    	ImageDelta,
    	ImageLed,
    	ImageTrigger,
    	ImageUpdate,
    	ImageWhite,
    	ImagePercentage,
    	ImageFilter,
    	ImageCompensation,
    	ImagePixelDepth,
    	ImageSharpenEdges,
    	ImageFormat,
    	ImageHistogram,
    	ImageInvertX,
    	ImageInvertY,
    	ImageFlySpec,
    	ImageRotate,
    	ImageQuality,
    	ImageGamma,
    	ImageCropLeft,
    	ImageCropBottom,
    	ImageCropMargin,
    	ImageProtocol,
    	ImageShipEvery,
    	ImageDocFilter,
    	ImageShipHistogram,
    	OCRDefault,
    	Ocr,
    	OCRTemplate,
    	OCRVarG,
    	OCRVarH,
    	OCRCheckChar
    }

    public enum AlgorithmType : uint
    {
    	FixedQ = 0,
    	DynamicQ = 1
    }
}
