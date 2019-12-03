namespace WebAddressbookTests
{
    public class Group
    {
        public string Name { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }

        public Group()
        {
            this.Name = string.Empty;
            this.Header = string.Empty;
            this.Footer = string.Empty;
        }
    }
}