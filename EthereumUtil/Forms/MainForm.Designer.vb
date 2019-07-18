<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.btnStructUint = New System.Windows.Forms.Button()
        Me.btnUintStruct = New System.Windows.Forms.Button()
        Me.btnTwoStructUint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStructUint
        '
        Me.btnStructUint.Location = New System.Drawing.Point(12, 40)
        Me.btnStructUint.Name = "btnStructUint"
        Me.btnStructUint.Size = New System.Drawing.Size(553, 62)
        Me.btnStructUint.TabIndex = 0
        Me.btnStructUint.Text = "Struct first, uint second."
        Me.btnStructUint.UseVisualStyleBackColor = True
        '
        'btnUintStruct
        '
        Me.btnUintStruct.Location = New System.Drawing.Point(12, 118)
        Me.btnUintStruct.Name = "btnUintStruct"
        Me.btnUintStruct.Size = New System.Drawing.Size(553, 62)
        Me.btnUintStruct.TabIndex = 1
        Me.btnUintStruct.Text = "Uint first, struct second."
        Me.btnUintStruct.UseVisualStyleBackColor = True
        '
        'btnTwoStructUint
        '
        Me.btnTwoStructUint.Location = New System.Drawing.Point(12, 198)
        Me.btnTwoStructUint.Name = "btnTwoStructUint"
        Me.btnTwoStructUint.Size = New System.Drawing.Size(553, 62)
        Me.btnTwoStructUint.TabIndex = 2
        Me.btnTwoStructUint.Text = "Struct[] first, uint second."
        Me.btnTwoStructUint.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 286)
        Me.Controls.Add(Me.btnTwoStructUint)
        Me.Controls.Add(Me.btnUintStruct)
        Me.Controls.Add(Me.btnStructUint)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Test"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStructUint As Button
    Friend WithEvents btnUintStruct As Button
    Friend WithEvents btnTwoStructUint As Button
End Class
