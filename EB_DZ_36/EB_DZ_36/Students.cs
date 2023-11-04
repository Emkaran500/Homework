public class Students
{
    private string name = default;
    private string surname = default;
    private int[] marks = new int[0];

    public Students(string name, string surname)
    {
        SetName(name);
        SetSurname(surname);
    }

    private void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            this.name = "ERROR";
        else
        {
            name = name.Trim();

            for (int i = 0; i < name.Length; i++)
            {
                if (int.TryParse(name.Substring(i, 1), out int result))
                {
                    this.name = "ERROR";
                }
            }

            name.ToUpper();
            this.name = name;
        }
    }

    private void SetSurname(string surname)
    {
        if (string.IsNullOrWhiteSpace(surname))
            this.surname = "ERROR";
        else
        {
            surname = surname.Trim();

            for (int i = 0; i < surname.Length; i++)
            {
                if (int.TryParse(surname.Substring(i, 1), out int result))
                {
                    this.surname = "ERROR";
                }
            }

            surname.ToUpper();
            this.surname = surname;
        }
    }

    public string GetName() => this.name;
    public string GetSurname() => this.surname;
    public int[] GetMarks() => this.marks;
    public double GetAverageMark()
    {
        return this.marks.Average();
    }

    public void AddMark(int mark)
    {
        if (mark < 1 || mark > 12)
            return;
        else
        {
            int[] newMarksArr = new int[this.marks.Length + 1];

            newMarksArr[0] = mark;

            if (this.marks.Length > 0)
            {
                for (int i = 0; i < this.marks.Length; i++)
                {
                    newMarksArr[i + 1] = this.marks[i];
                }
            }

            this.marks = newMarksArr;
        }
    }
    public void EditMarkByIndex(int index, int mark)
    {
        if (mark < 1 || mark > 12)
            return;
        if (index < 1 || index > this.marks.Length)
            return;
        else
            this.marks[index - 1] = mark;
    }

    public void DeleteMarkByIndex(int index)
    {
        if (index < 1 || index > this.marks.Length)
            return;
        else
        {
            int[] newArr = new int[this.marks.Length - 1];

            for (int i = 0, j = 0; i < this.marks.Length; i++)
            {
                if (i != (index - 1))
                {
                    newArr[j] = this.marks[i];
                    j++;
                }
            }

            this.marks = newArr;
        }
    }

    public void ShowStudentInfo()
    {
        Console.WriteLine($"Name: {this.GetName()}");
        Console.WriteLine($"Surname: {this.GetSurname()}");
        ShowMarks();
        Console.WriteLine($"Average Mark: {GetAverageMark()}");
    }

    public void ShowStudent()
    {
        Console.WriteLine($" {this.name} {this.surname}");
    }

    public void ShowMarks()
    {
        Console.Write("Marks: ");
        for (int i = 0; i < this.GetMarks().Length; i++)
        {
            if (i == (this.GetMarks().Length - 1))
                Console.WriteLine($"{this.GetMarks()[i]}.");
            else
                Console.Write($"{this.GetMarks()[i]}, ");
        }
    }
}

public class MenuApp
{
    Students[] studentArr = new Students[0];
    int choose = default;

    public void AddStudent(string name, string surname)
    {
        Students[] newStudArr = new Students[this.studentArr.Length + 1];

        if (this.studentArr.Length == 0)
        {
            newStudArr[0] = new Students(name, surname);
        }
        else
        {
            newStudArr[this.studentArr.Length] = new Students(name, surname);
            for (int i = 0; i < this.studentArr.Length; i++)
            {
                newStudArr[i] = this.studentArr[i];
            }
        }
        
        this.studentArr = newStudArr;
    }

    public void ShowStudents()
    {
        if (this.studentArr.Length == 0)
        {
            Console.WriteLine("You don't have any students!");
            return;
        }

        for (int i = 0; i < studentArr.Length; i++)
        {
            Console.Write($"{i + 1}.");
            this.studentArr[i].ShowStudent();
        }
    }

