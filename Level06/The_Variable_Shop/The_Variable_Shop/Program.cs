using System;

namespace The_Variable_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            byte _byte = byte.MaxValue;
            Console.WriteLine(_byte);
            short _short = short.MaxValue;
            Console.WriteLine(_short);
            int _int = 1_000;
            Console.WriteLine(_int);
            long _long = long.MaxValue;
            Console.WriteLine(_long);
            sbyte _sbyte = sbyte.MaxValue;
            Console.WriteLine(_sbyte);
            ushort _ushort = ushort.MaxValue;
            Console.WriteLine(_ushort);
            uint _uint = uint.MaxValue;
            Console.WriteLine(_uint);
            ulong _ulong = 5_000_000UL;
            Console.WriteLine(_ulong);

            int binaryThirteen = 0b00001011;
            Console.WriteLine(binaryThirteen);
            int hexFifteen = 0x0F;
            Console.WriteLine(hexFifteen);

            char _char = 'A';
            Console.WriteLine(_char);

            char _unicode = '\u0061';
            Console.WriteLine(_unicode);

            string _string = "Arslan";
            Console.WriteLine(_string);

            double _double = double.MaxValue;
            Console.WriteLine(_double);
            float _float = 0.25F;
            Console.WriteLine(_float);
            decimal _decimal = decimal.MinValue;
            Console.WriteLine(_decimal);
            decimal _decimal2 = 1_000_000.000_5M;
            Console.WriteLine(_decimal2);

            bool _bool = true;
            Console.WriteLine(_bool);

            _byte = byte.MinValue;
            Console.WriteLine(_byte);

            _short = short.MinValue;
            Console.WriteLine(_short);

            _int = int.MinValue;
            Console.WriteLine(_int);

            _long = long.MinValue;
            Console.WriteLine(_long);

            _sbyte = sbyte.MinValue;
            Console.WriteLine(_sbyte);

            _ushort = ushort.MinValue;
            Console.WriteLine(_ushort);

            _uint = uint.MinValue;
            Console.WriteLine(_uint);

            _ulong = ulong.MinValue;
            Console.WriteLine(_ulong);

            _char = char.MinValue;
            Console.WriteLine(_char);

            _string = string.Empty;
            Console.WriteLine(_string);

            _double = double.MinValue;
            Console.WriteLine(_double);

            _float = float.MinValue;
            Console.WriteLine(_float);

            _decimal = decimal.MinValue;
            Console.WriteLine(_decimal);

        }
    }
}
