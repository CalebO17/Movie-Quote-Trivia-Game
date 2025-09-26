using MySql.Data.MySqlClient;


namespace PersonalProject
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            loadData();
            
        }
    

    void loadData()
        {
            string server = Environment.GetEnvironmentVariable("DB_SERVER");
            string port = Environment.GetEnvironmentVariable("DB_PORT");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string database = Environment.GetEnvironmentVariable("DB_NAME");

            string connectionString = $"server={server};port={port};user={user};password={password};database={database}";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connected to the database!");
                }
                catch (Exception failure)
                {
                    Console.WriteLine("Error connecting to mysql database");
                };
            }
            List<Celebrity> celebrities = new List<Celebrity>();
            List<Film> movies = new List<Film>();
            List<Quote> quotes = new List<Quote>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string actorQuery = "SELECT * FROM Actors ORDER BY actor_id";
                string quoteQuery = "SELECT q.quote_line, a.actor_name, m.movie_name\r\nFROM Quotes q\r\nLEFT JOIN Actors a on q.actor_id = a.actor_id\r\nLEFT JOIN Movies m on q.movie_id = m.movie_id";
                string movieQuery = "SELECT * FROM Movies ORDER BY movie_id";
                using (MySqlCommand command = new MySqlCommand(actorQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString("actor_name");
                        DateTime birthday = dataReader.GetDateTime("birthday");
                        Celebrity celeb = new Celebrity(name, birthday);
                        celebrities.Add(celeb);
                    }
                }
                using (MySqlCommand command = new MySqlCommand(movieQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Film movie = new Film();
                        string name = dataReader.GetString("movie_name");
                        DateTime releaseDate = dataReader.GetDateTime("movie_release_date");
                        string director = dataReader.GetString("movie_director");
                        string description = dataReader.GetString("movie_description");
                        movie.Name = name;
                        movie.releaseDate = releaseDate;
                        movie.Director = director;
                        movie.Description = description;
                        movies.Add(movie);
                    }
                }


                using (MySqlCommand command = new MySqlCommand(quoteQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Quote quote = new Quote();
                        string quoteLine = dataReader.GetString("quote_line");
                        string quoteCelebName = dataReader.GetString("actor_name");
                        string quoteMovieName = dataReader.GetString("movie_name");
                        foreach (Celebrity celeb in celebrities)
                        {
                            if (celeb.Name == quoteCelebName)
                            {
                                quote.celebrity = celeb;
                            }
                        }
                        foreach (Film movie in movies)
                        {
                            if (movie.Name == quoteMovieName)
                            {
                                quote.film = movie;
                            }
                        }
                        quote.movieQuote = quoteLine;
                        quotes.Add(quote);
                    }

                    foreach (Celebrity celeb in celebrities)
                    {
                        celebrityListBox.Items.Add($"{celeb.Name} ({celeb.Birthday})");
                    }
                    foreach (Film movie in movies)
                    {
                        celebrityListBox.Items.Add($"{movie.Name} ({movie.releaseDate})");
                    }
                    foreach (Quote quote in quotes)
                    {
                        celebrityListBox.Items.Add($"{quote.movieQuote} ({quote.celebrity.Name})");
                    }
                }

            }
        }
    }
}
    


