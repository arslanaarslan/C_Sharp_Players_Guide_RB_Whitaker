using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_The_Password_Validator
{
    internal class PasswordValidator
    {
        // public static char[] lowerLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        // public static char[] uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static char[] bannedCharacters = "T&".ToCharArray();

        static bool _haveLowercaseLetter = false;
        static bool _haveUppercaseLetter = false;
        static bool _haveBannedCharacter = false;
        static bool _haveDigitCharacter = false;
        static bool _haveEnoughCharacter = false;

        String _password;

        public PasswordValidator (String password)
        {
            _password = password;

            
        }

        public bool IsValid()
        {
            _haveLowercaseLetter = HaveLowercaseLetter(_password);
            _haveUppercaseLetter = HaveUppercaseLetter(_password);
            _haveDigitCharacter = HaveDigitCharacter(_password);
            _haveBannedCharacter = HaveBannedCharacter(_password);
            _haveEnoughCharacter = HaveEnoughCharacter(_password);

            if (_haveLowercaseLetter && _haveUppercaseLetter && _haveDigitCharacter && _haveEnoughCharacter && !_haveBannedCharacter)
            {
                return true;
            }

            return false;

        }

        private bool HaveLowercaseLetter(String password)
        {
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }

            return false;

        }

        private bool HaveUppercaseLetter(String password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }

            return false;
        }

        private bool HaveDigitCharacter(String password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }

            return false;
        }

        private bool HaveBannedCharacter(String password)
        {
            foreach (char c in password)
            {
                foreach (char bannedCharacter in bannedCharacters)
                {
                    if (c == bannedCharacter)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool HaveEnoughCharacter(String password)
        {
            if (password.Length >= 6 && password.Length <= 13)
            {
                return true;
            }

            return false;
        }
    }
}
