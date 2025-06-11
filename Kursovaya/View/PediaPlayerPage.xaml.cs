using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Kursovaya.View
{
    /// <summary>
    /// Логика взаимодействия для PediaPlayerPage.xaml
    /// </summary>
    public partial class PediaPlayerPage : UserControl
    {
        private DispatcherTimer timer;

        public PediaPlayerPage(string videoPath)
        {
            InitializeComponent();
            mediaPlayer.Source = new Uri(videoPath, UriKind.Absolute);
            mediaPlayer.MediaOpened += MediaPlayer_MediaOpened;
            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;

            // Таймер для обновления слайдера
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
        }

        private void MediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                positionSlider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                timer.Start();
                mediaPlayer.Play();
            }
        }

        private void MediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            mediaPlayer.Stop();
            positionSlider.Value = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                positionSlider.Value = mediaPlayer.Position.TotalSeconds;
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            positionSlider.Value = 0;
        }

        private void PositionSlider_PreviewMouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                mediaPlayer.Position = TimeSpan.FromSeconds(positionSlider.Value);
            }
        }
    }
}