    public void Menu()
    {
        bool exit = false;
        while (exit == false)
        {
            do
            {
                Console.WriteLine("1. Show student info (marks, average marks score, info)");
                Console.WriteLine("2. Add Mark");
                Console.WriteLine("3. Edit Mark (by index)");
                Console.WriteLine("4. Delete Mark (by index)");
                Console.WriteLine("5. Add Student");
                Console.WriteLine("6. Exit");
                choose = Convert.ToInt32(Console.ReadLine());
            } while (this.choose != 1 && this.choose != 2 && this.choose != 3 && this.choose != 4 && this.choose != 5 && this.choose != 6);

            switch (choose)
            {
                case 1:
                    if (studentArr.Length == 0)
                    {
                        Console.WriteLine("You do not have any students!");
                        break;
                    }
                    int studChoose1 = default;
                    bool correct1 = false;
                    do
                    {
                        Console.WriteLine("Choose the number of the student you want to see info of: ");
                        this.ShowStudents();

                        studChoose1 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < this.studentArr.Length; i++)
                        {
                            if (studChoose1 == (i + 1))
                                correct1 = true;
                        }
                    } while (correct1 == false);

                    this.studentArr[studChoose1 - 1].ShowStudentInfo();
                    break;
                case 2:
                    if (studentArr.Length == 0)
                    {
                        Console.WriteLine("You do not have any students!");
                        break;
                    }
                    int studChoose2 = default;
                    bool correct2 = false;
                    do
                    {
                        Console.WriteLine("Choose the student you want to add mark to: ");
                        this.ShowStudents();
                        studChoose2 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < this.studentArr.Length; i++)
                        {
                            if (studChoose2 == (i + 1))
                                correct2 = true;
                        }
                    } while (correct2 == false);

                    Console.Write("Input the mark you want to add: ");
                    this.studentArr[studChoose2 - 1].AddMark(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 3:
                    if (studentArr.Length == 0)
                    {
                        Console.WriteLine("You do not have any students!");
                        break;
                    }
                    int studChoose3 = default;
                    bool correct3 = false;
                    do
                    {
                        Console.WriteLine("Choose the student you want to edit mark of: ");
                        this.ShowStudents();
                        studChoose3 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < this.studentArr.Length; i++)
                        {
                            if (studChoose3 == (i + 1))
                                correct3 = true;
                        }
                    } while (correct3 == false);

                    int index3 = default;
                    Console.Write("Choose the index of a mark you want to edit: ");
                    this.studentArr[studChoose3 - 1].ShowMarks();
                    index3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose the mark you want to input: ");
                    this.studentArr[studChoose3 - 1].EditMarkByIndex(index3, Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    if (studentArr.Length == 0)
                    {
                        Console.WriteLine("You do not have any students!");
                        break;
                    }
                    int studChoose4 = default;
                    bool correct4 = false;
                    do
                    {
                        Console.WriteLine("Choose the number of the student you want to delete mark of: ");
                        this.ShowStudents();
                        studChoose4 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < this.studentArr.Length; i++)
                        {
                            if (studChoose4 == (i + 1))
                                correct4 = true;
                        }
                    } while (correct4 == false);
                    int index4 = default;
                    Console.Write("Choose the index of a mark you want to delete: ");
                    this.studentArr[studChoose4 - 1].ShowMarks();
                    index4 = Convert.ToInt32(Console.ReadLine());
                    this.studentArr[studChoose4 - 1].DeleteMarkByIndex(index4);
                    break;
                case 5:
                    string name5 = default;
                    string surname5 = default;
                    Console.Write("Please, input the name of the student: ");
                    name5 = Console.ReadLine();
                    Console.Write("Please, input the surname of the student: ");
                    surname5 = Console.ReadLine();
                    this.AddStudent(name5, surname5);
                    break;
                case 6:
                    System.Environment.Exit(0); //???
                    break;
            }

        }
    }
}