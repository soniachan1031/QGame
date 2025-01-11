using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGame_Library
{
    public enum GridType
    {
        Empty,
        Wall,
        RedDoor,
        GreenDoor,
        BlueDoor,
        RedBox,
        GreenBox,
        BlueBox
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public static class GameManager
    {
        /// <summary>
        /// Converts the PictureBox grid to a GridType grid.
        /// </summary>
        /// <param name="pictureBoxGrid"></param>
        /// <returns></returns>
        public static GridType[,] ConvertGridToGridType(PictureBox[,] pictureBoxGrid)
        {
            int rows = pictureBoxGrid.GetLength(0);
            int cols = pictureBoxGrid.GetLength(1);
            GridType[,] gridTypeGrid = new GridType[rows, cols]; // Initialize the gridTypeGrid

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (pictureBoxGrid[i, j] != null && pictureBoxGrid[i, j].Tag != null) // Check if the PictureBox is not null and has a Tag
                    {
                        gridTypeGrid[i, j] = (GridType)pictureBoxGrid[i, j].Tag; // Cast the Tag to GridType
                    }
                    else
                    {
                        gridTypeGrid[i, j] = GridType.Empty; // Use Empty as default
                    }
                }
            }

            return gridTypeGrid;
        }

        /// <summary>
        /// Saves a maze to a file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="grid"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public static void SaveMaze(string filePath, GridType[,] grid, int row, int col)
        {
            try
            {
                int wallCount = 0;
                int doorCount = 0;
                int boxCount = 0;

                using (StreamWriter writer = new StreamWriter(filePath)) // Use StreamWriter to write to the file
                {
                    writer.WriteLine($"{row},{col}"); // Write the row and column count to the file

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            writer.Write(grid[i, j] + ",");
                            switch (grid[i, j])
                            {
                                case GridType.Wall:
                                    wallCount++;
                                    break;
                                case GridType.RedDoor:
                                case GridType.GreenDoor:
                                case GridType.BlueDoor:
                                    doorCount++;
                                    break;
                                case GridType.RedBox:
                                case GridType.GreenBox:
                                case GridType.BlueBox:
                                    boxCount++;
                                    break;
                            }
                        }
                        writer.WriteLine();
                    }

                    MessageBox.Show($"Maze saved successfully! \nWalls: {wallCount} \nDoors: {doorCount} \nBoxes: {boxCount}", "Save Confirmation");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving maze: {ex.Message}", "Save Error");
            }
        }


        /// <summary>
        /// Loads a maze from a file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="loadedRows"></param>
        /// <param name="loadedCols"></param>
        /// <returns></returns>
        // Ensure GameManager methods handle the file read/write properly
        public static GridType[,] LoadMaze(string fileName, out int rows, out int cols)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    // Read the first line to get the number of rows and columns
                    string[] dimensions = reader.ReadLine().Split(',');
                    rows = int.Parse(dimensions[0]);
                    cols = int.Parse(dimensions[1]);

                    // Initialize the grid with the specified dimensions
                    GridType[,] grid = new GridType[rows, cols];

                    // Read the rest of the file to populate the grid
                    for (int i = 0; i < rows; i++)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        for (int j = 0; j < cols; j++)
                        {
                            grid[i, j] = (GridType)Enum.Parse(typeof(GridType), line[j]);
                        }
                    }

                    return grid;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading maze: {ex.Message}", "Load Error");
                rows = 0;
                cols = 0;
                return null;
            }
        }

    }
}
