using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FT_Soundboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent(); //launch app
        }

        //Event handlers to play the sound

        //========== TED SOUNDS ================================================================================================

        private void playSoundButton_Click(object sender, RoutedEventArgs e)
        {
            ted.Play(); // media element has the source of the sound. Then assign it to the Play function that is already a defualt function in library.
        }

        private void ted2_Click(object sender, RoutedEventArgs e)
        {
            ted2.Play();
        }

        private void lovelybottom_Click(object sender, RoutedEventArgs e)
        {
            ted3.Play();
        }

        private void theyallhave_Click(object sender, RoutedEventArgs e)
        {
            ted4.Play();
        }

        //====== DOUGAL SOUNDS =================================================================================

        private void playSoundButton2_Click(object sender, RoutedEventArgs e)
        {
            dougal1.Play();
        }

        private void kurtcobain_Click(object sender, RoutedEventArgs e)
        {
            dougal2.Play();
        }

        private void whoAreYou_Click(object sender, RoutedEventArgs e)
        {
            dougal3.Play();
        }

        private void illmakethetea_Click(object sender, RoutedEventArgs e)
        {
            dougal4.Play();
        }

        //======== JACK SOUNDS ==================================================================================

        private void playSoundButton3_Click(object sender, RoutedEventArgs e)
        {
            jack.Play();
        }

        private void playSoundButton5_Click(object sender, RoutedEventArgs e)
        {
            jack2.Play();
        }

        private void ecumenicalmatter_Click(object sender, RoutedEventArgs e)
        {
            jack3.Play();
        }

        private void jacobscreek_Click(object sender, RoutedEventArgs e)
        {
            jack4.Play();
        }

        private void rats_Click(object sender, RoutedEventArgs e)
        {
            jack5.Play();
        }




        //OTHER SOUNDS=========================================================================================

        private void nicepints_Click(object sender, RoutedEventArgs e)
        {
            patmustard.Play();
        }

        private void justshutup1_Click(object sender, RoutedEventArgs e)
        {
            justshutup.Play();
        }

        private void noelfurlong1_Click(object sender, RoutedEventArgs e)
        {
            noelfurlong.Play();
        }


        private void gorgeous_Click(object sender, RoutedEventArgs e)
        {
            patmustard2.Play();
        }


        private void spreadmyselfaround_Click(object sender, RoutedEventArgs e)
        {
            patmustard3.Play();
        }

        private void exhaustion_Click(object sender, RoutedEventArgs e)
        {
            patmustard4.Play();
        }

    
    }
}
