using System;

namespace Pkg
{
    public class Class1
    {
        public int Covered(int input)
        {
            if(input % 3 == 1)
                return -1;
            
            if(input % 3 == 2)
                return 1;

            return 0;
        }

        public string NotCovered()
        {
            return null;
        }
    }
}
