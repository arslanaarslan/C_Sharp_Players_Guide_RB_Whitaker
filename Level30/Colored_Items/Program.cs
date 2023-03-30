// See https://aka.ms/new-console-template for more information


namespace Colored_Items;

class Program
{
    
    public class Sword {}
    public class Bow {}
    public class Axe {}

    public class ColoredItem<T> where T : new()
    {
        private T _item;

        public T Item
        {
            get => _item;
            set => _item = value;
        }

        private ConsoleColor _consoleColor;

        public ConsoleColor ConsoleColor
        {
            get => _consoleColor;
            set => _consoleColor = value;
        }

        public ColoredItem(ConsoleColor consoleColor)
        {
            this.ConsoleColor = consoleColor;
            this.Item = new T();
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor;
            Console.WriteLine(Item?.ToString());
        }
    }

    static void Main()
    {
        ColoredItem<Sword> redSword = new ColoredItem<Sword>(ConsoleColor.Red);
        redSword.Display();
        
        ColoredItem<Axe> blueAxe = new ColoredItem<Axe>(ConsoleColor.Blue);
        blueAxe.Display();

        ColoredItem<Bow> yellowBow = new ColoredItem<Bow>(ConsoleColor.Yellow);
        yellowBow.Display();
    }
}