namespace addressbook_web_tests
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
        }
    }
}
