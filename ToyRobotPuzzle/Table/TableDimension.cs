namespace ToyRobotPuzzle
{
    public class TableDimension : IDimension
    {
        public int Columns { get; set; }
        public int Rows { get; set; }

        public TableDimension() 
        { 
            this.Columns = 5;
            this.Rows = 5;
        }
        public TableDimension(int columns, int rows)
        {
            this.Columns = columns;
            this.Rows = rows;
        }
    }
}   
