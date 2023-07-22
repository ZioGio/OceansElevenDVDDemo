using System;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace OceansElevenDVDDemo.Controls
{
    public sealed partial class DVDMenuControl : UserControl
    {
        private MediaPlayer mediaPlayer;

        public DVDMenuControl()
        {
            InitializeComponent();
        }

        private void SbIntroPart1_Completed(object sender, object e)
        {
            // Stop media and load/unload elements    
            mediaPlayer.Dispose();
            sbIntroPart1.Stop();
            UnloadObject(VerticalDots);
            UnloadObject(Numbers1To10);
            FindName("HorizontalDots");
            FindName("MenuPart2");

            // Start Storyboard and music
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Media/IntroMusicPart2.wma"));
            mediaPlayer.Play();
            sbIntroPart2.Begin();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            // Load and unload elements
            UnloadObject(btnStart);
            FindName("VerticalDots");
            FindName("Numbers1To10");
            FindName("Number11");

            // Start media
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Media/IntroMusicPart1.wma"));
            mediaPlayer.Play();
            sbIntroPart1.Begin();
        }

        private void SbIntroPart2_Completed(object sender, object e)
        {
            mediaPlayer.Dispose();
        }
    }
}