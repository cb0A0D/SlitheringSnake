using System.Collections.Generic;

namespace snake_game
{
    public class Position
    {
        public int Row { get; }
        public int Cols { get; }

        public Position(int row, int column)
        {
            Row = row;
            Cols = column;
        }

        public Position Translate(Direction dir)
        {
            return new Position(Row + dir.RowOffset, Cols + dir.ColOffset);
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Cols == position.Cols;
        }

        public override int GetHashCode()
        {
            int hashCode = 240067226;
            hashCode = hashCode * -1521134295 + Row.GetHashCode();
            hashCode = hashCode * -1521134295 + Cols.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
    }
}
