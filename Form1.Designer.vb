<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        ConvertedCurrencyLabel = New Label()
        DollarTextBox = New TextBox()
        ConvertedAmountTextBox = New TextBox()
        PoundButton = New Button()
        EuroButton = New Button()
        YuanButton = New Button()
        CADButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 32)
        Label1.TabIndex = 0
        Label1.Text = "Dollars"
        ' 
        ' ConvertedCurrencyLabel
        ' 
        ConvertedCurrencyLabel.AutoSize = True
        ConvertedCurrencyLabel.Location = New Point(63, 276)
        ConvertedCurrencyLabel.Name = "ConvertedCurrencyLabel"
        ConvertedCurrencyLabel.Size = New Size(109, 32)
        ConvertedCurrencyLabel.TabIndex = 1
        ConvertedCurrencyLabel.Text = "Currency"
        ' 
        ' DollarTextBox
        ' 
        DollarTextBox.Location = New Point(399, 128)
        DollarTextBox.Name = "DollarTextBox"
        DollarTextBox.Size = New Size(200, 39)
        DollarTextBox.TabIndex = 2
        ' 
        ' ConvertedAmountTextBox
        ' 
        ConvertedAmountTextBox.Location = New Point(399, 269)
        ConvertedAmountTextBox.Name = "ConvertedAmountTextBox"
        ConvertedAmountTextBox.ReadOnly = True
        ConvertedAmountTextBox.Size = New Size(200, 39)
        ConvertedAmountTextBox.TabIndex = 3
        ' 
        ' PoundButton
        ' 
        PoundButton.Location = New Point(63, 424)
        PoundButton.Name = "PoundButton"
        PoundButton.Size = New Size(150, 46)
        PoundButton.TabIndex = 4
        PoundButton.Text = "Pounds "
        PoundButton.UseVisualStyleBackColor = True
        ' 
        ' EuroButton
        ' 
        EuroButton.Location = New Point(63, 521)
        EuroButton.Name = "EuroButton"
        EuroButton.Size = New Size(150, 46)
        EuroButton.TabIndex = 5
        EuroButton.Text = "Euro"
        EuroButton.UseVisualStyleBackColor = True
        ' 
        ' YuanButton
        ' 
        YuanButton.Location = New Point(426, 424)
        YuanButton.Name = "YuanButton"
        YuanButton.Size = New Size(150, 46)
        YuanButton.TabIndex = 7
        YuanButton.Text = "Yuan"
        YuanButton.UseVisualStyleBackColor = True
        ' 
        ' CADButton
        ' 
        CADButton.Location = New Point(426, 521)
        CADButton.Name = "CADButton"
        CADButton.Size = New Size(150, 46)
        CADButton.TabIndex = 8
        CADButton.Text = "Canadian$"
        CADButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(669, 627)
        Controls.Add(CADButton)
        Controls.Add(YuanButton)
        Controls.Add(EuroButton)
        Controls.Add(PoundButton)
        Controls.Add(ConvertedAmountTextBox)
        Controls.Add(DollarTextBox)
        Controls.Add(ConvertedCurrencyLabel)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Currency Converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ConvertedCurrencyLabel As Label
    Friend WithEvents DollarTextBox As TextBox
    Friend WithEvents ConvertedAmountTextBox As TextBox
    Friend WithEvents PoundButton As Button
    Friend WithEvents EuroButton As Button
    Friend WithEvents YuanButton As Button
    Friend WithEvents CADButton As Button

End Class
