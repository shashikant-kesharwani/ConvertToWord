<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NumberToWord
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
        txtnumber = New TextBox()
        txtword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnconvert = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtnumber
        ' 
        txtnumber.Location = New Point(277, 140)
        txtnumber.Multiline = True
        txtnumber.Name = "txtnumber"
        txtnumber.Size = New Size(802, 37)
        txtnumber.TabIndex = 0
        ' 
        ' txtword
        ' 
        txtword.Location = New Point(277, 223)
        txtword.Multiline = True
        txtword.Name = "txtword"
        txtword.Size = New Size(802, 35)
        txtword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Label1.Location = New Point(0, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 37)
        Label1.TabIndex = 2
        Label1.Text = "Enter the decimal number : "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Label2.Location = New Point(0, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(244, 41)
        Label2.TabIndex = 3
        Label2.Text = "Convert into Word : "
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnconvert
        ' 
        btnconvert.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnconvert.Location = New Point(424, 350)
        btnconvert.Name = "btnconvert"
        btnconvert.Size = New Size(159, 69)
        btnconvert.TabIndex = 4
        btnconvert.Text = "Convert"
        btnconvert.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label3.Font = New Font("Baskerville Old Face", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(326, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(410, 73)
        Label3.TabIndex = 5
        Label3.Text = "Convert Numbers into Words"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label4.Font = New Font("Monotype Corsiva", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(776, 456)
        Label4.Name = "Label4"
        Label4.Size = New Size(281, 33)
        Label4.TabIndex = 6
        Label4.Text = "Shashikant Kesharwani"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumberToWord
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1091, 498)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnconvert)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtword)
        Controls.Add(txtnumber)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "NumberToWord"
        Text = "Convert  to Word"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtnumber As TextBox
    Friend WithEvents txtword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnconvert As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
