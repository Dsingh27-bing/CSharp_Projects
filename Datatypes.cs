namespace UnderstandingTypes;

public class Datatypes
{
    public void Datatype_values(){
        
        Console.WriteLine("{0,-8}  {1,8} {2,30} {3,30}", "Datatype", "Size", "MinValue", "MaxValue" );
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","sbyte",sizeof(SByte),SByte.MinValue, SByte.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}", "sbyte", sizeof(SByte) , SByte.MinValue, SByte.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","byte",sizeof(Byte),Byte.MinValue, Byte.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","short",sizeof(Int16),Int16.MinValue,Int16.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","ushort",sizeof(UInt16),UInt16.MinValue,UInt16.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","Int",sizeof(Int32),Int32.MinValue,Int32.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","UInt",sizeof(UInt32),UInt32.MinValue,UInt32.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}", "Long", sizeof(Int64), Int64.MinValue, Int64.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","ulong",sizeof(UInt64),UInt64.MinValue,UInt64.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","Float",sizeof(float),float.MinValue,float.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","Double",sizeof(Double),Double.MinValue,Double.MaxValue);
        Console.WriteLine("{0,-8}: {1,8} bytes {2,30} {3,30}","Decimal",sizeof(Decimal),Decimal.MinValue,Decimal.MaxValue);
    }
}