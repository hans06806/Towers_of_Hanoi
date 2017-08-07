using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Towers_of_Hanoi
{
    public partial class MainForm : Form
    {

        Board board = new Board();
        
        //array of possible positions of disks over the 3 poles and four levels
        //the array keeps track of where the labels representing the disks are
        //the Disk class stores the pole and level of a label representing the disk
        //as well as an object refrence to the label
        private int targetPole = 0;

        //if moves are being made from a list, not by drag and drop
        //isStepping is used to prevent recording the moves made

        private int MoveCount = 0; //count of moves made in a board



        public MainForm()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, System.EventArgs e)
		//create Disk objects matching the "Disk" labels on the first pole
		{
            board = new Board(new Disk(Disk1, 2, 0, 3), new Disk(Disk2, 2, 0, 2),
                              new Disk(Disk3, 2, 0, 1), new Disk(Disk4, 2, 0, 0));
		}
       

        private void Disk1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Label alabel = (sender as Label);


            DragDropEffects result = alabel.DoDragDrop(alabel, DragDropEffects.All);
            if (result != DragDropEffects.None)
            {
                if (board.canStartMove(board.FindDisk(alabel)) && board.canDrop(board.FindDisk(alabel), targetPole))
                {

                    board.move(board.FindDisk(alabel), board.newLevInPeg(targetPole), targetPole);
                    string theMove = board.allMovesAsString();
                    txtMoves.Text = theMove;
                    txtCount.Text = board.count.ToString();
                }
            }
        }
        private void lblPeg2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        //change the cursor to show dropping is allowed
        {
            e.Effect = DragDropEffects.All;
        }


        private void lblPeg1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        //when a drop happens store the information about which pole was
        //dropped on in the global variable targetPole
        {
            Label alabel = (sender as Label);
            if (alabel == lblPeg1) targetPole = 0;
            else if (alabel == lblPeg2) targetPole = 1;
            else if (alabel == lblPeg3) targetPole = 2;
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            board.reset();
            txtMoves.Text = "";
            txtCount.Text = "";

        }
    }
}
