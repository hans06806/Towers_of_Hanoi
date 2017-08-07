using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Towers_of_Hanoi
{
    class Board
    {
        Disk[,] board; //condition says TWO dimentional array            
        ArrayList movements;
        Disk[] disks; //Array of disks
        DiskMove diskMove = new DiskMove();

        private const int NUM_DISKS = 4;
        private const int NUM_PEGS = 3;
        public int count = 0;

        public Board()
        {
            board = new Disk[NUM_PEGS, NUM_DISKS];

            //Array of disk objects
            disks = new Disk[NUM_DISKS];
            disks[0] = null;
            disks[1] = null;
            disks[2] = null;
            disks[3] = null;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  

            board[0, 3] = new Disk();
            board[0, 2] = new Disk();
            board[0, 1] = new Disk();
            board[0, 0] = new Disk();

            //Creating arraylist of movement 
            movements = new ArrayList();
        }


        //Alterntative constructor
        public Board(Disk d1, Disk d2, Disk d3, Disk d4)
        {
            //Storing into disks array
            disks = new Disk[NUM_DISKS];
            disks[0] = d1;
            disks[1] = d2;
            disks[2] = d3;
            disks[3] = d4;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  
            board[0, 3] = d1;
            board[0, 2] = d2;
            board[0, 1] = d3;
            board[0, 0] = d4;

            //Arraylist of movement.
            movements = new ArrayList();
        }


        public void reset()
        {

            for (int iP = 0; iP < NUM_PEGS; iP++)
            {
                //Remove all elements from board array
                for (int iD = 0; iD < NUM_DISKS; iD++)
                {
                    board[iP, iD] = null;
                    //Update disks array
                    disks[iD].setPegNum(0);
                    disks[iD].setLevel(NUM_DISKS - 1 - iD);
                }
            }
            
            //Reallocate elements 
            board[0, 3] = disks[0]; //Peg 1/Level4 
            board[0, 2] = disks[1]; //Peg 1/Level3 
            board[0, 1] = disks[2]; //Peg 1/Level2
            board[0, 0] = disks[3]; //Peg 1/Level1 

            move(disks[0], 3, 0);
            move(disks[1], 2, 0);
            move(disks[2], 1, 0);
            move(disks[3], 0, 0);

            //Remove all elements from movement arraylist
            movements.Clear();
            count = 0;
        }


        public bool canStartMove(Disk aDisk)
        {
            if (aDisk.getLevel() < 3)
            {
                if (board[aDisk.getPegNum(), aDisk.getLevel()] == null)
            {
                MessageBox.Show("Invalid Move - no disk at start point");
                return false;
            }
                if (board[aDisk.getPegNum(), aDisk.getLevel()+1] != null)
                {
                    MessageBox.Show("Invalid Move - can only move top disk");
                    return false;
                }
            }
            return true;
        }


        public bool canDrop(Disk aDisk, int aPeg)
        {

            if (board[aPeg, 3] != null)
            {
                MessageBox.Show("Invalid Move - pole is full");
                return false;
            }
            if (newLevInPeg(aPeg)-1 >= 0)
            {
                if (aDisk.getDiameter() >= board[aPeg, newLevInPeg(aPeg) - 1].getDiameter())
                {
                    MessageBox.Show("Invalid Move - cannot drop bigger disk on smaller");
                    return false;
                }
            }    
            return true;
        }


        public void move(Disk aDisk, int newLevel , int newPole)
        {
            //Change the disk place in the board
            board[aDisk.getPegNum(), aDisk.getLevel()] = null;
            board[newPole, newLevel] = aDisk;

            //Set the new pegNum and new level of the disk
            aDisk.setPegNum(newPole);
            aDisk.setLevel(newLevel);

            Display(aDisk);

            //Store the move to the movement array
            diskMove = new DiskMove(getDiskInd(aDisk), newPole);
            movements.Add(diskMove.AsText());

            //Increase move count
            count += 1;
        
        }


        public string allMovesAsString()
        {
            string moves="";
            int count = movements.Count;
            for (int i = 0; i < count; i++) { 
                moves += movements[i].ToString() + "\n";
            }
                return moves;  // Dummy return to avoid syntax error - must be changed
        }


        public void Display(Disk aDisk)
        {
            aDisk.label.Hide();
            aDisk.label.Left = 228 + ((aDisk.getPegNum()) * 180) - (aDisk.getDiameter() / 2);
            aDisk.label.Top = 240 - ((aDisk.getLevel() + 1) * 24);
            aDisk.label.Show();
        }


        public Disk FindDisk(Label aLabel)
        {
            for (int ipole = 0; ipole < NUM_PEGS ; ipole++)
            {
                for (int jlevel = 0; jlevel < NUM_DISKS; jlevel++)
                {
                    if (board[ipole, jlevel] != null)
                    {
                        if (board[ipole, jlevel].label == aLabel)
                        {
                            return board[ipole, jlevel];
                        }
                    }
                }          
            }
            return null;
        }


        public int newLevInPeg(int pegNum)
        {
            for (int iLevel = 0; iLevel < NUM_DISKS; iLevel++)
            {
                if (board[pegNum, iLevel] == null) {
                    return iLevel;
                }
            }
            return 0;
        }

 
        public String getText(int cnt)
        {
            return "1";    // Dummy return to avoid syntax error - must be changed
        }


        public void backToSelected(int ind)
        {

        }


        public int getPegInd(int ind)
        {
             return 1;    // Dummy return to avoid syntax error - must be changed
        }

        public int getDiskInd(Disk aDisk)
        {
            for (int i = 0; i < 4; i++)
            {
                if (disks[i] == aDisk)
                    {
                        return i;
                    }

            }          
            return 1;    // Dummy return to avoid syntax error - must be changed
        }

        public int getLevel(int ind)
        {
            return 1;    // Dummy return to avoid syntax error - must be changed
        }


        public void unDo()
        {

        }


        public void loadData(ArrayList dm)
        {

        }
   }
}
