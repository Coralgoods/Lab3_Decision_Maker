using System;

namespace Lab3_Decision_Maker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput;
            string userName = "Human";

            Console.WriteLine("Please enter your name");
            userInput = Console.ReadLine();

            // If the user doesn't enter a name and just hits enter they will
            // be named "Human"
            if (userInput != string.Empty)
            {
                userName = userInput.Trim();
            }

            bool validInteger;
            bool validredo = false;
            bool integercheckerror = false;
            int integerUserEnter;
            string integerMessage;
            bool redo = false;

            const string intergerErrorResponse = "Integer or range error. Try again! - ";

            while (!redo) //redo the exercise
            {

                do //Valid Integer check
                {
                    if (integercheckerror == false)
                    {
                        integerMessage = userName;
                    }
                    else
                    {
                        integerMessage = intergerErrorResponse + userName;
                    }

                    Console.WriteLine(integerMessage + " will you please enter an integer between 1 and 100");
                    userInput = Console.ReadLine();

                    validInteger = int.TryParse(userInput, out integerUserEnter);

                    if (integerUserEnter < 1 || integerUserEnter > 100)
                    {
                        validInteger = false;
                    }

                    integercheckerror = true;

                } while (validInteger != true);


                if (integerUserEnter % 2 != 0 && integerUserEnter > 60)
                {
                    Console.WriteLine(userName + "  " + integerUserEnter + " Odd.");
                }
                else if (integerUserEnter % 2 != 0 && integerUserEnter < 60)
                {
                    Console.WriteLine(userName + "  " + integerUserEnter + " Odd.");
                }
                else if (integerUserEnter % 2 == 0 && integerUserEnter < 25)
                {
                    Console.WriteLine(userName + " Even and less than 25.");
                }
                else if (integerUserEnter % 2 == 0 && integerUserEnter > 25 && integerUserEnter < 61)
                {
                    Console.WriteLine(userName + " Even.");
                }
                else if (integerUserEnter % 2 == 0 && integerUserEnter > 60)
                {
                    Console.WriteLine(userName + "  " + integerUserEnter + " Even");
                }
                else
                {
                    Console.WriteLine(userName + " - " + integerUserEnter + "Error - how did you do that? ");
                }

                bool yesNoValidation = true;
                bool yesNoerror = false;
                do
                {
                    while (yesNoValidation)
                    {
                        string errorMessage = "Error, please try again: ";

                        if (yesNoerror == true)
                        {
                            Console.Write(errorMessage + userName + " - Would you to do it again? (yes or no) ");
                        }
                        else
                        {
                            Console.Write(userName + " - Would you to do it again? (yes or no) ");
                        }
                        userInput = Console.ReadLine();

                        if (userInput.Trim().ToLower() == "yes")
                        {
                            validredo = true;
                            integercheckerror = false;
                            yesNoValidation = false;

                        }
                        else if (userInput.Trim().ToLower() == "no")
                        {
                            validredo = true;
                            redo = true;
                            yesNoValidation = false;

                        }
                        else
                        {
                            yesNoValidation = true;
                            validredo = false;
                            yesNoerror = true;
                        }
                    }
                } while (validredo != true);

            }

        }
    }
}
