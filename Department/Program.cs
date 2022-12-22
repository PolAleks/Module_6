namespace Department
{
    internal class Program
    {
        class Company
        {
            public string Type;
            public string Name;

            public Company()
            {
                Type = "Неизвестная компания";
            }

            public Company(string type)
            {
                this.Type = type;
            }

        }

        class Department
        {
            public Company company;
            public City city;

            
            public Department(Company company, City city)
            {
                company = company ?? new Company("Банк");
                city = city ?? new City("Санкт-Петербург");
            }
        }

        class City
        {
            public string Name;

            public City()
            {
               
            }
            public City(string name)
            {
                Name = name;
            }
        }
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
            Console.WriteLine($"У банка {department.company.Type} есть отделение в Санкт-Петербурге");
        }
        static Department GetCurrentDepartment()
        {
            return new Department(new Company(), new City());
        }
    }
}