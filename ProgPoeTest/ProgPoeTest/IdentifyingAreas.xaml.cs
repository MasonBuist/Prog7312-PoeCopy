using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgPoeTest
{
    /// <summary>
    /// Interaction logic for IdentifyingAreas.xaml
    /// </summary>
    public partial class IdentifyingAreas : Window
    {
        // Declare variables and data structures
        Dictionary<String, String> userDictionary = new Dictionary<String, String>();
        DeweyClass gameStart = new DeweyClass();
        List<String> cn;// List for call numbers
        List<String> d; // List for descriptions
        List<String> answers = new List<String>();
        String keyValuePairs1 = "";
        String keyValuePairs2 = "";
        int score = 0;

        public IdentifyingAreas()
        {
            InitializeComponent();

            initializingGame();// Initialize the game and UI components

        }
        // Button click to switch between Call Numbers and Descriptions
        private void switchBtn_Click(object sender, RoutedEventArgs e)
        {
            userDictionary = null;
            userDictionary = new Dictionary<String, String>();

            if (firstlabeltxb.Text.Equals("Call Numbers"))
            {
                firstlabeltxb.Text = "Description";
                secondlabeltxb.Text = "Call Numbers";
                listBoxA.Items.Clear();
                listBoxB.Items.Clear();
                initializingGame();
            }
            else if (firstlabeltxb.Text.Equals("Description"))
            {
                firstlabeltxb.Text = "Call Numbers";
                secondlabeltxb.Text = "Description";
                listBoxA.Items.Clear();
                listBoxB.Items.Clear();
                initializingGame();
            }
           

        }

        // Button click to match call Numbers with descriptions
        private void matchBtn_Click(object sender, RoutedEventArgs e)
        {
            String leftCol = "";
            String rightCol = "";

            leftCol = listBoxA.SelectedItem.ToString();
            rightCol = listBoxB.SelectedItem.ToString();


            userDictionary.Add(leftCol, rightCol);

            MessageBox.Show("matched");
        }

        // Button click to display the results
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            keyValuePairs1 = "";
            keyValuePairs2 = "";
            foreach (var item in userDictionary)
            {
                keyValuePairs1 += $"{item.Key} - {item.Value} \n";

            }

            foreach (var item in gameStart.callNumberDescription)
            {
                keyValuePairs2 += $"{item.Key} - {item.Value} \n";

            }
            MessageBox.Show("The call Numbers and their description you have matched: \n" + keyValuePairs1 + "\n" +
                "The correct call Numbers and their description: \n" + keyValuePairs2, "Results", MessageBoxButton.OK, MessageBoxImage.Information);

            // Check and update the user's score
            if (firstlabeltxb.Text.Equals("Call Numbers"))
            {
                foreach (var item in userDictionary)
                {
                    if (gameStart.callNumberDescription.ContainsKey(item.Key))
                    {
                        gameStart.callNumberDescription.TryGetValue(item.Key, out String val);
                        if (val.Equals(item.Value))
                        {
                            score++;
                        }
                        else
                        {

                        }


                    }
                }
            }
            else
            {
                foreach (var item in userDictionary)
                {
                    if (gameStart.callNumberDescription.ContainsKey(item.Value))
                    {
                        gameStart.callNumberDescription.TryGetValue(item.Key, out String val);
                        var key = gameStart.callNumberDescription.FirstOrDefault(x => x.Key == item.Value).Key;
                        if (key.Equals(item.Value))
                        {
                            score++;
                        }
                        else
                        {

                        }
                    }
                }
            }
            // Show the user's score
            MessageBox.Show("Your score is: " + score);
        }

        // Initialize the game by generating random items for matching
        public void initializingGame()
        {
            userDictionary.Clear();
            if (firstlabeltxb.Text.Equals("Call Numbers"))
            {
                cn = gameStart.randonNumberGen(); // Generate random call numbers

                for (int i = 0; i < 4; i++)
                {
                    listBoxA.Items.Add(cn[i]); // Display call numbers in list
                }

                d = gameStart.descriptionInitialization(); // Initialize descriptions

                if (listBoxB.Items.Count == 0)
                {
                    correctAnswers(cn, true);

                }
                else
                {
                    listBoxB.Items.Clear();
                    correctAnswers(cn, true);

                }

            }
            else if (firstlabeltxb.Text.Equals("Description"))
            {

                d = gameStart.descriptionInitialization();  // Initialize descriptions

                for (int i = 0; i < 4; i++)
                {
                    listBoxA.Items.Add(d[i]);// Display descriptions in list
                }

                cn = gameStart.callNumberIntialization(); // Generate random call numbers
                correctAnswers(cn, false);

            }
            else
            {
                MessageBox.Show("Opps that wasn't meant to happen");
            }



        }
        // Button click to refresh and restart the game
        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            
            listBoxB.Items.Clear();
            listBoxA.Items.Clear();
            userDictionary = null;
            userDictionary = new Dictionary<String, String>();
            score = 0;
            gameStart.callNumbers.Clear();
            gameStart.description.Clear();
            initializingGame();
        }
        // This method generates correct answers for matching
        public void correctAnswers(List<String> callN, bool sw)
        {

            List<String> myAnswers = new List<String>();

            for (int i = 0; i < callN.Count(); i++)
            {
                if (sw)
                {
                    gameStart.callNumberDescription.TryGetValue(callN[i], out String val);
                    myAnswers.Add(val);
                }
                else
                {

                    if (gameStart.callNumberDescription.ContainsKey(callN[i]))
                    {
                        Debug.WriteLine(myAnswers.Count());
                        var key = gameStart.callNumberDescription.FirstOrDefault(y => y.Key == (callN[i])).Key;
                        myAnswers.Add(callN[i]);
                    }
                }

            }


            int x = 0;
            Random rand = new Random();
            
            while (x < 3)
            {
                if (sw)
                {
                    int gameDictionary = rand.Next(0, gameStart.callNumberDescription.Count());

                    if (!myAnswers.Contains(gameStart.callNumberDescription.ElementAt(gameDictionary).Value))
                    {
                        myAnswers.Add(gameStart.callNumberDescription.ElementAt(gameDictionary).Value);
                        x++;
                    }
                    else
                    {

                    }
                }
                else
                {
                    x++;

                }


            }


            myAnswers = gameStart.shuffleList(myAnswers);

            for (int j = 0; j < myAnswers.Count; j++)
            {
                listBoxB.Items.Add(myAnswers[j]);
            }
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            // Takes the user back to the main menu
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        // Gives the user a hint on how to play
        private void Hint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Match the colums with each other by selecting an item from call Numbers and from Description and clicking the 'Match' button, Once you've matched all the numbers click 'Check Answers' to see if you got it correct.", "Hint", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }


}



