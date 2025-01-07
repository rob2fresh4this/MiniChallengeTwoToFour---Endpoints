namespace MiniChallengeTwoToFour___Endpoints.Services
{
    public class AddingTwoNumbersService
    {
        public string anwser;

        public AddingTwoNumbersService(){
            anwser = "Nothing here yet!";
        }

        public void AddingTwoNumbers(string num1, string num2)
        {
            int convertNum1;
            int convertNum2;

            bool isValied = int.TryParse(num1, out convertNum1);
            bool isValied1 = int.TryParse(num2, out convertNum2);

            if (isValied == false && isValied1 == false)
            {
                anwser = "Both numbers are not numbers";
            }
            else if (isValied == false)
            {
                anwser = "The first number is not a number";
            }
            else if (isValied1 == false)
            {
                anwser = "The second number is not a number";
            }
            else if (isValied == true && isValied1 == true)
            {
                int sum = convertNum1 + convertNum2;
                anwser = "The sum of " + convertNum1 + " and " + convertNum2 + " is " + sum.ToString();
            }
            else
            {
                anwser = "An error occured";
            }
        }

    }
}