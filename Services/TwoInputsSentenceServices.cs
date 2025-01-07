namespace MiniChallengeTwoToFour___Endpoints.Services
{
    // endpoint that accepts 2 inputs. You will take the answer from those inputs and display the answer in one sentence.
    //  - What is your name? 
    //  - What time did you wake up?
    //  *Your output should be a sentence that tells me who the person is and what time they woke up
    public class TwoInputsSentenceServices
    {
        public string reply;
        public TwoInputsSentenceServices()
        {
            reply = "Nothing here yet!";
        }

        public void TwoInputsSentence(string name, string time)
        {
            reply = "The person is " + name + " and they woke up at " + time;
        }
    }
}