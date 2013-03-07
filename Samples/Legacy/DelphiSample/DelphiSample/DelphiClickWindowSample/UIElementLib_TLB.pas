unit UIElementLib_TLB;

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
// File generated on 11/3/2011 9:33:50 PM from Type Library described below.

// ************************************************************************  //
// Type Lib: C:\PROGRA~1\DESKPE~1\SCREEN~1\UIELEM~1.DLL (1)
// LIBID: {318E2ADC-5813-45F1-8BC3-77EC829D0F43}
// LCID: 0
// Helpfile: 
// HelpString: UIElement 1.0 Type Library
// DepndLst: 
//   (1) v2.0 stdole, (C:\WINDOWS\system32\stdole2.tlb)
// Errors:
//   Hint: Member 'Set' of 'IUIElem2' changed to 'Set_'
//   Error creating palette bitmap of (TUIElem) : Server C:\Program Files\Deskperience\ScreenScraper Studio\UIElement.dll contains no icons
//   Error creating palette bitmap of (TUIElemCollection) : Server C:\Program Files\Deskperience\ScreenScraper Studio\UIElement.dll contains no icons
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
  UIElementLibMajorVersion = 1;
  UIElementLibMinorVersion = 0;

  LIBID_UIElementLib: TGUID = '{318E2ADC-5813-45F1-8BC3-77EC829D0F43}';

  IID_IUIElem: TGUID = '{ABFB4D5E-9035-46DE-8DD7-238E188E4A14}';
  IID_IUIElem2: TGUID = '{23939C9C-2850-4B30-B2A7-D3F962D83AB1}';
  IID_IUIElemCollection: TGUID = '{EE4275A6-0D7F-4386-A7E4-1F54860D3137}';
  IID_IUIElem3: TGUID = '{A6D9B399-CCE8-4EB5-8FE5-E8D615CD9AE1}';
  CLASS_UIElem: TGUID = '{4864DBD2-56CE-4B10-A870-5950BE6EF8DD}';
  IID_IUIElemCollection2: TGUID = '{A5EC7D6F-37C0-4595-80BB-81739BA03BF4}';
  CLASS_UIElemCollection: TGUID = '{CC0CC8FB-5445-4BE7-AD81-764649E7452B}';

// *********************************************************************//
// Declaration of Enumerations defined in Type Library                    
// *********************************************************************//
// Constants for enum UIE_Subsystem
type
  UIE_Subsystem = TOleEnum;
const
  UIE_WIN32_SUBSYSTEM = $00000000;
  UIE_AA_SUBSYSTEM = $00000001;
  UIE_JAVA_SUBSYSTEM = $00000002;
  UIE_HTML_SUBSYSTEM = $00000003;
  UIE_OTHER_SUBSYSTEM = $00000004;

// Constants for enum UIE_FindScope
type
  UIE_FindScope = TOleEnum;
const
  UIE_FIND_CHILDREN = $00000000;
  UIE_FIND_DESCENDANTS = $00000001;

// Constants for enum UIE_WriteTextMethod
type
  UIE_WriteTextMethod = TOleEnum;
const
  UIE_WTM_NATIVE = $00000000;
  UIE_WTM_SENDKEYS = $00000001;

// Constants for enum UIE_ClickFlags
type
  UIE_ClickFlags = TOleEnum;
const
  UIE_CF_CLICK_MASK = $00000003;
  UIE_CF_SINGLE = $00000000;
  UIE_CF_DOUBLE = $00000001;
  UIE_CF_HOVER = $00000002;
  UIE_CF_BUTTON_MASK = $0000000C;
  UIE_CF_LEFT = $00000000;
  UIE_CF_RIGHT = $00000004;
  UIE_CF_MIDDLE = $00000008;
  UIE_CF_SCREEN_COORDS = $00000010;
  UIE_CF_MOVE_CURSOR = $00000020;
  UIE_CF_WIN32_EVENT = $00000040;

type

