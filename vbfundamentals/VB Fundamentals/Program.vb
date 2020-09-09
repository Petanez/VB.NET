'   Option Strict On MUST be at the top                    should be on
Option Strict On
Imports System
Module Program
    '///////    BUILT-IN STRING METHODS ///////////////////////////////////
    'Sub Main(args As String())
    '    Dim Name As String = "10 Speed Bike"

    '    Console.WriteLine("Built-in String Methods")
    '    Console.WriteLine(Name.Length)
    '    Console.WriteLine(Name.IndexOf(" "))
    '    Console.WriteLine(Name.LastIndexOf(" "))
    '    Console.WriteLine(Name.EndsWith("e"))
    '    Console.WriteLine(Name.Insert(9, "Mountain "))
    '    Console.WriteLine(Name.Remove(0, 9))
    '    Console.WriteLine(Name.Replace("10", "12"))
    '    Console.WriteLine(Name.ToUpper())
    '    Console.WriteLine(Name.ToLower())
    'End Sub
    '//////////////////////////////////////////////////////////////////////


    '///////    BUILT-IN NUMERIC METHODS ///////////////////////////////////
    'Sub Main(args As String())
    '    Dim ListPrice As Decimal = 999.99D

    '    Console.WriteLine("Built-in Numberic Methods")
    '    Console.WriteLine(ListPrice.Equals(999.99D))
    '    Console.WriteLine(Decimal.MinValue)
    '    Console.WriteLine(Decimal.MaxValue)
    '    Console.WriteLine(Decimal.Ceiling(ListPrice))
    '    Console.WriteLine(Decimal.Floor(ListPrice))

    '    Decimal.TryParse(55.01, ListPrice)
    '    Console.WriteLine(ListPrice)

    '    Decimal.TryParse("55.01", ListPrice)
    '    Console.WriteLine(ListPrice)

    '    Decimal.TryParse("Fifty-Five", ListPrice)
    '    Console.WriteLine(ListPrice)

    'End Sub
    '//////////////////////////////////////////////////////////////////////


    '///////    Built-in DateTime Methods ///////////////////////////////////
    'Sub Main(args As String())
    '    Dim SellDate As DateTime

    '    SellDate = #1/1/2019 12:05:01 PM#

    '    Console.WriteLine("Built-in DateTime Methods")
    '    Console.WriteLine(SellDate.AddDays(10))
    '    Console.WriteLine(SellDate.AddDays(-10))
    '    Console.WriteLine(SellDate.AddYears(2))
    '    Console.WriteLine(SellDate.AddYears(-2))

    '    Console.WriteLine()
    '    Console.WriteLine(SellDate.Date) 'returns date and time will be set to midnight
    '    Console.WriteLine(SellDate.Day)
    '    Console.WriteLine(SellDate.DayOfWeek)
    '    Console.WriteLine(SellDate.Year)
    '    Console.WriteLine(SellDate.DayOfYear)

    '    Console.WriteLine()
    '    Console.WriteLine(SellDate.Hour)
    '    Console.WriteLine(SellDate.Minute)
    '    Console.WriteLine(SellDate.Second)

    'End Sub
    '//////////////////////////////////////////////////////////////////////



    '////// INCREMENT WITH STATIC KEYWORD ///////////////////////////////////////////////
    'Sub Main()
    '    IncrementListPrice()
    '    IncrementListPrice()
    '    IncrementListPrice()

    '    Console.ReadKey()
    'End Sub

    'Sub IncrementListPrice()
    '    '   When you use the static keyword its not gonna instantiate it again after the first time 
    '    '   even tho the method is called multiple times
    '    Static ListPrice As Decimal = 0D


    '    ListPrice += 1

    '    Console.WriteLine(ListPrice)
    'End Sub
    '///////////////////////////////////////////////////////////////////////////////////





    '////// USE OF OBJECT ///////////////////////////////////////////////
    'Sub Main()
    '    '   Object can hold any type of data
    '    '   Avoid using, it takes alot of memory and can cause problems
    '    Dim theData As Object

    '    theData = "10 Speed Bike"
    '    Console.WriteLine(theData)

    '    theData = 999.99
    '    Console.WriteLine(theData)

    '    theData = DateTime.Now
    '    Console.WriteLine(theData)

    '    theData = vbEmpty
    '    Console.WriteLine(theData)

    '    'DBNull.Value special value to store null to a database
    '    theData = DBNull.Value
    '    Console.WriteLine(theData)

    '    Console.ReadKey()
    'End Sub
    '///////////////////////////////////////////////////////////////////////////////////




    '/////// STRICT ON //////////////////////////////////////////////////////////////////
    'Sub Main()
    '    '   With strict off will do addition -> output 3
    '    '                                              12
    '    '   With strict on wont compile
    '    Dim s1 As Object
    '    Dim s2 As Object

    '    s1 = "1"
    '    s2 = 2
    '    Console.WriteLine(s1 + s2)

    '    s2 = "2"
    '    Console.WriteLine(s1 + s2)

    '    Console.ReadKey()
    'End Sub
    '///////////////////////////////////////////////////////////////////////////////////



    '/////// CONSTANTS, PRIVATE KEYWORD, CLASS, MODULE //////////////////////////////////////
    '   Private Keyword locks the method within this Module
    '   Best Practice of naming constants DEFAULT_ACTIVE
    'Private Const DEFAULT_ACTIVE As Boolean = True
    'Private Const DEFAULT_LIST_PRICE As Decimal = 999.99D

    'Sub Main()
    '    '   Works with public module which has public types
    '    'Dim isActive As Boolean = DEFAULT_ACTIVE

    '    'Class has to be referred by Class Name
    '    Dim isActive As Boolean = ClassConstants.DEFAULT_ACTIVE
    '    Dim Name As String = "10 Speed Bike"
    '    Dim ListPrice As Decimal

    '    ListPrice = ClassConstants.DEFAULT_LIST_PRICE

    '    Console.WriteLine(String.Format("Name: {0}{1}ListPrice: {2}", Name, Environment.NewLine, ListPrice))
    '    Console.ReadKey()
    'End Sub
    '///////////////////////////////////////////////////////////////////////////////////


    '/////// ARITHMETIC OPERATORS    //////////////////////////////////////
    'Sub Main()
    '    Dim ListPrice As Decimal = 999.99D

    '    'ListPrice += 200
    '    'Console.WriteLine(ListPrice)

    '    'ListPrice -= 100
    '    'Console.WriteLine(ListPrice)

    '    'ListPrice *= 2
    '    'Console.WriteLine(ListPrice)

    '    'ListPrice /= 3
    '    'Console.WriteLine(ListPrice)

    '    '   Integer Division
    '    '   opposite of modulus
    '    Console.WriteLine(5 \ 4)

    '    '   Modulus
    '    Console.WriteLine(10 Mod 3)

    '    '   Exponentiation
    '    Console.WriteLine(2 ^ 3)

    'End Sub
    '///////////////////////////////////////////////////////////////////////////////////


    '////////   RELATIONAL OPERATORS INCLUDE <>(not equal to) >(greater than) ////////////////////////////////
    '///////    LOGICAL OPERATORS                          //////////////////////////////////////
    'Sub Main()
    '    Dim ListPrice As Decimal = 999.99D
    '    Dim isActive As Boolean = True

    '    Console.WriteLine("And operator")
    '    '_ is a line continuation character
    '    Console.WriteLine(ListPrice < 900 _
    '            And ListPrice <= 999.99)

    '    Console.WriteLine("Or operator")
    '    Console.WriteLine(ListPrice > 900 _
    '            Or ListPrice <= 999.99)

    '    Console.WriteLine("Not operator")
    '    Console.WriteLine(Not isActive)
    'End Sub
    '///////////////////////////////////////////////////////////////////////////////////


    '///////    Order of Precedence       //////////////////////////////////////
    Sub Main()
        Dim ListPrice As Decimal = 900D

        '   Evaluated as ListPrice + (1 * 2)
        Console.WriteLine(ListPrice + 1 * 2)

        '   Evaluated as 1 + (ListPrice * 2)
        Console.WriteLine(1 + ListPrice * 2)
        Console.WriteLine((ListPrice + 1) * 2)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
End Module
