using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amputation
{
    class AMP
    {
        public int left, right, up, down;

        private byte T1(int x)
        {
            if (x < left)
                return 1;
            return 0;
        }

        private byte T2(int x)
        {
            if (x > right)
                return 1;
            return 0;
        }

        private byte T3(int y)
        {
            if (y < down)
                return 1;
            return 0;
        }

        private byte T4(int y)
        {
            if (y > up)
                return 1;
            return 0;
        }

        public int S(int x, int y)
        {
            return T1(x) + T2(x) + T3(y) + T4(y);
        }

        public int P(int X1, int Y1, int X2, int Y2)
        {
            return T1(X1) * T1(X2) + T2(X1) * T2(X2) + T3(Y1) * T3(Y2) + T4(Y1) * T4(Y2);
        }

        /// <summary>
        ///     Checking horizontal line
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public bool isHori(System.Drawing.Point A, System.Drawing.Point B)
        {
            if (A.Y == B.Y)
                return true;
            return false;
        }

        /// <summary>
        ///     Checking vertical line
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public bool isVert(System.Drawing.Point A, System.Drawing.Point B)
        {
            if (A.X == B.X)
                return true;
            return false;
        }

        /// <summary>
        ///     Identifying (Y)cross with the vertical line Xkey
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="Xkey"></param>
        /// <returns>
        ///     0 if no cross or cross point is outside
        ///     else (Y)
        /// </returns>
        public int crVert(System.Drawing.Point A, System.Drawing.Point B, int Xkey)
        {
            if (isVert(A, B))
                return 0;
            
            int y = (int)(A.Y + (Xkey - A.X) * (B.Y - A.Y) / (B.X - A.X));
            if ((T3(y) == 0) && (T4(y) == 0) && ((Xkey - A.X) * (Xkey - B.X) < 0))
                return y;
            
            return 0;
        }

        /// <summary>
        ///     Identifying (X)cross with the horizontal line Ykey
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="Ykey"></param>
        /// <returns>
        ///     0 if no cross or cross point is outside
        ///     else (X)
        /// </returns>
        public int crHori(System.Drawing.Point A, System.Drawing.Point B, int Ykey)
        {
            if (isHori(A, B))
                return 0;
            
            int x = (int)(A.X + (Ykey - A.Y) * (B.X - A.X) / (B.Y - A.Y));
            if ((T1(x) == 0) && (T2(x) == 0) && ((Ykey - A.Y) * (Ykey - B.Y) < 0))
                return x;

            return 0;
        }

        /// <summary>
        ///     Checking posittion of [PRV]
        /// </summary>
        /// <param name="P"></param>
        /// <param name="R"></param>
        /// <param name="V"></param>
        /// <returns></returns>
        public bool isMid(System.Drawing.Point P, System.Drawing.Point R, System.Drawing.Point V)
        {
            if ((R.X - P.X) * (R.X - V.X) + (R.Y - P.Y) * (R.Y - V.Y) < 0)
                return true;
            return false;
        }
    }
}
