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
    Console.WriteLine($"DivideByZeroException catched in Process1 method: {ex.Message}");
    throw new DivideByZeroException("A new DividedByZeroException", ex);
  }
  catch (OverflowException ex)
  {
    Console.WriteLine($"OverflowException catched in Process1 method: {ex.Message}");
    throw new OverflowException("A new OverflowException", ex);
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
    // string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

    // foreach (string inputValue in inputValues)
    // {
    //   int numValue = 0;
    //   try
    //   {
    //     numValue = int.Parse(inputValue);
    //   }
    //   catch (FormatException)
    //   {
    //     Console.WriteLine("Invalid readResult. Please enter a valid number.");
    //   }
    //   catch (OverflowException)
    //   {
    //     Console.WriteLine("The number you entered is too large or too small.");
    //   }
    //   catch (Exception ex)
    //   {
    //     Console.WriteLine(ex.Message);
    //   }
    // }

    try
    {
      Console.WriteLine(float1 / float2);
      // Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
      Console.WriteLine($"Exception caught when dividing: {ex.Message}");
      throw;
    }
    checked
    {
      try
      {
        smallNumber = (byte)number1;
      }
      catch (OverflowException ex)
      {
        Console.WriteLine($"Exception caught when convert data type: {ex.Message}");
        throw;
      }
    }
  }
  catch (System.Exception ex)
  {
    Console.WriteLine($"Catched in WriteMessage method: {ex.Message}");
    throw;
  }
}