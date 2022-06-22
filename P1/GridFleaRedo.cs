/*
 * Constructor receive one parameter : int size; 
 * if that number >10, then that will be the int passed to the function initialize
 *if <10, defualt size is 10
 *the size is then save ( originalSize) to help when reseting 
 *The function initialize is then called to initialize the object 
 * x, y, currentX, currentY are initially set to 0
 * some random algebra is done to calculte reward as well as triggerActive( which determines
 * after how many moves the object becomes inactive) 
 * active and energetic are initially set to true
 * permanentDesactivated is set to false
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Redo
{
    public class GridFleaRedo
    {
        private int x, y, originalSize, reward, size, totalChange, triggerInactive;
        private int lowerLimit, upperLimit, currentX, currentY, countMoves;
        bool energetic, active, permanentlyDesactivated;

   public GridFleaRedo(int givenSize)
        {
            if (givenSize < 10)
            {
                size= 10; 
            }
            else
            {
                size = givenSize; 
            }
            originalSize = size;

            initialize(size);


        }

        //helper function for the constructor and reset function 
        private void initialize(int sizeOfGrid)
        {
            x = 0;
            y = 0;
            currentX = x;
            currentY = y;
            active = true;
            energetic = true; 
            permanentlyDesactivated = false;
            upperLimit = sizeOfGrid;
            lowerLimit = -(sizeOfGrid);
            if (sizeOfGrid % 2 == 0) { 
                reward = sizeOfGrid * 10;
                triggerInactive = size / 2; 
            } 

            else {
                reward = sizeOfGrid * 5 ;
                triggerInactive = size / 3;
            }
                
            
        }

        //if active & energetic, moves p squares 
        //if active but not energetic, move 1 sqaure
        //moves can be made on either axis: 
        //reward is updated
        //check that the object does not move outside of boundaries when moving
        //if it does, object becomes inactive & permanentlyDesactivated
        //Pre: active object & not permanentlyDesactivated 
        //Post: state of the object( active & permanentDesactivated) may be altered
        public void Move(int p)
        {
            int squaresMove;
            

            if (reward < size)
            {
                energetic = false; 
            }

            
            if (active)
            {
                countMoves++; 

                if (energetic)
                {
                    squaresMove = p;
                }
                else
                {
                    squaresMove = 1; 
                }

                if (size % reward == 0)
                {
                    moveOnX(squaresMove);
                }

                if (size % reward != 0)
                {
                    moveOnY(squaresMove);
                }

            }
            if (countMoves > triggerInactive)
            {
                active = false; 
            }

        }

        //helper function for Move
        private void moveOnX(int move)
        {
            if (reward % 2 == 0)
            {
                move *= 1;
                
            }
            currentX += move;
            reward -= move; 
            if (currentX < lowerLimit || currentX > upperLimit)
            {
                permanentlyDesactivated = true;
                active = false;
            }
            Console.WriteLine(" squares move: " + move + " energetic " + energetic);

        }

        //helper function for Move
        private void moveOnY(int move)
        {
            if (reward % 2 == 0)
            {
                move *= 1;

            }

            currentY += move;
            reward -= move;
            if (currentY < lowerLimit || currentY > upperLimit)
            {
                permanentlyDesactivated = true;
                active = false;
            }
            Console.WriteLine(" squares move: " + move + " energetic " + energetic);

        }

        //Returns the value of the gridFlea object 
        //if object is active, value= size * reward * totalChange
        //else, it returns 0
        //Pre: Object needs to be in active mode 
        public int Value()
        {
            int value = 0; 
            totalChange=(x-currentX)+(y-currentY);
            if (active)
            {
                value = size * reward * totalChange;
            }
            return value; 
        }


        
        public int DisplayReward()
        {
            return reward;
        }

        public bool DisplayActiveState()
        {
            return active; 
        }

        public bool DisplayPermanentState()
        {
            return permanentlyDesactivated; 
        }
        //Brings the object to the state it was initially
        //Pre: object needs not to be permanently desactivated
        //Post: state of the object may be altered 
        public void Reset()
        {
            if (!permanentlyDesactivated)
            {
                initialize(originalSize);
            }
        }

        //set the gridFlea object to active state again
        //Pre: object not permanently desactivated & inactive 
        //Post: State of the object may be altered
        public void Revive()
        {
            if (!permanentlyDesactivated)
            {
                if (!active)
                {
                    active = true;
                }
            }
        }
    }
}
