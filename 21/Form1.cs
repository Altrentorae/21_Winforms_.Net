using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace _21
{
    

    public partial class Form1 : Form
    {
        
        usrSettings ursSettingsMenu = new usrSettings();
        public initSettingParse initSettings = new initSettingParse();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initSettings.startupSettings.ShowDialog();
            initSettings.fetchSettings();

            AceChangeActive = initSettings.AceSet;
            PlayerOne.money = initSettings.startMoney;           

            Dealer.C1.drawCard();
            PlayerOne.C1.drawCard();
            PlayerOne.C2.drawCard();
            betAmount_INIT();
            updateLabels();
            checkTotals();
            betAmount.Minimum = 25; betAmount.Value = 25; betLabel.Text = "25";
            ursSettingsMenu.setLin();
            
        }
        
        Player PlayerOne = new Player();
        Player Dealer = new Player();
        public void updateLabels()
        {
            label1.Text = PlayerOne.C1.display;
            label2.Text = PlayerOne.C2.display;
            label3.Text = PlayerOne.C3.display;
            label4.Text = PlayerOne.C4.display;
            label5.Text = PlayerOne.C5.display;
            dealbox1.Text = Dealer.C1.display;
            dealbox2.Text = Dealer.C2.display;
            dealbox3.Text = Dealer.C3.display;
            dealbox4.Text = Dealer.C4.display;
            dealbox5.Text = Dealer.C5.display;
            moneyLabel.Text = PlayerOne.money.ToString();
            betLabel.Text = PlayerOne.bet.ToString() ;
            if (betAmount.Value < minBet) { betAmount.Value = minBet; betLabel.Text = minBet.ToString(); }

            
            
        }
        public void buttonControl(bool state, bool lockOnly = false)
        {
            if (!lockOnly)
            {
                buttonDraw.Enabled = state;
                buttonLock.Enabled = state;
                if (initSettings.AceSet == true)
                {
                    AceChangeActive = state;
                }
            }
            else
            {
                buttonLock.Enabled = state;
                if (state)
                {
                    buttonLock.BackColor = Color.LightGray;
                }
                else
                {
                    buttonLock.BackColor = Color.DarkGray;
                }
                
            }
            if (state && !lockOnly)
            {
                buttonDraw.BackColor = Color.LightGray;
                buttonLock.BackColor = Color.LightGray;
            }
            else if (!state && !lockOnly)
            {
                buttonDraw.BackColor = Color.DarkGray;
                buttonLock.BackColor = Color.DarkGray;
            }
        }


        int minBet;

        private void betAmount_INIT(byte x = 0, int linearAmount = 50, int exponent = 2, int F = 8, bool Increment = true) //x = option //linearAmount = linear increase or x in (x^y)
        {
            ursSettingsMenu.simClick();
            x = ursSettingsMenu.getMode();
            linearAmount = ursSettingsMenu.LIN;
            exponent = ursSettingsMenu.EXP;
            F = ursSettingsMenu.FRA;
            Increment = ursSettingsMenu.INC;
            switch (x) //0 = linear //1 = Exponential //2 = fractional
            {
                case 0:  if (Increment) { minBet += linearAmount; betAmount.Minimum = minBet; } else { minBet = linearAmount; } break;
                case 1: for(int i=0; i<exponent; i++)
                    {
                        minBet += (minBet * minBet);
                    }
                    betAmount.Minimum = minBet;
                    break;
                case 2:
                    if (!(PlayerOne.money < 1))
                    {
                        if (PlayerOne.money % F != 0)
                        {
                            decimal p = Convert.ToDecimal(PlayerOne.money / F);
                            p = Math.Round(p, 0);
                            if (p == 0) { p = PlayerOne.money; }
                            betAmount.Minimum = (int)p;

                        }
                        else { betAmount.Minimum = (int) PlayerOne.money / F; }
                    }
                    else { betAmount.Minimum = minBet; }
                    break;
                    
            }
            


            betAmount.Maximum = (int) PlayerOne.money;
            betAmount.Enabled = true;
            betAmount.BackColor = Color.LightGray;
            //Minimum bet handling
            
            betLabel.Text = betAmount.Minimum.ToString();
            betAmount.Value = betAmount.Minimum;
            updateLabels();
        }


        private void buttonDraw_Click(object sender, EventArgs e)
        {
            PlayerOne.drawHandling();
            
            if (PlayerOne.count > 2) { betAmount.Enabled = false; betAmount.BackColor = Color.DarkGray;  buttonLock.Text = "Stay"; buttonDraw.Text = "Draw";
                PlayerOne.bet = (int)betAmount.Value;
                
                betAmount.Enabled = false;
            }
            if (PlayerOne.count == 3) { PlayerOne.money -= PlayerOne.bet; }
            if (PlayerOne.Total() > 20)
            {
                gameStateLbl.Text = "Loss by bust (BDC)";
                buttonControl(false);
            }
            if (PlayerOne.C5.value != 0) { buttonDraw.Enabled = false; buttonDraw.BackColor = Color.DarkGray; }
            checkTotals();
            updateLabels();
        }
        
        private void buttonLock_Click(object sender, EventArgs e)
        {
            buttonControl(false);
            PlayerOne.bet = (int) betAmount.Value;
            if (PlayerOne.count == 3) { PlayerOne.money -= PlayerOne.bet; }
            betAmount.Enabled = false; betAmount.BackColor = Color.DarkGray;
            buttonLock.Text = "Stay"; buttonDraw.Text = "Draw";
            
            POSTCHOICE();
            updateLabels();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            RESET();
        }
        public void RESET()
        {
            PlayerOne.reset();
            Dealer.reset();
            Dealer.C1.drawCard();
            PlayerOne.C1.drawCard();
            PlayerOne.C2.drawCard();
            buttonControl(true);
            betAmount_INIT();
            checkTotals();
            if (initSettings.AceSet == true) { AceChangeActive = true; }
            gameStateLbl.Text = "Your Turn"; buttonDraw.Text = "Draw and Bet"; buttonLock.Text = "Stay and Bet";
            buttonReset.Enabled = false;
            buttonReset.BackColor = Color.DarkGray;
            updateLabels();
            betAmount.Value = betAmount.Minimum; betLabel.Text = betAmount.Minimum.ToString();
            
        }
        private void POSTCHOICE(bool alt = false)
        {
            if (alt == true)
            {
                if (DealLogic(0) == false)
                {
                    PlayerOne.money += PlayerOne.bet * 2;
                    gameStateLbl.Text = "You Win DLF";
                }
                else if (DealLogic(0) == true) { gameStateLbl.Text = "You Lose ELDLF"; }
            }
            else
            {
                if (DealLogic() == false)
                {
                    PlayerOne.money += PlayerOne.bet * 2;
                    gameStateLbl.Text = "You Win DLF";
                }
                else if (DealLogic() == true) { gameStateLbl.Text = "You Lose ELDLF"; }
                else { PlayerOne.money += PlayerOne.bet; gameStateLbl.Text = "Tie"; }
            }
            updateLabels();

            System.Diagnostics.Debug.WriteLine("PlayerTotal " + PlayerOne.Total());
            System.Diagnostics.Debug.WriteLine("DealerTotal " +Dealer.Total());
            System.Diagnostics.Debug.WriteLine("PlayerValues");
            System.Diagnostics.Debug.WriteLine(PlayerOne.C1.value);
            System.Diagnostics.Debug.WriteLine(PlayerOne.C2.value);
            System.Diagnostics.Debug.WriteLine(PlayerOne.C3.value);
            System.Diagnostics.Debug.WriteLine(PlayerOne.C4.value);
            System.Diagnostics.Debug.WriteLine(PlayerOne.C5.value);
            System.Diagnostics.Debug.WriteLine("DealerValues");
            System.Diagnostics.Debug.WriteLine(Dealer.C1.value);
            System.Diagnostics.Debug.WriteLine(Dealer.C2.value);
            System.Diagnostics.Debug.WriteLine(Dealer.C3.value);
            System.Diagnostics.Debug.WriteLine(Dealer.C4.value);
            System.Diagnostics.Debug.WriteLine(Dealer.C5.value);
            
            if (PlayerOne.money <= 0)
            {
                gameStateLbl.Text = "Broke";
                buttonReset.Text = "Broke";
                moneyLabel.BackColor = Color.Red;
            }
            else
            {
                buttonReset.BackColor = Color.LightGray;
                buttonReset.Enabled = true;
            }
        }
        Random manipRnd = new Random();
        private bool? DealLogic(int maxnum = 16)
        {
            if (PlayerOne.Total() == 21) { return false; }
            
            Dealer.count = 1;
            if (initSettings.diff == 2)
            {

                
                while (Dealer.Total() < maxnum)
                {
                    Dealer.drawHandling();
                    updateLabels();
                    // System.Threading.Thread.Sleep(1000);
                }
            }

            if (initSettings.diff == 0) { while (Dealer.Total() < PlayerOne.Total() && Dealer.Total() < maxnum) { Dealer.drawHandling();updateLabels(); } ; }
            if (initSettings.diff == 1) { while (Dealer.Total() < PlayerOne.Total() - 2 && Dealer.Total() < maxnum) { Dealer.drawHandling(); updateLabels(); }; }
            if (initSettings.diff == 3) { while (Dealer.Total() < maxnum) { Dealer.drawHandling(); updateLabels(); }; }
            if (initSettings.diff == 4) { while (Dealer.Total() < PlayerOne.Total()) {
                    
                    //---//
                    int d = 21 - Dealer.Total();
                    bool end = false;
                    if (d > 10)
                    {
                        Dealer.drawHandling();
                    }
                    if (d <= 10)
                    {
                        Dealer.count++;
                        string disp = "ERR"; // ERR = Error
                        bool posOrNeg = false; //changed from p.or.N (porN) for obvious reason

                        
                        if (manipRnd.Next(1,3) == 1) { posOrNeg = true; } else { posOrNeg = false; }
                        int v = manipRnd.Next(1, 2);
                        
                        
                        if (posOrNeg == true && d+v <12)
                        {
                            d = d + v;
                        }
                        else if (posOrNeg == false && d-v>0)
                        {
                            d = d - v;
                        }
                        switch (d)
                        {
                            case 1: disp = "a"; break;
                            case 2: disp = "2"; break;
                            case 3: disp = "3"; break;
                            case 4: disp = "4"; break;
                            case 5: disp = "5"; break;
                            case 6: disp = "6"; break;
                            case 7: disp = "7"; break;
                            case 8: disp = "8"; break;
                            case 9: disp = "9"; break;
                            case 10: disp = "10"; break;
                            case 11: disp = "A"; break;
                            default: disp = "SE"; break; //SE = Switch Error

                        }

                        switch (Dealer.count)
                        {                           
                            case 2: Dealer.C2.setValues(d, disp); end = true; break;
                            case 3: Dealer.C3.setValues(d, disp); end = true; break;
                            case 4: Dealer.C4.setValues(d, disp); end = true; break;
                            case 5: Dealer.C5.setValues(d, disp); end = true; break;
                        }
                    }
                    updateLabels();
                    if (end == true) { break; }
                };
                
            }





            return ComparePlayers(Dealer, PlayerOne);
            
        }
       
        private bool AceChangeActive;
        private void label1_Click(object sender, EventArgs e)
        {

            {
                if (AceChangeActive)
                {
                    if (PlayerOne.C1.value == 1)
                    {
                        PlayerOne.C1.setValues(11, "A");
                    }
                    else if (PlayerOne.C1.value == 11)
                    {
                        PlayerOne.C1.setValues(1, "a");
                    }
                    System.Diagnostics.Debug.WriteLine("1Click");
                    updateLabels();
                    checkTotals();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

            {
                if (AceChangeActive)
                {
                    if (PlayerOne.C2.value == 1)
                    {
                        PlayerOne.C2.setValues(11, "A");
                    }
                    else if (PlayerOne.C2.value == 11)
                    {
                        PlayerOne.C2.setValues(1, "a");
                    }
                    System.Diagnostics.Debug.WriteLine("2Click");
                    updateLabels();
                    checkTotals();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

            {
                if (AceChangeActive)
                {
                    if (PlayerOne.C3.value == 1)
                    {
                        PlayerOne.C3.setValues(11, "A");
                    }
                    else if (PlayerOne.C3.value == 11)
                    {
                        PlayerOne.C3.setValues(1, "a");
                    }
                    System.Diagnostics.Debug.WriteLine("3Click");
                    updateLabels();
                    checkTotals();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

            {
                if (AceChangeActive)
                {
                    if (PlayerOne.C4.value == 1)
                    {
                        PlayerOne.C4.setValues(11, "A");
                    }
                    else if (PlayerOne.C4.value == 11)
                    {
                        PlayerOne.C4.setValues(1, "a");
                    }
                    System.Diagnostics.Debug.WriteLine("4Click");
                    updateLabels();
                    checkTotals();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            {
                if (AceChangeActive)
                {
                    if (PlayerOne.C5.value == 1)
                    {
                        PlayerOne.C5.setValues(11, "A");
                    }
                    else if (PlayerOne.C5.value == 11)
                    {
                        PlayerOne.C5.setValues(1, "a");
                    }
                    System.Diagnostics.Debug.WriteLine("5Click");
                    updateLabels();
                    checkTotals();
                }
            }
        }
        private void checkTotals()
        {
           
            if (PlayerOne.Total() < 16)
            {
                buttonControl(false, true);
            }
            else
            {
                buttonControl(true, true);
            }
            if (PlayerOne.Total() > 21)
            {
                gameStateLbl.Text = "Loss by bust (CT)";
                POSTCHOICE(true);
                buttonControl(false);
            }
            if (PlayerOne.Total() == 21)
            {
                gameStateLbl.Text = "Win";
                buttonControl(false);
                POSTCHOICE(true);
            }
        
        }
        private bool? ComparePlayers(Player A, Player B)
        {
            if (A.Total() == B.Total()) { return null; }
            else if (A.Total() == 21) { return true; }
            else if (A.Total() > 21) //Check if A is bust
            {
                return false;
            }
            else if (B.Total() > 21) { return true; }
            else if (A.Total() > B.Total()) //Compare A to B
            {
                return true;
            }
            else { return false; }
            
        }

        private void betAmount_Scroll(object sender, EventArgs e)
        {
            betLabel.Text = betAmount.Value.ToString();
        }

        public void openUrsSettings_Click(object sender, EventArgs e)
        {
            
            ursSettingsMenu.ShowDialog();
        }

      
    }

    public class Player
    {
        

        public void reset()
        {
            C1.reset();
            C2.reset();
            C3.reset();
            C4.reset();
            C5.reset();
            count = 2;
            Random rnd = new Random();
        }


        static Random rnd = new Random();
        public Card C1 = new Card();
        public Card C2 = new Card();
        public Card C3 = new Card();
        public Card C4 = new Card();
        public Card C5 = new Card();
        public int bet;
        public long money = 1000;
        public int count = 2;
        public byte AceSet;
        
        public void drawHandling()
        {
            this.count++;
            //---//
            switch (count)
            {
                case 1: this.C1.drawCard(); break;
                case 2: this.C2.drawCard(); break;
                case 3: this.C3.drawCard(); break;
                case 4: this.C4.drawCard(); break;
                case 5: this.C5.drawCard(); break;
            }
        }
        public int Total(int? set = null)
        {
            if (set == null)
            {
                return C1.value + C2.value + C3.value + C4.value + C5.value;
            }
            else { C1.value = 0; C2.value = 0; C3.value = 0; C4.value = 0; C5.value = set.Value; return C5.value; }
        }
        
        public class Card
        {
            public void reset()
            {
                value = 0;
                display = "?";
            }
            public int value = 0;
            public string display = "?";
            public bool isAce()
            {
                if(this.value==1||this.value==11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void setValues(int v, string d)
            {
                this.value = v;
                this.display = d;
            }
            public void drawCard()
            {
                int v = rnd.Next(1, 14);
                if(v>1 && v < 11)
                {
                    setValues(v, v.ToString());
                }
                else
                {
                    switch (v)
                    {
                        case 1:  setValues(v, "a");  break;
                        case 11: setValues(10, "J"); break;
                        case 12: setValues(10, "Q"); break;
                        case 13: setValues(10, "K"); break;
                    }
                }
            }
           
        }
        
    }
    public class initSettingParse
    {
        public initial_settings startupSettings = new initial_settings();

        public initSettingParse()
        {

        }
        public bool AceSet;
        public byte diff;
        public long startMoney;

        public void fetchSettings()
        {
            AceSet = startupSettings.aceSetting;
            diff = startupSettings.diff;
            startMoney = startupSettings.money;
        }

    }

}
