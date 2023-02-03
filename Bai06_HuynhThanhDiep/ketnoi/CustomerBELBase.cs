namespace ketnoi
{
    internal class CustomerBELBase
    {
        public string AreaName { get; set; }

        public string AreaName
        {
            get { return Area.Name; }
        }
    }
}