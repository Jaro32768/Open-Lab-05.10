using System;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            int ret = 1;
            string nums = num.ToString();
            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case '0':
                        {
                            ret = ret * 0;
                            break;
                        }
                    case '1':
                        {
                            ret = ret * 1;
                            break;
                        }
                    case '2':
                        {
                            ret = ret * 2;
                            break;
                        }
                    case '3':
                        {
                            ret = ret * 3;
                            break;
                        }
                    case '4':
                        {
                            ret = ret * 4;
                            break;
                        }
                    case '5':
                        {
                            ret = ret * 5;
                            break;
                        }
                    case '6':
                        {
                            ret = ret * 6;
                            break;
                        }
                    case '7':
                        {
                            ret = ret * 7;
                            break;
                        }
                    case '8':
                        {
                            ret = ret * 8;
                            break;
                        }
                    case '9':
                        {
                            ret = ret * 9;
                            break;
                        }
                }
            }
            return ret;
        }
    }
}
