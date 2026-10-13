namespace WinFormsApp46
{
    internal class License : ICloneable
    {
        public string key { get; set; }
        public int DurationDays { get; set; }

        License(string Key, int DURATION)
        {
            key = Key;
            DurationDays = DURATION;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
