using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_app
{
    public static class CardExtensions  // Добавил static для удобства использования
    {
        public static IEnumerable<T> InterleaveSequences<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            using var firstEnumerator = first.GetEnumerator();
            using var secondEnumerator = second.GetEnumerator();

            bool hasFirst = firstEnumerator.MoveNext();
            bool hasSecond = secondEnumerator.MoveNext();

            while (hasFirst || hasSecond)
            {
                if (hasFirst)
                {
                    yield return firstEnumerator.Current!; 
                    hasFirst = firstEnumerator.MoveNext();
                }

                if (hasSecond)
                {
                    yield return secondEnumerator.Current!;
                    hasSecond = secondEnumerator.MoveNext();
                }
            }
        }

        public static bool SequencesEqual<T>(this IEnumerable<T> first, IEnumerable<T> second) where T : notnull
        {
            using var firstEnum = first?.GetEnumerator() ?? throw new ArgumentNullException(nameof(first));
            using var secondEnum = second?.GetEnumerator() ?? throw new ArgumentNullException(nameof(second));

            while (firstEnum.MoveNext())
            {
                if (!secondEnum.MoveNext() || !EqualityComparer<T>.Default.Equals(firstEnum.Current, secondEnum.Current))
                {
                    return false;
                }
            }

            return !secondEnum.MoveNext();
        }
    }
}
