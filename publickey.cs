using System;

namespace filter_value
{
    public class TestObject
    {
        public string Name { get; set; }

    }



    public static class PublicKey
    { 
        public static TestObject GetTestObject()
        {
            
            return new TestObject()
            {
                Name = "TestObe"
            };

        }

        public static string[] Args = null;


        public static string find_value(string q, string def = null)
        {
            if (Args == null)
            {
                return null;
            }
            for (int i = 0; i < Args.Length; i++)
            {
                if (Args[i] == q)
                {
                    if (i + 1 < Args.Length)
                    {
                        return Args[i + 1];
                    }
                }
            }
            if (def != null)
            {
                return def;
            }
            throw new Exception($"you need {q} key and value");

        }
    }
}
