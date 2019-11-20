using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOutDemo3
{

    public class Paddle
    {
        private PictureBox pictureBox;

        public Paddle(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void MovePaddle()
        {
            pictureBox.Left = Form1.MousePosition.X - (pictureBox.Width / 2);
        }

    }
}
