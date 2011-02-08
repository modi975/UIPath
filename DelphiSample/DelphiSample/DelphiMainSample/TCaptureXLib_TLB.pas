unit TCaptureXLib_TLB;

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

// $Rev: 8291 $
// File generated on 3/7/2008 11:04:14 from Type Library described below.

// ************************************************************************  //
// Type Lib: d:\Florin\Projects\Pozitiv\ScreenScraping\Output\bin\Release\TCaptureX.dll (1)
// LIBID: {92657C70-D31B-4930-9014-379E3F6FB91A}
// LCID: 0
// Helpfile: 
// HelpString: TCaptureX 1.0 Type Library
// DepndLst: 
//   (1) v2.0 stdole, (C:\WINDOWS\system32\stdole2.tlb)
// Errors:
//   Hint: Symbol 'Type' renamed to 'type_'
//   Hint: Symbol 'Type' renamed to 'type_'
//   Error creating palette bitmap of (TTextCaptureX) : Server d:\Florin\Projects\Pozitiv\ScreenScraping\Output\bin\Release\TCaptureX.dll contains no icons
//   Error creating palette bitmap of (TGetAAText) : Server d:\Florin\Projects\Pozitiv\ScreenScraping\Output\bin\Release\TCaptureX.dll contains no icons
//   Error creating palette bitmap of (TTSelection) : Server d:\Florin\Projects\Pozitiv\ScreenScraping\Output\bin\Release\TCaptureX.dll contains no icons
//   Error creating palette bitmap of (TTSelectionInfo) : Server d:\Florin\Projects\Pozitiv\ScreenScraping\Output\bin\Release\TCaptureX.dll contains no icons
//   Error creating palette bitmap of (TTHighlightInfo) : Server d:\Florin\Projects\Pozitiv\ScreenScraping\Output\bin\Release\TCaptureX.dll contains no icons
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
  TCaptureXLibMajorVersion = 1;
  TCaptureXLibMinorVersion = 1;

  LIBID_TCaptureXLib: TGUID = '{92657C70-D31B-4930-9014-379E3F6FB91A}';

  IID_ITextCaptureX: TGUID = '{EEA5ABD9-2C89-4CDD-9C07-C3DDDF162A37}';
  IID_ITextCaptureX2: TGUID = '{E2500574-7215-4028-A567-3A7D77A4B2B1}';
  IID_ITextCaptureX3: TGUID = '{C9D57541-BAD7-46B4-82D8-2041546133BF}';
  IID_ITextCaptureX4: TGUID = '{ACFD5F3E-946F-4A6A-8B76-450F94120D4C}';
  IID_ITextCaptureX5: TGUID = '{D460C8E0-B0EA-4F9B-8E2E-5042A191FA79}';
  IID_ITextCaptureX6: TGUID = '{419BE681-BCA8-49D0-9BAD-8A088B1C043B}';
  IID_ITextCaptureX7: TGUID = '{88CCC373-72B2-4AFD-AD2A-8C39956ECBFE}';
  CLASS_TextCaptureX: TGUID = '{13FE2FA1-EE8B-45B9-BBB4-08E5F2F43AC3}';
  IID_IGetAAText: TGUID = '{4652E117-CDF0-4B10-B3C9-4FE74FD0FA5B}';
  IID_IGetAAText2: TGUID = '{71EA4E83-A80C-435B-8B77-76D2E45D02A6}';
  CLASS_GetAAText: TGUID = '{924699E8-66EF-4EB9-AB6E-3CA9660B31EC}';
  IID_ITHighlightInfo: TGUID = '{FF7B48D0-4615-49FA-970B-56A95EDA143A}';
  IID_ITSelection: TGUID = '{24455CC7-C5E2-4D5B-A37C-47C76CFE1905}';
  CLASS_TSelection: TGUID = '{BF616448-1D65-4559-9293-0F6B607BA892}';
  IID_ITSelectionInfo: TGUID = '{12E679EC-86BF-4AA2-AA94-1B8D16E30EAF}';
  CLASS_TSelectionInfo: TGUID = '{AD58B105-E00C-4F3F-81A5-54F741853E5C}';
  CLASS_THighlightInfo: TGUID = '{B13501DF-12B3-4A6A-9A5B-8FA1EBCF8699}';

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
  tsSelFlagDefaultText = $0000000C;
  tsSelFlagDefaultGraphic = $00000013;
  tsSelFlagDefault = $0000000C;

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

type

// *********************************************************************//
// Forward declaration of types defined in TypeLibrary                    
// *********************************************************************//
  ITextCaptureX = interface;
  ITextCaptureXDisp = dispinterface;
  ITextCaptureX2 = interface;
  ITextCaptureX2Disp = dispinterface;
  ITextCaptureX3 = interface;
  ITextCaptureX3Disp = dispinterface;
  ITextCaptureX4 = interface;
  ITextCaptureX4Disp = dispinterface;
  ITextCaptureX5 = interface;
  ITextCaptureX5Disp = dispinterface;
  ITextCaptureX6 = interface;
  ITextCaptureX6Disp = dispinterface;
  ITextCaptureX7 = interface;
  ITextCaptureX7Disp = dispinterface;
  IGetAAText = interface;
  IGetAATextDisp = dispinterface;
  IGetAAText2 = interface;
  IGetAAText2Disp = dispinterface;
  ITHighlightInfo = interface;
  ITHighlightInfoDisp = dispinterface;
  ITSelection = interface;
  ITSelectionDisp = dispinterface;
  ITSelectionInfo = interface;
  ITSelectionInfoDisp = dispinterface;

