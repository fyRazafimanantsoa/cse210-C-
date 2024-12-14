using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        public List<Goal> _goals = new List<Goal>();
        public int _score;

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordEvent(int goalIndex)
        {
            if (goalIndex < 0 || goalIndex >= _goals.Count)
            {
                Console.WriteLine("Invalid goal index.");
                return;
            }

            var goal = _goals[goalIndex];
            goal.RecordEvent();
            int pointsToAdd = goal._points; 

// Check if the goal is complete.
if (goal.IsComplete())
{
    // If the goal is a ChecklistGoal, add the bonus points.
    if (goal is ChecklistGoal checklistGoal)
    {
        pointsToAdd += checklistGoal._bonusPoints; 
    }
}

// Add the calculated points to the score.
_score += pointsToAdd;

        }

        public void DisplayGoals()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                var goal = _goals[i];
                Console.WriteLine($"{i + 1}. {goal.GetDetailsString()} - {(goal.IsComplete() ? "[X]" : "[ ]")}");
            }
        }
                public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.Serialize());
                }
            }
        }

        public void LoadGoals(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    Goal goal = parts[0] switch
                    {
                        "SimpleGoal" => new SimpleGoal("", "", 0),
                        "EternalGoal" => new EternalGoal("", "", 0),
                        "ChecklistGoal" => new ChecklistGoal("", "", 0, 0, 0),
                        _ => null
                    };

                    if (goal != null)
                    {
                        goal.Deserialize(line);
                        _goals.Add(goal);
                    }
                }
            }
        }

        public int GetScore()
        {
            return _score;
        }
    }
}


