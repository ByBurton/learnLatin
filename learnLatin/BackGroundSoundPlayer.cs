//-------------------------------------------------------------------------------------------------
//Author: Maederer
//Company: page one GmbH
//Created: December, 18th, 2017
//File: Filename
//Short Description: background sound
//-------------------------------------------------------------------------------------------------


using System;
using System.Media;
using System.Windows.Media;

namespace learnLatin
{
    public static class BackGroundSoundPlayer
    {
        public static void Play(String FileName)
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri(FileName, UriKind.Relative));
            player.Play();
        }
    }

    public class BackGroundSound
    {
        public SoundPlayer BackgroundSoundPlayer;

        public BackGroundSound(String wavFile)
        {
            this.BackgroundSoundPlayer = new SoundPlayer(wavFile);
            this.BackgroundSoundPlayer.PlayLooping();
        }
    }
}
