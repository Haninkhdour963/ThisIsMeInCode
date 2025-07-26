using System.Collections.Generic;

namespace HaneenWebApp.Models
{
    public class Haneen
    {
        public string Mood { get; private set; } = "Motivated";
        public List<string> Skills { get; set; } = new() { "C#", ".NET", "Problem Solving" };
        public List<string> Dreams { get; set; } = new() { "PHD AI", "Work Remotely", "Get DAAD Scholarship" };
        public List<string> Logs { get; private set; } = new();

        public void Try()
        {
            Logs.Add("Trying something new... again.");
            Mood = "Focused";
        }

        public void Learn()
        {
            Logs.Add("Learning from mistakes like a true developer.");
            Mood = "Curious";
        }

        public void CoffeeBreak()
        {
            Logs.Add("Refueling with Turkish coffee...");
            Mood = "Relaxed";
        }

        public void SelfPepTalk()
        {
            Logs.Add("حاولي تروّقي، إنتِ قدها!");
            Mood = "Motivated";
        }
    }
}
