#include "stdafx.h"
#pragma once
static _ATL_FUNC_INFO FiredSystemMouseEventStruct = {CC_STDCALL, VT_EMPTY, 1, {VT_DISPATCH}};
static _ATL_FUNC_INFO FiredSystemKeyboardEventStruct = {CC_STDCALL, VT_EMPTY, 1, {VT_DISPATCH}};

class CSystemEventsHandler : public IDispEventSimpleImpl</*nID =*/ 1, CSystemEventsHandler, &__uuidof(IUiEvents)>
{
public:
   CSystemEventsHandler()
   {
   }

public:
   BEGIN_SINK_MAP(CSystemEventsHandler)
      SINK_ENTRY_INFO(1, __uuidof(IUiEvents), 1, &CSystemEventsHandler::OnUiMouse, &FiredSystemMouseEventStruct)
	  SINK_ENTRY_INFO(1, __uuidof(IUiEvents), 2, &CSystemEventsHandler::OnUiKeyboard, &FiredSystemKeyboardEventStruct)
   END_SINK_MAP()
   
  void __stdcall OnUiMouse(CComQIPtr<IUiEventInfo> uiEvent)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }
  
  void __stdcall OnUiKeyboard(CComQIPtr<IUiEventInfo> uiEvent)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }

 HRESULT Advise(IUnknown *punk)
 {
	 return IDispEventSimpleImpl<1, CSystemEventsHandler, &__uuidof(IUiEvents)>::DispEventAdvise(punk);
 }

};