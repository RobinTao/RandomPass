using RandomPass;

//int length = 32;
//int nonAlphabet = 16;

int length = 16;
int nonAlphabet = 8;

for (int i = 0; i < 10; ++i)
{
    string pass = Password.Generate(length, nonAlphabet);
    Console.WriteLine(pass);
}
