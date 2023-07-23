using System;
using Windows.Media.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace OceansElevenDVDDemo.Controls
{
    public sealed partial class DVDMenuControl : UserControl
    {
        private MediaPlayerElement mediaPlayerElement;
        private const string MusicPart1File = "ms-appx:///Assets/Media/IntroMusicPart1.wma";
        private const string MusicPart2File = "ms-appx:///Assets/Media/IntroMusicPart2.wma";

        public DVDMenuControl()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            // Load and unload elements
            UnloadObject(btnStart);
            FindName("VerticalDots");
            FindName("Numbers1To10");
            FindName("Number11");

            // Start media
            Play(MusicPart1File);
            sbIntroPart1.Begin();
        }

        private void SbIntroPart1_Completed(object sender, object e)
        {
            // Stop media and load/unload elements    
            sbIntroPart1.Stop();
            UnloadObject(VerticalDots);
            UnloadObject(Numbers1To10);
            FindName("HorizontalDots");
            FindName("MenuPart2");

            // Start media
            Play(MusicPart2File);
            sbIntroPart2.Begin();
        }

        private void Play(string fileName)
        {
            mediaPlayerElement = new MediaPlayerElement();
            mediaPlayerElement.Source = MediaSource.CreateFromUri(new Uri(fileName));
            // The two lines below are what act as the mediaElement.Play() equivelant 
            mediaPlayerElement.AutoPlay = true;
            LayoutRoot.Children.Add(mediaPlayerElement);
        }
    }
}