unit TSelectionLib_TLB;

// ************************************************************************ //
// WARNING                                                                    
// -------                                                                    
// The types declared in this file were generated from data read from a       
// Type Library. If this type library is explicitly or indirectly (via        
// another type library referring to this type library) re-imported, or the   
// 'Refresh' command of the Type Library Editor activated while editing the   
// Type Library, the contents of this file will be regenerated and all        
// manual modifications will be lost.                                         
// ************************************************************************ //

// PASTLWTR : 1.2
// File generated on 11/3/2011 9:33:31 PM from Type Library described below.

// ************************************************************************  //
// Type Lib: C:\PROGRA~1\DESKPE~1\SCREEN~1\TSELEC~1.DLL (1)
// LIBID: {F68022D4-D902-4D29-A24E-13F5C71C7B33}
// LCID: 0
// Helpfile: 
// HelpString: TSelection 1.0 Type Library
// DepndLst: 
//   (1) v2.0 stdole, (C:\WINDOWS\system32\stdole2.tlb)
// Errors:
//   Hint: Symbol 'Type' renamed to 'type_'
//   Hint: Symbol 'Type' renamed to 'type_'
//   Error creating palette bitmap of (TTSelection) : Server C:\Program Files\Deskperience\ScreenScraper Studio\TSelection.dll contains no icons
//   Error creating palette bitmap of (TTSelectionInfo) : Server C:\Program Files\Deskperience\ScreenScraper Studio\TSelection.dll contains no icons
// ************************************************************************ //
// *************************************************************************//
// NOTE:                                                                      
// Items guarded by $IFDEF_LIVE_SERVER_AT_DESIGN_TIME are used by properties  
// which return objects that may need to be explicitly created via a function 
// call prior to any access via the property. These items have been disabled  
// in order to prevent accidental use from within the object inspector. You   
// may enable them by defining LIVE_SERVER_AT_DESIGN_TIME or by selectively   
// removing them from the $IFDEF blocks. However, such items must still be    
// programmatically created via a method of the appropriate CoClass before    
// they can be used.                                                          
{$TYPEDADDRESS OFF} // Unit must be compiled without type-checked pointers. 
{$WARN SYMBOL_PLATFORM OFF}
{$WRITEABLECONST ON}
{$VARPROPSETTER ON}
interface

uses Windows, ActiveX, Classes, Graphics, OleServer, StdVCL, Variants;
  

// *********************************************************************//
// GUIDS declared in the TypeLibrary. Following prefixes are used:        
//   Type Libraries     : LIBID_xxxx                                      
//   CoClasses          : CLASS_xxxx                                      
//   DISPInterfaces     : DIID_xxxx                                       
//   Non-DISP interfaces: IID_xxxx                                        
// *********************************************************************//
const
  // TypeLibrary Major and minor versions
  TSelectionLibMajorVersion = 1;
  TSelectionLibMinorVersion = 0;

  LIBID_TSelectionLib: TGUID = '{F68022D4-D902-4D29-A24E-13F5C71C7B33}';

  IID_ITSelection: TGUID = '{24455CC7-C5E2-4D5B-A37C-47C76CFE1905}';
  CLASS_TSelection: TGUID = '{BF616448-1D65-4559-9293-0F6B607BA892}';
  IID_ITSelectionInfo: TGUID = '{12E679EC-86BF-4AA2-AA94-1B8D16E30EAF}';
  IID_ITSelectionInfo2: TGUID = '{C5D9A330-5BB9-4904-B898-4A1DCAFD3C7A}';
  CLASS_TSelectionInfo: TGUID = '{AD58B105-E00C-4F3F-81A5-54F741853E5C}';

// *********************************************************************//
// Declaration of Enumerations defined in Type Library                    
// *********************************************************************//
// Constants for enum TS_MOUSE
type
  TS_MOUSE = TOleEnum;
