/*
 * QGameDesignForm.cs
 * QGame Design Form
 * Revision History
 * Chan Shong, Ridoy Mubarak Hussain, 2024.10.23: Created
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Group1_Chan_Ridoy_QGame.Properties;
using QGame_Library;

namespace Group1_Chan_Ridoy_QGame
{
    public partial class QGameDesignForm : Form
    {
        // Constants for grid positioning and size
        private const int INIT_TOP = 10;
        private const int INIT_LEFT = 10;
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        private const int VGAP = 1;
        private const int HGAP = 1;

        // variables for grid and selected tool
        private PictureBox[,] grid;
        private int row, col;
        private GridType selectedTool = GridType.Empty;

        // images used in the grid for different tools
        private readonly Bitmap emptyImage;
        private readonly Bitmap wallImage;
        private readonly Bitmap redDoorImage;
        private readonly Bitmap greenDoorImage;
        private readonly Bitmap blueDoorImage;
        private readonly Bitmap redBoxImage;
        private readonly Bitmap greenBoxImage;
        private readonly Bitmap blueBoxImage;

        /// <summary>
        /// Initializes a new instance of the QGameDesignForm class.
        /// </summary>
        public QGameDesignForm()
        {
            InitializeComponent();
            comboBoxRow.Items.AddRange(new string[] { "5", "8", "15" }); // Add row options to ComboBox
            comboBoxRow.SelectedIndex = 0;

            comboBoxCol.Items.AddRange(new string[] { "5", "8", "15" }); // Add column options to ComboBox
            comboBoxCol.SelectedIndex = 0;

            try // Load images for the grid
            {
                emptyImage = new Bitmap(Resources.square_white_1024);
                wallImage = new Bitmap(Resources.wall_1024);
                redDoorImage = new Bitmap(Resources.red_door_1024);
                greenDoorImage = new Bitmap(Resources.green_door_1024);
                blueDoorImage = new Bitmap(Resources.blue_door_1024);
                redBoxImage = new Bitmap(Resources.red_block_1024);
                greenBoxImage = new Bitmap(Resources.green_block_1024);
                blueBoxImage = new Bitmap(Resources.blue_block_1024);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnGenerate control.
        /// Generates a new grid based on the selected row and column values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (grid != null && IsGridModified()) // Check if the grid has been modified
            {
                DialogResult result = MessageBox.Show(
                    "Do you want to abandon the current level and start a new one?",
                    "Confirm New Level",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return; // Exit the method if the user chooses not to abandon the current level
                }
            }
            row = int.Parse(comboBoxRow.SelectedItem.ToString()); // Get the selected row value
            col = int.Parse(comboBoxCol.SelectedItem.ToString()); // Get the selected column value
            CreateGrid(row, col);
        }


        /// <summary>
        /// Checks if the grid has been modified by looking for any cell with a tool other than empty.
        /// </summary>
        /// <returns>True if the grid contains any non-empty cells; otherwise, false.</returns>
        private bool IsGridModified()
        {
            if (grid == null)
            {
                return false;
            }

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].Tag != null && (GridType)grid[i, j].Tag != GridType.Empty) // Check if the cell is not empty
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Creates a new grid with the specified number of rows and columns.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        private void CreateGrid(int rows, int cols)
        {
            if (grid != null)
            {
                ClearGrid();
            }

            grid = new PictureBox[rows, cols];
            panelDisplay.Controls.Clear();

            int x = INIT_LEFT;  // Starting X position for the grid
            int y = INIT_TOP;   // Starting Y position for the grid

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    PictureBox pictureBox = new PictureBox()  // Create a new PictureBox
                    {
                        Width = WIDTH, // Set width of PictureBox
                        Height = HEIGHT, // Set height of PictureBox
                        Left = x, // Set X position of PictureBox
                        Top = y, // Set Y position of PictureBox
                        BackColor = Color.White, // Set background color to white
                        BorderStyle = BorderStyle.FixedSingle, // Add border to PictureBox
                        Name = i.ToString() + "," + j.ToString(), // Unique name for each PictureBox
                        SizeMode = PictureBoxSizeMode.StretchImage // Set image size mode
                    };

                    panelDisplay.Controls.Add(pictureBox);  // Add PictureBox to panel
                    grid[i, j] = pictureBox;                 // Add PictureBox to grid array
                    pictureBox.Click += Cell_Click;          // Add click event handler

                    x += WIDTH + HGAP;  // Move to the next column
                }

                x = INIT_LEFT;          // Reset X position for new row
                y += HEIGHT + VGAP;     // Move to the next row
            }
        }


        /// <summary>
        /// Clears the current grid.
        /// </summary>
        private void ClearGrid()
        {
            foreach (var cell in grid) // Remove each cell from the panel
            {
                panelDisplay.Controls.Remove(cell);
            }
            grid = null;
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            selectedTool = GridType.Empty;
        }

        private void btnWall_Click(object sender, EventArgs e)
        {
            selectedTool = GridType.Wall;
        }

        private void btnRedDoor_Click(object sender, EventArgs e)
        {
            selectedTool = GridType.RedDoor;
        }

        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            selectedTool = GridType.GreenDoor;
        }

        private void btnBlueDoor_Click(object sender, EventArgs e)
        {
            selectedTool = GridType.BlueDoor;
        }

        private void btnRedBox_Click(object sender, EventArgs e)
        {
            selectedTool = GridType.RedBox;
        }

        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            selectedTool = GridType.GreenBox;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBlueBox_Click_1(object sender, EventArgs e)
        {
            selectedTool = GridType.BlueBox;
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// Saves the current maze to a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Maze Files (*.QG)|*.QG";
                saveFileDialog.Title = "Save Maze File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var gridType = GameManager.ConvertGridToGridType(grid); // Convert the PictureBox grid to GridType
                    GameManager.SaveMaze(saveFileDialog.FileName, gridType, row, col); // Pass the file name
                }
            }
        }


        /// <summary>
        /// Handles the Click event of the btnLoad control.
        /// Loads a maze from a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Maze Files (*.QG)|*.QG";
                openFileDialog.Title = "Open Maze File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GridType[,] loadedGrid = GameManager.LoadMaze(openFileDialog.FileName, out int loadedRows, out int loadedCols); // Load the maze

                    if (loadedGrid != null)
                    {
                        row = loadedRows;
                        col = loadedCols;
                        CreateGrid(row, col);
                        DisplayMaze(loadedGrid);

                        // Update ComboBox selections
                        comboBoxRow.SelectedItem = row.ToString();
                        comboBoxCol.SelectedItem = col.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of a cell in the grid.
        /// Sets the image and tag of the cell based on the selected tool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cell_Click(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;
            cell.Tag = selectedTool;

            switch (selectedTool)
            {
                case GridType.Empty:
                    cell.Image = emptyImage;
                    break;
                case GridType.Wall:
                    cell.Image = wallImage;
                    break;
                case GridType.RedDoor:
                    cell.Image = redDoorImage;
                    break;
                case GridType.GreenDoor:
                    cell.Image = greenDoorImage;
                    break;
                case GridType.BlueDoor:
                    cell.Image = blueDoorImage;
                    break;
                case GridType.RedBox:
                    cell.Image = redBoxImage;
                    break;
                case GridType.GreenBox:
                    cell.Image = greenBoxImage;
                    break;
                case GridType.BlueBox:
                    cell.Image = blueBoxImage;
                    break;
            }
        }


        /// <summary>
        /// Displays the loaded maze on the grid.
        /// Sets the image and tag of each cell based on the loaded grid data.
        /// </summary>
        /// <param name="loadedGrid"></param>
        private void DisplayMaze(GridType[,] loadedGrid)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    grid[i, j].Tag = loadedGrid[i, j]; // Set the tag of the cell
                    switch (loadedGrid[i, j]) // Set the image of the cell
                    {
                        case GridType.Empty:
                            grid[i, j].Image = emptyImage;
                            break;
                        case GridType.Wall:
                            grid[i, j].Image = wallImage;
                            break;
                        case GridType.RedDoor:
                            grid[i, j].Image = redDoorImage;
                            break;
                        case GridType.GreenDoor:
                            grid[i, j].Image = greenDoorImage;
                            break;
                        case GridType.BlueDoor:
                            grid[i, j].Image = blueDoorImage;
                            break;
                        case GridType.RedBox:
                            grid[i, j].Image = redBoxImage;
                            break;
                        case GridType.GreenBox:
                            grid[i, j].Image = greenBoxImage;
                            break;
                        case GridType.BlueBox:
                            grid[i, j].Image = blueBoxImage;
                            break;
                    }
                }
            }
        }
    }
}

