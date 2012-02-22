#include "stdafx.h"
#pragma once
static _ATL_FUNC_INFO FiredSystemMouseEventStruct = {CC_STDCALL, VT_EMPTY, 5, {VT_I4, VT_I4, VT_I4, VT_I4, VT_I4}};
static _ATL_FUNC_INFO FiredSystemKeyboardEventStruct = {CC_STDCALL, VT_EMPTY, 4, {VT_I4, VT_I4, VT_I4, VT_I4}};

class CSystemEventsHandler : public IDispEventSimpleImpl</*nID =*/ 1, CSystemEventsHandler, &__uuidof(IUiSystemEvents)>
{
public:
   CSystemEventsHandler()
   {
   }

public:
   BEGIN_SINK_MAP(CSystemEventsHandler)
      SINK_ENTRY_INFO(1, __uuidof(IUiSystemEvents), 3, &CSystemEventsHandler::OnUiMouse, &FiredSystemMouseEventStruct)
	  SINK_ENTRY_INFO(1, __uuidof(IUiSystemEvents), 4, &CSystemEventsHandler::OnUiKeyboard, &FiredSystemKeyboardEventStruct)
   END_SINK_MAP()

   
   
  void __stdcall OnUiMouse(LONG hwnd, LONG x1, LONG y1, LONG x2, LONG y2)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }
  
  void __stdcall OnUiKeyboard(LONG hwnd, LONG x, LONG y, LONG id)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }

 HRESULT Advise(IUnknown *punk)
 {
	 return IDispEventSimpleImpl<1, CSystemEventsHandler, &__uuidof(IUiSystemEvents)>::DispEventAdvise(punk);
 }

};