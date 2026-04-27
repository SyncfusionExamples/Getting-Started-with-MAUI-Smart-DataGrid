namespace SmartDataGridSample
{
	public class OrderInfo
	{
        private string orderID;
        private string customerID;
        private string customer;
        private string shipCity;
        private string shipCountry;

        public string OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { shipCountry = value; }
        }

        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set { shipCity = value; }
        }

        public OrderInfo(string orderId, string customerId, string customer, string country, string shipCity)
        {
            OrderID = orderId;
            CustomerID = customerId;
            Customer = customer;
            ShipCountry = country;
            ShipCity = shipCity;
        }
    }
}