Option Strict On
Imports System.Collections.Generic
Imports EPWinSock.v4.BASE


Public Class Form1
    Public users As New List(Of user)()

    Private Sub btnGoOnline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoOnline.Click
        ServerSock.Start()

    End Sub

    Private Sub btnGoOffline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoOffline.Click
        ServerSock.Stop()
    End Sub


    Private Sub ServerSock_AClientConnected(ByVal SocketID As Integer) Handles ServerSock.AClientConnected
        REM Populate the Client List Box
        Dim ClientInfo As EPWinSock.v4.Utilities.PCInfo = ServerSock.getClient(SocketID)
        With ClientInfo
            Dim lsvItem As New ListViewItem(
                                New String() {.ID.ToString(), .AnyIPAddress, .AnyMacAddress,
                                             .OperatingSystem
                                            }
                                        )
            lsvItem.Name = SocketID.ToString() REM for reference purpose
            Me.lsvClientList.Items.Add(lsvItem)
        End With

    End Sub

    Private Sub ServerSock_AClientDisconnected(ByVal SocketID As Integer) Handles ServerSock.AClientDisconnected
        If Me.lsvClientList.Items.ContainsKey(SocketID.ToString()) Then
            Me.lsvClientList.Items.RemoveByKey(SocketID.ToString())
        End If
    End Sub

#Region "Loggings"

    Private Sub ServerSock_DataReceived(SckData() As Byte, senderSocketID As Integer) Handles ServerSock.DataReceived
        Dim message() As String
        message = Split(";", System.Text.UTF32Encoding.UTF32.GetString(SckData), Limit:=1)
        If message(0) = "connect" Then
            Dim username As String = message(1)
            Dim password As String = message(2)
            Dim hidden As Boolean = message(3) = "hiding"
            Dim currentuser As New user(username, hidden, senderSocketID)
            users.Add(currentuser)


        End If


        Me.lstLogs.Items.Add(
            String.Format("Client [{1}] Encoded Message: {0}",
                          System.Text.UTF32Encoding.UTF32.GetString(SckData),
                          senderSocketID)
            )
        Me.lstLogs.SelectedIndex = Me.lstLogs.Items.Count - 1

        ServerSock.SendMessage("Got an Encoded Message using UTF32 at " & Now.ToString, senderSocketID)
    End Sub

    Private Sub EpWinSock1_MessageReceived(ByVal SckMessage As String, ByVal senderSocketID As Integer) Handles ServerSock.MessageReceived
        Me.lstLogs.Items.Add(
            String.Format("Client [{1}] Message: {0}", SckMessage, senderSocketID)
            )
        Me.lstLogs.SelectedIndex = Me.lstLogs.Items.Count - 1

        ServerSock.SendMessage("Got It at " & Now.ToString, senderSocketID)

    End Sub

    Private Sub EpWinSock1_SocketErrorMessage(ByVal SckMessage As String) Handles ServerSock.SocketErrorMessage
        Me.lstLogs.Items.Add(
          String.Format("Error Message: {0}", SckMessage)
          )
        Me.lstLogs.SelectedIndex = Me.lstLogs.Items.Count - 1
    End Sub

    Private Sub EpWinSock1_SocketLogMessage(ByVal sckLog As String) Handles ServerSock.SocketLogMessage
        Me.lstLogs.Items.Add(
         String.Format("Log: {0}", sckLog)
         )
        Me.lstLogs.SelectedIndex = Me.lstLogs.Items.Count - 1
    End Sub

    Private Sub EpWinSock1_SocketStateChanged(ByVal CurrentState As SocketConnectionState, ByVal DebugMessage As String) Handles ServerSock.SocketStateChanged
        Me.lstLogs.Items.Add(
         String.Format("Status Changed: {0}", DebugMessage)
         )
        Me.lstLogs.SelectedIndex = Me.lstLogs.Items.Count - 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region


End Class
