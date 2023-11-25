using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace oppfinal
{
    public partial class Setting : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;
        public Setting()
        {
            InitializeComponent();
            InitializeNAudio();
            Application.OpenForms["GameMenu"].Hide();
        }
        private void InitializeNAudio()
        {
            // Khởi tạo WaveOutEvent và AudioFileReader với một tập tin âm thanh hoặc nguồn âm thanh
            waveOut = new WaveOutEvent();
            audioFile = new AudioFileReader("./bgmusic.mp3"); // Thay đổi đường dẫn phù hợp

            // Kết nối AudioFileReader với WaveOutEvent
            waveOut.Init(audioFile);
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            trackBar1.Value = int.Parse(lblsound.Text);
            trackBar1.ValueChanged  += trackBar1_ValueChanged;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblsound.Text = trackBar1.Value.ToString();
            
            
        }
        

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị của TrackBar và chuyển đổi nó thành giá trị âm lượng (ví dụ: 0-1)
            float volume = trackBar1.Value / 100.0f;

            
            // Đặt âm lượng cho WaveOutEvent
            waveOut.Volume = volume;
        }

        private void btnback_MouseHover(object sender, EventArgs e)
        {
            btnback.Image = Properties.Resources.back_hover;
        }

        private void btnback_MouseLeave(object sender, EventArgs e)
        {
            btnback.Image = Properties.Resources.back;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            //đóng tab hiện tại vào mở lại game menu
            this.Close();
            GameMenu gm = new GameMenu();
            gm.Show();
                       
        }
    }
}
