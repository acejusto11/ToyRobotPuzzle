namespace ToyRobotPuzzle
{
    public class TableDimension : IDimension
    {
        public int Columns { get; set; }
        public int Rows { get; set; }
        public TableDimension(int columns, int rows)
        {
            this.Columns = columns;
            this.Rows = rows;
        }
    }
}   
