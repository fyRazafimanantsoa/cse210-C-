namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) 
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string Serialize()
        {
            return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
        }

        public override void Deserialize(string data)
        {
            var parts = data.Split(',');
            _name = parts[1];
            _description = parts[2];
            _points = int.Parse(parts[3]);
            _isComplete = bool.Parse(parts[4]);
        }
    }
}
