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
using System.Threading;

namespace Wpfball
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DispatcherTimer timer = new DispatcherTimer();
        static DispatcherTimer timerbola13 = new DispatcherTimer();
        static int movx1 = 1;
        static int movy1 = 1;
        static int movx13 = 1;
        static int movy13 = 1;
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += timer_tick;
            timerbola13.Tick += timerbola13_tick;
        }

        private void timerbola13_tick(object sender, EventArgs e)
        {
            timerbola13.Interval = new TimeSpan((long)SlideVolocidad13.Value);
            label_13.Content = (int)SlideVolocidad13.Value;
            Canvas.SetTop(bola13, Canvas.GetTop(bola13) + movy13);
            Canvas.SetLeft(bola13, Canvas.GetLeft(bola13) + movx13);
            if (Canvas.GetTop(bola13) == 0 || Canvas.GetTop(bola13) == CanvasVerde.Height - bola13.Height)
            {
                movy13 *= -1;
            }
            if (Canvas.GetLeft(bola13) == 0 || Canvas.GetLeft(bola13) == CanvasVerde.Width - bola13.Width)
            {
                movx13 *= -1;
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            timer.Interval = new TimeSpan((long)SlideVolocidad.Value);
            label_8.Content = (int)SlideVolocidad.Value;
            Canvas.SetTop(bola8, Canvas.GetTop(bola8) + movy1);
            Canvas.SetLeft(bola8, Canvas.GetLeft(bola8) + movx1);
            if (Canvas.GetTop(bola8) == 0 || Canvas.GetTop(bola8) == CanvasVerde.Height-bola8.Height)
            {
                movy1 *= -1;
            }
            if (Canvas.GetLeft(bola8) == 0 || Canvas.GetLeft(bola8) == CanvasVerde.Width - bola8.Width)
            {
                movx1 *= -1;
            }
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                btnInicio.Content = "En movimiento";
            }
            else
            {
                timer.Start();
                timerbola13.Start();
                btnInicio.Content = "En movimiento";
                btnPausa.Content = "Pausar";
            }
        }

        private void btnPausa_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
                timerbola13.Stop();
                btnPausa.Content = "En pausa";
                btnInicio.Content = "Iniciar";
            }
            else
            {
                btnInicio.Content = "Iniciar";
            }
        }

    }
}
