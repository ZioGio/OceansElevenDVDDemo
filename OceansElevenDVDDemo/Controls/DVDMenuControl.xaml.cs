using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace OceansElevenDVDDemo.Controls
{
    public sealed partial class DVDMenuControl : UserControl
    {
        public DVDMenuControl()
        {
            InitializeComponent();
            VerticalDots.Opacity = 0;
            HorizontalDots.Opacity = 0;
            Numbers.Opacity = 0;
            MenuPart2.Opacity = 0;
        }

        private void SbIntroPart1_Completed(object sender, object e)
        {
            sbIntroPart1.Stop();
            IntroMusicPart1.Stop();
            sbIntroPart2.Begin();
            IntroMusicPart2.Play();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Opacity = 0;
            VerticalDots.Opacity = 1;
            HorizontalDots.Opacity = 1;
            Numbers.Opacity = 1;
            MenuPart2.Opacity = 1;
            sbIntroPart1.Begin();
            IntroMusicPart1.Play();
        }
    }
}