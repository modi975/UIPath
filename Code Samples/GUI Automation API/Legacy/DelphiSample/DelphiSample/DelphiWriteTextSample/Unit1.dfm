object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 413
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
    Top = 72
    Width = 77
    Height = 13
    Caption = 'Window handle:'
  end
  object Label2: TLabel
    Left = 40
    Top = 101
    Width = 56
    Height = 13
    Caption = 'Window ID:'
  end
  object Label3: TLabel
    Left = 40
    Top = 197
    Width = 195
    Height = 13
    Caption = 'You can  manually change the Control ID'
  end
  object btnSelWnd: TButton
    Left = 39
    Top = 25
    Width = 225
    Height = 25
    Caption = 'Select a control'
    TabOrder = 0
    OnClick = btnSelWndClick
  end
  object txtHandle: TEdit
    Left = 143
    Top = 69
    Width = 121
    Height = 21
    Alignment = taRightJustify
    TabOrder = 1
  end
  object txtID: TMemo
    Left = 39
    Top = 120
    Width = 225
    Height = 72
    Lines.Strings = (
      'txtID')
    ScrollBars = ssVertical
    TabOrder = 2
  end
  object GroupBox1: TGroupBox
    Left = 40
    Top = 216
    Width = 224
    Height = 81
    Caption = 'Choose a writing method '
    TabOrder = 3
    object radioKeys: TRadioButton
      Left = 16
      Top = 24
      Width = 113
      Height = 17
      Caption = 'Send keys method'
      Checked = True
      TabOrder = 0
      TabStop = True
    end
    object radioAPI: TRadioButton
      Left = 16
      Top = 47
      Width = 113
      Height = 17
      Caption = 'Control API method'
      TabOrder = 1
    end
  end
  object GroupBox2: TGroupBox
    Left = 39
    Top = 303
    Width = 225
    Height = 105
    Caption = 'Write text '
    TabOrder = 4
    object txtWrite: TMemo
      Left = 17
      Top = 24
      Width = 185
      Height = 41
      Lines.Strings = (
        'txtWrite')
      TabOrder = 0
    end
    object Button1: TButton
      Left = 72
      Top = 71
      Width = 75
      Height = 25
      Caption = 'Write text'
      TabOrder = 1
      OnClick = Button1Click
    end
  end
end
