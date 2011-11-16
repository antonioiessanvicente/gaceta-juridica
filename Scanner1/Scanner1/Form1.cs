using System;
using System.Windows.Forms;
using WIA;
using System.Drawing;
using System.IO;
using System.Text;
using PdfSharp;
namespace Scanner1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
            String Archivo = "D:\\EJEMPLO_ESCANEO_012"; 
	    //CommonDialogClass wiaDiag = new CommonDialogClass();
        ICommonDialog wiaDiag = new WIA.CommonDialog();
	    WIA.ImageFile wiaImage = null;
	    wiaImage = wiaDiag.ShowAcquireImage(WiaDeviceType.UnspecifiedDeviceType,WiaImageIntent.GrayscaleIntent,WiaImageBias.MaximizeQuality,
            wiaFormatJPEG ,   true, true, false );
	    WIA.Vector vector = wiaImage.FileData;
        pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])vector.get_BinaryData()));
        
            Image i = Image.FromStream(new MemoryStream((byte[])vector.get_BinaryData()));
            i.Save(Archivo + ".TIFF");

            PdfSharp.Pdf.PdfDocument doc = new PdfSharp.Pdf.PdfDocument();
            doc.Pages.Add(new PdfSharp.Pdf.PdfPage());
            PdfSharp.Drawing.XGraphics xgr = PdfSharp.Drawing.XGraphics.FromPdfPage(doc.Pages[0]);
            PdfSharp.Drawing.XImage img = PdfSharp.Drawing.XImage.FromFile(Archivo + ".TIFF");

            xgr.DrawImage(img, 0, 0);
            doc.Save(Archivo + ".PDF");
            doc.Close();            
        }
    }
}
