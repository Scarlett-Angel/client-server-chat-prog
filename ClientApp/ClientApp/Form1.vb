Imports EPWinSock.v4.BASE

Public Class Form1
    Public usersOnline As New List(Of String)()
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClientSock.Start()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClientSock.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim themessage As String
        Dim thetarget As Boolean
        thetarget = String.IsNullOrWhiteSpace(TextBox3.Text)
        If thetarget = True Then
            themessage = "all;" + TextBox1.Text
        Else
            themessage = "to;" + TextBox3.Text + ";" + TextBox1.Text
        End If

        ClientSock.SendData(System.Text.UTF32Encoding.UTF32.GetBytes(themessage))
        TextBox1.Text = String.Empty

    End Sub

    Private Sub EpWinSock1_MessageReceived(ByVal SckMessage As String, ByVal senderSocketID As Integer) Handles ClientSock.MessageReceived
        Dim themessage() As String
        themessage = Split(SckMessage, ";", Limit:=-1)

        If themessage(0) = "ConEstablished" Then

            Dim username As String
            Dim connected As Boolean
            connected = False

            username = TextBox2.Text
            Dim message As String
            message = “connect;" + username + ";" + If(CheckBox1.Checked = True, "hidden", "visible")
            ClientSock.SendData(System.Text.UTF32Encoding.UTF32.GetBytes(message))
        End If
        If themessage(0) = "from" Then
            Me.ListBox2.Items.Add(
            String.Format("[{0}] Shouts: {1}", themessage(1), themessage(2))
            )
        End If
        If themessage(0) = "enters" Then
            Me.ListBox2.Items.Add(
            String.Format("[{0}] Enters the Rooms", themessage(1))
            )
        End If
        If themessage(0) = "Client added to list" Then
            ClientSock.SendData(System.Text.UTF32Encoding.UTF32.GetBytes("update-list"))
        End If
        If themessage(0) = "online" Then
            For Each useronline In themessage
                Dim userfound As Boolean = False
                If useronline <> "online" Then
                    For Each user As String In usersOnline
                        If user = useronline Then
                            userfound = True
                        End If
                    Next
                    If userfound = False Then
                        usersOnline.Add(useronline)
                    End If
                End If
            Next
            ListBox3.Items.Clear()
            For Each user As String In usersOnline

                Me.ListBox3.Items.Add(user)

            Next
        End If
        Me.ListBox1.Items.Add(
            String.Format("Server [{1}] Message: {0}", SckMessage, senderSocketID)
            )

        REM Push the last text to current view
        Me.ListBox1.SelectedIndex = Me.ListBox1.Items.Count - 1

    End Sub

    Private Sub EpWinSock1_SocketErrorMessage(ByVal SckMessage As String) Handles ClientSock.SocketErrorMessage
        Me.ListBox1.Items.Add(
      String.Format("Server {0}", SckMessage)
      )

        REM Push the last text to current view
        Me.ListBox1.SelectedIndex = Me.ListBox1.Items.Count - 1
    End Sub

    Private Sub EpWinSock1_SocketIDChanged() Handles ClientSock.SocketIDChanged

        Me.Text = "Client App - " & ClientSock.SocketID

    End Sub

    Private Sub EpWinSock1_SocketLogMessage(ByVal sckLog As String) Handles ClientSock.SocketLogMessage
        Me.ListBox1.Items.Add(
     String.Format("Server {0}", sckLog)
     )

        REM Push the last text to current view
        Me.ListBox1.SelectedIndex = Me.ListBox1.Items.Count - 1
    End Sub

    Private Sub EpWinSock1_SocketStateChanged(ByVal CurrentState As SocketConnectionState, ByVal DebugMessage As String) Handles ClientSock.SocketStateChanged
        Me.ListBox1.Items.Add(
     String.Format("Server {0}", DebugMessage)
     )

        REM Push the last text to current view
        Me.ListBox1.SelectedIndex = Me.ListBox1.Items.Count - 1


        If CurrentState = SocketConnectionState.Disconnected Then Me.Text = "Client App"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
