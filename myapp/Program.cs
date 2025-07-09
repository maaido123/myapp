using System;


//// Variables
//string name = "Farhio Bashiir";
//Console.WriteLine(name);

//string motherName = "Saido Ali";
//Console.WriteLine(motherName);

//string dobString = "1990-06-25";  // Taariikhda dhalashada string ahaan
//Console.WriteLine(dobString);

//// Convert dob string to DateTime
//DateTime dob = DateTime.Parse(dobString);
//Console.WriteLine(dob.ToShortDateString());

//// Calculate age
//DateTime today = DateTime.Today;
//int age = today.Year - dob.Year;
//if (dob > today.AddYears(-age)) age--;
//Console.WriteLine(age);

//string pop = "Somali";
//Console.WriteLine(pop);

//string address = "Galkacyo, Somalia";
//Console.WriteLine(address);

//string telephone = "09000000";
//Console.WriteLine(telephone);

//string sex = "Female";
//Console.WriteLine(sex);

//string status = "Single";
//Console.WriteLine(status);

//string name, motherName, dobString, pop, address ,single , sex,status;
//int tell;
//Console.WriteLine("gali magacaga");
//name = Console.ReadLine();

//Console.WriteLine("gali hooyada");
//motherName =Console.ReadLine();

//Console.WriteLine("gali taariikhda dhalashada");
//dobString = Console.ReadLine();


//Console.WriteLine("gali meesha kudhalatay");
//pop = Console.ReadLine();

//Console.WriteLine("gali address");
//address = Console.ReadLine();

//Console.WriteLine("gali sex");
//sex = Console.ReadLine();


//Console.WriteLine("gali statuskaga");
//status = Console.ReadLine();


//int tiro;
//Random qulxin = new Random(); // random object
// function to generate a random number between 1 and 50


//int loop;
//for (loop = 1; loop <= 10; loop++)
//{
//    tiro = qulxin.Next(1, 50);
//    Console.WriteLine(tiro);

//}


int tiro;
int iskuday = 0; 
Random qulxin = new Random(); // Object Random

int loop;
for (loop = 1; loop <= 10; loop++)
{
    tiro = qulxin.Next(1, 50); // Random 1 ilaa 49
    Console.WriteLine(loop+"\t\t"+tiro);
    iskuday = iskuday + tiro;

}
Console.WriteLine("iskudarka" +iskuday);