using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UiPath;

namespace UiEventsSample
{
    public partial class Form1 : Form
    {
        public UiNodeMonitor uiNodeEvents;
        public UiSystem uiSystemEvents;
        public UiNode uiNode;
        public Form1()
        {
            InitializeComponent();
            Monitor.SelectedIndex = 0;
            SpecialKey_Combo.SelectedIndex = 0;
            BTN_Combo.SelectedIndex = 0;
            KeyModifier_Combo.SelectedIndex = 0;
            EventType_Combo.SelectedIndex = 0;
            Blocking_Combo.SelectedIndex = 0;

            //instantiate UiEvents objects
            uiNodeEvents = UiFactory.Instance.NewUiNodeMonitor();
            uiSystemEvents = UiFactory.Instance.NewUiSystem();

            //instantiate UiNode object
            uiNode = UiFactory.Instance.NewUiNode();
        }

        private void StartVMMonitor_Click(object sender, EventArgs e)
        {
            //register for events
            if (Monitor.SelectedIndex == 0)
            {
                //register for mouse monitoring
                uiSystemEvents.OnUiMouse += new IUiSystemEvents_OnUiMouseEventHandler(UiSystemEvents_OnUiMouseEvent);
                UiMouseButton msBtn = (UiMouseButton)BTN_Combo.SelectedIndex;
                UiKeyModifier kModif = (UiKeyModifier)KeyModifier_Combo.SelectedIndex;
                UiEventMode eventMode = (UiEventMode)Blocking_Combo.SelectedIndex;
                uiSystemEvents.MonitorClick(msBtn, kModif, eventMode);
            }
            else
            {
                //register for hotkey monitoring
                uiSystemEvents.OnUiKeyboard += new IUiSystemEvents_OnUiKeyboardEventHandler(UiSystemEvents_OnUiKeyboardEvent);
                string key = KeyTextBox.Text;
                if(key == "")
                {
                    key = SpecialKey_Combo.SelectedItem.ToString();
                }

                uiSystemEvents.MonitorHotkey(key, (UiKeyModifier)KeyModifier_Combo.SelectedIndex);
            }
            StartVMMonitor.Enabled = false;
        }

        private void Monitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Monitor.SelectedIndex == 0)
            {
                KeyTextBox.Enabled = false;
                SpecialKey_Combo.Enabled = false;
                BTN_Combo.Enabled = true;
            }
            else
            {
                KeyTextBox.Enabled = true;
                SpecialKey_Combo.Enabled = true;
                BTN_Combo.Enabled = false;
            }

        }

        private void SpecialKey_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpecialKey_Combo.SelectedIndex != 0)
            {
                KeyTextBox.Text = "";
            }
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            SpecialKey_Combo.SelectedIndex = 0;
        }      

        private void MonitorUIObject_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            //select a control
            uiNode.SelectInteractive(UiSelectionType.UI_SELECT_NODE);
            string Selector = uiNode.GetSelector(true);
            bool MatchChildren = false;
            if (IncludeChildren_Checkbox.CheckState == CheckState.Checked)
            {
                MatchChildren = true;
            }

            //register for events
            if (Monitor.SelectedIndex == 0)
            {
                //register for mouse monitoring
                uiNodeEvents.OnUiMouse += new IUiNodeMonitorEvents_OnUiMouseEventHandler(uiNodeMonitor_OnUiMouseEvent);
                uiNodeEvents.MonitorClick((UiMouseButton)BTN_Combo.SelectedIndex, (UiKeyModifier)KeyModifier_Combo.SelectedIndex, (UiEventType)EventType_Combo.SelectedIndex, Selector, MatchChildren, null);
            }
            else
            {
                //register for keyboard monitoring
                uiNodeEvents.OnUiKeyboard += new IUiNodeMonitorEvents_OnUiKeyboardEventHandler(uiNodeMonitor_OnUiKeyboardEvent);
                string key = KeyTextBox.Text;
                if (key == "")
                {
                    key = SpecialKey_Combo.SelectedText;
                }

                uiNodeEvents.MonitorHotkey(key, (UiKeyModifier)KeyModifier_Combo.SelectedIndex, (UiEventType)EventType_Combo.SelectedIndex, Selector, MatchChildren);
            }
            MonitorUIObject.Enabled = false;
            WindowState = FormWindowState.Normal;
        }

        private void StopMonitoring_Click(object sender, EventArgs e)
        {
            StartVMMonitor.Enabled = true;
            MonitorUIObject.Enabled = true;
            LogTextBox.ResetText();

            //remove event handlers 
            uiNodeEvents.OnUiMouse -= uiNodeMonitor_OnUiMouseEvent;
            uiNodeEvents.OnUiKeyboard -= uiNodeMonitor_OnUiKeyboardEvent;
            uiSystemEvents.OnUiMouse -= UiSystemEvents_OnUiMouseEvent;
            uiSystemEvents.OnUiKeyboard -= UiSystemEvents_OnUiKeyboardEvent;

            //Detach all events
            uiNodeEvents.StopMonitoring();
            uiSystemEvents.StopMonitoring();
            
        }

        void UiSystemEvents_OnUiMouseEvent(int hWnd, int x1, int y1, int x2, int y2)
        {
            LogTextBox.AppendText("OnMonitorMouseEvent fired : hwnd: " + hWnd + ", x1: " + x1 + ", y1: " + y1 + ", x2:" + x2 + ", y2: " + y2 + "\r\n");
        }

        void UiSystemEvents_OnUiKeyboardEvent(int hWnd, int x, int y, int id)
        {
            LogTextBox.AppendText("OnMonitorHotkeyEvent fired : hwnd: " + hWnd + ", x: " + x + ", y: " + y + ", id:" + id + "\r\n");
        }

        void uiNodeMonitor_OnUiMouseEvent(int monitorID, int hWnd, int x, int y, out UiEventMode Forward)
        {
            LogTextBox.AppendText("OnUiMouseEvent fired : monitorID: " + monitorID + ", hwnd: " + hWnd + ", x: " + x + ", y:" + y + "\r\n");
            //Pass the event to control
            if (Blocking_Combo.SelectedIndex == 0)
                Forward = UiEventMode.UI_EVENT_FORWARD;
            else
                Forward = UiEventMode.UI_EVENT_BLOCK;
        }

        void uiNodeMonitor_OnUiKeyboardEvent(int monitorID, int hWnd, int ScanCode, out UiEventMode Forward)
        {
            LogTextBox.AppendText("OnUiKeyboardEvent fired : monitorID: " + monitorID + ", hwnd: " + hWnd + ", ScanCode: " + ScanCode + "\r\n");
            //Pass the event to control
            if (Blocking_Combo.SelectedIndex == 0)
                Forward = UiEventMode.UI_EVENT_FORWARD;
            else
                Forward = UiEventMode.UI_EVENT_BLOCK;
        }

    }
}