const
  tsMouseNone = $00000000;
  tsMouseLeft = $00000001;
  tsMouseRight = $00000002;
  tsMouseLeftRight = $00000003;
  tsMouseMiddle = $00000004;

// Constants for enum TS_SELECTION_OPTIONS
type
  TS_SELECTION_OPTIONS = TOleEnum;
const
  tsSelFlagNone = $00000000;
  tsSelFlagShowPreview = $00000001;
  tsSelFlagLockScreen = $00000002;
  tsSelFlagHighlight = $00000004;
  tsSelSchemeBlue = $00000008;
  tsSelSchemeRed = $00000010;
  tsSelFlagDefaultText = $0000000D;
  tsSelFlagDefaultGraphic = $00000013;
  tsSelFlagDefault = $0000000D;

// Constants for enum TS_SELECTION_RESULT
type
  TS_SELECTION_RESULT = TOleEnum;
const
  tsSelResultSuccess = $00000000;
  tsSelResultCancelled = $00000001;
  tsSelResultError = $00000002;

// Constants for enum TS_SELECTION
type
  TS_SELECTION = TOleEnum;
const
  tsSelectionNone = $00000000;
  tsSelectionPoint = $00000001;
  tsSelectionRectangle = $00000002;
  tsSelectionPointRectangle = $00000003;
  tsSelectionFreeFrom = $00000004;
  tsSelectionPointFreeFrom = $00000005;
  tsSelectionWindow = $00000008;
  tsSelectionObject = $00000010;
  tsSelectionScrollingWindow = $00000020;
  tsSelectionRoundRectangle = $00000040;
  tsSelectionEllipse = $00000080;
  tsSelectionColorPick = $00000100;
  tsSelectionFixedRegion = $00000200;
  tsSelectionUIElement = $00000400;

type

// *********************************************************************//
// Forward declaration of types defined in TypeLibrary                    
// *********************************************************************//
  ITSelection = interface;
  ITSelectionDisp = dispinterface;
  ITSelectionInfo = interface;
  ITSelectionInfoDisp = dispinterface;
  ITSelectionInfo2 = interface;
  ITSelectionInfo2Disp = dispinterface;

// *********************************************************************//
// Declaration of CoClasses defined in Type Library                       
// (NOTE: Here we map each CoClass to its Default Interface)              
// *********************************************************************//
  TSelection = ITSelection;
  TSelectionInfo = ITSelectionInfo2;


// *********************************************************************//
// Interface: ITSelection
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {24455CC7-C5E2-4D5B-A37C-47C76CFE1905}
// *********************************************************************//
  ITSelection = interface(IDispatch)
    ['{24455CC7-C5E2-4D5B-A37C-47C76CFE1905}']
    function Start(selection_type: Integer; options: Integer): IDispatch; safecall;
    function Get_FixedRegionWidth: Integer; safecall;
    procedure Set_FixedRegionWidth(pVal: Integer); safecall;
    function Get_FixedRegionHeight: Integer; safecall;
    procedure Set_FixedRegionHeight(pVal: Integer); safecall;
    property FixedRegionWidth: Integer read Get_FixedRegionWidth write Set_FixedRegionWidth;
    property FixedRegionHeight: Integer read Get_FixedRegionHeight write Set_FixedRegionHeight;
  end;

// *********************************************************************//
// DispIntf:  ITSelectionDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {24455CC7-C5E2-4D5B-A37C-47C76CFE1905}
// *********************************************************************//
  ITSelectionDisp = dispinterface
    ['{24455CC7-C5E2-4D5B-A37C-47C76CFE1905}']
    function Start(selection_type: Integer; options: Integer): IDispatch; dispid 1;
    property FixedRegionWidth: Integer dispid 2;
    property FixedRegionHeight: Integer dispid 3;
  end;

