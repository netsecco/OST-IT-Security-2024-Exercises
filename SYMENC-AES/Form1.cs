using utils;

namespace SYMENC_AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            byte[] key = utils.Helpers.HexStringToByteArray(textBoxKey.Text);
            byte[] iv = utils.Helpers.HexStringToByteArray(textBoxIV.Text);

            AesCryptor.init();
            AesCryptor.Key = key;
            AesCryptor.IV = iv;
            byte[] cipherText = AesCryptor.encrypt(textBoxCleartext.Text);
            textBoxCipherText.Text = utils.Helpers.Base64Encode(cipherText);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            byte[] key = utils.Helpers.HexStringToByteArray(textBoxKey.Text);
            byte[] iv = utils.Helpers.HexStringToByteArray(textBoxIV.Text);

            AesCryptor.init();
            AesCryptor.Key = key;
            AesCryptor.IV = iv;

            byte[] cipherText = utils.Helpers.Base64Decode(textBoxCipherText.Text);

            string clearText = AesCryptor.decrypt(cipherText);

            textBoxDecryptedText.Text = clearText;

        }
    }
}