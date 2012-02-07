#include "stdafx.h"
#pragma once
static _ATL_FUNC_INFO FiredMouseEventStruct = {CC_STDCALL, VT_EMPTY, 4, {VT_I4, VT_I4, VT_I4, VT_I4}};
static _ATL_FUNC_INFO FiredKeyboardEventStruct = {CC_STDCALL, VT_EMPTY, 3, {VT_I4, VT_I4, VT_I4}};
static _ATL_FUNC_INFO FiredMonitorMouseEventStruct = {CC_STDCALL, VT_EMPTY, 5, {VT_I4, VT_I4, VT_I4, VT_I4, VT_I4}};
static _ATL_FUNC_INFO FiredMonitorHotkeyEventStruct = {CC_STDCALL, VT_EMPTY, 4, {VT_I4, VT_I4, VT_I4, VT_I4}};

class CEventHandler : public IDispEventSimpleImpl</*nID =*/ 1, CEventHandler, &__uuidof(IUiEventsToComEvents)>
{
public:
   CEventHandler()
   {
   }

public:
   BEGIN_SINK_MAP(CEventHandler)
      SINK_ENTRY_INFO(1, __uuidof(IUiEventsToComEvents), 1, &CEventHandler::OnUiMouseEvent, &FiredMouseEventStruct)
	  SINK_ENTRY_INFO(1, __uuidof(IUiEventsToComEvents), 2, &CEventHandler::OnUiKeyboardEvent, &FiredKeyboardEventStruct)
	  SINK_ENTRY_INFO(1, __uuidof(IUiEventsToComEvents), 3, &CEventHandler::OnMonitorMouseEvent, &FiredMonitorMouseEventStruct)
	  SINK_ENTRY_INFO(1, __uuidof(IUiEventsToComEvents), 4, &CEventHandler::OnMonitorHotkeyEvent, &FiredMonitorHotkeyEventStruct)
   END_SINK_MAP()

   
   
 void __stdcall OnUiMouseEvent(LONG monitorId, LONG hwnd, LONG x, LONG y)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }

  void __stdcall OnUiKeyboardEvent(LONG monitorId, LONG hwnd, LONG scanCode)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }

  
  void __stdcall OnMonitorMouseEvent(LONG hwnd, LONG x1, LONG y1, LONG x2, LONG y2)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }
  
  void __stdcall OnMonitorHotkeyEvent(LONG hwnd, LONG x, LONG y, LONG id)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }

 HRESULT Advise(IUnknown *punk)
 {
	 return IDispEventSimpleImpl<1, CEventHandler, &__uuidof(IUiEventsToComEvents)>::DispEventAdvise(punk);
 }

};