// *********************************************************************//
// Interface: ITSelectionInfo
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {12E679EC-86BF-4AA2-AA94-1B8D16E30EAF}
// *********************************************************************//
  ITSelectionInfo = interface(IDispatch)
    ['{12E679EC-86BF-4AA2-AA94-1B8D16E30EAF}']
    function Get_type_: Integer; safecall;
    procedure Set_type_(pVal: Integer); safecall;
    function Get_WindowHandle: Integer; safecall;
    procedure Set_WindowHandle(pVal: Integer); safecall;
    function Get_Points: OleVariant; safecall;
    procedure Set_Points(pVal: OleVariant); safecall;
    function Get_Image: IPictureDisp; safecall;
    procedure Set_Image(const pVal: IPictureDisp); safecall;
    function Get_UIElementID: WideString; safecall;
    procedure Set_UIElementID(const result: WideString); safecall;
    function Get_SelectionResult: Integer; safecall;
    procedure Set_SelectionResult(pVal: Integer); safecall;
    property type_: Integer read Get_type_ write Set_type_;
    property WindowHandle: Integer read Get_WindowHandle write Set_WindowHandle;
    property Points: OleVariant read Get_Points write Set_Points;
    property Image: IPictureDisp read Get_Image write Set_Image;
    property UIElementID: WideString read Get_UIElementID write Set_UIElementID;
    property SelectionResult: Integer read Get_SelectionResult write Set_SelectionResult;
  end;

// *********************************************************************//
// DispIntf:  ITSelectionInfoDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {12E679EC-86BF-4AA2-AA94-1B8D16E30EAF}
// *********************************************************************//
  ITSelectionInfoDisp = dispinterface
    ['{12E679EC-86BF-4AA2-AA94-1B8D16E30EAF}']
    property type_: Integer dispid 1;
    property WindowHandle: Integer dispid 2;
    property Points: OleVariant dispid 3;
    property Image: IPictureDisp dispid 4;
    property UIElementID: WideString dispid 5;
    property SelectionResult: Integer dispid 6;
  end;

// *********************************************************************//
// Interface: ITSelectionInfo2
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {C5D9A330-5BB9-4904-B898-4A1DCAFD3C7A}
// *********************************************************************//
  ITSelectionInfo2 = interface(ITSelectionInfo)
    ['{C5D9A330-5BB9-4904-B898-4A1DCAFD3C7A}']
    procedure GetClientCoordinates; safecall;
    function Get_RCLeft: Integer; safecall;
    procedure Set_RCLeft(pVal: Integer); safecall;
    function Get_RCTop: Integer; safecall;
    procedure Set_RCTop(pVal: Integer); safecall;
    function Get_RCWidth: Integer; safecall;
    procedure Set_RCWidth(pVal: Integer); safecall;
    function Get_RCHeight: Integer; safecall;
    procedure Set_RCHeight(pVal: Integer); safecall;
    property RCLeft: Integer read Get_RCLeft write Set_RCLeft;
    property RCTop: Integer read Get_RCTop write Set_RCTop;
    property RCWidth: Integer read Get_RCWidth write Set_RCWidth;
    property RCHeight: Integer read Get_RCHeight write Set_RCHeight;
  end;

// *********************************************************************//
// DispIntf:  ITSelectionInfo2Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {C5D9A330-5BB9-4904-B898-4A1DCAFD3C7A}
// *********************************************************************//
  ITSelectionInfo2Disp = dispinterface
    ['{C5D9A330-5BB9-4904-B898-4A1DCAFD3C7A}']
    procedure GetClientCoordinates; dispid 7;
    property RCLeft: Integer dispid 8;
    property RCTop: Integer dispid 9;
    property RCWidth: Integer dispid 10;
    property RCHeight: Integer dispid 11;
    property type_: Integer dispid 1;
    property WindowHandle: Integer dispid 2;
    property Points: OleVariant dispid 3;
    property Image: IPictureDisp dispid 4;
    property UIElementID: WideString dispid 5;
    property SelectionResult: Integer dispid 6;
  end;

