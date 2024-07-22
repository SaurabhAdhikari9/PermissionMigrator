namespace PermissionMigrator
{
    public class Resource
    {
        public Role Role { get; set; }
    }
    public class Role
    {
        public List<string> Client { get; set; }
        public List<string> SalesTeam { get; set; }
        public List<string> Employee { get; set; }
        public List<string> Manager { get; set; }
        public List<string> Director { get; set; }
        public List<string> Admin { get; set; }
        public List<string> Prospect { get; set; }  
    }
}
