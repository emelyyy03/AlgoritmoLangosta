namespace AlgoritmoLangosta
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNP.Text))
            {
                double NP, pago;
                NP = Convert.ToDouble(entryNP.Text);
                if (NP >= 300 )
                {
                    pago = NP * 75;
                }
                else if (NP >= 200 && NP <= 300)
                {
                    pago = NP * 85;
                }
                else
                {
                    pago = NP * 95;
                }
                entryPago.Text = pago.ToString();
            }
        }
    }
}
