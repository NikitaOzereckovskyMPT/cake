namespace cakes
{
    public class Data
    {
        static public Item[] types_forms = new Item[] { new Item("Круглый", 10), new Item("Овальный", 20), new Item("Квадратный", 15) };
        static public Item[] types_sizes = new Item[] { new Item("Маленький", 10), new Item("Средний", 20), new Item("Большой", 30) };
        static public Item[] types_tastes = new Item[] { new Item("Малиновый", 10), new Item("Ананасовый", 20), new Item("Грушевый", 15) };
        static public Item[] types_glasurs = new Item[] { new Item("Шоколадная", 20), new Item("Ванильная", 15), new Item("Карамельная", 10) };
        static public Item[] types_decors = new Item[] { new Item("Радужная посыпка", 10), new Item("Орешки", 15), new Item("Пудра", 20) };
        static public string[] menu = new string[] { "Форма", "Размер", "Вкус", "Глазурь", "Декор", "Количество", "Выполнить заказ" };
        public static int get_lenght(int id)
        {
            switch (id)
            {
                case 0: return types_forms.Length;
                case 1: return types_sizes.Length;
                case 2: return types_tastes.Length;
                case 3: return types_glasurs.Length;
                case 4: return types_decors.Length;
                case 5: return menu.Length;
            }
            return 0;
        }
    }
}