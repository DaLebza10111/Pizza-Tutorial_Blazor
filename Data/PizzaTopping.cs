namespace BlazingPizza.Data
{
    public class PizzaTopping
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public object PizzaId { get; internal set; }
        public object ToppingId { get; internal set; }
        public object Topping { get; internal set; }
    }
}
