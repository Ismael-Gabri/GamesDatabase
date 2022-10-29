using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Entities
{
    public class Screenshots : Entity
    {
        public Screenshots(string screenshotPath)
        {
            ScreenshotPath = screenshotPath;
        }

        public string ScreenshotPath { get; private set; }
    }
}
