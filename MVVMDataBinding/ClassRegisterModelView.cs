using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    public class ClassRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Prop changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Crash drawer
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total in the drawer
        /// </summary>
        public double TotalVal => drawer.TotalValue;

        public int Penies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value) return;
                if (value < 0) return;
                var quant = value - drawer.Pennies;
                if (quant > 0) drawer.AddCoin(Coins.Penny, quant);
                else drawer.RemoveCoin(Coins.Penny, quant);
                invokePropChanged("Pennies");
            }
        }

        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value) return;
                if (value < 0) return;
                var quant = value - drawer.Nickels;
                if (quant > 0) drawer.AddCoin(Coins.Nickel, quant);
                else drawer.RemoveCoin(Coins.Nickel, quant);
                invokePropChanged("Nickels");
            }
        }

        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value) return;
                if (value < 0) return;
                var quant = value - drawer.Dimes;
                if (quant > 0) drawer.AddCoin(Coins.Dime, quant);
                else drawer.RemoveCoin(Coins.Dime, quant);
                invokePropChanged("Dimes");
            }
        }

        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value) return;
                if (value < 0) return;
                var quant = value - drawer.Quarters;
                if (quant > 0) drawer.AddCoin(Coins.Quarter, quant);
                else drawer.RemoveCoin(Coins.Quarter, quant);
                invokePropChanged("Quarters");
            }
        }

        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value) return;
                if (value < 0) return;
                var quant = value - drawer.HalfDollars;
                if (quant > 0) drawer.AddCoin(Coins.HalfDollar, quant);
                else drawer.RemoveCoin(Coins.HalfDollar, quant);
                invokePropChanged("HalfDollars");
            }
        }

        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value) return;
                if (value < 0) return;
                var quant = value - drawer.Dollars;
                if (quant > 0) drawer.AddCoin(Coins.Dollar, quant);
                else drawer.RemoveCoin(Coins.Dollar, quant);
                invokePropChanged("Dollars");
            }
        }

        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value) return;
                if (value < 0) return;
                var quant = value - drawer.Ones;
                if (quant > 0) drawer.AddBill(Bills.One, quant);
                else drawer.RemoveBill(Bills.One, quant);
                invokePropChanged("Ones");
            }
        }

        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value) return;
                if (value < 0) return;
                var quant = value - drawer.Twos;
                if (quant > 0) drawer.AddBill(Bills.Two, quant);
                else drawer.RemoveBill(Bills.Two, quant);
                invokePropChanged("Twos");
            }
        }
        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value) return;
                if (value < 0) return;
                var quant = value - drawer.Fives;
                if (quant > 0) drawer.AddBill(Bills.Five, quant);
                else drawer.RemoveBill(Bills.Five, quant);
                invokePropChanged("Fives");
            }
        }

        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value) return;
                if (value < 0) return;
                var quant = value - drawer.Tens;
                if (quant > 0) drawer.AddBill(Bills.Ten, quant);
                else drawer.RemoveBill(Bills.Ten, quant);
                invokePropChanged("Tens");
            }
        }

        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value) return;
                if (value < 0) return;
                var quant = value - drawer.Twenties;
                if (quant > 0) drawer.AddBill(Bills.Twenty, quant);
                else drawer.RemoveBill(Bills.Twenty, quant);
                invokePropChanged("Twenties");
            }
        }

        public int Fifties
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value) return;
                if (value < 0) return;
                var quant = value - drawer.Fifties;
                if (quant > 0) drawer.AddBill(Bills.Fifty, quant);
                else drawer.RemoveBill(Bills.Fifty, quant);
                invokePropChanged("Fifties");
            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value) return;
                if (value < 0) return;
                var quant = value - drawer.Hundreds;
                if (quant > 0) drawer.AddBill(Bills.Hundred, quant);
                else drawer.RemoveBill(Bills.Hundred, quant);
                invokePropChanged("Hundreds");
            }
        }

        void invokePropChanged(string denom)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denom));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalVal"));
        }
    }
}
