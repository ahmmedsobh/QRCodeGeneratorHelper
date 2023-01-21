namespace QRCodeGeneratorHelper.Helper.QRCodeGeneratorHelper
{
    public interface IQRCodeGeneratorHelperService
    {
        byte[] GenerateQRCode(string text);
    }
}