// *********************************************************************//
// Declaration of CoClasses defined in Type Library                       
// (NOTE: Here we map each CoClass to its Default Interface)              
// *********************************************************************//
  TextCaptureX = ITextCaptureX;
  GetAAText = IGetAAText;
  TSelection = ITSelection;
  TSelectionInfo = ITSelectionInfo;
  THighlightInfo = ITHighlightInfo;


// *********************************************************************//
// Interface: ITextCaptureX
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {EEA5ABD9-2C89-4CDD-9C07-C3DDDF162A37}
// *********************************************************************//
  ITextCaptureX = interface(IDispatch)
    ['{EEA5ABD9-2C89-4CDD-9C07-C3DDDF162A37}']
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString; safecall;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString; safecall;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer; safecall;
    function CaptureActiveWindow: WideString; safecall;
    function GetActiveWindowHwnd: Integer; safecall;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureXDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {EEA5ABD9-2C89-4CDD-9C07-C3DDDF162A37}
// *********************************************************************//
  ITextCaptureXDisp = dispinterface
    ['{EEA5ABD9-2C89-4CDD-9C07-C3DDDF162A37}']
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString; dispid 1;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString; dispid 2;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer; dispid 3;
    function CaptureActiveWindow: WideString; dispid 4;
    function GetActiveWindowHwnd: Integer; dispid 5;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer; dispid 6;
  end;

// *********************************************************************//
// Interface: ITextCaptureX2
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {E2500574-7215-4028-A567-3A7D77A4B2B1}
// *********************************************************************//
  ITextCaptureX2 = interface(ITextCaptureX)
    ['{E2500574-7215-4028-A567-3A7D77A4B2B1}']
    function GetTextFromPoint2(hwnd: Integer; x: Integer; y: Integer; const separators: WideString): WideString; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX2Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {E2500574-7215-4028-A567-3A7D77A4B2B1}
// *********************************************************************//
  ITextCaptureX2Disp = dispinterface
    ['{E2500574-7215-4028-A567-3A7D77A4B2B1}']
    function GetTextFromPoint2(hwnd: Integer; x: Integer; y: Integer; const separators: WideString): WideString; dispid 7;
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString; dispid 1;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString; dispid 2;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer; dispid 3;
    function CaptureActiveWindow: WideString; dispid 4;
    function GetActiveWindowHwnd: Integer; dispid 5;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer; dispid 6;
  end;

// *********************************************************************//
// Interface: ITextCaptureX3
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {C9D57541-BAD7-46B4-82D8-2041546133BF}
// *********************************************************************//
  ITextCaptureX3 = interface(ITextCaptureX2)
    ['{C9D57541-BAD7-46B4-82D8-2041546133BF}']
    function CaptureActiveWindow2(pid: Integer): WideString; safecall;
    function GetActiveWindowHwnd2(pid: Integer): Integer; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX3Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {C9D57541-BAD7-46B4-82D8-2041546133BF}
// *********************************************************************//
  ITextCaptureX3Disp = dispinterface
    ['{C9D57541-BAD7-46B4-82D8-2041546133BF}']
    function CaptureActiveWindow2(pid: Integer): WideString; dispid 8;
    function GetActiveWindowHwnd2(pid: Integer): Integer; dispid 9;
    function GetTextFromPoint2(hwnd: Integer; x: Integer; y: Integer; const separators: WideString): WideString; dispid 7;
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString; dispid 1;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString; dispid 2;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer; dispid 3;
    function CaptureActiveWindow: WideString; dispid 4;
    function GetActiveWindowHwnd: Integer; dispid 5;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer; dispid 6;
  end;

// *********************************************************************//
// Interface: ITextCaptureX4
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {ACFD5F3E-946F-4A6A-8B76-450F94120D4C}
// *********************************************************************//
  ITextCaptureX4 = interface(ITextCaptureX3)
    ['{ACFD5F3E-946F-4A6A-8B76-450F94120D4C}']
    procedure GetCaret(hwnd: Integer; out x: Integer; out y: Integer); safecall;
    procedure GetCaret2(out hwnd: Integer; out x: Integer; out y: Integer); safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX4Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {ACFD5F3E-946F-4A6A-8B76-450F94120D4C}
// *********************************************************************//
  ITextCaptureX4Disp = dispinterface
    ['{ACFD5F3E-946F-4A6A-8B76-450F94120D4C}']
    procedure GetCaret(hwnd: Integer; out x: Integer; out y: Integer); dispid 10;
    procedure GetCaret2(out hwnd: Integer; out x: Integer; out y: Integer); dispid 11;
    function CaptureActiveWindow2(pid: Integer): WideString; dispid 8;
    function GetActiveWindowHwnd2(pid: Integer): Integer; dispid 9;
    function GetTextFromPoint2(hwnd: Integer; x: Integer; y: Integer; const separators: WideString): WideString; dispid 7;
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString; dispid 1;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString; dispid 2;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer; dispid 3;
    function CaptureActiveWindow: WideString; dispid 4;
    function GetActiveWindowHwnd: Integer; dispid 5;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer; dispid 6;
  end;

