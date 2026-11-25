open System
open System.Windows.Forms

// TODO (Teammate 3): Build WinForms panels (pnlLogin, pnlAdmin, pnlQuiz) wired via Observable.scan
[<STAThread>]
[<EntryPoint>]
let main _ =
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)
    MessageBox.Show("UI TODO: Implement WinForms panels in Program.fs") |> ignore
    0
