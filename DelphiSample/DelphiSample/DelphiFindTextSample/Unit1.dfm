object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 704
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
    Left = 47
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
    Top = 293
    Width = 125
    Height = 13
    Caption = 'Screen Scraping Methods:'
  end
  object Label8: TLabel
    Left = 44
    Top = 8
    Width = 127
    Height = 13
    Caption = 'Where is the text located?'
  end
  object btnSelReg: TButton
    Left = 40
    Top = 40
    Width = 225
    Height = 25
    Caption = 'INSIDE a region on the screen'
    TabOrder = 0
    OnClick = btnSelRegClick
  end
  object btnSelWnd: TButton
    Left = 40
    Top = 71
    Width = 225
    Height = 25
    Caption = 'INSIDE a window or control'
    TabOrder = 1
    OnClick = btnSelWndClick
  end
  object txtHandle: TEdit
    Left = 144
    Top = 109
    Width = 121
    Height = 21
    Alignment = taRightJustify
    TabOrder = 2
  end
  object txtX: TEdit
    Left = 63
    Top = 245
    Width = 30
    Height = 21
    NumbersOnly = True
    TabOrder = 3
    Text = 'txtX'
  end
  object txtY: TEdit
    Left = 119
    Top = 245
    Width = 32
    Height = 21
    NumbersOnly = True
    TabOrder = 4
    Text = 'txtY'
  end
  object txtW: TEdit
    Left = 180
    Top = 245
    Width = 39
    Height = 21
    NumbersOnly = True
    TabOrder = 5
    Text = 'txtW'
  end
  object txtH: TEdit
    Left = 242
    Top = 245
    Width = 29
    Height = 21
    NumbersOnly = True
    TabOrder = 6
    Text = 'txtH'
  end
  object radioNative: TRadioButton
    Left = 40
    Top = 312
    Width = 113
    Height = 17
    Caption = 'Native method'
    TabOrder = 7
  end
  object radioOCR: TRadioButton
    Left = 40
    Top = 360
    Width = 81
    Height = 17
    Caption = 'OCR method'
    TabOrder = 8
  end
  object comboEngine: TComboBox
    Left = 127
    Top = 358
    Width = 82
    Height = 21
    TabOrder = 9
    Text = 'Internal'
  end
  object comboLang: TComboBox
    Left = 217
    Top = 358
    Width = 79
    Height = 21
    TabOrder = 10
    Text = 'eng'
  end
  object checkLayout: TCheckBox
    Left = 63
    Top = 335
    Width = 97
    Height = 17
    Caption = 'Preserve Layout'
    TabOrder = 11
    OnClick = checkLayoutClick
  end
  object txtID: TMemo
    Left = 40
    Top = 160
    Width = 225
    Height = 72
    Lines.Strings = (
      'txtID')
    ScrollBars = ssVertical
    TabOrder = 12
  end
  object GroupBox1: TGroupBox
    Left = 24
    Top = 400
    Width = 257
    Height = 196
    Caption = 'Find Text '
    TabOrder = 13
    object Label9: TLabel
      Left = 16
      Top = 24
      Width = 151
      Height = 13
      Caption = 'What text do you want to find?'
    end
    object Label10: TLabel
      Left = 16
      Top = 67
      Width = 59
      Height = 13
      Caption = 'Occurrence:'
    end
    object Label11: TLabel
      Left = 15
      Top = 138
      Width = 152
      Height = 13
      Caption = 'Text was found at this location:'
    end
    object Label12: TLabel
      Left = 198
      Top = 169
      Width = 11
      Height = 13
      Caption = 'H:'
    end
    object Label13: TLabel
      Left = 139
      Top = 169
      Width = 14
      Height = 13
      Caption = 'W:'
    end
    object Label14: TLabel
      Left = 85
      Top = 169
      Width = 10
      Height = 13
      Caption = 'Y:'
    end
    object Label15: TLabel
      Left = 22
      Top = 169
      Width = 10
      Height = 13
      Caption = 'X:'
    end
    object txtFind: TEdit
      Left = 16
      Top = 40
      Width = 201
      Height = 21
      TabOrder = 0
      Text = 'txtFind'
    end
    object txtOcc: TEdit
      Left = 93
      Top = 67
      Width = 121
      Height = 21
      Alignment = taRightJustify
      NumbersOnly = True
      TabOrder = 1
      Text = '0'
    end
    object txtH2: TEdit
      Left = 215
      Top = 161
      Width = 29
      Height = 21
      NumbersOnly = True
      TabOrder = 2
      Text = 'txtH'
    end
    object txtW2: TEdit
      Left = 159
      Top = 161
      Width = 33
      Height = 21
      NumbersOnly = True
      TabOrder = 3
      Text = 'txtW'
    end
    object txtY2: TEdit
      Left = 101
      Top = 161
      Width = 32
      Height = 21
      NumbersOnly = True
      TabOrder = 4
      Text = 'txtY'
    end
    object txtX2: TEdit
      Left = 45
      Top = 161
      Width = 30
      Height = 21
      NumbersOnly = True
      TabOrder = 5
      Text = 'txtX'
    end
    object Button1: TButton
      Left = 16
      Top = 107
      Width = 225
      Height = 25
      Caption = 'Search text'
      TabOrder = 6
      OnClick = Button1Click
    end
  end
  object GroupBox2: TGroupBox
    Left = 24
    Top = 602
    Width = 257
    Height = 95
    Caption = 'Click on found text '
    TabOrder = 14
    object comboClick: TComboBox
      Left = 16
      Top = 32
      Width = 98
      Height = 21
      TabOrder = 0
      Text = 'comboClick'
      Items.Strings = (
        'Single'
        'Double')
    end
    object comboBtn: TComboBox
      Left = 139
      Top = 32
      Width = 94
      Height = 21
      TabOrder = 1
      Text = 'comboBtn'
      Items.Strings = (
        'Left'
        'Middle'
        'Right')
    end
    object Button2: TButton
      Left = 15
      Top = 59
      Width = 218
      Height = 25
      Caption = 'Click Text'
      TabOrder = 2
      OnClick = Button2Click
    end
  end
end
