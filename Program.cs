Dictionary<char, string> gradeMessages = new Dictionary<char, string>();

gradeMessages.Add('P', "Wow! That's impressive!");
gradeMessages.Add('A', "Very nice!");
gradeMessages.Add('B', "Keep it up!");
gradeMessages.Add('C', "You got this, keep working!");
gradeMessages.Add('D', "Keep trying!");
gradeMessages.Add('E', "Don't give up!");

Console.WriteLine("Enter the number score you have in class.");
var score = Int32.Parse(Console.ReadLine());

char letter = 'P';

if (score >= 100)
    letter = 'P';
else if (score >= 90)
    letter = 'A';
else if (score >= 80)
    letter = 'B';
else if (score >= 70)
    letter = 'C';
else if (score >= 60)
    letter = 'D';
else
    letter = 'E';

string a = letter == 'P' ? "A+" : letter+"";

Console.WriteLine(gradeMessages[letter]);
Console.WriteLine($"Letter grade: {a}");