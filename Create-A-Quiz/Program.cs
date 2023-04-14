// Create-A-Quiz
#nullable disable

Console.Clear();
Console.WriteLine("WELCOME TO THE BSD QUIZ!");


// Quiz

// Score Variable
int score = 0;

// Question 1 
        Console.Write("\n1. When was the first volume released? ");
        string ansOne = Console.ReadLine().ToLower();

        if ( ansOne == "april 2013" || ansOne == "2013 april" || ansOne == "april 4, 2013" || ansOne == "2013") {
            score++;
            Console.WriteLine("Correct!");
        } else {
            Console.WriteLine("Inorrect!");
        }

// Question 2 
        Console.Write("\n2. When did the first season premiere? ");
        string ansTwo = Console.ReadLine().ToLower();

        if ( ansTwo == "april 2016" || ansTwo == "2016 april" || ansTwo == "april 7, 2016" || ansTwo == "2016") {
            score++;
            Console.WriteLine("Correct!");
        } else {
            Console.WriteLine("Inorrect!");
        } 

// Question 3
        Console.Write("\n3. How many authors are mentioned in the ADA? ");
        string ansThree = Console.ReadLine().ToLower();

        if ( ansThree == "10" || ansThree == "ten" ) {
            score++;
            Console.WriteLine("Correct!");
        } else {
            Console.WriteLine("Inorrect!");
        } 

// Question 4
        Console.Write("\n4.Who is the protagonist? ");
        string ansFour = Console.ReadLine().ToLower();

        if ( ansFour == "atsushi" || ansFour == "atsushi nakajima" || ansFour == " nakajima atsushi" ) {
            score++;
            Console.WriteLine("Correct!");
        } else {
            Console.WriteLine("Inorrect!");
        } 

//Process Score and Feedback Messages
    double percentScore = Convert.ToDouble(score) / 4 * 100;
    
    int feedbackScore = score;

    if (feedbackScore == 1 || feedbackScore == 0) {
        Console.WriteLine("\nTry Again.");
    } else if (feedbackScore == 2) {
        Console.WriteLine("\nNot Bad!");
    } else if (feedbackScore == 3) {
        Console.WriteLine("\nSo Close!");
    } else {
        Console.WriteLine("\nAMAZING JOB!");
    }

//Output
    Console.WriteLine($"{score}/4 ({percentScore} %)");
