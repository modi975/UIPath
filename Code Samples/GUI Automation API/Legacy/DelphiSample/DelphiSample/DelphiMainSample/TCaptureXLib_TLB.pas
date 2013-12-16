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

// PASTLWTR : 1.2
// File generated on 11/3/2011 9:34:14 PM from Type Library described below.

// ************************************************************************  //
// Type Lib: C:\PROGRA~1\DESKPE~1\SCREEN~1\TCAPTU~1.DLL (1)
// LIBID: {92657C70-D31B-4930-9014-379E3F6FB91A}
// LCID: 0
// Helpfile: 
// HelpString: TCaptureX 1.0 Type Library
// DepndLst: 
//   (1) v2.0 stdole, (C:\WINDOWS\system32\stdole2.tlb)
// Errors:
//   Error creating palette bitmap of (TTextCaptureX) : Server C:\Program Files\Deskperience\ScreenScraper Studio\TCaptureX.dll contains no icons
//   Error creating palette bitmap of (TGetAAText) : Server C:\Program Files\Deskperience\ScreenScraper Studio\TCaptureX.dll contains no icons
//   Error creating palette bitmap of (TGetOCRText) : Server C:\Program Files\Deskperience\ScreenScraper Studio\TCaptureX.dll contains no icons
//   Error creating palette bitmap of (TTHighlightInfo) : Server C:\Program Files\Deskperience\ScreenScraper Studio\TCaptureX.dll contains no icons
//   Error creating palette bitmap of (Trect) : Server C:\Program Files\Deskperience\ScreenScraper Studio\TCaptureX.dll contains no icons
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
  TCaptureXLibMinorVersion = 0;

  LIBID_TCaptureXLib: TGUID = '{92657C70-D31B-4930-9014-379E3F6FB91A}';

  IID_ITextCaptureX: TGUID = '{EEA5ABD9-2C89-4CDD-9C07-C3DDDF162A37}';
  IID_ITextCaptureX2: TGUID = '{E2500574-7215-4028-A567-3A7D77A4B2B1}';
  IID_ITextCaptureX3: TGUID = '{C9D57541-BAD7-46B4-82D8-2041546133BF}';
  IID_ITextCaptureX4: TGUID = '{ACFD5F3E-946F-4A6A-8B76-450F94120D4C}';
  IID_ITextCaptureX5: TGUID = '{D460C8E0-B0EA-4F9B-8E2E-5042A191FA79}';
  IID_ITextCaptureX6: TGUID = '{419BE681-BCA8-49D0-9BAD-8A088B1C043B}';
  IID_ITextCaptureX7: TGUID = '{88CCC373-72B2-4AFD-AD2A-8C39956ECBFE}';
  IID_ITextCaptureX8: TGUID = '{181482EE-078A-420E-9B70-605029542C92}';
  IID_ITextCaptureX9: TGUID = '{55826D98-97B3-4614-88E1-8F6C66C90C60}';
  IID_IRect: TGUID = '{0E4BE2A0-AD3A-4237-9406-CEB504EFE361}';
  IID_ITextCaptureX10: TGUID = '{2F31D2C1-884C-4A65-BF7E-C0F362795C25}';
  IID_ITextCaptureX11: TGUID = '{80F2E9CE-A674-4831-8FE8-BF17270B6A7C}';
  IID_ITextCaptureX12: TGUID = '{9647861E-6BC5-4906-9B22-807CA2A7302B}';
  IID_ITextCaptureX13: TGUID = '{010EF7AF-96F2-4F5A-9DFB-D81FB259CF12}';
  IID_ITextCaptureX14: TGUID = '{F7ACFE99-3CC9-40DA-85D1-42D882CAE986}';
  IID_ITHighlightInfo: TGUID = '{FF7B48D0-4615-49FA-970B-56A95EDA143A}';
  IID_ITHighlightInfo2: TGUID = '{6B558D32-93F8-41E6-AD6E-79E64D58AC45}';
  IID_ITextCaptureX15: TGUID = '{F087CCAF-0108-455B-A8F0-CCC05C0CE457}';
  CLASS_TextCaptureX: TGUID = '{13FE2FA1-EE8B-45B9-BBB4-08E5F2F43AC3}';
  IID_IGetAAText: TGUID = '{4652E117-CDF0-4B10-B3C9-4FE74FD0FA5B}';
  IID_IGetAAText2: TGUID = '{71EA4E83-A80C-435B-8B77-76D2E45D02A6}';
  IID_IGetAAText3: TGUID = '{39B4B3E6-4C2B-4574-B9C7-088AF5FAF8A3}';
  IID_IGetAAText4: TGUID = '{1FA317DF-A401-490A-A35E-160521FF62B1}';
  IID_IGetAAText5: TGUID = '{2B5BB8EC-4219-42AE-A486-79D517753198}';
  CLASS_GetAAText: TGUID = '{924699E8-66EF-4EB9-AB6E-3CA9660B31EC}';
  IID_IGetOCRText: TGUID = '{0A293C91-E546-4025-86D0-57A7875EA634}';
  IID_IGetOCRText2: TGUID = '{E5E40C21-EFE8-45AC-AC04-A415924B36CD}';
  IID_IGetOCRText3: TGUID = '{1C943625-61D2-4258-8632-9C65EBB0B9EC}';
  IID_IGetOCRText4: TGUID = '{C3F9D942-688D-40FD-BA4C-F69D077A03AF}';
  IID_IGetOCRText5: TGUID = '{0E32FA09-68CA-430B-B444-B0589C5EBF5D}';
  IID_IGetOCRText6: TGUID = '{C0AD18D0-676F-44DD-9728-6822CE39AB6F}';
  IID_IGetOCRText7: TGUID = '{09C4FAF6-B846-4185-850D-27B8501EE752}';
  CLASS_GetOCRText: TGUID = '{F827ADF4-AC12-4FAA-8073-4558C0489283}';
  CLASS_THighlightInfo: TGUID = '{B13501DF-12B3-4A6A-9A5B-8FA1EBCF8699}';
  CLASS_rect: TGUID = '{FB9DE2D6-DDAF-47B3-BCF0-31D17E8D34C5}';
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
  ITextCaptureX8 = interface;
  ITextCaptureX8Disp = dispinterface;
  ITextCaptureX9 = interface;
  ITextCaptureX9Disp = dispinterface;
  IRect = interface;
  IRectDisp = dispinterface;
  ITextCaptureX10 = interface;
  ITextCaptureX10Disp = dispinterface;
  ITextCaptureX11 = interface;
  ITextCaptureX11Disp = dispinterface;
  ITextCaptureX12 = interface;
  ITextCaptureX12Disp = dispinterface;
  ITextCaptureX13 = interface;
  ITextCaptureX13Disp = dispinterface;
  ITextCaptureX14 = interface;
  ITextCaptureX14Disp = dispinterface;
  ITHighlightInfo = interface;
  ITHighlightInfoDisp = dispinterface;
  ITHighlightInfo2 = interface;
  ITHighlightInfo2Disp = dispinterface;
  ITextCaptureX15 = interface;
  ITextCaptureX15Disp = dispinterface;
  IGetAAText = interface;
  IGetAATextDisp = dispinterface;
  IGetAAText2 = interface;
  IGetAAText2Disp = dispinterface;
  IGetAAText3 = interface;
  IGetAAText3Disp = dispinterface;
  IGetAAText4 = interface;
  IGetAAText4Disp = dispinterface;
  IGetAAText5 = interface;
  IGetAAText5Disp = dispinterface;
  IGetOCRText = interface;
  IGetOCRTextDisp = dispinterface;
  IGetOCRText2 = interface;
  IGetOCRText2Disp = dispinterface;
  IGetOCRText3 = interface;
  IGetOCRText3Disp = dispinterface;
  IGetOCRText4 = interface;
  IGetOCRText4Disp = dispinterface;
  IGetOCRText5 = interface;
  IGetOCRText5Disp = dispinterface;
  IGetOCRText6 = interface;
  IGetOCRText6Disp = dispinterface;
  IGetOCRText7 = interface;
  IGetOCRText7Disp = dispinterface;