// *********************************************************************//
// Interface: ITextCaptureX5
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {D460C8E0-B0EA-4F9B-8E2E-5042A191FA79}
// *********************************************************************//
  ITextCaptureX5 = interface(ITextCaptureX4)
    ['{D460C8E0-B0EA-4F9B-8E2E-5042A191FA79}']
    function GetTextFromPointWithFont(hwnd: Integer; x: Integer; y: Integer; out font: IFontDisp): WideString; safecall;
    function GetTextFromRectWithFont(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                     height: Integer; out font: IFontDisp): WideString; safecall;
    function CaptureActiveWindowWithFont(out font: IFontDisp): WideString; safecall;
    function GetTextFromPoint2WithFont(hwnd: Integer; x: Integer; y: Integer; 
                                       const separators: WideString; out font: IFontDisp): WideString; safecall;
    function CaptureActiveWindow2WithFont(pid: Integer; out font: IFontDisp): WideString; safecall;
    function CaptureWindow(hwnd: Integer): WideString; safecall;
    function CaptureWindowWithFont(hwnd: Integer; out font: IFontDisp): WideString; safecall;
    function Get_UseClientCoordinates: WordBool; safecall;
    procedure Set_UseClientCoordinates(pVal: WordBool); safecall;
    function Get_BringWindowToTop: WordBool; safecall;
    procedure Set_BringWindowToTop(pVal: WordBool); safecall;
    function GetFullTextAA(hwnd: Integer): WideString; safecall;
    property UseClientCoordinates: WordBool read Get_UseClientCoordinates write Set_UseClientCoordinates;
    property BringWindowToTop: WordBool read Get_BringWindowToTop write Set_BringWindowToTop;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX5Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {D460C8E0-B0EA-4F9B-8E2E-5042A191FA79}
// *********************************************************************//
  ITextCaptureX5Disp = dispinterface
    ['{D460C8E0-B0EA-4F9B-8E2E-5042A191FA79}']
    function GetTextFromPointWithFont(hwnd: Integer; x: Integer; y: Integer; out font: IFontDisp): WideString; dispid 12;
    function GetTextFromRectWithFont(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                     height: Integer; out font: IFontDisp): WideString; dispid 13;
    function CaptureActiveWindowWithFont(out font: IFontDisp): WideString; dispid 14;
    function GetTextFromPoint2WithFont(hwnd: Integer; x: Integer; y: Integer; 
                                       const separators: WideString; out font: IFontDisp): WideString; dispid 15;
    function CaptureActiveWindow2WithFont(pid: Integer; out font: IFontDisp): WideString; dispid 16;
    function CaptureWindow(hwnd: Integer): WideString; dispid 17;
    function CaptureWindowWithFont(hwnd: Integer; out font: IFontDisp): WideString; dispid 18;
    property UseClientCoordinates: WordBool dispid 19;
    property BringWindowToTop: WordBool dispid 20;
    function GetFullTextAA(hwnd: Integer): WideString; dispid 21;
    procedure GetCaret(hwnd: Integer; out x: Integer; out y: Integer); dispid 10;
    procedure GetCaret2(out hwnd: Integer; out x: Integer; out y: Integer); dispid 11;
    function CaptureActiveWindow2(pid: Integer): WideString; dispid 8;
    function GetActiveWindowHwnd2(pid: Integer): Integer; dispid 9;
    function GetTextFromPoint2(hwnd: Integer; x: Integer; y: Integer; const separators: WideString): WideString; dispid 7;
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString; dispid 1;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString; dispid 2;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer; dispid 3;
    function CaptureActiveWindow: WideString; dispid 4;
    function GetActiveWindowHwnd: Integer; dispid 5;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer; dispid 6;
  end;

// *********************************************************************//
// Interface: ITextCaptureX6
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {419BE681-BCA8-49D0-9BAD-8A088B1C043B}
// *********************************************************************//
  ITextCaptureX6 = interface(ITextCaptureX5)
    ['{419BE681-BCA8-49D0-9BAD-8A088B1C043B}']
    function Get_FormattedText: WordBool; safecall;
    procedure Set_FormattedText(pVal: WordBool); safecall;
    property FormattedText: WordBool read Get_FormattedText write Set_FormattedText;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX6Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {419BE681-BCA8-49D0-9BAD-8A088B1C043B}
// *********************************************************************//
  ITextCaptureX6Disp = dispinterface
    ['{419BE681-BCA8-49D0-9BAD-8A088B1C043B}']
    property FormattedText: WordBool dispid 22;
    function GetTextFromPointWithFont(hwnd: Integer; x: Integer; y: Integer; out font: IFontDisp): WideString; dispid 12;
    function GetTextFromRectWithFont(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                     height: Integer; out font: IFontDisp): WideString; dispid 13;
    function CaptureActiveWindowWithFont(out font: IFontDisp): WideString; dispid 14;
    function GetTextFromPoint2WithFont(hwnd: Integer; x: Integer; y: Integer; 
                                       const separators: WideString; out font: IFontDisp): WideString; dispid 15;
    function CaptureActiveWindow2WithFont(pid: Integer; out font: IFontDisp): WideString; dispid 16;
    function CaptureWindow(hwnd: Integer): WideString; dispid 17;
    function CaptureWindowWithFont(hwnd: Integer; out font: IFontDisp): WideString; dispid 18;
    property UseClientCoordinates: WordBool dispid 19;
    property BringWindowToTop: WordBool dispid 20;
    function GetFullTextAA(hwnd: Integer): WideString; dispid 21;
    procedure GetCaret(hwnd: Integer; out x: Integer; out y: Integer); dispid 10;
    procedure GetCaret2(out hwnd: Integer; out x: Integer; out y: Integer); dispid 11;
    function CaptureActiveWindow2(pid: Integer): WideString; dispid 8;
    function GetActiveWindowHwnd2(pid: Integer): Integer; dispid 9;
    function GetTextFromPoint2(hwnd: Integer; x: Integer; y: Integer; const separators: WideString): WideString; dispid 7;
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString; dispid 1;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString; dispid 2;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer; dispid 3;
    function CaptureActiveWindow: WideString; dispid 4;
    function GetActiveWindowHwnd: Integer; dispid 5;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer; dispid 6;
  end;

