using SMC_SLOT.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SMC_SLOT
{
    public partial class Main : Form
    {
        public bool exit;
        public int latestResult = 0;
        public bool slotting;
        public bool kakuhen;

        public List<int> numbers = new List<int>();
        public List<int> zanNumbers = new List<int>();
        public List<int> atari = new List<int>();
        public List<int> selected = new List<int>();
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public ResourceManager rm;

        public Main()
        {
            InitializeComponent();

            //リソースマネージャー
            rm = SMC_SLOT.Properties.Resources.ResourceManager;

            //当たりの数初期化
            for (int index = 1; index < 15; index++)
            {
                numbers.Add(index);
            }

            zanNumbers = new List<int>(numbers);

            foreach (var slot in numbers)
            {
                string s = "label" + slot;
                Control[] c = this.Controls.Find(s, true);
                ((Label)c[0]).Visible = true;
            }
        }

        private void slot_Click(object sender, EventArgs e)
        {
            //スロットは回っているか
            if(slotting)
            {
                slotting = !slotting;


                //回転終了
                StopSlot();
                this.pictureBox4.Image = global::SMC_SLOT.Properties.Resources.off;
                this.startSlotButton.Text = "START";

                //確変リセット
                kakuhen = false;
                pictureBox_kaku.Visible = pictureBox_hen.Visible = pictureBox_totsu.Visible = pictureBox_nyu.Visible = false;
                wmp.controls.stop();
            }
            else
            {
                //５分の１の確率で確変突入
                Random r = new Random();
                if (r.Next(1, 10) > 8)
                {
                    kakuhen = true;
                    wmp.URL = @"Resources\vanilla.mp3";
                    wmp.controls.play();
                }

                slotting = !slotting;
                //回転開始
                StartSlot();
                this.pictureBox4.Image = global::SMC_SLOT.Properties.Resources.on;
                this.startSlotButton.Text = "STOP";

            }

        }

        private async void StartSlot()
        {
            int i = 1;
            while (slotting)
            {
                if (i <= numbers.Count - 2)
                {
                    this.UpsidePictureBox.Image = (Bitmap)rm.GetObject(i.ToString());
                    this.ResultPictureBox.Image = (Bitmap)rm.GetObject((i + 1).ToString());
                    this.DownPictureBox.Image = (Bitmap)rm.GetObject((i + 2).ToString());

                }
                else
                {
                    if(i == numbers.Count - 1)
                    {
                        this.UpsidePictureBox.Image = (Bitmap)rm.GetObject((i - 1).ToString());
                        this.ResultPictureBox.Image = (Bitmap)rm.GetObject(i.ToString());
                        this.DownPictureBox.Image = (Bitmap)rm.GetObject("1");
                    }
                    else if(i == numbers.Count)
                    {
                        this.UpsidePictureBox.Image = (Bitmap)rm.GetObject(i.ToString());
                        this.ResultPictureBox.Image = (Bitmap)rm.GetObject("1");
                        this.DownPictureBox.Image = (Bitmap)rm.GetObject("2");
                    }
                }

                if (i == numbers.Count)
                {
                    i = 0;
                }
                i++;

                if (kakuhen)
                {
                    if (pictureBox_hen.Visible) 
                    { 
                        pictureBox_kaku.Visible = pictureBox_hen.Visible = pictureBox_totsu.Visible = pictureBox_nyu.Visible = false;
                    }
                    else
                    {
                        pictureBox_kaku.Visible = pictureBox_hen.Visible = pictureBox_totsu.Visible = pictureBox_nyu.Visible = true;
                    }
                }

                await Task.Delay(50);
            }
        }

        private void StopSlot()
        {
            exit = true;
            Random r1 = new System.Random();
            //1～14 の乱数生成
            while (exit)
            {
                int i = r1.Next(1, 15);

                //確変中に●等以下なら引き直し
                if(kakuhen && i > 7)
                {
                        kakuhen = !kakuhen;
                        continue;
                }

                if (!atari.Contains(i))
                {
                    if (zanNumbers.Contains(i))
                    {
                        latestResult = i;
                        exit = false;
                    }
                }
            }

            //結果を表示
            this.ResultPictureBox.Image = (Bitmap)rm.GetObject(latestResult.ToString());

            //景品選択をさせるためにスロット開始ボタンを非活性、景品選択ボタンを活性化
            this.startSlotButton.Enabled = false;
            this.selectPrizeButton.Enabled = true;
        }

        private void selectPrizeButton_Click(object sender, EventArgs e)
        {
            //景品選択画面へ移動
            Prize prize = new Prize(latestResult, atari, selected, numbers, zanNumbers, this);
            prize.Show();

            this.startSlotButton.Enabled = true;
        }

        private void checkPrize_Click(object sender, EventArgs e)
        {
            //景品一覧画面に移動
            Prize prize = new Prize(atari, selected, numbers, zanNumbers);
            prize.Show();
        }

        //〇当選択イベント
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
