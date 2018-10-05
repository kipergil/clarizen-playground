using Ekin.Clarizen;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class WorkItem : EntityId
    {
        public string Name { get; set; }
        public Currency C_WISoldCost { get; set; }
        public int? ChildrenCount { get; set; }
        public bool? C_HasSoldHours { get; set; }
    }
}