// *********************************************************************//
// The Class CoTSelection provides a Create and CreateRemote method to          
// create instances of the default interface ITSelection exposed by              
// the CoClass TSelection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoTSelection = class
    class function Create: ITSelection;
    class function CreateRemote(const MachineName: string): ITSelection;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TTSelection
// Help String      : TSelection
// Default Interface: ITSelection
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TTSelectionProperties= class;
{$ENDIF}
  TTSelection = class(TOleServer)
  private
    FIntf:        ITSelection;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TTSelectionProperties;
    function      GetServerProperties: TTSelectionProperties;
{$ENDIF}
    function      GetDefaultInterface: ITSelection;
  protected
    procedure InitServerData; override;
    function Get_FixedRegionWidth: Integer;
    procedure Set_FixedRegionWidth(pVal: Integer);
    function Get_FixedRegionHeight: Integer;
    procedure Set_FixedRegionHeight(pVal: Integer);
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: ITSelection);
    procedure Disconnect; override;
    function Start(selection_type: Integer; options: Integer): IDispatch;
    property DefaultInterface: ITSelection read GetDefaultInterface;
    property FixedRegionWidth: Integer read Get_FixedRegionWidth write Set_FixedRegionWidth;
    property FixedRegionHeight: Integer read Get_FixedRegionHeight write Set_FixedRegionHeight;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TTSelectionProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : TTSelection
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TTSelectionProperties = class(TPersistent)
  private
    FServer:    TTSelection;
    function    GetDefaultInterface: ITSelection;
    constructor Create(AServer: TTSelection);
  protected
    function Get_FixedRegionWidth: Integer;
    procedure Set_FixedRegionWidth(pVal: Integer);
    function Get_FixedRegionHeight: Integer;
    procedure Set_FixedRegionHeight(pVal: Integer);
  public
    property DefaultInterface: ITSelection read GetDefaultInterface;
  published
    property FixedRegionWidth: Integer read Get_FixedRegionWidth write Set_FixedRegionWidth;
    property FixedRegionHeight: Integer read Get_FixedRegionHeight write Set_FixedRegionHeight;
  end;
{$ENDIF}


// *********************************************************************//
// The Class CoTSelectionInfo provides a Create and CreateRemote method to          
// create instances of the default interface ITSelectionInfo2 exposed by              
// the CoClass TSelectionInfo. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoTSelectionInfo = class
    class function Create: ITSelectionInfo2;
    class function CreateRemote(const MachineName: string): ITSelectionInfo2;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TTSelectionInfo
// Help String      : TSelectionInfo
// Default Interface: ITSelectionInfo2
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TTSelectionInfoProperties= class;
{$ENDIF}
  TTSelectionInfo = class(TOleServer)
  private
    FIntf:        ITSelectionInfo2;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TTSelectionInfoProperties;
    function      GetServerProperties: TTSelectionInfoProperties;
{$ENDIF}
    function      GetDefaultInterface: ITSelectionInfo2;
  protected
    procedure InitServerData; override;
    function Get_RCLeft: Integer;
    procedure Set_RCLeft(pVal: Integer);
    function Get_RCTop: Integer;
    procedure Set_RCTop(pVal: Integer);
    function Get_RCWidth: Integer;
    procedure Set_RCWidth(pVal: Integer);
    function Get_RCHeight: Integer;
    procedure Set_RCHeight(pVal: Integer);
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: ITSelectionInfo2);
    procedure Disconnect; override;
    procedure GetClientCoordinates;
    property DefaultInterface: ITSelectionInfo2 read GetDefaultInterface;
    property RCLeft: Integer read Get_RCLeft write Set_RCLeft;
    property RCTop: Integer read Get_RCTop write Set_RCTop;
    property RCWidth: Integer read Get_RCWidth write Set_RCWidth;
    property RCHeight: Integer read Get_RCHeight write Set_RCHeight;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TTSelectionInfoProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : TTSelectionInfo
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TTSelectionInfoProperties = class(TPersistent)
  private
    FServer:    TTSelectionInfo;
    function    GetDefaultInterface: ITSelectionInfo2;
    constructor Create(AServer: TTSelectionInfo);
  protected
    function Get_RCLeft: Integer;
    procedure Set_RCLeft(pVal: Integer);
    function Get_RCTop: Integer;
    procedure Set_RCTop(pVal: Integer);
    function Get_RCWidth: Integer;
    procedure Set_RCWidth(pVal: Integer);
    function Get_RCHeight: Integer;
    procedure Set_RCHeight(pVal: Integer);
  public
    property DefaultInterface: ITSelectionInfo2 read GetDefaultInterface;
  published
    property RCLeft: Integer read Get_RCLeft write Set_RCLeft;
    property RCTop: Integer read Get_RCTop write Set_RCTop;
    property RCWidth: Integer read Get_RCWidth write Set_RCWidth;
    property RCHeight: Integer read Get_RCHeight write Set_RCHeight;
  end;
{$ENDIF}


