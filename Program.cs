using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using static QRCoder.QRCodeGenerator;


namespace QRCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(" O texto que deve ser codificado. ", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
        }
    }
}
