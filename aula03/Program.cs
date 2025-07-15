using System;

// namespace UserName
// {

//     public class Name
//     {
//         public const string name = "Kauã";

//     }

// }

// namespace UserAge
// {
//     public class Idade
//     {
//     public const int age = 21;

//     }
// }

// namespace results
// {
//     using UserName;
//     using UserAge;

//     class DoubleOutput
//     {
//         static void Main()
//         {
//             string nome = Name.name;
//             int idade = Idade.age;

//             Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos de idade");
//         }
//     }

// }


namespace VhModel
{
    public class Model
    {
       public const string model = "Porsche 911-GT3 RS";
    }
}


namespace Brand
{
    public class CraBrand
    {
       public const string brand = "Group Porsche";
    }
}


namespace YearModel
{
    public class TheYear
    {
       public const int year = 2024;
    }
}

namespace Result
{
    using VhModel;
    using Brand;
    using YearModel;

    class CarOutpuut
    {

        static void Main()
        {
            string model = Model.model;
            string brand = CraBrand.brand;
            int year = TheYear.year;

            Console.WriteLine($"My car is {model} your monter is {brand} and year is {year}");
        }
    }

}