﻿using System.Globalization;

namespace Fitness_Center;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Member member = new MultiClubMember(1234, "Darryl", "313-806-0757", "hey@gmail.com", "1234 Street", 25);
        member.DisplayMember();
    }
}