// *********************************************************************//
// Forward declaration of types defined in TypeLibrary                    
// *********************************************************************//
  IUIElem = interface;
  IUIElemDisp = dispinterface;
  IUIElem2 = interface;
  IUIElem2Disp = dispinterface;
  IUIElemCollection = interface;
  IUIElemCollectionDisp = dispinterface;
  IUIElem3 = interface;
  IUIElem3Disp = dispinterface;
  IUIElemCollection2 = interface;
  IUIElemCollection2Disp = dispinterface;

// *********************************************************************//
// Declaration of CoClasses defined in Type Library                       
// (NOTE: Here we map each CoClass to its Default Interface)              
// *********************************************************************//
  UIElem = IUIElem3;
  UIElemCollection = IUIElemCollection2;


// *********************************************************************//
// Interface: IUIElem
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {ABFB4D5E-9035-46DE-8DD7-238E188E4A14}
// *********************************************************************//
  IUIElem = interface(IDispatch)
    ['{ABFB4D5E-9035-46DE-8DD7-238E188E4A14}']
    function Get_hwnd: Integer; safecall;
    procedure Set_hwnd(pVal: Integer); safecall;
    function GetID(refresh: WordBool): WideString; safecall;
    procedure InitializeFromID(const bstrID: WideString; vbEnumInvisible: WordBool); safecall;
    procedure InitializeFromPoint(x: Integer; y: Integer; root_wnd: Integer); safecall;
    function IsValid: WordBool; safecall;
    procedure WriteText(method: Integer; const text: WideString); safecall;
    procedure Activate; safecall;
    procedure Click(dx: Integer; dy: Integer; flags: Integer); safecall;
    function IsInForeground: WordBool; safecall;
    function FindAll(scope: Integer; const nodeID: WideString): IUIElemCollection; safecall;
    function FindFirst(scope: Integer; const nodeID: WideString): IUIElemCollection; safecall;
    function TopLevelElement: IUIElem; safecall;
    procedure GetRectangle(out left: Integer; out top: Integer; out right: Integer; 
                           out bottom: Integer); safecall;
    function Get_UseClientCoordinates: WordBool; safecall;
    procedure Set_UseClientCoordinates(pVal: WordBool); safecall;
    function IsLeaf: WordBool; safecall;
    function GetValue: WideString; safecall;
    property hwnd: Integer read Get_hwnd write Set_hwnd;
    property UseClientCoordinates: WordBool read Get_UseClientCoordinates write Set_UseClientCoordinates;
  end;

// *********************************************************************//
// DispIntf:  IUIElemDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {ABFB4D5E-9035-46DE-8DD7-238E188E4A14}
// *********************************************************************//
  IUIElemDisp = dispinterface
    ['{ABFB4D5E-9035-46DE-8DD7-238E188E4A14}']
    property hwnd: Integer dispid 1;
    function GetID(refresh: WordBool): WideString; dispid 2;
    procedure InitializeFromID(const bstrID: WideString; vbEnumInvisible: WordBool); dispid 3;
    procedure InitializeFromPoint(x: Integer; y: Integer; root_wnd: Integer); dispid 4;
    function IsValid: WordBool; dispid 5;
    procedure WriteText(method: Integer; const text: WideString); dispid 6;
    procedure Activate; dispid 7;
    procedure Click(dx: Integer; dy: Integer; flags: Integer); dispid 8;
    function IsInForeground: WordBool; dispid 9;
    function FindAll(scope: Integer; const nodeID: WideString): IUIElemCollection; dispid 10;
    function FindFirst(scope: Integer; const nodeID: WideString): IUIElemCollection; dispid 11;
    function TopLevelElement: IUIElem; dispid 12;
    procedure GetRectangle(out left: Integer; out top: Integer; out right: Integer; 
                           out bottom: Integer); dispid 13;
    property UseClientCoordinates: WordBool dispid 14;
    function IsLeaf: WordBool; dispid 15;
    function GetValue: WideString; dispid 16;
  end;

