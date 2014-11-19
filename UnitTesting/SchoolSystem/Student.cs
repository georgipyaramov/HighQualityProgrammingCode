namespace SchoolSystem
{
    using System;
    using System.Linq;

    public class Student : IEquatable<Student>
    {
        private uint id;

        private string name;

        public Student(uint id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public uint Id
        {
            get
            {
                return this.id;
            }

            protected set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The value for 'Name' can not contain null, empty string or only white spaces.");
                }

                this.name = value;
            }
        }

        public bool Equals(Student other)
        {
            if (this.Id == other.Id)
            {
                return true;
            }

            return false;
        }
    }
}
