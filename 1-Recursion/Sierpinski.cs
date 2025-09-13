using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Sierpinski
    {
        public static void draw_sierpinski_carpet(int levels, double x, double y, double width, double height, SierpinskiCanvas canvas)
        {
            //canvas.drawSquare(0, 0, 100, 100);

            if (levels < 0 || width <= 0 || height <= 0)
            {
                return;
            }

            if (levels == 0)
            {
                canvas.drawSquare(x, y, width, height);
                return;
            }

            double newWidth = width / 3.0;
            double newHeight = height / 3.0;

            for (int dx = 0; dx < 3; dx++)
            {
                for (int dy = 0; dy < 3; dy++)
                {
                    if (dx == 1 && dy == 1)
                    {
                        // Skip the center square
                        continue;
                    }
                    draw_sierpinski_carpet(levels - 1, x + dx * newWidth, y + dy * newHeight, newWidth, newHeight, canvas);
                }
            }
        }

        public interface SierpinskiCanvas
        {
            void drawSquare(double x, double y, double width, double height);
        }
    }
}
