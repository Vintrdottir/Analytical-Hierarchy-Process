using System.Collections.Generic;


namespace AHP
{
    public class Parameter
    {
        public string name { get; set; }
        public double localWeight { get; set; }
        public double globalWeight { get; set; }
        public int level { get; set; }
        public Queue<Parameter> parents { get; set; }
        public List<Parameter> children { get; set; }
        public bool hasParent
        {
            get
            {
                if (parents != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool hasChild
        {
            get
            {
                if (children != null)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
