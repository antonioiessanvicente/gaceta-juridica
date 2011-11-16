using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Mail;


namespace QueryBasic
{
    public partial class frmEmails : Form
    {
        Microsoft.Office.Interop.Outlook.Application m_OutLook;

        public frmEmails()
        {
            InitializeComponent();
        }

        private void frmEmails_Load(object sender, EventArgs e)
        {
            txtFrom.Text = ActualUser.email;
            txtTo.Text = EjecutivoActual.email;
            txtAsunto.Text = "RECORADORIO DE PASSWORD";
            txtMensaje.Text = "LE RECORDAMOS QUE SU PASSWORD PARA ACCEDER AL SISTEMA DE CONSULTAS ES: " + EjecutivoActual.clave;
        }
        private void cmbEnviar_Click_1(object sender, EventArgs e)
        {
            try
            {
                MailMessage oMsg = new MailMessage();
                // TODO: Replace with sender e-mail address.
                oMsg.From = txtFrom.Text;
                // TODO: Replace with recipient e-mail address.
                oMsg.To = txtTo.Text;
                oMsg.Subject = txtAsunto.Text;

                // SEND IN HTML FORMAT (comment this line to send plain text).
                oMsg.BodyFormat = MailFormat.Html;

                // HTML Body (remove HTML tags for plain text).
                oMsg.Body = "<body> <table > <tr> <td colspan='2'>CLAVE DEL SISTEMA</td> </tr> <tr> " +
                " <td>USUARIO      :  </td> " +
                "<td> " + EjecutivoActual.email.ToString().Replace("@gacetajuridica.com.pe","") + "</td> </tr> <tr> " +
                " <td>PASSWORD     :  </td> " +
                "<td>" + EjecutivoActual.clave + "</td> </tr> </table> </body>";

                // TODO: remote SMTP server.
                SmtpMail.SmtpServer = "192.168.0.2";
                SmtpMail.Send(oMsg);

                oMsg = null;
                MessageBox.Show("mensaje enviado correctamente");
                this.Dispose();
                //                oAttch = null;
            }
            catch (Exception er)
            {
                MessageBox.Show("Exception caught." + er.Message.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
