using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Macro
    {
        //watching macro and wants to pause
  
        
            DispatcherTimer timer;
            DispatcherTimer timer1;


            public MainWindow()
            {
                InitializeComponent();

            }

            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                timer1 = new DispatcherTimer();
                timer1.Tick += new EventHandler(dispatcherTimer_Tick1);
                timer1.Interval = new TimeSpan(0, 0, 10);

                timer = new DispatcherTimer();
                timer.Tick += new EventHandler(dispatcherTimer_Tick);
                timer.Interval = new TimeSpan(0, 0, 5);
                video_panel.Play();




                timer1.Start();
                timer.Start();




            }

            private void dispatcherTimer_Tick(object sender, EventArgs e)
            {
                this.draw_an_elipse();

                draw_an_elipse()
            {
                    ++a;
                    txt.Text = a.ToString();



                    if (a % 5 == 0)
                    {
                        video_panel.Stop();
                        video_panel.Position = new TimeSpan(0, 18, 30);

                        video_panel.Play();
                        timer1.Start();
                    }
                }

                private void dispatcherTimer_Tick1(object sender, EventArgs e)
                {

                    video_panel.Pause();
                    timer1.Stop();
                }

            }
        }
}
