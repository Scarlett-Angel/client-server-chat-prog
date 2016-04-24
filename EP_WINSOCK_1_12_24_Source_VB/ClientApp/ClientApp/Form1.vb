Imports EPWinSock.v4.BASE

Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClientSock.Start()
        Dim username As String
        username = txt_username.Text
        Dim password As String
        password = txt_password.Text
        Dim message As String
        message = “connect;" + username + ";" + password
        ClientSock.SendData(System.Text.UTF32Encoding.UTF32.GetBytes(message))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClientSock.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '需要更多sent功能
        Dim sendingmessage As String
        sendingmessage = TextBox1.Text
        Dim messageall() As String

        Split()
        'If Left(sendingmessage, 1) = "@" Then


        ' ClientSock.SendMessage(TextBox1.Text)

        ClientSock.SendData(System.Text.UTF32Encoding.UTF32.GetBytes(TextBox1.Text))
        TextBox1.Text = String.Empty

    End Sub

    Private Sub EpWinSock1_MessageReceived(ByVal SckMessage As String, ByVal senderSocketID As Integer) Handles ClientSock.MessageReceived
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

    Private Sub txt_towhom_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
