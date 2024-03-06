try
{
  Process1();
}
catch
{
  Console.WriteLine("An exception has occurred, Catched in Main method");
}

Console.WriteLine("Exit program normally");

static void Process1()
{
  try
  {
    WriteMessage();
  }
  catch (System.Exception)
  {
    Console.WriteLine("An exception has occurred, Catched in Process1 method");
    throw;
  }
}

static void WriteMessage()
{
  double float1 = 3000.0;
  double float2 = 0.0;
  int number1 = 3000;
  int number2 = 0;
  try
  {
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
  }
  catch (System.Exception)
  {
    Console.WriteLine("An exception has occurred, Catched in WriteMessage method");
    throw;
  }
}