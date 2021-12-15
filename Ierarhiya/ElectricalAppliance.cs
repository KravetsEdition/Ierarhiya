using System;

public abstract class WorksTool
{ // работа инструмента
    public abstract void start();

    public void work()
    {
        Console.WriteLine("Инструмент выполняет работу");
    }
    
    public abstract void end();
}

public interface RequirementsTools // требования к инструменту
{
    String getName();
    String getModel();
}

public class ElectricInstrument : WorksTool
{
    private String name;
    private String model;
    private bool active;

    protected ElectricInstrument(string name, string model, bool active) // конструктор
    {
        this.name = name;
        this.model = model;
        this.active = active;
    }
    
    public ElectricInstrument() // пустой
    {
        name = null;
        model = null;
        active = false;
    }
    
    ~ElectricInstrument() // деструктор
    {
        Console.WriteLine("Объект уничтожен");
    }

    public string Name => name;

    public string Model => model;

    public bool Active => active;

    public override void start() // абстрактные метод старта
    {
        if (!active)
        {
            Console.WriteLine("Електро інструмент " + name + " " + model + " почав виконувати дію");
            active = true;
        }
        else
        {
            Console.WriteLine("Електро інструмент уже виконує дію");
        }
    }

    public override void end()
    {
        if (active)
        {
            Console.WriteLine("Електро інструмент " + name + " " + model + " закінчив виконувати дію");
            active = false;
        }
        else
        {
            Console.WriteLine("Електро інструмент ще не виконує дію");
        }
    }
}

public class KitchenInstrumentsSaveProducts : ElectricInstrument // для сохранения продуктов
{
    private int minTemp, maxTemp;
    private String type;
    private int capacity;
    private bool freezer;
    
    public KitchenInstrumentsSaveProducts(string name, string model, bool active, 
        int minTemp, int maxTemp, string type, int capacity,bool freezer) : base(name, model, active)
    {
        this.minTemp = minTemp;
        this.maxTemp = maxTemp;
        this.type = type;
        this.capacity = capacity;
        this.freezer = freezer; 
    }

    public int MinTemp => minTemp;

    public int MaxTemp => maxTemp;

    public string Type => type;

    public int Capacity => capacity;

    public bool Freezer => freezer;
}

// public class Refrigerator : KitchenInstrumentsSaveProducts
// {
//     
//     public Refrigerator(string name, string model, bool active, int minTemp, int maxTemp, string type, int capacity) : base(name, model, active, minTemp, maxTemp, type, capacity)
//     {
//         
//     }
// }

public class KitchenInstrumentsMechanicalRestoration : ElectricInstrument // для механической обработки
{
    private int minSpeed, maxSpeed;
    private bool portable; 
    private String typeNozzle; // тип насадки

    public KitchenInstrumentsMechanicalRestoration(string name, string model, bool active, int minSpeed, int maxSpeed, bool portable, string typeNozzle) : base(name, model, active)
    {
        this.minSpeed = minSpeed;
        this.maxSpeed = maxSpeed;
        this.portable = portable;
        this.typeNozzle = typeNozzle;
    }
}
