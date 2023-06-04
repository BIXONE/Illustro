namespace Illustro;

public partial class MainWindow : Window
{
    string StanowiskoHistoriaOdczytów { get; set; }
    string PracownikHistoriaOdczytów { get; set; }
    string OdczytHistoriaOdczytów { get; set; }

    public List<Odczyt> listaOdczytów;
    public List<Odczyt> listaOdczytówDziś;

    private readonly int cel = 20;
    private int idDB = 0;

    Style styleWybranyPrzycisk = new();
    Style styleNieWybranyPrzycisk = new();
    public ISeries[] wykresPuszka { get; set; }
    public ISeries[] wykresKJ { get; set; }
    public ISeries[] wykresStemas { get; set; }
    public ISeries[] wykresMontaż1 { get; set; }
    public ISeries[] wykresMontaż2 { get; set; }
    public ISeries[] wykresMontaż3 { get; set; }
    public ISeries[] wykresMontaż4 { get; set; }
    public ISeries[] wykresMontaż5 { get; set; }
    public ISeries[] wykresHistoriaOdczytów { get; set; }

    public Axis[] XAxis { get; set; }
    public Axis[] XAxisHistoriaOdczytów { get; set; }

    public List<string> odczyty = new List<string>();

    public MainWindow()
    {
        InitializeComponent();

        listaOdczytówDziś = new();
    }

