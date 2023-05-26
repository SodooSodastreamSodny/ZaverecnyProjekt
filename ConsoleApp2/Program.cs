using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;


class Program
{
    static void Main()
    {

        Hra h = new Hra();
        while (h.SkoreHrac < 5 && h.SkoreNepritel < 5)
        {
            AnsiConsole.Clear();
            AnsiConsole.Render(h.PrintScore());
            AnsiConsole.MarkupLine("[bold]--------------[/]");
            AnsiConsole.MarkupLine("[bold]Kolo hráče:[/]");
            AnsiConsole.WriteLine("1 - kamen");
            AnsiConsole.WriteLine("2 - nuzky");
            AnsiConsole.WriteLine("3 - papir");
            AnsiConsole.MarkupLine("[bold]--------------[/]");
            try {
                int hracuvTah = Convert.ToInt32(Console.ReadLine());
                int nepriteluvTah = generatorCisla.Next(1, 4);
                if (hracuvTah == nepriteluvTah)
                {
                    AnsiConsole.Markup("[yellow]Remíza[/]");
                }
                else if (hracuvTah == 1 && nepriteluvTah == 2 ||
                    hracuvTah == 2 && nepriteluvTah == 3 ||
                    hracuvTah == 3 && nepriteluvTah == 1)
                {
                    AnsiConsole.Markup($"[green]Hráč vyhrál - nepřítel zvolil {ziskatTahText(nepriteluvTah)}[/]");
                    h.SkoreHrac++;
                }
                else
                {
                    AnsiConsole.Markup($"[red]Nepřítel vyhrál - zvolil {ziskatTahText(nepriteluvTah)}[/]");
                    h.SkoreNepritel++;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();



        }
    }
    public static Random generatorCisla = new Random();



    public class Hra
    {

        public int SkoreHrac { get; set; } = 0;
        public int SkoreNepritel { get; set; } = 0;

        public Hra()
        {
            SkoreHrac = 0;
            SkoreNepritel = 0;

        }
        public Table PrintScore()
        {
            var table = new Table();
            table.AddColumn("[bold]Hráč[/]");
            table.AddColumn("[bold]Nepřítel[/]");
            table.AddRow(SkoreHrac.ToString(), SkoreNepritel.ToString());
            return table;
        }

    }
    static string ziskatTahText(int tah)
    {
        switch (tah)
        {
            case 1: return "kamen";
            case 2: return "nuzky";
            case 3: return "papir";
            default: return "error";
        }
    }

}