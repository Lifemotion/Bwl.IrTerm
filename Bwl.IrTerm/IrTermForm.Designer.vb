<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IrTermForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IrTermForm))
        Me.cbPorts = New System.Windows.Forms.ComboBox()
        Me.cbConnect = New System.Windows.Forms.CheckBox()
        Me.cbFilter = New System.Windows.Forms.CheckBox()
        Me.tbResults = New System.Windows.Forms.TextBox()
        Me.cbAddTime = New System.Windows.Forms.CheckBox()
        Me.bCclear = New System.Windows.Forms.Button()
        Me.portsRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.cbWriteLog = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cbPorts
        '
        Me.cbPorts.FormattingEnabled = True
        Me.cbPorts.Location = New System.Drawing.Point(5, 5)
        Me.cbPorts.Name = "cbPorts"
        Me.cbPorts.Size = New System.Drawing.Size(121, 21)
        Me.cbPorts.TabIndex = 0
        '
        'cbConnect
        '
        Me.cbConnect.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbConnect.AutoSize = True
        Me.cbConnect.Location = New System.Drawing.Point(132, 4)
        Me.cbConnect.Name = "cbConnect"
        Me.cbConnect.Size = New System.Drawing.Size(57, 23)
        Me.cbConnect.TabIndex = 1
        Me.cbConnect.Text = "Connect"
        Me.cbConnect.UseVisualStyleBackColor = True
        '
        'cbFilter
        '
        Me.cbFilter.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbFilter.AutoSize = True
        Me.cbFilter.Checked = True
        Me.cbFilter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFilter.Location = New System.Drawing.Point(195, 4)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(39, 23)
        Me.cbFilter.TabIndex = 2
        Me.cbFilter.Text = "Filter"
        Me.cbFilter.UseVisualStyleBackColor = True
        '
        'tbResults
        '
        Me.tbResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbResults.BackColor = System.Drawing.Color.White
        Me.tbResults.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbResults.Location = New System.Drawing.Point(5, 33)
        Me.tbResults.Multiline = True
        Me.tbResults.Name = "tbResults"
        Me.tbResults.ReadOnly = True
        Me.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbResults.Size = New System.Drawing.Size(814, 458)
        Me.tbResults.TabIndex = 3
        '
        'cbAddTime
        '
        Me.cbAddTime.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbAddTime.AutoSize = True
        Me.cbAddTime.Checked = True
        Me.cbAddTime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAddTime.Location = New System.Drawing.Point(240, 4)
        Me.cbAddTime.Name = "cbAddTime"
        Me.cbAddTime.Size = New System.Drawing.Size(62, 23)
        Me.cbAddTime.TabIndex = 4
        Me.cbAddTime.Text = "Add Time"
        Me.cbAddTime.UseVisualStyleBackColor = True
        '
        'bCclear
        '
        Me.bCclear.AutoSize = True
        Me.bCclear.Location = New System.Drawing.Point(308, 4)
        Me.bCclear.Name = "bCclear"
        Me.bCclear.Size = New System.Drawing.Size(52, 23)
        Me.bCclear.TabIndex = 5
        Me.bCclear.Text = "Clear"
        Me.bCclear.UseVisualStyleBackColor = True
        '
        'portsRefresh
        '
        Me.portsRefresh.Enabled = True
        Me.portsRefresh.Interval = 1000
        '
        'cbWriteLog
        '
        Me.cbWriteLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbWriteLog.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbWriteLog.AutoSize = True
        Me.cbWriteLog.Checked = True
        Me.cbWriteLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbWriteLog.Location = New System.Drawing.Point(756, 5)
        Me.cbWriteLog.Name = "cbWriteLog"
        Me.cbWriteLog.Size = New System.Drawing.Size(63, 23)
        Me.cbWriteLog.TabIndex = 6
        Me.cbWriteLog.Text = "Write Log"
        Me.cbWriteLog.UseVisualStyleBackColor = True
        '
        'IrTermForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 496)
        Me.Controls.Add(Me.cbWriteLog)
        Me.Controls.Add(Me.bCclear)
        Me.Controls.Add(Me.cbAddTime)
        Me.Controls.Add(Me.tbResults)
        Me.Controls.Add(Me.cbFilter)
        Me.Controls.Add(Me.cbConnect)
        Me.Controls.Add(Me.cbPorts)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IrTermForm"
        Me.Text = "Bwl IR Terminal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPorts As ComboBox
    Friend WithEvents cbConnect As CheckBox
    Friend WithEvents cbFilter As CheckBox
    Friend WithEvents tbResults As TextBox
    Friend WithEvents cbAddTime As CheckBox
    Friend WithEvents bCclear As Button
    Friend WithEvents portsRefresh As Timer
    Friend WithEvents cbWriteLog As CheckBox
End Class
