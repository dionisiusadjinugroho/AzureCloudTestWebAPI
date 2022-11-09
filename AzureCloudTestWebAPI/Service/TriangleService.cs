using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCloudTestWebAPI.Service
{
    public class TriangleService : ITriangleService
    {

        public string GetCategoryTriangle(decimal sideA = 0, decimal sideB = 0, decimal sideC = 0)
        {
            string Category = "";
            List<decimal> allsides = new List<decimal>()
            {
                sideA,sideB,sideC
            };

            var zeroExist = allsides.FindIndex(x => x == 0);
            if (zeroExist != -1)
            {
                Category = EnumBase.SideCategory.Invalid.GetEnumDescription();
                return Category;
            }

            var maxSides = allsides.Max(x => x);
            var sumOf2SmallerSides = allsides.Sum(x => x) - maxSides;
            if (maxSides >= sumOf2SmallerSides)
            {
                Category = EnumBase.SideCategory.Invalid.GetEnumDescription();
                return Category;
            }

            var samesides = allsides.GroupBy(x => x).Where(y => y.Count() > 1).Select(z => new { Element = z.Key, Counter = z.Count() }).FirstOrDefault();

            //Calculate All Corner Degrees
            List<decimal> alldegrees = new List<decimal>();
            for (int i = 0; i < allsides.Count; i++)
            {
                int indexA = i;
                int indexB = i + 1;
                int indexC = i + 2;
                if (indexB > 2)
                {
                    indexB = Math.Abs(indexB - 3);
                }
                if (indexC > 2)
                {
                    indexC = Math.Abs(indexC - 3);
                }
                var degrees = Math.Round(CornerDegrees(allsides[indexA], allsides[indexB], allsides[indexC]), 2);
                alldegrees.Add(degrees);
            }

            if (samesides != null)
            {
                if (samesides.Counter == 3)
                {
                    Category = EnumBase.SideCategory.Equilateral.GetEnumDescription();
                    return Category;
                }
                if (samesides.Counter == 2)
                {
                    Category = EnumBase.SideCategory.Isosceles.GetEnumDescription();
                }
            }
            else
            {
                Category = EnumBase.SideCategory.Scalene.GetEnumDescription();
            }

            var checkRightTriangle = alldegrees.FindIndex(x => x == 90);
            if (checkRightTriangle != -1)
            {
                Category = string.Format("{0} {1}", EnumBase.CornerCategory.Right.GetEnumDescription(), Category);
                return Category;
            }
                
                

            var checkObtuseTriangle = alldegrees.FindIndex(x => x > 90);
            if (checkObtuseTriangle != -1)
            {
                Category = string.Format("{0} {1}", EnumBase.CornerCategory.Obtuse.GetEnumDescription(), Category);
                return Category;
            }


            Category = string.Format("{0} {1}", EnumBase.CornerCategory.Acute.GetEnumDescription(), Category);
            return Category;
        }

        public decimal CornerDegrees(decimal a, decimal b, decimal c)
        {
            var calculate = (a * a + b * b - c * c) / (2 * a * b);
            var degrees = Math.Acos((double)calculate) * 180 / Math.PI;
            return Convert.ToDecimal(degrees);
        }
    }
}
