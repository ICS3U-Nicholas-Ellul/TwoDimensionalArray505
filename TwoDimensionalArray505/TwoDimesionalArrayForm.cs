/*
 * Created by: Nicholas Ellul
 * Created on: 19-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 5-06
 * This program returns the average of a 2D array.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDimensionalArray505
{
    public partial class frm2DArray : Form
    {
        Random randomizedNum = new Random();
        public frm2DArray()
        {
            InitializeComponent();
        }


       public int AverageOf2DArray(int[,] theArray2, int width, int length)
       {
            //returns average of a two dimensional array
            int sum = 0;
            int elementsInArray = width * length;

          for (int columnCounter = 0; columnCounter < length; columnCounter++)
          {
                for (int rowCounter = 0; rowCounter < width; rowCounter++)
                {
                    sum = sum + theArray2[columnCounter, rowCounter];
                }
          }
            
          if(elementsInArray == 0)
            {
                return 0;
            }

             return sum/elementsInArray;
      }


        private void btnGo_Click(object sender, EventArgs e)
        {
            //input
            int length = Convert.ToInt32(nudLength.Value);
            int width = Convert.ToInt32(nudWidth.Value);
            int generatedNumber;
            string theAverage;

            int[,] my2Darray = new int[length, width];

            //process
            lstListOfNumbers.Items.Clear();
            for(int lengthCounter = 0; lengthCounter < length; lengthCounter++)
            {
                for(int widthCounter = 0; widthCounter < width; widthCounter++)
                {
                    generatedNumber = randomizedNum.Next(0, 10 + 1);
                    my2Darray[lengthCounter, widthCounter] = generatedNumber;
                    this.lstListOfNumbers.Items.Add(generatedNumber);
                }
            }


            //output
            theAverage = Convert.ToString(AverageOf2DArray(my2Darray, width, length));
            MessageBox.Show(theAverage, "Your Average is...");
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
          /*  
            // generate the array
            int width;
            int length;
            Random randomNumberGenerator = new Random();
            int aRandomNumber;
            string aPieceOfText = null;

            width = 4; //Convert.ToInt16(this.nudWidth.Value);
            length = 2;//Convert.ToInt16(this.nudLength.Value);

            // declare the array
            int[,] a2DArray = new int[width, length];

            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    aRandomNumber = randomNumberGenerator.Next(0, 9 + 1);
                    a2DArray[widthCounter, lengthCounter] = aRandomNumber;
                    aPieceOfText = aPieceOfText + " " + aRandomNumber;
                }
                    aPieceOfText = aPieceOfText + "\r" + "\n";
            }

            //this.txtArray.Text = aPieceOfText;
            MessageBox.Show(aPieceOfText); */
        }
       
    }
}
