namespace BrokenStats.UserControls;

public partial class UC_EssenceCalculator : UserControl
{
    public UC_EssenceCalculator()
    {
        InitializeComponent();
    }

    private void toggleButtonSetItem_CheckedChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1)
        {
            CalculateProfit();
        }
    }

    private void toggleButtonSynergetyk_CheckedChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1)
        {
            CalculateProfit();
        }
    }

    private void toggleButtonTargPremium_CheckedChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1)
        {
            CalculateProfit();
        }
    }

    private void toggleButtonInhibitor_CheckedChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1)
        {
            CalculateProfit();
        }
    }

    private void customComboBoxGwiazdki_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1 )
        {
            CalculateProfit();
        }
    }

    private void customComboBoxRanga_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1)
        {
            CalculateProfit();
        }
    }

    private void customTextBoxCenaPlatyny__TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1)
        {
            CalculateProfit();
        }
    }

    private void customTextBoxCenaEsencji__TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1)
        {
            CalculateProfit();
        }
    }

    private void customTextBoxCenaOdlamkow__TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaPlatyny.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaEsencji.Text) &&
            !string.IsNullOrWhiteSpace(customTextBoxCenaOdlamkow.Text) &&
            customComboBoxGwiazdki.SelectedIndex != -1 &&
            customComboBoxRanga.SelectedIndex != -1)
        {
            CalculateProfit();
        }
    }


    private void customTextBoxCenaPrzedmiotu__TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text))
        {
            customTextBoxCenaPrzedmiotu.Text = "0";
            customTextBoxCenaPrzedmiotu.SelectionStart = customTextBoxCenaPrzedmiotu.Text.Length;
        }
    }

    private void customTextBoxCenaPrzedmiotu__Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text)) customTextBoxCenaPrzedmiotu.Text = "0";
    }


    private void CalculateProfit()
    {
        labelCenaWOdlamkachPo.BackColor = Color.Gainsboro;
        labelCenaWEsencjachPo.BackColor = Color.Gainsboro;
        try
        {
            var setItem = toggleButtonSetItem.Checked;
            var synergetyk = toggleButtonSynergetyk.Checked;
            var targPremium = toggleButtonTargPremium.Checked;
            var inhibitor = toggleButtonInhibitor.Checked;
            var gwiazdki = customComboBoxGwiazdki.SelectedIndex;
            var ranga = customComboBoxRanga.SelectedIndex;

            decimal cenaInhibitoraGold = 0;
            decimal iloscEsencji;
            decimal iloscOdlamkow;
            if (!decimal.TryParse(customTextBoxCenaPlatyny.Text, out var cenaPlatyny))
                throw new FormatException("Cena platyny musi być liczbą. Podano: " + customTextBoxCenaPlatyny.Text);
            if (!decimal.TryParse(customTextBoxCenaEsencji.Text, out var cenaEsencji))
                throw new FormatException("Cena esencji musi być liczbą.");
            if (!decimal.TryParse(customTextBoxCenaOdlamkow.Text, out var cenaOdlamkow))
                throw new FormatException("Cena odłamków musi być liczbą.");
            if (!decimal.TryParse(customTextBoxCenaPrzedmiotu.Text, out var cenaPrzedmiotu))
                throw new FormatException("Cena przedmiotu musi być liczbą.");
            if (cenaPlatyny < 0 || cenaEsencji < 0 || cenaOdlamkow < 0 || cenaPrzedmiotu < 0)
                throw new ArgumentOutOfRangeException("Ceny nie mogą być ujemne.");


            if (customComboBoxGwiazdki.SelectedIndex != -1)
            {
                if (customComboBoxGwiazdki.SelectedItem is decimal wybranaGwiazdka)
                    Console.WriteLine(@"Wybrana gwiazdka: " + wybranaGwiazdka);
                else
                    Console.WriteLine(@"Nieprawidłowy format gwiazdki.");
            }
            else
            {
                throw new InvalidOperationException("Nie wybrano gwiazdki.");
            }

            if (customComboBoxRanga.SelectedIndex != -1)
            {
                if (customComboBoxRanga.SelectedItem is decimal wybranaRanga)
                    Console.WriteLine(@"Wybrana Ranga: " + wybranaRanga);
                else
                    Console.WriteLine(@"Nieprawidłowy format rangi.");
            }
            else
            {
                throw new InvalidOperationException("Nie wybrano rangi.");
            }


            int[,] odlamkowRaryBezInhibitora =
            {
                { 3, 5, 8, 12, 20, 30, 50, 100, 250 },
                { 15, 20, 40, 60, 100, 150, 250, 500, 1250 },
                { 75, 100, 200, 300, 500, 750, 1250, 2500, 6500 },
                { 300, 500, 1000, 1500, 2500, 4000, 6500, 12500, 30000 }
            };

            int[,] odlamkowRaryZInhibitorem =
            {
                { 4, 7, 11, 16, 26, 39, 65, 130, 325 },
                { 20, 26, 52, 78, 130, 195, 325, 650, 1625 },
                { 98, 130, 260, 390, 650, 975, 1625, 3250, 8450 },
                { 390, 650, 1300, 1950, 3250, 5200, 8450, 16250, 39000 }
            };

            int[,] odlamkowSetyBezInhibitora =
            {
                { 5, 8, 12, 18, 30, 45, 75, 150, 350 },
                { 20, 30, 50, 100, 150, 250, 400, 750, 1800 },
                { 90, 120, 250, 450, 750, 1100, 2000, 4000, 9000 },
                { 350, 550, 1200, 2200, 4000, 6000, 10000, 20000, 45000 }
            };

            int[,] odlamkowSetyZInhibitorem =
            {
                { 7, 11, 16, 24, 39, 59, 98, 195, 455 },
                { 26, 39, 65, 130, 195, 325, 520, 975, 2340 },
                { 117, 156, 325, 585, 975, 1430, 2600, 5200, 11700 },
                { 455, 715, 1560, 2860, 5200, 7800, 13000, 26000, 58500 }
            };

            int[] esencjeBezInhibitora =
            [
                2, 5, 12, 24, 32, 40, 55, 70, 85, 115, 145, 175
            ];


            int[] esencjeZInhibitorem =
            [
                3, 7, 16, 32, 42, 52, 72, 91, 111, 150, 189, 228
            ];

            void AssignValues(int ranga, int gwiazdki, bool inhibitor, bool isSet)
            {
                var rangaIndex = (ranga - 1) / 3; // wiersz
                var gwiazdkiIndex = gwiazdki; // kolumna

                if (isSet)
                {
                    if (inhibitor)
                    {
                        iloscOdlamkow = odlamkowSetyZInhibitorem[rangaIndex, gwiazdkiIndex];
                        iloscEsencji = esencjeZInhibitorem[ranga];
                    }
                    else
                    {
                        iloscOdlamkow = odlamkowSetyBezInhibitora[rangaIndex, gwiazdkiIndex];
                        iloscEsencji = esencjeBezInhibitora[ranga];
                    }
                }
                else
                {
                    if (inhibitor)
                    {
                        iloscOdlamkow = odlamkowRaryZInhibitorem[rangaIndex, gwiazdkiIndex];
                        iloscEsencji = esencjeZInhibitorem[ranga];
                    }
                    else
                    {
                        iloscOdlamkow = odlamkowRaryBezInhibitora[rangaIndex, gwiazdkiIndex];
                        iloscEsencji = esencjeBezInhibitora[ranga];
                    }
                }

                switch (ranga)
                {
                    case 1:
                        cenaInhibitoraGold = cenaPlatyny * 3;
                        break;

                    case 2:
                    case 3:
                        cenaInhibitoraGold = cenaPlatyny * 4;
                        break;

                    case 4:
                        cenaInhibitoraGold = cenaPlatyny * 5;
                        break;

                    case 5:
                    case 6:
                        cenaInhibitoraGold = cenaPlatyny * 6;
                        break;

                    case 7:
                        cenaInhibitoraGold = cenaPlatyny * 7;
                        break;

                    case 8:
                    case 9:
                        cenaInhibitoraGold = cenaPlatyny * 8;
                        break;

                    case 10:
                        cenaInhibitoraGold = cenaPlatyny * 10;
                        break;

                    case 11:
                    case 12:
                        cenaInhibitoraGold = cenaPlatyny * 12;
                        break;
                }
            }

            AssignValues(ranga, gwiazdki, inhibitor, setItem);

            int[,] esencjePotrzebneDoRozbicia =
            {
                { 1, 5, 25 },
                { 2, 10, 50 },
                { 3, 15, 70 },
                { 4, 20, 100 }
            };

            int GetEsencje(int ranga, int gwiazdki)
            {
                var rangaIndex = (ranga - 1) / 3;
                var gwiazdkiIndex = (gwiazdki - 1) / 3;
                return esencjePotrzebneDoRozbicia[rangaIndex, gwiazdkiIndex];
            }


            var cenaWOdlamkachGold = iloscOdlamkow * cenaOdlamkow - GetEsencje(ranga, gwiazdki) * cenaEsencji - 20000;

            var cenaWEsencjachGold = iloscEsencji * cenaEsencji - 20000;


            if (synergetyk)
            {
                cenaWEsencjachGold /= 2;
                cenaWOdlamkachGold /= 2;
            }

            if (targPremium)
            {
                cenaWEsencjachGold = cenaWEsencjachGold * 98 / 100;
                cenaWOdlamkachGold = cenaWOdlamkachGold * 98 / 100;
            }
            else
            {
                cenaWEsencjachGold = cenaWEsencjachGold * 96 / 100;
                cenaWOdlamkachGold = cenaWOdlamkachGold * 96 / 100;
            }


            if (inhibitor)
            {
                cenaWOdlamkachGold -= cenaInhibitoraGold;
                cenaWEsencjachGold -= cenaInhibitoraGold;
            }


            var profitGold = Math.Max(cenaWOdlamkachGold, cenaWEsencjachGold) - cenaPrzedmiotu;
            var profitPlat = profitGold / cenaPlatyny;

            // Aktualizacja labela
            labelIloscEsencji.Text = iloscEsencji.ToString("0");
            labelIloscOdlamkow.Text = iloscOdlamkow.ToString("0");
            labelCenaWEsencjachPo.Text = cenaWEsencjachGold.ToString("0");
            labelCenaWOdlamkachPo.Text = cenaWOdlamkachGold.ToString("0");
            labelProfitGold.Text = profitGold.ToString("0");
            labelProfitPlat.Text = profitPlat.ToString("0");
            if (cenaWOdlamkachGold > cenaWEsencjachGold)
                labelCenaWOdlamkachPo.BackColor = Color.ForestGreen;
            else
                labelCenaWEsencjachPo.BackColor = Color.ForestGreen;
        }
        catch (FormatException ex)

        {
            MessageBox.Show(@"Błąd formatu danych: " + ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            MessageBox.Show(@"Błąd wartości danych: " + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"Niespodziewany błąd: " + ex.Message);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        CalculateProfit();
    }
}