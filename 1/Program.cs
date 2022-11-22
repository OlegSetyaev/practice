Console.WriteLine("Введите дистанцию между друзьями: ");
int distance =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость первого друга: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость второго друга: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость собаки: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int friend = 2;
int count = 0;
int time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count = count + 1;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count = count + 1;
    }
}
Console.WriteLine("Собака пробежит " + count + " раз!");
