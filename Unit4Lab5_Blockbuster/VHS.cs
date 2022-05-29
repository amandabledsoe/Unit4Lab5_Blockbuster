using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab5_Blockbuster
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; }

        public VHS(string Title, int RunTime, Category Category, List<string> Scenes, int currentScene)
            : base(Title, Category, RunTime, Scenes)
        {
            this.CurrentScene = currentScene;
        }

        public override void Play()
        {  
            CurrentScene++;
        }
        public void Rewind()
        {
            CurrentScene = 0;
        }
    }
}
