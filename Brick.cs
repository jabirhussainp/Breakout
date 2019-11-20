using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOutDemo3
{
    public class Brick
    {
        private PictureBox[,] blocks;
        
        private const int row = 8;
        private const int col = 8;

        public Brick(PictureBox[,] blocks)
        {
        
            this.blocks = blocks;
           
        }

        public Brick(PictureBox pictureBox1)
        {
        }

        public void SetBlocks()
        {
            int blockHeight = 25;
            int blockWidth = 100;

            blocks = new System.Windows.Forms.PictureBox[row, col];
           

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    blocks[x, y] = new PictureBox();
                    blocks[x, y].Width = blockWidth;
                    blocks[x, y].Height = blockHeight;
                    blocks[x, y].Top = blockHeight * x;
                    blocks[x, y].Left = blockWidth * y;
                    blocks[x, y].BackColor = Color.Beige;
                    blocks[x, y].BorderStyle = BorderStyle.Fixed3D;

                    this.blocks[x, y] = blocks[x, y];
                   
                }
            }

           
        }
    }
}
