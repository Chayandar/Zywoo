//Задание 1
//Создайте класс, описывающий данные человека (Person). Поля – ФИО, возраст и пол. Также
//должен быть метод для вывода данных в командную строку. Это будет класс с данными.
//Создайте класс (ListQueue), имитирующий работу очереди (принцип FIFO) на основе
//односвязного списка. Объект этого класса должен представлять собой объект очереди, в который
//можно добавлять данные (объект Person) и получать по очереди (с «удалением» из очереди).
//Внутри класса-очереди создайте класс элемента очереди (Element), в котором будут поля:
// объект данных(Person data);
// следующий элемент списка (Element next).
//А сам класс очереди (ListQueue) будет содержать:
// приватное поле начала очереди (Element head)
// метод для добавления данных в список;
// метод для получения данных из списка (с удалением выданного элемента). Если
//список пустой, то он должен адекватно реагировать на попутку получить из него
//элемент.
//Реализуйте интерфейс работы со списком. Пользователь должен иметь возможность:
// Добавлять элемент в список
// Получить элемент из списка






ListQueue list = new ListQueue();
while (true)
{
    Console.WriteLine("Выберите действие");
    Console.WriteLine("1 - добавить \n2 - вывести");
    int n = Convert.ToInt32(Console.ReadLine());
    switch (n)
    {
        case 1:
            Console.WriteLine("Введите имя:");
            string f = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Пол:");
            bool m = bool.Parse(Console.ReadLine());
            Person person = new(f, a, m);
            list.add(person);
            break;
        case 2:
            list.get().Print();

            break;
        default:
            Console.WriteLine("default");
            break;
    }
}

//while (true)
//{
//    ListQueue list = new ListQueue();
//    Console.WriteLine("Выберите действие");
//    Console.WriteLine("1 - действие \n2 - вывести");
//    int n = Convert.ToInt32(Console.ReadLine());
//    switch (n)
//    {
//        case 1:
//            Person person = new("Tom", 14, true);
//            list.add(person);
//            break;
//        case 2:

//            break;
//        default:
//            Console.WriteLine("default");
//            break;
//    }

//}