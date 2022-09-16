

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//Kas kasutaja arv on paaris v. paaritu

int result = userNum % 2;

Console.WriteLine(result);

if(result != 0) //!= - ei ole(eitus)
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("User number is even.");
}