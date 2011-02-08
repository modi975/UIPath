program DelphiDemo;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  TCaptureXLib_TLB in '..\..\..\Documents\RAD Studio\7.0\Imports\TCaptureXLib_TLB.pas',
  TSelectionLib_TLB in '..\..\..\Documents\RAD Studio\7.0\Imports\TSelectionLib_TLB.pas',
  UIElementLib_TLB in '..\..\..\Documents\RAD Studio\7.0\Imports\UIElementLib_TLB.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