procedure Register;

resourcestring
  dtlServerPage = 'ActiveX';

  dtlOcxPage = 'ActiveX';

implementation

uses ComObj;

class function CoTSelection.Create: ITSelection;
begin
  Result := CreateComObject(CLASS_TSelection) as ITSelection;
end;

class function CoTSelection.CreateRemote(const MachineName: string): ITSelection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_TSelection) as ITSelection;
end;

procedure TTSelection.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{BF616448-1D65-4559-9293-0F6B607BA892}';
    IntfIID:   '{24455CC7-C5E2-4D5B-A37C-47C76CFE1905}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure TTSelection.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as ITSelection;
  end;
end;

procedure TTSelection.ConnectTo(svrIntf: ITSelection);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure TTSelection.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function TTSelection.GetDefaultInterface: ITSelection;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
  Result := FIntf;
end;

constructor TTSelection.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TTSelectionProperties.Create(Self);
{$ENDIF}
end;

destructor TTSelection.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function TTSelection.GetServerProperties: TTSelectionProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function TTSelection.Get_FixedRegionWidth: Integer;
begin
    Result := DefaultInterface.FixedRegionWidth;
end;

procedure TTSelection.Set_FixedRegionWidth(pVal: Integer);
begin
  DefaultInterface.Set_FixedRegionWidth(pVal);
end;

function TTSelection.Get_FixedRegionHeight: Integer;
begin
    Result := DefaultInterface.FixedRegionHeight;
end;

procedure TTSelection.Set_FixedRegionHeight(pVal: Integer);
begin
  DefaultInterface.Set_FixedRegionHeight(pVal);
end;

function TTSelection.Start(selection_type: Integer; options: Integer): IDispatch;
begin
  Result := DefaultInterface.Start(selection_type, options);
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TTSelectionProperties.Create(AServer: TTSelection);
begin
  inherited Create;
  FServer := AServer;
end;

function TTSelectionProperties.GetDefaultInterface: ITSelection;
begin
  Result := FServer.DefaultInterface;
end;

function TTSelectionProperties.Get_FixedRegionWidth: Integer;
begin
    Result := DefaultInterface.FixedRegionWidth;
end;

procedure TTSelectionProperties.Set_FixedRegionWidth(pVal: Integer);
begin
  DefaultInterface.Set_FixedRegionWidth(pVal);
end;

function TTSelectionProperties.Get_FixedRegionHeight: Integer;
begin
    Result := DefaultInterface.FixedRegionHeight;
end;

procedure TTSelectionProperties.Set_FixedRegionHeight(pVal: Integer);
begin
  DefaultInterface.Set_FixedRegionHeight(pVal);
end;

{$ENDIF}