// *********************************************************************//
// Interface: IUIElem2
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {23939C9C-2850-4B30-B2A7-D3F962D83AB1}
// *********************************************************************//
  IUIElem2 = interface(IUIElem)
    ['{23939C9C-2850-4B30-B2A7-D3F962D83AB1}']
    function Get_parent: IUIElem2; safecall;
    function Get_next: IUIElem2; safecall;
    function Get_previous: IUIElem2; safecall;
    function GetType: WideString; safecall;
    function GetSubsystem: WideString; safecall;
    function Get(const bstrAttr: WideString): OleVariant; safecall;
    procedure Set_(const bstrAttr: WideString; vValue: OleVariant); safecall;
    procedure Wait(const bstrAttr: WideString; vValue: OleVariant; nTimeout: Integer); safecall;
    function IsJavaWindow: WordBool; safecall;
    function IsJavaBridgeEnabled: WordBool; safecall;
    function GetJREPath: WideString; safecall;
    property parent: IUIElem2 read Get_parent;
    property next: IUIElem2 read Get_next;
    property previous: IUIElem2 read Get_previous;
  end;

// *********************************************************************//
// DispIntf:  IUIElem2Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {23939C9C-2850-4B30-B2A7-D3F962D83AB1}
// *********************************************************************//
  IUIElem2Disp = dispinterface
    ['{23939C9C-2850-4B30-B2A7-D3F962D83AB1}']
    property parent: IUIElem2 readonly dispid 17;
    property next: IUIElem2 readonly dispid 18;
    property previous: IUIElem2 readonly dispid 19;
    function GetType: WideString; dispid 20;
    function GetSubsystem: WideString; dispid 21;
    function Get(const bstrAttr: WideString): OleVariant; dispid 22;
    procedure Set_(const bstrAttr: WideString; vValue: OleVariant); dispid 23;
    procedure Wait(const bstrAttr: WideString; vValue: OleVariant; nTimeout: Integer); dispid 24;
    function IsJavaWindow: WordBool; dispid 25;
    function IsJavaBridgeEnabled: WordBool; dispid 26;
    function GetJREPath: WideString; dispid 27;
    property hwnd: Integer dispid 1;
    function GetID(refresh: WordBool): WideString; dispid 2;
    procedure InitializeFromID(const bstrID: WideString; vbEnumInvisible: WordBool); dispid 3;
    procedure InitializeFromPoint(x: Integer; y: Integer; root_wnd: Integer); dispid 4;
    function IsValid: WordBool; dispid 5;
    procedure WriteText(method: Integer; const text: WideString); dispid 6;
    procedure Activate; dispid 7;
    procedure Click(dx: Integer; dy: Integer; flags: Integer); dispid 8;
    function IsInForeground: WordBool; dispid 9;
    function FindAll(scope: Integer; const nodeID: WideString): IUIElemCollection; dispid 10;
    function FindFirst(scope: Integer; const nodeID: WideString): IUIElemCollection; dispid 11;
    function TopLevelElement: IUIElem; dispid 12;
    procedure GetRectangle(out left: Integer; out top: Integer; out right: Integer; 
                           out bottom: Integer); dispid 13;
    property UseClientCoordinates: WordBool dispid 14;
    function IsLeaf: WordBool; dispid 15;
    function GetValue: WideString; dispid 16;
  end;

// *********************************************************************//
// Interface: IUIElemCollection
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {EE4275A6-0D7F-4386-A7E4-1F54860D3137}
// *********************************************************************//
  IUIElemCollection = interface(IDispatch)
    ['{EE4275A6-0D7F-4386-A7E4-1F54860D3137}']
    function GetAt(index: Integer): IUIElem; safecall;
    function Get_length: Integer; safecall;
    property length: Integer read Get_length;
  end;

