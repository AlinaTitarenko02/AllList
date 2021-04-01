using System;
using ListsProject;

namespace ListsProjectManualTests
{
    class Program
    {
        static void Main()
        {
            ArrayList arrList = new ArrayList(new [] {1, 2, 3, 4, 6});
            ArrayList arrList2 = new ArrayList(new []{ 1, 2, 6 });
            arrList.AddListByIndex(2,arrList2);
            arrList.Print();

        }
    }
}
