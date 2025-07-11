using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems
{
    internal class BinarySearch
    {
        //[0,1,2,3,4,6,7,8,9,10,11,12,13]
        public static int BinarySearchFindMissing(int [] array)
        {
            int startIndex,endIndex,mid ;
            startIndex=0; 
            endIndex=array.Length - 1;
            mid = (startIndex + endIndex) / 2;
            while (mid>1 && mid<array.Length)
            { 
                if (array[mid] - array[mid - 1] > 1)
                    return array[mid] - 1;//the missing number
                if (array[mid]>mid)
                    endIndex = mid;
                else
                    startIndex = mid;   
                mid = (startIndex + endIndex) / 2;
            }
            return 0;


        }


    }
}
