using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class TransportCompany
    {
        private List<Deliverable> myDeliverable;
        private List<Person> persons;

        public List<Deliverable> Deliverables
        {
            get { return myDeliverable; }
        }

        private List<Person> Persons
        {
            get { return persons; }
        }
        #region constructor
        public TransportCompany()
        {

        }
        #endregion

        #region Methods

        public void AddDeliverable(Deliverable d)
        {

        }

        public void AddPerson(Person p)
        {

        }

        public void FindDeliverable(int id)
        {

        }

        public void FindPerson(int id)
        {

        }

        public void LoadDeliverablesFromFile(string filename)
        {

        }

        public void LoadPersonsFromFile(string filename)
        {

        }

        public void SortByAddress()
        {

        }

        public void SortById()
        {

        }

        public void SortByWeight()
        {

        }

        public void SortForPostMan()
        {

        }


        #endregion


    }
}
