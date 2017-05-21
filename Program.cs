using System;

namespace homework2
{
    public class Account
    {
        public string  userName{get;set;}
    }
    public class Saving : Account 
    {
        public decimal rate{get;set;}
        public bool active{get;set;}
        public decimal ammount{get;set;}
        public static void createAccount(Saving instance){
            instance.active=true;
            Console.WriteLine("Saving account created successfully ("+instance+")");
            Console.WriteLine(instance.active);    
        }
        public void removeAccount(){
            this.active=false;
            Console.WriteLine("Saving account removed successfully");
            Console.WriteLine(this.active);
        }
        public void MakeDeposit(){
            Console.WriteLine("You deposited");
        }
        public void WithdrawFunds(){
            Console.WriteLine("You withdaw");
        }
        public Saving()
        {
            this.rate= 1.5M;
            this.active=false;
            this.ammount=0M;
        }
    }
    public class Checking : Account 
    {
        public decimal rate{get;set;}
        public bool active{get;set;}
        public decimal ammount{get;set;}
        public void createAccount(){
            this.active=true;
            Console.WriteLine("Checking account created successfully");
            Console.WriteLine(this.active);    
        }
        public void removeAccount(){
            this.active=false;
            Console.WriteLine("Checking account removed successfully");
            Console.WriteLine(this.active);
        }
        public void MakeDeposit(){
            Console.WriteLine("You deposited");
        }
        public void WithdrawFunds(){
            Console.WriteLine("You withdaw");
        }
        public Checking()
        {
            this.rate= 0.0M;
            this.active=false;
            this.ammount=0M;
        }
    }
    class Program
    {
        //User1 accounts
            public Saving saving1 = new Saving();
            public Checking checking1 = new Checking();
            //User2 accounts
            public Saving saving2 = new Saving();
            public Checking checking2 = new Checking();
            //User3 accounts
            public Saving saving3 = new Saving();
            public Checking checking3 = new Checking();

        public static void Main()
        {
            bool displayMenu=true;
            while(displayMenu){
            displayMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            Console.Clear();
            //Prompting the user to select a user            
            Console.WriteLine("Please choose a user");
            Console.WriteLine("1) User1");
            Console.WriteLine("2) User2");
            Console.WriteLine("3) User3");
            //Storing the number of the user selected in a string
            string userSelected = Console.ReadLine();           

            //Prompting the user to select an opperation
            Console.WriteLine("What would you like to do today User {0}?", userSelected);
            Console.WriteLine("1) Create an account");
            Console.WriteLine("2) View details of an account");
            Console.WriteLine("3) Make a deposit");
            Console.WriteLine("4) Withdraw funds");
            Console.WriteLine("5) See the banks capital");      
            Console.WriteLine("6) Remove an account");         
            Console.WriteLine("7) Quit");            
            string input = Console.ReadLine();
            if(input == "1"){
                //Prompting the user to select a type of account to create and saving it to type
                Console.WriteLine("Please select a type of account");
                Console.WriteLine("1/) Saving");
                Console.WriteLine("2/) Checking");
                string type = Console.ReadLine();
                if(type=="1"){
                    Saving.createAccount(ref saving1);
                    
                    Console.ReadLine();
                }
                else if(type=="2"){
                    string typeSelected = "checking";
                    // createAccount(userSelected, typeSelected);
                }
                return true;
            }
            else if (input == "2"){
                Console.WriteLine("Show report");
                return true;
            }
            else if (input == "3"){
                // MakeDeposit();
                return true;
            }
            else if (input == "4"){
                // WithdrawFunds();
                return true;
            }
            else if (input == "5"){
                Console.WriteLine("See the banks Capital");     
                return true;
            }
            else if (input == "6"){
                // removeAccount();     
                return true;
            }
            else if (input == "7"){
                return false;
            }
            else{
                return false;
            }
        }
        // private static void createAccount(string userSelected, string type)
        // {
        //     Console.Clear();
        //     if(userSelected =="1"){
        //         if(type=="saving"){
        //             saving1.active=true;
        //         }
        //          else if(type=="checking"){
                
        //     }
        //     }
            


            
        }
    //     private static void removeAccount()
    //     {
    //         Console.Clear();

            
    //     }
    //     private static void MakeDeposit()
    //     {
            
    //         Console.Clear();
            

            
    //     }
    //     private static void WithdrawFunds()
    //     {
    //         Console.Clear();
            
    //     }
    // }
}
