class Program1
{
    static void Main()
    {
        // called the constructors

        // 1) Usa el constructor sin parámetros
        Person p1 = new Person();
        p1.ShowInfo();   // " Anonymous Unknown"

        // 2) Usa el constructor con nombre y apellido
        Person p2 = new Person("Jane", "Doe");
        p2.ShowInfo();   // 👉 Muestra: " Jane Doe"

        // 3) Usa el constructor con título, nombre y apellido
        Person p3 = new Person("Mrs.", "Jane", "Doe");
        p3.ShowInfo();   // 👉 Muestra: "Mrs. Jane Doe"
    }
}