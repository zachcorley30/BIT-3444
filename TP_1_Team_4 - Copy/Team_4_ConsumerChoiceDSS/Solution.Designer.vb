<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solution
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
        Me.lblDSS = New System.Windows.Forms.Label()
        Me.lblObjFunction = New System.Windows.Forms.Label()
        Me.lblOptimal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gpxSolution = New System.Windows.Forms.GroupBox()
        Me.lblSolution = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblExtraInfo = New System.Windows.Forms.Label()
        Me.rbxOptimal = New System.Windows.Forms.RichTextBox()
        Me.rbxObjFunction = New System.Windows.Forms.RichTextBox()
        Me.rbxDSS = New System.Windows.Forms.RichTextBox()
        Me.rbxExtraInfo = New System.Windows.Forms.RichTextBox()
        Me.gpxSolution.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDSS
        '
        Me.lblDSS.AutoSize = True
        Me.lblDSS.BackColor = System.Drawing.Color.White
        Me.lblDSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSS.Location = New System.Drawing.Point(3, 0)
        Me.lblDSS.Name = "lblDSS"
        Me.lblDSS.Size = New System.Drawing.Size(231, 31)
        Me.lblDSS.TabIndex = 0
        Me.lblDSS.Text = "Statement of DSS"
        '
        'lblObjFunction
        '
        Me.lblObjFunction.AutoSize = True
        Me.lblObjFunction.BackColor = System.Drawing.Color.White
        Me.lblObjFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjFunction.Location = New System.Drawing.Point(3, 113)
        Me.lblObjFunction.Name = "lblObjFunction"
        Me.lblObjFunction.Size = New System.Drawing.Size(274, 31)
        Me.lblObjFunction.TabIndex = 1
        Me.lblObjFunction.Text = "Value of Obj Function"
        '
        'lblOptimal
        '
        Me.lblOptimal.AutoSize = True
        Me.lblOptimal.BackColor = System.Drawing.Color.White
        Me.lblOptimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptimal.Location = New System.Drawing.Point(3, 226)
        Me.lblOptimal.Name = "lblOptimal"
        Me.lblOptimal.Size = New System.Drawing.Size(403, 62)
        Me.lblOptimal.TabIndex = 2
        Me.lblOptimal.Text = "Value of performance at optimal solution"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 535)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 31)
        Me.Label3.TabIndex = 3
        '
        'gpxSolution
        '
        Me.gpxSolution.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpxSolution.Controls.Add(Me.lblSolution)
        Me.gpxSolution.Controls.Add(Me.TableLayoutPanel1)
        Me.gpxSolution.Location = New System.Drawing.Point(12, -1)
        Me.gpxSolution.Name = "gpxSolution"
        Me.gpxSolution.Size = New System.Drawing.Size(1129, 773)
        Me.gpxSolution.TabIndex = 4
        Me.gpxSolution.TabStop = False
        Me.gpxSolution.Text = "Solution Group Box"
        '
        'lblSolution
        '
        Me.lblSolution.AutoSize = True
        Me.lblSolution.BackColor = System.Drawing.Color.White
        Me.lblSolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolution.ForeColor = System.Drawing.Color.Black
        Me.lblSolution.Location = New System.Drawing.Point(471, 40)
        Me.lblSolution.Name = "lblSolution"
        Me.lblSolution.Size = New System.Drawing.Size(153, 42)
        Me.lblSolution.TabIndex = 4
        Me.lblSolution.Text = "Solution"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblExtraInfo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.rbxOptimal, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.rbxObjFunction, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOptimal, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblObjFunction, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDSS, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rbxDSS, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rbxExtraInfo, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(37, 141)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(923, 512)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'lblExtraInfo
        '
        Me.lblExtraInfo.AutoSize = True
        Me.lblExtraInfo.BackColor = System.Drawing.Color.White
        Me.lblExtraInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraInfo.Location = New System.Drawing.Point(3, 339)
        Me.lblExtraInfo.Name = "lblExtraInfo"
        Me.lblExtraInfo.Size = New System.Drawing.Size(130, 31)
        Me.lblExtraInfo.TabIndex = 6
        Me.lblExtraInfo.Text = "Extra Info"
        '
        'rbxOptimal
        '
        Me.rbxOptimal.Location = New System.Drawing.Point(464, 229)
        Me.rbxOptimal.Name = "rbxOptimal"
        Me.rbxOptimal.Size = New System.Drawing.Size(373, 96)
        Me.rbxOptimal.TabIndex = 5
        Me.rbxOptimal.Text = ""
        '
        'rbxObjFunction
        '
        Me.rbxObjFunction.Location = New System.Drawing.Point(464, 116)
        Me.rbxObjFunction.Name = "rbxObjFunction"
        Me.rbxObjFunction.Size = New System.Drawing.Size(373, 96)
        Me.rbxObjFunction.TabIndex = 4
        Me.rbxObjFunction.Text = ""
        '
        'rbxDSS
        '
        Me.rbxDSS.Location = New System.Drawing.Point(464, 3)
        Me.rbxDSS.Name = "rbxDSS"
        Me.rbxDSS.Size = New System.Drawing.Size(373, 96)
        Me.rbxDSS.TabIndex = 3
        Me.rbxDSS.Text = ""
        '
        'rbxExtraInfo
        '
        Me.rbxExtraInfo.Location = New System.Drawing.Point(464, 342)
        Me.rbxExtraInfo.Name = "rbxExtraInfo"
        Me.rbxExtraInfo.Size = New System.Drawing.Size(373, 96)
        Me.rbxExtraInfo.TabIndex = 7
        Me.rbxExtraInfo.Text = ""
        '
        'Solution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 784)
        Me.Controls.Add(Me.gpxSolution)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Solution"
        Me.Text = "Solution"
        Me.gpxSolution.ResumeLayout(False)
        Me.gpxSolution.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDSS As Label
    Friend WithEvents lblObjFunction As Label
    Friend WithEvents lblOptimal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gpxSolution As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents rbxOptimal As RichTextBox
    Friend WithEvents rbxObjFunction As RichTextBox
    Friend WithEvents rbxDSS As RichTextBox
    Friend WithEvents lblSolution As Label
    Friend WithEvents lblExtraInfo As Label
    Friend WithEvents rbxExtraInfo As RichTextBox
End Class
