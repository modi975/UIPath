Attribute VB_Name = "Module1"
Sub uipath()
    ' Start browser and navigate to yahoo finance page.
    Dim b As UiBrowser
    Set b = New UiBrowser
    Call b.Start("http://finance.yahoo.com/", UI_BROWSER_IE)
    
    Dim n As UiNode
    Set n = b.Node
    
    ' Type MSFT in the search edit box.
    Dim e As UiNode
    Set e = n.FindFirst(UI_FIND_DESCENDANTS, "<webctrl tag='INPUT' id='txtQuotes' />")
    Call e.WriteText("GOOG", UI_CONTROL_API)

    ' Press search quote button.
    Dim q As UiNode
    Set q = n.FindFirst(UI_FIND_DESCENDANTS, "<webctrl tag='INPUT' id='btnQuotes' />")
    Call q.Click(0, 0, UI_CLICK_SINGLE, UI_BTN_LEFT, UI_CONTROL_API)
    
    ' Get the quote value.
    Dim r As UiNode
    Set r = n.FindFirst(UI_FIND_DESCENDANTS, "<webctrl tag='DIV' id='yfi_investing_content' /><webctrl tag='SPAN' id='yfs_l84_*' />")
    Sheets(1).Cells(1, 1).Value = r.Get("text")
End Sub
