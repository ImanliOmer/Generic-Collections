using Generic_Collections.Models;

namespace Generic_Collections.ExxHelper
{
    static class Extensions
    {
        public static Student[] PointSort(this Student[] stu)
        {
            Student min_value = stu[0];
            for (int i = 0; i < stu.Length; i++)
            {
                for (int j = i + 1; j < stu.Length; j++)
                {
                    if (stu[i] > stu[j])
                    {
                        min_value = stu[j];
                        stu[j] = stu[i];
                        stu[i] = min_value;
                    }
                }
            }
            return stu;

        }
    }

}
