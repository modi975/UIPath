object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 340
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
    Top = 128
    Width = 225
    Height = 72
    Lines.Strings = (
      'txtID')
    ScrollBars = ssVertical
    TabOrder = 2
  end
  object GroupBox2: TGroupBox
    Left = 24
    Top = 226
    Width = 257
    Height = 95
    Caption = 'Click on found text '
    TabOrder = 3
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
