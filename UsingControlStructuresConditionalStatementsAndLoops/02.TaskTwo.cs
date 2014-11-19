using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPCHomeworkConditionalStatementsLoops
{
    class TaskTwo
    {
        public void CookPotato()
        {
            Potato potato;
            //... 
            if (potato != null)
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
                   

        }

        public void Shit()
        {
            bool isXInsideTheField = (MIN_X <= x && x <= MAX_X);
            bool isYInsideTheField = (MIN_Y <= y && y <= MAX_Y);
            bool isInsideTheField = isXInsideTheField && isYInsideTheField;

            if (isInsideTheField && !shouldNotVisitCell)))
            {
               VisitCell();
            }

        }
    }
}
