DROP SCHEMA IF EXISTS Movies;

CREATE SCHEMA Movies;
USE Movies;

CREATE TABLE Actors (
actor_id INT AUTO_INCREMENT PRIMARY KEY,
actor_name VARCHAR(50),
birthday DATE,
actor_image_directory VARCHAR(75)
);

CREATE TABLE Movies (
movie_id INT AUTO_INCREMENT PRIMARY KEY,
movie_name VARCHAR(50),
movie_release_date DATE,
movie_director VARCHAR(50),
movie_description VARCHAR(300),
movie_image_directory VARCHAR(50)
);

CREATE TABLE Quotes (
quote_id INT AUTO_INCREMENT PRIMARY KEY,
quote_line VARCHAR (200),
actor_id INT, 
FOREIGN KEY (actor_id) REFERENCES Actors(actor_id),
movie_id INT,
FOREIGN KEY (movie_id) REFERENCES Movies(movie_id)
);

CREATE TABLE Hints (
hint_id INt AUTO_INCREMENT PRIMARY KEY,
actor_id INT,
FOREIGN KEY (actor_id) REFERENCES Actors(actor_id),
hint VARCHAR(250)
);

INSERT INTO Actors (actor_name, birthday, actor_image_directory) VALUES
('Samuel L. Jackson', '1948-12-21', 'SamJackson'),
('Anya Taylor-Joy', '1996-04-16', 'AnyaTaylorJoy'),
('Andrew Garfield', '1983-08-20', 'AndrewGarfield'),
('Robert Redford', '1936-08-18', 'RobertRedford'),
('Jennifer Lawrence', '1990-08-15', 'JenniferLawrence'),
('Elizabeth Olsen', '1989-02-16', 'ElizabethOlsen'),
('Tom Hanks', '1956-07-09', 'TomHanks'),
('Zendaya Coleman', '1996-09-01', 'Zendaya'),
('Hunter Schafer', '1998-12-31', 'HunterSchafer');

INSERT INTO Movies (movie_name, movie_release_date, movie_director, movie_description, movie_image_directory) VALUES
('Pulp Fiction', '1994-10-14', 'Quentin Tarantino', 'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.', 'PulpFiction'),
('The Long Kiss Goodnight', '1996-10-07', 'Renny Harlin', 'Government agents come after an amnesiac woman, who gradually remembers her past.', 'TheLongKissGoodnight'),
('The Menu', '2022-11-18', 'Mark Mylod', 'A young couple travels to a remote island to eat at an exclusive restaurant where the chef has prepared a lavish menu, with some shocking surprises.', 'TheMenu'),
('The Social Network', '2010-10-01', 'David Fincher','As Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, he is sued by the twins who claimed he stole their idea and by the co-founder who was later squeezed out of the business.', 'TheSocialNetwork'),
('Butch Cassidy and the Sundance Kid', '1969-09-24', 'George Roy Hill', 'In 1890s Wyoming, Butch Cassidy and The Sundance Kid lead a band of outlaws. When a train robbery goes wrong, they find themselves on the run with a posse hard on their heels.', 'ButchCassidyAndTheSundanceKid'),
('Don''t Look Up', '2021-12-10', 'Adam McKay', 'Two low-level astronomers must go on a giant media tour to warn humankind of an approaching comet that will destroy planet Earth.', 'DontLookUp'),
('Wind River', '2017-08-04', 'Taylor Sheridan', 'An FBI agent teams with a town''s veteran game tracker to investigate a murder that occurred on a Native American reservation.', 'WindRiver'),
('Forrest Gump', '1994-06-06', 'Robert Zemeckis', 'The history of the United States from the 1950s to the 70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.', 'ForrestGump'),
('Dune', '2021-10-22', 'Denis Villeneuve', 'Paul Atreides arrives on Arrakis after his father accepts the stewardship of the dangerous planet. However, chaos ensues after a betrayal as forces clash to control melange, a precious resource.', 'Dune'),
('Cuckoo', '2024-08-29', 'Tilman Singer', 'A 17-year-old is forced to move with her family to a resort where things are not what they seem.', 'Cuckoo');


