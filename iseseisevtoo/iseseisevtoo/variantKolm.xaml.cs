using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iseseisevtoo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class variantKolm : ContentPage
    {
        Label label_;
        Image img;
        TimePicker time_;
        public variantKolm()
        {
            //InitializeComponent();

            AbsoluteLayout absolute = new AbsoluteLayout()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            label_ = new Label()
            {
                Text = "План дня",
                TextColor = Color.Black,
                FontSize = 24
            };
            AbsoluteLayout.SetLayoutBounds(label_, new Rectangle(0.7, 0.02, 300, 50));
            AbsoluteLayout.SetLayoutFlags(label_, AbsoluteLayoutFlags.PositionProportional);
            absolute.Children.Add(label_);

            img = new Image() { Source = "time.png" };
            AbsoluteLayout.SetLayoutBounds(img, new Rectangle(0.1, 0.2, 220, 220));
            AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.PositionProportional);
            absolute.Children.Add(img);


            time_ = new TimePicker() { Time = new TimeSpan(17, 0, 0) };
            AbsoluteLayout.SetLayoutBounds(time_, new Rectangle(0.9, 0.2, 100, 50));
            AbsoluteLayout.SetLayoutFlags(time_, AbsoluteLayoutFlags.PositionProportional);
            absolute.Children.Add(time_);
            time_.PropertyChanged += Time__PropertyChanged;
            

            Content = absolute;
        }

        private void Time__PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            TimeSpan selectedTime = time_.Time;
            if (selectedTime.ToString() == "07:00:00")
            {
                label_.Text = "Время просыпаться";
                img.Source = "prosipaemsja.png";
            }
            if (selectedTime.ToString() == "07:10:00")
            {
                label_.Text = "Время умываться";
                img.Source = "umivaetsja.jpg";
            }
            if (selectedTime.ToString() == "07:20:00")
            {
                label_.Text = "Время завтракать";
                img.Source = "zavtrak.jpg"; 
            }
            if (selectedTime.ToString() == "08:00:00")
            {
                label_.Text = "Время на работу";
                img.Source = "narabotu.jpg";
            }
            if (selectedTime.ToString() == "08:30:00")
            {
                label_.Text = "Езда на работу";
                img.Source = "ezdanarabotu.jpg";
            }
            if (selectedTime.ToString() == "09:00:00")
            {
                label_.Text = "Уже на работе";
                img.Source = "rabota.jpg";
            }
            if (selectedTime.ToString() == "12:00:00")
            {
                label_.Text = "Время на обед на работе";
                img.Source = "obed.jpg";
            }
            if (selectedTime.ToString() == "15:00:00")
            {
                label_.Text = "Время на кофе";
                img.Source = "kofe.jpg";
            }
            if (selectedTime.ToString() == "17:00:00")
            {
                label_.Text = "Время ехать домой";
                img.Source = "domoi.png";
            }
            if (selectedTime.ToString() == "18:00:00")
            {
                label_.Text = "Приехать домой";
                img.Source = "priexalDomoi.png";
            }
            if (selectedTime.ToString() == "19:00:00")
            {
                label_.Text = "Отдых";
                img.Source = "otdix.png";
            }
            if (selectedTime.ToString() == "22:00:00")
            {
                label_.Text = "Время спать";
                img.Source = "son.png";
            }
        }
    }
}