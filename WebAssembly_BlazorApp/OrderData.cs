namespace WebAssembly_BlazorApp
{
    public class OrderData
    {
        public static List<OrderData> Orders = new List<OrderData>();
        public OrderData()
        {

        }
        public OrderData(int? OrderID, string CustomerID, DateTime? OrderDate, double? Freight)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.OrderDate = OrderDate;
            this.Freight = Freight;
        }
        public static List<OrderData> GetAllRecords()
        {
            if (Orders.Count() == 0)
            {
                int code = 10;
                for (int i = 1; i < 2; i++)
                {
                    Orders.Add(new OrderData(10248, "VINET", new DateTime(1996, 07, 07), 32.38));
                    Orders.Add(new OrderData(10249, "TOMSP", new DateTime(1996, 07, 07), 92.38));
                    Orders.Add(new OrderData(10250, "HANAR", new DateTime(1996, 07, 07), 62.77));
                    Orders.Add(new OrderData(10251, "VICTE", new DateTime(1996, 07, 07), 12.38));
                    Orders.Add(new OrderData(10252, "SUPRD", new DateTime(1996, 07, 07), 82.38));
                    Orders.Add(new OrderData(10253, "CHOPS", new DateTime(1996, 07, 07), 31.31));
                    Orders.Add(new OrderData(10254, "RICSU", new DateTime(1996, 07, 07), 22.37));
                    Orders.Add(new OrderData(10255, "WELLI", new DateTime(1996, 07, 07), 44.34));
                    Orders.Add(new OrderData(10256, "RICSU", new DateTime(1996, 07, 07), 31.33));
                    code += 5;
                }
            }
            return Orders;
        }
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }
    }
}
