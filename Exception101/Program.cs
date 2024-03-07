try
{
  Process1();
}
catch (Exception ex)
{
  Console.WriteLine($"An exception has occurred, Catched in Main method: {ex}");
}

Console.WriteLine("Exit program normally");

static void Process1()
{
  try
  {
    WriteMessage();
  }
  catch (DivideByZeroException ex)
  {
    Console.WriteLine($"Catched in Process1 method: {ex.Message}");
    throw;
  }
}

static void WriteMessage()
{
  double float1 = 3000.0;
  double float2 = 0.0;
  int number1 = 3000;
  int number2 = 0;
  byte smallNumber;

  try
  {
    Console.WriteLine(float1 / float2);
    checked
    {
      smallNumber = (byte)number1;
    }
    Console.WriteLine(number1 / number2);
  }
  catch (System.Exception ex)
  {
    Console.WriteLine($"Catched in WriteMessage method: {ex.Message}");
    throw;
  }
}