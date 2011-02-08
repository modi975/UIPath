unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, TCaptureXLib_TLB, TSelectionLib_TLB, UIElementLib_TLB;

type
  TForm1 = class(TForm)
    btnCapture: TButton;
    txtResult: TMemo;
    btnSelReg: TButton;
    btnSelWnd: TButton;
    Label1: TLabel;
    txtHandle: TEdit;
    Label2: TLabel;
    Label3: TLabel;
    txtX: TEdit;
    txtY: TEdit;
    Label4: TLabel;
    Label5: TLabel;
    txtW: TEdit;
    Label6: TLabel;
    txtH: TEdit;
    Label7: TLabel;
    radioNative: TRadioButton;
    radioFull: TRadioButton;
    radioOCR: TRadioButton;
    comboEngine: TComboBox;
    comboLang: TComboBox;
    checkLayout: TCheckBox;
    Label8: TLabel;
    checkID: TCheckBox;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    txtID: TMemo;


    procedure btnCaptureClick(Sender: TObject);
    procedure btnSelRegClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnSelWndClick(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure checkLayoutClick(Sender: TObject);
    procedure ManageError(exception : Exception);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);

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

procedure TForm1.btnCaptureClick(Sender: TObject);
  var
     strResult : string;
     hwnd, x, y, width, height : Integer;
     strLang : string;
     uiElem : IUIElem;
     left, top, w, h : integer;


begin
      if (checkID.Checked = true) then
          begin
              uiElem := CoUIElem.Create;
              uiElem.InitializeFromID(txtID.Text, false);
              hwnd := uiElem.hwnd;
          end
      else
          hwnd := StrToInt(txtHandle.Text);

      x := StrToInt(txtX.Text);
      y := StrToInt(txtY.Text);
      width := StrToInt(txtW.Text);
      height := StrToInt(txtH.Text);

      try
            if radioNative.checked = true then
              strResult := m_tCapture.GetTextFromRect(hwnd, x, y, width, height)

            else if radioFull.Checked = true then
              strResult :=  m_tAAText.GetFullTextFromRectangle(hwnd, x, y, width, height)

            else if radioOCR.Checked = true then
                 begin
                      strLang := comboLang.Text;
                      {translate the rectangle to client coordinates}
                      uiElem := CoUIelem.Create;
                      uiElem.hwnd := hwnd;
                      uiElem.GetRectangle(left, top, w, h);
                      x := x - left;
                      y := y - top;
                      strResult  := m_tOCR.GetTextFromRect(hwnd, x, y, width, height, strLang, false);
                 end;

      except
            On E: Exception do
            begin
                 ManageError(E);
                 exit;
            end;
      end;


      txtresult.Text := strResult;
end;

procedure TForm1.btnSelRegClick(Sender: TObject);
var
  tSelInfo: IDispatch;
  tSelInfo2 : TSelectionInfo;
  uiElem: IUIElem;
  points : OleVariant;
  point1, point2, x1, y1, x2, y2: Integer;
  finalX, finalY, height, width: Integer;

begin

    try
        tSelInfo := m_tSelection.Start(tsSelectionRectangle, tsSelFlagDefaultText);
    except
      On E: exception do
          begin
                 ManageError(E);
                 exit;
            end;
    end;

    tSelInfo.QueryInterface(IID_ITSelectionInfo, tSelInfo2) ;
    txtHandle.Text := IntToStr(tSelInfo2.WindowHandle);

    try
        uiElem := CoUIElem.Create;
        uiElem.hwnd := tSelInfo2.WindowHandle;

        txtID.Text := uiElem.GetID(TRUE);
    except
        on E: exception do
           begin
                 ManageError(E);
                 exit;
            end;
    end;

    points := tSelInfo2.Points;
    point1 := VarArrayGet(points, [0]);
    point2 := VarArrayGet(points, [1]);

    x1 := LoWord(point1);
    y1 := HiWord(point1);

    x2 := LoWord(point2);
    y2 := HiWord(point2);

    if (x1 > x2) then
      begin
        finalX := x2;
        width := x1 - x2;
      end
    else
      begin
        finalX := x1;
        width := x2 - x1;
      end;

    if (y1 > y2) then
      begin
        finalY := y2;
        height := y1 - y2;
      end
    else
      begin
        finalY := y1;
        height := y2 - y1;
      end;


    txtX.Text := IntToStr(finalX);
    txtY.Text := IntToStr(finalY);
    txtW.Text := IntToStr(width);
    txtH.Text := IntToStr(height);

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
            txtID.Text := 'A valid ID could not be generated';
        end
        else
          begin
            try
                uiElem := CoUIElem.Create;
                uiElem.InitializeFromID(tSelInfo2.UIElementID, false);
            except
                on E: exception do
                    begin
                       ManageError(E);
                       exit;
                    end;
            end;
          end;

       txtX.Text := '0';
       txtY.Text := '0';
       txtW.Text := '0';
       txtH.Text := '0';
end;

procedure TForm1.Button3Click(Sender: TObject);
  var
      uiElem : IUIElem;
      strText, strLang : string;
      hwnd : Integer;

begin
      uiElem := CoUIElem.Create;

      try
          uiElem := CoUIElem.Create;
          if (checkID.Checked = true) then
              begin
                uiElem.InitializeFromID(txtID.Text, false);
              end
          else
              begin
                  hwnd := StrToInt(txtHandle.Text);
                  uiElem.hwnd := hwnd;
              end;
      except
          on E: exception do
              begin
                 ManageError(E);
                 exit;
              end;
      end;

      try
          if radioNative.checked = true then
              strText := m_tCapture.GetTextFromUIElem(uiElem)

            else if radioFull.Checked = true then
              strText :=  m_tAAText.GetFullTextFromUIElem(uiElem)

            else if radioOCR.Checked = true then
                 begin
                      strLang := comboLang.Text;
                      strText  := m_tOCR.GetTextFromUIElem(uiElem, strLang, false);
                 end;
      except
          on E: exception do begin
              strText := 'Capture Error!';
              ManageError(E);
              exit;
          end;
      end;

      txtResult.Text := strtext;

end;

procedure TForm1.Button4Click(Sender: TObject);
  var
      hwnd : Integer;

begin
      try
          Form1.Visible := false;
          Sleep (100);
          hwnd := m_tCapture.GetActiveWindowHwnd;
          txtResult.Text := m_tCapture.CaptureWindow(hwnd);
          Sleep (100);
          Form1.Visible := true;

      except
        on E: Exception do
          begin
            ManageError(E);
            exit;
          end;

      end;
end;

procedure TForm1.Button5Click(Sender: TObject);
var
    x, y, hwnd : Integer;
    strResult : string;
begin
    hwnd := StrToInt(txtHandle.Text);
    x := StrToInt(txtX.Text);
    y := StrToInt(txtY.Text);

    try
        strResult := m_tCapture.GetTextFromPoint(hwnd, x, y);
        txtResult.Text := strResult;

    except
        on E: Exception do
          begin
            ManageError(E);
            exit;
          end;

    end;
end;

procedure TForm1.checkLayoutClick(Sender: TObject);
begin
    m_tCapture.FormattedText := checkLayout.Checked;
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
      comboEngine.Items.Add('Internal');
      comboLang.Items.Add('eng');
      comboLang.Items.Add('deu');
      comboLang.Items.Add('spa');
      comboLang.Items.Add('nld');

      comboLang.SelText := '';
      comboEngine.SelText := '';

      radioNative.Checked := true;
end;

end.

