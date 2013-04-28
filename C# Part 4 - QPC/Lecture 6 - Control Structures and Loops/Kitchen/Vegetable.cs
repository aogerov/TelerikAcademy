using System;

namespace Kitchen
{
    public abstract class Vegetable
    {
        public bool IsPeeled { get; set; }
        public bool IsCut { get; set; }
        public bool IsRotten { get; set; }
    }
}