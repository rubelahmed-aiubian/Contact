using System;
namespace Co
{
    public class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber; 
        private char gender;

        //empty constructor
        public Contact()
        {

        }

        //valued constructor

        public Contact(string p_name, string p_id, int p_age, string p_num, char p_gen)
        {
            Name = p_name;
            Id = p_id;
            Age = p_age;
            Number = p_num;
            Gen = p_gen;
        }

        //properties

        public string Name
        { 
            get
            {
                return personName;
            }
            set
            {
                personName = value;
            }
        }

        public string Id
        { 
            get
            {
                return personId;
            }
            set
            {
                personId = value;
            }
        }

        public int Age
        { 
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Number
        { 
            get
            {
                return mobileNumber;
            }
            set
            {
                mobileNumber = value;
            }
        }

        public char Gen
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine("\n------------------------Person Information-------------------\n");
            Console.WriteLine("Person Name: "+Name+"\nPerson Id: "+Id+ "\nPerson Mobile Number: "+Number);
            Console.WriteLine("Person Age: {0}",Age);
            Console.WriteLine("Gender: {0}",Gen);
        }

        public void DetectMobileOperator()
        {
            if(Number.Length != 11)
            {
                Console.WriteLine("Mobile Number Should Be 11 Digit.");
            }
            else
            {
                char tmp = Number[2];

                if(tmp.Equals('7'))
                {
                    Console.WriteLine("Mobile Operator: Grameenphone");
                }
                else if(tmp.Equals('3'))
                {
                    Console.WriteLine("Mobile Operator: Skitto");
                }
                else if(tmp.Equals('4'))
                {
                    Console.WriteLine("Mobile Operator: Banglalink");
                }
                else if(tmp.Equals('5'))
                {
                    Console.WriteLine("Mobile Operator: TeliTalk");
                }
                else if(tmp.Equals('6'))
                {
                    Console.WriteLine("Mobile Operator: Airtel");
                }
                else if(tmp.Equals('8'))
                {
                    Console.WriteLine("Mobile Operator: Robi");
                }
                else if(tmp.Equals('1'))
                {
                    Console.WriteLine("Mobile Operator: Citycell");
                }
                else
                {
                    Console.WriteLine("Enter A Valid Mobile Number");
                }
            }

            Console.WriteLine("\n------------------------End Program-------------------\n");
        }

        
        

    }
}