using System.Windows.Forms;

namespace HotDrinksVendingMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            twoEuro_pictureBox = new PictureBox();
            oneEuro_pictureBox = new PictureBox();
            fiftyCent_pictureBox = new PictureBox();
            twentyCent_pictureBox = new PictureBox();
            tenCent_pictureBox = new PictureBox();
            fiveCent_pictureBox = new PictureBox();
            tea_label = new Label();
            tea_pictureBox = new PictureBox();
            chocolate_label = new Label();
            chocolate_pictureBox = new PictureBox();
            cappuccino_pictureBox = new PictureBox();
            coffee_label = new Label();
            confirmInsertion_button = new Button();
            insertedValue_label = new Label();
            cappuccino_label = new Label();
            change_label = new Label();
            changeCoins_label = new Label();
            insertCoins_label = new Label();
            takeChange_button = new Button();
            machine_pictureBox = new PictureBox();
            coffee_pictureBox = new PictureBox();
            selectDrink_label = new Label();
            preparing_timer = new System.Windows.Forms.Timer(components);
            preparing_textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)twoEuro_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oneEuro_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiftyCent_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)twentyCent_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tenCent_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiveCent_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tea_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chocolate_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cappuccino_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)machine_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffee_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // twoEuro_pictureBox
            // 
            twoEuro_pictureBox.Image = Properties.Resources.chrome_PtjGd9x9jM;
            twoEuro_pictureBox.Location = new Point(390, 53);
            twoEuro_pictureBox.Name = "twoEuro_pictureBox";
            twoEuro_pictureBox.Size = new Size(61, 61);
            twoEuro_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            twoEuro_pictureBox.TabIndex = 8;
            twoEuro_pictureBox.TabStop = false;
            twoEuro_pictureBox.Click += twoEuro_pictureBox_Click;
            // 
            // oneEuro_pictureBox
            // 
            oneEuro_pictureBox.BackColor = Color.White;
            oneEuro_pictureBox.Image = Properties.Resources.euro_coins_europe_money_1_euro_coin_eur;
            oneEuro_pictureBox.Location = new Point(457, 53);
            oneEuro_pictureBox.Name = "oneEuro_pictureBox";
            oneEuro_pictureBox.Size = new Size(61, 61);
            oneEuro_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            oneEuro_pictureBox.TabIndex = 10;
            oneEuro_pictureBox.TabStop = false;
            oneEuro_pictureBox.Click += oneEuro_pictureBox_Click;
            // 
            // fiftyCent_pictureBox
            // 
            fiftyCent_pictureBox.Image = Properties.Resources._50_cent_euro_coin_euro_coins_euro_coin_png_image;
            fiftyCent_pictureBox.Location = new Point(390, 120);
            fiftyCent_pictureBox.Name = "fiftyCent_pictureBox";
            fiftyCent_pictureBox.Size = new Size(61, 61);
            fiftyCent_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            fiftyCent_pictureBox.TabIndex = 12;
            fiftyCent_pictureBox.TabStop = false;
            fiftyCent_pictureBox.Click += fiftyCent_pictureBox_Click;
            // 
            // twentyCent_pictureBox
            // 
            twentyCent_pictureBox.Image = Properties.Resources._20_cent_euro_coin_euro_coins_1_cent_euro_coin_euro;
            twentyCent_pictureBox.Location = new Point(457, 120);
            twentyCent_pictureBox.Name = "twentyCent_pictureBox";
            twentyCent_pictureBox.Size = new Size(61, 61);
            twentyCent_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            twentyCent_pictureBox.TabIndex = 14;
            twentyCent_pictureBox.TabStop = false;
            twentyCent_pictureBox.Click += twentyCent_pictureBox_Click;
            // 
            // tenCent_pictureBox
            // 
            tenCent_pictureBox.Image = Properties.Resources.chrome_x5idlnwB1T;
            tenCent_pictureBox.Location = new Point(390, 187);
            tenCent_pictureBox.Name = "tenCent_pictureBox";
            tenCent_pictureBox.Size = new Size(61, 61);
            tenCent_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tenCent_pictureBox.TabIndex = 16;
            tenCent_pictureBox.TabStop = false;
            tenCent_pictureBox.Click += tenCent_pictureBox_Click;
            // 
            // fiveCent_pictureBox
            // 
            fiveCent_pictureBox.Image = Properties.Resources._5_eurocent_common_1999;
            fiveCent_pictureBox.Location = new Point(457, 187);
            fiveCent_pictureBox.Name = "fiveCent_pictureBox";
            fiveCent_pictureBox.Size = new Size(61, 61);
            fiveCent_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            fiveCent_pictureBox.TabIndex = 18;
            fiveCent_pictureBox.TabStop = false;
            fiveCent_pictureBox.Click += fiveCent_pictureBox_Click;
            // 
            // tea_label
            // 
            tea_label.AutoSize = true;
            tea_label.Enabled = false;
            tea_label.Location = new Point(243, 309);
            tea_label.Name = "tea_label";
            tea_label.Size = new Size(63, 15);
            tea_label.TabIndex = 29;
            tea_label.Text = "Tea (0,20€)";
            tea_label.Click += tea_pictureBox_Click;
            // 
            // tea_pictureBox
            // 
            tea_pictureBox.Enabled = false;
            tea_pictureBox.Image = Properties.Resources.chrome_5bXBndFenU;
            tea_pictureBox.Location = new Point(234, 224);
            tea_pictureBox.Name = "tea_pictureBox";
            tea_pictureBox.Size = new Size(85, 82);
            tea_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tea_pictureBox.TabIndex = 28;
            tea_pictureBox.TabStop = false;
            tea_pictureBox.Click += tea_pictureBox_Click;
            // 
            // chocolate_label
            // 
            chocolate_label.AutoSize = true;
            chocolate_label.Enabled = false;
            chocolate_label.Location = new Point(96, 309);
            chocolate_label.Name = "chocolate_label";
            chocolate_label.Size = new Size(99, 15);
            chocolate_label.TabIndex = 27;
            chocolate_label.Text = "Chocolate (0,35€)";
            chocolate_label.Click += chocolate_pictureBox_Click;
            // 
            // chocolate_pictureBox
            // 
            chocolate_pictureBox.Enabled = false;
            chocolate_pictureBox.Image = Properties.Resources.chrome_PuM1mYgNxu;
            chocolate_pictureBox.Location = new Point(103, 224);
            chocolate_pictureBox.Name = "chocolate_pictureBox";
            chocolate_pictureBox.Size = new Size(85, 82);
            chocolate_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            chocolate_pictureBox.TabIndex = 26;
            chocolate_pictureBox.TabStop = false;
            chocolate_pictureBox.Click += chocolate_pictureBox_Click;
            // 
            // cappuccino_pictureBox
            // 
            cappuccino_pictureBox.Enabled = false;
            cappuccino_pictureBox.Image = Properties.Resources.chrome_pPKpnvYZnW;
            cappuccino_pictureBox.Location = new Point(234, 105);
            cappuccino_pictureBox.Name = "cappuccino_pictureBox";
            cappuccino_pictureBox.Size = new Size(85, 82);
            cappuccino_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cappuccino_pictureBox.TabIndex = 24;
            cappuccino_pictureBox.TabStop = false;
            cappuccino_pictureBox.Click += cappuccino_pictureBox_Click;
            // 
            // coffee_label
            // 
            coffee_label.AutoSize = true;
            coffee_label.Enabled = false;
            coffee_label.Location = new Point(112, 190);
            coffee_label.Name = "coffee_label";
            coffee_label.Size = new Size(80, 15);
            coffee_label.TabIndex = 23;
            coffee_label.Text = "Coffee (0,25€)";
            coffee_label.Click += coffee_pictureBox_Click;
            // 
            // confirmInsertion_button
            // 
            confirmInsertion_button.Location = new Point(380, 278);
            confirmInsertion_button.Name = "confirmInsertion_button";
            confirmInsertion_button.Size = new Size(141, 57);
            confirmInsertion_button.TabIndex = 30;
            confirmInsertion_button.Text = "Confirm coin insertion";
            confirmInsertion_button.UseVisualStyleBackColor = true;
            confirmInsertion_button.Click += confirmInsertion_button_Click;
            // 
            // insertedValue_label
            // 
            insertedValue_label.AutoSize = true;
            insertedValue_label.Location = new Point(402, 352);
            insertedValue_label.Name = "insertedValue_label";
            insertedValue_label.Size = new Size(107, 15);
            insertedValue_label.TabIndex = 31;
            insertedValue_label.Text = "insertedValue_label";
            // 
            // cappuccino_label
            // 
            cappuccino_label.AutoSize = true;
            cappuccino_label.Enabled = false;
            cappuccino_label.Location = new Point(225, 190);
            cappuccino_label.Name = "cappuccino_label";
            cappuccino_label.Size = new Size(109, 15);
            cappuccino_label.TabIndex = 32;
            cappuccino_label.Text = "Cappuccino (0,30€)";
            cappuccino_label.Click += cappuccino_pictureBox_Click;
            // 
            // change_label
            // 
            change_label.AutoSize = true;
            change_label.Location = new Point(402, 379);
            change_label.Name = "change_label";
            change_label.Size = new Size(76, 15);
            change_label.TabIndex = 31;
            change_label.Text = "change_label";
            // 
            // changeCoins_label
            // 
            changeCoins_label.AutoSize = true;
            changeCoins_label.Location = new Point(402, 406);
            changeCoins_label.Name = "changeCoins_label";
            changeCoins_label.Size = new Size(106, 15);
            changeCoins_label.TabIndex = 33;
            changeCoins_label.Text = "changeCoins_label";
            // 
            // insertCoins_label
            // 
            insertCoins_label.AutoSize = true;
            insertCoins_label.Location = new Point(423, 19);
            insertCoins_label.Name = "insertCoins_label";
            insertCoins_label.Size = new Size(70, 15);
            insertCoins_label.TabIndex = 34;
            insertCoins_label.Text = "Insert coins:";
            // 
            // takeChange_button
            // 
            takeChange_button.BackColor = Color.White;
            takeChange_button.Enabled = false;
            takeChange_button.Location = new Point(384, 570);
            takeChange_button.Name = "takeChange_button";
            takeChange_button.Size = new Size(141, 37);
            takeChange_button.TabIndex = 35;
            takeChange_button.Text = "Take change";
            takeChange_button.UseVisualStyleBackColor = false;
            takeChange_button.Click += takeChange_button_Click;
            // 
            // machine_pictureBox
            // 
            machine_pictureBox.Image = Properties.Resources.chrome_ugfCkvfoGD;
            machine_pictureBox.Location = new Point(28, 3);
            machine_pictureBox.Name = "machine_pictureBox";
            machine_pictureBox.Size = new Size(493, 649);
            machine_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            machine_pictureBox.TabIndex = 37;
            machine_pictureBox.TabStop = false;
            // 
            // coffee_pictureBox
            // 
            coffee_pictureBox.Enabled = false;
            coffee_pictureBox.Image = Properties.Resources.chrome_wrMIlb2nyp;
            coffee_pictureBox.Location = new Point(103, 105);
            coffee_pictureBox.Name = "coffee_pictureBox";
            coffee_pictureBox.Size = new Size(85, 82);
            coffee_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            coffee_pictureBox.TabIndex = 38;
            coffee_pictureBox.TabStop = false;
            coffee_pictureBox.Click += coffee_pictureBox_Click;
            // 
            // selectDrink_label
            // 
            selectDrink_label.AutoSize = true;
            selectDrink_label.Enabled = false;
            selectDrink_label.Location = new Point(171, 86);
            selectDrink_label.Name = "selectDrink_label";
            selectDrink_label.Size = new Size(80, 15);
            selectDrink_label.TabIndex = 39;
            selectDrink_label.Text = "Select a drink:";
            // 
            // preparing_timer
            // 
            preparing_timer.Interval = 10000;
            preparing_timer.Tick += preparing_timer_Tick;
            // 
            // preparing_textBox
            // 
            preparing_textBox.Location = new Point(118, 394);
            preparing_textBox.Multiline = true;
            preparing_textBox.Name = "preparing_textBox";
            preparing_textBox.ReadOnly = true;
            preparing_textBox.Size = new Size(190, 39);
            preparing_textBox.TabIndex = 41;
            preparing_textBox.Text = "Purchase confirmed. Your drink is being prepared.";
            preparing_textBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 664);
            Controls.Add(preparing_textBox);
            Controls.Add(selectDrink_label);
            Controls.Add(coffee_pictureBox);
            Controls.Add(takeChange_button);
            Controls.Add(coffee_label);
            Controls.Add(cappuccino_pictureBox);
            Controls.Add(cappuccino_label);
            Controls.Add(chocolate_pictureBox);
            Controls.Add(insertCoins_label);
            Controls.Add(chocolate_label);
            Controls.Add(changeCoins_label);
            Controls.Add(tea_pictureBox);
            Controls.Add(change_label);
            Controls.Add(tea_label);
            Controls.Add(insertedValue_label);
            Controls.Add(confirmInsertion_button);
            Controls.Add(fiveCent_pictureBox);
            Controls.Add(tenCent_pictureBox);
            Controls.Add(twentyCent_pictureBox);
            Controls.Add(fiftyCent_pictureBox);
            Controls.Add(oneEuro_pictureBox);
            Controls.Add(twoEuro_pictureBox);
            Controls.Add(machine_pictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Hot Drinks Vending Machine";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)twoEuro_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)oneEuro_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiftyCent_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)twentyCent_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tenCent_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiveCent_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tea_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)chocolate_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cappuccino_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)machine_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffee_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox twoEuro_pictureBox;
        private PictureBox oneEuro_pictureBox;
        private PictureBox fiftyCent_pictureBox;
        private PictureBox twentyCent_pictureBox;
        private PictureBox tenCent_pictureBox;
        private PictureBox fiveCent_pictureBox;
        private Label tea_label;
        private PictureBox tea_pictureBox;
        private Label chocolate_label;
        private PictureBox chocolate_pictureBox;
        private PictureBox cappuccino_pictureBox;
        private Label coffee_label;
        private PictureBox coffee_pictureBox;
        private Button confirmInsertion_button;
        private Label insertedValue_label;
        private Label cappuccino_label;
        private Label change_label;
        private Label changeCoins_label;
        private Label insertCoins_label;
        private Label label2;
        private Button takeChange_button;
        private PictureBox machine_pictureBox;
        private Label selectDrink_label;
        private System.Windows.Forms.Timer preparing_timer;
        private TextBox preparing_textBox;
    }
}
