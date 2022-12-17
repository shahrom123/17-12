 class Person
    {
        public string Name;
        public string Age;
        public float Height;
        public byte Weight;

        public void Info()
        {
            Console.WriteLine(" Name: {0} \n Age: {1} \n Height: {2} \n Weight {3}", Name, Age, Height, Weight);
        }
        public void Walk()
        {
            Console.WriteLine( Name + " is walking in the park!");
        }
        public void Talk()
        {
            Console.WriteLine( Name +" will talk about 'codding' tomorrow!");
        }
        public void Eat()
        {
            Console.WriteLine("{0} is eathing something...", Name);
        }
        public void sleep()
        {
            Console.WriteLine("{0} Everyday sleeping...", Name);
        }
    }