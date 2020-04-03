using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for CointControl.xaml
    /// </summary>
    public partial class CointControl : UserControl
    {

        public static readonly DependencyProperty DenomProperty =
            DependencyProperty.Register("denom", typeof(Coins), typeof(CointControl), new PropertyMetadata(Coins.Penny));
        public Coins denom
        {
            get { return (Coins)GetValue(DenomProperty); }
            set { SetValue(DenomProperty, value); }
        }


        public static readonly DependencyProperty QuantProperty =
            DependencyProperty.Register("quant", typeof(int), typeof(CointControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public int quant
        {
            get { return (int)GetValue(QuantProperty); }
            set { SetValue(QuantProperty, value); }
        }

        public CointControl()
        {
            InitializeComponent();
        }

        private void DecreaseCoin_Click(object sender, RoutedEventArgs e)
        {
            quant--;
        }

        private void IncreaseCoin_Click(object sender, RoutedEventArgs e)
        {
            quant++;
        }
    }
}
