using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AcmeApp.Helpers
{
    public static class AssertionConcern
    {
        public static bool IsSatisfiedBy(params DomainNotification[] validations)
        {
            var notificationsNotNull = validations.Where(validation => validation != null);
            NotifyAll(notificationsNotNull);

            return notificationsNotNull.Count().Equals(0);
        }

        private static void NotifyAll(IEnumerable<DomainNotification> notifications)
        {
            notifications.ToList().ForEach(DomainEvent.Raise);
        }

        public static DomainNotification AssertLength(string stringValue, int minimum, int maximum, string message)
        {
            int length = stringValue == null ? 0 : stringValue.Trim().Length;

            return (length < minimum || length > maximum) ?
                new DomainNotification("AssertArgumentLength", message) : null;
        }

        public static DomainNotification AssertFixedLength(string stringValue, int size, string message)
        {
            int length = stringValue == null ? 0 : stringValue.Trim().Length;

            return (length != size) ?
                new DomainNotification("AssertArgumentFixedLength", message) : null;
        }

        public static DomainNotification AssertMatches(string pattern, string stringValue, string message)
        {
            Regex regex = new Regex(pattern);

            return (!regex.IsMatch(stringValue)) ?
                new DomainNotification("AssertArgumentLength", message) : null;
        }

        public static DomainNotification AssertNotNullOrEmpty(string stringValue, string message)
        {
            return (string.IsNullOrEmpty(stringValue)) ?
                new DomainNotification("AssertArgumentNotEmpty", message) : null;
        }

        public static DomainNotification AssertDateTimeNull(DateTime? dataValue, string message)
        {
            return (DateTime.MinValue == dataValue || dataValue == null) ?
                new DomainNotification("AssertDateTimeNull", message) : null;
        }

        public static DomainNotification AssertNotNull(object object1, string message)
        {

            return (object1 == null) ?
                new DomainNotification("AssertArgumentNotNull", message) : null;
        }

        public static DomainNotification AssertTrue(bool boolValue, string message)
        {
            return (!boolValue) ?
                new DomainNotification("AssertArgumentTrue", message) : null;
        }

        public static DomainNotification AssertAreEquals(string value, string match, string message)
        {
            return (!(value == match)) ?
                new DomainNotification("AssertArgumentTrue", message) : null;
        }

        public static DomainNotification AssertArgumentRange(long value, long minimum, long maximum, string message)
        {
            return (value < minimum || value > maximum) ?
                new DomainNotification("AssertArgumentRange", message) : null;
        }
        public static DomainNotification AssertArgumentRange(int value, int minimum, int maximum, string message)
        {
            return (value < minimum || value > maximum) ?
                new DomainNotification("AssertArgumentRange", message) : null;
        }
        public static DomainNotification AssertArgumentRange(float value, float minimum, float maximum, string message)
        {
            return (value < minimum || value > maximum) ?
                new DomainNotification("AssertArgumentRange", message) : null;
        }
        public static DomainNotification AssertArgumentRange(decimal value, decimal minimum, decimal maximum, string message)
        {
            return (value < minimum || value > maximum) ?
                new DomainNotification("AssertArgumentRange", message) : null;
        }
        public static DomainNotification AssertArgumentRange(double value, double minimum, double maximum, string message)
        {
            return (value < minimum || value > maximum) ?
                new DomainNotification("AssertArgumentRange", message) : null;
        }

        public static DomainNotification AssertIsGreaterThan(int value1, int value2, string message)
        {
            return (!(value1 > value2)) ?
                new DomainNotification("AssertArgumentTrue", message) : null;
        }

        public static DomainNotification AssertIsGreaterThan(decimal value1, decimal value2, string message)
        {
            return (!(value1 > value2)) ?
                new DomainNotification("AssertArgumentTrue", message) : null;
        }

        public static DomainNotification AssertIsGreaterOrEqualThan(int value1, int value2, string message)
        {
            return (!(value1 >= value2)) ?
                new DomainNotification("AssertArgumentTrue", message) : null;
        }

    }
}
