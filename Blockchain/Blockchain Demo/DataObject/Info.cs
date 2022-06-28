using System;
namespace Blockchain_Demo
{
    public class Info
    {
        public string totalTime;
        public int Milliseconds { get; set; }
        public int milliseconds { get; set; }
        public int nonce { get; set; }
        public int seconds { get; set; }
        public string averageUnitsPerSecond { get; set; }
        public void SetInfo()
        {
            seconds = Milliseconds / 1000;
            milliseconds = Milliseconds - seconds * 1000;
            totalTime = $"{seconds}.{milliseconds}";
            try
            {
                averageUnitsPerSecond = (Convert.ToString(Convert.ToInt32(Convert.ToDouble(nonce) / Convert.ToDouble(Milliseconds) * 1000)));
            }
            catch
            {

            }
        }
    }
}
