namespace DelegateAssignment
{/// <summary>
/// This program describes a delegate called DelegateName
/// </summary>
    internal class Program
    {
        public delegate string DelegateName(string firstName, string lastName);
        static void Main(string[] args)
        {
            Del x = new Del();
            var likelyUsername = x.FirstName + " " + x.LastName;
            

            Delegate pred = (Del x) =>
            {
                if (x.FirstName == "James" && x.LastName == "Samson")
                {
                    return true;
                }
                else return false;
            };
            Console.WriteLine("Hello, World!");
        }
    }




        public class Del
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string UserName { get; set; }    
        }
    }

