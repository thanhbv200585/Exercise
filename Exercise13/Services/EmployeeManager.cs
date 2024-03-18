using Exercise13.Entities;

namespace Exercise13.Services
{
    internal class EmployeeManager
    {
        public List<Employee> Employees { get; }

        public EmployeeManager() 
        {
            Employees = new List<Employee>(); 
        }

        public void Run()
        {
            int choice = 0;
            while (choice != 8)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("1. Add employee.");
                Console.WriteLine("2. Search employee by ID.");
                Console.WriteLine("3. Show all Experience.");
                Console.WriteLine("4. Show all Fresher");
                Console.WriteLine("5. Show all Intern");
                Console.WriteLine("6. Update Employee");
                Console.WriteLine("7. Delete Employee by ID");
                Console.WriteLine("8. Exit");
                Console.WriteLine("==================================");
                Console.Write(">> ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        int EmployeeType = CheckUtils.InputInt("Enter employee type (Experience - 0, Fresher - 1, Intern - 2): ");
                        AddEmployee(EmployeeType);
                        break;
                    case 2:
                        int searchID = CheckUtils.InputInt("Enter ID: ");
                        Employee res = SearchEmployeeById(searchID);
                        if (res != null)
                        {
                            res.ShowInfo();
                        }
                        else
                        {
                            Console.WriteLine("Not found employee with ID =  " + searchID);
                        }
                        break;
                    case 3:
                        FindAllExperience().ForEach(e => e.ShowInfo());
                        break;
                    case 4:
                        FindAllFresher().ForEach(e => e.ShowInfo());
                        break;
                    case 5: 
                        FindAllIntern().ForEach(e => e.ShowInfo());
                        break;
                    case 6:
                        int updateID = CheckUtils.InputInt("Enter ID: ");
                        UpdateEmployee(updateID);
                        break;
                    case 7:
                        int deleteID = CheckUtils.InputInt("Enter ID: ");
                        DeleteEmployeeById(deleteID);
                        break;
                    case 8:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please try again!");
                        break;

                }
            }
            
        }
        public void AddEmployee(int EmployeeType)
        {
            int ID = CheckUtils.InputInt("Enter ID: ");
            string Fullname = CheckUtils.InputString("Enter fullname: ");
            DateTime BirthDay = CheckUtils.InputDateTime("Enter DoB (yyyy-MM-dd): ");
            string Phone = CheckUtils.InputPhone();
            string Email = CheckUtils.InputMail();
            switch (EmployeeType)
            {
                case (int)EmployeeTypes.Experience:
                    int ExpInYear = CheckUtils.InputInt("Enter YoE: ");
                    string ProSkill = CheckUtils.InputString("Enter proskills: ");
                    Employees.Add(new Experience(ID, Fullname, BirthDay, Phone, Email, EmployeeType, ExpInYear, ProSkill));
                    Employee.Employee_count++;
                    break;
                case (int)EmployeeTypes.Fresher:
                    DateTime GraduationDate = CheckUtils.InputDateTime("Enter Graduation Date: ");
                    string GraduationRank = CheckUtils.InputString("Enter Graduation Rank: ");
                    string Education = CheckUtils.InputString("Enter education: ");
                    Employees.Add(new Fresher(ID, Fullname, BirthDay, Phone, Email, EmployeeType, GraduationDate, GraduationRank, Education));
                    Employee.Employee_count++;
                    break;
                case (int)EmployeeTypes.Intern:
                    string Major = CheckUtils.InputString("Enter major: ");
                    string Semester = CheckUtils.InputString("Enter semester: ");
                    string UniversityName = CheckUtils.InputString("Enter university name: ");
                    Employees.Add(new Intern(ID, Fullname, BirthDay, Phone, Email, EmployeeType, Major, Semester, UniversityName));
                    Employee.Employee_count++;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        public Employee SearchEmployeeById(int ID)
        {
            return Employees.Find(x => x.ID == ID);
        }
        public void DeleteEmployeeById(int ID)
        {
            if(Employees.Remove(SearchEmployeeById(ID)))
            {
                Console.WriteLine("Delete successfully");
            }
            else
            {
                Console.WriteLine("Not found employee with ID = " + ID);
            } 

        }

        private static void UpdateMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("1. Change current infomartion.");
            Console.WriteLine("2. Change the employee type.");
            Console.WriteLine("3. Exit");
            Console.WriteLine("==================================");
        }
        public void UpdateEmployee(int employeeId)
        {
            Employee employee = SearchEmployeeById(employeeId);
            if (employee == null)
            {
                Console.WriteLine("Not found employee with ID = " + employeeId);
                return;
            }
            UpdateMenu();
            int choice = CheckUtils.InputInt(">>");
            switch (choice)
            {
                case 1:
                    UpdateCurrentInfo(employee);
                    break;
                case 2:
                    ChangeEmployeeType(employee);
                    break;
                case 3: 
                    Console.WriteLine("Exit!");
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }

        }

        private void UpdateCurrentInfo(Employee employee)
        {
            Console.WriteLine("Reenter new information");
            employee.Fullname = CheckUtils.InputString(string.Format("Enter fullname ({0}): ",employee.Fullname));
            employee.BirthDay = CheckUtils.InputDateTime(string.Format("Enter DoB (yyyy-MM-dd) ({0}): ", employee.BirthDay));
            employee.Phone = CheckUtils.InputPhone();
            employee.Email = CheckUtils.InputMail();
            switch (employee.EmployeeType)
            {
                case EmployeeTypes.Experience:
                    ((Experience)employee).ExpInYear = CheckUtils.InputInt(string.Format("Enter YoE ({0}): ", ((Experience)employee).ExpInYear));
                    ((Experience)employee).ProSkill = CheckUtils.InputString(string.Format("Enter proskills ({0}): ", ((Experience)employee).ProSkill));
                    break;
                case EmployeeTypes.Fresher:
                    ((Fresher)employee).GraduationDate = CheckUtils.InputDateTime(string.Format("Enter Graduation Date ({0}): ", ((Fresher)employee).GraduationDate));
                    ((Fresher)employee).GraduationRank = CheckUtils.InputString(string.Format("Enter Graduation Rank ({0}): ", ((Fresher)employee).GraduationRank));
                    ((Fresher)employee).Education = CheckUtils.InputString(string.Format("Enter education ({0}): ", ((Fresher)employee).Education));
                    break;
                case EmployeeTypes.Intern:
                    ((Intern)employee).Major = CheckUtils.InputString(string.Format("Enter major ({0}): ", ((Intern)employee).Major));
                    ((Intern)employee).Semester = CheckUtils.InputString(string.Format("Enter semester ({0}): ", ((Intern)employee).Semester));
                    ((Intern)employee).UniversityName = CheckUtils.InputString(string.Format("Enter university name ({0}): ", ((Intern)employee).UniversityName));
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
        

        private void ChangeEmployeeType(Employee employee)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Which type do you change to?");
            Console.WriteLine("0 - Experience");
            Console.WriteLine("1 - Fresher");
            Console.WriteLine("2 - Intern");
            Console.WriteLine("==================================");

            int choice = CheckUtils.InputInt(">>");
            if (choice == (int)employee.EmployeeType ) 
            {
                Console.WriteLine("Employee " + employee.ID + " is already " + employee.EmployeeType);
                return;
            }

            if (choice < 0 && choice > 2)
            {
                Console.WriteLine("Invalid Input!");
            }

            AddEmployee(choice);
            Employees.Remove(employee);
        }

        public List<Employee> FindAllIntern()
        {
            return Employees.FindAll(e => e.GetType() == typeof(Intern));
        }

        public List<Employee> FindAllFresher()
        {
            return Employees.FindAll(e => e.GetType() == typeof(Fresher));
        }

        public List<Employee> FindAllExperience()
        {
            return Employees.FindAll(e => e.GetType() == typeof(Experience));
        }

    }
}
