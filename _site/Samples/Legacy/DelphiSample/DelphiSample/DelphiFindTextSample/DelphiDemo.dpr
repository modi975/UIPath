program DelphiDemo;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  TCaptureXLib_TLB in 'TCaptureXLib_TLB.pas',
  TSelectionLib_TLB in 'TSelectionLib_TLB.pas',
  UIElementLib_TLB in 'UIElementLib_TLB.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
