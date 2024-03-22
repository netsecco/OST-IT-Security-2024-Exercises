using static System.Net.Mime.MediaTypeNames;

namespace ASYM_SM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {
            UInt64 p, q;

            if (TryTextToUInt64(textBoxP.Text, out p))
            {
                if (TryTextToUInt64(textBoxQ.Text, out q))
                {
                    UInt64 N = p * q;
                    UInt64 phi = (p - 1) * (q - 1);
                    textBoxN.Text = N.ToString();
                    textBoxPhi.Text = phi.ToString();
                }
            }
        }

        private bool TryTextToUInt64(string text, out UInt64 value)
        {
            return UInt64.TryParse(text, out value);
        }

        private UInt64 power(UInt64 b, UInt64 e, UInt64 modulus)
        {
            UInt64 result = b;
            for (int i = 1; i < (int)e; i++)
            {
                result = result * b % modulus;
            }
            return result;
        }



        private bool parseAll(out UInt64 n, out UInt64 d, out UInt64 e)
        {
            n = 0; d = 0; e = 0;

            if (TryTextToUInt64(textBoxN.Text, out n))
            {
                if (TryTextToUInt64(textBoxD.Text, out d))
                {
                    if (TryTextToUInt64(textBoxE.Text, out e))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void buttonEncrypt_Click(object sender, EventArgs ea)
        {
            UInt64 n, d, e, m;
            if (parseAll(out n, out d, out e))
            {
                if (TryTextToUInt64(textBoxClearValue.Text, out m))
                {
                    UInt64 c = power(m, e, n);
                    textBoxCipherValue.Text = c.ToString();
                }
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs ea)
        {
            UInt64 n, d, e, c;
            if (parseAll(out n, out d, out e))
            {
                if (TryTextToUInt64(textBoxCipherValue.Text, out c))
                {
                    UInt64 m = power(c, d, n);
                    textBoxDecryptedValue.Text = m.ToString();
                }
            }
        }


    }
}