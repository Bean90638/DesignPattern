﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, 遊戲開始!");

var hero1 = new Hero("A", new Waterball());
var hero2 = new Hero("B", new Colliding());
var Battle = new Battle(hero1, hero2);
Battle.start();

Console.WriteLine("遊戲結束! Bye~");
