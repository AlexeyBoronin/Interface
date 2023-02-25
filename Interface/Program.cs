using static System.Console;
/*WriteLine(IMovable.MaxSpeed);
IMovable.MaxSpeed = 65;
WriteLine(IMovable.MaxSpeed);
double time = IMovable.GetTime(500, 10);
WriteLine(time);

interface IMovable
{
    //константы
    public const int minSpeed = 0;
    //статическая переменная
    private static int maxSpeed = 60;
    //метод
    static double GetTime(double distance, double speed) => distance / speed;
    static int MaxSpeed
    {
        get => maxSpeed;
        set
        {
            if(value>0) maxSpeed = value;
        }
    }
    /*void Move()
    {
        WriteLine("Walking");
    }
    //свойство
    string Name { get; set; }
    delegate void MoveHandler(string message);
    //событие
    event MoveHandler MoveEvent;*/
//}
//IMovable m =new IMovable();
/*Human human = new Human();
Car car = new Car();
DoAction(human);
DoAction(car);

void DoAction(IMovable movable) => movable.Move();
interface IMovable
{
    void Move();
}
class Human : IMovable
{
    public void Move()
    {
        WriteLine("Человек идёт");
    }
}
struct Car:IMovable
{
    public void Move()
    {
        WriteLine("Машина едет");
    }

}
*/
/*IMovable ted = new Human();
Car kia = new Car();
ted.Move();
kia.Move();
interface IMovable
{
    void Move() => WriteLine("Walking");
}
class Human:IMovable { }
class Car : IMovable
{
    public void Move() => WriteLine("Driving");
}*/
/*Message hello = new Message("Hello world");
hello.Print();
interface IMessage
{
    string Text { get;set; }
}
interface IPrintable
{
    void Print();
}
class Message:IMessage,IPrintable
{
    public string Text { get; set; }
    public Message(string text)=>Text = text;
    public void Print() => WriteLine(Text);
}*/

IMessage hello = new Message("Hello");
WriteLine(hello.Text);
//не все объекты IMessage являются объектами Message, необходимо явное приведение
//Message someMessage = hello;
//Интерфейс IMessage не имеет свойcтва Print, необходимо явное приведение
//hello.Print();
//если hello представляет класс Message, выполняем преобразование
if(hello is Message someMessage1) someMessage1.Print();
interface IMessage
{
    string Text { get; set; }
}
interface IPrintable
{
    void Print();
}
class Message : IMessage, IPrintable
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
    public void Print() => WriteLine(Text);
}


