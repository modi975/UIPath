#include "stdafx.h"
#pragma once
static _ATL_FUNC_INFO FiredMouseEventStruct = {CC_STDCALL, VT_EMPTY, 1, {VT_DISPATCH|VT_BYREF}};
static _ATL_FUNC_INFO FiredKeyboardEventStruct = {CC_STDCALL, VT_EMPTY, 1, {VT_DISPATCH|VT_BYREF}};

class CNodeMonitorHandler : public IDispEventSimpleImpl</*nID =*/ 1, CNodeMonitorHandler, &__uuidof(IUiEvents)>
{
public:
   CNodeMonitorHandler()
   {
	   m_enEventMode = UI_EVENT_FORWARD;
   }

public:
   BEGIN_SINK_MAP(CNodeMonitorHandler)
      SINK_ENTRY_INFO(1, __uuidof(IUiEvents), 1, &CNodeMonitorHandler::OnUiMouse, &FiredMouseEventStruct)
	  SINK_ENTRY_INFO(1, __uuidof(IUiEvents), 2, &CNodeMonitorHandler::OnUiKeyboard, &FiredKeyboardEventStruct)
   END_SINK_MAP()

public:
	UiEventMode m_enEventMode;  
   
   
 void __stdcall OnUiMouse(CComQIPtr<IUiEventInfo> uiEvent)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
	 uiEvent->forward = m_enEventMode;
 }

  void __stdcall OnUiKeyboard(CComQIPtr<IUiEventInfo> uiEvent)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
	 uiEvent->forward = m_enEventMode;
 }

  HRESULT Advise(IUnknown *punk)
 {
	 return IDispEventSimpleImpl<1, CNodeMonitorHandler, &__uuidof(IUiEvents)>::DispEventAdvise(punk);
 }

};