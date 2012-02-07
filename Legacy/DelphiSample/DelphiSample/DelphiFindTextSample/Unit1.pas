unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, TCaptureXLib_TLB, TSelectionLib_TLB, UIElementLib_TLB;

type
  TForm1 = class(TForm)
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
    radioOCR: TRadioButton;
    comboEngine: TComboBox;
    comboLang: TComboBox;
    checkLayout: TCheckBox;
    txtID: TMemo;
    Label8: TLabel;
    GroupBox1: TGroupBox;
    Label9: TLabel;
    txtFind: TEdit;
    Label10: TLabel;
    txtOcc: TEdit;
    Label11: TLabel;
    txtH2: TEdit;
    txtW2: TEdit;
    txtY2: TEdit;
    txtX2: TEdit;
    Label12: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    Button1: TButton;
    GroupBox2: TGroupBox;
    comboClick: TComboBox;
    comboBtn: TComboBox;
    Button2: TButton;

    procedure btnSelRegClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnSelWndClick(Sender: TObject);
    procedure checkLayoutClick(Sender: TObject);
    procedure ManageError(exception : Exception);
    procedure Button1Click(Sender: TObject);
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

    {translate to client coordinates}
    uiElem.GetRectangle(x1, y1, x2, y2);
    finalX := finalX - x1;
    finalY := finalY - y1;

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
    x1, y1, x2, y2: Integer;

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
        end
       else
          begin
            uiElem := CoUIElem.Create;
            uiElem.InitializeFromID(txtID.Text, false);
          end;

       uiElem.GetRectangle(x1, y1, x2, y2);

       txtX.Text := '0';
       txtY.Text := '0';
       txtW.Text := IntToStr(x2 - x1);
       txtH.Text := IntToStr(y2 - y1);
end;

procedure TForm1.Button1Click(Sender: TObject);
var
    x1, y1, width, height, x2, y2 : Integer;
    uiElement : UIElem;
    rectangle, targetRect : rect;

begin

    x1 := StrToInt(txtX.Text);
    y1 := StrToInt(txtY.Text);
    width := StrToInt(txtW.Text);
    height := StrToInt(txtH.Text);

    try

        m_tCapture.UseClientCoordinates := true;

        uiElement := CoUIElem.Create;
        uiElement.InitializeFromID(txtID.Text, false);

        targetRect := CoRect.Create;
        targetRect.RLeft := x1;
        targetRect.RTop := y1;
        targetRect.RRight := x1 + width;
        targetRect.RBottom := y1 + height;

        if (radioNative.checked = true) then
            rectangle := m_tCapture.GetRectFromText(uiElement.hwnd, txtFind.Text, targetRect, StrToInt(txtOcc.Text))
        else
            rectangle := m_tOCR.GetRectFromText(uiElement.hwnd, txtFind.Text, targetRect, comboLang.Text, false, StrToInt(txtOcc.texT));

        txtX2.Text := IntToStr(rectangle.RLeft);
        txtY2.Text := IntToStr(rectangle.Rtop);
        txtH2.Text := IntToStr(rectangle.height);
        txtW2.Text := IntToStr(rectangle.width);

    except
      on E: exception do
        begin
            ManageError(E);
            Exit;
        end;

    end;
end;

procedure TForm1.Button2Click(Sender: TObject);
var
    x, y, flags : Integer;
    uiElement : UIElem;
begin
    x := StrToInt(txtX2.Text);
    y := StrToInt(txtY2.Text);

    try

        uiElement := CoUIElem.Create;
        uiElement.InitializeFromID(txtID.Text, false);

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

