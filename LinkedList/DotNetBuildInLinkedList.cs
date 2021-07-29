using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class DotNetBuildInLinkedList
    {
      
            public static void DemoLinkedListFeatures()
            {
                string[] words = { "the", "actor", "jumped", "over", "the" };

                LinkedList<string> sentacence = new LinkedList<string>(words);
              //  Display(sentacence, "The Linked list values");

            sentacence.AddFirst("today");
            //Display(sentacence, "The Linked list values");

        }

    }
}
