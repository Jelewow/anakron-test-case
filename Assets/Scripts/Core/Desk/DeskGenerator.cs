using Anakron.Core.CellSystem;
using Anakron.Helpers;
using UnityEngine;

namespace Anakron.Core.Desk
{
    public class DeskGenerator
    {
        private readonly Chip _chipPrefab;
        private readonly Cell _cellPrefab;

        public DeskGenerator()
        {
            _chipPrefab = Resources.Load<Chip>(Constants.Resources.Chip);
            _cellPrefab = Resources.Load<Cell>(Constants.Resources.Cell);
        }
        
        public void CreateDesk(DeskSize size)
        {
            var cells = new Cell[size.Rows, size.Columns];
            InstantiateCells(cells);
        }

        private void InstantiateCells(Cell[,] cells)
        {
            var previousColor = CellColor.Black;
            
            for (int i = 0; i < cells.GetUpperBound(0) + 1; i++)
            {
                var previousPosition = 0f;
                previousColor = previousColor == CellColor.White ? CellColor.Black : CellColor.White;
                
                for (int j = 0; j < cells.GetUpperBound(1) + 1; j++)
                {
                    var cell = Object.Instantiate(_cellPrefab, new Vector2(previousPosition, i), Quaternion.identity);
                    previousPosition += cell.transform.localScale.x;
                    cell.Color = previousColor;
                    cell.Coordinate = new Coordinate(i, j);
                    cells[i, j] = cell;

                    if (previousColor == CellColor.White)
                    {
                        TryInstantiateChip(cell);
                    }
                    
                    previousColor = previousColor == CellColor.White ? CellColor.Black : CellColor.White;
                }
            }
        }

        private void TryInstantiateChip(Cell cell)
        {
            var chip = Object.Instantiate(_chipPrefab, cell.transform.position, Quaternion.identity);
            cell.Chip = chip;
        }
    }
}