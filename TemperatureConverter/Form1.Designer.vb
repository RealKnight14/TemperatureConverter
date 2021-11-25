<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTemperature
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.grpPanel = New System.Windows.Forms.GroupBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.lblCelcius = New System.Windows.Forms.Label()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.grpPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.ForeColor = System.Drawing.Color.Green
        Me.lblWelcome.Location = New System.Drawing.Point(212, 34)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(396, 29)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome To The Converter Program"
        '
        'grpPanel
        '
        Me.grpPanel.Controls.Add(Me.BtnExit)
        Me.grpPanel.Controls.Add(Me.btnConvert)
        Me.grpPanel.Controls.Add(Me.txtCelcius)
        Me.grpPanel.Controls.Add(Me.lblCelcius)
        Me.grpPanel.Controls.Add(Me.txtFahrenheit)
        Me.grpPanel.Controls.Add(Me.lblFahrenheit)
        Me.grpPanel.Location = New System.Drawing.Point(184, 136)
        Me.grpPanel.Name = "grpPanel"
        Me.grpPanel.Size = New System.Drawing.Size(448, 244)
        Me.grpPanel.TabIndex = 1
        Me.grpPanel.TabStop = False
        Me.grpPanel.Text = "Celcius To Fahrenheit"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnExit.Location = New System.Drawing.Point(300, 176)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(102, 45)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(28, 176)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(102, 45)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtCelcius
        '
        Me.txtCelcius.Location = New System.Drawing.Point(104, 112)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(193, 23)
        Me.txtCelcius.TabIndex = 3
        '
        'lblCelcius
        '
        Me.lblCelcius.AutoSize = True
        Me.lblCelcius.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCelcius.Location = New System.Drawing.Point(28, 114)
        Me.lblCelcius.Name = "lblCelcius"
        Me.lblCelcius.Size = New System.Drawing.Size(64, 21)
        Me.lblCelcius.TabIndex = 2
        Me.lblCelcius.Text = "Celcius"
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(104, 74)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(193, 23)
        Me.txtFahrenheit.TabIndex = 1
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFahrenheit.Location = New System.Drawing.Point(6, 72)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(92, 21)
        Me.lblFahrenheit.TabIndex = 0
        Me.lblFahrenheit.Text = "Fahrenheit"
        '
        'FrmTemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpPanel)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "FrmTemperature"
        Me.Text = "Celcius To Fahrenheit"
        Me.grpPanel.ResumeLayout(False)
        Me.grpPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents grpPanel As GroupBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents lblFahrenheit As Label
End Class
