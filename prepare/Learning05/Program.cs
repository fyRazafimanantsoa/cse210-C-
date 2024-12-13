public class Program
{
    public static void Main(string[] args)
    {
        
        Assignment simpleAssignment = new Assignment("Samuel Bennett", "Multiplication");
        System.Console.WriteLine(simpleAssignment.GetSummary());
        
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        System.Console.WriteLine(mathAssignment.GetSummary()); 
        System.Console.WriteLine(mathAssignment.GetHomeworkList()); 
        
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        System.Console.WriteLine(writingAssignment.GetSummary()); 
        System.Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}