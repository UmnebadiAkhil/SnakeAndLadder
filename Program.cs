//See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Snake & Ladder Stimulator");
Console.WriteLine("_________________________");

SnakeAndLadder.UC1_StartPosition uc1 = new SnakeAndLadder.UC1_StartPosition();
uc1.StartPosition();

Console.WriteLine("_________________________");

SnakeAndLadder.UC2_PlayerRolls uc2 = new SnakeAndLadder.UC2_PlayerRolls();
uc2.DieRoll();

Console.WriteLine("_________________________");

SnakeAndLadder.UC3_PlayerRollsADie uc3 = new SnakeAndLadder.UC3_PlayerRollsADie();
uc3.DieRolling();
uc3.PlayerCheck();

Console.WriteLine("_________________________");

SnakeAndLadder.UC4_WinningPosition uc4 = new SnakeAndLadder.UC4_WinningPosition();
uc4.PlayerCheck();

Console.WriteLine("_________________________");

SnakeAndLadder.UC5_Winning uc5 = new SnakeAndLadder.UC5_Winning();
uc5.PlayerCheck();

Console.WriteLine("_________________________");

SnakeAndLadder.UC6 uc6 = new SnakeAndLadder.UC6();
uc6.PlayerCheck();

Console.WriteLine("_________________________");

SnakeAndLadder.UC7 uc7 = new SnakeAndLadder.UC7();
uc7.PlayerCheck();
