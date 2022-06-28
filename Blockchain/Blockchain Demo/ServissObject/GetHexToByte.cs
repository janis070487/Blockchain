
namespace Blockchain_Demo
{
    public static class GetHexToByte
    {
        public static string answer;
        public static string GetHex(byte[] data)
        {
            answer = "";
            for (int i = 0; i < data.Length; i++)
            {
                GetHexSymbol(data[i] >> 4);
                GetHexSymbol(data[i] & 15);
            }
            return answer;
        }
        public static void GetHexSymbol(int value)
        {
            switch (value)
            {
                case 0:
                    answer += "0";
                    break;
                case 1:
                    answer += "1";
                    break;
                case 2:
                    answer += "2";
                    break;
                case 3:
                    answer += "3";
                    break;
                case 4:
                    answer += "4";
                    break;
                case 5:
                    answer += "5";
                    break;
                case 6:
                    answer += "6";
                    break;
                case 7:
                    answer += "7";
                    break;
                case 8:
                    answer += "8";
                    break;
                case 9:
                    answer += "9";
                    break;
                case 10:
                    answer += "a";
                    break;
                case 11:
                    answer += "b";
                    break;
                case 12:
                    answer += "c";
                    break;
                case 13:
                    answer += "d";
                    break;
                case 14:
                    answer += "e";
                    break;
                case 15:
                    answer += "f";
                    break;
            }
        }

    }
}