    void InicjalizacjaAktualnaWydajność()
    {
        LiveCharts.Configure(config => config
        .AddDarkTheme()
        .AddSkiaSharp()
        );

        wykresPuszka = new ISeries[]
        {
                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
                },

                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
                }
        };
        wykresKJ = new ISeries[]
        {
                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
                },

                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
                }
        };
        wykresStemas = new ISeries[]
        {
                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
                },

                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
                }
        };
        wykresMontaż1 = new ISeries[]
        {
                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
                },

                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
                }
        };
        wykresMontaż2 = new ISeries[]
        {
                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
                },

                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
                }
        };
        wykresMontaż3 = new ISeries[]
        {
                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
                },

                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
                }
        };
        wykresMontaż4 = new ISeries[]
        {
                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
                },

                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
                }
        };
        wykresMontaż5 = new ISeries[]
        {
                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
                },

                new StackedColumnSeries<int>
                {
                    Values = new List<int> {0, 0, 0, 0, 0, 0, 0, 0},
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
                }
        };
        wykresHistoriaOdczytów = new ISeries[]
        {

            new StackedColumnSeries<int>
            {
                    Values = new List<int>(),
                    Fill = new SolidColorPaint(SKColors.Green),
                    Stroke = null,
                    Name = "Dobre",
            },

            new StackedColumnSeries<int>
            {
                    Values = new List<int>(),
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Brak",
            },
        };

        XAxis = new Axis[]
        {
            new Axis
            {
                Labels = new string[] { "7", "8", "9", "10", "11", "12", "13", "14" },
                MinLimit = 0d
            }
        };
        XAxisHistoriaOdczytów = new Axis[1];

        DataContext = this;
    }

    void InicjalizacjaHistoriaOdczytów()
    {
        StanowiskoHistoriaOdczytów = "";
        PracownikHistoriaOdczytów = "";
        OdczytHistoriaOdczytów = "";

        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Wszystkie");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Montaże");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Montaż 1");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Montaż 2");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Montaż 3");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Montaż 4");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Montaż 5");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Stemas");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Kontrola Jakości");
        stanowiskoComboBoxHistoriaOdczytów.Items.Add("Montaż Ramiaka");
        stanowiskoComboBoxHistoriaOdczytów.SelectedItem = "Wszystkie";
    }

    private void ZmianaPozycjiOkna(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            DragMove();
        }
    }

    private void ExitButton_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Minimalizuj_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            WindowState = WindowState.Minimized;
        }
    }

    private void InicjalizacjaPrzycisków()
    {
        styleNieWybranyPrzycisk = AktualnaWydajnośćButton.Style;
        styleWybranyPrzycisk = PrzyciskDoMenu.Style;
    }

    private void ZmianaSekcji()
    {
        AktualnaWydajnośćBorder.Visibility = Visibility.Hidden;
        HistoriaOdczytówBorder.Visibility = Visibility.Hidden;

        AktualnaWydajnośćButton.Style = styleNieWybranyPrzycisk;
        HistoriaOdczytówButton.Style = styleNieWybranyPrzycisk;
    }

    private void AktualnaWydajność_Click(object sender, RoutedEventArgs e)
    {
        ZmianaSekcji();
        AktualnaWydajnośćBorder.Visibility = Visibility.Visible;
        AktualnaWydajnośćButton.Style = styleWybranyPrzycisk;
    }

    private void HistoriaOdczytów_Click(object sender, RoutedEventArgs e)
    {
        ZmianaSekcji();
        HistoriaOdczytówBorder.Visibility = Visibility.Visible;
        HistoriaOdczytówButton.Style = styleWybranyPrzycisk;
    }

    private async void Window_Loaded(object sender, RoutedEventArgs e)
    {
        InicjalizacjaAktualnaWydajność();
        InicjalizacjaHistoriaOdczytów();
        InicjalizacjaPrzycisków();

        //domyślna strona 
        AktualnaWydajność_Click(sender, e);

        PobranieIdDB();
        ZapytanieOKolejneOdczyty();
        DziśHistoriaOdczytów_Click(sender, e);
        await NoweOdczytyNaŻywo();
    }

    #region Aktualna wydajność DB

    #region Dodanie wartości na wykresie
    void ZmieńWartość(ISeries[] wykres, int dobre_zle, int godzina, int wartość)
    {
        int iloscWykresów = wykres.Count();
        List<int>[] listaWartości = new List<int>[iloscWykresów];

        for (int i = 0; i < iloscWykresów; i++)
        {
            listaWartości[i] = (List<int>)wykres[i].Values;
        }

        listaWartości[dobre_zle].Insert(godzina, listaWartości[dobre_zle].ElementAt(godzina) + 1);
        listaWartości[dobre_zle].RemoveAt(godzina + 1);
    }
    #endregion

    #region Dodawanie wartości
    void DodanieDanychDoWykresów(ProductionOrderItemStatuses statusDB, int akcja)
    {
        int id = statusDB.Id;
        DateTime dateTime = statusDB.Date;
        string stanowisko = statusDB.Station;
        string odczyt = statusDB.Status;
        string operators = statusDB.Operators;

        ISeries[] wykres = new ISeries[2];

        int dobre_zle = -1;
        int godzina = -1;
        int wartość = -1;

        switch (stanowisko)
        {
            case "MPUSZKI": wykres = wykresPuszka; break;
            case "KJ1": wykres = wykresKJ; break;
            case "STEMAS": wykres = wykresStemas; break;
            case "MONTAZ1": wykres = wykresMontaż1; break;
            case "MONTAZ2": wykres = wykresMontaż2; break;
            case "MONTAZ3": wykres = wykresMontaż3; break;
            case "MONTAZ4": wykres = wykresMontaż4; break;
            case "MONTAZ5": wykres = wykresMontaż5; break;
            default:
                break;
        }

        switch (odczyt)
        {
            case "1":
                if (stanowisko == "STEMAS")
                {
                    dobre_zle = 0;
                }
                break;
            case "2":
                if (stanowisko == "STEMAS")
                {

                }
                else
                {
                    dobre_zle = 0;
                }
                break;
            case "3":
                if (stanowisko == "STEMAS")
                {

                }
                else
                {
                    dobre_zle = 0;
                }
                break;
            case "4":
                if (stanowisko == "STEMAS")
                {

                }
                else
                {
                    dobre_zle = 1;
                }
                break;
            case "5":
                break;
            default:
                break;
        }

        #region Parametr pozycja/od czasu
        if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0))
        {
            godzina = 0;
        }
        else if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0))
        {
            godzina = 1;
        }
        else if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0))
        {
            godzina = 2;
        }
        else if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0))
        {
            godzina = 3;
        }
        else if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0))
        {
            godzina = 4;
        }
        else if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0))
        {
            godzina = 5;
        }
        else if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 0, 0))
        {
            godzina = 6;
        }
        else if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0))
        {
            godzina = 7;
        }

        //Odczyty po 15 przypisane do 14:00
        else if (dateTime >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0)
           && dateTime < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0))
        {
            godzina = 7;
        }
        #endregion

        wartość = wartość + 1;

        if (dobre_zle >= 0 && godzina >= 0 && wartość >= 0 && akcja == 1)
        {
            ZmieńWartość(wykres, dobre_zle, godzina, wartość + 1);
            ZmianaKolejnościOstatnichTrzech(statusDB, dobre_zle.ToString());
            PrzypisanieOperatorówDoStanowisk(statusDB);
            PrzeliczenieWydajności(stanowisko);
            PrzeliczenieCelu(stanowisko);
            DodawnieOdczytówWHistorii(statusDB, dobre_zle.ToString());
        }
    }

    void GenerowanieListyHistoriaZamówień(DateTime dataOd, DateTime dataDo)
    {
        List<int> listaWartościWykrsu0 = new();
        List<int> listaWartościWykrsu1 = new();

        List<ProductionOrderItemStatuses> listaOdczytów = new();
        listaOdczytów = ZapytanieOOdczytPoDatach(dataOd, dataDo);

        switch (StanowiskoHistoriaOdczytów)
        {
            case "Montaż Ramiaka":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "MPUSZKI"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            case "Kontrola Jakości":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "KJ1"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            case "Stemas":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "STEMAS"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            case "Montaże":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "MONTAZ1" || l.Station == "MONTAZ2" || l.Station == "MONTAZ3" || l.Station == "MONTAZ4" || l.Station == "MONTAZ5"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            case "Montaż 1":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "MONTAZ1"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            case "Montaż 2":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "MONTAZ2"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            case "Montaż 3":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "MONTAZ3"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            case "Montaż 4":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "MONTAZ4"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            case "Montaż 5":
                {
                    listaOdczytów = (from l in listaOdczytów
                                     where l.Station == "MONTAZ5"
                                     orderby l.Id
                                     select l).ToList();
                };
                break;
            default:
                break;
        }

        switch (OdczytHistoriaOdczytów)
        {
            default:
                break;
        }

        switch (PracownikHistoriaOdczytów)
        {
            default:
                break;
        }

        if (XAxisHistoriaOdczytów[0] == null)
        {
            XAxisHistoriaOdczytów = new Axis[]
            {
                new Axis
                {

                }
            };
        }

        if ((dataDo - dataOd).Days <= 1)
        {
            string[] godziny = new string[25];
            for (int i = 0; i < godziny.Length; i++)
            {
                godziny[i] = i.ToString();
                listaWartościWykrsu0.Add(0);
                listaWartościWykrsu1.Add(0);
            }

            wykresHistoriaOdczytów[0].Values = listaWartościWykrsu0;
            wykresHistoriaOdczytów[1].Values = listaWartościWykrsu1;
            XAxisHistoriaOdczytów[0].Labels = godziny;

            for (int i = 0; i < listaOdczytów.Count; i++)
            {
                int zmienna1 = ZmianaParametruOdczyt(listaOdczytów[i].Status, listaOdczytów[i].Station);
                int zmienna2 = (listaOdczytów[i].Date - dataOd).Hours;

                if (zmienna1 >= 0 && zmienna2 >= 0)
                {
                    ZmieńWartość(wykresHistoriaOdczytów, zmienna1, zmienna2, 1);
                }
            }
        }
        else if ((dataDo - dataOd).Days <= 31)
        {
            string[] dni = new string[(dataDo - dataOd).Days];
            for (int i = 0; i < dni.Length; i++)
            {
                dni[i] = dataOd.AddDays(i).Day.ToString();
                listaWartościWykrsu0.Add(0);
                listaWartościWykrsu1.Add(0);
            }

            wykresHistoriaOdczytów[0].Values = listaWartościWykrsu0;
            wykresHistoriaOdczytów[1].Values = listaWartościWykrsu1;
            XAxisHistoriaOdczytów[0].Labels = dni;

            for (int i = 0; i < listaOdczytów.Count; i++)
            {
                int zmienna1 = ZmianaParametruOdczyt(listaOdczytów[i].Status, listaOdczytów[i].Station);
                int zmienna2 = (listaOdczytów[i].Date - dataOd).Days;

                if (zmienna1 >= 0 && zmienna2 >= 0)
                {
                    ZmieńWartość(wykresHistoriaOdczytów, zmienna1, zmienna2, 1);
                }
            }
        }
    }

    // niepotrzebne
    int ZmianaParametruDniaNaWykresie(DateTime dataOd, DateTime dataDo, DateTime dataOdczyt)
    {
        int zmienna = 0;
        zmienna = (dataOdczyt - dataOd).Days;
        return zmienna;
    }

    int ZmianaParametruOdczyt(string odczyt, string stanowisko)
    {
        switch (odczyt)
        {
            case "1":
                if (stanowisko == "STEMAS")
                {
                    return 0;
                }
                break;
            case "2":
                if (stanowisko == "STEMAS")
                {

                }
                else
                {
                    return 0;
                }
                break;
            case "3":
                if (stanowisko == "STEMAS")
                {

                }
                else
                {
                    return 0;
                }
                break;
            case "4":
                if (stanowisko == "STEMAS")
                {

                }
                else
                {
                    return 1;
                }
                break;
            case "5":
                break;
            default:
                break;
        }

        return -1;
    }

    void GenerowanieWykresuHistoriiOdczytów()
    {

    }

    List<ProductionOrderItemStatuses> ZapytanieOOdczytPoDatach(DateTime dataOd, DateTime datoDo)
    {
        using var aplicationDBContext = new AplicationDBContext();

        var odczyt = (from s in aplicationDBContext.ProductionOrderItemStatuses
                      where s.Date >= dataOd && s.Date <= datoDo
                      orderby s.Id
                      select s).ToList();

        return (List<ProductionOrderItemStatuses>)odczyt;
    }

    void PobranieIdDB()
    {
        using (var aplicationDBContext = new AplicationDBContext())
        {
            var odczyt = (from s in aplicationDBContext.ProductionOrderItemStatuses
                          where (s.Date.Year >= DateTime.Now.Year && s.Date.Month >= DateTime.Now.Month && s.Date.Day >= DateTime.Now.Day)
                          orderby s.Id ascending
                          select s).FirstOrDefault();
            if (odczyt != null)
            {
                idDB = odczyt.Id - 1;
            }
        }
    }

    void ZapytanieOKolejneOdczyty()
    {
        using var aplicationDBContext = new AplicationDBContext();

        var odczyt = (from s in aplicationDBContext.ProductionOrderItemStatuses
                      where s.Id > idDB
                      orderby s.Id
                      select s).ToList();
        if (odczyt != null)
        {
            foreach (var item in odczyt)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    DodanieDanychDoWykresów(item, 1);
                    idDB = item.Id;
                }));
            }
        }

    }

    async Task NoweOdczytyNaŻywo()
    {
        while (true)
        {
            try
            {
                ZapytanieOKolejneOdczyty();
            }
            catch
            {

            }

            await Task.Delay(100);
        }
    }
    #endregion

    private string GenerowanieStringaDoOdczytu(ProductionOrderItemStatuses statusDB, string dobre_złe)
    {
        string stanowisko = "";
        switch (statusDB.Station)
        {
            case "MPUSZKI": stanowisko = "montażu ramiaka"; break;
            case "KJ1": stanowisko = "kontroli jakości"; break;
            case "STEMAS": stanowisko = "stemasa"; break;
            case "MONTAZ1": stanowisko = "montażu 1"; break;
            case "MONTAZ2": stanowisko = "montażu 2"; break;
            case "MONTAZ3": stanowisko = "montażu 3"; break;
            case "MONTAZ4": stanowisko = "montażu 4"; break;
            case "MONTAZ5": stanowisko = "montażu 5"; break;
            default:
                break;
        }

        string pracownicy = "";
        if (statusDB.Operators != null)
        {
            pracownicy = string.Join(" i ", RozdzielenieStringaPracowników(statusDB.Operators));
        }

        string postęp = "";
        if (dobre_złe == "1")
            postęp = "brak";
        else if (dobre_złe == "0")
            postęp = "dobry przedmiot";

        return $"{statusDB.Date.ToString("T")}     Na stanowisku {stanowisko} wykonano {postęp} przez {pracownicy}";
    }

    #region Ostatnie 3 odczyty
    private void ZmianaKolejnościOstatnichTrzech(ProductionOrderItemStatuses statusDB, string dobre_złe)
    {
        Odczyt3TekstAktualnaWydajność.Content = Odczyt2TekstAktualnaWydajność.Content;
        Odczyt3BorderAktualnaWydajność.Background = Odczyt2BorderAktualnaWydajność.Background;
        Odczyt2TekstAktualnaWydajność.Content = Odczyt1TekstAktualnaWydajność.Content;
        Odczyt2BorderAktualnaWydajność.Background = Odczyt1BorderAktualnaWydajność.Background;
        Odczyt1TekstAktualnaWydajność.Content = GenerowanieStringaDoOdczytu(statusDB, dobre_złe);
        if (dobre_złe == "0")
            Odczyt1BorderAktualnaWydajność.Background = new SolidColorBrush(Color.FromRgb(0, 180, 0));
        if (dobre_złe == "1")
            Odczyt1BorderAktualnaWydajność.Background = new SolidColorBrush(Color.FromRgb(180, 0, 0));

    }
    #endregion

    private void DodawnieOdczytówWHistorii(ProductionOrderItemStatuses statusDB, string dobre_złe)
    {
        listaOdczytówDziś.Add(new(GenerowanieStringaDoOdczytu(statusDB, dobre_złe)));
    }

    #region Operatorzy na stanowiskach
    private void PrzypisanieOperatorówDoStanowisk(ProductionOrderItemStatuses statusDB)
    {
        switch (statusDB.Station)
        {
            case "MPUSZKI":
                {
                    if (statusDB.Operators != null)
                    {
                        List<string> stringList = RozdzielenieStringaPracowników(statusDB.Operators);
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (i == 0)
                                Operator1WykresPuszka.Content = stringList[i];
                            else if (i == 1)
                                Operator2WykresPuszka.Content = stringList[i];
                            else if (i == 2)
                                Operator3WykresPuszka.Content = stringList[i];
                            else if (i == 3)
                                Operator4WykresPuszka.Content = stringList[i];
                        }
                    }
                };
                break;
            case "KJ1":
                {
                    if (statusDB.Operators != null)
                    {
                        List<string> stringList = RozdzielenieStringaPracowników(statusDB.Operators);
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (i == 0)
                                Operator1KontrolaJakości.Content = stringList[i];
                            else if (i == 1)
                                Operator2KontrolaJakości.Content = stringList[i];
                            else if (i == 2)
                                Operator3KontrolaJakości.Content = stringList[i];
                            else if (i == 3)
                                Operator4KontrolaJakości.Content = stringList[i];
                        }
                    }
                };
                break;
            case "STEMAS":
                {
                    if (statusDB.Operators != null)
                    {
                        List<string> stringList = RozdzielenieStringaPracowników(statusDB.Operators);
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (i == 0)
                                Operator1Stemas.Content = stringList[i];
                            else if (i == 1)
                                Operator2Stemas.Content = stringList[i];
                            else if (i == 2)
                                Operator3Stemas.Content = stringList[i];
                            else if (i == 3)
                                Operator4Stemas.Content = stringList[i];
                        }
                    }
                };
                break;
            case "MONTAZ1":
                {
                    if (statusDB.Operators != null)
                    {
                        List<string> stringList = RozdzielenieStringaPracowników(statusDB.Operators);
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (i == 0)
                                Operator1Montaż1.Content = stringList[i];
                            else if (i == 1)
                                Operator2Montaż1.Content = stringList[i];
                            else if (i == 2)
                                Operator3Montaż1.Content = stringList[i];
                            else if (i == 3)
                                Operator4Montaż1.Content = stringList[i];
                        }
                    }
                };
                break;
            case "MONTAZ2":
                {
                    if (statusDB.Operators != null)
                    {
                        List<string> stringList = RozdzielenieStringaPracowników(statusDB.Operators);
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (i == 0)
                                Operator1Montaż2.Content = stringList[i];
                            else if (i == 1)
                                Operator2Montaż2.Content = stringList[i];
                            else if (i == 2)
                                Operator3Montaż2.Content = stringList[i];
                            else if (i == 3)
                                Operator4Montaż2.Content = stringList[i];
                        }
                    }
                };
                break;
            case "MONTAZ3":
                {
                    if (statusDB.Operators != null)
                    {
                        List<string> stringList = RozdzielenieStringaPracowników(statusDB.Operators);
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (i == 0)
                                Operator1Montaż3.Content = stringList[i];
                            else if (i == 1)
                                Operator2Montaż3.Content = stringList[i];
                            else if (i == 2)
                                Operator3Montaż3.Content = stringList[i];
                            else if (i == 3)
                                Operator4Montaż3.Content = stringList[i];
                        }
                    }
                };
                break;
            case "MONTAZ4":
                {
                    if (statusDB.Operators != null)
                    {
                        List<string> stringList = RozdzielenieStringaPracowników(statusDB.Operators);
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (i == 0)
                                Operator1Montaż4.Content = stringList[i];
                            else if (i == 1)
                                Operator2Montaż4.Content = stringList[i];
                            else if (i == 2)
                                Operator3Montaż4.Content = stringList[i];
                            else if (i == 3)
                                Operator4Montaż4.Content = stringList[i];
                        }
                    }
                };
                break;
            case "MONTAZ5":
                {
                    if (statusDB.Operators != null)
                    {
                        List<string> stringList = RozdzielenieStringaPracowników(statusDB.Operators);
                        for (int i = 0; i < stringList.Count; i++)
                        {
                            if (i == 0)
                                Operator1Montaż5.Content = stringList[i];
                            else if (i == 1)
                                Operator2Montaż5.Content = stringList[i];
                            else if (i == 2)
                                Operator3Montaż5.Content = stringList[i];
                            else if (i == 3)
                                Operator4Montaż5.Content = stringList[i];
                        }
                    }
                };
                break;
            default:
                break;
        }
    }
    #endregion

    private List<string> RozdzielenieStringaPracowników(string stringPracowników)
    {
        List<string> listaPracowników = new List<string>();
        listaPracowników.AddRange(stringPracowników.Split(";"));

        for (int i = 0; i < listaPracowników.Count; i++)
        {
            listaPracowników[i] = ZapytanieOPracownika(listaPracowników[i]);
        }

        return listaPracowników;
    }

    string ZapytanieOPracownika(string numerPracownika)
    {
        using var aplicationDBContext = new AplicationDBContext();

        var odczyt = (from s in aplicationDBContext.Employees
                      where numerPracownika == s.EnovaId.ToString()
                      select s).FirstOrDefault();

        if (odczyt != null)
        {
            return odczyt.FirstName.Remove(1) + ". " + odczyt.LastName;
        }

        return "";
    }

    #endregion

    #region Wydajność
    void PrzeliczenieWydajności(string stanowisko)
    {
        switch (stanowisko)
        {
            case "MPUSZKI":
                {
                    int dobre = ((List<int>)wykresPuszka[0].Values).Sum();
                    int złe = ((List<int>)wykresPuszka[1].Values).Sum();
                    PasekWydajnośćRamiak.Value = (double)dobre / (double)(dobre + złe) * 100d;
                };
                break;
            case "KJ1":
                {
                    int dobre = ((List<int>)wykresKJ[0].Values).Sum();
                    int złe = ((List<int>)wykresKJ[1].Values).Sum();
                    PasekWydajnośćKontrolaJakości.Value = (double)dobre / (double)(dobre + złe) * 100d;
                };
                break;
            case "STEMAS":
                {
                    int dobre = ((List<int>)wykresStemas[0].Values).Sum();
                    int złe = ((List<int>)wykresStemas[1].Values).Sum();
                    PasekWydajnośćStemas.Value = (double)dobre / (double)(dobre + złe) * 100d;
                };
                break;
            case "MONTAZ1":
                {
                    int dobre = ((List<int>)wykresMontaż1[0].Values).Sum();
                    int złe = ((List<int>)wykresMontaż1[1].Values).Sum();
                    PasekWydajnośćMontaż1.Value = (double)dobre / (double)(dobre + złe) * 100d;
                };
                break;
            case "MONTAZ2":
                {
                    int dobre = ((List<int>)wykresMontaż2[0].Values).Sum();
                    int złe = ((List<int>)wykresMontaż2[1].Values).Sum();
                    PasekWydajnośćMontaż2.Value = (double)dobre / (double)(dobre + złe) * 100d;
                };
                break;
            case "MONTAZ3":
                {
                    int dobre = ((List<int>)wykresMontaż3[0].Values).Sum();
                    int złe = ((List<int>)wykresMontaż3[1].Values).Sum();
                    PasekWydajnośćMontaż3.Value = (double)dobre / (double)(dobre + złe) * 100d;
                };
                break;
            case "MONTAZ4":
                {
                    int dobre = ((List<int>)wykresMontaż4[0].Values).Sum();
                    int złe = ((List<int>)wykresMontaż4[1].Values).Sum();
                    PasekWydajnośćMontaż4.Value = (double)dobre / (double)(dobre + złe) * 100d;
                };
                break;
            case "MONTAZ5":
                {
                    int dobre = ((List<int>)wykresMontaż5[0].Values).Sum();
                    int złe = ((List<int>)wykresMontaż5[1].Values).Sum();
                    PasekWydajnośćMontaż5.Value = (double)dobre / (double)(dobre + złe) * 100d;
                };
                break;
            default:
                break;
        }
    }
    #endregion

    #region Cel
    void PrzeliczenieCelu(string stanowisko)
    {
        switch (stanowisko)
        {
            case "MPUSZKI":
                {
                    int dobre = ((List<int>)wykresPuszka[0].Values).Sum();
                    PasekCelWydajnośćRamiak.Value = (double)dobre / (double)cel * 100d;
                };
                break;
            case "KJ1":
                {
                    int dobre = ((List<int>)wykresKJ[0].Values).Sum();
                    PasekCelWydajnośćKontrolaJakości.Value = (double)dobre / (double)cel * 100d;
                };
                break;
            case "STEMAS":
                {
                    int dobre = ((List<int>)wykresStemas[0].Values).Sum();
                    PasekCelWydajnośćStemas.Value = (double)dobre / (double)cel * 100d;
                };
                break;
            case "MONTAZ1":
                {
                    int dobre = ((List<int>)wykresMontaż1[0].Values).Sum();
                    PasekCelWydajnośćMontaż1.Value = (double)dobre / (double)cel * 100d;
                };
                break;
            case "MONTAZ2":
                {
                    int dobre = ((List<int>)wykresMontaż2[0].Values).Sum();
                    PasekCelWydajnośćMontaż2.Value = (double)dobre / (double)cel * 100d;
                };
                break;
            case "MONTAZ3":
                {
                    int dobre = ((List<int>)wykresMontaż3[0].Values).Sum();
                    PasekCelWydajnośćMontaż3.Value = (double)dobre / (double)cel * 100d;
                };
                break;
            case "MONTAZ4":
                {
                    int dobre = ((List<int>)wykresMontaż4[0].Values).Sum();
                    PasekCelWydajnośćMontaż4.Value = (double)dobre / (double)cel * 100d;
                };
                break;
            case "MONTAZ5":
                {
                    int dobre = ((List<int>)wykresMontaż5[0].Values).Sum();
                    PasekCelWydajnośćMontaż5.Value = (double)dobre / (double)cel * 100d;
                };
                break;
            default:
                break;
        }
    }
    #endregion

    private void DziśHistoriaOdczytów_Click(object sender, RoutedEventArgs e)
    {
        kalendarzOdHistoriaOdczytów.SelectedDate = DateTime.Now;
        kalendarzDoHistoriaOdczytów.SelectedDate = DateTime.Now.AddDays(1);
        NadanieParametrówTymczasowychHistoriaOdczytów();
        GenerowanieListyHistoriaZamówień(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(1));
    }

    private void TrzyDniHistoriaOdczytów_Click(object sender, RoutedEventArgs e)
    {
        kalendarzOdHistoriaOdczytów.SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-2);
        kalendarzDoHistoriaOdczytów.SelectedDate = DateTime.Now.AddDays(1);
        NadanieParametrówTymczasowychHistoriaOdczytów();
        GenerowanieListyHistoriaZamówień(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-2), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(1));
    }

    private void SiedemDniHistoriaOdczytów_Click(object sender, RoutedEventArgs e)
    {
        kalendarzOdHistoriaOdczytów.SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-6);
        kalendarzDoHistoriaOdczytów.SelectedDate = DateTime.Now.AddDays(1);
        NadanieParametrówTymczasowychHistoriaOdczytów();
        GenerowanieListyHistoriaZamówień(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-6), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(1));
    }

    private void MiesiącHistoriaOdczytów_Click(object sender, RoutedEventArgs e)
    {
        kalendarzOdHistoriaOdczytów.SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddMonths(-1);
        kalendarzDoHistoriaOdczytów.SelectedDate = DateTime.Now.AddDays(1);
        NadanieParametrówTymczasowychHistoriaOdczytów();
        GenerowanieListyHistoriaZamówień(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddMonths(-1), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(1));
    }

    private void PrzejdzButtonHistoriaOdczytów_Click(object sender, RoutedEventArgs e)
    {
        if (kalendarzOdHistoriaOdczytów.SelectedDate != null && kalendarzOdHistoriaOdczytów.SelectedDate != null)
        {
            DateTime dateTimePoczątkowa = kalendarzOdHistoriaOdczytów.SelectedDate.Value;
            DateTime dateTimeKońcowa = kalendarzDoHistoriaOdczytów.SelectedDate.Value;
            NadanieParametrówTymczasowychHistoriaOdczytów();
            GenerowanieListyHistoriaZamówień(new DateTime(dateTimePoczątkowa.Year, dateTimePoczątkowa.Month, dateTimePoczątkowa.Day), new DateTime(dateTimeKońcowa.Year, dateTimeKońcowa.Month, dateTimeKońcowa.Day));
        }
    }

    private void ResetujButtonHistoriaOdczytów_Click(object sender, RoutedEventArgs e)
    {
        stanowiskoComboBoxHistoriaOdczytów.SelectedValue = "Wszystkie";
    }

    void NadanieParametrówTymczasowychHistoriaOdczytów()
    {
        StanowiskoHistoriaOdczytów = stanowiskoComboBoxHistoriaOdczytów.SelectedValue.ToString();
    }
}
