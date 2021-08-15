using System;

namespace Eatery
{
    /// <summary>
    /// Summarize process types
    /// </summary>
    public abstract class Processing
    {
        /// <summary>
        /// Interfase processing type
        /// </summary>
        public Type ProcessingType { get; protected set; }
        /// <summary>
        /// Cost of processing
        /// </summary>
        public int Cost { get; protected set; }
        /// <summary>
        /// Cook time
        /// </summary>
        public int Time { get; protected set; }
    }
}
