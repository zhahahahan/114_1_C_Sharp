using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly Random rng = new();

        private enum RPS { Rock = 0, Paper = 1, Scissors = 2 }

        private int playerWins = 0, computerWins = 0, draws = 0;

        public Form1()
        {
            InitializeComponent();
            ShowImage(pbComputerHand, RPS.Rock, false);
            ShowImage(pbPlayerHand, RPS.Paper, true);
            lblResult.Text = "請出拳";
        }

        private void Play(RPS player)
        {
            var computer = (RPS)rng.Next(0, 3);

            ShowImage(pbPlayerHand, player, true);
            ShowImage(pbComputerHand, computer, false);

            int diff = ((int)player - (int)computer + 3) % 3;
            if (diff == 0)
            {
                draws++;
                lblResult.Text = "平手";
                lblResult.ForeColor = Color.Black;
            }
            else if (diff == 1)
            {
                playerWins++;
                lblResult.Text = "玩家贏";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                computerWins++;
                lblResult.Text = "電腦贏";
                lblResult.ForeColor = Color.DarkRed;
            }
        }

        private void ShowImage(PictureBox pb, RPS choice, bool isPlayer)
        {
            Image res = isPlayer ? choice switch
            {
                RPS.Rock => Properties.Resources.stone_player,
                RPS.Paper => Properties.Resources.paper_player,
                RPS.Scissors => Properties.Resources.scissor_player,
                _ => null
            }
            : choice switch
            {
                RPS.Rock => Properties.Resources.stone_computer,
                RPS.Paper => Properties.Resources.paper_computer,
                RPS.Scissors => Properties.Resources.scissor_computer,
                _ => null
            };

            if (res != null)
            {
                int w = Math.Max(1, pb.ClientSize.Width);
                int h = Math.Max(1, pb.ClientSize.Height);
                pb.Image = new Bitmap(res, w, h);
            }
            else
            {
                string emoji = choice switch { RPS.Rock => "👊", RPS.Paper => "✋", _ => "✌️" };
                pb.Image = EmojiToBitmap(emoji, pb.ClientSize);
            }
        }

        private Image EmojiToBitmap(string emoji, Size size)
        {
            if (size.Width <= 0 || size.Height <= 0) size = new Size(200, 120);
            var bmp = new Bitmap(size.Width, size.Height);
            using var g = Graphics.FromImage(bmp);
            g.Clear(SystemColors.Control);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            float fontSize = Math.Min(size.Width, size.Height) * 0.8f;
            using var font = new Font("Segoe UI Emoji", fontSize, GraphicsUnit.Pixel);
            using var brush = new SolidBrush(Color.Black);
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(emoji, font, brush, new RectangleF(0, 0, size.Width, size.Height), sf);
            return bmp;
        }

        private void showFinalResult()
        {
            string overall = playerWins > computerWins ? "玩家總體勝利"
                : computerWins > playerWins ? "電腦總體勝利" : "雙方平手";

            string message = $"最終結果:\r\n玩家: {playerWins}\r\n電腦: {computerWins}\r\n平手: {draws}\r\n\r\n{overall}";
            lblResult.Text = overall + $" — 玩家:{playerWins} 電腦:{computerWins} 平手:{draws}";
            lblResult.ForeColor = playerWins > computerWins ? Color.Green : (computerWins > playerWins ? Color.DarkRed : Color.Black);
            FlashResultBorder();
            MessageBox.Show(message, "遊戲結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // event handlers
        private void btnRock_Click(object sender, EventArgs e) => Play(RPS.Rock);
        private void btnPaper_Click(object sender, EventArgs e) => Play(RPS.Paper);
        private void btnScissors_Click(object sender, EventArgs e) => Play(RPS.Scissors);
        private void btnExit_Click(object sender, EventArgs e)
        {
            showFinalResult();
            Close();
        }

        private async void FlashResultBorder()
        {
            var original = lblResult.BorderStyle;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            await System.Threading.Tasks.Task.Delay(220);
            lblResult.BorderStyle = original;
        }

        // designer stubs
        private void lblPlayerHand_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