// *********************************************************************//
// Interface: ITextCaptureX7
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {88CCC373-72B2-4AFD-AD2A-8C39956ECBFE}
// *********************************************************************//
  ITextCaptureX7 = interface(ITextCaptureX6)
    ['{88CCC373-72B2-4AFD-AD2A-8C39956ECBFE}']
    procedure Set_NoWordsInContext(Param1: Integer); safecall;
    function Get_Context: WideString; safecall;
    procedure EndCaptureSession; safecall;
    property NoWordsInContext: Integer write Set_NoWordsInContext;
    property Context: WideString read Get_Context;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX7Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {88CCC373-72B2-4AFD-AD2A-8C39956ECBFE}
// *********************************************************************//
  ITextCaptureX7Disp = dispinterface
    ['{88CCC373-72B2-4AFD-AD2A-8C39956ECBFE}']
    property NoWordsInContext: Integer writeonly dispid 23;
    property Context: WideString readonly dispid 24;
    procedure EndCaptureSession; dispid 25;
    property FormattedText: WordBool dispid 22;
    function GetTextFromPointWithFont(hwnd: Integer; x: Integer; y: Integer; out font: IFontDisp): WideString; dispid 12;
    function GetTextFromRectWithFont(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                     height: Integer; out font: IFontDisp): WideString; dispid 13;
    function CaptureActiveWindowWithFont(out font: IFontDisp): WideString; dispid 14;
    function GetTextFromPoint2WithFont(hwnd: Integer; x: Integer; y: Integer; 
                                       const separators: WideString; out font: IFontDisp): WideString; dispid 15;
    function CaptureActiveWindow2WithFont(pid: Integer; out font: IFontDisp): WideString; dispid 16;
    function CaptureWindow(hwnd: Integer): WideString; dispid 17;
    function CaptureWindowWithFont(hwnd: Integer; out font: IFontDisp): WideString; dispid 18;
    property UseClientCoordinates: WordBool dispid 19;
    property BringWindowToTop: WordBool dispid 20;
    function GetFullTextAA(hwnd: Integer): WideString; dispid 21;
    procedure GetCaret(hwnd: Integer; out x: Integer; out y: Integer); dispid 10;
    procedure GetCaret2(out hwnd: Integer; out x: Integer; out y: Integer); dispid 11;
    function CaptureActiveWindow2(pid: Integer): WideString; dispid 8;
    function GetActiveWindowHwnd2(pid: Integer): Integer; dispid 9;
    function GetTextFromPoint2(hwnd: Integer; x: Integer; y: Integer; const separators: WideString): WideString; dispid 7;
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString; dispid 1;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString; dispid 2;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer; dispid 3;
    function CaptureActiveWindow: WideString; dispid 4;
    function GetActiveWindowHwnd: Integer; dispid 5;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer; dispid 6;
  end;

// *********************************************************************//
// Interface: IGetAAText
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {4652E117-CDF0-4B10-B3C9-4FE74FD0FA5B}
// *********************************************************************//
  IGetAAText = interface(IDispatch)
    ['{4652E117-CDF0-4B10-B3C9-4FE74FD0FA5B}']
    function GetFullTextAA(hwnd: Integer): WideString; safecall;
  end;

// *********************************************************************//
// DispIntf:  IGetAATextDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {4652E117-CDF0-4B10-B3C9-4FE74FD0FA5B}
// *********************************************************************//
  IGetAATextDisp = dispinterface
    ['{4652E117-CDF0-4B10-B3C9-4FE74FD0FA5B}']
    function GetFullTextAA(hwnd: Integer): WideString; dispid 1;
  end;

// *********************************************************************//
// Interface: IGetAAText2
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {71EA4E83-A80C-435B-8B77-76D2E45D02A6}
// *********************************************************************//
  IGetAAText2 = interface(IGetAAText)
    ['{71EA4E83-A80C-435B-8B77-76D2E45D02A6}']
    function Get_HighlightInfo: ITHighlightInfo; safecall;
    procedure Set_HighlightInfo(const pVal: ITHighlightInfo); safecall;
    function Get_ExtractHighlightInfo: WordBool; safecall;
    procedure Set_ExtractHighlightInfo(pVal: WordBool); safecall;
    property HighlightInfo: ITHighlightInfo read Get_HighlightInfo write Set_HighlightInfo;
    property ExtractHighlightInfo: WordBool read Get_ExtractHighlightInfo write Set_ExtractHighlightInfo;
  end;

// *********************************************************************//
// DispIntf:  IGetAAText2Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {71EA4E83-A80C-435B-8B77-76D2E45D02A6}
// *********************************************************************//
  IGetAAText2Disp = dispinterface
    ['{71EA4E83-A80C-435B-8B77-76D2E45D02A6}']
    property HighlightInfo: ITHighlightInfo dispid 2;
    property ExtractHighlightInfo: WordBool dispid 3;
    function GetFullTextAA(hwnd: Integer): WideString; dispid 1;
  end;

