using MethodOeverloadExercise;
Console.WriteLine("How much money is in your two pockets, change included\n" +
    "Please enter how much you have in have pocket below\n" +
    "---------------------------------------------------");
var pocket1 = int.Parse(Console.ReadLine());
var pocket2 = int.Parse(Console.ReadLine());

Console.WriteLine(Methods.Add(pocket2, pocket1, true));