// *********************************************************************//
// DispIntf:  IUIElemCollectionDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {EE4275A6-0D7F-4386-A7E4-1F54860D3137}
// *********************************************************************//
  IUIElemCollectionDisp = dispinterface
    ['{EE4275A6-0D7F-4386-A7E4-1F54860D3137}']
    function GetAt(index: Integer): IUIElem; dispid 1;
    property length: Integer readonly dispid 2;
  end;

// *********************************************************************//
// Interface: IUIElem3
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {A6D9B399-CCE8-4EB5-8FE5-E8D615CD9AE1}
// *********************************************************************//
  IUIElem3 = interface(IUIElem2)
    ['{A6D9B399-CCE8-4EB5-8FE5-E8D615CD9AE1}']
    procedure InitializeFromSelector(const bstrID: WideString; nTimeout: Integer); safecall;
    procedure Start(const bstrCmd: WideString; const bstrID: WideString; nTimeout: Integer); safecall;
    function GetChecked: WordBool; safecall;
    procedure SetChecked(vbChecked: WordBool); safecall;
    function GetSelectedItem: WideString; safecall;
    procedure SetSelectedItem(const bstrSelItem: WideString); safecall;
    procedure Highlight(nDelay: Integer); safecall;
    procedure SetFocus; safecall;
    function IsFocused: WordBool; safecall;
    function IsEqual(const pElem: IUIElem): WordBool; safecall;
    function Get_autoRefresh: WordBool; safecall;
    procedure Set_autoRefresh(pVal: WordBool); safecall;
    function GetSelector(refresh: WordBool): WideString; safecall;
    function FindFirstElem(scope: Integer; const nodeID: WideString; timeout: Integer): IUIElem; safecall;
    procedure Cleanup; safecall;
    function GetState: WideString; safecall;
    function IsMinimized: WordBool; safecall;
    property autoRefresh: WordBool read Get_autoRefresh write Set_autoRefresh;
  end;

// *********************************************************************//
// DispIntf:  IUIElem3Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {A6D9B399-CCE8-4EB5-8FE5-E8D615CD9AE1}
// *********************************************************************//
  IUIElem3Disp = dispinterface
    ['{A6D9B399-CCE8-4EB5-8FE5-E8D615CD9AE1}']
    procedure InitializeFromSelector(const bstrID: WideString; nTimeout: Integer); dispid 28;
    procedure Start(const bstrCmd: WideString; const bstrID: WideString; nTimeout: Integer); dispid 29;
    function GetChecked: WordBool; dispid 30;
    procedure SetChecked(vbChecked: WordBool); dispid 31;
    function GetSelectedItem: WideString; dispid 32;
    procedure SetSelectedItem(const bstrSelItem: WideString); dispid 33;
    procedure Highlight(nDelay: Integer); dispid 35;
    procedure SetFocus; dispid 36;
    function IsFocused: WordBool; dispid 37;
    function IsEqual(const pElem: IUIElem): WordBool; dispid 38;
    property autoRefresh: WordBool dispid 39;
    function GetSelector(refresh: WordBool): WideString; dispid 40;
    function FindFirstElem(scope: Integer; const nodeID: WideString; timeout: Integer): IUIElem; dispid 41;
    procedure Cleanup; dispid 42;
    function GetState: WideString; dispid 43;
    function IsMinimized: WordBool; dispid 44;
    property parent: IUIElem2 readonly dispid 17;
    property next: IUIElem2 readonly dispid 18;
    property previous: IUIElem2 readonly dispid 19;
    function GetType: WideString; dispid 20;
    function GetSubsystem: WideString; dispid 21;
    function Get(const bstrAttr: WideString): OleVariant; dispid 22;
    procedure Set_(const bstrAttr: WideString; vValue: OleVariant); dispid 23;
    procedure Wait(const bstrAttr: WideString; vValue: OleVariant; nTimeout: Integer); dispid 24;
    function IsJavaWindow: WordBool; dispid 25;
    function IsJavaBridgeEnabled: WordBool; dispid 26;
    function GetJREPath: WideString; dispid 27;
    property hwnd: Integer dispid 1;
    function GetID(refresh: WordBool): WideString; dispid 2;
    procedure InitializeFromID(const bstrID: WideString; vbEnumInvisible: WordBool); dispid 3;
    procedure InitializeFromPoint(x: Integer; y: Integer; root_wnd: Integer); dispid 4;
    function IsValid: WordBool; dispid 5;
    procedure WriteText(method: Integer; const text: WideString); dispid 6;
    procedure Activate; dispid 7;
    procedure Click(dx: Integer; dy: Integer; flags: Integer); dispid 8;
    function IsInForeground: WordBool; dispid 9;
    function FindAll(scope: Integer; const nodeID: WideString): IUIElemCollection; dispid 10;
    function FindFirst(scope: Integer; const nodeID: WideString): IUIElemCollection; dispid 11;
    function TopLevelElement: IUIElem; dispid 12;
    procedure GetRectangle(out left: Integer; out top: Integer; out right: Integer; 
                           out bottom: Integer); dispid 13;
    property UseClientCoordinates: WordBool dispid 14;
    function IsLeaf: WordBool; dispid 15;
    function GetValue: WideString; dispid 16;
  end;

