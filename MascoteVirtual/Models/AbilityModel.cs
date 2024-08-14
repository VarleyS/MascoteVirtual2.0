namespace MascoteVirtual.Models
{
    public class AbilityModel
    {
        public AbilityName ability { get; set; }

        public class AbilityName
        {
            public string name { get; set; }
            public string url { get; set; }
        }
    }
}
