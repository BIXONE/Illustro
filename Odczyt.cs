namespace Illustro;

public class Odczyt
{
    public int Id { get; set; }
    public string dateTime { get; set; }
    public string stanowisko { get; set; }
    public List<(int numer, string imie)> pracownik { get; set; }
    public string wartośćOdczytu { get; set; }
    public string wartośćTekstowa { get; set; }

    public Odczyt(int id, DateTime dateTime, string stanowisko, string? pracownik, string wartośćOdczytu)
    {
        Id = id;
        this.dateTime = dateTime.ToString("G");
        this.stanowisko = stanowisko;
        this.pracownik = RozdzielenieStringaPracowników(pracownik);
        this.wartośćOdczytu = wartośćOdczytu;
    }

    public Odczyt(string tekst)
    {
        this.wartośćTekstowa = tekst;
    }

    private List<(int numer, string imie)> RozdzielenieStringaPracowników(string? stringPracowników)
    {
        if (string.IsNullOrEmpty(stringPracowników))
            return new();

        List<(int numer, string imie)> listaPracowników = new List<(int numer, string imie)>();

        List<string> listaPomocnicza = new();
        listaPomocnicza.AddRange(stringPracowników.Split(";"));

        for (int i = 0; i < listaPomocnicza.Count; i++)
        {
            int num = 0;
            if (int.TryParse(listaPomocnicza[i], out num))
            {
                listaPracowników.Add(new(num, ZapytanieOPracownika(num)));
            }
        }
        return listaPracowników;
    }

    string ZapytanieOPracownika(int numerPracownika)
    {
        using var aplicationDBContext = new AplicationDBContext();

        var odczyt = (from s in aplicationDBContext.Employees
                      where numerPracownika == s.EnovaId
                      select s).FirstOrDefault();

        if (odczyt != null)
        {
            return odczyt.FirstName.Remove(1) + ". " + odczyt.LastName;
        }

        return "";
    }
}
