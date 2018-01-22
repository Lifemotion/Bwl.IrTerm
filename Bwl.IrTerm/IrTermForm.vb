Imports System.IO.Ports

Public Class IrTermForm
    Private regSettings As New RegistryStorage
    Private regPortName As RegistryStorage.Setting = regSettings.CreateSetting("PortName", "")
    Private WithEvents port As New IO.Ports.SerialPort

    Private Sub IrTermForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        portsRefresh_Tick()
        Dim thread As New Threading.Thread(AddressOf ReadThread)
        thread.IsBackground = True
        thread.Start()
        Try
            Text += " " + Application.ProductVersion + " (" + IO.File.GetLastWriteTime(Application.ExecutablePath).ToString + ")"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ReadThread()
        Do
            Try
                Dim line = port.ReadLine.Trim
                Dim filteredLine = ""
                For Each ch In line
                    If ch >= " " AndAlso ch < "~" Then
                        filteredLine += ch
                    End If
                Next
                Me.Invoke(Sub()
                              If cbFilter.Checked Then line = filteredLine.Trim
                              If line.Length > 0 Then
                                  If cbAddTime.Checked Then line = Now.ToLongTimeString + ": " + line
                                  If cbWriteLog.Checked Then
                                      IO.File.AppendAllLines(Application.StartupPath + "\log.txt", {line})
                                  End If
                                  tbResults.Text += line + vbCrLf
                                  tbResults.SelectionStart = tbResults.Text.Length
                                  tbResults.ScrollToCaret()
                              End If
                          End Sub)
            Catch ex As Exception
            End Try
            Threading.Thread.Sleep(1)
        Loop
    End Sub

    Private Sub portsRefresh_Tick() Handles portsRefresh.Tick
        Static portnameCount As Integer

        Dim ports = SerialPort.GetPortNames
        If ports.Length <> portnameCount Then
            portnameCount = ports.Length
            Dim items = New List(Of String)

            For Each item In cbPorts.Items
                items.Add(item)
            Next

            For Each item In items
                If ports.Contains(item) = False Then cbPorts.Items.Remove(item)
            Next

            For Each item In ports
                If cbPorts.Items.Contains(item) = False Then cbPorts.Items.Add(item)
            Next

            If cbPorts.Items.Count = 0 Then
                cbPorts.Text = ""
            Else
                If cbPorts.Text = "" Then cbPorts.Text = regPortName.Value
            End If
        End If

        Try
            cbConnect.Checked = port.IsOpen
        Catch ex As Exception
            port.Write("1")
            cbConnect.Checked = False
            MsgBox("Port was disconnected")
            Try
                port.Close()
            Catch ex1 As Exception
            End Try
        End Try
        If cbConnect.Checked Then
            tbResults.BackColor = Color.LightGreen
        Else
            tbResults.BackColor = Color.Pink
        End If
    End Sub

    Private Sub cbConnect_CheckedChanged(sender As Object, e As EventArgs) Handles cbConnect.CheckedChanged
        If cbConnect.Checked Then
            If cbPorts.Text = "" Then
                cbConnect.Checked = False
            Else
                Try
                    If port.IsOpen Then port.Close()
                    port.PortName = cbPorts.Text
                    regPortName.Value = port.PortName
                    port.BaudRate = 2400
                    port.Open()
                Catch ex As Exception
                    MsgBox("Port Open failed: " + ex.Message, vbExclamation)
                End Try
            End If
        Else
            If port.IsOpen Then port.Close()
        End If
    End Sub

    Private Sub port_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles port.DataReceived

    End Sub

    Private Sub bCclear_Click(sender As Object, e As EventArgs) Handles bCclear.Click
        tbResults.Text = ""
    End Sub
End Class
