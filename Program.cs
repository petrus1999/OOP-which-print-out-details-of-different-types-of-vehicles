using OOP_which_print_out_details_of_different_types_of_vehicles;
class Program
{
    static void Main(string[] args)
    {
        Car mycar1 = new Car("POLO GTI","VW","RED");
        Car mycar2 = new Car("MAZDAX3", "MAZDA", "BLUE");
        Car mycar3 = new Car(" AMG ", "MERCEDEZ BENZ", "WHITE");
        Car mycar4 = new Car("MUSTANG", "FORD", "RED");

        Console.WriteLine(mycar1.Name + " " + mycar1.Brand+"  "+ mycar1.Colour);
        Console.WriteLine(mycar2.Name + " " + mycar2.Brand + " " + mycar2.Colour);
        Console.WriteLine(mycar3.Name + " " + mycar3.Brand + " " + mycar3.Colour);
        Console.WriteLine(mycar4.Name + " " + mycar4.Brand + " " + mycar4.Colour);


    }
}