﻿using System;
using MoviesDataLayer.Models;

namespace MoviesDataLayer
{
    public class EFMoviesDBFirst
    {
        public Movie GetMovieById(int movieId) 
        { 
            using (MoviesContext db = new MoviesContext())
            {
                var movie = db.Movies
                    .SingleOrDefault(m => m.MovieId == movieId);
                return movie;
            }
        }

        public List<Movie> GetAllMovies()
        {
            using (MoviesContext db = new MoviesContext())
            {
                var movies = db.Movies.ToList();
                return movies;
            }
        }

    }
}