using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace oppfinal
{
    public partial class Form1 : Form
        
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;


        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
            InitializeNAudio();
            waveOut.Play();

        }
        private void InitializeNAudio()
        {
            // Khởi tạo WaveOutEvent và AudioFileReader với một tập tin âm thanh hoặc nguồn âm thanh
            waveOut = new WaveOutEvent();
            audioFile = new AudioFileReader("./bgmusic.mp3"); // Thay đổi đường dẫn phù hợp

            // Kết nối AudioFileReader với WaveOutEvent
            waveOut.Init(audioFile);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(Opacity < 100)
            {
                Opacity += 0.05;
                progressBar1.Increment(2);
            }
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                GameMenu option = new GameMenu();
                option.ShowDialog();
                
                
                   
                


            }
        }

        
    }
}
