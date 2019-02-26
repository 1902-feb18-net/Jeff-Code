using System;
using System.Collections.Generic;

namespace CollectionTesting.Library
{
    public class MyStringCollection
    {
        // Use a private or protected field to store a 
        // List<string> to handle all the list operations 
        // Implement some collection methods like Add, 
        // Contains, Remove, etc. that are not already on the list. 
        protected List<string> _list = new List<string>();

        public void Add(string value)
        {
            _list.Add(value);
        }

        public void Contains(string value)
        {
            
        }

    }
}
