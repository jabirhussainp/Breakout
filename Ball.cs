using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOutDemo3
{
    public class Ball
    {
        private PictureBox pictureBox;
        private int vSpeed;
        private int hSpeed;

        public Ball(PictureBox pictureBox)
        {
            vSpeed = 1;
            hSpeed = 1;

            this.pictureBox = pictureBox;
        }



        public void MoveBall()
        {
            pictureBox.Top += vSpeed;
            pictureBox.Left += hSpeed;

            if (pictureBox.Bottom >= Form1.ActiveForm.ClientSize.Height)
            {
                vSpeed = -vSpeed;
            }

            if (pictureBox.Top < 0)
            {
                vSpeed = -vSpeed;
            }
            if (pictureBox.Right >= Form.ActiveForm.ClientSize.Width)
            {
                hSpeed = -hSpeed;
            }
            if (pictureBox.Left < 0)
            {
                hSpeed = -hSpeed;
            }

        }
    }
}
