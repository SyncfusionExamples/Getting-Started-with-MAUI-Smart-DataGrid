using Syncfusion.Maui.AIAssistView;
using System.Collections.ObjectModel;

namespace SmartDataGridSample
{
	public class OrderInfoRepository
	{
		private ObservableCollection<OrderInfo> orderInfo;
		public ObservableCollection<OrderInfo> OrderInfoCollection
		{
			get { return orderInfo; }
			set { orderInfo = value; }
		}

        public ObservableCollection<ISuggestion> Suggestions { get; set; } = new ObservableCollection<ISuggestion>
        {
            new AssistSuggestion() {Text = "Highlight customer names that appear more than once."},
            new AssistSuggestion() {Text = "List all Order IDs shipped to London."},
            new AssistSuggestion() {Text = "Which city has the maximum orders?"}
        };

        public OrderInfoRepository()
		{
			orderInfo = new ObservableCollection<OrderInfo>();
            GenerateOrders();
		}

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo("1001", "MA0024", "Maria Anders", "Germany", "Berlin"));
            orderInfo.Add(new OrderInfo("1002", "AT0165", "Ana Trujillo", "Mexico", "Mexico D.F."));
            orderInfo.Add(new OrderInfo("1003", "AF0006", "Ant Fuller", "Mexico", "Mexico D.F."));
            orderInfo.Add(new OrderInfo("1004", "TH0280", "Thomas Hardy", "UK", "London"));
            orderInfo.Add(new OrderInfo("1005", "TA0058", "Tim Adams", "Sweden", "Gothenburg"));
            orderInfo.Add(new OrderInfo("1006", "HM0012", "Hanna Moos", "Germany", "Mannheim"));
            orderInfo.Add(new OrderInfo("1007", "AF0037", "Andrew Fuller", "France", "Strasbourg"));
            orderInfo.Add(new OrderInfo("1008", "MK0138", "Martin King", "Spain", "Madrid"));
            orderInfo.Add(new OrderInfo("1009", "LL0015", "Lenny Lin", "France", "Marseille"));
            orderInfo.Add(new OrderInfo("1010", "JC0126", "John Carter", "Canada", "Ottawa"));
            orderInfo.Add(new OrderInfo("1011", "LK0045", "Laura King", "UK", "London"));
            orderInfo.Add(new OrderInfo("1012", "AW0134", "Anne Wilson", "Germany", "Mannheim"));
            orderInfo.Add(new OrderInfo("1013", "MK0055", "Martin King", "France", "Strasbourg"));
            orderInfo.Add(new OrderInfo("1014", "GI0092", "Gina Irene", "UK", "London"));
        }
    }
}