// *********************************************************************//
// Interface: IUIElemCollection2
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {A5EC7D6F-37C0-4595-80BB-81739BA03BF4}
// *********************************************************************//
  IUIElemCollection2 = interface(IUIElemCollection)
    ['{A5EC7D6F-37C0-4595-80BB-81739BA03BF4}']
    function Get_item(index: Integer): IUIElem; safecall;
    property item[index: Integer]: IUIElem read Get_item; default;
  end;

// *********************************************************************//
// DispIntf:  IUIElemCollection2Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {A5EC7D6F-37C0-4595-80BB-81739BA03BF4}
// *********************************************************************//
  IUIElemCollection2Disp = dispinterface
    ['{A5EC7D6F-37C0-4595-80BB-81739BA03BF4}']
    property item[index: Integer]: IUIElem readonly dispid 0; default;
    function GetAt(index: Integer): IUIElem; dispid 1;
    property length: Integer readonly dispid 2;
  end;

// *********************************************************************//
// The Class CoUIElem provides a Create and CreateRemote method to          
// create instances of the default interface IUIElem3 exposed by              
// the CoClass UIElem. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoUIElem = class
    class function Create: IUIElem3;
    class function CreateRemote(const MachineName: string): IUIElem3;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TUIElem
// Help String      : UIElem Class
// Default Interface: IUIElem3
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TUIElemProperties= class;
{$ENDIF}
  TUIElem = class(TOleServer)
  private
    FIntf:        IUIElem3;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TUIElemProperties;
    function      GetServerProperties: TUIElemProperties;
{$ENDIF}
    function      GetDefaultInterface: IUIElem3;
  protected
    procedure InitServerData; override;
    function Get_autoRefresh: WordBool;
    procedure Set_autoRefresh(pVal: WordBool);
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: IUIElem3);
    procedure Disconnect; override;
    procedure InitializeFromSelector(const bstrID: WideString; nTimeout: Integer);
    procedure Start(const bstrCmd: WideString; const bstrID: WideString; nTimeout: Integer);
    function GetChecked: WordBool;
    procedure SetChecked(vbChecked: WordBool);
    function GetSelectedItem: WideString;
    procedure SetSelectedItem(const bstrSelItem: WideString);
    procedure Highlight(nDelay: Integer);
    procedure SetFocus;
    function IsFocused: WordBool;
    function IsEqual(const pElem: IUIElem): WordBool;
    function GetSelector(refresh: WordBool): WideString;
    function FindFirstElem(scope: Integer; const nodeID: WideString; timeout: Integer): IUIElem;
    procedure Cleanup;
    function GetState: WideString;
    function IsMinimized: WordBool;
    property DefaultInterface: IUIElem3 read GetDefaultInterface;
    property autoRefresh: WordBool read Get_autoRefresh write Set_autoRefresh;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TUIElemProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : TUIElem
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TUIElemProperties = class(TPersistent)
  private
    FServer:    TUIElem;
    function    GetDefaultInterface: IUIElem3;
    constructor Create(AServer: TUIElem);
  protected
    function Get_autoRefresh: WordBool;
    procedure Set_autoRefresh(pVal: WordBool);
  public
    property DefaultInterface: IUIElem3 read GetDefaultInterface;
  published
    property autoRefresh: WordBool read Get_autoRefresh write Set_autoRefresh;
  end;
{$ENDIF}


