using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Society society = new Society();
            


            Console.WriteLine("Student Club Management System");
            Console.WriteLine("\n----------------------------\n");

            Console.WriteLine("1. Register a new society");
            Console.WriteLine("2. Allocate funding to Socities ");
            Console.WriteLine("3. Register an event for  a Society");
            Console.WriteLine("4. Display Society Funding Information");
            Console.WriteLine("5. Display events for a Society ");
            Console.WriteLine("6. Exit   \n");
            Console.WriteLine("enter from these options : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered  : "+ a+"\n");

            if (a!=1 && a != 2 && a != 3 && a != 4 && a != 5 && a != 6 )
            {
                Console.WriteLine("invalid input ");
            }
            else if (a == 1)
            {
               StudentClub club = new StudentClub();
                club.registerSociety();
                club.displaysocities();
            }
            else if (a == 2)
            {
                StudentClub obj = new StudentClub();

                obj.FundSociety();
            }
            else if (a == 3)
            {
                StudentClub club = new StudentClub();
                club.registerSociety();
               
            }
            else if (a == 4)
            {

                StudentClub obj = new StudentClub();
                Console.WriteLine("The funds are ");
                obj.FundSociety();

            }
            else if (a == 5)
            {
                StudentClub club = new StudentClub();
                club.registerSociety();
                club.displaysocities();
            }
            else if (a == 6)
            {
                Console.WriteLine("Exiting....");
            }


        }
    }
}

public class Clubrole
{
    private string name;
    private string role;
    private string contactinfo;

    public void setname(string a)
    {
        name = a;

    }
    public string getname()
    {
        return name;

    }




};
public class Society
{
    private string name;
    private double Contact;


    public  void  setname(string n)
    {
        this.name = n;
     
    }
 public string getname()
    {
        return name;

    }
    public void setcontact(int a)
    {
        this.Contact = a;


    }
    public double getcontact()
    {
        return Contact;


    }

    public void Addactivity()
    {
        Console.WriteLine("\nenter the activity : ");

        string d=Convert.ToString(Console.ReadLine());
        Console.WriteLine("you entered : "+d+"\nYour activity is entered ");

    }
    public void  listEvents()
    {
        Console.WriteLine("\nenter the events : ");

        string d1 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("you entered : " + d1+"\nYour events is entered ");


    }

};


public class Funded_Society : Society
{
    private double funding_amount;

    public void setFund(double a)
    {
        funding_amount = a;

    }
    public double getFund()
    {
       return funding_amount;

    }



};
public class nonFunded_Society : Society
{
    public Society Society { get; set; }


};




public class StudentClub{
    private double budget;
    public Clubrole  clubrole ;
    private string president;
    private string vicepresident;
    private string generalsecrety;
    private string financesecrety;
    public void FundSociety()
    {
        Funded_Society obj= new Funded_Society();


        Console.WriteLine("\nenter the funding amount :");
        obj.setFund(12);
        double fund=Convert.ToDouble(Console.ReadLine());
       
        obj.getFund();
        Console.WriteLine("the funding amount is entered ");

    }
    public void dispenseFunds()
    {



    }
    public void registerSociety()
    {
        Society society = new Society();
        Console.WriteLine("enter the name : ");
        society.setname(Console.ReadLine());
        society.getname();
        Console.WriteLine("\nenter the contact : ");
        double v = Convert.ToInt32(Console.ReadLine());

        society.setcontact(1);
        society.getname();

        society.Addactivity();
        society.listEvents();


    }
    public void displaysocities()
    {
      Console.WriteLine("\nthe events for a society are " );
        Society society=new Society();
        society.listEvents();

    }

};
