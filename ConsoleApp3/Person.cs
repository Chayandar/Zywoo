

    class Person
    {
        string fio;
        int age;
        bool male;
        public Person(string f, int a, bool m)
        {
            this.fio = f;
            this.age = a;
            this.male = m;
        }
        public void Print()
        {
            Console.WriteLine(fio + " " + age + " " + male);
            if (male)
                Console.WriteLine("man");
            else
                Console.WriteLine("");
        }
    }

