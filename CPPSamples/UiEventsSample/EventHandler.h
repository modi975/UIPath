#include "stdafx.h"
#pragma once
static _ATL_FUNC_INFO FiredEventStruct = {CC_STDCALL, VT_EMPTY, 3, {VT_I4, VT_I4, VT_I4}};

class CEventHandler : public IDispEventSimpleImpl</*nID =*/ 1, CEventHandler, &__uuidof(IUiEventsToComEvents)>
{
public:
   CEventHandler()
   {
   }

public:
   BEGIN_SINK_MAP(CEventHandler)
      SINK_ENTRY_INFO(1, __uuidof(IUiEventsToComEvents), 1, &CEventHandler::OnUiEvent, &FiredEventStruct)
   END_SINK_MAP()

   
 void __stdcall OnUiEvent(LONG monitorId, LONG x, LONG y)
 {
	 MessageBox(NULL, _T("Event fired"), _T("Event handler"), 0);
 }

 HRESULT Advise(IUnknown *punk)
 {
	 return IDispEventSimpleImpl<1, CEventHandler, &__uuidof(IUiEventsToComEvents)>::DispEventAdvise(punk);
 }

};