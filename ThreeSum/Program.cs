using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Length:"); 
            int arrayLength = 0;
            int.TryParse(Console.ReadLine(), out arrayLength);
            int[] nums = new int[arrayLength];
            Console.WriteLine("Enter Array Content:");
            for(int i=0; i<arrayLength; ++i)
            {
                   int.TryParse(Console.ReadLine(),out nums[i]);
            }
            IList<IList<int>> answer =  ThreeSum(nums);
            foreach(var arrays in answer)
            {
                foreach(var num in arrays)
                {
                    Console.Write(num+",");
                }
                Console.WriteLine();
            }                       
            Console.ReadLine();
            return;
        }
        static IList<IList<int>> ThreeSum(int[] nums)
        {
            int[] array = new int[3];
            int difference = 0;
            string arrayString = string.Empty;
            List<string> stringList = new List<string>();
            List<IList<int>> answerArray = new List<IList<int>>();
            List<int> firstLayer = new List<int>();
            for(int i=0; i<nums.Length-2; ++i)
            {
                if(!firstLayer.Contains(nums[i]))
                {
                    firstLayer.Add(nums[i]);
                for(int j=i+1; j<nums.Length-1; ++j)
                {    
                    List<int> secondLayer = new List<int>();
                    difference = 0 - nums[i] - nums[j];
                    if(!secondLayer.Contains(nums[j]))
                    {
                            secondLayer.Add(nums[j]);
                    for(int k=j+1; k<nums.Length; ++k)
                    {
                        if(nums[k] == difference)
                        {    
                            array[0] = nums[i];
                            array[1] = nums[j];
                            array[2] = difference;
                            Array.Sort(array);
                            arrayString = string.Join("",array);
                            if(!stringList.Contains(arrayString))
                            {    
                                stringList.Add(arrayString);
                                answerArray.Add(array);
                                array = new int[3];
                            }
                            break;
                        }
                    }
                    }
                }
                }
            }
            return answerArray;
        } 
    }
}
