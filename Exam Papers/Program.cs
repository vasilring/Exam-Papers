//// Exam Papers

////---------------------------------------------------------------------------------------------

//Console.ReadLine() - четене от конзолата

//Console.WriteLine() -писане на конзолата, принтиране

//.Parse - преобразуване на променлива от тип стринг към числов тип данни

//int number = int.Parse(Console.ReadLine());

//long.Parse()
//byte.Parse()

////---------------------------------------------------------------------------------------------

//.ToString() - метод, който може да преобразува всичко в стринг

//int number = 4;

//string result = number.ToString();

////в този случай ще принтира отново 4, но то явече няма да е число, а просто текст

//Console.WriteLine(result);

////---------------------------------------------------------------------------------------------

//.Math()


//int number = Math.Max(5, 10); // връща по-голямото число
//int number = Math.Min(5, 10); //връща по-малкото число
//double number = Math.Abs(-4.7); //връща положително число ако е подадено негативно
//double number = Math.Round(9.11); //връща най-близкото цяло число 
//double number = Math.Floor(9.11); //закръгля до най-близкото цяло число, като закръгля  надолу
//double number = Math.Ceiling(9.11); //връща най-близкото цяло число, като закръгля

////---------------------------------------------------------------------------------------------

//// Getting specific number of digits after decimal point:

//double num = 1.00;
//Console.WriteLine(num);
//Console.WriteLine($"{num: f2}");

////---------------------------------------------------------------------------------------------
// Char

//Полезни операзии за characters:

//Ако искате да видите каква е ЧИСЛОВАТА стойност на някоя буква (character):

//// числовата стойност на буквата а (малко а) е 97

//char a = 'a';
//int numericRepresentation = Convert.ToInt32(a);
//Console.WriteLine(numericRepresentation);

//Още един начин:

//char a = 'a';
//int numericRepresentation = (int)a;
//Console.WriteLine(numericRepresentation);
//int charAsNumber = int.Parse(character) - взема ascii value за съответната буква
//int charAsNumber = (int)character - взема ascii value за съответната буква чрез cast-ване

//Как да сравните числовата стойност на 2 char, ще пусна 2 варианта:

//string str = "input: 1";
//Console.WriteLine(Char.GetNumericValue('8'));       // Output: "8"
//Console.WriteLine(Char.GetNumericValue(str, 7));    // Output: "1"

//char chA = 'A';
//char chB = 'B';
//Console.WriteLine(chA.Equals('A'));     // Output: "True"
//Console.WriteLine('b'.Equals(chB));     // Output: "False"

////---------------------------------------------------------------------------------------------

//Намиране на четни и нечетни числа

//number % 2 == 0 - проверка дали число е четно

//number % 2 != 0 - проверка дали число е нечетно

//Как да вземате определено число от многочислено такова

//Например имаме числото 4365

//Искаме да вземем първото число - 4

//int firstDigit = fourDigitNumber / 1000;

//Второто число - 3

//int secondDigit = (fourDigitNumber / 100) % 10;

//Третото число - 6

//int thirdDigit = (fourDigitNumber / 10) % 10;

//Четвъртото число - 5

//int forthDigit = fourDigitNumber % 10;

////---------------------------------------------------------------------------------------------

//Сравняване с.CompareTo()


//string name = "Pesho";
//string secondName = "Ivan";
//// name.CompareTo(secondName) returns a NUMBER as result
//// ще върне -1 ако сборът на буквите на първата дума преобразувани към числа е по-малък от този сложен в скоби
//// ще върне 0 ако двата стринга са равни
//// ще върне 1 ако думата в скобите има по-висок сбор на буквите си
//Console.WriteLine(name.CompareTo(secondName));
//Как да разберем дали едно число се дели на 5 (като аналогично ще е и с други числа):

//currentNumber % 5 == 0

//Kак да намеря average на 2 числа ( тук ще върне реално число, което ще е от тип decimal)

//decimal averageNumber = (decimal)(a + b) / 2;

////---------------------------------------------------------------------------------------------

//Условният оператор - “?:”, изчислява булев израз и връща резултата от един от двата израза, в зависимост от това дали булевият израз e true или false.

//Или нагледно написано:

//is this condition true ? yes(do something) : no(do something)

//Доста прибран начин за изписване на такъв тип проверка и определено се използва често.

//Например при деклариране на променливи:

//int numN = int.Parse(Console.ReadLine());
//string even = numN % 2 == 0 ? “even” : “not even”;
//Console.WriteLine(even);

//Или по-често при печатането им:

//int numN = int.Parse(Console.ReadLine());
//Console.WriteLine("{0}", numN % 2 == 0 ? “even” : “not even”);

////---------------------------------------------------------------------------------------------

//TryParse() се опитва да парсне едит тип променлива в друг и ако успее, записва ресултата от парсването в променлива, която ние дефилираме в замия Parse statement.

//Какво реално се случва:

