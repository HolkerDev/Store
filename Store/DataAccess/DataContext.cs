using System;
using System.Collections.Generic;
using System.Linq;
using Store.Data;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess
{
    /// <summary>
    /// DataContex
    /// </summary>
    class DataContext
    {
        //static List<Movie> movies = new List<Movie>();
        //static List<Game> games = new List<Game>();
        //static List<Album> albums = new List<Album>();
        static StoreContext context = new StoreContext();
        public static StoreContext Context
        {
            get { return context; }
        }
        /// <summary>
        /// GetGameList
        /// </summary>
        /// <returns>List</returns>
        /// <remarks>Metoda zwraca listę produktów zapisanych w bazie danych</remarks>
        public static List<Movie> GetMovieList()
        {
            return context.Movies.ToList();
        }
        public static List<Game> GetGameList()
        {
            return context.Games.ToList();
        }
        public static List<Album> GetAlbumList()
        {
            return context.Albums.ToList();
        }
        public static bool AddOrEditMovie(Movie value)
        {
            if (value.MovieId == 0)
            {
                value.MovieId = context.Movies.Count() > 0 ? context.Movies.Max(x => x.MovieId) + 1 : 1;
                context.Movies.Add(value);
            }
            else
            {
                Movie movie = context.Movies.FirstOrDefault(x => x.MovieId == value.MovieId);
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
            context.SaveChanges();
            return true;
        }
        public static bool AddOrEditGame(Game value)
        {
            if (value.GameId == 0)
            {
                value.GameId = context.Games.Count() > 0 ? context.Games.Max(x => x.GameId) + 1 : 1;
                context.Games.Add(value);
            }
            else
            {
                Game game = context.Games.FirstOrDefault(x => x.GameId == value.GameId);
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
            context.SaveChanges();
            return true;
        }
        public static bool AddOrEditAlbum(Album value)
        {
            if (value.AlbumId == 0)
            {
                value.AlbumId = context.Albums.Count() > 0 ? context.Albums.Max(x => x.AlbumId) + 1 : 1;
                context.Albums.Add(value);
            }
            else
            {
                Album album = context.Albums.FirstOrDefault(x => x.AlbumId == value.AlbumId);
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
            context.SaveChanges();
            return true;

        }
        public static List<Transaction> GetTransactionList()
        {
            return context.Transactions.ToList();
        }
        public static bool AddOrEditTransaction(Transaction value)
        {
            if (value.TransactionId == 0)
            {
                value.TransactionId = context.Transactions.Count() > 0 ? context.Transactions.Max(x => x.TransactionId) + 1 : 1;
                context.Transactions.Add(value);
            }
            else
            {
                Transaction trans = context.Transactions.FirstOrDefault(x => x.TransactionId == value.TransactionId);
                if(trans != null)
                {
                    trans.Amount = value.Amount;
                    trans.Price = value.Price;
                    trans.AlbumData = value.AlbumData;
                    trans.MovieData = value.MovieData;
                    trans.GameData = value.GameData;
                }
            }
            context.SaveChanges();
            return true;
        }
    }
}
