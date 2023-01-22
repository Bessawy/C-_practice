using System;
using System.Diagnostics;
using System.Globalization;

//-----------------------------------------------------------------------
// Strings are immutable so their value is not changed but replace
// How to create a string?
Console.WriteLine("----String----------------");
string str_1 = "this is a string";
string str_2 = new String(new char[]{'a', 'b','c'});
Console.WriteLine($"str_2 = {str_2}");
string str_3 = new String('*', 4);
Console.WriteLine($"str_3 = {str_3}");

// Concatenate strings
string str_4 = string.Concat(str_1, str_3);
string str_5 = str_1 + str_3;
var builder = new System.Text.StringBuilder();
builder.Append(str_1);
builder.Append(str_3);
Debug.Assert(str_4 == str_5, "strings are equal");
Debug.Assert(builder.ToString() == str_5, "strings are equal");
Console.WriteLine($"str_4 = {str_4}");

//Compare strings
// == must be excatly the same
str_1 = "amr";
str_2 = "Amr";
Debug.Assert(str_1 != str_2);
Console.WriteLine($"amr not equal to Amr = {str_1 == str_2}");
// compareto: smaller -1, larger= 1, equal = 0
str_1 = "dad";
str_2 = "amr";
Debug.Assert(str_1.CompareTo(str_2) == 1);
Console.WriteLine($"amr compare to dad = {str_1.CompareTo(str_2)}");

//String methods
string str_test = "test this string";
Debug.Assert(str_test.StartsWith("test"));
Debug.Assert(str_test.EndsWith("string"));
// split and join
string[] splitted = str_test.Split(" ");
Debug.Assert(String.Join(' ', splitted) == str_test);
// Check conditions
Debug.Assert(str_test.Contains("test"));
// divide string
Debug.Assert(str_test.Substring(5) == "this string");
// Trim
Console.WriteLine("string trim: " + "   test this ".Trim());
// Insert and remove
Debug.Assert(str_test.Remove(5, 5) == "test string");
Debug.Assert(str_test.Insert(0, "+++") == "+++test this string");


//-----------------------------------------------------------------------
// Array in C#
// 1-D arrays intialization:
Console.WriteLine("");
Console.WriteLine("----Arrays----------------");
int[] arr = new int[5]{1, 2, 3, 4, 5};
int[] arr_1 = {1, 2 ,3 ,4, 5};

// Indexing and slicing
Debug.Assert(arr[0] == 1);
Debug.Assert(arr[^1] == 5);
int[] arr_slice = arr[1..^0];
Console.Write(" Index to last element [1..^0]: ");
foreach(int val in arr_slice){
    Console.Write(val + " ");
}

//2-D Array or more
// rectangular
int [,] arr2D = new int[2, 2]{{1, 2},{2 , 3}};
// row and col
Debug.Assert(arr2D.GetLength(0) == 2);
Debug.Assert(arr2D.GetLength(1) == 2);

// jigged array
int [][] arr2d = {
    new int[]{1, 2},
    new int []{2, 3}
    };
Console.WriteLine("Jigged array: ");
for(int i = 0; i< arr2d.Length; i++){
    for(int j=0; j< arr2d[i].Length; j++){
        Console.Write(arr2d[i][j] + " ");
    }
    Console.WriteLine("");
}
int [][] arr2d_2 = new int[2][];
arr2d_2[0] = new int[]{1, 2, 3, 4, 5, 6};
arr2d_2[1] = new int[]{3, 4, 5, 6, 7, 8};
Console.WriteLine("Jigged array 2: ");
for(int i = 0; i< arr2d_2.Length; i++){
    for(int j=0; j< arr2d_2[i].Length; j++){
        Console.Write(arr2d_2[i][j] + " ");
    }
    Console.WriteLine("");
}
// jigged array slicing
Console.WriteLine("Slice jigged: ");
int[] arr_slice_2 = arr2d_2[0][2..^0];
foreach(var item in arr_slice_2){
    Console.Write(item + " ");
}


// Switch
char checkme = '+';
switch(checkme){
    case '+':
        Console.WriteLine("sum");
        break;
    case '-':
        Console.WriteLine("subtract");
        break;
    default:
        Console.WriteLine("no operation found");
        break;
}

int age = 10;
var perSonChek = age switch{
    <1 => "smaller than 1",
    <2 => "smaller than 2",
    <3 => "samller than 3",
    >3 => "larger than 3",
};
Console.WriteLine($"switch expression: {perSonChek}");

int price = 100;
int sale = 40;
var perSonChek2 = (price, sale) switch{
    (<50, <30)=> "not good enough",
    (>50, >30)=> "perfect profit",
};
Console.WriteLine($"switch expression: {perSonChek2}");

int value = default;
Debug.Assert(value==0);

//Functions:
// ref
int funcTest = 10;
void myFunc(ref int value){
    value += 20;
}
myFunc(ref funcTest);
Debug.Assert(funcTest == 30);

//out is similar to ref but can only be assigned and not used
void myFunc2(out int value){
    value = 10;
}
int funcTest2;
myFunc2(out funcTest2);
Debug.Assert(funcTest2 == 10);

void myFunc3(params int[] val){
    Console.WriteLine("param:  ");
    foreach(var i in val){
        Console.Write( i + " ");
    }
} 
myFunc3(1,2,3,4);

Console.WriteLine("");
Console.WriteLine("----Enums----------------");
// Enum
void enum_test(){
    test.Color myColor = test.Color.Blue;
    Console.WriteLine(myColor);
}
enum_test();

void enum_pos(){
    var posTopLeft = test.Position.Top | test.Position.Left;
    if((posTopLeft & test.Position.Top) > 0){
        Console.WriteLine("Top position Detected");
    }

    posTopLeft = posTopLeft ^ test.Position.Top;
    if((posTopLeft & test.Position.Top) == 0){
        Console.WriteLine("Not in Top");
    }
}
enum_pos();

Console.WriteLine("");
Console.WriteLine("----Tuple----------------");
(int, int) count = (2, 3);
Console.WriteLine($"Tuple values {count.Item1} & {count.Item2}");
(int val1, int val2) count_2 = (2, 4);
Console.WriteLine($"Tuple values {count_2.val1} & {count_2.val2}");
(int, int) tupleTest(){
    return (2, 3);
}
if(count == count_2){
    Console.WriteLine("they are equal");
}

// Nullable
Console.WriteLine("");
Console.WriteLine("----Nullable----------------");
int[]? possibleNull = null;
if(possibleNull == null){
    Console.WriteLine("val is null");
}

//struct
var newStruct = new test.myStruct(5, "My age");
var newStruct2 = default(test.myStruct);
newStruct.print();
newStruct2.print();

namespace test{
    public enum Color{
        Yellow,
        Blue,
        Red,
        Green
    }

    public enum Position{
        Top = 1 << 0,
        Left = 1 << 1,
        Right = 1 << 2,
        Bottom = 1 << 3
    }
    public struct myStruct{
    int x = 0;
    string y = "";
   
    public myStruct(int x, string y){
        this.x = x;
        this.y = y;
    }
    
    public void print() => Console.WriteLine($"{this.y} is equal to {this.x}");
}

}

