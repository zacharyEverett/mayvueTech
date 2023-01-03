using System;
namespace MayvueTech.Models
{
	public class Movie
	{
		private string title;
		private string description;
		private string releaseYear;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string ReleaseYear { get => releaseYear; set => releaseYear = value; }
    }
}

