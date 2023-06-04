namespace Illustro.DBContext
{
    public class ProductionOrderItemStatuses
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Station { get; set; }
        public string? Operators { get; set; }
        public int ProductionOrderElement_Id { get; set; }
    }
}
