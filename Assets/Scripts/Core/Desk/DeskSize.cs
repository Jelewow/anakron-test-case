using System;

namespace Anakron.Core.Desk
{
    [Serializable]
    public  struct DeskSize
    {
        public  int Columns;
        public  int Rows;
        public  int ChipAmount;

        public int Size => Columns * Rows;

        public DeskSize(int columns, int rows, int chipAmount)
        {
            Columns = columns;
            Rows = rows;
            ChipAmount = chipAmount;
        }
    }
}