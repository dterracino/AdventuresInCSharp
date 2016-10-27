namespace AdventuresInCSharp {
    using System;

    /// <summary>
    ///     A value T Current clamped between a T Base and T Max. Attempting to set beyond these bounds will round to the
    ///     closest bound.
    /// </summary>
    public class Bounded<T> where T : struct, IComparable<T> {
        public T Max { get; }
        public T Base { get; }

        public T Current {
            get { return current; }
            set { current = Clamp(value); }
        }

        /// <summary>
        ///     <see cref="Current" /> initialized to <see cref="Max" />.
        /// </summary>
        /// <param name="min">Lowest possible value</param>
        /// <param name="max">Highest possible value</param>
        /// <returns></returns>
        public static Bounded<T> OfRange(T min, T max) {
            return new Bounded<T>(min, max, max);
        }

        /// <summary>
        ///     <see cref="Current" /> initialized to <see cref="Base" />.
        /// </summary>
        /// <param name="min">Lowest possible value</param>
        /// <param name="max">Highest possible value</param>
        /// <returns></returns>
        public static Bounded<T> OfRangeStartingAtMin(T min, T max) {
            return new Bounded<T>(min, max, min);
        }

        /// <summary>
        ///     <see cref="Current" /> initialized to <see cref="Max" />. <see cref="Min" /> set to default(T).
        /// </summary>
        /// <param name="max">Highest possible value</param>
        /// <returns></returns>
        public static Bounded<T> OfMaxValue(T max) {
            return new Bounded<T>(default(T), default(T), max);
        }

        public Bounded(T min, T max, T current) {
            if(max.CompareTo(min) < 0) {
                throw new ArgumentException($"{nameof(Max)} ({max}) must be >= {nameof(Base)} ({min})");
            }
            Base = min;
            Max = max;
            this.current = current;
        }

        private T current;

        private T Clamp(T value) {
            if(value.CompareTo(Base) < 0) {
                return Base;
            }
            if(value.CompareTo(Max) > 0) {
                return Max;
            }
            return value;
        }
    }
}
