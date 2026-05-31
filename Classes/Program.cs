using System;
using Classes;

namespace ProgramNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание подземелья
            Dungeon dungeon = new Dungeon();
            // Вывод информации о комнатах
            dungeon.ShowRoomsInfo();
        }
    }
}