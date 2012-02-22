#include "stdafx.h"
#pragma once
static _ATL_FUNC_INFO FiredMouseEventStruct = {CC_STDCALL, VT_EMPTY, 5, {VT_I4, VT_I4, VT_I4, VT_I4, VT_BOOL|VT_BYREF}};
static _ATL_FUNC_INFO FiredKeyboardEventStruct = {CC_STDCALL, VT_EMPTY, 3, {VT_I4, VT_I4, VT_I4, VT_BOOL|VT_BYREF}};

class CNodeMonitorHandler : public IDispEventSimpleImpl</*nID =*/ 1, CNodeMonitorHandler, &__uuidof(IUiNodeMonitorEvents)>
{
public:
   CNodeMonitorHandler()
   {
   }

public:
   BEGIN_SINK_MAP(CNodeMonitorHandler)
      SINK_ENTRY_INFO(1, __uuidof(IUiNodeMonitorEvents), 1, &CNodeMonitorHandler::OnUiMouse, &FiredMouseEventStruct)
	  SINK_ENTRY_INFO(1, __uuidof(IUiNodeMonitorEvents), 2, &CNodeMonitorHandler::OnUiKeyboard, &FiredKeyboardEventStruct)
   END_SINK_MAP()

   
   
 void __stdcall OnUiMouse(LONG monitorId, LONG hwnd, LONG x, LONG y, VARIANT_BOOL *pbForwardEvent)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }

  void __stdcall OnUiKeyboard(LONG monitorId, LONG hwnd, LONG scanCode,  VARIANT_BOOL *pbForwardEvent)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }

  HRESULT Advise(IUnknown *punk)
 {
	 return IDispEventSimpleImpl<1, CNodeMonitorHandler, &__uuidof(IUiNodeMonitorEvents)>::DispEventAdvise(punk);
 }

};