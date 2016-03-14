/*
* Created: 8.3.2016 
* Authors: Albert Kuusjärvi
*/
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HarjoitustyöApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();

            //Playerin ja Opponentin luominen
            Player Player = new Player();
            Opponent Opponent = new Opponent();

            // Playerin tietojen määrittäminen
            LevelTextBlock.Text = "Level:1";
            HitPointsBar.Value = Player.HitPoints;
            HitPointsBar.Maximum = Player.HitPoints;
            BlockTextBlock.Text = "Block:1";
            StaminaBar.Value = Player.Stamina;
            StaminaBar.Maximum = Player.Stamina;

            // Opponentin tietojen määrittäminen
            OpponentLevelTextBlock.Text = "Level:1";
            OpponentHitPointsBar.Value = Opponent.HitPoints;
            OpponentHitPointsBar.Maximum = Opponent.HitPoints;
            OpponentBlockTextBlock.Text = "Block:1";
            OpponentStaminaBar.Value = Opponent.Stamina;
            OpponentStaminaBar.Maximum = Opponent.Stamina;
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null) return;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void CreateCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void PlayerAttackButton_Click(object sender, RoutedEventArgs e)
        {
            InfoTextBlock.Text = "Attack!";
        }
    }
}