// *********************************************************************//
// Declaration of CoClasses defined in Type Library                       
// (NOTE: Here we map each CoClass to its Default Interface)              
// *********************************************************************//
  TextCaptureX = ITextCaptureX15;
  GetAAText = IGetAAText5;
  GetOCRText = IGetOCRText7;
  THighlightInfo = ITHighlightInfo2;
  rect = IRect;


// *********************************************************************//
// Declaration of structures, unions and aliases.                         
// *********************************************************************//
  PInteger1 = ^Integer; {*}


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
// Interface: ITextCaptureX8
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {181482EE-078A-420E-9B70-605029542C92}
// *********************************************************************//
  ITextCaptureX8 = interface(ITextCaptureX7)
    ['{181482EE-078A-420E-9B70-605029542C92}']
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX8Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {181482EE-078A-420E-9B70-605029542C92}
// *********************************************************************//
  ITextCaptureX8Disp = dispinterface
    ['{181482EE-078A-420E-9B70-605029542C92}']
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; dispid 26;
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
// Interface: ITextCaptureX9
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {55826D98-97B3-4614-88E1-8F6C66C90C60}
// *********************************************************************//
  ITextCaptureX9 = interface(ITextCaptureX8)
    ['{55826D98-97B3-4614-88E1-8F6C66C90C60}']
    function CaptureControl(hwnd: Integer; const class_name: WideString; const aa_name: WideString; 
                            aa_role: Integer): WideString; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX9Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {55826D98-97B3-4614-88E1-8F6C66C90C60}
// *********************************************************************//
  ITextCaptureX9Disp = dispinterface
    ['{55826D98-97B3-4614-88E1-8F6C66C90C60}']
    function CaptureControl(hwnd: Integer; const class_name: WideString; const aa_name: WideString; 
                            aa_role: Integer): WideString; dispid 27;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; dispid 26;
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
// Interface: IRect
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {0E4BE2A0-AD3A-4237-9406-CEB504EFE361}
// *********************************************************************//
  IRect = interface(IDispatch)
    ['{0E4BE2A0-AD3A-4237-9406-CEB504EFE361}']
    function Get_RLeft: Integer; safecall;
    procedure Set_RLeft(pVal: Integer); safecall;
    function Get_RTop: Integer; safecall;
    procedure Set_RTop(pVal: Integer); safecall;
    function Get_RRight: Integer; safecall;
    procedure Set_RRight(pVal: Integer); safecall;
    function Get_RBottom: Integer; safecall;
    procedure Set_RBottom(pVal: Integer); safecall;
    function width: Integer; safecall;
    function height: Integer; safecall;
    property RLeft: Integer read Get_RLeft write Set_RLeft;
    property RTop: Integer read Get_RTop write Set_RTop;
    property RRight: Integer read Get_RRight write Set_RRight;
    property RBottom: Integer read Get_RBottom write Set_RBottom;
  end;

// *********************************************************************//
// DispIntf:  IRectDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {0E4BE2A0-AD3A-4237-9406-CEB504EFE361}
// *********************************************************************//
  IRectDisp = dispinterface
    ['{0E4BE2A0-AD3A-4237-9406-CEB504EFE361}']
    property RLeft: Integer dispid 1;
    property RTop: Integer dispid 2;
    property RRight: Integer dispid 3;
    property RBottom: Integer dispid 4;
    function width: Integer; dispid 5;
    function height: Integer; dispid 6;
  end;

// *********************************************************************//
// Interface: ITextCaptureX10
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {2F31D2C1-884C-4A65-BF7E-C0F362795C25}
// *********************************************************************//
  ITextCaptureX10 = interface(ITextCaptureX9)
    ['{2F31D2C1-884C-4A65-BF7E-C0F362795C25}']
    function CheckStopEvent: WordBool; safecall;
    procedure SignalStopEvent(bSignal: WordBool); safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX10Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {2F31D2C1-884C-4A65-BF7E-C0F362795C25}
// *********************************************************************//
  ITextCaptureX10Disp = dispinterface
    ['{2F31D2C1-884C-4A65-BF7E-C0F362795C25}']
    function CheckStopEvent: WordBool; dispid 29;
    procedure SignalStopEvent(bSignal: WordBool); dispid 30;
    function CaptureControl(hwnd: Integer; const class_name: WideString; const aa_name: WideString; 
                            aa_role: Integer): WideString; dispid 27;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; dispid 26;
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
// Interface: ITextCaptureX11
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {80F2E9CE-A674-4831-8FE8-BF17270B6A7C}
// *********************************************************************//
  ITextCaptureX11 = interface(ITextCaptureX10)
    ['{80F2E9CE-A674-4831-8FE8-BF17270B6A7C}']
    function GetTextFromUIElem(const pUIElemDisp: IDispatch): WideString; safecall;
    function GetTextFromUIElemWithFont(const pUIElemDisp: IDispatch; out font: IFontDisp): WideString; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX11Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {80F2E9CE-A674-4831-8FE8-BF17270B6A7C}
// *********************************************************************//
  ITextCaptureX11Disp = dispinterface
    ['{80F2E9CE-A674-4831-8FE8-BF17270B6A7C}']
    function GetTextFromUIElem(const pUIElemDisp: IDispatch): WideString; dispid 31;
    function GetTextFromUIElemWithFont(const pUIElemDisp: IDispatch; out font: IFontDisp): WideString; dispid 32;
    function CheckStopEvent: WordBool; dispid 29;
    procedure SignalStopEvent(bSignal: WordBool); dispid 30;
    function CaptureControl(hwnd: Integer; const class_name: WideString; const aa_name: WideString; 
                            aa_role: Integer): WideString; dispid 27;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; dispid 26;
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
// Interface: ITextCaptureX12
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {9647861E-6BC5-4906-9B22-807CA2A7302B}
// *********************************************************************//
  ITextCaptureX12 = interface(ITextCaptureX11)
    ['{9647861E-6BC5-4906-9B22-807CA2A7302B}']
    procedure SetClipboardText(const text: WideString); safecall;
    function GetClipboardText: WideString; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX12Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {9647861E-6BC5-4906-9B22-807CA2A7302B}
