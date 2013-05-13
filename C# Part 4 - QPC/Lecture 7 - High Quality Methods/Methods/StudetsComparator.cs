using System;

namespace Methods
{
    public static class StudetsComparator
    {
        public static bool IsFirstIsOlderThanSecond(Student first, Student second)
        {
            if (first.Born == null || second.Born == null)
            {
                throw new ArgumentNullException("Date of birth don't exists.");
            }

            bool isOlder = (first.Born < second.Born);
            return isOlder;
        }
    }
}