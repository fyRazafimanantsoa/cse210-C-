namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _timesCompleted;
        private int _requiredTimes;
        public int _bonusPoints;

        public ChecklistGoal(string name, string description, int points, int requiredTimes, int bonusPoints) 
            : base(name, description, points)
        {
            _timesCompleted = 0;
            _requiredTimes = requiredTimes;
            _bonusPoints = bonusPoints;
        }

        public override void RecordEvent()
        {
            _timesCompleted++;
        }

        public override bool IsComplete()
        {
            return _timesCompleted >= _requiredTimes;
        }

        public override string Serialize()
        {
            return $"ChecklistGoal,{_name},{_description},{_points},{_timesCompleted},{_requiredTimes},{_bonusPoints}";
        }

        public override void Deserialize(string data)
        {
            var parts = data.Split(',');
            _name = parts[1];
            _description = parts[2];
            _points = int.Parse(parts[3]);
            _timesCompleted = int.Parse(parts[4]);
            _requiredTimes = int.Parse(parts[5]);
            _bonusPoints = int.Parse(parts[6]);
        }

        public override string GetDetailsString()
        {
            return base.GetDetailsString() + $" - Completed {_timesCompleted}/{_requiredTimes}";
        }
    }
}