//string text = Console.ReadLine();
//int resultInteger = 0;
//// На долния ред казваме: Опитай се да парснеш към int стринга text и ако успееш, запиши резултата в променливата resultInteger
//if (int.TryParse(text, out resultInteger))
//{
//	resultInteger += 1;

//	Console.WriteLine(resultInteger);
//}
//// Ако не успееш, изпълни тази част от логиката на задачата
//else
//{
//	double resultDouble = double.Parse(text);
//	resultDouble += 1;

//	Console.WriteLine($"{resultDouble:f2}");
//}

////---------------------------------------------------------------------------------------------

//Как да намерим сбора на всички елементи в колекция:

//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//	sum += numbers[i];
//}

//Console.WriteLine(sum);

//Как да намерим най–голямото число в колекция:

//    int biggestNumber = int.MinValue;

//foreach (var item in numbers)
//{
//	if (item > biggestNumber)
//	{
//		biggestNumber = item;
//	}
//}

//Console.WriteLine(biggestNumber);

////---------------------------------------------------------------------------------------------
//// Arrays

//Как можем да инициализираме колекция:

//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
//int[] array = new int[10];

//Как да преобразуваме стринг в колекция от char:

//string word = "string";

//char[] charArr = word.ToCharArray();

//Kак да вземем от конзолата числа на един ред разделени от спейс или друг разделител:

//int[] firstInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//int[] anotherInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

//int[] thirdInput = Console.ReadLine().Split(new char[] { ' ', ',' }).Select(int.Parse).ToArray();

//int[] arrayN = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

//Console.ReadLine() - чете стринг от конзолата, един ред

//.Split(' ') - преобразува стинга към колекция от стрингове, като разбира разделя стринга на парченца по ’ ’ (празно място).

//.Select(int.Parse) -взема всеки стринг от новосъздадената колекция и го парсва към int

//.ToArray() -най просто казано, сглобява всичко в колекция от int

//.Distinct() - премахва копията на елементите от масив

//Console.WriteLine(string.Join(" ", arrayN.Except(arrayM))); - връща само елементите от първия масив, без тези които се повтарят в двата масива

//Още полезни неща, които можем да ползваме при Arrays:

//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

//int length = numbers.Length; // намира дължината на колекция
//Array.Sort(numbers); // сортира
//Array.Reverse(numbers); // обръща реда
//numbers.Min(); // намира най-малкото число
//numbers.Max(); // намира най-голямото число
//numbers.Sum(); // сумира числата в колекцията

//Как да вземем n на брой числа от конзолата и да ги сложим в масив

//int n = int.Parse(Console.ReadLine());

//int[] exampleInput = new int[n];

//for (int i = 0; i < n; i++)
//{
//	exampleInput[i] = int.Parse(Console.ReadLine());
//}

//Как да принтирам елемента на позиция 1 от колекция

//Console.WriteLine(words[1]);

//Как да принтирам елементите от колекция

//Първи начин:

//string[] courses = { "OOP", "HQC", "Entity Framework", "ASP.NET Core" };

//for (int index = 0; index < courses.Length; index++)
//{
//	string course = courses[index];
//	Console.WriteLine($"At index {index}: {course}");
//}

//Втори начин:

//    for (int i = 0; i < numbers.Length; i++)
//{
//	Console.WriteLine(numbers[i]);
//}

//Трети начин - с foreach

//foreach (var number in numbers)
//{
//	Console.WriteLine(number);
//}

//Как да принтираме елементите от колекция на един ред разделени със " "

//Console.WriteLine(string.Join(" ", numbers));

//Syntax sugar за принтиране на масиви:

//Array.ForEach(array, Console.WriteLine);

////---------------------------------------------------------------------------------------------
//// List

//Полезни операции, които можем да правим с Листове

//Инициализираме лист с 4 елемента, а после инсъртваме числото 11 на позиция с индекс 1 (тоест след числото 10) и вече имаме 5 елемента в листа.

//List numbers = new List() { 10, 20, 30, 40 };

//numbers.Insert(1, 11);

//Премахване на елементи от лист.

//List numbers = new List() { 10, 20, 30, 40, 10 };

//numbers.Remove(10); премахва първата 10-ка от листа

//numbers.RemoveAt(2); премахва елемента на позиция с индекс 2 (т.е. 3-я елемент)

//Добавяне на колекция/масив в лист.

//string[] cities = new string[3] { “Mumbai”, “London”, “New York” };

//var popularCities = new List();

//popularCities.AddRange(cities); → самото добавяне

//Добаване на елементи в лист.

//List primeNumbers = new List();

//primeNumbers.Add(1); // adding elements using add() method
//primeNumbers.Add(3);
//primeNumbers.Add(5);
//primeNumbers.Add(7);

//var cities = new List();
//cities.Add(“New York”);
//cities.Add(“London”);
//cities.Add(“Mumbai”);
//cities.Add(“Chicago”);

//Проверка за елементи в лист.

//var numbers = new List() { 10, 20, 30, 40 };
//numbers.Contains(10); → връща true
//numbers.Contains(11); → връща false
//numbers.Contains(20); → връща true