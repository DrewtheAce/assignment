
        Console.WriteLine("Student Results Processing System");
Console.WriteLine("hello");

        int choice;

        string[] name = new string[3];
        int[] age = new int[3];
        string[] id = new string[3];
        string[] program = new string[3];
        string[] level = new string[3];

        int[] totalScore = new int[3];
        double[] average = new double[3];
        string[] grade = new string[3];
        string[] status = new string[3];

        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Enter Student Results");
            Console.WriteLine("2. View Student Report");
            Console.WriteLine("3. Exit");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                for (int i = 0; i <3; i++)
                {
                    Console.WriteLine("\nEnter details for Student " + (i + 1));

                    Console.WriteLine("What is your name?");
                    name[i] = Console.ReadLine();

                    Console.WriteLine("How old are you?");
                    age[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Your Student ID:");
                    id[i] = Console.ReadLine();

                    Console.WriteLine("What do you study?");
                    program[i] = Console.ReadLine();

                    Console.WriteLine("Which level are you in?");
                    level[i] = Console.ReadLine();

                    int score1, score2, score3, score4, score5;

            do
            {
                Console.WriteLine("Database Systems:");
                score1 = int.Parse(Console.ReadLine());
                    if (score1 < 0 || score1 > 100) {
                    Console.WriteLine("Invalid score. Score must be between 0 and 100");
                }
                    } while (score1 < 0 || score1 > 100);

            do
            {
                Console.WriteLine("Programming with C#:");
                score2 = int.Parse(Console.ReadLine());
                    if (score2 < 0 || score2 > 100) {
                    Console.WriteLine("Invalid score. Score must be between 0 and 100");
                }
                    } while (score2 < 0 || score2 > 100);

            do
            {
                Console.WriteLine("Computer Networks:");
                score3 = int.Parse(Console.ReadLine());
                    if (score3 < 0 || score3 > 100) {
                    Console.WriteLine("Invalid score. Score must be between 0 and 100");
                }
                    } while (score3 < 0 || score3 > 100);

            do
            {

                Console.WriteLine("Web Development:");
                score4 = int.Parse(Console.ReadLine());
                    if (score4 < 0 || score4 > 100) {
                    Console.WriteLine("Invalid score. Score must be between 0 and 100");
                }
                    } while (score4 < 0 || score4 > 100);

            do
            {
                Console.WriteLine("Mathematics for Computing:");
                score5 = int.Parse(Console.ReadLine());
                if (score5 < 0 || score5 > 100) {
                    Console.WriteLine("Invalid score. Score must be between 0 and 100");
                }
                {
                            Console.WriteLine("Enter a")
                        }
                    } while (score5 < 0 || score5 > 100);

                    totalScore[i] = score1 + score2 + score3 + score4 + score5;
                    average[i] = totalScore[i] / 5.0;

                    if (average[i] >= 80)
                        grade[i] = "A";
                    else if (average[i] >= 70)
                        grade[i] = "B";
                    else if (average[i] >= 60)
                        grade[i] = "C";
                    else if (average[i] >= 50)
                        grade[i] = "D";
                    else
                        grade[i] = "F";

                    status[i] = average[i] >= 50 ? "Passed" : "Failed";
                }

                Console.WriteLine("\nAll 3 students have been recorded successfully.");
            }

            else if (choice == 2)
            {
                Console.WriteLine("\n===== STUDENT REPORT =====");

                for (int i = 0; i <3; i++)
                {
                    Console.WriteLine("\nStudent " + (i + 1));
                    Console.WriteLine("Name: " + name[i]);
                    Console.WriteLine("Age: " + age[i]);
                    Console.WriteLine("Student ID: " + id[i]);
                    Console.WriteLine("Programme: " + program[i]);
                    Console.WriteLine("Level: " + level[i]);
                    Console.WriteLine("Total Score: " + totalScore[i]);
                    Console.WriteLine("Average Score: " + average[i]);
                    Console.WriteLine("Grade: " + grade[i]);
                    Console.WriteLine("Status: " + status[i]);
                }
            }

            else if (choice == 3)
            {
                Console.WriteLine("Thank you for using the Student Results Processing System.");
            }

            else
            {
                Console.WriteLine("Invalid option.");
            }

        } while (choice != 3);
