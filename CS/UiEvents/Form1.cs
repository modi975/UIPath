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
        public UiEvents uiEvents;
        public UiNode uiNode;
        public Form1()
        {
            InitializeComponent();
            Monitor.SelectedIndex = 0;
            SpecialKey_Combo.SelectedIndex = 0;
            BTN_Combo.SelectedIndex = 0;
            KeyModifier_Combo.SelectedIndex = 0;
            Blocking_Combo.SelectedIndex = 0;

            //instantiate UiEvents object
            uiEvents = ComFactory.Instance.NewUiEvents();

            //instantiate UiNode object
            uiNode = ComFactory.Instance.NewUiNode();
        }

        private void StartVMMonitor_Click(object sender, EventArgs e)
        {
            //register for events
            if (Monitor.SelectedIndex == 0)
            {
                //register for mouse monitoring
                uiEvents.OnMonitorMouseEvent += new IUiEventsToComEvents_OnMonitorMouseEventEventHandler(uiEvents_OnMonitorMouseEvent);
                UiMouseButton msBtn = (UiMouseButton)BTN_Combo.SelectedIndex;
                UiKeyModifier kModif = (UiKeyModifier)KeyModifier_Combo.SelectedIndex;
                uiEvents.MonitorClick(msBtn, kModif);
            }
            else
            {
                //register for hotkey monitoring
                uiEvents.OnMonitorHotkeyEvent += new IUiEventsToComEvents_OnMonitorHotkeyEventEventHandler(uiEvents_OnMonitorHotkeyEvent);
                string key = KeyTextBox.Text;
                if(key == "")
                {
                    key = SpecialKey_Combo.SelectedItem.ToString();
                }

                uiEvents.MonitorHotkey(key, (UiKeyModifier)KeyModifier_Combo.SelectedIndex);
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

            //register for events
            if (Monitor.SelectedIndex == 0)
            {
                //register for mouse monitoring
                uiEvents.OnUiMouseEvent += new IUiEventsToComEvents_OnUiMouseEventEventHandler(uiEvents_OnUiMouseEvent);
                uiEvents.AttachClick((UiMouseButton)BTN_Combo.SelectedIndex, (UiKeyModifier)KeyModifier_Combo.SelectedIndex, (UiEventType)Blocking_Combo.SelectedIndex, Selector, null);
            }
            else
            {
                //register for keyboard monitoring
                uiEvents.OnUiKeyboardEvent += new IUiEventsToComEvents_OnUiKeyboardEventEventHandler(uiEvents_OnUiKeyboardEvent);
                string key = KeyTextBox.Text;
                if (key == "")
                {
                    key = SpecialKey_Combo.SelectedText;
                }

                uiEvents.AttachKeys(key, (UiKeyModifier)KeyModifier_Combo.SelectedIndex, (UiEventType)Blocking_Combo.SelectedIndex, Selector, null);
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
            uiEvents.OnMonitorMouseEvent -= uiEvents_OnMonitorMouseEvent;
            uiEvents.OnMonitorHotkeyEvent -= uiEvents_OnMonitorHotkeyEvent;
            uiEvents.OnUiKeyboardEvent -= uiEvents_OnUiKeyboardEvent;
            uiEvents.OnUiMouseEvent -= uiEvents_OnUiMouseEvent;

            //Detach all events
            uiEvents.StopMonitoring();
            uiEvents.DetachAll();
            
        }
        
        void uiEvents_OnMonitorMouseEvent(int hWnd, int x1, int y1, int x2, int y2)
        {
            LogTextBox.AppendText("OnMonitorMouseEvent fired : hwnd: " + hWnd + ", x1: " + x1 + ", y1: " + y1 + ", x2:" + x2 + ", y2: " + y2 + "\r\n");
        }

        void uiEvents_OnMonitorHotkeyEvent(int hWnd, int x, int y, int id)
        {
            LogTextBox.AppendText("OnMonitorHotkeyEvent fired : hwnd: " + hWnd + ", x: " + x + ", y: " + y + ", id:" + id + "\r\n");
        }

        void uiEvents_OnUiMouseEvent(int monitorID, int hWnd, int x, int y)
        {
            LogTextBox.AppendText("OnUiMouseEvent fired : monitorID: " + monitorID + ", hwnd: " + hWnd + ", x: " + x + ", y:" + y + "\r\n");
        }

        void uiEvents_OnUiKeyboardEvent(int monitorID, int hWnd, int ScanCode)
        {
            LogTextBox.AppendText("OnUiKeyboardEvent fired : monitorID: " + monitorID + ", hwnd: " + hWnd + ", ScanCode: " + ScanCode + "\r\n");
        }

    }
}
