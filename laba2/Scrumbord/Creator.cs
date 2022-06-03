namespace ScrumBoard.Body
{
    public class Creator
    {
        public static BoardI Create_board(string title) // Создание доски
        {
            return new Board(title);
        }

        public static ColumnI Create_column(string title) // Создание колонки
        {
            return new Column(title);
        }

        public static TaskI Create_task(string title, string description, Task_priority priority) // Создание задания
        {
            return new Body.Task(title, description, priority);
        }
    }
}