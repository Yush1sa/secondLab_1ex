namespace secondLab_1ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tAHBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tAMBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Logic
    {
        public static string CalcTrainLocation(int tAH, int tAM, int tDH, int tDM, int hH, int hM)
        {
            var outMessage = "";
            if (tAH > tDH || (tAH == tDH && tAM > tDM))
            {
                if ((tAH == hH && tDH == hH && (hM > tAM || hM < tDM)) || (tAH > hH && tDH > hH) || (tDH == hH && tDM > hM))
                {
                    outMessage = "Поезд у пирона";
                }
                else
                {
                    outMessage = "Поезда нет ;(";
                }
                return outMessage;
            }
            else if (tAH <= tDH)
            {
                if (((tAH == hH && tAM < hM) && (tDH == hH && tDM > hM)) || (tAH == hH && tDH > hH && tAM <= hM))
                {
                    outMessage = "Поезд у пирона";
                }
                else if ((tDH == hH && tAH < hH && tDM >= hM) || (tAH < hH && tDH > hH))
                {
                    outMessage = "Поезд у пирона";
                }
                else
                {
                    outMessage = "Поезда нет ;(";
                }
                return outMessage;
            }
            else
            {
                outMessage = "error";
                return outMessage;
            }

        }
    }
}
