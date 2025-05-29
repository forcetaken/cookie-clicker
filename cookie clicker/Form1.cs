using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cookie_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double money = 0;
        double multiplyer = 1;
        private void button1_Click(object sender, EventArgs e)
        {if (chocolatechips > 0)
            {
            chocolatechipsmultiplyer = chocolatechips * 1.2;

            }
            money += 1 * multiplyer * rebirthmultiplyer * chocolatechipsmultiplyer * rebirthupgrade1multiplyer;
            Money.Text = "Cookies:\r\n" + Convert.ToInt64(money).ToString();
            if (money >= 1000000)
            {
                Money.Text = "Cookies:\r\n" + Million(money);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            double price = 10;

        private void Upgrade1_Click(object sender, EventArgs e)
        { if (money >= price)
            {
            money -= price;
            price = price * 1.5;
            Upgrade1price.Text = "Price: " + Convert.ToInt64(price);
                multiplyer = multiplyer * 1.1;
            }

        }

        private void Upgrade1price_Click(object sender, EventArgs e)
        {

        }
        double price2 = 250;
        private async void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                
                Upgrade1.BackColor = Color.HotPink;
                Upgrade2.BackColor = Color.HotPink;
                Upgrade3.BackColor = Color.HotPink;
                Upgrade2price.Text = "Price:\r\n" + Million(price2);
                Upgrade1price.Text = "Price:\r\n" + Million(price);
                Upgrade3price.Text = "Price:\r\n" + Million(price3);
                RU1price.Text = "Price:\r\n" + Million(rebirthupgrade1price);
                


                Money.Text = "Cookies:\r\n" + Million(money);
                
                await Task.Delay (1);
                Moneyperclick.Text = "Money Per Click:\r\n" + Million(1 * multiplyer * rebirthmultiplyer * chocolatechipsmultiplyer * rebirthupgrade1multiplyer);
                rebirthchips.Text = "Chocolate Chips:\r\n" + chocolatechips;
            }
        }

        private string Million(double number)
        {
            string num = "0";
            if (number >= 1000000)
            {
                // num = (number / 1000000.ToString()[0] + "." + (number).ToString()[1] + "M");
                double million = number / 1000000.0;
                num = million.ToString("F1") + "M";
            }
            else { num = number.ToString("F1"); }
            return num;
        }

        private void Upgrade2_Click(object sender, EventArgs e)
        {
                if (money >= price2)
                {
                    money -= price2;
                    price2 = price2 * 2;
                    Upgrade2price.Text = "Price: " + Convert.ToInt64(price2);
                    multiplyer = multiplyer * 1.25;
                }

            }

        private void Upgrade2price_Click(object sender, EventArgs e)
        {

        }
        double price3 = 2500;
        private void Upgrade3_Click(object sender, EventArgs e)
        {
            if (money >= price3)
            {
                money -= price3;
                price3 = price3 * 3;
                Upgrade3price.Text = "Price: " + Convert.ToInt64(price3);
                multiplyer = multiplyer * 1.5;
            }
        }

        private void Upgrade3price_Click(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("cookie.txt");
            file.WriteLine(money);
            file.WriteLine(price);
            file.WriteLine(price2);
            file.WriteLine(price3);
            file.WriteLine(multiplyer);
            file.WriteLine(rebirthmultiplyer);
            file.WriteLine(rebirthprice);
            file.WriteLine(Rebirths);
            file.Close();

        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("cookie.txt");
            money = Convert.ToDouble(file.ReadLine());
            price = Convert.ToDouble(file.ReadLine());
            price2 = Convert.ToDouble(file.ReadLine());
            price3 = Convert.ToDouble(file.ReadLine());
            multiplyer = Convert.ToDouble(file.ReadLine());
            rebirthmultiplyer = Convert.ToDouble(file.ReadLine());
            rebirthprice = Convert.ToDouble(file.ReadLine());
            Rebirths = Convert.ToDouble(file.ReadLine());
            file.Close();
        }

        private void Moneyperclick_Click(object sender, EventArgs e)
        {

        }
        double rebirthprice = 100000;
        double Rebirths = 0;
        double rebirthmultiplyer = 1;
        double chocolatechips = 0;
        double chocolatechipsmultiplyer = 1;
        private void rebirthbutton_Click(object sender, EventArgs e)
        {
            if (money >= rebirthprice)
            {
                Rebirths = Rebirths + 1;
                money = 0;
                price = 10;
                price2 = 250;
                price3 = 2500;
                multiplyer = 1;
                rebirths.Text = "Rebirths:\r\n" + Convert.ToInt64(Rebirths);
                rebirthprice = rebirthprice * 10;
                rebirthmultiplyer = rebirthmultiplyer * 3;
                rebirthcost.Text = "Cost:" + Convert.ToInt64(rebirthprice);
                if (rebirthprice >= 1000000)
                {
                    rebirthcost.Text = "Cost:\r\n" + rebirthprice/1000000 + "." + rebirthprice%1000000 + "M";
                }
                chocolatechips = chocolatechips + 1;
                rebirthchips.Text = "Chocolate Chips:\r\n" + chocolatechips;


            }
            
        }

        private void rebirths_Click(object sender, EventArgs e)
        {

        }

        private void rebirthcost_Click(object sender, EventArgs e)
        {

        }

        private void rebirthchips_Click(object sender, EventArgs e)
        {

        }
        double rebirthupgrade1price = 1;
        double rebirthupgrade1multiplyer = 1;
        private void rebirthbutton1_Click(object sender, EventArgs e)
        {
            if (chocolatechips >= rebirthupgrade1price)
            {chocolatechips = chocolatechips - rebirthupgrade1price;
                rebirthupgrade1multiplyer = rebirthupgrade1multiplyer * 1.5;
                rebirthupgrade1price = rebirthupgrade1price * 2;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
