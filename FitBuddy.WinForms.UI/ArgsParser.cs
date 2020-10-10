using System.Collections.Generic;
using System.Linq;

namespace FitBuddy.WinForms.UI
{
    internal static class ArgsParser
    {
        public static ParsedArgs Parse(string[] args)
        {
            var parsedArgs = new ParsedArgs();

            var totalArgs = args.Length;
            for (int index = 0; index < totalArgs; ++index)
            {
                var arg = args[index].ToLowerInvariant();

                switch (arg)
                {
                    case "-ll":
                    case "--loglevel":
                        if (index >= totalArgs)
                        {
                            parsedArgs.Errores.Add("Debe especificar el nivel de mensajes de bitácora.");
                            break;
                        }

                        ++index;
                        parsedArgs.LogLevel = args[index];
                        break;

                    case "-lf":
                    case "--logfile":
                        if (index >= totalArgs)
                        {
                            parsedArgs.Errores.Add("Debe especificar el nombre de archivo de la bitácora.");
                            break;
                        }

                        ++index;
                        parsedArgs.LogFilename = args[index];
                        break;

                    case "-v":
                    case "--version":
                    case "/v":
                        parsedArgs.VersiónSolicitada = true;
                        break;

                    case "-h":
                    case "--help":
                    case "/h":
                    case "/?":
                        parsedArgs.AyudaSolicitada = true;
                        break;

                    default:
                        parsedArgs.Errores.Add($"El parámetro {arg} no es válido.");
                        break;
                }
            }

            return parsedArgs;
        }
    }

    public class ParsedArgs
    {
        public List<string> Errores { get; set; } = new List<string>();
        public bool SonVálidos => !Errores.Any();
        public string LogLevel { get; set; } = null;
        public string LogFilename { get; set; } = null;
        public bool VersiónSolicitada { get; set; } = false;
        public bool AyudaSolicitada { get; set; } = false;
    }
}
