   int.TryParse(Console.ReadLine(), out int number);

    var negativeN = number * (-1);

    while (negativeN <= number)
    {
      Console.Write(negativeN + " ");
      negativeN++;

    }