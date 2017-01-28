# Translator
This code changes the latin letters into armenian letters


#### Extension Methods

Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type. For client code written in C# and Visual Basic, there is no apparent difference between calling an extension method and the methods that are actually defined in a type.

This class library contains extension methods **ToLover()** and **ToArmenia()**.
The method **ToLover()** allows you convert uppercase letters to lovercase. For instance:
"A" => "a";
"B" => "b" etc.


Thie method allows you to convert latin letters into armenian. For example:
"a" => "ա",
"b" => "բ" etc.


``` c#

static void Main(string [] args)
        {
            var l = "ABC";
            var k = "TOLOVER";

            Console.WriteLine(l.ToLower());
            Console.WriteLine(k.ToArmenia());
            Console.ReadKey();


        }
 ```

#### The output

abc
tolover




