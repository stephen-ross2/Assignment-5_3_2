namespace Assignment_5_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {                       
            Console.WriteLine("Enter the number of steps: ");
            int numberOfSteps = int.Parse(Console.ReadLine());
                       
            int waysToClimb = ClimbStairs(numberOfSteps);
                        
            Console.WriteLine($"The number of distinct ways to climb {numberOfSteps} steps is: {waysToClimb}");
        }
              
        public static int ClimbStairs(int n)
        {
           
            if (n <= 1)
            {
                return 1; 
            }
                       
            int previousStep1 = 1; 
            int previousStep2 = 1; 
                      
            for (int i = 2; i <= n; i++)
            {
                int currentStep = previousStep1 + previousStep2; 
                previousStep2 = previousStep1;              
                previousStep1 = currentStep;            
            }

            return previousStep1; 
        }
    }
}
   