INSERT INTO Quotes (quote_line, actor_id, movie_id) VALUES
('Mmm, This Is A Tasty Burger!', 1, 1),
('Other charcter: Were you always this stupid, or did you take lessons? _________: I took lessons.', 1,2),
('Now that... is a cheeseburger.', 2, 3),
('You better lawyer up, because I\'m not coming back for 30%, I\'m coming back for EVERYTHING.', 3, 4),
('You just keep thinking, Butch. That\'s what you\'re good at', 4, 5),
('I\'m not on a diet. I\'m just crying five times a day', 5, 6),
('How far do you think someone could run barefoot out here?', 6, 7),
('Stupid is as stupid does', 7, 8),
('My planet Arrakis is so beautiful when the sun is low. Rolling over the sands. You can see spice in the air', 8, 9),
('That\'s a very weird way to put it!', 9, 10);

INSERT INTO Hints (actor_id, hint) VALUES
(1, 'This person was an usher at Martin Luther King\'s funeral'),
(1, 'This person is known to actively enjoy watching their own movies'),
(1, 'This person has a clause in their movie contracts that states they are required easy access to golf courses'),
(1, 'This actor/actress is known for their frequent use of the F bomb'),
(1, 'This actor/actress is close friends with Simon Pegg'),
(2, 'This actor/actress was discovered as a model whilst walking their dog'),
(2, 'This person is a fluent Spanish speaker who learned English by reading Harry Potter'),
(2, 'This actor/actress had their first lead role in a Robert Eggers film'),
(2, 'This person is an insomniac'),
(2, 'This person has recieved many accolades including a Golden Globe award in 2020'),
(3, 'This person is known for their chemistry and flirtations with someone who takes people on chicken shop dates'),
(3, 'This person played a superhero'),
(3, 'This person is close friends with Robert Pattinson and Matt Smith'),
(3, 'This actor/actress does not participate in social media'),
(3, 'This persons father is a swimmming coach'),
(4, 'This actor/actress passed away in 2025'),
(4, 'This person dislikes watching his own films'),
(4, 'This actor/actress was considered for a prominent role in the Godfather'),
(4, 'This persons daughter, Shauna, was in a relationship someone who was then murdered on August 1, 1983. The prime suspect has been on the run since 1986 over theft charges.'),
(4, 'This person was once voted the 30th greatest movie star of all time by Entertainment Weekly'),
(5, 'This person once dated an actor who played Lex Luthor'),
(5, 'This actor/actress auditioned for a prominent role in Twilight but lost'),
(5, 'This actor/actress was the second person to play a prominent Marvel character in live action'),
(5, 'This person once had to eat a raw fish for one of their movies'),
(5, 'This person is most well known for playing a character named K______'),
(6, 'This person has two famous sisters'),
(6, 'This actor/actresses favorite film growing up was Tremors'),
(6, 'This person auditioned for a prominent role in Michael Bay\'s TMNT movies, but lost out'),
(6, 'This actor/actress\' middle name is Chase because their parents want them to chase after their siblings'),
(6, 'This person was almost a lead in the new Star Wars trilogy but had scheduling conflicts'),
(7, 'This actor/actress attended Princess Diana\'s funeral'),
(7, 'This person is good friends with Bruce Springsteen'),
(7, 'This person stars in Caleb O\'Haras favorite movie of all time'),
(7, 'This person sold popcorn and peanuts as a teenager'),
(7, 'This person gained 55 pounds and then lost it for a role in a 2000 movie'),
(8, 'This actor/actress is close friends with Hunter Schafer'),
(8, 'This person was in a Kidz Bop music video'),
(8, 'This person was offered a prominent role in a Marvel movie but said no'),
(8, 'This actor/actress is a big fan of Law&Order SVU'),
(8, 'Both of this persons parents are teachers'),
(9, 'This persons first acting role was in a popular HBO television series'),
(9, 'This person studied art in University'),
(9, 'This actor/actress was in prominent headlines in 2016 for their activism'),
(9, 'This person was heavily fancast as a popular video game character, but lost the role to someone else'),
(9, 'This actor/actress was born in New Jersey');


SELECT h.hint, a.actor_name
FROM Hints h
LEFT JOIN Actors a ON a.actor_id = h.actor_id






