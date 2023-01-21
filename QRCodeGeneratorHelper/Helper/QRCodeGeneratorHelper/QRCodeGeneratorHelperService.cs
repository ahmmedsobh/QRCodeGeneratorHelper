using QRCoder;

namespace QRCodeGeneratorHelper.Helper.QRCodeGeneratorHelper
{
    public class QRCodeGeneratorHelperService : IQRCodeGeneratorHelperService
    {
        public byte[] GenerateQRCode(string text)
        {
            byte[] QRCode = new byte[0];
            if(!string.IsNullOrEmpty(text))
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData data = qRCodeGenerator.CreateQrCode(text,QRCodeGenerator.ECCLevel.Q);
                BitmapByteQRCode bitmap = new BitmapByteQRCode(data);
                QRCode = bitmap.GetGraphic(20);
            }
            return QRCode;
        }
    }
}
