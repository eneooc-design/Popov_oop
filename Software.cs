namespace WinFormsApp46
{
    internal class Software : IComparable, ICloneable
    {
        public string Title { get; private set; }
        public string Version { get; private set; }
        public decimal Price { get; private set; }
        public License SoftwareLicense { get; private set; }
        public Software(string title, string version, decimal price, License license)
        {
            Title = title;
            Version = version;
            Price = price;
            SoftwareLicense = license;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is Software otherSoftware)
            {
                return this.Price.CompareTo(otherSoftware.Price);
            }
            else
            {
                throw new ArgumentException("Объект не является экземпляром класса Software");
            }
        }
        public object Clone()
        {
            Software cloned = (Software)this.MemberwiseClone();
            cloned.SoftwareLicense = (License)this.SoftwareLicense.Clone();
            return cloned;
        }
    }
}