class function CoTSelectionInfo.Create: ITSelectionInfo2;
begin
  Result := CreateComObject(CLASS_TSelectionInfo) as ITSelectionInfo2;
end;

class function CoTSelectionInfo.CreateRemote(const MachineName: string): ITSelectionInfo2;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_TSelectionInfo) as ITSelectionInfo2;
end;

procedure TTSelectionInfo.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{AD58B105-E00C-4F3F-81A5-54F741853E5C}';
    IntfIID:   '{C5D9A330-5BB9-4904-B898-4A1DCAFD3C7A}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure TTSelectionInfo.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as ITSelectionInfo2;
  end;
end;

procedure TTSelectionInfo.ConnectTo(svrIntf: ITSelectionInfo2);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure TTSelectionInfo.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function TTSelectionInfo.GetDefaultInterface: ITSelectionInfo2;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
  Result := FIntf;
end;

constructor TTSelectionInfo.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TTSelectionInfoProperties.Create(Self);
{$ENDIF}
end;

destructor TTSelectionInfo.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function TTSelectionInfo.GetServerProperties: TTSelectionInfoProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function TTSelectionInfo.Get_RCLeft: Integer;
begin
    Result := DefaultInterface.RCLeft;
end;

procedure TTSelectionInfo.Set_RCLeft(pVal: Integer);
begin
  DefaultInterface.Set_RCLeft(pVal);
end;

function TTSelectionInfo.Get_RCTop: Integer;
begin
    Result := DefaultInterface.RCTop;
end;

procedure TTSelectionInfo.Set_RCTop(pVal: Integer);
begin
  DefaultInterface.Set_RCTop(pVal);
end;

function TTSelectionInfo.Get_RCWidth: Integer;
begin
    Result := DefaultInterface.RCWidth;
end;

procedure TTSelectionInfo.Set_RCWidth(pVal: Integer);
begin
  DefaultInterface.Set_RCWidth(pVal);
end;

function TTSelectionInfo.Get_RCHeight: Integer;
begin
    Result := DefaultInterface.RCHeight;
end;

procedure TTSelectionInfo.Set_RCHeight(pVal: Integer);
begin
  DefaultInterface.Set_RCHeight(pVal);
end;

procedure TTSelectionInfo.GetClientCoordinates;
begin
  DefaultInterface.GetClientCoordinates;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TTSelectionInfoProperties.Create(AServer: TTSelectionInfo);
begin
  inherited Create;
  FServer := AServer;
end;

function TTSelectionInfoProperties.GetDefaultInterface: ITSelectionInfo2;
begin
  Result := FServer.DefaultInterface;
end;

function TTSelectionInfoProperties.Get_RCLeft: Integer;
begin
    Result := DefaultInterface.RCLeft;
end;

procedure TTSelectionInfoProperties.Set_RCLeft(pVal: Integer);
begin
  DefaultInterface.Set_RCLeft(pVal);
end;

function TTSelectionInfoProperties.Get_RCTop: Integer;
begin
    Result := DefaultInterface.RCTop;
end;

procedure TTSelectionInfoProperties.Set_RCTop(pVal: Integer);
begin
  DefaultInterface.Set_RCTop(pVal);
end;

function TTSelectionInfoProperties.Get_RCWidth: Integer;
begin
    Result := DefaultInterface.RCWidth;
end;

procedure TTSelectionInfoProperties.Set_RCWidth(pVal: Integer);
begin
  DefaultInterface.Set_RCWidth(pVal);
end;

function TTSelectionInfoProperties.Get_RCHeight: Integer;
begin
    Result := DefaultInterface.RCHeight;
end;

procedure TTSelectionInfoProperties.Set_RCHeight(pVal: Integer);
begin
  DefaultInterface.Set_RCHeight(pVal);
end;

{$ENDIF}

procedure Register;
begin
  RegisterComponents(dtlServerPage, [TTSelection, TTSelectionInfo]);
end;

end.
