namespace atrakcjeZamoscia
{
    public partial class MainPage : ContentPage
    {
        int likeLiczba = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void onPolubClicked(object sender, EventArgs e)
        {
            likeLiczba++;
            lblLike.Text = $"Polubień: {likeLiczba.ToString()}";
        }

        private void onNiePolubClicked(object sender, EventArgs e)
        {
            if (likeLiczba > 0)
                likeLiczba--;
            lblLike.Text = $"Polubień: {likeLiczba}";
        }
    }

}
