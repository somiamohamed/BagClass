public class Bag
{
    private string color;
    private int size;
    private bool hasStrap;
    private bool isWaterproof;
    private string material;
    private int numCompartments;
    private bool isInsulated;
    private string brand;

    public Bag()
    {
        color = "black";
        size = 10;
        hasStrap = true;
        isWaterproof = false;
        material = "nylon";
        numCompartments = 1;
        isInsulated = false;
        brand = "unknown";
    }

    public Bag(string c, int s)
    {
        color = c;
        size = s;
        hasStrap = true;
        isWaterproof = false;
        material = "nylon";
        numCompartments = 1;
        isInsulated = false;
        brand = "unknown";
    }

    public Bag(string c, int s, bool strap, bool waterproof, string mat, int compartments, bool insulated, string b)
    {
        color = c;
        size = s;
        hasStrap = strap;
        isWaterproof = waterproof;
        material = mat;
        numCompartments = compartments;
        isInsulated = insulated;
        brand = b;
    }

    public Bag(Bag other)
    {
        color = other.color;
        size = other.size;
        hasStrap = other.hasStrap;
        isWaterproof = other.isWaterproof;
        material = other.material;
        numCompartments = other.numCompartments;
        isInsulated = other.isInsulated;
        brand = other.brand;
    }

    public Bag(string b)
    {
        color = "black";
        size = 10;
        hasStrap = true;
        isWaterproof = false;
        material = "nylon";
        numCompartments = 1;
        isInsulated = false;
        brand = b;
    }

    public void AddCompartment()
    {
        if (numCompartments < 5)
        {
            numCompartments++;
            Console.WriteLine("Added compartment. New number of compartments: " + numCompartments);
        }
        else
        {
            Console.WriteLine("Cannot add more compartments.");
        }
    }

    public void RemoveCompartment()
    {
        if (numCompartments > 1)
        {
            numCompartments--;
            Console.WriteLine("Removed compartment. New number of compartments: " + numCompartments);
        }
        else
        {
            Console.WriteLine("Cannot remove more compartments.");
        }
    }

    public void ChangeColor(string newColor)
    {
        color = newColor;
        Console.WriteLine("Changed bag color to: " + color);
    }

    public bool CanFitItem(int itemSize)
    {
        return (itemSize <= (size / numCompartments));
    }

    public void PrintAttributes()
    {
        Console.WriteLine("Bag attributes:");
        Console.WriteLine("- Color: " + color);
        Console.WriteLine("- Size: " + size);
        Console.WriteLine("- Has strap: " + hasStrap);
        Console.WriteLine("- Is waterproof: " + isWaterproof);
        Console.WriteLine("- Material: " + material);
        Console.WriteLine("- Number of compartments: " + numCompartments);
        Console.WriteLine("- Is insulated: " + isInsulated);
    }
}