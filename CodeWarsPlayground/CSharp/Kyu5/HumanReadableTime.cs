namespace CodeWarsPlayground.CSharp.Kyu5
{
    internal static class HumanReadableTime
    {
        public static string GetReadableTime(int seconds) 
        {
            var hh = seconds / 3600;
            seconds = seconds - (hh * 3600);
            var mm = seconds / 60;
            seconds = seconds - (mm * 60);
            var ss = seconds / 1;
            return hh.ToString("00") + ":" + mm.ToString("00") + ":" + ss.ToString("00");
        }

        public static string GetReadableTimed2(int seconds)
        {
            return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }

        public static string GetReadableTimeTimeSpan(int seconds)
        {
            var t = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }
    }
}
