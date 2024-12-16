int nombre = 0;
bool validator = true;
List<int> notes = new List<int>();

do
{
    Console.Write("--- Gestion des notes avec menu ---\n\n");

    Console.Write(
        "1-----Saisir les notes\n" +
        "2-----La plus grande note\n" +
        "3-----La plus petite note\n" +
        "4-----La moyenne des notes\n" +
        "0-----Quitter\n" +
        "\n" +
        "Faites votre choix : ");

    int choose = int.Parse(Console.ReadLine());

    switch (choose)
    {
        case 1:
            do
            {
                try
                {
                    Console.WriteLine("Veuillez saisir le nombre de notes");

                    nombre = int.Parse(Console.ReadLine());

                    // nombre != 0 ? validator = false : Console.WriteLine("Entrer un nombre correct superieur à 0");
                    if (nombre != 0)
                    {
                        validator = false;
                    }
                    else
                    {
                        Console.WriteLine("Entrer un nombre correct superieur à 0");
                    }

                }
                catch
                {
                    Console.WriteLine("Entrer un nombre !");
                }
            } while (validator);

            
            Console.WriteLine($"\nVeuillez saisir {nombre} notes\n");

            validator = true;


            for (int i = 0; i < nombre; i++)
            {
                do
                {
                    try
                    {

                        Console.Write($"\t\t - Merci de saisir la note {i + 1} (sur /20) : ");

                        notes.Add(int.Parse(Console.ReadLine()));

                        if (notes[i] >= 0 && notes[i] <= 20)
                        {
                            validator = false;
                        }
                        else
                        {
                            Console.WriteLine("Entrer une note correct entre 0 est 20");
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Entrer un nombre !" + e);
                    }
                } while (validator);

            };
            break;

        case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n--- La plus grande note ---\n");
            Console.WriteLine($"La meilleur note est {notes.Max()}/20\n");
            Console.ResetColor();
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n--- La plus petite note ---\n");
            Console.WriteLine($"La moins bonne note est {notes.Min()}/20\n");
            Console.ResetColor();
            break;
        case 4:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n--- La moyenne des note --- \n");
            Console.WriteLine($"La moyenne des notes est {Math.Round(notes.Average(), 1)}/20\n");
            Console.ResetColor();
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Numéro saisis invalide");
            break;

    }
        

} while (true);