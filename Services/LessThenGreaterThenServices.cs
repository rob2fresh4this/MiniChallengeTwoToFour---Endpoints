// endpoint that accepts 2 numbers. Results should print the following 2 statements:
// The first statement should tell me if the first number is greater than, less than or equal to the second number.
// The second statement should tell me if the second number is greater than, less than, or equal to the first number.
namespace MiniChallengeTwoToFour___Endpoints.Services
{
    public class LessThenGreaterThenServices
    {
        public string reply1;
        public LessThenGreaterThenServices(){
            reply1 = "Nothing here yet!";
        }

        public void LessThenGreaterThen(string num3, string num4)
        {
            int convertNum3;
            int convertNum4;

            bool isValied2 = int.TryParse(num3, out convertNum3);
            bool isValied3 = int.TryParse(num4, out convertNum4);

            if (isValied2 == false && isValied3 == false)
            {
                reply1 = "Both numbers are not numbers";
            }
            else if (isValied2 == false)
            {
                reply1 = "The first number is not a number";
            }
            else if (isValied3 == false)
            {
                reply1 = "The second number is not a number";
            }
            else if (isValied2 == true && isValied3 == true)
            {
                if (convertNum3 > convertNum4)
                {
                    reply1 = "The first number " + convertNum3 + " is greater than the second number " + convertNum4;
                }
                else if (convertNum3 < convertNum4)
                {
                    reply1 = "The first number " + convertNum3 + " is less than the second number " + convertNum4;
                }
                else if (convertNum3 == convertNum4)
                {
                    reply1 = "The first number " + convertNum3 +  "     is equal to the second number " + convertNum4;
                }
                else
                {
                    reply1 = "An error occured";
                }
            }
        }

    }
}