// *********************************************************************//
// Interface: ITHighlightInfo
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {FF7B48D0-4615-49FA-970B-56A95EDA143A}
// *********************************************************************//
  ITHighlightInfo = interface(IDispatch)
    ['{FF7B48D0-4615-49FA-970B-56A95EDA143A}']
    function Get_hwnd: Integer; safecall;
    procedure Set_hwnd(pVal: Integer); safecall;
    function Get_Count: Integer; safecall;
    procedure Add(const text: WideString; left: Integer; top: Integer; right: Integer; 
                  bottom: Integer); safecall;
    procedure Remove(index: Integer); safecall;
    procedure Get(index: Integer; out text: WideString; out left: Integer; out top: Integer; 
                  out right: Integer; out bottom: Integer); safecall;
    procedure PerformHighlight(delay: Integer); safecall;
    procedure PerformHighlightFull(delay: Integer); safecall;
    property hwnd: Integer read Get_hwnd write Set_hwnd;
    property Count: Integer read Get_Count;
  end;

// *********************************************************************//
// DispIntf:  ITHighlightInfoDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {FF7B48D0-4615-49FA-970B-56A95EDA143A}
// *********************************************************************//
  ITHighlightInfoDisp = dispinterface
    ['{FF7B48D0-4615-49FA-970B-56A95EDA143A}']
    property hwnd: Integer dispid 1;
    property Count: Integer readonly dispid 2;
    procedure Add(const text: WideString; left: Integer; top: Integer; right: Integer; 
                  bottom: Integer); dispid 3;
    procedure Remove(index: Integer); dispid 4;
    procedure Get(index: Integer; out text: WideString; out left: Integer; out top: Integer; 
                  out right: Integer; out bottom: Integer); dispid 5;
    procedure PerformHighlight(delay: Integer); dispid 6;
    procedure PerformHighlightFull(delay: Integer); dispid 7;
  end;

// *********************************************************************//
// Interface: ITSelection
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {24455CC7-C5E2-4D5B-A37C-47C76CFE1905}
// *********************************************************************//
  ITSelection = interface(IDispatch)
    ['{24455CC7-C5E2-4D5B-A37C-47C76CFE1905}']
    procedure Start(selection_type: Integer; options: Integer; 
                    out selection_result: ITSelectionInfo; out result: Integer); safecall;
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
    procedure Start(selection_type: Integer; options: Integer; 
                    out selection_result: ITSelectionInfo; out result: Integer); dispid 1;
    property FixedRegionWidth: Integer dispid 3;
    property FixedRegionHeight: Integer dispid 4;
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
    property type_: Integer read Get_type_ write Set_type_;
    property WindowHandle: Integer read Get_WindowHandle write Set_WindowHandle;
    property Points: OleVariant read Get_Points write Set_Points;
    property Image: IPictureDisp read Get_Image write Set_Image;
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
  end;

// *********************************************************************//
// The Class CoTextCaptureX provides a Create and CreateRemote method to          
// create instances of the default interface ITextCaptureX exposed by              
// the CoClass TextCaptureX. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoTextCaptureX = class
    class function Create: ITextCaptureX;
    class function CreateRemote(const MachineName: string): ITextCaptureX;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TTextCaptureX
// Help String      : TextCaptureX Class
// Default Interface: ITextCaptureX
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TTextCaptureXProperties= class;
{$ENDIF}
  TTextCaptureX = class(TOleServer)
  private
    FIntf: ITextCaptureX;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps: TTextCaptureXProperties;
    function GetServerProperties: TTextCaptureXProperties;
{$ENDIF}
    function GetDefaultInterface: ITextCaptureX;
  protected
    procedure InitServerData; override;
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: ITextCaptureX);
    procedure Disconnect; override;
    function GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer): WideString;
    function CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                out width: Integer; out height: Integer): Integer;
    function CaptureActiveWindow: WideString;
    function GetActiveWindowHwnd: Integer;
    function CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer;
    property DefaultInterface: ITextCaptureX read GetDefaultInterface;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TTextCaptureXProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : TTextCaptureX
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TTextCaptureXProperties = class(TPersistent)
  private
    FServer:    TTextCaptureX;
    function    GetDefaultInterface: ITextCaptureX;
    constructor Create(AServer: TTextCaptureX);
  protected
  public
    property DefaultInterface: ITextCaptureX read GetDefaultInterface;
  published
  end;
{$ENDIF}


// *********************************************************************//
// The Class CoGetAAText provides a Create and CreateRemote method to          
// create instances of the default interface IGetAAText exposed by              
// the CoClass GetAAText. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoGetAAText = class
    class function Create: IGetAAText;
    class function CreateRemote(const MachineName: string): IGetAAText;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TGetAAText
