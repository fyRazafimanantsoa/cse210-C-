namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) 
            : base(name, description, points) { }

        public override void RecordEvent()
        {
            
        }

        public override bool IsComplete()
        {
            return false; 
        }

        public override string Serialize()
        {
            return $"EternalGoal,{_name},{_description},{_points}";
        }

        public override void Deserialize(string data)
        {
            var parts = data.Split(',');
            _name = parts[1];
            _description = parts[2];
            _points = int.Parse(parts[3]);
        }
    }
}
