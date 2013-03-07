unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, TCaptureXLib_TLB, TSelectionLib_TLB, UIElementLib_TLB;

type
  TForm1 = class(TForm)
    btnSelWnd: TButton;
    Label1: TLabel;
    txtHandle: TEdit;
    Label2: TLabel;
    txtID: TMemo;
    GroupBox2: TGroupBox;
    comboClick: TComboBox;
    comboBtn: TComboBox;
    Button2: TButton;

    procedure FormCreate(Sender: TObject);
    procedure btnSelWndClick(Sender: TObject);
    procedure ManageError(exception : Exception);
    procedure Button2Click(Sender: TObject);
    function GetClickFlags() : Integer;

  private
    { Private declarations }

     m_tCapture: TextCaptureX;
     m_tSelection: ITSelection;
     m_tAAText : GetAAText;
     m_tOCR : GetOCRText;


  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}


procedure TForm1.ManageError(exception: Exception);
  var
    strWideCharErr : PWideChar;
    strWideCharTitle : PWideCHar;
    strTCXTitle : string;
begin
   strTCXTitle := 'Text Capture X Delphi Sample';

   GetMem(strWideCharErr, sizeof(WideChar) * (length(exception.Message) + 1));
   GetMem(strWideCharTitle, sizeof(WideChar) * (length(strTCXTitle) + 1));

   StringToWideChar(exception.Message, strWideCharErr, length(exception.message) + 1);
   StringToWideChar(strTCXTitle, strWideCharTitle, length(strTCXTitle) + 1);

   MessageBox(0, strWideCharErr, strWideCharTitle, 0);

   FreeMem(strWideCharErr);
   FreeMem(strWideCharTitle);
end;

procedure TForm1.btnSelWndClick(Sender: TObject);
  var
    tSelInfo: IDispatch;
    tSelInfo2 : ITSelectionInfo;
    uiElem : IUIElem;

begin
       Form1.Visible := false;

       try
          tSelInfo := m_tSelection.Start(tsSelectionUIelement, tsSelFlagDefaultText);
          tSelInfo.QueryInterface(IID_ITSelectionInfo, tSelInfo2);

       except
          on E: exception do
             begin
                 ManageError(E);
                 exit;
            end;
       end;

       Sleep(200);

       Form1.Visible := true;

       txtID.Text := tSelInfo2.UIElementID;
       txtHandle.Text := IntToStr(tSelInfo2.WindowHandle);

       if (tSelInfo2.UIElementID = '') then
        begin

            try
                uiElem := CoUIElem.Create;
                uiElem.hwnd := tSelInfo2.WindowHandle;

                txtID.Text := uiElem.GetID(true);
            except
                on E: exception do
                    begin
                       ManageError(E);
                       exit;
                    end;
            end;
        end;
end;

procedure TForm1.Button2Click(Sender: TObject);
var
    x, y, flags, x2, y2 : Integer;
    uiElement : UIElem;
begin
    try
        uiElement := CoUIElem.Create;
        uiElement.InitializeFromID(txtID.Text, false);
        uiElement.UseClientCoordinates := true;

        uiElement.GetRectangle(x, y, x2, y2);

        flags := GetClickFlags();

        uiElement.Click(x + 2, y + 2, flags);

    except
         on E: exception do
            begin
                ManageError(E);
                Exit;
            end;
    end;
end;

procedure TForm1.FormCreate(Sender: TObject);

begin
      try
           m_tSelection := CoTSelection.Create;
           m_tCapture := CoTextCaptureX.Create;
           m_tAAText := CoGetAAText.Create;
           m_tOCR := CoGetOCRText.Create;
      except
           on E: exception do
             begin
                 ManageError(E);
                 exit;
            end;
      end;
      comboBtn.Text := 'Left';
      comboClick.Text := 'Single';
end;

function TForm1.GetClickFlags : Integer;
var
    retval : Integer;
begin
    retval := UIE_CF_MOVE_CURSOR;

    if comboClick.Text = 'Single' then
      retval := retval or UIE_CF_SINGLE
    else if comboClick.Text = 'Double' then
      retval := retval or UIE_CF_DOUBLE;

    if comboBtn.Text = 'Left' then
      retval := retval or UIE_CF_LEFT
    else if comboBtn.Text = 'Middle' then
      retval := retval or UIE_CF_MIDDLE
    else if comboBtn.Text = 'Right' then
      retval := retval or UIE_CF_RIGHT;

    GetClickFlags := retval;

end;

end.

