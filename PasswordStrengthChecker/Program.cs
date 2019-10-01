using PasswordStrengthChecker.Builder;
using PasswordStrengthChecker.ChainOfResponsibility;
using PasswordStrengthChecker.TestStrategy;
using System;

namespace PasswordStrengthChecker
{
    class Program
    {
       
        static void Main(string[] args)
        {
           

           Console.WriteLine("Enter the password:");
            string password = Console.ReadLine();

            /// <summary>
            /// Strategy Design Pattern.
            /// </summary>  
            /// 
            Console.WriteLine("                               ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("----Strategy Design Pattern: --");
            Console.WriteLine("-------------------------------");
           
            Context context;
            context = new Context(new StrengthLevel1());
            context.ContextInterface(password);

            context = new Context(new StrengthLevel2());
            context.ContextInterface(password);

            context = new Context(new StrengthLevel3());
            context.ContextInterface(password);


            /// <summary>
            /// Chain of responsibility Design Pattern.
            /// </summary>  
            Console.WriteLine("                                       ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Chain of responsibility Design Pattern:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("----------------Level 1----------------");
           
            // Setup Chain of Responsibility
            Requirement r1 = new RequirementMinLength();
            Requirement r2 = new RequirementContainsDigit();
            Requirement r3 = new RequirementConstainSpecialCharacter();
            Requirement r4 = new RequirementIsNotOnTheListForbiddenPasswords();
           

            r1.SetRequirement(r2);
            r2.SetRequirement(r3);
            r3.SetRequirement(r4);

            r1.HandleRequest(password);


            /// <summary>
            /// Builder Design Pattern.
            /// </summary>  
            /// 
            Console.WriteLine("                                       ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("--------Builder Design Pattern---------");
            Console.WriteLine("---------------------------------------");
            
            Director director = new Director();
            BuilderPass builder1 = new BuilderLevel1();
            BuilderPass builder2= new BuilderLevel2();
            BuilderPass builder3= new BuilderLevel3();

            //Level 1
            Console.WriteLine("----------------Level 1----------------");
             director.Construct(builder1, password);
            Level level1 = builder1.GetResult();
            level1.Show();

            //Level2
            Console.WriteLine("----------------Level 2----------------");
            director.Construct(builder2, password);
            Level level2 = builder2.GetResult();
            level2.Show();

            //Level3 
            Console.WriteLine("----------------Level 3----------------");
            director.Construct(builder3, password);
            Level level3 = builder3.GetResult();
            level3.Show();



            Console.ReadKey();
        }
    }
    
}
