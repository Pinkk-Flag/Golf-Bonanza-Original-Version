<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.lblTotalMessage = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotalMessage
        '
        Me.lblTotalMessage.AutoSize = True
        Me.lblTotalMessage.Font = New System.Drawing.Font("Yu Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalMessage.Location = New System.Drawing.Point(2, 66)
        Me.lblTotalMessage.Name = "lblTotalMessage"
        Me.lblTotalMessage.Size = New System.Drawing.Size(806, 62)
        Me.lblTotalMessage.TabIndex = 3
        Me.lblTotalMessage.Text = "Are you happy with your purchase?"
        '
        'btnYes
        '
        Me.btnYes.Font = New System.Drawing.Font("Yu Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnYes.Location = New System.Drawing.Point(112, 131)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(255, 98)
        Me.btnYes.TabIndex = 4
        Me.btnYes.Text = "Yes! Take me to the receipt!"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(373, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 98)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "No! I want to try again"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblTotalMessage)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalMessage As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents Button1 As Button
End Class
