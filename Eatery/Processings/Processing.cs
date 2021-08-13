using System;

namespace Eatery
{
    public abstract class Processing
    {
        public Type processingType;
        public int Cost { get; protected set; }
        public int Time { get; protected set; }
    }
}
