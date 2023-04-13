namespace Hamshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biemvenido al restuaruante de hamburguesas Chimi MiBarriga!");
            Console.WriteLine("Qué tipo de hamburguesa desea hoy?");
            Console.WriteLine("(Escriba la letra de la opción preferida y presionar Enter:)");

            Console.WriteLine("\na. Hamburguesa Clásica\nb. Hamburguesa Saludable\nc. Hamburguesa Premium\n");
            string hamselect = Console.ReadLine();

            if (hamselect == "a") //Clásica
            {
                Hamburger classic = new Hamburger();

                Console.WriteLine("Ha seleccionado la hamburguesa clásica.");
                Console.WriteLine("Esta solo tiene Pan y Carne. Desea agregar más ingredientes?");
                Console.WriteLine("(Escriba Si o No, y luego presione Enter:)");
                string extras = Console.ReadLine();

                if (extras == "Si")
                {
                    int numextra = 4;
                    Console.WriteLine("Escriba 'Si' si desea el ingrediente.");
                    Console.WriteLine("De lo contrario, no escriba nada.");
                    while (numextra > 0)
                    {
                        Console.WriteLine("Carne extra.");
                        string choice1 = Console.ReadLine();
                        if (choice1 == "Si")
                        {
                            classic.carne2 = true;
                            numextra--;
                        }

                        Console.WriteLine("Queso");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "Si")
                        {
                            classic.queso = true;
                            numextra--;
                        }

                        Console.WriteLine("Bacon.");
                        string choice3 = Console.ReadLine();
                        if (choice3 == "Si")
                        {
                            classic.bacon = true;
                            numextra--;
                        }

                        Console.WriteLine("Lechuga");
                        string choice4 = Console.ReadLine();
                        if (choice4 == "Si")
                        {
                            classic.lechuga = true;
                            numextra--;
                        }

                        Console.WriteLine("Tomate.");
                        string choice5 = Console.ReadLine();
                        if (choice5 == "Si")
                        {
                            classic.tomate = true;
                            numextra--;
                        }

                        Console.WriteLine("Cebolla.");
                        string choice6 = Console.ReadLine();
                        if (choice6 == "Si")
                        {
                            classic.cebolla = true;
                            numextra--;
                        }

                        Console.WriteLine("Desea terminar su selección?");
                        string choice7 = Console.ReadLine();
                        if (choice7 == "Si")
                        {
                            numextra = 0;
                        }
                    }
                }

                Console.Write("Entendido, su total es:");
                Console.WriteLine("RD$" + classic.Hamcount() * 50);
            }

            else if (hamselect == "b") //Saludable
            {
                ThinBurger saludable = new ThinBurger();

                Console.WriteLine("Ha seleccionado la hamburguesa saludable.");
                Console.WriteLine("Esta hamburguesa tiene Pan Integral y Carne.");
                Console.WriteLine("Además, puede agregar 6 ingredientes extra.");
                Console.WriteLine("Desea agregar los ingredientes adicionales.");
                Console.WriteLine("(Escriba si o no, y luego presione Enter:)");
                string extras = Console.ReadLine();

                if (extras == "si")
                {
                    int numextra = 6;
                    Console.WriteLine("Escriba 'Si' si desea el ingrediente.");
                    Console.WriteLine("De lo contrario, no escriba nada.");
                    while (numextra > 0)
                    {
                        Console.WriteLine("Carne extra.");
                        string choice1 = Console.ReadLine();
                        if (choice1 == "Si")
                        {
                            saludable.carne2 = true;
                            numextra--;
                        }

                        Console.WriteLine("Queso");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "Si")
                        {
                            saludable.queso = true;
                            numextra--;
                        }

                        Console.WriteLine("Bacon.");
                        string choice3 = Console.ReadLine();
                        if (choice3 == "Si")
                        {
                            saludable.bacon = true;
                            numextra--;
                        }

                        Console.WriteLine("Lechuga");
                        string choice4 = Console.ReadLine();
                        if (choice4 == "Si")
                        {
                            saludable.lechuga = true;
                            numextra--;
                        }

                        Console.WriteLine("Tomate.");
                        string choice5 = Console.ReadLine();
                        if (choice5 == "Si")
                        {
                            saludable.tomate = true;
                            numextra--;
                        }

                        Console.WriteLine("Cebolla.");
                        string choice6 = Console.ReadLine();
                        if (choice6 == "Si")
                        {
                            saludable.cebolla = true;
                            numextra--;
                        }

                        Console.WriteLine("Desea terminar su selección?");
                        string choice7 = Console.ReadLine();
                        if (choice7 == "Si")
                        {
                            numextra = 0;
                        }
                    }
                }

                Console.Write("Entendido, su total es:");
                Console.WriteLine("RD$" + (saludable.Hamcount() + saludable.Thincount()) * 50);

            }

            else if (hamselect == "c") //Premium
            {
                PremiumBurger premium = new PremiumBurger();
                Console.WriteLine("Ha seleccionado la hamburguesa premium.");
                Console.WriteLine("Esta es la hamburguesa clásica, incluyendo papitas y una bebida de su preferencia.");
                Console.WriteLine("(Escriba la babida que desee, y luego presione Enter:)");
                premium.bebida = Console.ReadLine();
                Console.Write("Entendido, su total es:");
                Console.WriteLine("RD$" + (premium.Hamcount() + premium.Highcount()) * 100);
                Console.WriteLine("Y su bebida es: " + premium.bebida);
            }
        }
    }
}