namespace POCs.data
{
    public class Plans
    {
        public int Id { get; set; }
        public string name { get; set; }

        public List<Plan_Items> liPlan_Items { get; set; }
    }
}
