#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("ZXl+Y3hlaCAHIQUXEkQVEgIcUGEkIyAlISInSwYcIiQhIyEoIyAlIQ6Ayg9WQfoU/E9olTz6J7NGXUT9eHd4cnBleH5/MVBkZXl+Y3hlaCBmZj9wYWF9dD9yfnw+cGFhfXRycJoImM/oWn3kFrozIRP5CS/pQRjCurJgg1ZCRNC+PlCi6eryYdz3sl1/dTFyfn91eGV4fn9iMX53MWRidH10MVh/cj8gNyE1FxJEFRoCDFBhdp4ZpTHm2r09MX5hpy4QIZ2mUt4sN3YxmyJ75hyT3s/6sj7oQntKdSEAFxJEFRsCG1BhYX10MVh/cj8gIZMVqiGTErKxEhMQExMQEyEcFxgXEkQMHxUHFQU6wXhWhWcY7+V6nEi2FBhtBlFHAA9lwqaaMipWssR+kxARFxg7l1mX5nJ1FBAhkOMhOxemCqyCUzUDO9YeDKdcjU9y2VqRBnN9dDFiZXB/dXBjdTFldGN8YjFwPiGQ0hcZOhcQFBQWExMhkKcLkKIOlJKUCogsVibjuIpRnz3FoIEDyZ5ikHHXCkoYPoOj6VVZ4XEpjwTkQ3R9eHB/cnQxfn8xZXl4YjFydGMZTyGTEAAXEkQMMRWTEBkhkxAVIaQrvOUeHxGDGqAwBz9lxC0cynMHoCFJ/UsVI515op4Mz3Ri7nZPdK07l1mX5hwQEBQUESFzIBohGBcSRBQREpMQHhEhkxAbE5MQEBH1gLgYFyEeFxJEDAIQEO4VFCESEBDuIQxhfXQxUnRjZXh3eHJwZXh+fzFQZBk6FxAUFBYTEAcPeWVlYWIrPj5mMX53MWV5dDFleXR/MXBhYX14cnBjcHJleHJ0MWJlcGV0fHR/ZWI/Ia/lYor/w3Ue2mheJcmzL+hp7nrZNfP6wKZhzh5U8Dbb4Hxp/PakBgbIJ27QlkTItoioI1PqycRgj2+wQ2gxcGJiZHx0YjFwcnJ0YWVwf3J0uc1vMyTbNMTIHsd6xbM1MgDmsL1leHd4cnBldDFzaDFwf2gxYXBjZVRvDl16QYdQmNVlcxoBklCWIpuQHBcYO5dZl+YcEBAUFBESkxAQEU0VFwITREIgAiEAFxJEFRsCG1BhYT9Rt+ZWXG4ZTyEOFxJEDDIVCSEHMVJQIZMQMyEcFxg7l1mX5hwQEBBYyWeOIgV0sGaF2DwTEhARELKTENgIY+RMH8RuTorjNBKrRJ5cTBzgYX10MUN+fmUxUlAhDwYcISchJSMxcH91MXJ0Y2V4d3hycGV4fn8xYZEFOsF4VoVnGO/lepw/UbfmVlxuhI9rHbVWmkrFByYi2tUeXN8FeMAiJ0shcyAaIRgXEkQVFwITREIgAm5QuYnowNt3jTV6AMGyqvUKO9IOPTFydGNleHd4cnBldDFhfn14cmh1JDIEWgRIDKKF5ueNj95Bq9BJQR6MLOI6WDkL2e/fpKgfyE8Nx9osFv1sKJKaQjHCKdWgroteG3ruOu3RciJm5isWPUf6yx4wH8urYghepCeIXTxppvydis3iZorjZ8NmIV7QayGTEGchHxcSRAweEBDuFRUSExA3ITUXEkQVGgIMUGFhfXQxUnRjZQchBRcSRBUSAhxQYWF9dDFDfn5lQbubxMv17cEYFiahZGQw");
        private static int[] order = new int[] { 5,7,15,11,36,16,24,43,11,21,56,21,16,30,52,34,59,42,37,49,55,38,33,23,26,43,52,29,36,35,41,46,50,53,58,40,54,39,43,47,58,46,46,58,49,52,52,50,50,58,52,58,55,53,58,57,57,58,58,59,60 };
        private static int key = 17;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
