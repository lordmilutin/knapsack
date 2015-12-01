using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Knapsack
{
    class Knapsack
    {
        private string key;
        private string queue;
        private string fsMem;       
        private string numMem;
        private Random random;
        private int m;
        private int im;
        private int N;
        private int[] P;
        private int[] J;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        public string Queue
        {
            get { return queue; }
            set { queue = value; }
        }
        public string FsMem
        {
            get { return fsMem; }
            set { fsMem = value; }
        }
        public string NumMem
        {
            get { return numMem; }
            set { numMem = value; }

        }
        public int N1
        {
            get { return N; }
            set { N = value; }
        }
        public int Im
        {
            get { return im; }
            set { im = value; }
        }

        public Knapsack()
        {
            key = "";
            queue = "";
            fsMem = "";
            numMem = "0";
            random = new Random();
            N = 0;
            m = 0;
            im = 0;
        }

        public string GenerateQueue()
        {
            int nummem = Convert.ToInt32(this.numMem);
            int fsmem = Convert.ToInt32(this.fsMem);
            P = new int[nummem];
            P[0] = fsmem;
            int k = 1;

            for (int i = 1; i < nummem; i++)
            {
                int l = 0;
                for (int j = 0; j < k; j++ )
                {
                    l += P[j];
                }
                l += random.Next(1, 4);
                P[i] = l;
                k++;

                this.queue += l+" ";
            }
            return this.queue;
        }

        public string GenerateKey()
        {
            string[] pom = this.queue.Split(' ');
            int nummem = Convert.ToInt32(this.numMem);
            J = new int[nummem];
            P = new int[nummem];
            this.key = "";

            
            this.N = 2 * Convert.ToInt32(pom[nummem - 1]) + random.Next(1, 6);
            this.m = random.Next(23, 60);
            while (GetGCD(this.m, this.N) != 1)
                this.m = random.Next(23, 60);
            this.im = 1;
            while ((this.im * this.m) % this.N != 1)
                this.im++;

            for (int i = 0; i < nummem; i++ )
            {
                P[i] = Convert.ToInt32(pom[i]);
                J[i] = (P[i] * m) % N;
                this.key += J[i] + " ";
            }
            return this.key;
        }

        public void ModifyQueue()
        {
            string[] newQueue = this.queue.Split(' ');
            string[] newKey = this.key.Split(' ');
            int nummem = Convert.ToInt32(this.numMem);
            this.queue = "";
            this.key = "";
            for(int i = 0; i < nummem; i++ )
            {
                this.queue += newQueue[i] + " ";
                this.key += newKey[i] + " ";
            }

            int[] pom = new int[nummem];
            Array.Copy(P, pom, nummem);
            P = new int[nummem];
            Array.Copy(pom, P, nummem);
            Array.Copy(J, pom, nummem);
            J = new int[nummem];
            Array.Copy(pom, J, nummem);

            /*this.N = 2 * P[nummem - 1] + random.Next(1, 6);
            this.m = random.Next(23, 60);
            while(GetGCD(this.m, this.N) != 1)
                this.m = random.Next(23, 60);
            this.im = 1;
            while ((this.im * this.m) % this.N != 1)
                this.im++;*/
        }

        public int GetGCD(int val1, int val2)
        {
            while (val1 != 0 && val2 != 0)
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }
            return Math.Max(val1, val2);
        }

        static byte Reverse(byte x)
        {
            byte y = 0;
            for (int i = 0; i < 8; ++i)
            {
                y <<= 1;
                y |= (byte)(x & 1);
                x >>= 1;
            }
            return y;
        }

        public string Crypt(string str)
        {
            string Crypted = "";
            byte[] nonCrypted = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                nonCrypted[i] = Reverse((byte)str[i]);
            BitArray bitArr = new BitArray(nonCrypted);
            int sizeOfBitArr = bitArr.Length;
            int nummem = Convert.ToInt32(this.numMem);
            int noIdea = (int)(sizeOfBitArr / nummem);
            int diff = sizeOfBitArr - noIdea*nummem;

            for (int i = 0; i < noIdea; i++)
            {
                int pom = 0;
                for (int j = 0; j < nummem; j++ )
                {
                    if(bitArr[i*nummem + j])
                        pom += J[j];
                }
                Crypted += pom + " ";
            }
            
            if(diff != 0)
            {
                int pom = 0;
                int j = 0;
                for (int i = sizeOfBitArr - diff; i < sizeOfBitArr; i++)
                {
                    if (bitArr[i])
                        pom += J[j];
                    j++;
                }
                Crypted += pom + " ";
            }
            return Crypted;
        }

        public string Decrypt(string str)
        {
            string decrypted = "";
            string[] pom = str.Split(' ');
            int[] crypted = new int[pom.Length - 1];
            for (int i = 0; i < pom.Length - 1; i++)
                crypted[i] = (Convert.ToInt32(pom[i]) * this.im) % this.N;  
            int nummem = Convert.ToInt32(this.numMem);
            int numElBitArr = nummem * (pom.Length - 1);
            BitArray bitArr = new BitArray(numElBitArr);
            int p = 1;
            for (int i = 0; i < crypted.Length; i++ )
            {
                int j = nummem - 1;
                int l = j; 
                int current = crypted[i];
                int k = 0;
                while(current != 0)
                {
                    if((current - P[j]) >= 0)
                    {
                        bitArr[l*p + i - k] = true;
                        current -= P[j];
                    }
                    k++;
                    j--;
                }
                p++;
            }
            int numDecr;
           // if((nummem*crypted.Length)%8 == 0)
                numDecr = (int)((nummem*crypted.Length)/8);
            //else
                //numDecr = ((int)((nummem*crypted.Length)/8)) + 1;
            byte[] decrypteD = new byte[numDecr];

            for (int i = 0; i < numDecr; i++ )
            {
                int r = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (bitArr[i * 8 + r])
                        decrypteD[i] += (byte)(Math.Pow(2, 7 - r));
                    r++;
                }
                decrypted += (char)decrypteD[i];
            }
                
            return decrypted;
        }
    }
}
