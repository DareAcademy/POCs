﻿namespace POCs.data
{
    public class Courses
    {
        public int Id { get; set; }
        public string name { get; set; }

        public List<Plan_Items> liPlan_Items { get; set; }
    }
}
