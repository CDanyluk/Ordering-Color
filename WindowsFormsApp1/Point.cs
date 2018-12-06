using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace OrderColors
{
    class Point
    {
        public double x, y, z; //co-ordinate of point
        public double distance; //distance from test point
        public Color color;
        public int zval;
        public long hval;
        //public int hval;

        public Point(double x, double y, double z, double distance, Color color, bool zorder, bool horder, string hilbert)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.distance = distance;
            this.color = color;
            if (zorder == true)
            {
                getZValue();
            }
            if (horder == true)
            {
                //That one is broken
                //hilbertC(256, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1);
                //These appear to do the same thing
                //getHValue();
                GreyCode(hilbert);
            }
        }

        //Convert to the binary representation for z-ordering
        public void getZValue()
        {
            //array to store the individual bits
            char[] bitArr = new char[48];

            //convert integers in point to binary
            string bx = Convert.ToString(Convert.ToInt32(x), 2).PadLeft(16, '0');
            string by = Convert.ToString(Convert.ToInt32(y), 2).PadLeft(16, '0');
            string bz = Convert.ToString(Convert.ToInt32(z), 2).PadLeft(16, '0');

            //interlock the bits
            int counter = 0;
            for (int i = 0; i < bx.Count(); i++)
            {
                bitArr[i + counter] = bz[i];
                bitArr[i + counter + 1] = by[i];
                bitArr[i + counter + 2] = bx[i];
                counter = counter + 2;
            }

            //convert to a complete string then integer
            string resStr = new string(bitArr);
            int ret = Convert.ToInt32(resStr, 2);

            zval = ret;
        }

        //Retrieve distance along the Hilbert Curve
        //Convert(x, y, z!) to d
        public void getHValue()
        {
            int n = 256;
            int rx, ry, rz, s, d = 0;
            int ix = Convert.ToInt32(x);
            int iy = Convert.ToInt32(y);
            int iz = Convert.ToInt32(z);
            for (s = n / 2; s > 0; s /= 2)
            {
                rx = fromBool((ix & s) > 0);
                ry = fromBool((iy & s) > 0);
                rz = fromBool((iz & s) > 0);
                d += s * s * (((3 * rx) ^ ry) ^ rz);
                //Rotate or "flip the quadrant"
                if (ry == 0)
                {
                    if (rx == 1)
                    {
                        ix = n - 1 - ix;
                        iy = n - 1 - iy;
                        iz = n - 1 - iz;
                    }
                    //Swap x and y
                    int t = ix;
                    ix = iy;
                    iy = t;
                }
            }
            hval = d;
        }

        public void testHVal()
        {
            //convert the integers in the point to a binary representation of them
            string bx = Convert.ToString(Convert.ToInt32(x), 2).PadLeft(16, '0');
            string by = Convert.ToString(Convert.ToInt32(y), 2).PadLeft(16, '0');
            string bz = Convert.ToString(Convert.ToInt32(z), 2).PadLeft(16, '0');

            //store the binary values in an array to iterate over
            uint[] bxArr = ToUIntfromString(bx);
            uint[] byArr = ToUIntfromString(by);
            uint[] bzArr = ToUIntfromString(bz);

            //combine them into one long array
            uint[] combined = (bxArr.Concat(byArr).ToArray()).Concat(bzArr).ToArray();

            //call the weird function you found online
            hval = HilbertIndexTransposed(combined, 256);
        }

        public uint[] ToUIntfromString(string binaryrepresent)
        {
            uint[] ArrTemp = new uint[binaryrepresent.Length];
            for (int i = 0; i < binaryrepresent.Length; i++)
            {
                int tempint = binaryrepresent[i] - '0';
                uint tempuint = Convert.ToUInt32(tempint);
                ArrTemp[i] = tempuint;
            }
            return ArrTemp;
        }

        /// <summary>
        /// Given the axes (coordinates) of a point in N-Dimensional space, find the distance to that point along the Hilbert curve.
        /// That distance will be transposed; broken into pieces and distributed into an array.
        /// 
        /// The number of dimensions is the length of the hilbertAxes array.
        ///
        /// Note: In Skilling's paper, this function is called AxestoTranspose.
        /// </summary>
        /// <param name="hilbertAxes">Point in N-space.</param>
        /// <param name="bits">Depth of the Hilbert curve. If bits is one, this is the top-level Hilbert curve.</param>
        /// <returns>The Hilbert distance (or index) as a transposed Hilbert index.</returns>
        /// https://stackoverflow.com/questions/499166/mapping-n-dimensional-value-to-a-point-on-hilbert-curve
        public long HilbertIndexTransposed(uint[] hilbertAxes, int bits)
        {
            var X = (uint[])hilbertAxes.Clone();
            var n = hilbertAxes.Length; // n: Number of dimensions
            uint M = 1U << (bits - 1), P, Q, t;
            int i;
            // Inverse undo
            for (Q = M; Q > 1; Q >>= 1)
            {
                P = Q - 1;
                for (i = 0; i < n; i++)
                    if ((X[i] & Q) != 0)
                        X[0] ^= P; // invert
                    else
                    {
                        t = (X[0] ^ X[i]) & P;
                        X[0] ^= t;
                        X[i] ^= t;
                    }
            } // exchange
            // Gray encode
            for (i = 1; i < n; i++)
                X[i] ^= X[i - 1];
            t = 0;
            for (Q = M; Q > 1; Q >>= 1)
                if ((X[n - 1] & Q) != 0)
                    t ^= Q - 1;
            for (i = 0; i < n; i++)
                X[i] ^= t;

            //convert to int and return
            string resStr = string.Join("", X);
            long ret = Convert.ToInt64(resStr, 2);
            return ret;
        }

        //This might be a little more than graycode??
        public void GreyCode(string value)
        {
            //convert the integers in the point to a binary representation of them
            string bx = Convert.ToString(Convert.ToInt32(x), 2).PadLeft(16, '0');
            string by = Convert.ToString(Convert.ToInt32(y), 2).PadLeft(16, '0');
            string bz = Convert.ToString(Convert.ToInt32(z), 2).PadLeft(16, '0');

            //store the binary values in an array to iterate over
            int[] bxArr = bx.Select(c => c - '0').ToArray();
            int[] byArr = by.Select(c => c - '0').ToArray();
            int[] bzArr = bz.Select(c => c - '0').ToArray();

            //call a function that will iterate over each one xoring every bit together
            bxArr = XorArray(bxArr);
            byArr = XorArray(byArr);
            bzArr = XorArray(bzArr);

            //This is a magic number and I don't understand it tbh
            int rank = 4;

            //Using rank, combine the arrays and flip every rankth bit
            int[] combined = (bxArr.Concat(byArr).ToArray()).Concat(bzArr).ToArray();
            int[] bitArr = XorBits(rank, combined);

            if (value != "greycode")
            {
                //Test print the long bit number
                string totalArr = "";
                for (int i = 0; i < bitArr.Count(); i++)
                {
                    totalArr += bitArr[i];
                }
                Console.WriteLine("bitArr : " + totalArr);

                //rotations and stuff
                int[] finArr = getHilbertNum(bitArr, rank);

                //delaminate it
                //create empty matrix to start process
                List<int[]> matrix = new List<int[]>();
                //copy into the matrix
                for (int k = 0; k < finArr.Length - rank; k++)
                {
                    int[] section = SubArray(bitArr, k, k + rank);
                    matrix.Add(section);
                }
                //reversal
                for (int k = 0; k < matrix.Count/2; k++)
                {
                    int[] first = matrix[k];
                    int[] last = matrix[matrix.Count - 1 - k];

                    matrix[k] = first;
                    matrix[matrix.Count - 1 - k] = last;
                }
                //transpose it
                List<int[]> transposed = new List<int[]>();
                for (int i = 0; i < matrix[0].Length-1; i++)
                {
                    int[] temp = new int[matrix.Count];
                    for (int j = 0; j < matrix.Count-1; j++)
                    {
                        temp[j] = matrix[j][i];
                    }
                }
                //combine the arrays once more and flip every rankth bit to
                //grey decode it
                int[] decoded = new int[finArr.Length];
                for (int g = 0; g < transposed.Count; g++)
                {
                    decoded = decoded.Concat(transposed[g]).ToArray();
                }
                bitArr = decoded;
            }

            //finally, convert to integer and store
            string resStr = string.Join("", bitArr);
            long ret = Convert.ToInt64(resStr, 2);

            hval = ret;
        }

        public int[] SubArray(int[] data, int startindex, int endindex)
        {
            int length = endindex - startindex;
            int[] result = new int[length];
            Array.Copy(data, startindex, result, 0, length);
            return result;
        }

        public int[] getHilbertNum(int[] bitArr, int rank)
        {
            List<int> lst = new List<int>();

            int[] prevchnk = { 0, 0, 0, 0 };

            //For every chunk in the bit array
            for (int i = 0; i < bitArr.Count() - rank; i += rank)
            {

                //Take the chunk out of the bit array
                int[] chnk = SubArray(bitArr, i, i + rank);

                //rotation = the first index of 1 in number
                int rotation = 0;
                string testchnk = "";
                for (int j = prevchnk.Length - 1; j >= 0; j--)
                {
                    testchnk += prevchnk[j];
                    if (prevchnk[j] == 1)
                    {
                        rotation = j + 2;
                    }
                }
                //if the rotation is greater than rank, set it back
                if (rotation >= rank)
                {
                    rotation = rotation - rank;
                }


                //test the size of chnk
                string testchunk = "";
                for (int x = 0; x < chnk.Length; x++)
                {
                    testchunk += chnk[x];
                }
                Console.WriteLine("testchunk: " + testchunk);

                //create the flipbit
                int[] flipbit = { 0, 0, 0, 0 };
                Console.WriteLine("Rotation : " + rotation);
                flipbit[rotation] = 1;
                int[] rotated = Rotations(chnk, flipbit, 1);

                //Append the rotated bits to the list
                string test = "";
                for (int k = 0; k < rotated.Length; k++)
                {
                    lst.Add(rotated[k]);
                    test += rotated[k];
                }
                Console.WriteLine("returned : " + test);

                prevchnk = chnk;
            }

            //convert the list to an array and return
            int[] ret = lst.ToArray();
            return ret;
        }

        public int[] Rotations(int[] chnk, int[] flipbit, int rotation)
        {

            //shift every bit value to the left for the value of rotation
            Queue rotchunk = new Queue(chnk);
            //print array chnk to check
            for (int i = 0; i < rotation; i++)
            {
                rotchunk.Enqueue(rotchunk.Dequeue());
            }
            int[] rotchnkArr = new int[chnk.Length];

            int rotCount = rotchunk.Count;
            for (int j = 0; j < rotCount; j++)
            {
                rotchnkArr[j] = Convert.ToInt32(rotchunk.Dequeue());
            }

            //xor the chnk and flipbit together and append to the list
            int[] toAppend = chnkXflipbit(rotchnkArr, flipbit);
            return toAppend;
        }

        public int[] chnkXflipbit(int[] chnk, int[] flipbit)
        {
            int[] ret = new int[chnk.Length];
            for (int i = 0; i < chnk.Length-1; i++)
            {
                ret[i] = chnk[i] ^ flipbit[i];
            }
            return ret;
        }

        public int[] XorArray(int[] original)
        {
            int[] newbits = new int[original.Length];
            for (int i = 0; i < original.Length - 1; i++)
            {
                int temp = original[i] ^ original[i + 1];
                newbits[i] = temp;
            }

            //end case??
            //newbits[original.Length] = original[original.Length] ^ original[0];
            return newbits;
        }

        public int[] XorBits(int rank, int[] original)
        {
            for (int i = 0; i < original.Length; i += rank)
            {
                original[i] ^= 1;
            }
            return original;
        }

        //Retrieve distance along the Hilbert Curve
        //Convert (x, y, z!) to d
        public void hilbertC(int s, int x, int y, int z, int dx, int dy, int dz, int dx2, int dy2, int dz2, int dx3, int dy3, int dz3)
        {
            if (s == 1)
            {
                //red[m] = x;
                //green[m] = y;
                //blue[m] = z;
                hval++;
            }
            else
            {
                s /= 2;
                if (dx < 0) x -= s * dx;
                if (dy < 0) y -= s * dy;
                if (dz < 0) z -= s * dz;
                if (dx2 < 0) x -= s * dx2;
                if (dy2 < 0) y -= s * dy2;
                if (dz2 < 0) z -= s * dz2;
                if (dx3 < 0) x -= s * dx3;
                if (dy3 < 0) y -= s * dy3;
                if (dz3 < 0) z -= s * dz3;
                hilbertC(s, x, y, z, dx2, dy2, dz2, dx3, dy3, dz3, dx, dy, dz);
                hilbertC(s, x + s * dx, y + s * dy, z + s * dz, dx3, dy3, dz3, dx, dy, dz, dx2, dy2, dz2);
                hilbertC(s, x + s * dx + s * dx2, y + s * dy + s * dy2, z + s * dz + s * dz2, dx3, dy3, dz3, dx, dy, dz, dx2, dy2, dz2);
                hilbertC(s, x + s * dx2, y + s * dy2, z + s * dz2, -dx, -dy, -dz, -dx2, -dy2, -dz2, dx3, dy3, dz3);
                hilbertC(s, x + s * dx2 + s * dx3, y + s * dy2 + s * dy3, z + s * dz2 + s * dz3, -dx, -dy, -dz, -dx2, -dy2, -dz2, dx3, dy3, dz3);
                hilbertC(s, x + s * dx + s * dx2 + s * dx3, y + s * dy + s * dy2 + s * dy3, z + s * dz + s * dz2 + s * dz3, -dx3, -dy3, -dz3, dx, dy, dz, -dx2, -dy2, -dz2);
                hilbertC(s, x + s * dx + s * dx3, y + s * dy + s * dy3, z + s * dz + s * dz3, -dx3, -dy3, -dz3, dx, dy, dz, -dx2, -dy2, -dz2);
                hilbertC(s, x + s * dx3, y + s * dy3, z + s * dz3, dx2, dy2, dz2, -dx3, -dy3, -dz3, -dx, -dy, -dz);
            }
             hval=0;
        }

        public int fromBool(bool boolval)
        {
            if (boolval == true)
            {
                return 1;
            }
            return 0;
        }


    }
}