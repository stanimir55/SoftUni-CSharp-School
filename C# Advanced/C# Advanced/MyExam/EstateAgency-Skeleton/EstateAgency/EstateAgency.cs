using EstateAgency;

namespace EstateAgency
{
    public class EstateAgency
    {
        public int Capacity { get; private set; }
        public List<RealEstate> RealEstates { get; private set; }
        public int Count => RealEstates.Count;

        public EstateAgency(int capacity)
        {
            Capacity = capacity;
            RealEstates = new List<RealEstate>();
        }

        public bool AddRealEstate(RealEstate realEstate)
        {
            if (Count >= Capacity || RealEstates.Any(x => x.Address == realEstate.Address))
            {
                return false;
            }

            RealEstates.Add(realEstate);
            return true;
        }

        public bool RemoveRealEstate(string address)
        {
            RealEstate realEstate = RealEstates.FirstOrDefault(x => x.Address == address);
            if (realEstate != null)
            {
                RealEstates.Remove(realEstate);
                return true;
            }
            return false;
        }

        public List<RealEstate> GetRealEstates(string postalCode)
        {
            return RealEstates.Where(x => x.PostalCode == postalCode).ToList();
        }

        public RealEstate GetCheapest()
        {
            return RealEstates.OrderBy(x => x.Price).FirstOrDefault();
        }

        public double GetLargest()
        {
            return RealEstates.Max(re => re.Size);
        }

        public string EstateReport()
        {
            return $"Real estates available:{Environment.NewLine}" +
                string.Join(Environment.NewLine, RealEstates);
        }
    }
}

