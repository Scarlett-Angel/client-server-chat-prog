Option Strict On
Imports System.Threading
Imports EPWinSock.v4.BASE
Imports System.Threading.Tasks
Imports System.Drawing


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
        ServerSock.SendMessage("ConEstablished;", SocketID)

    End Sub

    Private Sub ServerSock_AClientDisconnected(ByVal SocketID As Integer) Handles ServerSock.AClientDisconnected
        If Me.lsvClientList.Items.ContainsKey(SocketID.ToString()) Then
            Me.lsvClientList.Items.RemoveByKey(SocketID.ToString())
        End If

        For Each user As user In users
            If user.socket = SocketID Then
                If user.hidden = False Then
                    sendToAll("offline;" + user.username)
                End If
            End If
        Next
        Dim theuser As user
        For Each user As user In users
            If user.socket = SocketID Then
                theuser = user
            End If
        Next
        users.Remove(theuser)
    End Sub
    Private Function getClientName(ByVal clientid As Integer) As String
        For Each user As user In users
            If user.socket = clientid Then
                Return user.username
            End If
        Next
    End Function
    Private Function getClientId(ByVal clientname As String) As Integer
        For Each user As user In users
            If user.username = clientname Then
                Return user.socket
            End If
        Next
    End Function
    Private Sub sendToAll(ByVal message As String)

        For Each user As user In users
            Dim thesocket As Integer
            thesocket = user.socket

            ServerSock.SendMessage(message, user.socket)
        Next
    End Sub
    Private Function createOnlineList() As String
        Dim sb As New System.Text.StringBuilder()
        Dim themessage As String
        sb.Append("online;")
        For Each user As user In users
            If user.hidden = False Then
                sb.Append(user.username)
            End If
            themessage = sb.ToString
            Return themessage
        Next
    End Function
#Region "Loggings"

    Private Sub ServerSock_DataReceived(SckData() As Byte, senderSocketID As Integer) Handles ServerSock.DataReceived
        Dim fromname As String = getClientName(senderSocketID)
        Me.lstLogs.Items.Add(
            String.Format("Client [{1}] Encoded Message: {0}",
                          System.Text.UTF32Encoding.UTF32.GetString(SckData),
                          senderSocketID)
            )
        Me.lstLogs.SelectedIndex = Me.lstLogs.Items.Count - 1

        ServerSock.SendMessage("Got an Encoded Message using UTF32 at " & Now.ToString, senderSocketID)
        Dim themessage() As String

        themessage = Split(System.Text.UTF32Encoding.UTF32.GetString(SckData), ";", Limit:=-1)
        If themessage(0).Equals("connect") Then
            Dim hidden As Boolean = False
            Dim username As String = themessage(1)
            If themessage(2).Equals("hidden") Then
                hidden = True

            End If
            Dim currentuser As New user(username, hidden, senderSocketID)
            users.Add(currentuser)
            ServerSock.SendMessage("Client added to list", senderSocketID)

            If hidden = False Then

            End If
        End If
        If themessage(0).Equals("all") Then
            Dim messageToAll As String = "from;" + fromname + ";" + themessage(1)
            sendToAll(messageToAll)
        End If
        If themessage(0).Equals("to") Then
            Dim toId As Integer = getClientId(themessage(1))
            ServerSock.SendMessage("whisper;" + fromname + ";" + themessage(2), toId)
        End If
        If themessage(0).Equals("update-list") Then
            Dim messageToAll As String = createOnlineList()
            sendToAll(messageToAll)
        End If


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
