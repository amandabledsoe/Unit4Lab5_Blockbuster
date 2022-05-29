using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab5_Blockbuster
{
    public enum Category
    {
        Action,
        Comedy,
        Drama,
        Horror,
        Romance
    }
    public abstract class Movie
    {
        public string? Title { get; set; }
        public Category Category { get; set; }
        public int RunTime { get; set; }
        public List<string>? Scenes { get; set; }
        public Movie()
        {

        }

        public Movie(string title, Category category, int runTime, List<string> scenes)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runTime;
            this.Scenes = scenes.ToList();
        }

        protected Movie(string title, int runTime, Category category)
        {
            Title = title;
            RunTime = runTime;
            Category = category;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Run Time: {RunTime}");
            Console.WriteLine($"Category: {Category}");
        }

        public void PrintScenes(List<string> scenes)
        {
            Console.WriteLine("The list of scenes in this movie are: ");
            foreach (var item in scenes)
            {
                Console.WriteLine($"{item.IndexOf(item)}. {item}");
            }
        }

        public abstract void Play();
    }
}
