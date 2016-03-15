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
            //Playerin ja Opponentin luominen
            Player player = new Player();
            Opponent opponent = new Opponent();

            // Playerin tietojen määrittäminen
            LevelTextBlock.Text = "Level:1";
            HitPointsBar.Value = player.HitPoints;
            HitPointsBar.Maximum = player.HitPoints;
            BlockTextBlock.Text = "Block:1";
            StaminaBar.Value = player.Stamina;
            StaminaBar.Maximum = player.Stamina;

            // Opponentin tietojen määrittäminen
            OpponentLevelTextBlock.Text = "Level:1";
            OpponentHitPointsBar.Value = opponent.HitPoints;
            OpponentHitPointsBar.Maximum = opponent.HitPoints;
            OpponentBlockTextBlock.Text = "Block:1";
            OpponentStaminaBar.Value = opponent.Stamina;
            OpponentStaminaBar.Maximum = opponent.Stamina;
        }

        private void PlayerAttackButton_Click(object sender, RoutedEventArgs e)
        {
            //opponent.Hitpoints = weapon1.Damage-opponent.Block; 
            InfoTextBlock.Text = "Attack!";
        }
    }
}