// *********************************************************************//
  ITextCaptureX12Disp = dispinterface
    ['{9647861E-6BC5-4906-9B22-807CA2A7302B}']
    procedure SetClipboardText(const text: WideString); dispid 33;
    function GetClipboardText: WideString; dispid 34;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch): WideString; dispid 31;
    function GetTextFromUIElemWithFont(const pUIElemDisp: IDispatch; out font: IFontDisp): WideString; dispid 32;
    function CheckStopEvent: WordBool; dispid 29;
    procedure SignalStopEvent(bSignal: WordBool); dispid 30;
    function CaptureControl(hwnd: Integer; const class_name: WideString; const aa_name: WideString; 
                            aa_role: Integer): WideString; dispid 27;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; dispid 26;
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
// Interface: ITextCaptureX13
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {010EF7AF-96F2-4F5A-9DFB-D81FB259CF12}
// *********************************************************************//
  ITextCaptureX13 = interface(ITextCaptureX12)
    ['{010EF7AF-96F2-4F5A-9DFB-D81FB259CF12}']
    function GetActiveWindowHwnd3(hwnd: Integer; bAll: WordBool): Integer; safecall;
    function Get_HighlightInfo: ITHighlightInfo2; safecall;
    procedure Set_HighlightInfo(const pVal: ITHighlightInfo2); safecall;
    function Get_ExtractHighlightInfo: WordBool; safecall;
    procedure Set_ExtractHighlightInfo(pVal: WordBool); safecall;
    property HighlightInfo: ITHighlightInfo2 read Get_HighlightInfo write Set_HighlightInfo;
    property ExtractHighlightInfo: WordBool read Get_ExtractHighlightInfo write Set_ExtractHighlightInfo;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX13Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {010EF7AF-96F2-4F5A-9DFB-D81FB259CF12}
// *********************************************************************//
  ITextCaptureX13Disp = dispinterface
    ['{010EF7AF-96F2-4F5A-9DFB-D81FB259CF12}']
    function GetActiveWindowHwnd3(hwnd: Integer; bAll: WordBool): Integer; dispid 35;
    property HighlightInfo: ITHighlightInfo2 dispid 36;
    property ExtractHighlightInfo: WordBool dispid 37;
    procedure SetClipboardText(const text: WideString); dispid 33;
    function GetClipboardText: WideString; dispid 34;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch): WideString; dispid 31;
    function GetTextFromUIElemWithFont(const pUIElemDisp: IDispatch; out font: IFontDisp): WideString; dispid 32;
    function CheckStopEvent: WordBool; dispid 29;
    procedure SignalStopEvent(bSignal: WordBool); dispid 30;
    function CaptureControl(hwnd: Integer; const class_name: WideString; const aa_name: WideString; 
                            aa_role: Integer): WideString; dispid 27;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; dispid 26;
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
// Interface: ITextCaptureX14
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {F7ACFE99-3CC9-40DA-85D1-42D882CAE986}
// *********************************************************************//
  ITextCaptureX14 = interface(ITextCaptureX13)
    ['{F7ACFE99-3CC9-40DA-85D1-42D882CAE986}']
    function Get_NativeCaptureTimeoutSec: Integer; safecall;
    procedure Set_NativeCaptureTimeoutSec(pVal: Integer); safecall;
    property NativeCaptureTimeoutSec: Integer read Get_NativeCaptureTimeoutSec write Set_NativeCaptureTimeoutSec;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX14Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {F7ACFE99-3CC9-40DA-85D1-42D882CAE986}
// *********************************************************************//
  ITextCaptureX14Disp = dispinterface
    ['{F7ACFE99-3CC9-40DA-85D1-42D882CAE986}']
    property NativeCaptureTimeoutSec: Integer dispid 38;
    function GetActiveWindowHwnd3(hwnd: Integer; bAll: WordBool): Integer; dispid 35;
    property HighlightInfo: ITHighlightInfo2 dispid 36;
    property ExtractHighlightInfo: WordBool dispid 37;
    procedure SetClipboardText(const text: WideString); dispid 33;
    function GetClipboardText: WideString; dispid 34;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch): WideString; dispid 31;
    function GetTextFromUIElemWithFont(const pUIElemDisp: IDispatch; out font: IFontDisp): WideString; dispid 32;
    function CheckStopEvent: WordBool; dispid 29;
    procedure SignalStopEvent(bSignal: WordBool); dispid 30;
    function CaptureControl(hwnd: Integer; const class_name: WideString; const aa_name: WideString; 
                            aa_role: Integer): WideString; dispid 27;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; dispid 26;
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
// Interface: ITHighlightInfo2
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {6B558D32-93F8-41E6-AD6E-79E64D58AC45}
// *********************************************************************//
  ITHighlightInfo2 = interface(ITHighlightInfo)
    ['{6B558D32-93F8-41E6-AD6E-79E64D58AC45}']
    procedure GhostMethod_ITHighlightInfo2_0_1; safecall;
    procedure GhostMethod_ITHighlightInfo2_4_2; safecall;
    procedure GhostMethod_ITHighlightInfo2_8_3; safecall;
    procedure GhostMethod_ITHighlightInfo2_12_4; safecall;
    procedure GhostMethod_ITHighlightInfo2_16_5; safecall;
    procedure GhostMethod_ITHighlightInfo2_20_6; safecall;
    procedure GhostMethod_ITHighlightInfo2_24_7; safecall;
    procedure GhostMethod_ITHighlightInfo2_28_8; safecall;
    procedure GhostMethod_ITHighlightInfo2_32_9; safecall;
    procedure GhostMethod_ITHighlightInfo2_36_10; safecall;
    procedure GhostMethod_ITHighlightInfo2_40_11; safecall;
    procedure GhostMethod_ITHighlightInfo2_44_12; safecall;
    procedure GhostMethod_ITHighlightInfo2_48_13; safecall;
    procedure GhostMethod_ITHighlightInfo2_52_14; safecall;
    procedure GhostMethod_ITHighlightInfo2_56_15; safecall;
    procedure SerializeToBuffer(size: Integer; out buf: Integer); safecall;
    procedure DeserializeFromBuffer(var buf: Integer); safecall;
    function GetSerializedSize: Integer; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITHighlightInfo2Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {6B558D32-93F8-41E6-AD6E-79E64D58AC45}
// *********************************************************************//
  ITHighlightInfo2Disp = dispinterface
    ['{6B558D32-93F8-41E6-AD6E-79E64D58AC45}']
    procedure GhostMethod_ITHighlightInfo2_0_1; dispid 1610678272;
    procedure GhostMethod_ITHighlightInfo2_4_2; dispid 1610678273;
    procedure GhostMethod_ITHighlightInfo2_8_3; dispid 1610678274;
    procedure GhostMethod_ITHighlightInfo2_12_4; dispid 1610678275;
    procedure GhostMethod_ITHighlightInfo2_16_5; dispid 1610678276;
    procedure GhostMethod_ITHighlightInfo2_20_6; dispid 1610678277;
    procedure GhostMethod_ITHighlightInfo2_24_7; dispid 1610678278;
    procedure GhostMethod_ITHighlightInfo2_28_8; dispid 1610678279;
    procedure GhostMethod_ITHighlightInfo2_32_9; dispid 1610678280;
    procedure GhostMethod_ITHighlightInfo2_36_10; dispid 1610678281;
    procedure GhostMethod_ITHighlightInfo2_40_11; dispid 1610678282;
    procedure GhostMethod_ITHighlightInfo2_44_12; dispid 1610678283;
    procedure GhostMethod_ITHighlightInfo2_48_13; dispid 1610678284;
    procedure GhostMethod_ITHighlightInfo2_52_14; dispid 1610678285;
    procedure GhostMethod_ITHighlightInfo2_56_15; dispid 1610678286;
    procedure SerializeToBuffer(size: Integer; out buf: Integer); dispid 8;
    procedure DeserializeFromBuffer(var buf: Integer); dispid 9;
    function GetSerializedSize: Integer; dispid 10;
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
// Interface: ITextCaptureX15
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {F087CCAF-0108-455B-A8F0-CCC05C0CE457}
// *********************************************************************//
  ITextCaptureX15 = interface(ITextCaptureX14)
    ['{F087CCAF-0108-455B-A8F0-CCC05C0CE457}']
    function GetRectFromUIElemText(const pUIElemDisp: IDispatch; const bstrText: WideString; 
                                   nOccurence: Integer): IRect; safecall;
  end;

