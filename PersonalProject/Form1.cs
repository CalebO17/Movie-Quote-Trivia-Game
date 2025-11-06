using System;
using System.Media;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PersonalProject
{


    public partial class Form1 : Form
    {
        //Creating lists that will represent each table from MYSQL
        List<Celebrity> celebrities = new List<Celebrity>();
        List<Film> movies = new List<Film>();
        List<Quote> quotes = new List<Quote>();
        List<Hint> hints = new List<Hint>();
        List<PictureBox> redXList = new List<PictureBox>();
        SoundPlayer soundPlayer = new SoundPlayer();
        Random randomNumb = new Random();

        //Global Variables
        int chosenQuoteIndex = 0;
        int score = 0;
        int incorrectGuesses = 0;

        //Runs when exe file runs
        public Form1()
        {
            InitializeComponent();
            loadTitleScreen(); // Loads title screen

        }

        //Runs when start game button is clicked
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            loadData(); //Loads data from sql database
            startGame(); //Loads start game function
        }

        //Function for loading data from database into array
        void loadData()
        {
            redXList = new List<PictureBox> { redX1, redX2, redX3 };
            //Declaring strings to represent each environment variable to connect to SQl database
            string server = Environment.GetEnvironmentVariable("DB_SERVER");
            string port = Environment.GetEnvironmentVariable("DB_PORT");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string database = Environment.GetEnvironmentVariable("DB_NAME");

            //Connecting to SQL database
            string connectionString = $"server={server};port={port};user={user};password={password};database={database}";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try //Attempting to connect to database, providing an error message if it fails
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database!");
                }
                catch (Exception failure)
                {
                    Console.WriteLine("Error connecting to mysql database");
                };
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Connectiong to the database using the connectionString
            {
                connection.Open();
                //Running queries and taking that data to put into objects and adding to the lists
                string actorQuery = "SELECT * FROM Actors ORDER BY actor_id";
                string quoteQuery = "SELECT q.quote_line, a.actor_name, m.movie_name\r\nFROM Quotes q\r\nLEFT JOIN Actors a on q.actor_id = a.actor_id\r\nLEFT JOIN Movies m on q.movie_id = m.movie_id";
                string movieQuery = "SELECT * FROM Movies ORDER BY movie_id";
                string hintQuery = "SELECT h.hint, a.actor_name\r\nFROM Hints h\r\nLEFT JOIN Actors a ON a.actor_id = h.actor_id";
                using (MySqlCommand command = new MySqlCommand(actorQuery, connection)) // Using actorQuery
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    //Adding celebrity data to objects and adding to list
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString("actor_name");
                        DateTime birthday = dataReader.GetDateTime("birthday");
                        string resourceName = dataReader["actor_image_directory"].ToString();

                        // Load the image dynamically from project resources
                        Image actorImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);

                        // Create the celebrity object with that image
                        Celebrity celeb = new Celebrity(name, birthday, actorImage);
                        celebrities.Add(celeb);
                    }
                }
                using (MySqlCommand command = new MySqlCommand(movieQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        //Adding movie data to objects and adding to list
                        string name = dataReader.GetString("movie_name");
                        DateTime releaseDate = dataReader.GetDateTime("movie_release_date");
                        string director = dataReader.GetString("movie_director");
                        string description = dataReader.GetString("movie_description");
                        string resourceName = dataReader["movie_image_directory"].ToString();

                        // Load the image dynamically from project resources
                        Image movieImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);


                        Film movie = new Film(name, description, director, releaseDate, movieImage);
                        movies.Add(movie);
                    }
                }


                using (MySqlCommand command = new MySqlCommand(quoteQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    //Adding quote data to objects and adding to list
                    while (dataReader.Read())
                    {
                        Quote quote = new Quote();
                        string quoteLine = dataReader.GetString("quote_line");
                        string quoteCelebName = dataReader.GetString("actor_name");
                        string quoteMovieName = dataReader.GetString("movie_name");
                        //Matching quote data with data from the other tables
                        foreach (Celebrity celeb in celebrities)
                        {
                            if (celeb.Name == quoteCelebName) // If the celeb is the same celeb as in the quote, then add that celeb to the quote object
                            {
                                quote.celebrity = celeb;
                            }
                        }
                        foreach (Film movie in movies)
                        {
                            if (movie.name == quoteMovieName) // If the film is the same as the film in the quote then add the film to the quote object
                            {
                                quote.film = movie;
                            }
                        }
                        quote.movieQuote = quoteLine; 
                        quotes.Add(quote); // Add quote to quotes list
                    }

                }

                using (MySqlCommand command = new MySqlCommand(hintQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    //Adding hint data to objects and adding to list
                    while (dataReader.Read())
                    {
                        Hint hint = new Hint();
                        string hintTxt = dataReader.GetString("hint");
                        string hintCeleb = dataReader.GetString("actor_name");
                        //Matching quote data with data from the other tables
                        foreach (Celebrity celeb in celebrities)
                        {
                            if (celeb.Name == hintCeleb) // If celeb matches celeb in the hint, add that celeb to the hint object
                            {
                                hint.celebrity = celeb;
                                hint.hint = hintTxt;
                            }
                        }
                        hints.Add(hint); // Add hint to the hints list
                    }

                }
            }
        }

        //Function for adjusting visibility for starting game

        void startGame()
        {
            startGameBtn.Visible = false;
            hintPbx.Visible = true;
            quoteTxtBox1.Visible = true;
            celebLbl1.Visible = true;
            celebLbl2.Visible = true;
            celebLbl3.Visible = true;
            celebPbx1.Visible = true;
            celebPbx2.Visible = true;
            celebPbx3.Visible = true;
            skipPbx.Visible = true;
            scoreLbl.Visible = true;
            scoreNumbLbl.Visible = true;
            startRound();
        }

        //Function for adjusting visibility for starting round and adding logic
        void startRound()
        {
            choose1Btn.Visible = true;
            choose2Btn.Visible = true;
            choose3Btn.Visible = true;
            celebLbl1.Tag = null;
            celebLbl2.Tag = null;
            celebLbl3.Tag = null;

            chosenQuoteIndex = randomNumb.Next(quotes.Count); // Choosing quote by having a random number as the index value of the quotes list
            Quote chosenQuote = quotes[chosenQuoteIndex]; // Creating quote object for the chosen quote
            List<Celebrity> otherCelebrities = new List<Celebrity>(); // Creating celebrities list of celebrities that are NOT the chosen quote celebrities

            foreach (Celebrity celeb in celebrities) // Creating a list of celebrities that are incorrect answers
            {
                if (chosenQuote.celebrity != celeb)
                {
                    otherCelebrities.Add(celeb);
                }
            }
            Celebrity randomCeleb1 = otherCelebrities[randomNumb.Next(otherCelebrities.Count)]; // Coming up with random celebrities to display next to the correct one
            otherCelebrities.Remove(randomCeleb1); // Removing that celebrity after they are chosen, so that they do not appear twice
            Celebrity randomCeleb2 = otherCelebrities[randomNumb.Next(otherCelebrities.Count)];
            otherCelebrities.Remove(randomCeleb2);

            List<Celebrity> round = new List<Celebrity> { chosenQuote.celebrity, randomCeleb1, randomCeleb2 }; // Creating a list of all three celebs that will be displayed this round
            round = round.OrderBy(x => randomNumb.Next()).ToList(); // Randomizing the celebrities for this round

            quoteTxtBox1.Text = quotes[chosenQuoteIndex].movieQuote.ToString(); // Filling the quote textbox with the chosen quote


            assignTextboxes(0, round[0], round[0] == chosenQuote.celebrity); // Assigning the chosen celebrities to the images and textboxes
            assignTextboxes(1, round[1], round[1] == chosenQuote.celebrity); // Checking for true or false by seeing if the chosen celebrity matches the celebrity being assigned to the location
            assignTextboxes(2, round[2], round[2] == chosenQuote.celebrity);




        }

        // Function for assigning each celebrity to their location in the game and assigning the correct answer with a tag
        void assignTextboxes(int celebLocation, Celebrity celeb, bool correctAnswer)
        {
            // Using a switch statement to assign each celebrity to their location and give them a "correct" tag if they are the right answer
            switch (celebLocation)
            {
                case 0:
                    celebLbl1.Text = celeb.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl1.Tag = "Correct";
                    }
                    celebPbx1.Image = celeb.image;
                    break;
                case 1:
                    celebLbl2.Text = celeb.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl2.Tag = "Correct";
                    }
                    celebPbx2.Image = celeb.image;
                    break;
                case 2:
                    celebLbl3.Text = celeb.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl3.Tag = "Correct";
                    }
                    celebPbx3.Image = celeb.image;

                    break;
            }
        }

        // Function for adding a red X if the answer is incorrect and incrementing number of wrong guesses
        void wrongAnswer()
        {
            incorrectGuesses++;
            if (incorrectGuesses < 4)
            {
                redXList[incorrectGuesses - 1].Visible = true;
            }
        }


        void guessTheMovie(Quote chosenQuote)
        {
            MessageBox.Show("You got it correct, but can you guess the movie for an extra point?");

            Random randomNumb = new Random();

            List<Film> otherMovies = new List<Film>();

            foreach (Film movie in movies)
            {
                if (chosenQuote.film != movie)
                {
                    otherMovies.Add(movie);
                }
            }
            Film randomMovie1 = otherMovies[randomNumb.Next(otherMovies.Count)];
            otherMovies.Remove(randomMovie1);
            Film randomMovie2 = otherMovies[randomNumb.Next(otherMovies.Count)];
            otherMovies.Remove(randomMovie2);

            List<Film> round = new List<Film> { chosenQuote.film, randomMovie1, randomMovie2 };
            round = round.OrderBy(x => randomNumb.Next()).ToList();

            quoteTxtBox1.Text = quotes[chosenQuoteIndex].movieQuote.ToString();


            assignMovieTextboxes(0, round[0], round[0] == chosenQuote.film);
            assignMovieTextboxes(1, round[1], round[1] == chosenQuote.film);
            assignMovieTextboxes(2, round[2], round[2] == chosenQuote.film);

        }


        void assignMovieTextboxes(int movieLocation, Film movie, bool correctAnswer)
        {

            switch (movieLocation)
            {
                case 0:
                    celebLbl1.Text = movie.name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl1.Tag = "Correct";
                    }
                    else
                    {
                        celebLbl1.Tag = null;
                    }
                    celebPbx1.Image = movie.image;
                    break;
                case 1:
                    celebLbl2.Text = movie.name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl2.Tag = "Correct";
                    }
                    else
                    {
                        celebLbl2.Tag = null;
                    }
                    celebPbx2.Image = movie.image;
                    break;
                case 2:
                    celebLbl3.Text = movie.name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl3.Tag = "Correct";
                    }
                    else
                    {
                        celebLbl3.Tag = null;
                    }
                    celebPbx3.Image = movie.image;

                    break;
            }
        }

        void chooseButtonClick(Label lbl, bool mode)
        {

            if (lbl.Tag == null)
            {
                MessageBox.Show("Incorrect!");
            }
            else
            {
                MessageBox.Show("Correct!");
                score++;
                scoreNumbLbl.Text = score.ToString();
            }
            quotes.RemoveAt(chosenQuoteIndex);
            if (incorrectGuesses == 3)
            {
                MessageBox.Show("You lose!");
            }
            else if (score == 10)
            {
                MessageBox.Show("You win!");
            }
            if(mode)
            {
                guessTheMovie(quotes[chosenQuoteIndex]);
            }
            else
            {
                startRound();
            }

        }
        private void skipPbx_Click(object sender, EventArgs e)
        {
            if (score < 9)
            {
                addToScore();
                skipPbx.Visible = false;
                startRound();
            }
            else
            {
                MessageBox.Show("You cannot use the skip powerup when you're at 9/10!");
            }
        }

        void addToScore()
        {
            score++;
            scoreNumbLbl.Text = (score.ToString() + "/10");
        }

        private void hintPbx_Click(object sender, EventArgs e)
        {
            hintPbx.Visible = false;
            List<Hint> chosenCelebHint = new List<Hint>();
            foreach (Hint hint in hints)
            {
                if (hint.celebrity.Name == quotes[chosenQuoteIndex].celebrity.Name)
                {
                    chosenCelebHint.Add(hint);
                }
            }
            chosenCelebHint = chosenCelebHint.OrderBy(x => randomNumb.Next()).ToList();
            MessageBox.Show("Hint: " + chosenCelebHint[0].hint.ToString());

        }

        void loadTitleScreen()
        {
            startGameBtn.Visible = true;
            celebPbx1.Visible = false;
            celebPbx2.Visible = false;
            celebPbx3.Visible = false;
            celebLbl1.Visible = false;
            celebLbl2.Visible = false;
            celebLbl3.Visible = false;
            choose1Btn.Visible = false;
            choose2Btn.Visible = false;
            choose3Btn.Visible = false;
            scoreLbl.Visible = false;
            scoreNumbLbl.Visible = false;
            redX1.Visible = false;
            redX2.Visible = false;
            redX3.Visible = false;


        }

        private void choose1Btn_Click(object sender, EventArgs e)
        {

        }

        private void choose2Btn_Click(object sender, EventArgs e)
        {

        }

        private void choose3Btn_Click(object sender, EventArgs e)
        {

        }
    }

}
