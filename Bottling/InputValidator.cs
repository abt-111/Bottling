namespace Bottling
{
    internal class InputValidator
    {
        public static uint ValidUserInputUnsignedInteger(string messageForUser)
        {
            bool isValid = false;
            uint validInteger = 0;
            string userInput;

            while (!isValid)
            {
                Console.Write(messageForUser);
                userInput = Console.ReadLine();

                isValid = uint.TryParse(userInput, out validInteger);

                if (!isValid)
                {
                    Console.WriteLine($"Tu dois entrer un entier compris entre 0 et {UInt32.MaxValue} \n");
                }
            }

            return validInteger;
        }

        public static float ValidUserInputFloat(string messageForUser)
        {
            bool isValid = false;
            float validFloat = 0.0f;
            string userInput;

            while (!isValid)
            {
                Console.Write(messageForUser);
                userInput = Console.ReadLine();

                isValid = float.TryParse(userInput, out validFloat);

                if (!isValid)
                {
                    Console.WriteLine($"Tu dois entrer un nombre réel compris entre {Single.MinValue} et {Single.MaxValue} \n");
                }
            }

            return validFloat;
        }
    }
}
