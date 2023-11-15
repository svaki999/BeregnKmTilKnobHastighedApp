namespace BeregnHastighedApp
{
    public class BeregnHastighed
    {
        public BeregnHastighed()
        { }

        public double BeregnHastighedKnob(double kmTime)
        {
            double knob = kmTime * 0.53996;
            return knob;
        }

        public double BeregnHastighedKmTime(double knob)
        {
            double kmTime = knob / 0.53996;
            return kmTime;
        }

        public static void NewMethod(BeregnHastighed beregn)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Vælg en beregning:");
                Console.WriteLine("1. Hastighed i knob");
                Console.WriteLine("2. Hastighed i km/t");
                Console.WriteLine("0. Afslut program");

                if (int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    switch (userChoice)
                    {
                        case 0:
                            continueRunning = false;
                            break;

                        case 1:
                            Console.WriteLine("Indtast antal km/t du vil have omregnet til knob: ");
                            if (double.TryParse(Console.ReadLine(), out double kmTime))
                            {
                                double knobResultat = beregn.BeregnHastighedKnob(kmTime);
                                Console.WriteLine("Hastighed i knob: " + knobResultat);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Ugyldig indtastning for km/t. Tryk på ENTER for at prøve igen.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;

                        case 2:
                            Console.WriteLine("Indtast antal knob du vil have omregnet til km/t: ");
                            if (double.TryParse(Console.ReadLine(), out double Knob))
                            {
                                double kmTimeResultat = beregn.BeregnHastighedKmTime(Knob);
                                Console.WriteLine("Hastighed i km/t: " + kmTimeResultat);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Ugyldig indtastning for knob. Tryk på ENTER for at prøve igen.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;
                                

                        default:
                            Console.WriteLine("Ugyldigt valg. Tryk på ENTER for at prøve igen.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldigt valg. Tryk på ENTER for at prøve igen.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
