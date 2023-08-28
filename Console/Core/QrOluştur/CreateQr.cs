using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Console.Core.QrOluştur
{
    public class CreateQr
    {
        public static Bitmap Create<T>(T obje)
        {
            string jsonObje = JsonSerializer.Serialize(obje);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(jsonObje, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5, "#FF0000", "#FFFFFF");
            return qrCodeImage;
        }
        public static Bitmap Create(string seriNumarasi)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(seriNumarasi, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5, "#FF0000", "#FFFFFF");
            return qrCodeImage;
        }
    }

}
