#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("jjpwVhWLVk89OAtIHxrsgmkVq5eb+x2mZDPeRAvEL7SYfcHgx7fKwxXFQOE8O+yVvuhiGwiB5gZ7thcod8VGZXdKQU5twQ/BsEpGRkZCR0S/EaF3og+b0i7mLUzuZEmne8rVJDkswT0bfXp88RxBRdo057sPcEccfWw5PtayjC7Yesc8N6/4WCdq1L1kKgCZpBF27dajpQXloj7T0eoiMFG9dbwSinnRaUCDnEkDoGFQKkwzxUZIR3fFRk1FxUZGR99W8+NpAbdNSW6qeGW1wVFSkGk4YGHXFIdElJlcVdHbChwvIeqG8Zrc/XqphN5VDdqs3mxcHVGZ13V0x1dqMdO6oWtWpofmXLSZi/t/GWtehqIuw8PE/z9sFgesjLEd+EVERkdG");
        private static int[] order = new int[] { 3,4,12,3,10,7,11,11,12,10,12,13,13,13,14 };
        private static int key = 71;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