// Help String      : GetAAText
// Default Interface: IGetAAText
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TGetAATextProperties= class;
{$ENDIF}
  TGetAAText = class(TOleServer)
  private
    FIntf: IGetAAText;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps: TGetAATextProperties;
    function GetServerProperties: TGetAATextProperties;
{$ENDIF}
    function GetDefaultInterface: IGetAAText;
  protected
    procedure InitServerData; override;
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: IGetAAText);
    procedure Disconnect; override;
    function GetFullTextAA(hwnd: Integer): WideString;
    property DefaultInterface: IGetAAText read GetDefaultInterface;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TGetAATextProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : TGetAAText
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TGetAATextProperties = class(TPersistent)
  private
    FServer:    TGetAAText;
    function    GetDefaultInterface: IGetAAText;
    constructor Create(AServer: TGetAAText);
  protected
  public
    property DefaultInterface: IGetAAText read GetDefaultInterface;
  published
  end;
{$ENDIF}


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
    FIntf: ITSelection;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps: TTSelectionProperties;
    function GetServerProperties: TTSelectionProperties;
{$ENDIF}
    function GetDefaultInterface: ITSelection;
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
    procedure Start(selection_type: Integer; options: Integer; 
                    out selection_result: ITSelectionInfo; out result: Integer);
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
// create instances of the default interface ITSelectionInfo exposed by              
// the CoClass TSelectionInfo. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoTSelectionInfo = class
    class function Create: ITSelectionInfo;
    class function CreateRemote(const MachineName: string): ITSelectionInfo;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TTSelectionInfo
// Help String      : TSelectionInfo
// Default Interface: ITSelectionInfo
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TTSelectionInfoProperties= class;
{$ENDIF}
  TTSelectionInfo = class(TOleServer)
  private
    FIntf: ITSelectionInfo;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps: TTSelectionInfoProperties;
    function GetServerProperties: TTSelectionInfoProperties;
{$ENDIF}
    function GetDefaultInterface: ITSelectionInfo;
  protected
    procedure InitServerData; override;
    function Get_type_: Integer;
    procedure Set_type_(pVal: Integer);
    function Get_WindowHandle: Integer;
    procedure Set_WindowHandle(pVal: Integer);
    function Get_Points: OleVariant;
    procedure Set_Points(pVal: OleVariant);
    function Get_Image: IPictureDisp;
    procedure Set_Image(const pVal: IPictureDisp);
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: ITSelectionInfo);
    procedure Disconnect; override;
    property DefaultInterface: ITSelectionInfo read GetDefaultInterface;
    property Points: OleVariant read Get_Points write Set_Points;
    property type_: Integer read Get_type_ write Set_type_;
    property WindowHandle: Integer read Get_WindowHandle write Set_WindowHandle;
    property Image: IPictureDisp read Get_Image write Set_Image;
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
    function    GetDefaultInterface: ITSelectionInfo;
    constructor Create(AServer: TTSelectionInfo);
  protected
    function Get_type_: Integer;
    procedure Set_type_(pVal: Integer);
    function Get_WindowHandle: Integer;
    procedure Set_WindowHandle(pVal: Integer);
    function Get_Points: OleVariant;
    procedure Set_Points(pVal: OleVariant);
    function Get_Image: IPictureDisp;
    procedure Set_Image(const pVal: IPictureDisp);
  public
    property DefaultInterface: ITSelectionInfo read GetDefaultInterface;
  published
    property type_: Integer read Get_type_ write Set_type_;
    property WindowHandle: Integer read Get_WindowHandle write Set_WindowHandle;
    property Image: IPictureDisp read Get_Image write Set_Image;
  end;
{$ENDIF}


// *********************************************************************//
// The Class CoTHighlightInfo provides a Create and CreateRemote method to          
// create instances of the default interface ITHighlightInfo exposed by              
// the CoClass THighlightInfo. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoTHighlightInfo = class
    class function Create: ITHighlightInfo;
    class function CreateRemote(const MachineName: string): ITHighlightInfo;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TTHighlightInfo
// Help String      : THighlightInfo
// Default Interface: ITHighlightInfo
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TTHighlightInfoProperties= class;
{$ENDIF}
  TTHighlightInfo = class(TOleServer)
  private
    FIntf: ITHighlightInfo;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps: TTHighlightInfoProperties;
    function GetServerProperties: TTHighlightInfoProperties;
{$ENDIF}
    function GetDefaultInterface: ITHighlightInfo;
  protected
    procedure InitServerData; override;
    function Get_hwnd: Integer;
    procedure Set_hwnd(pVal: Integer);
    function Get_Count: Integer;
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: ITHighlightInfo);
    procedure Disconnect; override;
    procedure Add(const text: WideString; left: Integer; top: Integer; right: Integer; 
                  bottom: Integer);
    procedure Remove(index: Integer);
    procedure Get(index: Integer; out text: WideString; out left: Integer; out top: Integer; 
                  out right: Integer; out bottom: Integer);
    procedure PerformHighlight(delay: Integer);
    procedure PerformHighlightFull(delay: Integer);
    property DefaultInterface: ITHighlightInfo read GetDefaultInterface;
    property Count: Integer read Get_Count;
    property hwnd: Integer read Get_hwnd write Set_hwnd;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TTHighlightInfoProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : TTHighlightInfo
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TTHighlightInfoProperties = class(TPersistent)
  private
    FServer:    TTHighlightInfo;
    function    GetDefaultInterface: ITHighlightInfo;
    constructor Create(AServer: TTHighlightInfo);
  protected
    function Get_hwnd: Integer;
    procedure Set_hwnd(pVal: Integer);
    function Get_Count: Integer;
  public
    property DefaultInterface: ITHighlightInfo read GetDefaultInterface;
  published
    property hwnd: Integer read Get_hwnd write Set_hwnd;
  end;
{$ENDIF}


procedure Register;

resourcestring
  dtlServerPage = '(none)';

  dtlOcxPage = '(none)';

implementation

uses ComObj;

class function CoTextCaptureX.Create: ITextCaptureX;
begin
  Result := CreateComObject(CLASS_TextCaptureX) as ITextCaptureX;
end;

