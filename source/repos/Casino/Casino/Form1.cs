using System.Diagnostics;
using System.Reflection;

namespace Casino
{
    public partial class Form1 : Form
    {
        SlotMachine.SlotMachine sm = new SlotMachine.SlotMachine();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animate(pictureBox1, false);
            Animate(pictureBox2, false);
        }
        void Animate(PictureBox pictureBox, bool animate)
        {
            var animateMethod = typeof(PictureBox).GetMethod("Animate",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance,
                null, new Type[] { typeof(bool) }, null);
            animateMethod.Invoke(pictureBox, new object[] { animate });
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Animate(pictureBox1, true);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Animate(pictureBox1, false);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            sm.Show();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Animate(pictureBox2, true);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Animate(pictureBox2, false);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string wpfRoulettePath = @"C:\Users\nikpe\source\repos\Casino\CasinoWpfV2.0\bin\Debug\net6.0-windows\CasinoWpfV2.0.exe";
            Process.Start(wpfRoulettePath);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            Animate(pictureBox3, true);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Animate(pictureBox3, false);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var bj = new Blackjack.Form1();
            bj.Show();
        }
    }
}