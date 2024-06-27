namespace CarDealer;

class Program
{
    static void Main(string[] args)
    {
        var menu = new Menu();
        menu.MainMenu();
    }
}

/* En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker,
 årsmodell, registreringsnummer og kilometerstand. Når kunden kommer inn i shappa 
 skal han kunne se hvilke biler som finnes i shappa, eller han kan velge å finne en 
 bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt 
 kilometerstand. Kunden skal også ha mulighet til å kjøpe en av bilene. 
 Bilen må da tilhøre kunden og ikke forhandleren. */