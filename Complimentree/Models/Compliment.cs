namespace Complimentree.Models
{
    public class Compliment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public static Random rnd = new();
        private static List<string> complimentTexts = new()
        {
        "You may not be evergreen, but you are to me.",
        "I bet squirrels consider you prime real estate.",
        "You're so down to earth.",
        "You're very grounded.",
        "Your leaves are soothing.",
        "You sway nicely in the wind.",
        "You're blooming brilliant.",
        "You're really good at standing still and doing nothing.",
        "Let's get to the root of your beauty.",
        "I will never leaf you.",
        "You've really branched out lately.",
        "You provide the perfect amount of shade on a hot day.",
        "I'm really pine-ing for you.",
        "Why are you weeping?"
        };
        public static Compliment GetCompliment(int id, int treeId)
        {
            //var complimentText = complimentTexts[rnd.Next(complimentTexts.Count)];
            //return new Compliment { Id = id, Text = complimentText };
            string complimentText;
            if(treeId == 2)
            {
                complimentText = complimentTexts[complimentTexts.Count - 1];
            } else
            {
                complimentText = complimentTexts[rnd.Next(complimentTexts.Count)];
            }

            return new Compliment { Id = id, Text = complimentText };

        }
    }
}
