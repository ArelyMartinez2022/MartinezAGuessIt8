/* See https://aka.ms/new-console-template for more information
ARELY MARTINEZ 

OCT 20 2022 11:33 AM

GUESS IT #8 

THIS PROGRAM WILL ASK THE USER IF THEY WANT TO PICK EASY, 
MEDIUM, OR HARD MODE FOR A GUESSING GAME. (THAT WILL REQUIRE 
DATA VAILDATION OTHERWISE THEY WILL BE ASKED OVER AND OVER 
AGAIN UNTIL THEY INPUT A VAILD RESPONSE.) ONCE THE USER ENTERS 
THE MODE THEY WOULD LIKE THEY WOULD HAVE TO GUESS FROM A RANGE 
OF NUMBERS. THEY WILL BE TOLD THAT THIER GUESSING NUMBER IS TOO
 HIGH, TOO LOW, OR CORRECT AND END. THE FINAL PART WILL ASK THE 
 USER IF THEY WOULD LIKE TO PLAY AGAIN. THAT TOO WILL RQUIRE DATA 
 VAILDTION.

PEER REVIEW: NAME -- REVIEW
*/
Console.WriteLine("Hello, World!");
Console.Clear();

bool playAgain = true;
while (playAgain) {
    bool isConverted = true;
    bool isNumber;
    long vaildNum = 0;

    while (isConverted) {
        //Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("▰▱▰▱▰▱▰▱▰▱▰▱▰▱ LETS PLAY A GUESSING GAME ▰▱▰▱▰▱▰▱▰▱▰▱▰▱");
        Console.WriteLine(" ");
        Console.WriteLine("ENTER 1 FOR EASY MODE: GUESS FROM 1 - 10 " );
        Console.WriteLine(" ");
        Console.WriteLine("ENTER 2 FOR MEDIUM MODE: GUESS FROM 1 - 50 ");
        Console.WriteLine(" ");
        Console.WriteLine("ENTER 3 FOR HARD MODE: GUESS FROM 1 - 100 " );
        Console.WriteLine(" ");
        string mode = Console.ReadLine();
        isNumber = Int64.TryParse(mode, out vaildNum);

        if (isNumber == true && vaildNum == 3 || vaildNum == 2|| vaildNum == 1 ) {
            Console.Clear();
            isConverted = false;
            Console.WriteLine(" ");
            Console.WriteLine("YOU ENTERED A VAILD OPTION");
        } else {
            Console.WriteLine(" ");
            Console.WriteLine("INAILD OPTION TRY AGAIN!! ");
        }
    }


    Console.WriteLine(" ");
    int guesses = 0;
    switch(vaildNum){
        case 1:
            bool correctEasy = true;
            Random ranNum = new Random();
            int num = ranNum.Next(0, 10);
            Console.WriteLine("▰▱▰▱▰▱▰▱▰▱▰▱▰▱ YOU CHOSE EASY MODE ▰▱▰▱▰▱▰▱▰▱▰▱▰▱");
            Console.WriteLine(" ");

            while(correctEasy){ 
                long convertEasyMode1 = 0;
                bool convert1 = true;
                while(convert1) {
                    Console.WriteLine("GUESS A # FROM 1 - 10 "); 
                    string guessEasyMode = Console.ReadLine();
                    isNumber = Int64.TryParse(guessEasyMode, out convertEasyMode1);
                    if (isNumber == true  ) {
                        convert1 = false;
                        Console.WriteLine(" ");
                        Console.WriteLine("YOU ENTERED A VAILD OPTION");
                    } else {
                        Console.WriteLine("INAILD OPTION TRY AGAIN!! ");
                    } 
                }
                //int convertEasyMode1 = convertEasyMode;

                Console.WriteLine(num);
                guesses++;

                if(convertEasyMode1 == num) {
                    Console.Clear();
                    Console.WriteLine("CONGRATS " + convertEasyMode1 + " WAS RIGHT!!"); 
                    correctEasy = false;
                }
                if(convertEasyMode1 < num) {
                    Console.Clear();
                    Console.WriteLine(convertEasyMode1 + " IS TOO LOW !! "); 
                    correctEasy = true;
                }
                if(convertEasyMode1 > num) {
                    Console.Clear();
                    Console.WriteLine(convertEasyMode1 + " IS TOO HIGH !! ");
                    correctEasy = true;
                }
            }
        break;
        case 2:
            bool correctMed = true;
            Random ranNumMed = new Random();
            int numMed = ranNumMed.Next(0, 50);
            Console.WriteLine("▰▱▰▱▰▱▰▱▰▱▰▱▰▱ YOU CHOSE MEDIUM MODE ▰▱▰▱▰▱▰▱▰▱▰▱▰▱");
            Console.WriteLine(" ");
            while(correctMed){ 

                long convertEasyMode2 = 0;
                bool convert2 = true;

                while(convert2) {

                    Console.WriteLine("GUESS A # FROM 1 - 50 "); 
                    string guessMedMode = Console.ReadLine();
                    isNumber = Int64.TryParse(guessMedMode, out convertEasyMode2);
                    if (isNumber == true  ) {
                        convert2 = false;
                        Console.WriteLine(" ");
                        Console.WriteLine("YOU ENTERED A VAILD OPTION");
                    } else {
                        Console.WriteLine("INAILD OPTION TRY AGAIN!! ");
                    } 
                }

                Console.WriteLine(numMed);
                guesses++;
                if(convertEasyMode2 == numMed) {
                    Console.Clear();
                    Console.WriteLine("CONGRATS " + convertEasyMode2 + " WAS RIGHT!!"); 
                    correctMed = false;
                }
                if(convertEasyMode2 < numMed) {
                    Console.Clear();
                    Console.WriteLine(convertEasyMode2 + " IS TOO LOW !! "); 
                    correctMed = true;
                }
                if(convertEasyMode2 > numMed) {
                    Console.Clear();
                    Console.WriteLine(convertEasyMode2 + " IS TOO HIGH !! ");
                    correctMed = true;
                }
            }
        break;
        case 3:
            bool correctHard = true;
            Random ranNumHard = new Random();
            int numHard = ranNumHard.Next(0, 100);
            Console.WriteLine("▰▱▰▱▰▱▰▱▰▱▰▱▰▱ YOU CHOSE HARD MODE ▰▱▰▱▰▱▰▱▰▱▰▱▰▱");
            Console.WriteLine(" ");

            while(correctHard){ 

                long convertEasyMode3 = 0;
                bool convert3 = true;

                while(convert3) { 
                    Console.WriteLine("GUESS A # FROM 1 - 100 "); 
                    string guessHardMode = Console.ReadLine();
                    isNumber = Int64.TryParse(guessHardMode, out convertEasyMode3);
                    if (isNumber == true  ) {
                        convert3 = false;
                        Console.WriteLine(" ");
                        Console.WriteLine("YOU ENTERED A VAILD OPTION");
                    } else {
                        Console.WriteLine("INAILD OPTION TRY AGAIN!! ");
                    } 
                }
                
                guesses++;
                if(convertEasyMode3 == numHard) {
                    Console.Clear();
                    Console.WriteLine("CONGRATS " + convertEasyMode3 + " WAS RIGHT!!"); 
                    correctHard = false;
                }
                if(convertEasyMode3 < numHard) {
                    Console.Clear();
                    Console.WriteLine(convertEasyMode3 + " IS TOO LOW !! "); 
                    correctHard = true;
                }
                if(convertEasyMode3 > numHard) {
                    Console.Clear();
                    Console.WriteLine(convertEasyMode3 + " IS TOO HIGH !! ");
                    correctHard = true;
                }
            }
        break;
    }

    Console.WriteLine(" ");
    Console.WriteLine("IT TOOK YOU " + guesses + " GUESS(ES)!! ");
    Console.WriteLine(" ");

    bool converted = true;
    while (converted){
        Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN? YES OR NO? ");
        string rePlay = Console.ReadLine().ToUpper();

        if(rePlay == "YES" ){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" ){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
            Console.WriteLine(" ");
        }
    } 
}