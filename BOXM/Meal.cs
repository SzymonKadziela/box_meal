using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOXM
{
    public class Meal
    {
        public string Name { get; set; }
        public List<Component> Component { get; set; }
        public int Kcal
        {
            get
            {
                int kcal = 0;
                foreach(Component ing in Component)
                {
                    kcal = kcal + ing.Kcal;
                }
                return kcal;
            }
        
        }




    }
}