// *********************************************************************//
// DispIntf:  ITextCaptureX15Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {F087CCAF-0108-455B-A8F0-CCC05C0CE457}
// *********************************************************************//
  ITextCaptureX15Disp = dispinterface
    ['{F087CCAF-0108-455B-A8F0-CCC05C0CE457}']
    function GetRectFromUIElemText(const pUIElemDisp: IDispatch; const bstrText: WideString; 
                                   nOccurence: Integer): IRect; dispid 39;
    property NativeCaptureTimeoutSec: Integer dispid 38;
    function GetActiveWindowHwnd3(hwnd: Integer; bAll: WordBool): Integer; dispid 35;
    property HighlightInfo: ITHighlightInfo2 dispid 36;
    property ExtractHighlightInfo: WordBool dispid 37;
    procedure SetClipboardText(const text: WideString); dispid 33;
    function GetClipboardText: WideString; dispid 34;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch): WideString; dispid 31;
    function GetTextFromUIElemWithFont(const pUIElemDisp: IDispatch; out font: IFontDisp): WideString; dispid 32;
    function CheckStopEvent: WordBool; dispid 29;
    procedure SignalStopEvent(bSignal: WordBool); dispid 30;
    function CaptureControl(hwnd: Integer; const class_name: WideString; const aa_name: WideString; 
                            aa_role: Integer): WideString; dispid 27;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             occurence: Integer): IRect; dispid 26;
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
// Interface: IGetAAText3
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {39B4B3E6-4C2B-4574-B9C7-088AF5FAF8A3}
// *********************************************************************//
  IGetAAText3 = interface(IGetAAText2)
    ['{39B4B3E6-4C2B-4574-B9C7-088AF5FAF8A3}']
    function GetFullTextFromRectangle(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer): WideString; safecall;
    function Get_UseClientCoordinates: WordBool; safecall;
    procedure Set_UseClientCoordinates(pVal: WordBool); safecall;
    property UseClientCoordinates: WordBool read Get_UseClientCoordinates write Set_UseClientCoordinates;
  end;

// *********************************************************************//
// DispIntf:  IGetAAText3Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {39B4B3E6-4C2B-4574-B9C7-088AF5FAF8A3}
// *********************************************************************//
  IGetAAText3Disp = dispinterface
    ['{39B4B3E6-4C2B-4574-B9C7-088AF5FAF8A3}']
    function GetFullTextFromRectangle(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer): WideString; dispid 4;
    property UseClientCoordinates: WordBool dispid 5;
    property HighlightInfo: ITHighlightInfo dispid 2;
    property ExtractHighlightInfo: WordBool dispid 3;
    function GetFullTextAA(hwnd: Integer): WideString; dispid 1;
  end;

// *********************************************************************//
// Interface: IGetAAText4
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {1FA317DF-A401-490A-A35E-160521FF62B1}
// *********************************************************************//
  IGetAAText4 = interface(IGetAAText3)
    ['{1FA317DF-A401-490A-A35E-160521FF62B1}']
    function GetFullTextFromUIElem(const pUIElemDisp: IDispatch): WideString; safecall;
  end;

// *********************************************************************//
// DispIntf:  IGetAAText4Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {1FA317DF-A401-490A-A35E-160521FF62B1}
// *********************************************************************//
  IGetAAText4Disp = dispinterface
    ['{1FA317DF-A401-490A-A35E-160521FF62B1}']
    function GetFullTextFromUIElem(const pUIElemDisp: IDispatch): WideString; dispid 6;
    function GetFullTextFromRectangle(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer): WideString; dispid 4;
    property UseClientCoordinates: WordBool dispid 5;
    property HighlightInfo: ITHighlightInfo dispid 2;
    property ExtractHighlightInfo: WordBool dispid 3;
    function GetFullTextAA(hwnd: Integer): WideString; dispid 1;
  end;

// *********************************************************************//
// Interface: IGetAAText5
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {2B5BB8EC-4219-42AE-A486-79D517753198}
// *********************************************************************//
  IGetAAText5 = interface(IGetAAText4)
    ['{2B5BB8EC-4219-42AE-A486-79D517753198}']
    function Get_IgnoreHidden: WordBool; safecall;
    procedure Set_IgnoreHidden(pVal: WordBool); safecall;
    property IgnoreHidden: WordBool read Get_IgnoreHidden write Set_IgnoreHidden;
  end;

// *********************************************************************//
// DispIntf:  IGetAAText5Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {2B5BB8EC-4219-42AE-A486-79D517753198}
// *********************************************************************//
  IGetAAText5Disp = dispinterface
    ['{2B5BB8EC-4219-42AE-A486-79D517753198}']
    property IgnoreHidden: WordBool dispid 7;
    function GetFullTextFromUIElem(const pUIElemDisp: IDispatch): WideString; dispid 6;
    function GetFullTextFromRectangle(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer): WideString; dispid 4;
    property UseClientCoordinates: WordBool dispid 5;
    property HighlightInfo: ITHighlightInfo dispid 2;
    property ExtractHighlightInfo: WordBool dispid 3;
    function GetFullTextAA(hwnd: Integer): WideString; dispid 1;
  end;

// *********************************************************************//
// Interface: IGetOCRText
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {0A293C91-E546-4025-86D0-57A7875EA634}
// *********************************************************************//
  IGetOCRText = interface(IDispatch)
    ['{0A293C91-E546-4025-86D0-57A7875EA634}']
    function IsMODIAvailable: WordBool; safecall;
    function GetTextFromRectUsingMODI(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer; const language: WideString): WideString; safecall;
  end;

// *********************************************************************//
// DispIntf:  IGetOCRTextDisp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {0A293C91-E546-4025-86D0-57A7875EA634}
// *********************************************************************//
  IGetOCRTextDisp = dispinterface
    ['{0A293C91-E546-4025-86D0-57A7875EA634}']
    function IsMODIAvailable: WordBool; dispid 1;
    function GetTextFromRectUsingMODI(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer; const language: WideString): WideString; dispid 2;
  end;

// *********************************************************************//
// Interface: IGetOCRText2
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {E5E40C21-EFE8-45AC-AC04-A415924B36CD}
// *********************************************************************//
  IGetOCRText2 = interface(IGetOCRText)
    ['{E5E40C21-EFE8-45AC-AC04-A415924B36CD}']
    function GetRectFromTextUsingMODI(hwnd: Integer; const text: WideString; 
                                      const target_rect: IRect; const bstrLanguage: WideString; 
                                      occurence: Integer): IRect; safecall;
  end;

// *********************************************************************//
// DispIntf:  IGetOCRText2Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {E5E40C21-EFE8-45AC-AC04-A415924B36CD}
// *********************************************************************//
  IGetOCRText2Disp = dispinterface
    ['{E5E40C21-EFE8-45AC-AC04-A415924B36CD}']
    function GetRectFromTextUsingMODI(hwnd: Integer; const text: WideString; 
                                      const target_rect: IRect; const bstrLanguage: WideString; 
                                      occurence: Integer): IRect; dispid 3;
    function IsMODIAvailable: WordBool; dispid 1;
    function GetTextFromRectUsingMODI(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer; const language: WideString): WideString; dispid 2;
  end;

