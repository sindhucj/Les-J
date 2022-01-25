﻿using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                  new Command() { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle  & Pan" },
                  new Command() { Id = 1, HowTo = "Cut Bread", Line = "Get Knife", Platform = "Knife & Chopping Board" },
                  new Command() { Id = 2, HowTo = "Make cup of tea", Line = "Place tea bag in cup", Platform = "Kettle  & Cup" }
        };
            return commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command() { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle  & Pan" };
        }
    }
}
