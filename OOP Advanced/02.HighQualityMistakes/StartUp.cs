﻿public class StartUp
{
    public static void Main()
    {
        var spy = new Spy();
        var result = spy.AnalyzeAcessModifiers("Hacker");
        System.Console.WriteLine(result);
    }
}

