<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtMemoria = New TextBox()
        Label2 = New Label()
        txtN = New TextBox()
        Label3 = New Label()
        txtM = New TextBox()
        btnCrear = New Button()
        Label4 = New Label()
        cmbAjuste = New ComboBox()
        Label5 = New Label()
        txtProceso = New TextBox()
        btnAsignar = New Button()
        btnReiniciar = New Button()
        Label6 = New Label()
        lstBloques = New ListBox()
        Label7 = New Label()
        lstLog = New ListBox()
        lblLibre = New Label()
        picMemoria = New PictureBox()
        CType(picMemoria, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tamaño de Memoria:"
        ' 
        ' txtMemoria
        ' 
        txtMemoria.Location = New Point(276, 55)
        txtMemoria.Name = "txtMemoria"
        txtMemoria.Size = New Size(125, 27)
        txtMemoria.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(82, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 20)
        Label2.TabIndex = 2
        Label2.Text = "Cantidad de Bloques:"
        ' 
        ' txtN
        ' 
        txtN.Location = New Point(276, 103)
        txtN.Name = "txtN"
        txtN.ReadOnly = True
        txtN.Size = New Size(125, 27)
        txtN.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(82, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 20)
        Label3.TabIndex = 4
        Label3.Text = "Tamaño del Bloque:"
        ' 
        ' txtM
        ' 
        txtM.Location = New Point(276, 154)
        txtM.Name = "txtM"
        txtM.Size = New Size(125, 27)
        txtM.TabIndex = 5
        ' 
        ' btnCrear
        ' 
        btnCrear.Location = New Point(184, 212)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(114, 29)
        btnCrear.TabIndex = 6
        btnCrear.Text = "Crear Bloques"
        btnCrear.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(82, 287)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 7
        Label4.Text = "Ajuste:"
        ' 
        ' cmbAjuste
        ' 
        cmbAjuste.FormattingEnabled = True
        cmbAjuste.Location = New Point(184, 279)
        cmbAjuste.Name = "cmbAjuste"
        cmbAjuste.Size = New Size(154, 28)
        cmbAjuste.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(82, 338)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 20)
        Label5.TabIndex = 9
        Label5.Text = "Tamaño del Proceso:"
        ' 
        ' txtProceso
        ' 
        txtProceso.Location = New Point(250, 331)
        txtProceso.Name = "txtProceso"
        txtProceso.Size = New Size(125, 27)
        txtProceso.TabIndex = 10
        ' 
        ' btnAsignar
        ' 
        btnAsignar.Location = New Point(98, 405)
        btnAsignar.Name = "btnAsignar"
        btnAsignar.Size = New Size(124, 29)
        btnAsignar.TabIndex = 11
        btnAsignar.Text = "Asignar Proceso"
        btnAsignar.UseVisualStyleBackColor = True
        ' 
        ' btnReiniciar
        ' 
        btnReiniciar.Location = New Point(264, 405)
        btnReiniciar.Name = "btnReiniciar"
        btnReiniciar.Size = New Size(94, 29)
        btnReiniciar.TabIndex = 12
        btnReiniciar.Text = "Reiniciar"
        btnReiniciar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(570, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 13
        Label6.Text = "Bloques:"
        ' 
        ' lstBloques
        ' 
        lstBloques.FormattingEnabled = True
        lstBloques.Location = New Point(454, 74)
        lstBloques.Name = "lstBloques"
        lstBloques.Size = New Size(334, 144)
        lstBloques.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(570, 237)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 20)
        Label7.TabIndex = 15
        Label7.Text = "Historial:"
        ' 
        ' lstLog
        ' 
        lstLog.FormattingEnabled = True
        lstLog.Location = New Point(454, 266)
        lstLog.Name = "lstLog"
        lstLog.Size = New Size(407, 184)
        lstLog.TabIndex = 16
        ' 
        ' lblLibre
        ' 
        lblLibre.AutoSize = True
        lblLibre.Location = New Point(82, 471)
        lblLibre.Name = "lblLibre"
        lblLibre.Size = New Size(162, 20)
        lblLibre.TabIndex = 17
        lblLibre.Text = "Memoria Libre Total: 0 "
        ' 
        ' picMemoria
        ' 
        picMemoria.BorderStyle = BorderStyle.FixedSingle
        picMemoria.Location = New Point(38, 528)
        picMemoria.Name = "picMemoria"
        picMemoria.Size = New Size(600, 90)
        picMemoria.TabIndex = 20
        picMemoria.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1019, 658)
        Controls.Add(picMemoria)
        Controls.Add(lblLibre)
        Controls.Add(lstLog)
        Controls.Add(Label7)
        Controls.Add(lstBloques)
        Controls.Add(Label6)
        Controls.Add(btnReiniciar)
        Controls.Add(btnAsignar)
        Controls.Add(txtProceso)
        Controls.Add(Label5)
        Controls.Add(cmbAjuste)
        Controls.Add(Label4)
        Controls.Add(btnCrear)
        Controls.Add(txtM)
        Controls.Add(Label3)
        Controls.Add(txtN)
        Controls.Add(Label2)
        Controls.Add(txtMemoria)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(picMemoria, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMemoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtM As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAjuste As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProceso As TextBox
    Friend WithEvents btnAsignar As Button
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lstBloques As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lstLog As ListBox
    Friend WithEvents lblLibre As Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents picMemoria As PictureBox
End Class
