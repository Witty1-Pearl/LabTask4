
namespace ParkingCustomers
{
    public class Customers
    {
        const double MIN_CHARGE = 2.0;
        const int BASIC_HOURS = 3;
        const double SURCHARGE = 0.5;
        const double MAX_CHARGE = 10.0;
        const int MAX_HOURS = 24;
        private double _hours;

        public Customers (double hours)
        {
            Hours = hours;
        }

        public double Hours 
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 24)
                        _hours = 0;
                else
                    _hours = value;

            } 
        }

        public double CalculateCharges()
        {
            double totalCharge;

            if (Hours <= 3)
            totalCharge = Hours * MIN_CHARGE;
            else
                totalCharge = (MIN_CHARGE * 3) + ((Hours - 3) * (MIN_CHARGE + SURCHARGE));
            
            if (totalCharge > MAX_CHARGE)
            totalCharge = MAX_CHARGE;

            return totalCharge;
        }
    }
        
}