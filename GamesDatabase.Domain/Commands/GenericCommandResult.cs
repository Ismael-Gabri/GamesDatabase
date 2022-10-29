using GamesDatabase.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public object Data { get; set; }
    }
}
