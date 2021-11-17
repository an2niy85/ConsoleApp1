using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toatalPictures = 52;
            int picturesInRow = 3;
            int fullyFilledRaws = toatalPictures / picturesInRow;
            int picturesBeyondMeasure = toatalPictures % picturesInRow;

            System.Console.WriteLine($"Всего рядов с картинками: {fullyFilledRaws}");
            System.Console.WriteLine($"Картинок сверх меры: {picturesBeyondMeasure}");
        }
    }
}