// *********************************************************************//
// Interface: IGetOCRText3
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {1C943625-61D2-4258-8632-9C65EBB0B9EC}
// *********************************************************************//
  IGetOCRText3 = interface(IGetOCRText2)
    ['{1C943625-61D2-4258-8632-9C65EBB0B9EC}']
    function GetTextFromUIElemUsingMODI(const pUIElemDisp: IDispatch; const language: WideString): WideString; safecall;
  end;

// *********************************************************************//
// DispIntf:  IGetOCRText3Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {1C943625-61D2-4258-8632-9C65EBB0B9EC}
// *********************************************************************//
  IGetOCRText3Disp = dispinterface
    ['{1C943625-61D2-4258-8632-9C65EBB0B9EC}']
    function GetTextFromUIElemUsingMODI(const pUIElemDisp: IDispatch; const language: WideString): WideString; dispid 4;
    function GetRectFromTextUsingMODI(hwnd: Integer; const text: WideString; 
                                      const target_rect: IRect; const bstrLanguage: WideString; 
                                      occurence: Integer): IRect; dispid 3;
    function IsMODIAvailable: WordBool; dispid 1;
    function GetTextFromRectUsingMODI(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer; const language: WideString): WideString; dispid 2;
  end;

// *********************************************************************//
// Interface: IGetOCRText4
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {C3F9D942-688D-40FD-BA4C-F69D077A03AF}
// *********************************************************************//
  IGetOCRText4 = interface(IGetOCRText3)
    ['{C3F9D942-688D-40FD-BA4C-F69D077A03AF}']
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer; const language: WideString; invert: WordBool): WideString; safecall;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch; const language: WideString; 
                               invert: WordBool): WideString; safecall;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             const bstrLanguage: WideString; invert: WordBool; occurence: Integer): IRect; safecall;
    function IsTesseractAvailable: WordBool; safecall;
  end;

// *********************************************************************//
// DispIntf:  IGetOCRText4Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {C3F9D942-688D-40FD-BA4C-F69D077A03AF}
// *********************************************************************//
  IGetOCRText4Disp = dispinterface
    ['{C3F9D942-688D-40FD-BA4C-F69D077A03AF}']
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer; const language: WideString; invert: WordBool): WideString; dispid 5;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch; const language: WideString; 
                               invert: WordBool): WideString; dispid 6;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             const bstrLanguage: WideString; invert: WordBool; occurence: Integer): IRect; dispid 7;
    function IsTesseractAvailable: WordBool; dispid 8;
    function GetTextFromUIElemUsingMODI(const pUIElemDisp: IDispatch; const language: WideString): WideString; dispid 4;
    function GetRectFromTextUsingMODI(hwnd: Integer; const text: WideString; 
                                      const target_rect: IRect; const bstrLanguage: WideString; 
                                      occurence: Integer): IRect; dispid 3;
    function IsMODIAvailable: WordBool; dispid 1;
    function GetTextFromRectUsingMODI(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer; const language: WideString): WideString; dispid 2;
  end;

// *********************************************************************//
// Interface: IGetOCRText5
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {0E32FA09-68CA-430B-B444-B0589C5EBF5D}
// *********************************************************************//
  IGetOCRText5 = interface(IGetOCRText4)
    ['{0E32FA09-68CA-430B-B444-B0589C5EBF5D}']
    function Get_UseClientCoordinates: WordBool; safecall;
    procedure Set_UseClientCoordinates(pVal: WordBool); safecall;
    function Get_HighlightInfo: ITHighlightInfo; safecall;
    procedure Set_HighlightInfo(const pVal: ITHighlightInfo); safecall;
    function Get_ExtractHighlightInfo: WordBool; safecall;
    procedure Set_ExtractHighlightInfo(pVal: WordBool); safecall;
    property UseClientCoordinates: WordBool read Get_UseClientCoordinates write Set_UseClientCoordinates;
    property HighlightInfo: ITHighlightInfo read Get_HighlightInfo write Set_HighlightInfo;
    property ExtractHighlightInfo: WordBool read Get_ExtractHighlightInfo write Set_ExtractHighlightInfo;
  end;

// *********************************************************************//
// DispIntf:  IGetOCRText5Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {0E32FA09-68CA-430B-B444-B0589C5EBF5D}
// *********************************************************************//
  IGetOCRText5Disp = dispinterface
    ['{0E32FA09-68CA-430B-B444-B0589C5EBF5D}']
    property UseClientCoordinates: WordBool dispid 9;
    property HighlightInfo: ITHighlightInfo dispid 10;
    property ExtractHighlightInfo: WordBool dispid 11;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer; const language: WideString; invert: WordBool): WideString; dispid 5;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch; const language: WideString; 
                               invert: WordBool): WideString; dispid 6;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             const bstrLanguage: WideString; invert: WordBool; occurence: Integer): IRect; dispid 7;
    function IsTesseractAvailable: WordBool; dispid 8;
    function GetTextFromUIElemUsingMODI(const pUIElemDisp: IDispatch; const language: WideString): WideString; dispid 4;
    function GetRectFromTextUsingMODI(hwnd: Integer; const text: WideString; 
                                      const target_rect: IRect; const bstrLanguage: WideString; 
                                      occurence: Integer): IRect; dispid 3;
    function IsMODIAvailable: WordBool; dispid 1;
    function GetTextFromRectUsingMODI(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer; const language: WideString): WideString; dispid 2;
  end;

// *********************************************************************//
// Interface: IGetOCRText6
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {C0AD18D0-676F-44DD-9728-6822CE39AB6F}
// *********************************************************************//
  IGetOCRText6 = interface(IGetOCRText5)
    ['{C0AD18D0-676F-44DD-9728-6822CE39AB6F}']
    function Get_OCRCorrection: WordBool; safecall;
    procedure Set_OCRCorrection(pVal: WordBool); safecall;
    property OCRCorrection: WordBool read Get_OCRCorrection write Set_OCRCorrection;
  end;

// *********************************************************************//
// DispIntf:  IGetOCRText6Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {C0AD18D0-676F-44DD-9728-6822CE39AB6F}
// *********************************************************************//
  IGetOCRText6Disp = dispinterface
    ['{C0AD18D0-676F-44DD-9728-6822CE39AB6F}']
    property OCRCorrection: WordBool dispid 12;
    property UseClientCoordinates: WordBool dispid 9;
    property HighlightInfo: ITHighlightInfo dispid 10;
    property ExtractHighlightInfo: WordBool dispid 11;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer; const language: WideString; invert: WordBool): WideString; dispid 5;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch; const language: WideString; 
                               invert: WordBool): WideString; dispid 6;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             const bstrLanguage: WideString; invert: WordBool; occurence: Integer): IRect; dispid 7;
    function IsTesseractAvailable: WordBool; dispid 8;
    function GetTextFromUIElemUsingMODI(const pUIElemDisp: IDispatch; const language: WideString): WideString; dispid 4;
    function GetRectFromTextUsingMODI(hwnd: Integer; const text: WideString; 
                                      const target_rect: IRect; const bstrLanguage: WideString; 
                                      occurence: Integer): IRect; dispid 3;
    function IsMODIAvailable: WordBool; dispid 1;
    function GetTextFromRectUsingMODI(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer; const language: WideString): WideString; dispid 2;
  end;

