using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PixelClass
{
    class Pixels
    {
        public PointF[] face = new PointF[3600];
        public PointF[] nose = new PointF[3];
        public PointF[] mouth = new PointF[3];
        public PointF[] eye_lf = new PointF[3600];
        public PointF[] eye_rt = new PointF[3600];
        
        public void init(int x, int y, int r)
        {
            int i;      // loop counter
            int xt, yt;
            double angle;
            
            // FACE
            for (i = 0; i < 3600; i++)
            {
                angle = i * Math.PI / 1800;
                xt = (int)(x + r * Math.Cos(angle));
                yt = (int)(y + r * Math.Sin(angle));
                face[i].X = xt; face[i].Y = yt;
            }

            // NOSE
            nose[0].X = x; nose[0].Y = y - r / 6;
            nose[1].X = x - r / 12; nose[1].Y = y + r / 4;
            nose[2].X = x + r / 12; nose[2].Y = y + r / 4;

            // MOUTH
            mouth[0].X = x; mouth[0].Y = y + r * 4 / 5;
            mouth[1].X = x - r / 2; mouth[1].Y = y + r / 2;
            mouth[2].X = x + r / 2; mouth[2].Y = y + r / 2;

            // LEFT EYE
            for (i = 0; i < 3600; i++)
            {
                angle = i * Math.PI / 1800;
                xt = (int)(x - r / 3 + r / 4 * Math.Cos(angle));
                yt = (int)(y - r / 2 + r / 6 * Math.Sin(angle));
                eye_lf[i].X = xt; eye_lf[i].Y = yt;
            }

            // RIGHT EYE
            for (i = 0; i < 3600; i++)
            {
                angle = i * Math.PI / 1800;
                xt = (int)(x + r / 3 + r / 4 * Math.Cos(angle));
                yt = (int)(y - r / 2 + r / 6 * Math.Sin(angle));
                eye_rt[i].X = xt; eye_rt[i].Y = yt;
            }
        }

        public void move(int dx, int dy)
        {
            int i;
            for (i = 0; i < 3600; i++)
            {
                face[i].X += dx; face[i].Y += dy;       // FACE
                eye_lf[i].X += dx; eye_lf[i].Y += dy;   // EYES
                eye_rt[i].X += dx; eye_rt[i].Y += dy;
            }

            for (i = 0; i < 3; i++)
            {
                nose[i].X += dx ; nose[i].Y += dy;      // NOSE
                mouth[i].X += dx; mouth[i].Y += dy;     // MOUTH
            }
        }

        public PointF fix_size(PointF z, int x, int y, float tx, float ty)
        {
            double xt = tx * z.X + (1 - tx) * x;
            double yt = ty * z.Y + (1 - ty) * y;

            return new PointF((float)xt, (float)yt);
        }

        public void resize(int x, int y, float tx, float ty)
        {
            int i;
            for (i = 0; i < 3600; i++)
            {
                face[i]   = fix_size(face[i], x, y, tx, ty);         // FACE
                eye_lf[i] = fix_size(eye_lf[i], x, y, tx, ty);       // LEFT EYE
                eye_rt[i] = fix_size(eye_rt[i], x, y, tx, ty);       // RIGHT EYE
            }

            for (i = 0; i < 3; i++)
            {
                nose[i] = fix_size(nose[i], x, y, tx, ty);           // NOSE
                mouth[i] = fix_size(mouth[i], x, y, tx, ty);         // MOUTH
            }
        }

        public PointF rotate_point(PointF z, int x, int y, int alpha)
        {
            double angle = alpha * Math.PI / 180;
            double xt = x + (z.X - x) * Math.Cos(angle) + (z.Y - y) * Math.Sin(angle);
            double yt = y - (z.X - x) * Math.Sin(angle) + (z.Y - y) * Math.Cos(angle);

            return new PointF((float)xt, (float)yt);
        }

        public void rotate(int x, int y, int angle)
        {
            int i;
            for (i = 0; i < 3600; i++)
            {
                face[i] = rotate_point(face[i], x, y, angle);           // FACE
                eye_lf[i] = rotate_point(eye_lf[i], x, y, angle);       // LEFT EYE
                eye_rt[i] = rotate_point(eye_rt[i], x, y, angle);       // RIGHT EYE
            }

            for (i = 0; i < 3; i++)
            {
                nose[i] = rotate_point(nose[i], x, y, angle);           // NOSE
                mouth[i] = rotate_point(mouth[i], x, y, angle);         // MOUTH
            }
        }
    }
}
