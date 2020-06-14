namespace DataAccessLayerEF
{
    public class Students
    {
        public Students()
        {
            Universities = new University();
            Supervisors = new GraduateSupervisor();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual University Universities { get; set; }
        public virtual GraduateSupervisor Supervisors { get; set; }
    }
}
