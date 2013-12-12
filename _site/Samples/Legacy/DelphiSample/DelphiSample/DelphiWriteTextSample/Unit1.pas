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
    GroupBox1: TGroupBox;
    radioKeys: TRadioButton;
    radioAPI: TRadioButton;
    GroupBox2: TGroupBox;
    txtWrite: TMemo;
    Button1: TButton;
    Label3: TLabel;

    procedure FormCreate(Sender: TObject);
    procedure btnSelWndClick(Sender: TObject);
    procedure ManageError(exception : Exception);
    procedure Button1Click(Sender: TObject);

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

procedure TForm1.Button1Click(Sender: TObject);
var
    uiElement : UIElem;

begin
    try
          uiElement := CoUIElem.Create;
          uiElement.InitializeFromID(txtID.text, false);

          if radioAPI.Checked = true then
              begin
                 uiElement.WriteText(UIE_WTM_NATIVE, txtWrite.Text);
              end
          else if radioKeys.Checked = true then
              begin
                 uiElement.WriteText(UIE_WTM_SENDKEYS, txtWrite.Text);
              end;

    except
        on E: exception do begin
            ManageError(E);
            Exit ;
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
end;

end.

