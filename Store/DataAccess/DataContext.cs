using System;
using System.Collections.Generic;
using System.Linq;
using Store.Data;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess
{
    class DataContext
    {
        static List<Movie> movies = new List<Movie>();
        static List<Game> games = new List<Game>();
        static List<Album> albums = new List<Album>();
        public static List<Movie> GetMovieList()
        {
            return movies;
        }
        public static List<Game> GetGameList()
        {
            return games;
        }
        public static List<Album> GetAlbumList()
        {
            return albums;
        }
        public static bool AddOrEditMovie(Movie value)
        {
            if (value.MovieId == 0)
            {
                value.MovieId = movies.Count > 0 ? movies.Max(x => x.MovieId) + 1 : 1;
                movies.Add(value);
            }
            else
            {
                Movie movie = movies.FirstOrDefault(x => x.MovieId == value.MovieId);
                if (movie != null)
                {
                    movie.MovieName = value.MovieName;
                    movie.Price = value.Price;
                    movie.Genre = value.Genre;
                    movie.Date = value.Date;
                    movie.Author = value.Author;
                    movie.Grade = value.Grade;
                    movie.Description = value.Description;
                }
            }
            return true;
        }
        public static bool AddOrEditGame(Game value)
        {
            if (value.GameId == 0)
            {
                value.GameId = games.Count > 0 ? games.Max(x => x.GameId) + 1 : 1;
                games.Add(value);
            }
            else
            {
                Game game = games.FirstOrDefault(x => x.GameId == value.GameId);
                if (game != null)
                {
                    game.GameName = value.GameName;
                    game.Price = value.Price;
                    game.Genre = value.Genre;
                    game.Date = value.Date;
                    game.Publisher = value.Publisher;
                    game.Grade = value.Grade;
                    game.Description = value.Description;
                }
            }
            return true;
        }
        public static bool AddOrEditAlbum(Album value)
        {
            if (value.AlbumId == 0)
            {
                value.AlbumId = albums.Count > 0 ? albums.Max(x => x.AlbumId) + 1 : 1;
                albums.Add(value);
            }
            else
            {
                Album album = albums.FirstOrDefault(x => x.AlbumId == value.AlbumId);
                if (album != null)
                {
                    album.AlbumName = value.AlbumName;
                    album.Price = value.Price;
                    album.Genre = value.Genre;
                    album.Date = value.Date;
                    album.Author = value.Author;
                    album.Grade = value.Grade;
                    album.Description = value.Description;
                }
            }
            return true;

        }
    }
}
