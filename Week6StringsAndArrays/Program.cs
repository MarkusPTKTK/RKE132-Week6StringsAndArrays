string hello = "hello, world! Here I am!";

int stringLenght = hello.Length;

//string trimmedString = hello.Trim();


hello = hello.Trim();

char firstletter = hello[0];
Console.WriteLine(firstletter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

firstletter = hello[0];
Console.WriteLine(firstletter);


//int wordCounter = 1;
//for(int i = 0; i < hello.Lenght; i++)
//{
//      if (char.IsWhiteSpace(hello[i]))
//      {
//          wordCounter++;
//      }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");