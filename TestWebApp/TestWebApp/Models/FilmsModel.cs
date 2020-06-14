using System;
using System.Collections.Generic;
using TestWebApp.DBLayer.Models;

namespace TestWebApp.Models
{
    public class FilmsModel
    {
        public List<Film> FilmList { get; set; } = new List<Film>();
        
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 10;
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
        public bool EnablePrevious => CurrentPage > 1;
        public bool EnableNext => CurrentPage < TotalPages;
    }
}