// *********************************************************************//
// The Class CoUIElemCollection provides a Create and CreateRemote method to          
// create instances of the default interface IUIElemCollection2 exposed by              
// the CoClass UIElemCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoUIElemCollection = class
    class function Create: IUIElemCollection2;
    class function CreateRemote(const MachineName: string): IUIElemCollection2;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TUIElemCollection
// Help String      : UIElemCollection Class
// Default Interface: IUIElemCollection2
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TUIElemCollectionProperties= class;
{$ENDIF}
  TUIElemCollection = class(TOleServer)
  private
    FIntf:        IUIElemCollection2;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TUIElemCollectionProperties;
    function      GetServerProperties: TUIElemCollectionProperties;
{$ENDIF}
    function      GetDefaultInterface: IUIElemCollection2;
  protected
    procedure InitServerData; override;
    function Get_item(index: Integer): IUIElem;
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: IUIElemCollection2);
    procedure Disconnect; override;
    property DefaultInterface: IUIElemCollection2 read GetDefaultInterface;
    property item[index: Integer]: IUIElem read Get_item; default;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TUIElemCollectionProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : TUIElemCollection
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TUIElemCollectionProperties = class(TPersistent)
  private
    FServer:    TUIElemCollection;
    function    GetDefaultInterface: IUIElemCollection2;
    constructor Create(AServer: TUIElemCollection);
  protected
    function Get_item(index: Integer): IUIElem;
  public
    property DefaultInterface: IUIElemCollection2 read GetDefaultInterface;
  published
  end;
{$ENDIF}


procedure Register;

resourcestring
  dtlServerPage = 'ActiveX';

  dtlOcxPage = 'ActiveX';

implementation

uses ComObj;

class function CoUIElem.Create: IUIElem3;
begin
  Result := CreateComObject(CLASS_UIElem) as IUIElem3;
end;

class function CoUIElem.CreateRemote(const MachineName: string): IUIElem3;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_UIElem) as IUIElem3;
end;

procedure TUIElem.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{4864DBD2-56CE-4B10-A870-5950BE6EF8DD}';
    IntfIID:   '{A6D9B399-CCE8-4EB5-8FE5-E8D615CD9AE1}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure TUIElem.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as IUIElem3;
  end;
end;

procedure TUIElem.ConnectTo(svrIntf: IUIElem3);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure TUIElem.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function TUIElem.GetDefaultInterface: IUIElem3;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
  Result := FIntf;
end;

constructor TUIElem.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TUIElemProperties.Create(Self);
{$ENDIF}
end;

destructor TUIElem.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function TUIElem.GetServerProperties: TUIElemProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function TUIElem.Get_autoRefresh: WordBool;
begin
    Result := DefaultInterface.autoRefresh;
end;

procedure TUIElem.Set_autoRefresh(pVal: WordBool);
begin
  DefaultInterface.Set_autoRefresh(pVal);
end;

procedure TUIElem.InitializeFromSelector(const bstrID: WideString; nTimeout: Integer);
begin
  DefaultInterface.InitializeFromSelector(bstrID, nTimeout);
end;

procedure TUIElem.Start(const bstrCmd: WideString; const bstrID: WideString; nTimeout: Integer);
begin
  DefaultInterface.Start(bstrCmd, bstrID, nTimeout);
end;

function TUIElem.GetChecked: WordBool;
begin
  Result := DefaultInterface.GetChecked;
