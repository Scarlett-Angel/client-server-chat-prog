<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnGoOnline = New System.Windows.Forms.Button()
        Me.btnGoOffline = New System.Windows.Forms.Button()
        Me.lstLogs = New System.Windows.Forms.ListBox()
        Me.lsvClientList = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServerSock = New EPWinSock.v4.NET.ServerSocket(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.colClientID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIPAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMacAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnGoOnline
        '
        Me.btnGoOnline.Location = New System.Drawing.Point(293, 22)
        Me.btnGoOnline.Name = "btnGoOnline"
        Me.btnGoOnline.Size = New System.Drawing.Size(146, 36)
        Me.btnGoOnline.TabIndex = 0
        Me.btnGoOnline.Text = "Go Online"
        Me.btnGoOnline.UseVisualStyleBackColor = True
        '
        'btnGoOffline
        '
        Me.btnGoOffline.Location = New System.Drawing.Point(445, 22)
        Me.btnGoOffline.Name = "btnGoOffline"
        Me.btnGoOffline.Size = New System.Drawing.Size(146, 36)
        Me.btnGoOffline.TabIndex = 0
        Me.btnGoOffline.Text = "Go Offline"
        Me.btnGoOffline.UseVisualStyleBackColor = True
        '
        'lstLogs
        '
        Me.lstLogs.FormattingEnabled = True
        Me.lstLogs.ItemHeight = 22
        Me.lstLogs.Location = New System.Drawing.Point(19, 64)
        Me.lstLogs.Name = "lstLogs"
        Me.lstLogs.Size = New System.Drawing.Size(570, 136)
        Me.lstLogs.TabIndex = 1
        '
        'lsvClientList
        '
        Me.lsvClientList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colClientID, Me.colIPAddress, Me.colMacAddress, Me.colOS})
        Me.lsvClientList.Location = New System.Drawing.Point(19, 277)
        Me.lsvClientList.Name = "lsvClientList"
        Me.lsvClientList.Size = New System.Drawing.Size(572, 136)
        Me.lsvClientList.TabIndex = 2
        Me.lsvClientList.UseCompatibleStateImageBehavior = False
        Me.lsvClientList.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clients List"
        '
        'ServerSock
        '
        Me.ServerSock.ParentControl = Me
        Me.ServerSock.Port = CType(2000, Short)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Message Logs"
        '
        'colClientID
        '
        Me.colClientID.Text = "ID"
        '
        'colIPAddress
        '
        Me.colIPAddress.Text = "IP"
        Me.colIPAddress.Width = 160
        '
        'colMacAddress
        '
        Me.colMacAddress.Text = "MAC"
        Me.colMacAddress.Width = 160
        '
        'colOS
        '
        Me.colOS.Text = "OS"
        Me.colOS.Width = 180
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvClientList)
        Me.Controls.Add(Me.lstLogs)
        Me.Controls.Add(Me.btnGoOffline)
        Me.Controls.Add(Me.btnGoOnline)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Server App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGoOnline As System.Windows.Forms.Button
    Friend WithEvents btnGoOffline As System.Windows.Forms.Button
    Friend WithEvents lstLogs As System.Windows.Forms.ListBox
    Friend WithEvents lsvClientList As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ServerSock As EPWinSock.v4.NET.ServerSocket
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colClientID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colIPAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMacAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOS As System.Windows.Forms.ColumnHeader

End Class
