object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 679
  ClientWidth = 304
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 40
    Top = 112
    Width = 77
    Height = 13
    Caption = 'Window handle:'
  end
  object Label2: TLabel
    Left = 40
    Top = 141
    Width = 56
    Height = 13
    Caption = 'Window ID:'
  end
  object Label3: TLabel
    Left = 40
    Top = 248
    Width = 10
    Height = 13
    Caption = 'X:'
  end
  object Label4: TLabel
    Left = 99
    Top = 248
    Width = 10
    Height = 13
    Caption = 'Y:'
  end
  object Label5: TLabel
    Left = 157
    Top = 248
    Width = 14
    Height = 13
    Caption = 'W:'
  end
  object Label6: TLabel
    Left = 225
    Top = 248
    Width = 11
    Height = 13
    Caption = 'H:'
  end
  object Label7: TLabel
    Left = 40
    Top = 280
    Width = 125
    Height = 13
    Caption = 'Screen Scraping Methods:'
  end
  object Label8: TLabel
    Left = 47
    Top = 392
    Width = 117
    Height = 13
    Caption = 'Region Screen Scraping:'
  end
  object btnCapture: TButton
    Left = 63
    Top = 443
    Width = 193
    Height = 25
    Caption = 'Get text from defined region'
    TabOrder = 0
    OnClick = btnCaptureClick
  end
  object txtResult: TMemo
    Left = 23
    Top = 567
    Width = 273
    Height = 106
    ReadOnly = True
    ScrollBars = ssVertical
    TabOrder = 1
  end
  object btnSelReg: TButton
    Left = 40
    Top = 24
    Width = 225
    Height = 25
    Caption = 'Select a region from the screen'
    TabOrder = 2
    OnClick = btnSelRegClick
  end
  object btnSelWnd: TButton
    Left = 40
    Top = 64
    Width = 225
    Height = 25
    Caption = 'Select a window or control'
    TabOrder = 3
    OnClick = btnSelWndClick
  end
  object txtHandle: TEdit
    Left = 144
    Top = 109
    Width = 121
    Height = 21
    Alignment = taRightJustify
    TabOrder = 4
  end
  object txtX: TEdit
    Left = 63
    Top = 245
    Width = 30
    Height = 21
    NumbersOnly = True
    TabOrder = 5
    Text = 'txtX'
  end
  object txtY: TEdit
    Left = 119
    Top = 245
    Width = 32
    Height = 21
    NumbersOnly = True
    TabOrder = 6
    Text = 'txtY'
  end
  object txtW: TEdit
    Left = 180
    Top = 245
    Width = 39
    Height = 21
    NumbersOnly = True
    TabOrder = 7
    Text = 'txtW'
  end
  object txtH: TEdit
    Left = 242
    Top = 245
    Width = 29
    Height = 21
    NumbersOnly = True
    TabOrder = 8
    Text = 'txtH'
  end
  object radioNative: TRadioButton
    Left = 40
    Top = 312
    Width = 113
    Height = 17
    Caption = 'Native method'
    TabOrder = 9
  end
  object radioFull: TRadioButton
    Left = 159
    Top = 312
    Width = 113
    Height = 17
    Caption = 'FullText method'
    TabOrder = 10
  end
  object radioOCR: TRadioButton
    Left = 40
    Top = 360
    Width = 81
    Height = 17
    Caption = 'OCR method'
    TabOrder = 11
  end
  object comboEngine: TComboBox
    Left = 127
    Top = 358
    Width = 82
    Height = 21
    TabOrder = 12
    Text = 'Internal'
  end
  object comboLang: TComboBox
    Left = 225
    Top = 358
    Width = 79
    Height = 21
    TabOrder = 13
    Text = 'eng'
  end
  object checkLayout: TCheckBox
    Left = 63
    Top = 335
    Width = 97
    Height = 17
    Caption = 'Preserve Layout'
    TabOrder = 14
    OnClick = checkLayoutClick
  end
  object checkID: TCheckBox
    Left = 63
    Top = 420
    Width = 186
    Height = 17
    Caption = 'Use the ID instead of the HWND'
    Checked = True
    State = cbChecked
    TabOrder = 15
  end
  object Button3: TButton
    Left = 63
    Top = 474
    Width = 193
    Height = 25
    Caption = 'Get text from defined window'
    TabOrder = 16
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 63
    Top = 505
    Width = 193
    Height = 25
    Caption = 'Get text out of active window'
    TabOrder = 17
    OnClick = Button4Click
  end
  object Button5: TButton
    Left = 63
    Top = 536
    Width = 193
    Height = 25
    Caption = 'Get word from a X, Y point'
    TabOrder = 18
    OnClick = Button5Click
  end
  object txtID: TMemo
    Left = 40
    Top = 160
    Width = 225
    Height = 72
    Lines.Strings = (
      'txtID')
    ScrollBars = ssVertical
    TabOrder = 19
  end
end
