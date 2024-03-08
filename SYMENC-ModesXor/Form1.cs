namespace SYMENC_ModesXor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxKexH_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKexH.Text.Length == 2)
            {
                byte b = utils.Helpers.HexToByte(textBoxKexH.Text);
                textBoxKeyB.Text = utils.Helpers.ByteToBin(b);
            }
        }

        private void textBoxCTH1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCTH1.Text.Length == 2)
            {
                byte b = utils.Helpers.HexToByte(textBoxCTH1.Text);
                textBoxCTB1.Text = utils.Helpers.ByteToBin(b);
            }
        }

        private void buttonEnc1_Click(object sender, EventArgs e)
        {
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte clearText1 = utils.Helpers.HexToByte(textBoxCTH1.Text);
            byte result = utils.Helpers.Xor(clearText1, key);
            textBoxSTH1.Text = utils.Helpers.ByteToHex(result);
            textBoxSTB1.Text = utils.Helpers.ByteToBin(result);
        }

        private void buttonDec1_Click(object sender, EventArgs e)
        {
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte secureText1 = utils.Helpers.HexToByte(textBoxSTH1.Text);
            byte result = utils.Helpers.Xor(secureText1, key);
            textBoxDecH1.Text = utils.Helpers.ByteToHex(result);

        }

        private void buttonEnc2_Click(object sender, EventArgs e)
        {
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte clearText2 = utils.Helpers.HexToByte(textBoxCTH2.Text);
            byte result = utils.Helpers.Xor(clearText2, key);
            textBoxSTH2.Text = utils.Helpers.ByteToHex(result);
            textBoxSTB2.Text = utils.Helpers.ByteToBin(result);
        }

        private void buttonDec2_Click(object sender, EventArgs e)
        {
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte secureText2 = utils.Helpers.HexToByte(textBoxSTH2.Text);
            byte result = utils.Helpers.Xor(secureText2, key);
            textBoxDecH2.Text = utils.Helpers.ByteToHex(result);
        }

        private void textBoxCTH2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCTH2.Text.Length == 2)
            {
                byte b = utils.Helpers.HexToByte(textBoxCTH2.Text);
                textBoxCTB2.Text = utils.Helpers.ByteToBin(b);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            textBoxTest.Text = "Knopf Test gedrückt";
            Console.WriteLine("Knopf Test gedrückt");
        }
    }
}