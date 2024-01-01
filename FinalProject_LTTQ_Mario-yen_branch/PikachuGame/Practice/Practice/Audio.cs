using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;


namespace Practice
{
    internal class Audio
    {
        private WaveOutEvent outputDevice;
        //private AudioFileReader reader;
        private LoopStream loop;
        const string path = "YOASOBIBiri-Biri-Official-Music-Video.wav";
        private RawSourceWaveStream sound;
        public Audio()
        {
            sound = new RawSourceWaveStream(Properties.Resources.YOASOBIBiri_Biri_Official_Music_Video1,new WaveFormat());
            //reader=new AudioFileReader(path);
            loop = new LoopStream(sound);
            outputDevice=new WaveOutEvent();
            outputDevice.Init(loop);
        }
        public void PlaybackAudio()
        {
            outputDevice.Play();
        }
        public void playLoopedAudio()
        {

        }
        public void StopAudio()
        {
            outputDevice.Stop();
        }
        public void AdjustVolumeDown()
        {
            outputDevice.Volume = 0;
        }
        public void AdjustVolumeUp()
        {
            outputDevice.Volume = 1;
        }
    }
}
