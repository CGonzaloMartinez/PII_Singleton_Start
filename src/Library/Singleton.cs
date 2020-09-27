using System;
using Library;

namespace Library
{
    public class Singleton <T> where T : new()
    {
        private static T instance {get; set; }
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }

    }
}