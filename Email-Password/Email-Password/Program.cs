using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		var EmailId1 = "code.edu.az";
		var EmailId2 = "test1212@com";

		string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

		//check first string
		if (Regex.IsMatch(EmailId1, pattern))
		{
			//if email is valid
			Console.WriteLine(EmailId1 + " is a valid Email address ");
		}
		else
		{
			Console.WriteLine(EmailId1 + " is a valid Email address");
		}

        //check second string
        if (!Regex.IsMatch(EmailId2, pattern))
        {
            //print if email id is not valid
            Console.WriteLine(EmailId2 + " is Not a Valid Email address");

            {

        else
        {
            //print if email id is valid
            Console.WriteLine(EmailId2 + " is Not Valid Email address ");
        }

            
	
  





