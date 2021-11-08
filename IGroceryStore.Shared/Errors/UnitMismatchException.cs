using System;

namespace IGroceryStore.Shared.Errors
{
    public class UnitMismatchException : Exception
    {
        public UnitMismatchException(string message) : base(message)
        {
        }
    }
}