using GamesDatabase.Domain.Commands.Contracts;
using GamesDatabase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Commands
{
    public class CreateGameCommand : ICommand
    {
        public CreateGameCommand() { }

        public CreateGameCommand(string type,
            string name,
            string genre,
            string description,
            double initialPrice,
            double discount_Percentage,
            double finalPrice,
            string screenshotPath)
        {
            Type = type;
            Name = name;
            Genre = genre;
            Description = description;
            InitialPrice = initialPrice;
            Discount_Percentage = discount_Percentage;
            FinalPrice = finalPrice;
            ScreenshotPath = screenshotPath;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public double InitialPrice { get; set; }
        public double Discount_Percentage { get; set; }
        public double FinalPrice { get; set; }
        public string ScreenshotPath { get; set; }
        public Dictionary<string, string> Notification { get; set; } = new Dictionary<string, string>();

        public bool Validate()
        {
            if(Type.Length < 3)
                Notification.Add("Type", "O tipo deve conter ao menos 3 caracteres");

            if(Name.Length < 3)
                Notification.Add("Name", "O nome deve conter ao menos 3 caracteres");

            if (Genre.Length < 3)
                Notification.Add("Genre", "O Genero deve conter ao menos que 3 caracteres");

            if (Description == "" || Description == null)
                Notification.Add("Description", "É preciso uma descrição");

            if (InitialPrice == null)
                Notification.Add("InitialPrice", "Preço inicial igual a nulo");

            if (FinalPrice == null)
                Notification.Add("FinalPrice", "Preço final igual a nulo");

            if (ScreenshotPath == null || ScreenshotPath == "")
                Notification.Add("ScreenshotPath", "É preciso de uma screenshoot");

            if (Notification.Count > 0)
                return false;
            else
                return true;
        }
    }
}
