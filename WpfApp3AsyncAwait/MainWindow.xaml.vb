Imports System
Imports System.Threading.Thread
Imports System.Threading.Tasks
'синхронно
' в одно и тоже время с чем-либо; одновременно



Class MainWindow
	Private Sub mysub()
		fffAsync()
		MsgBox("ready")
	End Sub
	Private Async Sub fffAsync() 'асинхронный; не одновременно; в разные моменты времени, разновременно
		Await Task.Run(Sub() Threading.Thread.Sleep(9000))
		MsgBox("End fffAsync")
	End Sub
End Class
