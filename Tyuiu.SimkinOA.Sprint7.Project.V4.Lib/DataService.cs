using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.SimkinOA.Sprint7.Project.V4.Lib
{
    public class DataService
    {
        public int BookSumm(string path, int cost)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int coll = lines[0].Split(';').Length;
            string[,] mtr = new string[rows, coll];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < coll; j++)
                {
                    mtr[i, j] = strok[j];
                }
            }

            int[] ln1 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if ((j == cost) && (i > 0))
                    {
                        ln1[i] = Convert.ToInt32(mtr[i, j]);
                    }
                }
            }

            int res = 0;
            for (int i = 0; i < ln1.Length; i++)
            {
                res += ln1[i];
            }
            return res;
        }

        public int BookMin(string path, int cost)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int coll = lines[0].Split(';').Length;
            string[,] mtr = new string[rows, coll];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < coll; j++)
                {
                    mtr[i, j] = strok[j];
                }
            }
            int[] ln1 = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if ((j == cost) && (i > 0))
                    {
                        ln1[i] = Convert.ToInt32(mtr[i, j]);
                    }
                }
            }
            int res;
            int min = 100000000;
            for (int i = 0; i < ln1.Length; i++)
            {
                res = ln1[i];
                if ((res < min) && (res != 0))
                {
                    min = res;
                }
            }
            return min;
        }
        public int BookMax(string path, int cost)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int coll = lines[0].Split(';').Length;
            string[,] mtr = new string[rows, coll];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < coll; j++)
                {
                    mtr[i, j] = strok[j];
                }
            }
            int[] ln1 = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if ((j == cost) && (i > 0))
                    {
                        ln1[i] = Convert.ToInt32(mtr[i, j]);
                    }
                }
            }
            int res;
            int max = -1;
            for (int i = 0; i < ln1.Length; i++)
            {
                res = ln1[i];
                if (res > max)
                {
                    max = res;
                }
            }
            return max;
        }
    }
}