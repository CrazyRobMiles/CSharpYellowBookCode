﻿using System;

class Account
{
    public string Name;
} ;

class StructsAndObjectsDemo
{
    public static void Main()
    {
        Account RobsAccount;
        RobsAccount = new Account();
        RobsAccount.Name = "Rob";
        Console.WriteLine(RobsAccount.Name);
    }
}

