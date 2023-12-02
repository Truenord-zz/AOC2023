namespace parser{


    public class Parser{
        private string path = @"input.txt";
        public Parser(){
        }

        public int ProcessFileLines(){
            //copying it into a local datastructure
            string[] lines = File.ReadAllLines(path);
            //container for extracted numbers
            int [] extractedNumbers = new int[lines.Length];
            // for loop for the extraction
            for (int i = 0; i<lines.Length; i++){
                string firstDigit = FirstDigit(lines[i]);
                string lastDigit = LastDigit(lines[i]);
                extractedNumbers[i] = int.Parse(firstDigit+lastDigit);

            }
            // Summing up and returning
            int sum = SumOfDigitPairs(extractedNumbers);
            return sum;
        }
      
        private string FirstDigit(string input){
            //returns the first digit of the string
            char[] needName = input.ToCharArray();
            for (int i = 0; i<needName.Length; i++){
                if (char.IsDigit(needName[i])) {
                    return needName[i].ToString();
                }
            }
            return 0.ToString(); // if there is no digit in string, it contributes 0 to the total sum.
        }
        private string LastDigit(string input){
            //returns the first digit of the string
            char[] needName = input.ToCharArray();
            for (int i = needName.Length-1; i>=0; i--){
                if (char.IsDigit(needName[i])) {
                    return needName[i].ToString();
                }
            }
            return 0.ToString(); // if there is no digit in string, it contributes 0 to the total sum.
        
        }
        private int SumOfDigitPairs(int[] input){
            //returns the sum of all pairs of digits in the array
            int sum = 0;
            for (int i = 0; i<input.Length; i++){
                sum+=input[i];
            }
            return sum;
        }
    }
}

