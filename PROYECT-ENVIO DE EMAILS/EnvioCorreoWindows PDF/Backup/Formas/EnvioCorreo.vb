

Imports System.IO
Imports System.Text
Imports System.Web.Mail
Imports CrystalDecisions.[Shared]
Imports CrystalDecisions.CrystalReports.Engine

Public Class EnvioCorreo
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents picIcono As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescripcionBase As System.Windows.Forms.Label
    Friend WithEvents lblTituloBase As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents txtDe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpExchange As System.Windows.Forms.GroupBox
    Friend WithEvents grpPOP3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPOP3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbExchange As System.Windows.Forms.RadioButton
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents txtExchangeServer As System.Windows.Forms.TextBox
    Friend WithEvents txtPOP3Pass As System.Windows.Forms.TextBox
    Friend WithEvents txtPOP3User As System.Windows.Forms.TextBox
    Friend WithEvents txtPOP3Server As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EnvioCorreo))
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.picIcono = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblDescripcionBase = New System.Windows.Forms.Label
        Me.lblTituloBase = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtMensaje = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAsunto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDe = New System.Windows.Forms.TextBox
        Me.txtPara = New System.Windows.Forms.TextBox
        Me.grpExchange = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtExchangeServer = New System.Windows.Forms.TextBox
        Me.grpPOP3 = New System.Windows.Forms.GroupBox
        Me.txtPOP3Pass = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPOP3User = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPOP3Server = New System.Windows.Forms.TextBox
        Me.rbPOP3 = New System.Windows.Forms.RadioButton
        Me.rbExchange = New System.Windows.Forms.RadioButton
        Me.pnlTop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpExchange.SuspendLayout()
        Me.grpPOP3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(17, Byte), CType(80, Byte), CType(152, Byte))
        Me.pnlTop.Controls.Add(Me.picIcono)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.lblDescripcionBase)
        Me.pnlTop.Controls.Add(Me.lblTituloBase)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(700, 40)
        Me.pnlTop.TabIndex = 9
        '
        'picIcono
        '
        Me.picIcono.BackColor = System.Drawing.Color.FromArgb(CType(17, Byte), CType(80, Byte), CType(152, Byte))
        Me.picIcono.Image = CType(resources.GetObject("picIcono.Image"), System.Drawing.Image)
        Me.picIcono.Location = New System.Drawing.Point(14, 2)
        Me.picIcono.Name = "picIcono"
        Me.picIcono.Size = New System.Drawing.Size(32, 32)
        Me.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcono.TabIndex = 9
        Me.picIcono.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblDescripcionBase
        '
        Me.lblDescripcionBase.AutoSize = True
        Me.lblDescripcionBase.BackColor = System.Drawing.Color.FromArgb(CType(17, Byte), CType(80, Byte), CType(152, Byte))
        Me.lblDescripcionBase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDescripcionBase.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDescripcionBase.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionBase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescripcionBase.Location = New System.Drawing.Point(80, 20)
        Me.lblDescripcionBase.Name = "lblDescripcionBase"
        Me.lblDescripcionBase.Size = New System.Drawing.Size(158, 16)
        Me.lblDescripcionBase.TabIndex = 5
        Me.lblDescripcionBase.Text = "Ingrese los datos necesarios..."
        '
        'lblTituloBase
        '
        Me.lblTituloBase.AutoSize = True
        Me.lblTituloBase.BackColor = System.Drawing.Color.FromArgb(CType(17, Byte), CType(80, Byte), CType(152, Byte))
        Me.lblTituloBase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTituloBase.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTituloBase.ForeColor = System.Drawing.Color.White
        Me.lblTituloBase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTituloBase.Location = New System.Drawing.Point(80, 2)
        Me.lblTituloBase.Name = "lblTituloBase"
        Me.lblTituloBase.Size = New System.Drawing.Size(163, 18)
        Me.lblTituloBase.TabIndex = 4
        Me.lblTituloBase.Text = "Envío de Correo Adjunto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(4, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 48)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(580, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Terminar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Enviar Correo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtMensaje)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtAsunto)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDe)
        Me.GroupBox2.Controls.Add(Me.txtPara)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(4, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 240)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos sobre el Envío"
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.Location = New System.Drawing.Point(84, 122)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(292, 106)
        Me.txtMensaje.TabIndex = 7
        Me.txtMensaje.Text = "Prueba de Envio de Correo ..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mensaje:"
        '
        'txtAsunto
        '
        Me.txtAsunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAsunto.Location = New System.Drawing.Point(84, 92)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(292, 20)
        Me.txtAsunto.TabIndex = 5
        Me.txtAsunto.Text = "Prueba Envío"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Asunto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "De:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Para:"
        '
        'txtDe
        '
        Me.txtDe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDe.Location = New System.Drawing.Point(84, 64)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(292, 20)
        Me.txtDe.TabIndex = 1
        Me.txtDe.Text = ""
        '
        'txtPara
        '
        Me.txtPara.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPara.Location = New System.Drawing.Point(84, 36)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(292, 20)
        Me.txtPara.TabIndex = 0
        Me.txtPara.Text = ""
        '
        'grpExchange
        '
        Me.grpExchange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpExchange.Controls.Add(Me.Label5)
        Me.grpExchange.Controls.Add(Me.txtExchangeServer)
        Me.grpExchange.Location = New System.Drawing.Point(404, 104)
        Me.grpExchange.Name = "grpExchange"
        Me.grpExchange.Size = New System.Drawing.Size(292, 92)
        Me.grpExchange.TabIndex = 15
        Me.grpExchange.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Servidor Exchange :"
        '
        'txtExchangeServer
        '
        Me.txtExchangeServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExchangeServer.Location = New System.Drawing.Point(16, 64)
        Me.txtExchangeServer.Name = "txtExchangeServer"
        Me.txtExchangeServer.Size = New System.Drawing.Size(264, 20)
        Me.txtExchangeServer.TabIndex = 3
        Me.txtExchangeServer.Text = ""
        '
        'grpPOP3
        '
        Me.grpPOP3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPOP3.Controls.Add(Me.txtPOP3Pass)
        Me.grpPOP3.Controls.Add(Me.Label8)
        Me.grpPOP3.Controls.Add(Me.Label7)
        Me.grpPOP3.Controls.Add(Me.txtPOP3User)
        Me.grpPOP3.Controls.Add(Me.Label6)
        Me.grpPOP3.Controls.Add(Me.txtPOP3Server)
        Me.grpPOP3.Location = New System.Drawing.Point(404, 216)
        Me.grpPOP3.Name = "grpPOP3"
        Me.grpPOP3.Size = New System.Drawing.Size(292, 128)
        Me.grpPOP3.TabIndex = 16
        Me.grpPOP3.TabStop = False
        '
        'txtPOP3Pass
        '
        Me.txtPOP3Pass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPOP3Pass.Location = New System.Drawing.Point(116, 98)
        Me.txtPOP3Pass.Name = "txtPOP3Pass"
        Me.txtPOP3Pass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPOP3Pass.Size = New System.Drawing.Size(160, 20)
        Me.txtPOP3Pass.TabIndex = 21
        Me.txtPOP3Pass.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Contraseña POP3 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Usuario POP3 :"
        '
        'txtPOP3User
        '
        Me.txtPOP3User.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPOP3User.Location = New System.Drawing.Point(116, 66)
        Me.txtPOP3User.Name = "txtPOP3User"
        Me.txtPOP3User.Size = New System.Drawing.Size(160, 20)
        Me.txtPOP3User.TabIndex = 19
        Me.txtPOP3User.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Servidor POP3 :"
        '
        'txtPOP3Server
        '
        Me.txtPOP3Server.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPOP3Server.Location = New System.Drawing.Point(116, 38)
        Me.txtPOP3Server.Name = "txtPOP3Server"
        Me.txtPOP3Server.Size = New System.Drawing.Size(160, 20)
        Me.txtPOP3Server.TabIndex = 17
        Me.txtPOP3Server.Text = ""
        '
        'rbPOP3
        '
        Me.rbPOP3.Checked = True
        Me.rbPOP3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbPOP3.Location = New System.Drawing.Point(416, 216)
        Me.rbPOP3.Name = "rbPOP3"
        Me.rbPOP3.Size = New System.Drawing.Size(144, 16)
        Me.rbPOP3.TabIndex = 17
        Me.rbPOP3.TabStop = True
        Me.rbPOP3.Text = "Por Servidor POP3"
        '
        'rbExchange
        '
        Me.rbExchange.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbExchange.Location = New System.Drawing.Point(416, 104)
        Me.rbExchange.Name = "rbExchange"
        Me.rbExchange.Size = New System.Drawing.Size(144, 16)
        Me.rbExchange.TabIndex = 18
        Me.rbExchange.Text = "Por Servidor Exchange"
        '
        'EnvioCorreo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(700, 345)
        Me.Controls.Add(Me.rbExchange)
        Me.Controls.Add(Me.rbPOP3)
        Me.Controls.Add(Me.grpPOP3)
        Me.Controls.Add(Me.grpExchange)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EnvioCorreo"
        Me.Text = "Prueba para Envío de Correo"
        Me.pnlTop.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grpExchange.ResumeLayout(False)
        Me.grpPOP3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub EnvioCorreo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.grpExchange.DataBindings.Add("Enabled", Me.rbExchange, "Checked")
            Me.grpPOP3.DataBindings.Add("Enabled", Me.rbPOP3, "Checked")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnviarCorreo(ByVal rpt As ReportDocument)
        Dim Mensaje As String
        Dim email As New System.Web.Mail.MailMessage
        Dim Directorio As String = Application.LocalUserAppDataPath
        Dim PathFile As String = Directorio & "\Reporte.pdf"

        Try
            Mensaje &= "Ejemplo Exportar un Crystal Reports a PDF y adjuntarlo a un correo" & vbCrLf

            With email
                .From = Me.txtDe.Text
                .To = Me.txtPara.Text
                .Subject = Me.txtAsunto.Text
                .Body = Me.txtMensaje.Text
                .BodyFormat = MailFormat.Text
                .Priority = MailPriority.High

                If Me.rbExchange.Checked Then
                    .Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "2") '; //basic authentication
                Else
                    .Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1") '; //basic authentication
                    .Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", Me.txtPOP3User.Text)  '; //set your username here
                    .Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", Me.txtPOP3Pass.Text) ';         //set your password here
                End If
            End With

            'Exporta a PDF
            PathFile = ExportToPDF(rpt, "Reporte.pdf")

            Dim HTMLAttachment As MailAttachment = New MailAttachment(PathFile)
            email.Attachments.Add(HTMLAttachment)


            If File.Exists("c:\tmp.log") Then File.Delete("c:\tmp.log")

            SmtpMail.SmtpServer = CStr(IIf(Me.rbExchange.Checked, Me.txtExchangeServer.Text, Me.txtPOP3Server.Text))
            SmtpMail.Send(email)

            MsgBox("Mensaje Enviado...")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Public Function ExportToPDF(ByVal rpt As ReportDocument, ByVal NombreArchivo As String) As String
        Dim vFileName As String
        Dim diskOpts As New DiskFileDestinationOptions

        Try
            With rpt.ExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
            End With

            vFileName = "c:\" & NombreArchivo
            If File.Exists(vFileName) Then File.Delete(vFileName)
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()
        Catch ex As Exception
            Throw ex
        End Try

        Return vFileName
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.EnviarCorreo(New Reporte)
    End Sub
End Class
