namespace AllTheTasks
{
    internal class Program
    {
        static void Main()
        {
            Enviroment env = new Enviroment();
            Game game = env.Load();

            game.StartGame();
        }
    }
}


/*
Brukeren kan skrive inn <, > eller =

- Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
- Det må verifiseres om brukeren har valgt riktig alternativ.
- Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
- Poengsummen printes til skjermen for hvert svar brukeren har gitt.
- Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene*/