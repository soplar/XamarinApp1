using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
        static string bomb = new Random().Next(1, 4).ToString();
        int scores;
        public MainPage()
		{
			InitializeComponent();
		}
        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // game over
            if (button.Text == bomb)
            {
                await DisplayAlert("Bomb exploded", "Game over", "Retry");
                bomb = new Random().Next(1, 4).ToString();
                scores = 0;
            }
            else
            {
                scores += 1;
                await DisplayAlert("Bomb defused", "Scores: " + scores, "continue");
                bomb = new Random().Next(1, 4).ToString();
            }
        }
	}
}
