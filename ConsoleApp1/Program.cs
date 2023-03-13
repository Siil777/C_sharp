//See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace RoomRepairColculator
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var name = Console.ReadLine();

            if (name.ToUpper() == "JUKU")
            {
                Console.WriteLine("go to cinema");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0 || age > 100)
                {
                    Console.WriteLine("age can not {age}", age);

                }
                if (age < 6)
                {
                    Console.WriteLine("free", age);
                }
                if (age > 6 && age < 14)
                {
                    Console.WriteLine("Children's ticket", age);
                }
                if (age > 14 && age < 66)
                {
                    Console.WriteLine("full ticket", age);
                }
                if (age > 65)
                {
                    Console.WriteLine("Discount ticket", age);

                }
            }
            else
            {
                Console.WriteLine("I am outside, go find Juku");

            }
            Console.WriteLine("input num:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input num:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("it will {2} ", num1, num2, num1 * num2);


            ////1.Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("what is your name>:?");
                var name = Console.ReadLine();


            }
            ////2.*Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala. 
            //// Küsi kasutajalt remondi tegemise soov, kui ta on positiivne, siis küsi kui
            //// palju maksab ruutmeeter ja leia põranda vahetamise hind
            Console.WriteLine("Enter the length of the room in meters");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the room in meters");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine($"the floor area of the room {area} square meters");

            Console.WriteLine("would you like to make repairs? (y/n)");
            string repairAnswer = Console.ReadLine();
            if (repairAnswer.ToLower() == "y")
            {
                Console.WriteLine("Enter the cost per square meter of the new floor:");
                double costPerSquareMeter = double.Parse(Console.ReadLine());


                double repairCost = area * costPerSquareMeter;
                Console.WriteLine($"the cost of replacing the floor is {repairCost} dollars");
            }
            else
            {
                Console.WriteLine("no repairs needed");
            }
            Console.WriteLine("press any key to exit");

            //3.Leia 30 % hinnasoodustusega hinna põhjal alghind
            //prompt the user to enter the price of an item
            Console.Write("enter the price of an item:");
            double price = double.Parse(Console.ReadLine());
            double discountPercent = 30;// the discount percentage

            double discountPrice = CalculateOriginalPrice(price, discountPercent);
            Console.WriteLine($"the discountetPrice price is {discountPrice:C}");
            Console.ReadKey();

            static double CalculateOriginalPrice(double price, double discountPercent)
            {
                // convert the discount percentage to a decimal value
                double discountDecimal = discountPercent / 100;
                // calculate the original price using the discounted price and discount percentage
                double discountPrice = price * (1 - discountDecimal);

                return discountPrice;



            }

            //4.*Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi
            //(soovitav toasoojus talvel).


            do
            {
                Console.WriteLine("what is the temperature:?");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int temperature))
                {
                    if (temperature > 18)
                    {
                        Console.WriteLine("the temperature is above 18 degree");
                    }
                    else
                    {
                        Console.WriteLine("the temperature is not above 18 degree");
                    }

                }
                else
                {
                    Console.WriteLine("invalid temperature,enter a valid temperature");
                }

            } while (true);

            //4.*Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi
            //(soovitav toasoojus talvel).

            Console.WriteLine("what is the temperature?");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int temperature))
            {
                switch (temperature > 18)
                {
                    case true:
                        Console.WriteLine("the temperature above 18");
                        break;
                    case false:
                        Console.WriteLine("the temperature is not above 18");
                        break;
                    default:
                        break;


                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            //5.Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk
            //(piirid pane ise paika)
            while (true)
            {


                Console.WriteLine("what is your height?>:");
                double height = double.Parse(Console.ReadLine());
                if (height >= 150 && height <= 170)
                {
                    Console.WriteLine("Low");
                }
                if (height >= 171 && height <= 185)
                {
                    Console.WriteLine("Middle");
                }
                if (height > 185)
                {

                    Console.WriteLine("High");
                }

                //5.Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk
                //(piirid pane ise paika) with random
                Random rnd = new Random();
                while (true)
                {
                    double height = rnd.Next(140, 210);
                    if (height >= 150 && height <= 170)
                    {
                        Console.WriteLine($" {height} Low");
                    }
                    if (height > 170 && height <= 185)
                    {
                        Console.WriteLine($" {height} Middle");
                    }
                    if (height > 185)
                    {
                        Console.WriteLine($" {height} High");
                    }
                    Console.WriteLine("press enter to continiue or type(exit)");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "exit")
                    {
                        break;
                    }
                }


                //6.Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või 
                //pikk(mitu tingimusplokki võib olla üksteise sees).
                while (true)
                {


                    Console.WriteLine("enter your height");
                    double height = double.Parse(Console.ReadLine());

                    Console.WriteLine("enter your gender");
                    string gender = Console.ReadLine();
                    if (gender.ToUpper() == "M")
                    {
                        if (height < 170)
                        {
                            Console.WriteLine("Low");
                        }
                        else if (height >= 170 && height < 180)
                        {
                            Console.WriteLine("Medium");
                        }
                        else
                        {
                            Console.WriteLine("High");
                        }


                    }
                    else if (gender.ToUpper() == "F")
                    {
                        if (height < 160)
                        {
                            Console.WriteLine("Low");
                        }
                        else if (height >= 160 && height < 170)
                        {
                            Console.WriteLine("Medium");
                        }
                        else
                        {
                            Console.WriteLine("High");
                        }

                    }
                    else
                    {
                        Console.WriteLine("invalid gender input.Please try again");
                    }


                }
                CultureInfo culture = new CultureInfo("en-US");
                //7.* Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö 
                //    hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.
                //// Define the prices of milk, roll, and bread
                double milkPrice = 2.0;
                double rollPrice = 1.0;
                double breadPrice = 1.0;

                //// Ask the customer if they want to buy milk
                Console.WriteLine("would you like to buy milk?(y/n)");
                string milkAnswer = Console.ReadLine();

                double totalCost = 0.0;

                if (milkAnswer.ToLower() == "y")
                {
                    Console.WriteLine("how many milks do you want to buy?");
                    int milkQuantity = Convert.ToInt32(Console.ReadLine());
                    totalCost += milkQuantity * milkPrice;
                    Console.WriteLine("would you like to buy anything else(y/n)");
                    string anythingElseAnswer = Console.ReadLine();
                    if (anythingElseAnswer.ToLower() == "y")
                    {
                        Console.WriteLine("do you eant to buy roll?");
                        string rollAnswer = Console.ReadLine();
                        if (rollAnswer.ToLower() == "y")
                        {
                            Console.WriteLine("how many rolls do you want?");
                            int rollQuantity = Convert.ToInt32(Console.ReadLine());

                            totalCost += rollQuantity * rollPrice;

                        }
                        else
                        {
                            totalCost += breadPrice;
                        }
                    }
                    else
                    {
                        Console.WriteLine("see you soon");
                    }
                }
                else
                {
                    Console.WriteLine("do you want to buy a bread?(y/n)");
                    string breadAnswer = Console.ReadLine();
                    if (breadAnswer.ToLower() == "y")

                    {
                        Console.WriteLine("how many?");
                        int breadQuantity = Convert.ToInt32(Console.ReadLine());
                        totalCost += breadQuantity * breadPrice;

                    }
                    else
                    {
                        Console.WriteLine("see you soon thank you");
                    }
                }
                Console.WriteLine("the totalcos is:" + totalCost.ToString("C", culture));
                Random rnd = new Random();
                //// generate random integer between 1 and 100
                int N = rnd.Next(1, 100);
                //// generate random integer between N and 100
                int M = rnd.Next(N, 100);
                //// create an array of size M-N+1
                ////M - N calculates the difference between the two integers
                ////We add 1 to account for the fact that we want to include N in the array.
                ////For example, if N is 3 and M is 7, then M -N + 1 is equal to 5, which means 
                ////we want to create an array of size 5.This array will contain the integers 
                ////3, 4, 5, 6, 7.
                int[] array = new int[M - N + 1];
                //// populate the array with integers between N and M
                for (int i = 0; i < array.Length; i++)
                {   ////N + i calculates the integer that should be placed at the current
                    ////index i in the array.
                    array[i] = N + i;
                }

                //// print the squares of the integers on the screen
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i] * array[i]);
                }
                8.* Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende
            summa, aritmeetiline keskmine ja korrutis
            1.option
            double[] numbers = new double[5];
                // ask the user for five numbers and save them in the array
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("enter number#{0}:", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                // calculate the sum of the numbers 
                double sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += numbers[i];
                }
                // calculate the arithmetic mean of the numbers 
                double mean = sum / 5;

                // calculate the product of the numbers
                double product = 1;
                for (int i = 0; i < 5; i++)
                {
                    product *= numbers[i];
                }
                // display the sum, arithmetic mean, and product of the numbers
                Console.WriteLine("Sum{0}", sum);
                Console.WriteLine("Arithmetic mean{0}", mean);
                Console.WriteLine("Product {0}", product);

                //2.option

                int[] numer = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    numer[i] = Convert.ToInt32(Console.ReadLine());

                }
                int summa = 0, multiple = 1;
                double avg;
                foreach (int item in numer)
                {
                    Console.Write("{0,5}", item);
                    summa = summa + item;
                    multiple = multiple * item;

                }
                //3    4    5    6    7
                Console.WriteLine();
                avg = summa / numer.Length;
                Console.WriteLine("summa={0}, multiple={1}, avg={2}", summa, multiple, avg);

                string userInput;
                do
                {
                    Console.WriteLine("buy elephant!");
                    userInput = Console.ReadLine();


                } while (userInput.ToUpper() != "elephant");

                Console.WriteLine("Congratulations!you finally bought the elephant ");
                Cread input with split


            //Ülesanne 1
            //Нaпишите программу, на вход которой подаётся список чисел одной строкой.Программа должна для каждого
            //    элемента этого списка вывести сумму двух его cоседей. Для элeментов списка, являющиxся крайними,
            //    одним из соседей считается элемент, находящий на противоположном конце этого списка.Например, если 
            //    на вход подаётся cписок «1 3 5 6 10», то на выход ожидается cписок «13 6 9 15 7».
            //Если на вход пришло только однo число, надо вывести его же.
            //Вывoд должен содержать одну строку с чиcлами новoго списка, разделёнными пробeлом.
            string[] input = Console.ReadLine().Split();
                //Creat new array
                int[] numbers = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    //convert string to int and store in array
                    numbers[i] = int.Parse(input[i]);



                }
                if (numbers.Length == 1)
                {

                    // if num only 1 it output
                    Console.WriteLine(numbers[0]);
                }
                int[] newNumbers = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {


                    // handle extreme left case 
                    int lefIndex = i == 0 ? numbers.Length - 1 : i - 1;
                    // handle extreme right case
                    int rightIndex = i == numbers.Length - 1 ? 0 : i + 1;
                    //add two neighbors and store them to array
                    newNumbers[i] = numbers[lefIndex] + numbers[rightIndex];
                }
                for (int i = 0; i < newNumbers.Length; i++)
                {
                    Console.Write(newNumbers[i] + " ");

                }
            //Ülesanne 2
            //Дан список из 20 случайных чисел. Переписать его элементы в новый список
            //следующим образом: сначала все четные, затем все нечетные.
            / generate 20 random numerous
                int[] num = new int[20];
                Random rand = new Random();
                for (int i = 0; i < 20; i++)
                {
                    num[i] = rand.Next(1, 99);

                }
                //separate odd and even numbers in different lists
                //The Where method is used to filter elements in the array
                //based on a condition.
                //The n => n % 2 == 0 is a lambda expression that defines the condition.
                int[] evenNum = num.Where(n => n % 2 == 0).ToArray();
                int[] oddNum = num.Where(n => n % 2 == 1).ToArray();
                //Concetrate two lists into a new list with even and folowed by odd
                int[] newNum = new int[num.Length];
                Array.Copy(evenNum, newNum, evenNum.Length);
                //0 indicates the starting index in the oddNum array from which to begin copying elements.
                Array.Copy(oddNum, 0, newNum, evenNum.Length, oddNum.Length);

                Console.WriteLine("original list");
                Console.WriteLine(string.Join(",", num));
                Console.WriteLine("new list");
                Console.WriteLine(string.Join(",", newNum));


            }
            fill food names and colories
            string[] tooted = { "Aple", "Banana", "Chicken", "Rice", "Salad" };
            double[] colorid = { 50, 85, 230, 135, 15 };
            //Ask for user necessary information to colculate daily colories intake

            Console.WriteLine("enter you wigth:");
            double wight = double.Parse(Console.ReadLine());

            Console.WriteLine("enter you height:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your gender (M/F)");
            string gender = Console.ReadLine();

            Console.WriteLine("enter your level of activity (1 = sedentery, 2 = light activity, 3 = moderate, 4 = high activity, 5 = very high)");
            int activyLevel = int.Parse(Console.ReadLine());

            //Calculate basic metabolic rate (BMR) using Harris-Benedict eqution
            double bmr;
            if (gender.ToUpper() == "M")
            {
                bmr = 66 + (13.7 * wight) + (5 * height) - (6.8 * age);

            }
            else
            {
                bmr = 655 + (9.6 * wight) + (1.8 * height) - (4.7 * age);
            }
            // Calculate daily colorite intake based on activity level
            double dailyColorieItake;
            switch (activyLevel)
            {
                case 1:
                    dailyColorieItake = bmr * 1.2;
                    break;
                case 2:
                    dailyColorieItake = bmr * 1.375;
                    break;
                case 3:
                    dailyColorieItake = bmr * 1.55;
                    break;
                case 4:
                    dailyColorieItake = bmr * 1.725;
                    break;
                case 5:
                    dailyColorieItake = bmr * 1.9;
                    break;
                default:
                    Console.WriteLine("invalid activity level");
                    return;
            }
            // display the daily colorie intake to the user
            Console.WriteLine("your daily colorire intake is:" + dailyColorieItake);

            // Calculate the amount of food a person can eat per day
            double[] foodAmounts = new double[tooted.Length];
            for (int i = 0; i < tooted.Length; i++)
            {
                double foodColories = colorid[i];
                double foodAmount = dailyColorieItake / foodColories;
                foodAmounts[i] = foodAmount;

            }
            //display the list of food and the corresponding amount that user can use per day
            Console.WriteLine("list of food you can eat per day");
            for (int i = 0; i < tooted.Length; i++)
            {
                Console.WriteLine(tooted[i] + ":" + foodAmounts[i] + " " + "gramms");

            }
            ////Ülesanne 4
            ////Составьте словарь, где перечислите часть уездов Эстонии.
            ////Ключом будет город - столица, описанием название уезда или наоборот.
            ////При помощи функций реализуйте возможности:
            ////отображение города, если вводиться название уезда и наоборот.
            ////если искомый уезд отсутствует в словаре, дайте пользователю возможность добавить его в словарь.
            ////При желании пользователя проверить знание слов из словаря, реализуйте эту возможность
            ////случайным образом появляются названия столиц / стран,
            ////после ввода соответствующего значения, сообщение о правильности или нет
            ////после окончания проверки знаний результат в %)



            string[] maakond = { "Harju-maakond", "Lääne-Viru-maakond", "Ida-Viru-maakond", "Lääne-maakond", "Rapla-maakond", "Järva-maakond", "Jõgeva-maakond", "Pärnu-maakond", "Viljandi-maakond", "Tartu-maakond", "Valga-maakond", "Põlva-maakond", "Võru-maakond", "Saare-maakond", "Hiju-maakond" };
            string[] linn = {"Tallinn", "Rakvere", "Narva", "Haapsalu", "Rapla", "Paide", "Jõgeva", "Pärnu", "Viljandi", "Tartu", "Valga", "Põlva", "Võru", "Kuressaare", "Kärdla" };
            Console.WriteLine("Enter maakond:");
            string inputMaakond = Console.ReadLine();

            //Array.IndexOf method searches for the specified element in the array

            int indexMaakond = Array.IndexOf(maakond, inputMaakond);
            if (indexMaakond >= 0)
            {
                Console.WriteLine($"The capital city of {maakond[indexMaakond]} is {linn[indexMaakond]}");
            }
            else
            {
                Console.WriteLine($"Maakond {inputMaakond} does not exist in the list. Add it:");
                // Resize method is used to increase the size of both the maakond and linn 
                // arrays by one
                Array.Resize(ref maakond, maakond.Length + 1);
                Array.Resize(ref linn, linn.Length + 1);

                maakond[maakond.Length - 1] = inputMaakond;
                Console.WriteLine($"Enter capital city for {inputMaakond}:");
                string inputCity = Console.ReadLine();
                linn[linn.Length - 1] = inputCity;

                Console.WriteLine($"Added {inputCity} as the capital city of {inputMaakond}");
            }

            Console.WriteLine("Enter city:");
            string inputCity1 = Console.ReadLine();
            int indexCity = Array.IndexOf(linn, inputCity1);
            if (indexCity >= 0)
            {
                Console.WriteLine($"This city {linn[indexCity]} is in {maakond[indexCity]}");
            }
            else
            {
                Console.WriteLine($"City {inputCity1} does not exist in the list. Add it:");
                Console.WriteLine("Enter maakond:");
                string inputMaakond1 = Console.ReadLine();
                int indexMaakond1 = Array.IndexOf(maakond, inputMaakond1);
                if (indexMaakond1 >= 0)
                {
                    Console.WriteLine($"Enter capital city for {inputMaakond1}:");
                    string inputCity2 = Console.ReadLine();
                    Array.Resize(ref linn, linn.Length + 1);
                    linn[linn.Length - 1] = inputCity2;
                    Console.WriteLine($"Added {inputCity2} as a city in {inputMaakond1}");
                }
                else
                {
                    Console.WriteLine($"Maakond {inputMaakond1} does not exist in the list. Add it:");
                    Array.Resize(ref maakond, maakond.Length + 1);



















                }
            }
        }
    }
}
