using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormApp
{

    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            

            


        }

        public void Form2_Load(object sender, EventArgs e)
        {
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            
            globalVariables.player1.SoundLocation = globalVariables.soundFileLocation;
            globalVariables.player1.PlayLooping();

            
            










        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Dispose();
            Refresh();
            globalVariables.player1.Stop();



            
          
            

        }

        public class globalVariables
        {
            public static String filepath = @"C:\Users\MochiBot\Documents\Visual Studio 2017\Projects\FormApp\FormApp\res\ToothySmile.png";
            public static String filepath2 = @"C:\Users\MochiBot\Documents\Visual Studio 2017\Projects\FormApp\FormApp\res\KeriyoEmoticonsdemo.png";
            public static String filepath3 = @"C:\Users\MochiBot\Documents\Visual Studio 2017\Projects\FormApp\FormApp\res\Sad.png";
            //public static String filepath4 = @"C:\Users\MochiBot\Documents\Visual Studio 2017\Projects\FormApp\FormApp\res\Confident.png";

            public static String winText = "You Win!";
            public static Boolean Button1Clicked = false;
            public static Boolean Button2Clicked = false;
            public static Boolean Button3Clicked = false;
            public static Boolean Button4Clicked = false;
            //public static Boolean firstMatch = Button2Clicked && Button4Clicked || Button4Clicked && Button2Clicked;
            //public static Boolean secondMatch = Button1Clicked && Button3Clicked || Button3Clicked && Button1Clicked;
            public static Boolean Button5Clicked = false;
            public static Boolean Button6Clicked = false;
            public static int Counter = 3;
            public static System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();

            
            public static String soundFileLocation = @"C:\Users\MochiBot\Documents\Visual Studio 2017\Projects\FormApp\FormApp\res\PeacefulSoundtrack.wav";
            
            






        }



        public void CountMatches()
        {
            globalVariables.Counter -= 1; 
            if(globalVariables.Counter == 0)
            {
                MessageBox.Show("You Win!"); 

            }

        }

        

       

      

        

        void LoadPicture(Button buttonNumber, String filepathNumber)
        {
            buttonNumber.BackgroundImage = Image.FromFile(filepathNumber); 

        }














        private void Button6_Click(object sender, EventArgs e)
        {
            globalVariables.Button6Clicked = true;
            LoadPicture(button6, globalVariables.filepath3); 
            if(globalVariables.Button5Clicked == true)
            {
                Controls.Remove(button6);
                Controls.Remove(button5);
                MessageBox.Show("You got a match!");
                globalVariables.Button5Clicked = false;
                globalVariables.Button6Clicked = false;
                CountMatches(); 
                
            }
            if (globalVariables.Button4Clicked == true)
            {
                button4.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button4Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button3Clicked == true)
            {
                button3.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button3Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button2Clicked == true)
            {
                button2.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button2Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button1Clicked == true)
            {
                button1.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button1Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }



        }

        private void Button5_Click(object sender, EventArgs e)
        {
            globalVariables.Button5Clicked = true;
            LoadPicture(button5, globalVariables.filepath3);

            if (globalVariables.Button6Clicked == true)
            {
                Controls.Remove(button6);
                Controls.Remove(button5);
                MessageBox.Show("You got a match!");
                globalVariables.Button5Clicked = false;
                globalVariables.Button6Clicked = false;
                CountMatches(); 

            }
            if (globalVariables.Button4Clicked == true)
            {
                button5.BackgroundImage = null;
                button4.BackgroundImage = null;

                globalVariables.Button5Clicked = false;
                globalVariables.Button4Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button3Clicked == true)
            {
                button3.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button3Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button2Clicked == true)
            {
                button5.BackgroundImage = null;
                button2.BackgroundImage = null;

                globalVariables.Button2Clicked = false;
                globalVariables.Button5Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button1Clicked == true)
            {
                button1.BackgroundImage = null;
                button5.BackgroundImage = null;

                globalVariables.Button1Clicked = false;
                globalVariables.Button5Clicked = false;

                MessageBox.Show("Not a match!");

            }
        }




        private void Button4_Click(object sender, EventArgs e)
        {
            globalVariables.Button4Clicked = true;
            LoadPicture(button4, globalVariables.filepath2);
            if (globalVariables.Button1Clicked == true)
            {


                Controls.Remove(button1);
                Controls.Remove(button4);
                MessageBox.Show("You got a match!");
                globalVariables.Button1Clicked = false;
                globalVariables.Button4Clicked = false;
                CountMatches(); 

            }

            if (globalVariables.Button2Clicked == true)
            {
                button4.BackgroundImage = null;
                button2.BackgroundImage = null;

                globalVariables.Button4Clicked = false;
                globalVariables.Button2Clicked = false;

                MessageBox.Show("Not a match!"); 

            }
            if (globalVariables.Button5Clicked == true)
            {
                button4.BackgroundImage = null;
                button5.BackgroundImage = null;

                globalVariables.Button4Clicked = false;
                globalVariables.Button5Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button6Clicked == true)
            {
                button4.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button4Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button3Clicked == true)
            {
                button3.BackgroundImage = null;
                button4.BackgroundImage = null;

                globalVariables.Button3Clicked = false;
                globalVariables.Button4Clicked = false;

                MessageBox.Show("Not a match!"); 
            }
          
          
        }




        public void Button3_Click(object sender, EventArgs e)
        {
            globalVariables.Button3Clicked = true; 
            LoadPicture(button3, globalVariables.filepath);
            if (globalVariables.Button2Clicked == true)
            {
                Controls.Remove(button2);
                Controls.Remove(button3);
                MessageBox.Show("You got a match!");
                globalVariables.Button2Clicked = false;
                globalVariables.Button3Clicked = false;
                CountMatches(); 


            }
            if (globalVariables.Button1Clicked == true)
            {
                button3.BackgroundImage = null;
                button1.BackgroundImage = null;
                globalVariables.Button3Clicked = false;
                globalVariables.Button1Clicked = false;
                MessageBox.Show("Not a match!");
            }
            if(globalVariables.Button4Clicked == true)
            {

                button3.BackgroundImage = null;
                button4.BackgroundImage = null;

                globalVariables.Button4Clicked = false;
                globalVariables.Button3Clicked = false;

                MessageBox.Show("Not a match!"); 
            }
            if (globalVariables.Button5Clicked == true)
            {
                button3.BackgroundImage = null;
                button5.BackgroundImage = null;

                globalVariables.Button3Clicked = false;
                globalVariables.Button5Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button6Clicked == true)
            {
                button3.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button3Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }








        }

        public void Button2_Click(object sender, EventArgs e)
        {
            globalVariables.Button2Clicked = true; 
            LoadPicture(button2, globalVariables.filepath);




            if (globalVariables.Button3Clicked == true)
            {
                Controls.Remove(button2);
                Controls.Remove(button3);
                MessageBox.Show("You got a match!");
                globalVariables.Button2Clicked = false;
                globalVariables.Button3Clicked = false;
                CountMatches(); 


            }
            if (globalVariables.Button1Clicked == true)
            {
                button1.BackgroundImage = null;
                button2.BackgroundImage = null;

                globalVariables.Button2Clicked = false;
                globalVariables.Button1Clicked = false; 

                MessageBox.Show("Not a match!");
            }

            if(globalVariables.Button4Clicked == true)
            {
                button4.BackgroundImage = null;
                button2.BackgroundImage = null;

                globalVariables.Button2Clicked = false;
                globalVariables.Button4Clicked = false;

                MessageBox.Show("Not a match!"); 


            }
            if (globalVariables.Button5Clicked == true)
            {
                button2.BackgroundImage = null;
                button5.BackgroundImage = null;

                globalVariables.Button2Clicked = false;
                globalVariables.Button5Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button6Clicked == true)
            {
                button2.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button2Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }
















        }

        public void Button1_Click(object sender, EventArgs e)
        {
            globalVariables.Button1Clicked = true; 
            LoadPicture(button1, globalVariables.filepath2);
            if (globalVariables.Button4Clicked == true)
            {
                Controls.Remove(button1);
                Controls.Remove(button4);
                MessageBox.Show("You got a match!");
                globalVariables.Button2Clicked = false;
                globalVariables.Button3Clicked = false;
                CountMatches(); 

            }

            if (globalVariables.Button2Clicked == true)
            {
                button1.BackgroundImage = null;
                button2.BackgroundImage = null;

                globalVariables.Button1Clicked = false;
                globalVariables.Button2Clicked = false;
                MessageBox.Show("Not a match!"); 
            } 
            
            

            if(globalVariables.Button3Clicked == true)
            {

                button1.BackgroundImage = null;
                button3.BackgroundImage = null;

                globalVariables.Button1Clicked = false;
                globalVariables.Button3Clicked = false;
                MessageBox.Show("Not a match!"); 
            }
            if (globalVariables.Button5Clicked == true)
            {
                button1.BackgroundImage = null;
                button5.BackgroundImage = null;

                globalVariables.Button1Clicked = false;
                globalVariables.Button5Clicked = false;

                MessageBox.Show("Not a match!");

            }
            if (globalVariables.Button6Clicked == true)
            {
                button1.BackgroundImage = null;
                button6.BackgroundImage = null;

                globalVariables.Button1Clicked = false;
                globalVariables.Button6Clicked = false;

                MessageBox.Show("Not a match!");

            }







        }


       

        
    }
}
