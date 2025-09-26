CREATE SCHEMA Movies;
USE Movies;

CREATE TABLE Actors (
actor_id INT AUTO_INCREMENT PRIMARY KEY,
actor_name VARCHAR(50),
birthday DATE
);

CREATE TABLE Movies (
movie_id INT AUTO_INCREMENT PRIMARY KEY,
movie_name VARCHAR(50),
movie_release_date DATE,
movie_director VARCHAR(50),
movie_description VARCHAR(200)
);

CREATE TABLE Quotes (
quote_id INT AUTO_INCREMENT PRIMARY KEY,
quote_line VARCHAR (200),
actor_id INT, 
FOREIGN KEY (actor_id) REFERENCES Actors(actor_id),
movie_id INT,
FOREIGN KEY (movie_id) REFERENCES Movies(movie_id)
);

INSERT INTO Actors (actor_name, birthday) VALUES
('Samuel L. Jackson', '1948-12-21'),
('Anya Taylor-Joy', '1996-04-16'),
('Andrew Garfield', '1983-08-20'),
('Robert Redford', '1936-08-18'),
('Jennifer Lawrence', '1990-08-15'),
('Elizabeth Olsen', '1989-02-16'),
('Tom Hanks', '1956-07-09'),
('Zendaya Coleman', '1996-09-01'),
('Hunter Schafer', '1998-12-31');

INSERT INTO Movies (movie_name, movie_release_date, movie_director, movie_description) VALUES
('Pulp Fiction', '1994-10-14', 'Quentin Tarantino', 'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.'),
('The Long Kiss Goodnight', '1996-10-07', 'Renny Harlin', 'Government agents come after an amnesiac woman, who gradually remembers her past'),
('The Menu', '2022-11-18', 'Mark Mylod', 'A young couple travels to a remote island to eat at an exclusive restaurant where the chef has prepared a lavish menu, with some shocking surprises.'),
('The Social Network', '2010-10-01', 'David Fincher','As Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, he is sued by the twins who claimed he stole their idea and by the co-founder who was later squeezed out of the business'),
('Butch Cassidy and the Sundance Kid', '1969-09-24', 'George Roy Hill', 'In 1890s Wyoming, Butch Cassidy and The Sundance Kid lead a band of outlaws. When a train robbery goes wrong, they find themselves on the run with a posse hard on their heels..'),
('Don\'t look up', '2021-12-10', 'Adam McKay', 'Two low-level astronomers must go on a giant media tour to warn humankind of an approaching comet that will destroy planet Earth.'),
('Wind River', '2017-08-04', 'Taylor Sheridan', 'An FBI agent teams with a town\'s veteran game tracker to investigate a murder that occurred on a Native American reservation. wildlife officer helps an FBI agent investigate a murder on an American Indian reservation.'),
('Forrest Gump', '1994-06-06', 'Robert Zemeckis', 'The history of the United States from the 1950s to the 70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.'),
('Dune', '2021-10-22', 'Denis Villeneuve', 'Paul Atreides arrives on Arrakis after his father accepts the stewardship of the dangerous planet. However, chaos ensues after a betrayal as forces clash to control melange, a precious resource'),
('Cuckoo', '2024-08-29', 'Tilman Singer', 'A 17-year-old is forced to move with her family to a resort where things are not what they seem.');

INSERT INTO Quotes (quote_line, actor_id, movie_id) VALUES
('Mmm, This Is A Tasty Burger!', 1, 1),
('Charlie: Were you always this stupid, or did you take lessons? _________: I took lessons.', 1,2),
('Now that... is a cheeseburger.', 2, 3),
('You better lawyer up asshole, because I\'m not coming back for 30%, I\'m coming back for EVERYTHING.', 3, 4),
('You just keep thinking, Butch. That\'s what you\'re good at', 4, 5),
('I\'m not on a diet. I\'m just crying five times a day', 5, 6),
('How far do you think someone could run barefoot out here?', 6, 7),
('Stupid is as stupid does', 7, 8),
('My planet Arrakis is so beautiful when the sun is low. Rolling over the sands. You can see spice in the air', 8, 9),
('That\'s a very fucking weird way to put it!', 9, 10);









