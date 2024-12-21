namespace HotDrinksVendingMachine;

public partial class Form1 : Form
{
    double insertedValue = 0, change = 0, price = 0;
    int twoEuroQuantity = 5, oneEuroQuantity = 5, fiftyCentQuantity = 5, twentyCentQuantity = 5, tenCentQuantity = 5, fiveCentQuantity = 5;
    System.Media.SoundPlayer preparing_sound = new System.Media.SoundPlayer(Properties.Resources.Making_coffee);

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        insertedValue_label.Text = "";
        change_label.Text = "";
        changeCoins_label.Text = "";
    }

    #region Coin insertion
    private void twoEuro_pictureBox_Click(object sender, EventArgs e)
    {
        insertedValue = insertedValue + 2;
        twoEuroQuantity++;
    }

    private void oneEuro_pictureBox_Click(object sender, EventArgs e)
    {
        insertedValue = insertedValue + 1;
        oneEuroQuantity++;
    }

    private void fiftyCent_pictureBox_Click(object sender, EventArgs e)
    {
        insertedValue = insertedValue + 0.50;
        fiftyCentQuantity++;
    }

    private void twentyCent_pictureBox_Click(object sender, EventArgs e)
    {
        insertedValue = insertedValue + 0.20;
        twentyCentQuantity++;
    }

    private void tenCent_pictureBox_Click(object sender, EventArgs e)
    {
        insertedValue = insertedValue + 0.10;
        tenCentQuantity++;
    }

    private void fiveCent_pictureBox_Click(object sender, EventArgs e)
    {
        insertedValue = insertedValue + 0.05;
        fiveCentQuantity++;
    }
    #endregion

    private void confirmInsertion_button_Click(object sender, EventArgs e)
    {
        if (insertedValue > 0)
        {
            insertCoins_label.Enabled = false;
            twoEuro_pictureBox.Enabled = false;
            oneEuro_pictureBox.Enabled = false;
            fiftyCent_pictureBox.Enabled = false;
            twentyCent_pictureBox.Enabled = false;
            tenCent_pictureBox.Enabled = false;
            fiveCent_pictureBox.Enabled = false;
            confirmInsertion_button.Enabled = false;
            selectDrink_label.Enabled = true;
            coffee_pictureBox.Enabled = true;
            coffee_label.Enabled = true;
            cappuccino_pictureBox.Enabled = true;
            cappuccino_label.Enabled = true;
            chocolate_pictureBox.Enabled = true;
            chocolate_label.Enabled = true;
            tea_pictureBox.Enabled = true;
            tea_label.Enabled = true;
            insertedValue_label.Text = $"Inserted value: {Math.Round(insertedValue, 2)}€";
        }
        else
        {
            CancelOperation();
            MessageBox.Show("No coins were inserted. Operation cancelled.");
        }
    }

    #region Drink selection
    private void coffee_pictureBox_Click(object sender, EventArgs e)
    {
        price = 0.25;
        change = insertedValue - price;
        ValidateOperation();
    }

    private void cappuccino_pictureBox_Click(object sender, EventArgs e)
    {
        price = 0.30;
        change = insertedValue - price;
        ValidateOperation();
    }

    private void chocolate_pictureBox_Click(object sender, EventArgs e)
    {
        price = 0.35;
        change = insertedValue - price;
        ValidateOperation();
    }

    private void tea_pictureBox_Click(object sender, EventArgs e)
    {
        price = 0.20;
        change = insertedValue - price;
        ValidateOperation();
    }
    #endregion

    private void ValidateOperation()
    {
        if (change >= 0)
        {
            change_label.Text = $"Change: {Math.Round(change, 2)}€";
            int twoEuroCounter = 0, oneEuroCounter = 0, fiftyCentCounter = 0, twentyCentCounter = 0, tenCentCounter = 0, fiveCentCounter = 0;
            PrepareDrink();
            while (change >= 0.05)
            {
                if (change >= 2)
                {
                    if (twoEuroQuantity > 0)
                    {
                        change = Math.Round(change - 2, 2);
                        twoEuroQuantity--;
                        twoEuroCounter++;
                    }
                    else
                    {
                        MessageBox.Show("The machine is out of coins. Please contact our support. We apologise for the inconvenience.");
                        CancelOperation();
                        break;
                    }
                }
                else if (change >= 1)
                {
                    if (oneEuroQuantity > 0)
                    {
                        change = Math.Round(change - 1, 2);
                        oneEuroQuantity--;
                        oneEuroCounter++;
                    }
                    else
                    {
                        MessageBox.Show("The machine is out of coins. Please contact our support. We apologise for the inconvenience.");
                        CancelOperation();
                        break;
                    }
                }
                else if (change >= 0.50)
                {
                    if (fiftyCentQuantity > 0)
                    {
                        change = Math.Round(change - 0.50, 2);
                        fiftyCentQuantity--;
                        fiftyCentCounter++;
                    }
                    else
                    {
                        MessageBox.Show("The machine is out of coins. Please contact our support. We apologise for the inconvenience.");
                        CancelOperation();
                        break;
                    }
                }
                else if (change >= 0.20)
                {
                    if (twentyCentQuantity > 0)
                    {
                        change = Math.Round(change - 0.20, 2);
                        twentyCentQuantity--;
                        twentyCentCounter++;
                    }
                    else
                    {
                        MessageBox.Show("The machine is out of coins. Please contact our support. We apologise for the inconvenience.");
                        CancelOperation();
                        break;
                    }
                }
                else if (change >= 0.10)
                {
                    if (tenCentQuantity > 0)
                    {
                        change = Math.Round(change - 0.10, 2);
                        tenCentQuantity--;
                        tenCentCounter++;
                    }
                    else
                    {
                        MessageBox.Show("The machine is out of coins. Please contact our support. We apologise for the inconvenience.");
                        CancelOperation();
                        break;
                    }
                }
                else if (change >= 0.05)
                {
                    if (fiveCentQuantity > 0)
                    {
                        change = Math.Round(change - 0.05, 2);
                        fiveCentQuantity--;
                        fiveCentCounter++;
                    }
                    else
                    {
                        MessageBox.Show("The machine is out of coins. Please contact our support. We apologise for the inconvenience.");
                        CancelOperation();
                        break;
                    }
                }
                changeCoins_label.Text = $"Coins to receive in change: \n2€: {twoEuroCounter}\n1€: {oneEuroCounter}\n0,50€: {fiftyCentCounter}\n0,20€: {twentyCentCounter}\n0,10€: {tenCentCounter}\n0,05€: {fiveCentCounter}";
            }
        }
        else
        {
            MessageBox.Show("Inserted value not sufficient. Operation cancelled.");
            change_label.Text = $"Change: {Math.Round(insertedValue, 2)}€";
            takeChange_button.Enabled = true;
            CancelOperation();
        }
    }

    private void CancelOperation()
    {
        selectDrink_label.Enabled = false;
        coffee_pictureBox.Enabled = false;
        coffee_label.Enabled = false;
        cappuccino_pictureBox.Enabled = false;
        cappuccino_label.Enabled = false;
        chocolate_pictureBox.Enabled = false;
        chocolate_label.Enabled = false;
        tea_pictureBox.Enabled = false;
        tea_label.Enabled = false;
    }

    private void PrepareDrink()
    {
        selectDrink_label.Enabled = false;
        coffee_pictureBox.Enabled = false;
        coffee_label.Enabled = false;
        cappuccino_pictureBox.Enabled = false;
        cappuccino_label.Enabled = false;
        chocolate_pictureBox.Enabled = false;
        chocolate_label.Enabled = false;
        tea_pictureBox.Enabled = false;
        tea_label.Enabled = false;
        preparing_textBox.Visible = true;
        preparing_timer.Start();
        preparing_sound.Play();
    }

    private void takeChange_button_Click(object sender, EventArgs e)
    {
        insertedValue_label.Text = "";
        change_label.Text = "";
        changeCoins_label.Text = "";
        takeChange_button.Enabled = false;
        insertedValue = 0;
        change = 0;
        insertCoins_label.Enabled = true;
        twoEuro_pictureBox.Enabled = true;
        oneEuro_pictureBox.Enabled = true;
        fiftyCent_pictureBox.Enabled = true;
        twentyCent_pictureBox.Enabled = true;
        tenCent_pictureBox.Enabled = true;
        fiveCent_pictureBox.Enabled = true;
        confirmInsertion_button.Enabled = true;
    }

    private void preparing_timer_Tick(object sender, EventArgs e)
    {
        preparing_timer.Stop();
        takeChange_button.Enabled = true;
        preparing_textBox.Visible = false;
    }
}