// *********************************************************************//
// Interface: IGetOCRText7
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {09C4FAF6-B846-4185-850D-27B8501EE752}
// *********************************************************************//
  IGetOCRText7 = interface(IGetOCRText6)
    ['{09C4FAF6-B846-4185-850D-27B8501EE752}']
    function Get_NumbersOnly: WordBool; safecall;
    procedure Set_NumbersOnly(pVal: WordBool); safecall;
    property NumbersOnly: WordBool read Get_NumbersOnly write Set_NumbersOnly;
  end;

// *********************************************************************//
// DispIntf:  IGetOCRText7Disp
// Flags:     (4544) Dual NonExtensible OleAutomation Dispatchable
// GUID:      {09C4FAF6-B846-4185-850D-27B8501EE752}
// *********************************************************************//
  IGetOCRText7Disp = dispinterface
    ['{09C4FAF6-B846-4185-850D-27B8501EE752}']
    property NumbersOnly: WordBool dispid 13;
    property OCRCorrection: WordBool dispid 12;
    property UseClientCoordinates: WordBool dispid 9;
    property HighlightInfo: ITHighlightInfo dispid 10;
    property ExtractHighlightInfo: WordBool dispid 11;
    function GetTextFromRect(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                             height: Integer; const language: WideString; invert: WordBool): WideString; dispid 5;
    function GetTextFromUIElem(const pUIElemDisp: IDispatch; const language: WideString; 
                               invert: WordBool): WideString; dispid 6;
    function GetRectFromText(hwnd: Integer; const text: WideString; const target_rect: IRect; 
                             const bstrLanguage: WideString; invert: WordBool; occurence: Integer): IRect; dispid 7;
    function IsTesseractAvailable: WordBool; dispid 8;
    function GetTextFromUIElemUsingMODI(const pUIElemDisp: IDispatch; const language: WideString): WideString; dispid 4;
    function GetRectFromTextUsingMODI(hwnd: Integer; const text: WideString; 
                                      const target_rect: IRect; const bstrLanguage: WideString; 
                                      occurence: Integer): IRect; dispid 3;
    function IsMODIAvailable: WordBool; dispid 1;
    function GetTextFromRectUsingMODI(hwnd: Integer; left: Integer; top: Integer; width: Integer; 
                                      height: Integer; const language: WideString): WideString; dispid 2;
  end;

// *********************************************************************//
// The Class CoTextCaptureX provides a Create and CreateRemote method to          
// create instances of the default interface ITextCaptureX15 exposed by              
// the CoClass TextCaptureX. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoTextCaptureX = class
    class function Create: ITextCaptureX15;
    class function CreateRemote(const MachineName: string): ITextCaptureX15;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TTextCaptureX
// Help String      : TextCaptureX Class
// Default Interface: ITextCaptureX15
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TTextCaptureXProperties= class;
{$ENDIF}
  TTextCaptureX = class(TOleServer)
  private
    FIntf:        ITextCaptureX15;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TTextCaptureXProperties;
    function      GetServerProperties: TTextCaptureXProperties;
{$ENDIF}
    function      GetDefaultInterface: ITextCaptureX15;
  protected
    procedure InitServerData; override;
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: ITextCaptureX15);
    procedure Disconnect; override;
    function GetRectFromUIElemText(const pUIElemDisp: IDispatch; const bstrText: WideString; 
                                   nOccurence: Integer): IRect;
    property DefaultInterface: ITextCaptureX15 read GetDefaultInterface;
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
    function    GetDefaultInterface: ITextCaptureX15;
    constructor Create(AServer: TTextCaptureX);
  protected
  public
    property DefaultInterface: ITextCaptureX15 read GetDefaultInterface;
  published
  end;
{$ENDIF}


// *********************************************************************//
// The Class CoGetAAText provides a Create and CreateRemote method to          
// create instances of the default interface IGetAAText5 exposed by              
// the CoClass GetAAText. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoGetAAText = class
    class function Create: IGetAAText5;
    class function CreateRemote(const MachineName: string): IGetAAText5;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TGetAAText
// Help String      : GetAAText
// Default Interface: IGetAAText5
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TGetAATextProperties= class;
{$ENDIF}
  TGetAAText = class(TOleServer)
  private
    FIntf:        IGetAAText5;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TGetAATextProperties;
    function      GetServerProperties: TGetAATextProperties;
{$ENDIF}
    function      GetDefaultInterface: IGetAAText5;
  protected
    procedure InitServerData; override;
    function Get_IgnoreHidden: WordBool;
    procedure Set_IgnoreHidden(pVal: WordBool);
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: IGetAAText5);
    procedure Disconnect; override;
    property DefaultInterface: IGetAAText5 read GetDefaultInterface;
    property IgnoreHidden: WordBool read Get_IgnoreHidden write Set_IgnoreHidden;
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
    function    GetDefaultInterface: IGetAAText5;
    constructor Create(AServer: TGetAAText);
  protected
    function Get_IgnoreHidden: WordBool;
    procedure Set_IgnoreHidden(pVal: WordBool);
  public
    property DefaultInterface: IGetAAText5 read GetDefaultInterface;
  published
    property IgnoreHidden: WordBool read Get_IgnoreHidden write Set_IgnoreHidden;
  end;
{$ENDIF}


// *********************************************************************//
// The Class CoGetOCRText provides a Create and CreateRemote method to          
// create instances of the default interface IGetOCRText7 exposed by              
// the CoClass GetOCRText. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoGetOCRText = class
    class function Create: IGetOCRText7;
    class function CreateRemote(const MachineName: string): IGetOCRText7;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TGetOCRText
// Help String      : GetOCRText
// Default Interface: IGetOCRText7
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TGetOCRTextProperties= class;
{$ENDIF}
  TGetOCRText = class(TOleServer)
  private
    FIntf:        IGetOCRText7;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TGetOCRTextProperties;
    function      GetServerProperties: TGetOCRTextProperties;
{$ENDIF}
    function      GetDefaultInterface: IGetOCRText7;
  protected
    procedure InitServerData; override;
    function Get_NumbersOnly: WordBool;
    procedure Set_NumbersOnly(pVal: WordBool);
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: IGetOCRText7);
    procedure Disconnect; override;
    property DefaultInterface: IGetOCRText7 read GetDefaultInterface;
    property NumbersOnly: WordBool read Get_NumbersOnly write Set_NumbersOnly;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TGetOCRTextProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : TGetOCRText
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TGetOCRTextProperties = class(TPersistent)
  private
    FServer:    TGetOCRText;
    function    GetDefaultInterface: IGetOCRText7;
    constructor Create(AServer: TGetOCRText);
  protected
    function Get_NumbersOnly: WordBool;
    procedure Set_NumbersOnly(pVal: WordBool);
  public
    property DefaultInterface: IGetOCRText7 read GetDefaultInterface;
  published
    property NumbersOnly: WordBool read Get_NumbersOnly write Set_NumbersOnly;
  end;
{$ENDIF}


// *********************************************************************//
// The Class CoTHighlightInfo provides a Create and CreateRemote method to          
// create instances of the default interface ITHighlightInfo2 exposed by              
// the CoClass THighlightInfo. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoTHighlightInfo = class
    class function Create: ITHighlightInfo2;
    class function CreateRemote(const MachineName: string): ITHighlightInfo2;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : TTHighlightInfo
