/*
 * QGamePlayForm.cs
 * QGame Play Form
 * Revision History
 * Chan Shong, Ridoy Mubarak Hussain, 2024.11.22: Created
 */

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Schema;
using Group1_Chan_Ridoy_QGame.Properties;
using QGame_Library;

namespace Group1_Chan_Ridoy_QGame
{
    public partial class QGamePlayForm : Form
    {
        // Variables
        private PictureBox[,] grid;
        private int rows, cols;
        private PictureBox selectedBox;
        private int moves = 0;
        private int remainingBoxes;

        // Image resources
        private Bitmap emptyImage;
        private Bitmap wallImage;
        private Bitmap redDoorImage;
        private Bitmap greenDoorImage;
        private Bitmap blueDoorImage;
        private Bitmap redBoxImage;
        private Bitmap greenBoxImage;
        private Bitmap blueBoxImage;
        private Bitmap redBoxSelectedImage;
        private Bitmap greenBoxSelectedImage;
        private Bitmap blueBoxSelectedImage;

        // Constants for grid positioning and size
        private const int INIT_TOP = 20;
        private const int INIT_LEFT = 20;
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        private const int VGAP = 1;
        private const int HGAP = 1;

        public QGamePlayForm()
        {
            InitializeComponent();
            LoadImages();
        }


        /// <summary>
        /// Load the images from resources
        /// </summary>
        private void LoadImages()
        {
            try
            {
                emptyImage = Resources.square_white_1024;
                wallImage = Resources.wall_1024;
                redDoorImage = Resources.red_door_1024;
                greenDoorImage = Resources.green_door_1024;
                blueDoorImage = Resources.blue_door_1024;
                redBoxImage = Resources.red_block_1024;
                greenBoxImage = Resources.green_block_1024;
                blueBoxImage = Resources.blue_block_1024;
                redBoxSelectedImage = Resources.red_box_selected_1024;
                greenBoxSelectedImage = Resources.green_box_selected_1024;
                blueBoxSelectedImage = Resources.blue_box_selected_1024;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Create a new maze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Maze Files (*.QG)|*.QG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GridType[,] loadedGrid = GameManager.LoadMaze(openFileDialog.FileName, out rows, out cols);

                    if (loadedGrid != null)
                    {
                        moves = 0;
                        ClearGrid();
                        CreateGrid(rows, cols);
                        DisplayMaze(loadedGrid);
                        remainingBoxes = CountRemainingBoxes();
                        UpdateCounters();
                    }
                }
            }
        }


        /// <summary>
        /// Clear the grid
        /// </summary>
        private void ClearGrid()
        {
            if (grid != null)
            {
                foreach (var cell in grid)
                {
                    if (cell != null)
                    {
                        panelDisplay.Controls.Remove(cell);
                    }
                }
            }
        }