end;

procedure TUIElem.SetChecked(vbChecked: WordBool);
begin
  DefaultInterface.SetChecked(vbChecked);
end;

function TUIElem.GetSelectedItem: WideString;
begin
  Result := DefaultInterface.GetSelectedItem;
end;

procedure TUIElem.SetSelectedItem(const bstrSelItem: WideString);
begin
  DefaultInterface.SetSelectedItem(bstrSelItem);
end;

procedure TUIElem.Highlight(nDelay: Integer);
begin
  DefaultInterface.Highlight(nDelay);
end;

procedure TUIElem.SetFocus;
begin
  DefaultInterface.SetFocus;
end;

function TUIElem.IsFocused: WordBool;
begin
  Result := DefaultInterface.IsFocused;
end;

function TUIElem.IsEqual(const pElem: IUIElem): WordBool;
begin
  Result := DefaultInterface.IsEqual(pElem);
end;

function TUIElem.GetSelector(refresh: WordBool): WideString;
begin
  Result := DefaultInterface.GetSelector(refresh);
end;

function TUIElem.FindFirstElem(scope: Integer; const nodeID: WideString; timeout: Integer): IUIElem;
begin
  Result := DefaultInterface.FindFirstElem(scope, nodeID, timeout);
end;

procedure TUIElem.Cleanup;
begin
  DefaultInterface.Cleanup;
end;

function TUIElem.GetState: WideString;
begin
  Result := DefaultInterface.GetState;
end;

function TUIElem.IsMinimized: WordBool;
begin
  Result := DefaultInterface.IsMinimized;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TUIElemProperties.Create(AServer: TUIElem);
begin
  inherited Create;
  FServer := AServer;
end;

function TUIElemProperties.GetDefaultInterface: IUIElem3;
begin
  Result := FServer.DefaultInterface;
end;

function TUIElemProperties.Get_autoRefresh: WordBool;
begin
    Result := DefaultInterface.autoRefresh;
end;

procedure TUIElemProperties.Set_autoRefresh(pVal: WordBool);
begin
  DefaultInterface.Set_autoRefresh(pVal);
end;

{$ENDIF}

class function CoUIElemCollection.Create: IUIElemCollection2;
begin
  Result := CreateComObject(CLASS_UIElemCollection) as IUIElemCollection2;
end;

class function CoUIElemCollection.CreateRemote(const MachineName: string): IUIElemCollection2;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_UIElemCollection) as IUIElemCollection2;
end;

procedure TUIElemCollection.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{CC0CC8FB-5445-4BE7-AD81-764649E7452B}';
    IntfIID:   '{A5EC7D6F-37C0-4595-80BB-81739BA03BF4}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure TUIElemCollection.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as IUIElemCollection2;
  end;
end;

procedure TUIElemCollection.ConnectTo(svrIntf: IUIElemCollection2);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure TUIElemCollection.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function TUIElemCollection.GetDefaultInterface: IUIElemCollection2;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
  Result := FIntf;
end;

constructor TUIElemCollection.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TUIElemCollectionProperties.Create(Self);
{$ENDIF}
end;

destructor TUIElemCollection.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function TUIElemCollection.GetServerProperties: TUIElemCollectionProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function TUIElemCollection.Get_item(index: Integer): IUIElem;
begin
    Result := DefaultInterface.item[index];
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TUIElemCollectionProperties.Create(AServer: TUIElemCollection);
begin
  inherited Create;
  FServer := AServer;
end;

function TUIElemCollectionProperties.GetDefaultInterface: IUIElemCollection2;
begin
  Result := FServer.DefaultInterface;
end;

function TUIElemCollectionProperties.Get_item(index: Integer): IUIElem;
begin
    Result := DefaultInterface.item[index];
end;

{$ENDIF}

procedure Register;
begin
  RegisterComponents(dtlServerPage, [TUIElem, TUIElemCollection]);
end;

end.