class function CoTextCaptureX.CreateRemote(const MachineName: string): ITextCaptureX;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_TextCaptureX) as ITextCaptureX;
end;

procedure TTextCaptureX.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{13FE2FA1-EE8B-45B9-BBB4-08E5F2F43AC3}';
    IntfIID:   '{EEA5ABD9-2C89-4CDD-9C07-C3DDDF162A37}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure TTextCaptureX.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as ITextCaptureX;
  end;
end;

procedure TTextCaptureX.ConnectTo(svrIntf: ITextCaptureX);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure TTextCaptureX.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function TTextCaptureX.GetDefaultInterface: ITextCaptureX;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call "Connect" or "ConnectTo" before this operation');
  Result := FIntf;
end;

constructor TTextCaptureX.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TTextCaptureXProperties.Create(Self);
{$ENDIF}
end;

destructor TTextCaptureX.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function TTextCaptureX.GetServerProperties: TTextCaptureXProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function TTextCaptureX.GetTextFromPoint(hwnd: Integer; x: Integer; y: Integer): WideString;
begin
  Result := DefaultInterface.GetTextFromPoint(hwnd, x, y);
end;

function TTextCaptureX.GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                       height: Integer): WideString;
begin
  Result := DefaultInterface.GetTextFromRect(hwnd, left, top, width, height);
end;

function TTextCaptureX.CaptureInteractive(out hwnd: Integer; out left: Integer; out top: Integer; 
                                          out width: Integer; out height: Integer): Integer;
begin
  Result := DefaultInterface.CaptureInteractive(hwnd, left, top, width, height);
end;

function TTextCaptureX.CaptureActiveWindow: WideString;
begin
  Result := DefaultInterface.CaptureActiveWindow;
end;

function TTextCaptureX.GetActiveWindowHwnd: Integer;
begin
  Result := DefaultInterface.GetActiveWindowHwnd;
end;

function TTextCaptureX.CaptureInteractiveFreeHand(out hwnd: Integer; out arPoints: OleVariant): Integer;
begin
  Result := DefaultInterface.CaptureInteractiveFreeHand(hwnd, arPoints);
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TTextCaptureXProperties.Create(AServer: TTextCaptureX);
begin
  inherited Create;
  FServer := AServer;
end;

function TTextCaptureXProperties.GetDefaultInterface: ITextCaptureX;
begin
  Result := FServer.DefaultInterface;
end;

{$ENDIF}

class function CoGetAAText.Create: IGetAAText;
begin
  Result := CreateComObject(CLASS_GetAAText) as IGetAAText;
end;

class function CoGetAAText.CreateRemote(const MachineName: string): IGetAAText;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_GetAAText) as IGetAAText;
end;

procedure TGetAAText.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{924699E8-66EF-4EB9-AB6E-3CA9660B31EC}';
    IntfIID:   '{4652E117-CDF0-4B10-B3C9-4FE74FD0FA5B}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure TGetAAText.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as IGetAAText;
  end;
end;

procedure TGetAAText.ConnectTo(svrIntf: IGetAAText);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure TGetAAText.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function TGetAAText.GetDefaultInterface: IGetAAText;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call "Connect" or "ConnectTo" before this operation');
  Result := FIntf;
end;

constructor TGetAAText.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TGetAATextProperties.Create(Self);
{$ENDIF}
end;

destructor TGetAAText.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function TGetAAText.GetServerProperties: TGetAATextProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function TGetAAText.GetFullTextAA(hwnd: Integer): WideString;
begin
  Result := DefaultInterface.GetFullTextAA(hwnd);
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TGetAATextProperties.Create(AServer: TGetAAText);
begin
  inherited Create;
  FServer := AServer;
end;

function TGetAATextProperties.GetDefaultInterface: IGetAAText;
begin
  Result := FServer.DefaultInterface;
end;

{$ENDIF}

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
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call "Connect" or "ConnectTo" before this operation');
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

procedure TTSelection.Start(selection_type: Integer; options: Integer; 
                            out selection_result: ITSelectionInfo; out result: Integer);
begin
  DefaultInterface.Start(selection_type, options, selection_result, result);
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

class function CoTSelectionInfo.Create: ITSelectionInfo;
begin
  Result := CreateComObject(CLASS_TSelectionInfo) as ITSelectionInfo;
end;

class function CoTSelectionInfo.CreateRemote(const MachineName: string): ITSelectionInfo;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_TSelectionInfo) as ITSelectionInfo;
end;

procedure TTSelectionInfo.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{AD58B105-E00C-4F3F-81A5-54F741853E5C}';
    IntfIID:   '{12E679EC-86BF-4AA2-AA94-1B8D16E30EAF}';
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
    Fintf:= punk as ITSelectionInfo;
  end;
end;

procedure TTSelectionInfo.ConnectTo(svrIntf: ITSelectionInfo);
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

function TTSelectionInfo.GetDefaultInterface: ITSelectionInfo;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call "Connect" or "ConnectTo" before this operation');
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

function TTSelectionInfo.Get_type_: Integer;
begin
    Result := DefaultInterface.type_;
end;

procedure TTSelectionInfo.Set_type_(pVal: Integer);
begin
  DefaultInterface.Set_type_(pVal);
end;

function TTSelectionInfo.Get_WindowHandle: Integer;
begin
    Result := DefaultInterface.WindowHandle;
end;

procedure TTSelectionInfo.Set_WindowHandle(pVal: Integer);
begin
  DefaultInterface.Set_WindowHandle(pVal);
