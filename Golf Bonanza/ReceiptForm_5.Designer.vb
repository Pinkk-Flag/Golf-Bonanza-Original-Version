<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReceiptForm_5
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblTotalMessage = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Golf_Bonanza.My.Resources.Resources.Golf_Receipt_Image
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(808, 456)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Yu Gothic", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtOut.Location = New System.Drawing.Point(98, 148)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(564, 129)
        Me.txtOut.TabIndex = 1
        '
        'lblTotalMessage
        '
        Me.lblTotalMessage.AutoSize = True
        Me.lblTotalMessage.Font = New System.Drawing.Font("Yu Gothic", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalMessage.Location = New System.Drawing.Point(98, 73)
        Me.lblTotalMessage.Name = "lblTotalMessage"
        Me.lblTotalMessage.Size = New System.Drawing.Size(564, 72)
        Me.lblTotalMessage.TabIndex = 2
        Me.lblTotalMessage.Text = "Your Total Comes to:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 67)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "README + Credits"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(98, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 72)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Your Total Comes to:"
        '
        'ReceiptForm_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTotalMessage)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ReceiptForm_5"
        Me.Text = "ReceiptForm_5"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtOut As TextBox
    Friend WithEvents lblTotalMessage As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
End Class
