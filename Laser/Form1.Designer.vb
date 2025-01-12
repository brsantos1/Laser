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
        btn_Sair = New Button()
        Label1 = New Label()
        txt_GCode = New TextBox()
        btn_Enviar = New Button()
        cmb_portas = New ComboBox()
        btn_Conectar = New Button()
        Label2 = New Label()
        btn_Xmenos = New Button()
        btn_Rmais = New Button()
        btn_Rmenos = New Button()
        btn_Xmais = New Button()
        btn_Desligar = New Button()
        btn_Ligar = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Btn_unlock = New Button()
        Btn_lock = New Button()
        SuspendLayout()
        ' 
        ' btn_Sair
        ' 
        btn_Sair.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Sair.Location = New Point(22, 322)
        btn_Sair.Name = "btn_Sair"
        btn_Sair.Size = New Size(122, 78)
        btn_Sair.TabIndex = 0
        btn_Sair.Text = "Sair"
        btn_Sair.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(758, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 25)
        Label1.TabIndex = 4
        Label1.Text = "Código manual"
        ' 
        ' txt_GCode
        ' 
        txt_GCode.Location = New Point(735, 66)
        txt_GCode.Multiline = True
        txt_GCode.Name = "txt_GCode"
        txt_GCode.Size = New Size(190, 240)
        txt_GCode.TabIndex = 8
        ' 
        ' btn_Enviar
        ' 
        btn_Enviar.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Enviar.Location = New Point(785, 322)
        btn_Enviar.Name = "btn_Enviar"
        btn_Enviar.Size = New Size(90, 47)
        btn_Enviar.TabIndex = 9
        btn_Enviar.Text = "Enviar"
        btn_Enviar.UseVisualStyleBackColor = True
        ' 
        ' cmb_portas
        ' 
        cmb_portas.Location = New Point(22, 58)
        cmb_portas.Name = "cmb_portas"
        cmb_portas.Size = New Size(190, 33)
        cmb_portas.TabIndex = 0
        ' 
        ' btn_Conectar
        ' 
        btn_Conectar.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Conectar.Location = New Point(233, 50)
        btn_Conectar.Name = "btn_Conectar"
        btn_Conectar.Size = New Size(139, 45)
        btn_Conectar.TabIndex = 10
        btn_Conectar.Text = "Conectar"
        btn_Conectar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 11
        Label2.Text = "Portas COM"
        ' 
        ' btn_Xmenos
        ' 
        btn_Xmenos.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Xmenos.Location = New Point(472, 254)
        btn_Xmenos.Name = "btn_Xmenos"
        btn_Xmenos.Size = New Size(90, 64)
        btn_Xmenos.TabIndex = 12
        btn_Xmenos.Text = "Y-"
        btn_Xmenos.UseVisualStyleBackColor = True
        ' 
        ' btn_Rmais
        ' 
        btn_Rmais.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Rmais.Location = New Point(590, 336)
        btn_Rmais.Name = "btn_Rmais"
        btn_Rmais.Size = New Size(90, 64)
        btn_Rmais.TabIndex = 13
        btn_Rmais.Text = "Z+"
        btn_Rmais.UseVisualStyleBackColor = True
        ' 
        ' btn_Rmenos
        ' 
        btn_Rmenos.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Rmenos.Location = New Point(472, 336)
        btn_Rmenos.Name = "btn_Rmenos"
        btn_Rmenos.Size = New Size(90, 64)
        btn_Rmenos.TabIndex = 14
        btn_Rmenos.Text = "Z-"
        btn_Rmenos.UseVisualStyleBackColor = True
        ' 
        ' btn_Xmais
        ' 
        btn_Xmais.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Xmais.Location = New Point(590, 254)
        btn_Xmais.Name = "btn_Xmais"
        btn_Xmais.Size = New Size(90, 64)
        btn_Xmais.TabIndex = 15
        btn_Xmais.Text = "Y+"
        btn_Xmais.UseVisualStyleBackColor = True
        ' 
        ' btn_Desligar
        ' 
        btn_Desligar.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Desligar.Location = New Point(581, 72)
        btn_Desligar.Name = "btn_Desligar"
        btn_Desligar.Size = New Size(99, 64)
        btn_Desligar.TabIndex = 16
        btn_Desligar.Text = "Desligar"
        btn_Desligar.UseVisualStyleBackColor = True
        ' 
        ' btn_Ligar
        ' 
        btn_Ligar.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Ligar.Location = New Point(472, 72)
        btn_Ligar.Name = "btn_Ligar"
        btn_Ligar.Size = New Size(90, 64)
        btn_Ligar.TabIndex = 17
        btn_Ligar.Text = "Ligar"
        btn_Ligar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(543, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 25)
        Label3.TabIndex = 18
        Label3.Text = "LASER"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(450, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(247, 25)
        Label4.TabIndex = 19
        Label4.Text = "Movimento manual dos eixos"
        ' 
        ' Btn_unlock
        ' 
        Btn_unlock.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_unlock.Location = New Point(22, 153)
        Btn_unlock.Name = "Btn_unlock"
        Btn_unlock.Size = New Size(90, 64)
        Btn_unlock.TabIndex = 20
        Btn_unlock.Text = "Unlock"
        Btn_unlock.UseVisualStyleBackColor = True
        ' 
        ' Btn_lock
        ' 
        Btn_lock.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_lock.Location = New Point(122, 153)
        Btn_lock.Name = "Btn_lock"
        Btn_lock.Size = New Size(90, 64)
        Btn_lock.TabIndex = 21
        Btn_lock.Text = "Lock"
        Btn_lock.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(963, 450)
        Controls.Add(Btn_lock)
        Controls.Add(Btn_unlock)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btn_Ligar)
        Controls.Add(btn_Desligar)
        Controls.Add(btn_Xmais)
        Controls.Add(btn_Rmenos)
        Controls.Add(btn_Rmais)
        Controls.Add(btn_Xmenos)
        Controls.Add(Label2)
        Controls.Add(btn_Conectar)
        Controls.Add(cmb_portas)
        Controls.Add(btn_Enviar)
        Controls.Add(txt_GCode)
        Controls.Add(Label1)
        Controls.Add(btn_Sair)
        Name = "Form1"
        Text = "CNC Laser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Sair As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_GCode As TextBox
    Friend WithEvents btn_Enviar As Button
    Friend WithEvents cmb_portas As ComboBox
    Friend WithEvents btn_Conectar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Xmenos As Button
    Friend WithEvents btn_Rmais As Button
    Friend WithEvents btn_Rmenos As Button
    Friend WithEvents btn_Xmais As Button
    Friend WithEvents btn_Desligar As Button
    Friend WithEvents btn_Ligar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_unlock As Button
    Friend WithEvents Btn_lock As Button

End Class
