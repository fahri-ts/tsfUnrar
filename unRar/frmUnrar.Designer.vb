<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUnrar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnrar))
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.boxUnrar = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDestination = New System.Windows.Forms.Button()
        Me.btnTarget = New System.Windows.Forms.Button()
        Me.btnRar = New System.Windows.Forms.Button()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.txtRar = New System.Windows.Forms.TextBox()
        Me.rarFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.boxPath = New System.Windows.Forms.GroupBox()
        Me.txtInside = New System.Windows.Forms.TextBox()
        Me.rarOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.boxUnrar.SuspendLayout()
        Me.boxPath.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcess.Location = New System.Drawing.Point(377, 224)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 34)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "P&rocess"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'boxUnrar
        '
        Me.boxUnrar.Controls.Add(Me.Label3)
        Me.boxUnrar.Controls.Add(Me.Label2)
        Me.boxUnrar.Controls.Add(Me.Label1)
        Me.boxUnrar.Controls.Add(Me.btnDestination)
        Me.boxUnrar.Controls.Add(Me.btnTarget)
        Me.boxUnrar.Controls.Add(Me.btnRar)
        Me.boxUnrar.Controls.Add(Me.txtDestination)
        Me.boxUnrar.Controls.Add(Me.txtTarget)
        Me.boxUnrar.Controls.Add(Me.txtRar)
        Me.boxUnrar.Location = New System.Drawing.Point(12, 12)
        Me.boxUnrar.Name = "boxUnrar"
        Me.boxUnrar.Size = New System.Drawing.Size(440, 140)
        Me.boxUnrar.TabIndex = 1
        Me.boxUnrar.TabStop = False
        Me.boxUnrar.Text = "Uncompress option"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Destination"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Target"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Winrar path"
        '
        'btnDestination
        '
        Me.btnDestination.Location = New System.Drawing.Point(351, 97)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.Size = New System.Drawing.Size(75, 32)
        Me.btnDestination.TabIndex = 6
        Me.btnDestination.Text = "Op&en"
        Me.btnDestination.UseVisualStyleBackColor = True
        '
        'btnTarget
        '
        Me.btnTarget.Location = New System.Drawing.Point(351, 59)
        Me.btnTarget.Name = "btnTarget"
        Me.btnTarget.Size = New System.Drawing.Size(75, 32)
        Me.btnTarget.TabIndex = 5
        Me.btnTarget.Text = "O&pen"
        Me.btnTarget.UseVisualStyleBackColor = True
        '
        'btnRar
        '
        Me.btnRar.Location = New System.Drawing.Point(351, 21)
        Me.btnRar.Name = "btnRar"
        Me.btnRar.Size = New System.Drawing.Size(75, 32)
        Me.btnRar.TabIndex = 4
        Me.btnRar.Text = "&Open"
        Me.btnRar.UseVisualStyleBackColor = True
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(95, 102)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(250, 22)
        Me.txtDestination.TabIndex = 2
        Me.txtDestination.Text = "D:\FTP_Test"
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(95, 64)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(250, 22)
        Me.txtTarget.TabIndex = 1
        Me.txtTarget.Text = "D:\MAC"
        '
        'txtRar
        '
        Me.txtRar.Location = New System.Drawing.Point(95, 26)
        Me.txtRar.Name = "txtRar"
        Me.txtRar.Size = New System.Drawing.Size(250, 22)
        Me.txtRar.TabIndex = 0
        Me.txtRar.Text = "C:\Program Files\WinRAR"
        '
        'rarFolderBrowserDialog
        '
        Me.rarFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.rarFolderBrowserDialog.ShowNewFolderButton = False
        '
        'boxPath
        '
        Me.boxPath.Controls.Add(Me.txtInside)
        Me.boxPath.Location = New System.Drawing.Point(12, 158)
        Me.boxPath.Name = "boxPath"
        Me.boxPath.Size = New System.Drawing.Size(440, 60)
        Me.boxPath.TabIndex = 2
        Me.boxPath.TabStop = False
        Me.boxPath.Text = "Path inside archive"
        '
        'txtInside
        '
        Me.txtInside.Location = New System.Drawing.Point(9, 21)
        Me.txtInside.Name = "txtInside"
        Me.txtInside.Size = New System.Drawing.Size(250, 22)
        Me.txtInside.TabIndex = 0
        '
        'rarOpenFileDialog
        '
        Me.rarOpenFileDialog.Filter = "Zip file|*.zip|Rar file|*.rar|Tar file|*.tar|Gz file|*.gz"
        '
        'frmUnrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 269)
        Me.Controls.Add(Me.boxPath)
        Me.Controls.Add(Me.boxUnrar)
        Me.Controls.Add(Me.btnProcess)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUnrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tsf Unrar"
        Me.boxUnrar.ResumeLayout(False)
        Me.boxUnrar.PerformLayout()
        Me.boxPath.ResumeLayout(False)
        Me.boxPath.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProcess As Button
    Friend WithEvents boxUnrar As GroupBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtTarget As TextBox
    Friend WithEvents txtRar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDestination As Button
    Friend WithEvents btnTarget As Button
    Friend WithEvents btnRar As Button
    Friend WithEvents rarFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents boxPath As GroupBox
    Friend WithEvents txtInside As TextBox
    Friend WithEvents rarOpenFileDialog As OpenFileDialog
End Class