// Help String      : THighlightInfo
// Default Interface: ITHighlightInfo2
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TTHighlightInfoProperties= class;
{$ENDIF}
  TTHighlightInfo = class(TOleServer)
  private
    FIntf:        ITHighlightInfo2;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TTHighlightInfoProperties;
    function      GetServerProperties: TTHighlightInfoProperties;
{$ENDIF}
    function      GetDefaultInterface: ITHighlightInfo2;
  protected
    procedure InitServerData; override;
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: ITHighlightInfo2);
    procedure Disconnect; override;
    procedure SerializeToBuffer(size: Integer; out buf: Integer);
    procedure DeserializeFromBuffer(var buf: Integer);
    function GetSerializedSize: Integer;
    property DefaultInterface: ITHighlightInfo2 read GetDefaultInterface;
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
    function    GetDefaultInterface: ITHighlightInfo2;
    constructor Create(AServer: TTHighlightInfo);
  protected
  public
    property DefaultInterface: ITHighlightInfo2 read GetDefaultInterface;
  published
  end;
{$ENDIF}


// *********************************************************************//
// The Class Corect provides a Create and CreateRemote method to          
// create instances of the default interface IRect exposed by              
// the CoClass rect. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  Corect = class
    class function Create: IRect;
    class function CreateRemote(const MachineName: string): IRect;
  end;


// *********************************************************************//
// OLE Server Proxy class declaration
// Server Object    : Trect
// Help String      : Rect Class
// Default Interface: IRect
// Def. Intf. DISP? : No
// Event   Interface: 
// TypeFlags        : (2) CanCreate
// *********************************************************************//
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  TrectProperties= class;
{$ENDIF}
  Trect = class(TOleServer)
  private
    FIntf:        IRect;
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    FProps:       TrectProperties;
    function      GetServerProperties: TrectProperties;
{$ENDIF}
    function      GetDefaultInterface: IRect;
  protected
    procedure InitServerData; override;
    function Get_RLeft: Integer;
    procedure Set_RLeft(pVal: Integer);
    function Get_RTop: Integer;
    procedure Set_RTop(pVal: Integer);
    function Get_RRight: Integer;
    procedure Set_RRight(pVal: Integer);
    function Get_RBottom: Integer;
    procedure Set_RBottom(pVal: Integer);
  public
    constructor Create(AOwner: TComponent); override;
    destructor  Destroy; override;
    procedure Connect; override;
    procedure ConnectTo(svrIntf: IRect);
    procedure Disconnect; override;
    function width: Integer;
    function height: Integer;
    property DefaultInterface: IRect read GetDefaultInterface;
    property RLeft: Integer read Get_RLeft write Set_RLeft;
    property RTop: Integer read Get_RTop write Set_RTop;
    property RRight: Integer read Get_RRight write Set_RRight;
    property RBottom: Integer read Get_RBottom write Set_RBottom;
  published
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
    property Server: TrectProperties read GetServerProperties;
{$ENDIF}
  end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
// *********************************************************************//
// OLE Server Properties Proxy Class
// Server Object    : Trect
// (This object is used by the IDE's Property Inspector to allow editing
//  of the properties of this server)
// *********************************************************************//
 TrectProperties = class(TPersistent)
  private
    FServer:    Trect;
    function    GetDefaultInterface: IRect;
    constructor Create(AServer: Trect);
  protected
    function Get_RLeft: Integer;
    procedure Set_RLeft(pVal: Integer);
    function Get_RTop: Integer;
    procedure Set_RTop(pVal: Integer);
    function Get_RRight: Integer;
    procedure Set_RRight(pVal: Integer);
    function Get_RBottom: Integer;
    procedure Set_RBottom(pVal: Integer);
  public
    property DefaultInterface: IRect read GetDefaultInterface;
  published
    property RLeft: Integer read Get_RLeft write Set_RLeft;
    property RTop: Integer read Get_RTop write Set_RTop;
    property RRight: Integer read Get_RRight write Set_RRight;
    property RBottom: Integer read Get_RBottom write Set_RBottom;
  end;
{$ENDIF}


procedure Register;

resourcestring
  dtlServerPage = 'ActiveX';

  dtlOcxPage = 'ActiveX';

implementation

uses ComObj;

class function CoTextCaptureX.Create: ITextCaptureX15;
begin
  Result := CreateComObject(CLASS_TextCaptureX) as ITextCaptureX15;
end;

class function CoTextCaptureX.CreateRemote(const MachineName: string): ITextCaptureX15;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_TextCaptureX) as ITextCaptureX15;
end;

procedure TTextCaptureX.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{13FE2FA1-EE8B-45B9-BBB4-08E5F2F43AC3}';
    IntfIID:   '{F087CCAF-0108-455B-A8F0-CCC05C0CE457}';
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
    Fintf:= punk as ITextCaptureX15;
  end;
end;

procedure TTextCaptureX.ConnectTo(svrIntf: ITextCaptureX15);
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

function TTextCaptureX.GetDefaultInterface: ITextCaptureX15;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
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

function TTextCaptureX.GetRectFromUIElemText(const pUIElemDisp: IDispatch; 
                                             const bstrText: WideString; nOccurence: Integer): IRect;
begin
  Result := DefaultInterface.GetRectFromUIElemText(pUIElemDisp, bstrText, nOccurence);
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TTextCaptureXProperties.Create(AServer: TTextCaptureX);
begin
  inherited Create;
  FServer := AServer;
end;

function TTextCaptureXProperties.GetDefaultInterface: ITextCaptureX15;
begin
  Result := FServer.DefaultInterface;
end;

{$ENDIF}

class function CoGetAAText.Create: IGetAAText5;
begin
  Result := CreateComObject(CLASS_GetAAText) as IGetAAText5;
end;

class function CoGetAAText.CreateRemote(const MachineName: string): IGetAAText5;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_GetAAText) as IGetAAText5;
end;

procedure TGetAAText.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{924699E8-66EF-4EB9-AB6E-3CA9660B31EC}';
    IntfIID:   '{2B5BB8EC-4219-42AE-A486-79D517753198}';
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
    Fintf:= punk as IGetAAText5;
  end;
end;

procedure TGetAAText.ConnectTo(svrIntf: IGetAAText5);
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

function TGetAAText.GetDefaultInterface: IGetAAText5;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
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

function TGetAAText.Get_IgnoreHidden: WordBool;
begin
    Result := DefaultInterface.IgnoreHidden;
end;

procedure TGetAAText.Set_IgnoreHidden(pVal: WordBool);
begin
  DefaultInterface.Set_IgnoreHidden(pVal);
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TGetAATextProperties.Create(AServer: TGetAAText);
begin
  inherited Create;
  FServer := AServer;
end;

function TGetAATextProperties.GetDefaultInterface: IGetAAText5;
begin
  Result := FServer.DefaultInterface;
end;

function TGetAATextProperties.Get_IgnoreHidden: WordBool;
begin
    Result := DefaultInterface.IgnoreHidden;
end;

procedure TGetAATextProperties.Set_IgnoreHidden(pVal: WordBool);
begin
  DefaultInterface.Set_IgnoreHidden(pVal);
end;

{$ENDIF}

class function CoGetOCRText.Create: IGetOCRText7;
begin
  Result := CreateComObject(CLASS_GetOCRText) as IGetOCRText7;
end;

class function CoGetOCRText.CreateRemote(const MachineName: string): IGetOCRText7;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_GetOCRText) as IGetOCRText7;
end;

