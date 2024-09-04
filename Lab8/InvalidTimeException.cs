using System;

namespace Lab8
{
    class InvalidTimeException : Exception
    {
        public InvalidTimeException() {}
        public InvalidTimeException(string message) : base(message) {}
    }
}