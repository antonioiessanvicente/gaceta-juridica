Imports System.IO
Imports System.Text
Imports CrystalDecisions.[Shared]
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Net

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents estadoS_CUENTA_2011_CYE1 As EnvioCorreoWindows.ESTADOS_CUENTA_2011_CYE
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblFechaProceso As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnvioCorreo))
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.picIcono = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblDescripcionBase = New System.Windows.Forms.Label
        Me.lblTituloBase = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.estadoS_CUENTA_2011_CYE1 = New EnvioCorreoWindows.ESTADOS_CUENTA_2011_CYE
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.lblFechaProceso = New System.Windows.Forms.Label
        Me.pnlTop.SuspendLayout()
        CType(Me.picIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.picIcono)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.lblDescripcionBase)
        Me.pnlTop.Controls.Add(Me.lblTituloBase)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(710, 40)
        Me.pnlTop.TabIndex = 9
        '
        'picIcono
        '
        Me.picIcono.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(152, Byte), Integer))
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
        Me.lblDescripcionBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lblDescripcionBase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDescripcionBase.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDescripcionBase.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionBase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescripcionBase.Location = New System.Drawing.Point(80, 20)
        Me.lblDescripcionBase.Name = "lblDescripcionBase"
        Me.lblDescripcionBase.Size = New System.Drawing.Size(156, 14)
        Me.lblDescripcionBase.TabIndex = 5
        Me.lblDescripcionBase.Text = "Ingrese los datos necesarios..."
        '
        'lblTituloBase
        '
        Me.lblTituloBase.AutoSize = True
        Me.lblTituloBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lblTituloBase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTituloBase.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTituloBase.ForeColor = System.Drawing.Color.White
        Me.lblTituloBase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTituloBase.Location = New System.Drawing.Point(80, 2)
        Me.lblTituloBase.Name = "lblTituloBase"
        Me.lblTituloBase.Size = New System.Drawing.Size(163, 16)
        Me.lblTituloBase.TabIndex = 4
        Me.lblTituloBase.Text = "Envío de Correo Adjunto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblFechaProceso)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 48)
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
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(14, 101)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(678, 172)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = ""
        '
        'lblFechaProceso
        '
        Me.lblFechaProceso.AutoSize = True
        Me.lblFechaProceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFechaProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaProceso.Location = New System.Drawing.Point(6, 20)
        Me.lblFechaProceso.Name = "lblFechaProceso"
        Me.lblFechaProceso.Size = New System.Drawing.Size(49, 16)
        Me.lblFechaProceso.TabIndex = 16
        Me.lblFechaProceso.Text = "Label1"
        '
        'EnvioCorreo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(710, 285)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EnvioCorreo"
        Me.Text = "Prueba para Envío de Correo"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.picIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private strServer As String
    Private strDataBase As String
    Private str_SMTP As String
    Private str_Cuenta As String
    Private str_Clave As String
    Private Sub EnvioCorreo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'strServer = "192.168.0.6"
            'strDataBase = "COMERCIAL"
            'str_SMTP = "192.168.0.5"
            'str_Cuenta = ""
            'str_Clave = ""
            If LeerDatosInciales(strServer, strDataBase, str_SMTP, str_Cuenta, str_Clave) = True Then
                MostrarFechaProceso()
            Else
                Button1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function LeerDatosInciales(ByRef Server As String, ByRef DataBase As String, ByRef str_SMTP As String, ByRef str_Cuenta As String, ByRef str_Clave As String) As Boolean
        Try
            Dim ruta As String = System.IO.Directory.GetCurrentDirectory() & "\Config\Configuracion.ini"
            If IO.File.Exists(ruta) = True Then
                Dim obj As New StreamReader(ruta)
                Server = obj.ReadLine
                DataBase = obj.ReadLine
                str_SMTP = obj.ReadLine
                str_Cuenta = obj.ReadLine
                str_Clave = obj.ReadLine
                obj.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As IOException
            Throw New Exception("Error: " & ex.Message, ex)
            Return False
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message, ex)
            Return False
        Finally
            GC.Collect()
        End Try
    End Function
    Private Sub MostrarFechaProceso()
        Dim sCnn1 As String
        sCnn1 = "data source = " + strServer + "; initial catalog = " + strDataBase + "; Integrated Security=SSPI "

        Dim sSel As String = "SELECT top 1 FECHA_SISTEMA FROM TEMPO_ESTADOS_CUENTA_CYE where USUARIO = 'GACETAJURIDICA\Systems'"
        Dim da1 As New SqlDataAdapter
        Dim dt1 As New DataTable
        Dim lExiste As Boolean = False
        Try
            da1 = New SqlDataAdapter(sSel, sCnn1)
            da1.Fill(dt1)
            Dim dr1 As DataRow
            For Each dr1 In dt1.Rows
                lExiste = True
                lblFechaProceso.Text = "PROCESADO EL : " + dr1("FECHA_SISTEMA").ToString()
            Next
            If lExiste = False Then
                lblFechaProceso.Text = "No existe Fecha de Proceso"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub EnviarCorreo(ByVal str_id_cliente As String, ByVal strNameCliente As String, ByVal str_Email As String)
        'Dim str_id_cliente As String = "20138855083-0"
        Dim email As New System.Net.Mail.MailMessage
        Dim Directorio As String = System.IO.Directory.GetCurrentDirectory()
        Dim PathFile As String = Directorio & "\Reportes\ESTADOS_CUENTA_" + str_id_cliente.ToString().Replace("-", "") + "_2011_CYE.pdf"
        Dim FileReport As String = Directorio & "\Reportes\ESTADOS_CUENTA_2011_CYE.rpt"

        Try
            'Login to database
            Dim LogInfo As New TableLogOnInfo()
            LogInfo.ConnectionInfo.ServerName = strServer
            LogInfo.ConnectionInfo.DatabaseName = strDataBase
            LogInfo.ConnectionInfo.IntegratedSecurity = True
            'LogInfo.ConnectionInfo.UserID = "username"
            'LogInfo.ConnectionInfo.Password = "password"
            'Load Report
            Dim oReport As New ReportDocument
            oReport.Load(FileReport) 'Set Parameters
            oReport.SetParameterValue("@Id_cliente", str_id_cliente)
            'oReport.SetParameterValue("Parameter2", "Test Parameter 2")
            'Export to disk as PDF file
            oReport.ExportToDisk(ExportFormatType.PortableDocFormat, PathFile)

            '        frmReporte.crvMiReporte.ReportSource = rpt
            '       frmReporte.Show()
            Envio_Email(PathFile, strNameCliente, str_Email)
            ''MsgBox("Mensaje Enviado...")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Envio_Email(ByVal file_name As String, ByVal strNameCliente As String, ByVal str_Email As String)
        'Send Email
        Dim mail As New MailMessage()

        'set the addresses
        mail.From = New MailAddress("ventas@contadoresyempresas.com.pe")
        Dim txtEmail As String = str_Email
        'Lets assume that txtEmail textbox contains multiple emails separated by comma
        'mail.To.Add(txtEmail)
        mail.To.Add("mmendoza@gacetajuridica.com.pe")
        'set the content
        mail.Subject = "ESTADOS DE CUENTA - GACETA COMERCIAL S.A. (Contadores & Empresas / Soluciones Laborales)"
        mail.Body = "Estimado Sr.(a) y/o Señores: " + strNameCliente + Chr(13) + Chr(13) + _
        "Adjuntamos su estado de cuenta a la fecha a efectos que verifique los pagos efectuados, así como el saldo que tiene por pagar." + _
        Chr(13) + Chr(13) + "Si tuviera alguna duda, favor de comunicarse con la suscrita al teléfono: " + _
        "7108950: ANEXO(204) " + Chr(13) + _
        Chr(13) + Chr(13) + Chr(13) + _
        "Cordialmente, " + Chr(13) + Chr(13) + Chr(13) + _
        "ROSARIO RIVAS" + Chr(13) + _
        "Jefe de Ventas" + Chr(13) + _
        "Email: ventas@contadoresyempresas.com.pe" + Chr(13) + _
        "Teléfonos  Nro. 7108950 - anexos 204, 216 y 217 Dpto.  de Ventas"
        'attach exported pdf
        Dim att As New Attachment(file_name)
        mail.Attachments.Add(att)

        'send the message
        Dim smtp As New SmtpClient(str_SMTP) 'SMTP Server
        If str_Cuenta <> "" Then
            smtp.Credentials = New NetworkCredential(str_Cuenta, str_Clave)
        End If
        smtp.Send(mail)
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sCnn As String
        Button1.Enabled = False
        sCnn = "data source = " + strServer + "; initial catalog = " + strDataBase + "; Integrated Security=SSPI "

        Dim sSel As String = "SELECT TOP 10 CODIGO = LEFT(RESUMEN.CODIGO,11), NOMBRE_CLIENTE = RTRIM(LTRIM(MAX(RESUMEN.NOMBRE_CLIENTE))), EMAIL = RTRIM(LTRIM(MAX(RESUMEN.EMAIL))) FROM (" + _
                             " select CODIGO = VIEW_TEMPO_ESTADOS_CUENTA_CYE.ID_CLIENTE, NOMBRE_CLIENTE = VIEW_TEMPO_ESTADOS_CUENTA_CYE.nombre_razon_social , CLIENTES.EMAIL " + _
                             " from VIEW_TEMPO_ESTADOS_CUENTA_CYE LEFT OUTER JOIN CLIENTES ON VIEW_TEMPO_ESTADOS_CUENTA_CYE.id_cliente = CLIENTES.ID_CLIENTE " + _
                             " ) AS RESUMEN GROUP BY LEFT(RESUMEN.CODIGO,11)  "
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            RichTextBox1.AppendText("Iniciando Envio de emails" + Now().ToString() + Chr(13))
            da = New SqlDataAdapter(sSel, sCnn)
            da.Fill(dt)
            Dim dr As DataRow
            For Each dr In dt.Rows
                If dr("EMAIL").ToString() <> "" Then
                    Me.EnviarCorreo(dr("CODIGO").ToString() + "-0", dr("NOMBRE_CLIENTE").ToString(), dr("EMAIL").ToString())
                    'Me.EnviarCorreo(dr("CODIGO").ToString() + "-0", dr("NOMBRE_CLIENTE").ToString(), "mmendoza@gacetajuridica.com.pe")
                    RichTextBox1.AppendText("Mail enviado a: " + dr("NOMBRE_CLIENTE").ToString() + Chr(13))
                Else
                    RichTextBox1.AppendText("NO ENVIADO A : " + dr("NOMBRE_CLIENTE").ToString() + Chr(13))
                End If
            Next
            RichTextBox1.AppendText("Fin de Envio de emails" + Now().ToString() + Chr(13))
            MsgBox("ENVIOS DE EMAIL FUE 'OK'", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Button1.Enabled = True
        End Try
    End Sub
    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class

