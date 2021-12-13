using System;
using System.Linq;

public static class Globals
{
    private const string V = " ";
    private const string X = "X";
    private const string O = "O";
    public static bool xTurn= true;
    public static string[] boardState = {V,V,V,V,V,V,V,V,V};
    
    public static void ClearBoard()
    {
        boardState[0] = V;
        boardState[1] = V;
        boardState[2] = V;
        boardState[3] = V;
        boardState[4] = V;
        boardState[5] = V;
        boardState[6] = V;
        boardState[7] = V;
        boardState[8] = V;
    }
    
    public static void ShowBoardReference()
    {
        Console.WriteLine("\n\nReference:\n┌───┬───┬───┐\n│ 7 │ 8 │ 9 │\n├───┼───┼───┤\n│ 4 │ 5 │ 6 │\n├───┼───┼───┤\n│ 1 │ 2 │ 3 │\n└───┴───┴───┘\n\n");
    }
    
    public static void ShowBoardState()
    {
        Console.WriteLine("┌───┬───┬───┐\n│ " + boardState[7] + " │ " + boardState[8] + " │ " + boardState[0] + " │\n├───┼───┼───┤\n│ " + boardState[4] + " │ " + boardState[5] + " │ " + boardState[6] + " │\n├───┼───┼───┤\n│ " + boardState[1] + " │ " + boardState[2] + " │ " + boardState[3] + " │\n└───┴───┴───┘");
    }

    public static void InvalidOMove()
    {
        Console.WriteLine(" ****Apologies. That square is taken.\n ****Please try a different move.\n ****Thank you.\n");
        Console.ReadKey();
        Globals.xTurn = false;

    }

    public static void InvalidXMove()
    {
        Console.WriteLine("**Apologies. That square is taken.**\n**Please try a different move.**\n**Thank you.**\n");
        Console.ReadKey();
        Globals.xTurn = true;

    }
}