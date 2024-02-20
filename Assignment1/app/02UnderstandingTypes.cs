namespace app1;
class UnderstandingTypes
{
    public void UnderstandingType()
    {
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("Data Type: {0}, Bytes: {1}, Minimum Value: {2}, Maximum Value: {3}",
            typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
}

