# OOPLab7_Polymorphism
Labb7 Edugrade education system developer
# Vad du ska göra

- [ ]  Du ska skapa en klass som ska vara ParentClass till de andra klasserna som ska ärva från den och klassen heter `Geometri{ }` som ska ha en metod som heter `Area()` och dess `return` typ är double.
- [ ]  Du ska skapa fem klasser till som ska ärva från Geometriklassen och klasserna ska heta `Rektangel`, `Fyrkant`, `Cirkel` , Parallellogram och Ellips. Alla klasser ska ha en metod som heter `Area().`
- [ ]  Varje klass ska ha minst en egenskap, till exempel:
    
    ```csharp
    public class Cirkel{
         public double Radius {get; set;}
    }
    ```
    
- [ ]  I alla ChildClasses ska vi overrida metoden `Area()` med olika implementeringar. Eftersom arean för en cirkel inte räknas ut på samma sätt som arean för en fyrkant.
- [ ]  Alla ChildClasses måste ha en konstruktor för att ge värde till egenskaperna och vi ska ge den ett fast värde i konstruktorn. Till exempel:
    
    ```csharp
    public Cirkel{
          Radius = 4;
    }
    ```
    
- [ ]  I void Main()-metoden ska du skapa en object reference från Geometriklassen och den ska peka mot ett objekt av varje klass.

## Output :
