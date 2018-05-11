namespace WindowsFormsApp1
{
    public class Deliverable
    {
        #region fields

        private Person buyer;
        private int id;
        private int weight;

        #endregion

        #region properties

        public int Id
        {
            get { return id; }
        }

        public int Weight { get; }
        public Person Buyer { get; }

        #endregion

        #region constructor

        public Deliverable(int id, int weight, Person buyer)
        {

        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return "name";
        }

        #endregion


    }
}