end;

function TTSelectionInfo.Get_Points: OleVariant;
var
  InterfaceVariant : OleVariant;
begin
  InterfaceVariant := DefaultInterface;
  Result := InterfaceVariant.Points;
end;

procedure TTSelectionInfo.Set_Points(pVal: OleVariant);
begin
  DefaultInterface.Set_Points(pVal);
end;

function TTSelectionInfo.Get_Image: IPictureDisp;
begin
    Result := DefaultInterface.Image;
end;

procedure TTSelectionInfo.Set_Image(const pVal: IPictureDisp);
begin
  DefaultInterface.Set_Image(pVal);
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TTSelectionInfoProperties.Create(AServer: TTSelectionInfo);
begin
  inherited Create;
  FServer := AServer;
end;

function TTSelectionInfoProperties.GetDefaultInterface: ITSelectionInfo;
begin
  Result := FServer.DefaultInterface;
end;

function TTSelectionInfoProperties.Get_type_: Integer;
begin
    Result := DefaultInterface.type_;
end;

procedure TTSelectionInfoProperties.Set_type_(pVal: Integer);
begin
  DefaultInterface.Set_type_(pVal);
end;

function TTSelectionInfoProperties.Get_WindowHandle: Integer;
begin
    Result := DefaultInterface.WindowHandle;
end;

procedure TTSelectionInfoProperties.Set_WindowHandle(pVal: Integer);
begin
  DefaultInterface.Set_WindowHandle(pVal);
end;

function TTSelectionInfoProperties.Get_Points: OleVariant;
var
  InterfaceVariant : OleVariant;
begin
  InterfaceVariant := DefaultInterface;
  Result := InterfaceVariant.Points;
end;

procedure TTSelectionInfoProperties.Set_Points(pVal: OleVariant);
begin
  DefaultInterface.Set_Points(pVal);
end;

function TTSelectionInfoProperties.Get_Image: IPictureDisp;
begin
    Result := DefaultInterface.Image;
end;

procedure TTSelectionInfoProperties.Set_Image(const pVal: IPictureDisp);
begin
  DefaultInterface.Set_Image(pVal);
end;

{$ENDIF}

class function CoTHighlightInfo.Create: ITHighlightInfo;
begin
  Result := CreateComObject(CLASS_THighlightInfo) as ITHighlightInfo;
end;

class function CoTHighlightInfo.CreateRemote(const MachineName: string): ITHighlightInfo;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_THighlightInfo) as ITHighlightInfo;
end;

procedure TTHighlightInfo.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{B13501DF-12B3-4A6A-9A5B-8FA1EBCF8699}';
    IntfIID:   '{FF7B48D0-4615-49FA-970B-56A95EDA143A}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure TTHighlightInfo.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as ITHighlightInfo;
  end;
end;

procedure TTHighlightInfo.ConnectTo(svrIntf: ITHighlightInfo);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure TTHighlightInfo.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function TTHighlightInfo.GetDefaultInterface: ITHighlightInfo;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call "Connect" or "ConnectTo" before this operation');
  Result := FIntf;
end;

constructor TTHighlightInfo.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TTHighlightInfoProperties.Create(Self);
{$ENDIF}
end;

destructor TTHighlightInfo.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function TTHighlightInfo.GetServerProperties: TTHighlightInfoProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function TTHighlightInfo.Get_hwnd: Integer;
begin
    Result := DefaultInterface.hwnd;
end;

procedure TTHighlightInfo.Set_hwnd(pVal: Integer);
begin
  DefaultInterface.Set_hwnd(pVal);
end;

function TTHighlightInfo.Get_Count: Integer;
begin
    Result := DefaultInterface.Count;
end;

procedure TTHighlightInfo.Add(const text: WideString; left: Integer; top: Integer; right: Integer; 
                              bottom: Integer);
begin
  DefaultInterface.Add(text, left, top, right, bottom);
end;

procedure TTHighlightInfo.Remove(index: Integer);
begin
  DefaultInterface.Remove(index);
end;

procedure TTHighlightInfo.Get(index: Integer; out text: WideString; out left: Integer; 
                              out top: Integer; out right: Integer; out bottom: Integer);
begin
  DefaultInterface.Get(index, text, left, top, right, bottom);
end;

procedure TTHighlightInfo.PerformHighlight(delay: Integer);
begin
  DefaultInterface.PerformHighlight(delay);
end;

procedure TTHighlightInfo.PerformHighlightFull(delay: Integer);
begin
  DefaultInterface.PerformHighlightFull(delay);
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TTHighlightInfoProperties.Create(AServer: TTHighlightInfo);
begin
  inherited Create;
  FServer := AServer;
end;

function TTHighlightInfoProperties.GetDefaultInterface: ITHighlightInfo;
begin
  Result := FServer.DefaultInterface;
end;

function TTHighlightInfoProperties.Get_hwnd: Integer;
begin
    Result := DefaultInterface.hwnd;
end;

procedure TTHighlightInfoProperties.Set_hwnd(pVal: Integer);
begin
  DefaultInterface.Set_hwnd(pVal);
end;

function TTHighlightInfoProperties.Get_Count: Integer;
begin
    Result := DefaultInterface.Count;
end;

{$ENDIF}

procedure Register;
begin
  RegisterComponents(dtlServerPage, [TTextCaptureX, TGetAAText, TTSelection, TTSelectionInfo, 
    TTHighlightInfo]);
end;

end.
