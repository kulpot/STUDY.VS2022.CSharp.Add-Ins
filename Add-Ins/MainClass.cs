using System;

//ref link:https://www.youtube.com/watch?v=PW6iq2mv170&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=14
// Tools > Command Line > Developers Command Prompt
// cmd.exe > C:\Users\sunny\source\repos\Add-Ins>csc /target:library /out:ChessInterface.dll MainClass.cs
/*
 * C:\Users\sunny\source\repos\Add-Ins\Add-Ins>dir
 * 
 Directory of C:\Users\sunny\source\repos\Add-Ins\Add-Ins

28/06/2023  11:44 pm    <DIR>          .
28/06/2023  11:44 pm    <DIR>          ..
28/06/2023  11:26 pm               293 Add-Ins.csproj
28/06/2023  11:27 pm    <DIR>          bin
28/06/2023  11:44 pm             4,608 ChessInterface.dll
28/06/2023  11:38 pm               572 MainClass.cs
28/06/2023  11:27 pm    <DIR>          obj
               3 File(s)          5,473 bytes
               4 Dir(s)  492,295,307,264 bytes free
 * 
 */

public struct ChessMove
{
    public int StartRow { get; set; }
    public int EndRow { get; set; }
    public int StartColumn { get; set; }
    public int EndColumn { get; set; }
}

public enum ChessPiece { King, Queen, Bishop, Castle, Pawn }

public interface IChessGame
{
    ChessMove MakeMove(ChessPiece[,] board);
}