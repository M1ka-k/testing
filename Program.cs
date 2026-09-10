using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testing.Models;

namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Yarn> yarns = new Dictionary<string, Yarn>
            {
                {
                    "Ocean",
                    new Yarn
                    {
                        Weight = 4,
                        Metrial = "Wool",
                        Color = "Blue",
                        ColorLot = "001",
                        Brand = "Lion Brand",
                        IsVarigated = false
                    }
                },
                {
                    "babypink",
                    new Yarn
                    {
                        Weight = 7,
                        Metrial = "Cotton",
                        Color = "Pink",
                        ColorLot = "030",
                        Brand = "Bernat",
                        IsVarigated = false
                    }
                },
                {
                    "Mouse",
                    new Yarn
                    {
                        Weight = 4,
                        Metrial = "Acrylic",
                        Color = "Gray",
                        ColorLot = "008",
                        Brand = "Red Heart",
                        IsVarigated = false
                    }
                },
                {
                    "Blood",
                    new Yarn
                    {
                        Weight = 4,
                        Metrial = "Wool",
                        Color = "maroon",
                        ColorLot = "050",
                        Brand = "Malabrigo",
                        IsVarigated = true
                    }
                },
                {
                    "Lime",
                    new Yarn
                    {
                        Weight = 4,
                        Metrial = "Merino Wool",
                        Color = "Green",
                        ColorLot = "001",
                        Brand = "Cascade",
                        IsVarigated = false
                    }
                },
                {
                    "brownCotton",
                    new Yarn
                    {
                        Weight = 3,
                        Metrial = "Cotton",
                        Color = "Brown",
                        ColorLot = "101",
                        Brand = "Sugar n Cream",
                        IsVarigated = false
                    }
                },
                {
                    "juteBeige",
                    new Yarn
                    {
                        Weight = 4,
                        Metrial = "Jute",
                        Color = "Beige",
                        ColorLot = "011",
                        Brand = "Hemp",
                        IsVarigated = false
                    }
                }
            };

            List<Project> projects = new List<Project>
            {
                new Project { Name = "Winter Scarf",      hookSize = 4, Yartage = 200,  IsFreeHand = false },
                new Project { Name = "Baby Hat",          hookSize = 3, Yartage = 100,  IsFreeHand = true  },
                new Project { Name = "Gloves",            hookSize = 2, Yartage = 150,  IsFreeHand = false },
                new Project { Name = "Patchwork Blanket", hookSize = 5, Yartage = 1500, IsFreeHand = true  },
                new Project { Name = "Sweater",           hookSize = 4, Yartage = 800,  IsFreeHand = false },
                new Project { Name = "Teddy Bear",        hookSize = 6, Yartage = 250,  IsFreeHand = false },
                new Project { Name = "Handbag",           hookSize = 4, Yartage = 400,  IsFreeHand = true  }
            };

            projects[0].Yarns = new List<Yarn>() { yarns["Ocean"] };
            projects[1].Yarns = new List<Yarn>() { yarns["babypink"] };
            projects[2].Yarns = new List<Yarn>() { yarns["Mouse"] };
            projects[4].Yarns = new List<Yarn>() { yarns["Lime"] };
            projects[5].Yarns = new List<Yarn>() { yarns["Blood"] };
            projects[6].Yarns = new List<Yarn>() { yarns["juteBeige"] };

            projects[3].Yarns = new List<Yarn>()
            {
                yarns["Lime"],
                yarns["Mouse"],
                yarns["juteBeige"]
            };




            foreach (var project in projects)
            {
                if (project.Yarns.Any(y => y.IsVarigated == false))
                {
                    Console.WriteLine(project.Name);
                }
            }


        }
    }
}