procedure TGetOCRText.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{F827ADF4-AC12-4FAA-8073-4558C0489283}';
    IntfIID:   '{09C4FAF6-B846-4185-850D-27B8501EE752}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure TGetOCRText.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as IGetOCRText7;
  end;
end;

procedure TGetOCRText.ConnectTo(svrIntf: IGetOCRText7);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure TGetOCRText.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function TGetOCRText.GetDefaultInterface: IGetOCRText7;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
  Result := FIntf;
end;

constructor TGetOCRText.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TGetOCRTextProperties.Create(Self);
{$ENDIF}
end;

destructor TGetOCRText.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function TGetOCRText.GetServerProperties: TGetOCRTextProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function TGetOCRText.Get_NumbersOnly: WordBool;
begin
    Result := DefaultInterface.NumbersOnly;
end;

procedure TGetOCRText.Set_NumbersOnly(pVal: WordBool);
begin
  DefaultInterface.Set_NumbersOnly(pVal);
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TGetOCRTextProperties.Create(AServer: TGetOCRText);
begin
  inherited Create;
  FServer := AServer;
end;

function TGetOCRTextProperties.GetDefaultInterface: IGetOCRText7;
begin
  Result := FServer.DefaultInterface;
end;

function TGetOCRTextProperties.Get_NumbersOnly: WordBool;
begin
    Result := DefaultInterface.NumbersOnly;
end;

procedure TGetOCRTextProperties.Set_NumbersOnly(pVal: WordBool);
begin
  DefaultInterface.Set_NumbersOnly(pVal);
end;

{$ENDIF}

class function CoTHighlightInfo.Create: ITHighlightInfo2;
begin
  Result := CreateComObject(CLASS_THighlightInfo) as ITHighlightInfo2;
end;

class function CoTHighlightInfo.CreateRemote(const MachineName: string): ITHighlightInfo2;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_THighlightInfo) as ITHighlightInfo2;
end;

procedure TTHighlightInfo.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{B13501DF-12B3-4A6A-9A5B-8FA1EBCF8699}';
    IntfIID:   '{6B558D32-93F8-41E6-AD6E-79E64D58AC45}';
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
    Fintf:= punk as ITHighlightInfo2;
  end;
end;

procedure TTHighlightInfo.ConnectTo(svrIntf: ITHighlightInfo2);
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

function TTHighlightInfo.GetDefaultInterface: ITHighlightInfo2;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
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

procedure TTHighlightInfo.SerializeToBuffer(size: Integer; out buf: Integer);
begin
  DefaultInterface.SerializeToBuffer(size, buf);
end;

procedure TTHighlightInfo.DeserializeFromBuffer(var buf: Integer);
begin
  DefaultInterface.DeserializeFromBuffer(buf);
end;

function TTHighlightInfo.GetSerializedSize: Integer;
begin
  Result := DefaultInterface.GetSerializedSize;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TTHighlightInfoProperties.Create(AServer: TTHighlightInfo);
begin
  inherited Create;
  FServer := AServer;
end;

function TTHighlightInfoProperties.GetDefaultInterface: ITHighlightInfo2;
begin
  Result := FServer.DefaultInterface;
end;

{$ENDIF}

class function Corect.Create: IRect;
begin
  Result := CreateComObject(CLASS_rect) as IRect;
end;

class function Corect.CreateRemote(const MachineName: string): IRect;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_rect) as IRect;
end;

procedure Trect.InitServerData;
const
  CServerData: TServerData = (
    ClassID:   '{FB9DE2D6-DDAF-47B3-BCF0-31D17E8D34C5}';
    IntfIID:   '{0E4BE2A0-AD3A-4237-9406-CEB504EFE361}';
    EventIID:  '';
    LicenseKey: nil;
    Version: 500);
begin
  ServerData := @CServerData;
end;

procedure Trect.Connect;
var
  punk: IUnknown;
begin
  if FIntf = nil then
  begin
    punk := GetServer;
    Fintf:= punk as IRect;
  end;
end;

procedure Trect.ConnectTo(svrIntf: IRect);
begin
  Disconnect;
  FIntf := svrIntf;
end;

procedure Trect.DisConnect;
begin
  if Fintf <> nil then
  begin
    FIntf := nil;
  end;
end;

function Trect.GetDefaultInterface: IRect;
begin
  if FIntf = nil then
    Connect;
  Assert(FIntf <> nil, 'DefaultInterface is NULL. Component is not connected to Server. You must call ''Connect'' or ''ConnectTo'' before this operation');
  Result := FIntf;
end;

constructor Trect.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps := TrectProperties.Create(Self);
{$ENDIF}
end;

destructor Trect.Destroy;
begin
{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
  FProps.Free;
{$ENDIF}
  inherited Destroy;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
function Trect.GetServerProperties: TrectProperties;
begin
  Result := FProps;
end;
{$ENDIF}

function Trect.Get_RLeft: Integer;
begin
    Result := DefaultInterface.RLeft;
end;

procedure Trect.Set_RLeft(pVal: Integer);
begin
  DefaultInterface.Set_RLeft(pVal);
end;

function Trect.Get_RTop: Integer;
begin
    Result := DefaultInterface.RTop;
end;

procedure Trect.Set_RTop(pVal: Integer);
begin
  DefaultInterface.Set_RTop(pVal);
end;

function Trect.Get_RRight: Integer;
begin
    Result := DefaultInterface.RRight;
end;

procedure Trect.Set_RRight(pVal: Integer);
begin
  DefaultInterface.Set_RRight(pVal);
end;

function Trect.Get_RBottom: Integer;
begin
    Result := DefaultInterface.RBottom;
end;

procedure Trect.Set_RBottom(pVal: Integer);
begin
  DefaultInterface.Set_RBottom(pVal);
end;

function Trect.width: Integer;
begin
  Result := DefaultInterface.width;
end;

function Trect.height: Integer;
begin
  Result := DefaultInterface.height;
end;

{$IFDEF LIVE_SERVER_AT_DESIGN_TIME}
constructor TrectProperties.Create(AServer: Trect);
begin
  inherited Create;
  FServer := AServer;
end;

function TrectProperties.GetDefaultInterface: IRect;
begin
  Result := FServer.DefaultInterface;
end;

function TrectProperties.Get_RLeft: Integer;
begin
    Result := DefaultInterface.RLeft;
end;

procedure TrectProperties.Set_RLeft(pVal: Integer);
begin
  DefaultInterface.Set_RLeft(pVal);
end;

function TrectProperties.Get_RTop: Integer;
begin
    Result := DefaultInterface.RTop;
end;

procedure TrectProperties.Set_RTop(pVal: Integer);
begin
  DefaultInterface.Set_RTop(pVal);
end;

function TrectProperties.Get_RRight: Integer;
begin
    Result := DefaultInterface.RRight;
end;

procedure TrectProperties.Set_RRight(pVal: Integer);
begin
  DefaultInterface.Set_RRight(pVal);
end;

function TrectProperties.Get_RBottom: Integer;
begin
    Result := DefaultInterface.RBottom;
end;

procedure TrectProperties.Set_RBottom(pVal: Integer);
begin
  DefaultInterface.Set_RBottom(pVal);
end;

{$ENDIF}

procedure Register;
begin
  RegisterComponents(dtlServerPage, [TTextCaptureX, TGetAAText, TGetOCRText, TTHighlightInfo, 
    Trect]);
end;

end.
