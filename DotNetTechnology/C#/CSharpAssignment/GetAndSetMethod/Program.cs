using System;

namespace GetAndSetMethod
{
    #region First Program 

    /*
     why properties
	marking the class field public and exposing to the external world is bad, as you will not have control over what gets assigned and returned.

1. id should always be non negative number
2. name cannot be set to Null
3. if student name is missing "NO Name" should be returned
4. PassMark Should be read only 

Programming language that does not have properties use getter and setter methods to encapsulate and protect fields.

in this example we use the StId(in Id) and getId() methods to encapsulate _id class field.
an a result, we have better control on what gets assigned and returned from the _id field.
Note: Encapsulation is one of the primary pillars of OOP

         */

    /*
    class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public void SetId(int Id)
        {
            if(Id<=0)
            {
                throw new Exception ("Student Id should be gretter than zero ");
            }
            this._id = Id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new Exception("");
            }
            _name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(_name) ? "No Name" : _name;
        }

        public int GetPassMark()
        {
            return _passMark;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetId(100);
            //s.SetName("karan");
            Console.WriteLine("Student Id = {0} Student Name = {1} Pass Mark {1}",s.GetId(),s.GetName(),s.GetPassMark());

            Console.ReadKey();
        }
    }
    */
    #endregion

    #region Second Program

    /*
     in c# to encapsulate and protect fields we use properties

1. we use get and set accessors to implement properties
2. A property with both get and set accessor is a Read/Write property
3. A property with onl get accessor is a read only property
4. A property with only set accessor is a write only property

note: the advantage of properties over traditional Get() and set() methods is that, you can access them as if they were public fields

     */

    /*
     class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id should be gretter than zero ");
                }
                this._id = value;
            }
            get
            {
                return _id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(Name))
                {
                    throw new Exception("");
                }
                _name = value;
            }
            get
            {
                return string.IsNullOrEmpty(_name) ? "No Name" : _name;
            }
        }

        public int PassMark
        {
            get
            {
                return _passMark;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 100;
            s.Name = "karan";
            //s.PassMark = 36; // ERROR
            Console.WriteLine("Student Id = {0} Student Name = {1} Pass Mark {2}", s.Id, s.Name, s.PassMark);

            Console.ReadKey();
        }
    }
    */
    #endregion

    #region Final program

    /*
Auto Implemented Properties

if there is no additional logic in the property accessors, then we can make use of auto-implemented properties introduced in C# 3.0.
auto-implenented properties reduce the amount of code that we have to write.
when you use auto-implemented properties, the complier create a private, anonymous field that can only be accessed through the property's get and set accessors.

*/

    class Student
    {
        // if you not any condition on id or name then use this method
        public int Id { get; set; }
        public string Name { get; set; }
        public int PassMark { get; } = 35;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 100;
            s.Name = "Karan mehta";

            Console.WriteLine("Student Id = {0} \nStudent Name = {1} \nPass Mark = {2}", s.Id, s.Name, s.PassMark);

            Console.ReadKey();
        }
    }
    #endregion
}