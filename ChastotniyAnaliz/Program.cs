public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Сначала введите количество пар участников, а потом голоса за них: ");
        List<Int16> Virables = new List<Int16>();
        // создаю массив и лист для ввода новых значений

        for (Int32 i = Int32.Parse(Console.ReadLine()); i > 0; i--)
        Virables.Add(Int16.Parse(Console.ReadLine()));
        // ввод новых значений
        
        foreach (var Line in from g in Virables group g by g into ng orderby ng.Key select new
            {
                Count = ng.Count(),
                Key = ng.Key
            })
        //подсчет голосов
            Console.WriteLine("Команда {0} набрала: {1}", Line.Key, Line.Count);
            Console.ReadKey();
    }
}
