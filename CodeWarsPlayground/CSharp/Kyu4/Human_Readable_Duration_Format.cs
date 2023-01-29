namespace CodeWarsPlayground.CSharp.Kyu4
{
    internal static class Human_Readable_Duration_Format
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0)
            {
                return "now";
            }

            string result = "";
            List<int> itemList = new List<int>();

            int YearSeconds = 31536000;
            int DaySeconds = 86400;
            int HourSeconds = 3600;
            int MinuteSeconds = 60;

            int Years = Calculate(ref seconds, YearSeconds);
            int Days = Calculate(ref seconds, DaySeconds);
            int Hours = Calculate(ref seconds, HourSeconds);
            int Minutes = Calculate(ref seconds, MinuteSeconds);
            if (Years > 0)
                itemList.Add(Years);
            if (Days > 0)
                itemList.Add(Days);
            if (Hours > 0)
                itemList.Add(Hours);
            if (Minutes > 0)
                itemList.Add(Minutes);
            if (seconds > 0)
                itemList.Add(seconds);

            int counter = itemList.Count;

            if (Years > 0)
            {
                result = ConcatenateString(result, Years, "year");
                StrBuilder(ref result, ref counter);
            }
            if (Days > 0)
            {
                result = ConcatenateString(result, Days, "day");
                StrBuilder(ref result, ref counter);
            }
            if (Hours > 0)
            {
                result = ConcatenateString(result, Hours, "hour");
                StrBuilder(ref result, ref counter);
            }
            if (Minutes > 0)
            {
                result = ConcatenateString(result, Minutes, "minute");
                StrBuilder(ref result, ref counter);
            }
            if (seconds > 0)
            {
                result = ConcatenateString(result, seconds, "second");
            }

            return result;
        }

        private static void StrBuilder(ref string result, ref int counter)
        {
            if (counter > 2)
            {
                result += ", ";
                counter--;
                return;
            }
            if (counter == 2)
            {
                result += " and ";
                counter--;
            }
        }

        private static string ConcatenateString(string result, int Years, string typedString)
        {
            result += Years > 1 ? $"{Years} {typedString}s" : Years == 1 ? $"1 {typedString}" : "";
            return result;
        }

        private static int Calculate(ref int seconds, int constValue)
        {
            int tmp = seconds / constValue;
            seconds -= tmp * constValue;
            return tmp;
        }
    }
}