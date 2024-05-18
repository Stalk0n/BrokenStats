namespace BrokenStats.UserControls
{
    public partial class UC_EssenceCalculator : UserControl
    {
        public UC_EssenceCalculator()
        {
            InitializeComponent();
        }

        private void toggleButtonSetItem_CheckedChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void toggleButtonSynergetyk_CheckedChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void toggleButtonTargPremium_CheckedChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void toggleButtonInhibitor_CheckedChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void customComboBoxGwiazdki_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void customComboBoxRanga_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void customTextBoxCenaPlatyny__TextChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void customTextBoxCenaEsencji__TextChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void customTextBoxCenaOdlamkow__TextChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void customTextBoxCenaPrzedmiotu__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text))
            {
                customTextBoxCenaPrzedmiotu.Text = "0";
                customTextBoxCenaPrzedmiotu.SelectionStart = customTextBoxCenaPrzedmiotu.Text.Length;
            }
            CalculateProfit();
        }

        private void customTextBoxCenaPrzedmiotu__Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customTextBoxCenaPrzedmiotu.Text))
            {
                customTextBoxCenaPrzedmiotu.Text = "0";
            }
            CalculateProfit();
        }

        private void CalculateProfit()
        {
            try
            {
                bool setItem = toggleButtonSetItem.Checked;
                bool synergetyk = toggleButtonSynergetyk.Checked;
                bool targPremium = toggleButtonTargPremium.Checked;
                bool inhibitor = toggleButtonInhibitor.Checked;
                int gwiazdki = customComboBoxGwiazdki.SelectedIndex;
                int ranga = customComboBoxRanga.SelectedIndex;
                decimal cenaInhibitoraGold = 0;
                if (!decimal.TryParse(customTextBoxCenaPlatyny.Text, out decimal cenaPlatyny))
                {
                    throw new FormatException("Cena platyny musi być liczbą. Podano: " + customTextBoxCenaPlatyny.Text);
                }
                if (!decimal.TryParse(customTextBoxCenaEsencji.Text, out decimal cenaEsencji))
                {
                    throw new FormatException("Cena esencji musi być liczbą.");
                }
                if (!decimal.TryParse(customTextBoxCenaOdlamkow.Text, out decimal cenaOdlamkow))
                {
                    throw new FormatException("Cena odłamków musi być liczbą.");
                }
                if (!decimal.TryParse(customTextBoxCenaPrzedmiotu.Text, out decimal cenaPrzedmiotu))
                {
                    throw new FormatException("Cena przedmiotu musi być liczbą.");
                }
                if (cenaPlatyny < 0 || cenaEsencji < 0 || cenaOdlamkow < 0 || cenaPrzedmiotu < 0)
                {
                    throw new ArgumentOutOfRangeException("Ceny nie mogą być ujemne.");
                }


                if (ranga == 1)
                {
                    cenaInhibitoraGold = cenaPlatyny * 3;
                }
                else if (ranga == 2 || ranga == 3)
                {
                    cenaInhibitoraGold = cenaPlatyny * 4;
                }
                else if (ranga == 4)
                {
                    cenaInhibitoraGold = cenaPlatyny * 5;
                }
                else if (ranga == 5 || ranga == 6)
                {
                    cenaInhibitoraGold = cenaPlatyny * 6;
                }
                else if (ranga == 7)
                {
                    cenaInhibitoraGold = cenaPlatyny * 7;
                }
                else if (ranga == 8 || ranga == 9)
                {
                    cenaInhibitoraGold = cenaPlatyny * 8;
                }
                else if (ranga == 10)
                {
                    cenaInhibitoraGold = cenaPlatyny * 10;
                }
                else if (ranga == 11 || ranga == 12)
                {
                    cenaInhibitoraGold = cenaPlatyny * 12;
                }


                decimal cenaWEsencjachGold = cenaPrzedmiotu - (cenaInhibitoraGold);
                decimal cenaWOdlamkachGold = cenaPrzedmiotu - (cenaInhibitoraGold);

                if (setItem)
                {
                    cenaWEsencjachGold += 100; // Przykładowa wartość
                    cenaWOdlamkachGold += 100; // Przykładowa wartość
                }

                if (synergetyk)
                {
                    cenaWEsencjachGold += 50; // Przykładowa wartość
                    cenaWOdlamkachGold += 50; // Przykładowa wartość
                }

                if (targPremium)
                {
                    cenaWEsencjachGold = (cenaWEsencjachGold * 96) / 100; // Przykładowa wartość
                }

                if (inhibitor)
                {
                    cenaWEsencjachGold += 30; // Przykładowa wartość
                }

                // Modyfikacja zysków na podstawie gwiazdek i rangi
                cenaWEsencjachGold = cenaWEsencjachGold * (1 + (gwiazdki * 0.1m));
                cenaWEsencjachGold *= (1 + (ranga * 0.05m));

                // Aktualizacja labela
                labelCenaWEsencjachPo.Text = cenaWEsencjachGold.ToString("C2");
            }
            catch (FormatException ex) { }
            //{
            //    MessageBox.Show("Błąd formatu danych: " + ex.Message);
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    MessageBox.Show("Błąd wartości danych: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Niespodziewany błąd: " + ex.Message);
            //}
        }
    }
}
