using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMC_SLOT
{
    public partial class Prize : Form
    {
        //field
        private int _result;
        private List<int> _numbers;
        private List<int> _zanNumbers;
        private List<int> _selectedPrize;
        private List<int> _atariZumi;
        private Main _Main;
        public List<int> ZanPrizes
        {
            get
            {
                List<int> list = new List<int>();

                for (int i = 1; i < _numbers.Count + 1; i++)
                {
                    list.Add(i);
                }

                if (_selectedPrize.Count != 0)
                {
                    foreach (var prize in _selectedPrize)
                    {
                        list.Remove(prize);
                    }

                    List<int> list2 = _atariZumi.Except(_selectedPrize).ToList();

                    foreach (var l in list2)
                    {
                        list.Add(l);
                    }
                }
                return list;
            }
        }
        //選択可能な景品
        //当たりの番号以下の景品 -選択済みの景品 + [当たったけど違う番号の景品だったから選べる景品（当たり済みと選択済みの差集合）]
        public List<int> ChoosablePrizes
        {
            get
            {
                List<int> list = new List<int>();

                for (int i = _result; i < _numbers.Count + 1; i++)
                {
                    list.Add(i);
                }

                if (_selectedPrize.Count != 0)
                {
                    foreach (var prize in _selectedPrize)
                    {
                        list.Remove(prize);
                    }

                    List<int> list2 = _atariZumi.Except(_selectedPrize).ToList();

                    foreach (var l in list2)
                    {
                        list.Add(l);
                    }
                }
                return list;
            }
        }
        private int selectingPrizeNo = 0;
        private string selectingPrizeName;
        private ImageList imageList1;

        public Prize()
        {
            InitializeComponent();
        }

        public Prize(List<int> atari, List<int> selected, List<int> numbers, List<int> zanNumbers)
        {
            //選ばれていない景品一覧みるだけ
            InitializeComponent();

            _numbers = numbers;
            _zanNumbers = zanNumbers;
            _atariZumi = atari;
            _selectedPrize = selected;

            //セリフを非表示
            this.fukidashiBox1.Visible = false;

            GetThumbnail(ZanPrizes);

            this.Enabled = false;
        }

        public Prize(int result, List<int> atari, List<int> selected, List<int> numbers, List<int> zanNumbers, Main Main)
        {
            InitializeComponent();

            _numbers = numbers;
            _zanNumbers = zanNumbers;
            _result = result;
            _atariZumi = atari;
            _selectedPrize = selected;
            _Main = Main;

            GetThumbnail(ChoosablePrizes);
        }

        private void ShowMessage()
        {
            //景品名 + 画像のセリフ
            this.prizeNameLabel.Text = selectingPrizeName;
            this.fukidashiBox1.Image = global::SMC_SLOT.Properties.Resources.fukidashi_select;

            this.prizeNameLabel.Visible = true;
            this.yesLabel.Visible = true;
            this.noLabel.Visible = true;
            this.fukidashiPanel1.Visible = true;
        }

        //はい
        private void Yes_Click(object sender, EventArgs e)
        {
            _selectedPrize.Add(selectingPrizeNo);
            _atariZumi.Add(_result);

            this.fukidashiBox1.Image = global::SMC_SLOT.Properties.Resources.fukidashi_thanks;

            //全画像を選択不可にする
            listView1.Visible = false;

            this.prizeNameLabel.Visible = false;
            this.yesLabel.Visible = false;
            this.noLabel.Visible = false;
            this.fukidashiPanel1.Visible = false;

            this.backLabel.Visible = true;
            this.fukidashiPanel2.Visible = true;

            //引かれたあたりを非表示
            if (_selectedPrize.Count == _zanNumbers.Count)
            {
                this.prizeNameLabel.Text = "終わりでーす";
                this.prizeNameLabel.Visible = true;
            }
            else
            {
                string ss = "label" + _result;
                Panel f1Panel = (Panel)_Main.Controls["panel1"];
                Label zanAtariLabel = (Label)f1Panel.Controls[ss];
                zanAtariLabel.BackColor = System.Drawing.Color.Gray;
            }
        }

        //いいえ
        private void No_Click(object sender, EventArgs e)
        {
            this.fukidashiBox1.Image = global::SMC_SLOT.Properties.Resources.fukidashi_initial;
            this.prizeNameLabel.Visible = false;
            this.yesLabel.Visible = false;
            this.noLabel.Visible = false;
            this.fukidashiPanel1.Visible = false;
        }

        //戻るボタン
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Button f1_spb = (Button)_Main.Controls["selectPrizeButton"];
            f1_spb.Enabled = false;

        }

        //景品画像選択イベント
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選択された景品の名前と番号を保持
            selectingPrizeName = listView1.SelectedItems[0].Text;
            selectingPrizeNo = int.Parse(listView1.SelectedItems[0].ImageKey);
            ShowMessage();
            listView1.SelectedItems.Clear();
        }

        //景品一覧画像を取得
        public void GetThumbnail(IEnumerable<int> list)
        {
            imageList1 = new ImageList();
            listView1.LargeImageList = imageList1;

            string imageDir = @"C:\Users\m_kajihara\source\repos\SMC-SLOT\SMC-SLOT\PrizeImages";
            string[] pngFiles = System.IO.Directory.GetFiles(imageDir, "*.png");

            int width = 200;
            int height = 200;

            imageList1.ImageSize = new Size(width, height);
            listView1.LargeImageList = imageList1;

            // imageList , listView 登録
            for (int i = 1; i < pngFiles.Length; i++)
            {
                String F_Name = Path.GetFileNameWithoutExtension(pngFiles[i]);
                string[] F_Name_Arr = F_Name.Split('_');

                Image original = Bitmap.FromFile(pngFiles[i]);
                Image unavailable = Bitmap.FromFile(pngFiles[0]);
                Image thumbnail;

                //残りの景品(ZanPrizes) or 取得可能な景品(ChoosablePrizes)を表示
                if (list.Contains(int.Parse(F_Name_Arr[0])))
                {
                    thumbnail = createThumbnail(original, width, height);
                }
                else
                {
                    thumbnail = createThumbnail(unavailable, width, height);
                }

                imageList1.Images.Add(F_Name_Arr[0], thumbnail);

                listView1.Items.Add(F_Name_Arr[1], F_Name_Arr[0]);
            }
        }

        // 幅w、高さhのImageオブジェクトを作成
        private Image createThumbnail(Image image, int w, int h)
        {
            Bitmap canvas = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, w, h);

            float fw = (float)w / (float)image.Width;
            float fh = (float)h / (float)image.Height;

            float scale = Math.Min(fw, fh);
            fw = image.Width * scale;
            fh = image.Height * scale;

            g.DrawImage(image, (w - fw) / 2, (h - fh) / 2, fw, fh);
            g.Dispose();

            return canvas;
        }
    }
}
