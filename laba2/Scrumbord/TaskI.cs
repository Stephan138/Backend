namespace ScrumBoard.Body
{
    public interface TaskI
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Task_priority Priority { get; set; }
    }
    public enum Task_priority
    {
        HARD,
        MEDIUM,
        EASY,
        NONE,
    }
}