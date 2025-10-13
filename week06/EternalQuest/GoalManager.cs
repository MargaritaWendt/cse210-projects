public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nGoal Names:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("Enter target number of times: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }


    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("\nEnter the number of the goal you completed: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            bool wasComplete = _goals[index].IsComplete();
            
            _goals[index].RecordEvent();

            _score += _goals[index].GetPoints();

            if (_goals[index].GetPoints() > 0 && _goals[index] is ChecklistGoal)
            {
                ChecklistGoal checklist = (ChecklistGoal)_goals[index];
                if (!wasComplete && checklist.IsComplete())
                {
                    _score += checklist.GetBonus();
                }
            }

            Console.WriteLine("Score updated. You now have " + _score + " points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            _goals.Clear();
            _score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("SimpleGoal:"))
                {
                    string[] parts = line.Substring(11).Split(',');
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (isComplete) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (line.StartsWith("EternalGoal:"))
                {
                    string[] parts = line.Substring(12).Split(',');
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);

                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (line.StartsWith("ChecklistGoal:"))
                {
                    string[] parts = line.Substring(14).Split(',');
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int bonus = int.Parse(parts[3]);
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++) goal.RecordEvent();
                    _goals.Add(goal);
                }
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }


}