        /// <summary>
        /// Create the grid of PictureBoxes
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        private void CreateGrid(int rows, int cols)
        {
            grid = new PictureBox[rows, cols];

            int x = INIT_LEFT; 
            int y = INIT_TOP;   

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Width = WIDTH, 
                        Height = HEIGHT, 
                        Left = x, 
                        Top = y, 
                        Size = new Size(50, 50),
                        Location = new Point(x, y),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    pictureBox.Click += PictureBox_Click;
                    panelDisplay.Controls.Add(pictureBox);
                    grid[i, j] = pictureBox;

                    x += WIDTH + HGAP;
                }
                x = INIT_LEFT;          
                y += HEIGHT + VGAP;     
            }
        }


        /// <summary>
        /// Display the maze on the grid
        /// </summary>
        /// <param name="loadedGrid"></param>
        private void DisplayMaze(GridType[,] loadedGrid)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
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



        /// <summary>
        /// Handle the click event on a PictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;

            if (clickedBox?.Tag is GridType type && (type == GridType.RedBox || type == GridType.GreenBox || type == GridType.BlueBox))
            {
                if (selectedBox != null)
                {
                    // Reset the image of the previously selected box
                    switch ((GridType)selectedBox.Tag)
                    {
                        case GridType.RedBox:
                            selectedBox.Image = redBoxImage;
                            break;
                        case GridType.GreenBox:
                            selectedBox.Image = greenBoxImage;
                            break;
                        case GridType.BlueBox:
                            selectedBox.Image = blueBoxImage;
                            break;
                    }
                    selectedBox.BorderStyle = BorderStyle.None;
                }

                selectedBox = clickedBox;
                selectedBox.BorderStyle = BorderStyle.FixedSingle;

                // Change the image of the selected box
                switch (type)
                {
                    case GridType.RedBox:
                        selectedBox.Image = redBoxSelectedImage;
                        break;
                    case GridType.GreenBox:
                        selectedBox.Image = greenBoxSelectedImage;
                        break;
                    case GridType.BlueBox:
                        selectedBox.Image = blueBoxSelectedImage;
                        break;
                }
            }
        }


        /// <summary>
        /// Move the selected box in the specified direction
        /// </summary>
        /// <param name="direction"></param>
        private void MoveBox(Direction direction)
        {
            if (selectedBox == null)
            {
                MessageBox.Show("Please select a box to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedBox.BorderStyle = BorderStyle.None;

            int row = selectedBox.Location.Y / 50;
            int col = selectedBox.Location.X / 50;
            bool boxRemoved = false;

            GridType boxType = (GridType)selectedBox.Tag;
            int newRow = row, newCol = col;
            bool boxMoved = false;
            while (true)
            {
                // Move in the selected direction
                switch (direction)
                {
                    case Direction.Up:
                        newRow--;
                        break;
                    case Direction.Down:
                        newRow++;
                        break;
                    case Direction.Left:
                        newCol--;
                        break;
                    case Direction.Right:
                        newCol++;
                        break;
                }

                // Check if the new position is within grid bounds
                if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols)
                {
                    // Reached the edge of the grid; stop moving
                    break;
                }

                var targetBox = grid[newRow, newCol];
                if (targetBox.Tag is GridType targetType)
                {
                    if (targetType == GridType.Wall || targetType == GridType.RedBox || targetType == GridType.GreenBox || targetType == GridType.BlueBox)
                    {
                        // Hit a wall or another box; stop moving
                        break;
                    }

                    if (IsMatchingDoor(boxType, targetType))
                    {
                        // Reached a matching door; remove the box
                        RemoveBox(selectedBox);
                        boxRemoved = true;
                        selectedBox = null;
                        boxMoved = true;
                        break;
                    }

                    if (targetType == GridType.Empty)
                    {
                        // Move the box to the empty cell
                        SwapCells(selectedBox, targetBox);
                        // Update selectedBox to the new position
                        selectedBox = targetBox;
                        row = newRow;
                        col = newCol;
                        boxMoved = true;
                    }
                    else
                    {
                        // Encountered an unmatched door or invalid cell; stop moving
                        break;
                    }
                }
                else
                {
                    // Invalid target cell; stop moving
                    break;
                }
            }

            
            if (boxMoved)
            {
                moves++;
            }
            UpdateCounters();
            CheckForGameEnd();
        }


        /// <summary>
        /// Check if the box type matches the door type
        /// </summary>
        /// <param name="boxType"></param>
        /// <param name="doorType"></param>
        /// <returns></returns>
        private bool IsMatchingDoor(GridType? boxType, GridType doorType)
        {

            if (boxType == GridType.RedBox && doorType == GridType.RedDoor)
            {
             
                return true;
            }
            else if (boxType == GridType.GreenBox && doorType == GridType.GreenDoor)
            {
                return true;
            }
            else if (boxType == GridType.BlueBox && doorType == GridType.BlueDoor)
            {
                return true;
            }

            return false;
        }

        private void RemoveBox(PictureBox box)
        {
            box.Image = emptyImage;
            box.Tag = GridType.Empty;
            remainingBoxes--;
        }


        /// <summary>
        /// Swap the contents of two PictureBox cells
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        private void SwapCells(PictureBox source, PictureBox target)
        {
            target.Image = source.Image;
            target.Tag = source.Tag;

            source.Image = emptyImage;
            source.Tag = GridType.Empty;
        }


        private void CheckForGameEnd()
        {
            if (remainingBoxes == 0)
            {
                MessageBox.Show("Congratulations!! All Boxes are removed", "Game Over", MessageBoxButtons.OK);
                txtMoves.Text = "0";
                txtBoxes.Text = "0";
                ClearGrid();
            }
        }


        private int CountRemainingBoxes()
        {
            int count = 0;
            foreach (var cell in grid)
            {
                if (cell.Tag is GridType tag && (tag == GridType.RedBox || tag == GridType.GreenBox || tag == GridType.BlueBox))
                    count++;
            }
            return count;
        }


        private void UpdateCounters()
        {
            txtMoves.Text = moves.ToString();
            txtBoxes.Text = remainingBoxes.ToString();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveBox(Direction.Left);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveBox(Direction.Right);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveBox(Direction.Up);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveBox(Direction.Down);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
