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
        public void createAccount(){
            this.active=true;
            Console.WriteLine("Saving account created successfully: Active = {0}.",this.active);
            Console.ReadLine();    
        }
        public void removeAccount(){
            Console.Clear();
            this.active=false;
            Console.WriteLine("Saving account deleted successfully: Active = {0}.",this.active);
            Console.ReadLine();    
        }
        public void MakeDeposit(int ammount){
            Console.Clear();            
            this.ammount=+ ammount;
            Console.WriteLine("You deposited: $"+this.ammount);
            Console.ReadLine();                
        }
        public void WithdrawFunds(int ammount){
            Console.Clear();            
            if(ammount <this.ammount){
            this.ammount= this.ammount -ammount;
            Console.WriteLine("You withdrawed: $"+ammount+" and your remainder is: $"+this.ammount);
            Console.ReadLine();
            }
            else{
                Console.WriteLine("Sorry the ammount you entered is bigger than the available funds that you have in this account");
            } 
        }
        public Saving()
        {
            this.rate= 0.015M;
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
            Console.WriteLine("Checking account created successfully: Active = {0}.",this.active);
            Console.ReadLine();    
        }
        public void removeAccount(){
            Console.Clear();
            this.active=false;
            Console.WriteLine("Checking account deleted successfully: Active = {0}.",this.active);
            Console.ReadLine();    
        }
        public void MakeDeposit(int ammount){
            Console.Clear();            
            this.ammount=+ ammount;
            Console.WriteLine("You deposited: $"+this.ammount);
            Console.ReadLine();                
        }
        public void WithdrawFunds(int ammount){
            Console.Clear();            
            if(ammount <this.ammount){
            this.ammount= this.ammount -ammount;
            Console.WriteLine("You withdrawed: $"+ammount+" and your remainder is: $"+this.ammount);
            Console.ReadLine();
            }
            else{
                Console.WriteLine("Sorry the ammount you entered is bigger than the available funds that you have in this account");
            } 
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
        public static void Main()
        {
            // Generating the users
            bool displayMenu=true;
            while(displayMenu){
            displayMenu = MainMenu();
            }
        }
        // The counter is just to flag the first execution of the program
        public static int counter = 0;
        // Creation of the three users, calling the constructor
        public static Saving saving1 = new Saving();
        public static Checking checking1;
        public static Saving saving2;
        public static Checking checking2;
        public static Saving saving3;
        public static Checking checking3;
        public static string userSelected = "";
        static bool MainMenu()
        {
            if(counter==0){
                saving1 = new Saving();
                checking1 = new Checking();
                //User2 accounts
                saving2 = new Saving();
                checking2 = new Checking();
                //User3 accounts
                saving3 = new Saving();
                checking3 = new Checking();

                Console.Clear();
                //Prompting the user to select a user            
                Console.WriteLine("Please choose a user");
                Console.WriteLine("1) User1");
                Console.WriteLine("2) User2");
                Console.WriteLine("3) User3");
                //Storing the number of the user selected in a string
                userSelected = Console.ReadLine();           
            }
            //Increasing the counter to trace that it's not the first time that the program is executed so it doesn't ask to select the user and so it doesn't create the instances of the users again.
            counter++;

            //Prompting the user to select an opperation
            Console.Clear();
            Console.WriteLine("Welcome to Big Bank Inc.");
            Console.WriteLine("What would you like to do today User {0}?", userSelected);
            Console.WriteLine("1) Create an account");
            Console.WriteLine("2) View details of an account");
            Console.WriteLine("3) Make a deposit");
            Console.WriteLine("4) Withdraw funds");
            Console.WriteLine("5) See the banks capital");      
            Console.WriteLine("6) Remove an account");         
            Console.WriteLine("7) Switch user");
            Console.WriteLine("8) Quit");            
            string input = Console.ReadLine();
            if(input == "1"){
                // Create account
                //Prompting the user to select a type of account to create and saving it to type
                string type = "";
                while(type !="1" && type !="2"){
                    Console.Clear();
                    Console.WriteLine("Please select a type of account");
                    Console.WriteLine("1/) Saving");
                    Console.WriteLine("2/) Checking");
                    type = Console.ReadLine();
                }
                if(userSelected == "1" && type == "1"){
                    if(saving1.active){
                        Console.WriteLine("You already have this type of account created");
                        }
                    else{
                        saving1.createAccount();
                    }                    
                }
                else if(userSelected == "1" && type == "2"){
                    if(checking1.active){
                        Console.WriteLine("You already have this type of account created");
                        }
                    else{
                    checking1.createAccount();
                    }                    
                }
                else if(userSelected == "2" && type == "1"){
                    if(saving2.active){
                        Console.WriteLine("You already have this type of account created");
                        }
                    else{
                        saving2.createAccount();
                    }                    
                }
                else if(userSelected == "2" && type == "2"){
                    if(checking2.active){
                        Console.WriteLine("You already have this type of account created");
                        }
                    else{
                    checking2.createAccount();
                    }                    
                }
                else if(userSelected == "3" && type == "1"){
                    if(saving3.active){
                        Console.WriteLine("You already have this type of account created");
                        }
                    else{
                    saving3.createAccount();
                    }                    
                }
                else if(userSelected == "3" && type == "2"){
                    if(checking3.active){
                        Console.WriteLine("You already have this type of account created");
                        }
                    else{
                    checking3.createAccount();
                    }                    
                }
                else{
                    Console.WriteLine("Please enter a valid selection");
                }
                return true;
            }
            else if (input == "2"){
                //View Report
                string type = "";
                while(type !="1" && type !="2"){
                    Console.Clear();                    
                    Console.WriteLine("Please select a type of account");
                    Console.WriteLine("1/) Saving");
                    Console.WriteLine("2/) Checking");
                    type = Console.ReadLine();
                }
                Console.Clear();
                if(userSelected == "1" && type == "1"){
                    if(saving1.active){
                        Console.WriteLine("You have\t{0,8:c} in your account and the interest rate is \t{1,8:p}",saving1.ammount, saving1.rate);
                        Console.ReadLine();
                    }
                    else{
                        Console.WriteLine("I am sorry but that account is not active");
                    }
                }
                else if(userSelected == "1" && type == "2"){
                    if(checking1.active){
                        Console.WriteLine("You have\t{0,8:c}  in your account and the interest rate is \t{1,8:p}",checking1.ammount, checking1.rate);
                        Console.ReadLine();
                    }
                    else{
                        Console.WriteLine("I am sorry but that account is not active");
                    }
                                        
                }
                else if(userSelected == "2" && type == "1"){
                    if(saving2.active){
                        Console.WriteLine("You have\t{0,8:c}  in your account and the interest rate is \t{1,8:p}",saving2.ammount, saving2.rate);
                        Console.ReadLine();
                    }
                    else{
                        Console.WriteLine("I am sorry but that account is not active");                    
                    }
                }
                else if(userSelected == "2" && type == "2"){
                    if(checking2.active){
                        Console.WriteLine("You have\t{0,8:c}  in your account and the interest rate is \t{1,8:p}",checking2.ammount, checking2.rate);
                        Console.ReadLine();
                    }
                    else{
                        Console.WriteLine("I am sorry but that account is not active");
                    }
                }
                else if(userSelected == "3" && type == "1"){
                    if(saving3.active){
                        Console.WriteLine("You have\t{0,8:c}  in your account and the interest rate is \t{1,8:p}",saving3.ammount, saving3.rate);
                        Console.ReadLine();
                    }
                    else{
                        Console.WriteLine("I am sorry but that account is not active");
                    }
                }
                else if(userSelected == "3" && type == "2"){
                    if(checking3.active){
                        Console.WriteLine("You have\t{0,8:c}  in your account and the interest rate is \t{1,8:p}",checking3.ammount, checking3.rate);
                        Console.ReadLine();
                    }
                    else{
                        Console.WriteLine("I am sorry but that account is not active");
                    }
                }
                return true;
            }
            else if (input == "3"){
                // MakeDeposit;
                string type = "";
                while(type !="1" && type !="2"){
                    Console.Clear();                    
                    Console.WriteLine("Please select a type of account");
                    Console.WriteLine("1/) Saving");
                    Console.WriteLine("2/) Checking");
                    type = Console.ReadLine();
                }
                int ammount = 0;
                while (ammount<=0)
                {
                Console.WriteLine("Please enter the amount to deposit (Integer > 0)");
                ammount = int.Parse(Console.ReadLine());;    
                }
                if(userSelected == "1" && type == "1"){
                    saving1.MakeDeposit(ammount);                    
                }
                else if(userSelected == "1" && type == "2"){
                    checking1.MakeDeposit(ammount);                    
                }
                else if(userSelected == "2" && type == "1"){
                    saving2.MakeDeposit(ammount);                    
                }
                else if(userSelected == "2" && type == "2"){
                    checking2.MakeDeposit(ammount);                    
                }
                else if(userSelected == "3" && type == "1"){
                    saving3.MakeDeposit(ammount);                    
                }
                else if(userSelected == "3" && type == "2"){
                    checking3.MakeDeposit(ammount);                    
                }
                return true;
            }
            else if (input == "4"){
                // WithdrawFunds();
               string type = "";
                while(type !="1" && type !="2"){
                    Console.Clear();                    
                    Console.WriteLine("Please select a type of account");
                    Console.WriteLine("1/) Saving");
                    Console.WriteLine("2/) Checking");
                    type = Console.ReadLine();
                }
                int ammount = 0;
                while (ammount<=0)
                {
                Console.WriteLine("Please enter the amount to withdraw (Integer > 0)");
                ammount = int.Parse(Console.ReadLine());;    
                }
                if(userSelected == "1" && type == "1"){
                    saving1.WithdrawFunds(ammount);                    
                }
                else if(userSelected == "1" && type == "2"){
                    checking1.WithdrawFunds(ammount);                    
                }
                else if(userSelected == "2" && type == "1"){
                    saving2.WithdrawFunds(ammount);                    
                }
                else if(userSelected == "2" && type == "2"){
                    checking2.WithdrawFunds(ammount);                    
                }
                else if(userSelected == "3" && type == "1"){
                    saving3.WithdrawFunds(ammount);                    
                }
                else if(userSelected == "3" && type == "2"){
                    checking3.WithdrawFunds(ammount);                    
                }
                return true;
            }
            else if (input == "5"){
                decimal total=0;
                if(saving1.active){
                    total= total +saving1.ammount;
                }
                if(checking1.active){
                    total= total + checking1.ammount;
                }
                if(saving2.active){
                    total= total + saving2.ammount;
                }
                if(checking2.active){
                    total= total + checking2.ammount;
                }
                if(saving3.active){
                    total= total + saving3.ammount;
                }
                if(checking3.active){
                    total= total + checking3.ammount;
                }
                Console.Clear();
                Console.WriteLine("The bank's Capital is:\t{0,8:c}",total);
                Console.ReadLine();                                
                return true;
            }
            else if (input == "6"){
                // removeAccount();     
                //Prompting the user to select a type of account to create and saving it to type
                string type = "";
                while(type !="1" && type !="2"){
                    Console.WriteLine("Please select a type of account");
                    Console.WriteLine("1/) Saving");
                    Console.WriteLine("2/) Checking");
                    type = Console.ReadLine();
                }
                Console.Clear();
                if(userSelected == "1" && type == "1"){
                    saving1.removeAccount();                    
                }
                else if(userSelected == "1" && type == "2"){
                    checking1.removeAccount();                    
                }
                else if(userSelected == "2" && type == "1"){
                    saving2.removeAccount();                    
                }
                else if(userSelected == "2" && type == "2"){
                    checking2.removeAccount();                    
                }
                else if(userSelected == "3" && type == "1"){
                    saving3.removeAccount();                    
                }
                else if(userSelected == "3" && type == "2"){
                    checking3.removeAccount();                    
                }
                return true;
            }
            else if (input == "7"){
            Console.Clear();
                //Prompting the user to select a user            
                Console.WriteLine("Please choose a user");
                Console.WriteLine("1) User1");
                Console.WriteLine("2) User2");
                Console.WriteLine("3) User3");
                //Storing the number of the user selected in a string
                userSelected = Console.ReadLine();
                return true;
            }
            else if (input == "8"){
                return false;
            }
            else{
                return false;
            }
        }
    }
}