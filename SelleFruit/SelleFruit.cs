using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SelleFruit
{
    public partial class SelleFruit : Form
    {
        System.Timers.Timer Seller;
        System.Timers.Timer Store;
        System.Timers.Timer Buy;
        System.Timers.Timer Rep;

        bool SellerRuning = false;
        bool StoreRuning = false;
        bool BuyRuning = false;
        bool RepRuning = false;

        public List<Entity.Fruit> lstFruit = new List<Entity.Fruit>();
        public List<Entity.Fruit> lstFruit2 = new List<Entity.Fruit>();

        public SelleFruit()
        {
            InitializeComponent();
        }

        private void SelleFruit_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                Entity.Fruit fruit = new Entity.Fruit();
                fruit.ID = i;
                fruit.StoreExist = 1000;
                fruit.SellerExist = 2000;
                if (i == 1)
                    fruit.FruitType = "سیب";
                else if (i == 2)
                    fruit.FruitType = "گلابی";
                else if (i == 3)
                    fruit.FruitType = "هلو";
                else if (i == 4)
                    fruit.FruitType = "نارنگی";
                else if (i == 5)
                    fruit.FruitType = "انار";
                else if (i == 6)
                    fruit.FruitType = "خیار";
                else if (i == 7)
                    fruit.FruitType = "انگور";
                else if (i == 8)
                    fruit.FruitType = "پرتقال";
                else if (i == 9)
                    fruit.FruitType = "موز";
                else if (i == 10)
                    fruit.FruitType = "کیوی";
                else
                    fruit.FruitType = "";

                lstFruit.Add(fruit);
            }

            GridSeller.DataSource = lstFruit;
            GridStore.DataSource = lstFruit;
            GridRep.DataSource = lstFruit;


            Buy = new System.Timers.Timer();
            Buy.Interval = 1 * 1 * 1000;
            Buy.Elapsed += TickBuy;
            Buy.Start();


            Rep = new System.Timers.Timer();
            Rep.Interval = 1 * 1 * 1000;
            Rep.Elapsed += TickRep;
            Rep.Start();

        }


        #region[ Seller ]

        private void btnSeller_Click(object sender, EventArgs e)
        {
            GridSeller.RootTable.Columns["SellerExist"].EditType = Janus.Windows.GridEX.EditType.NoEdit;

            Seller = new System.Timers.Timer();
            Seller.Interval = 1 * 5 * 1000;
            Seller.Elapsed += TickSeller;
            Seller.Start();

            btnSeller.Enabled = false;

        }
        public void TickSeller(object sender, EventArgs e)
        {
            if (!bkwSeller.IsBusy)
            {
                bkwSeller.RunWorkerAsync();
            }
        }
        private void bkwSeller_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SellerRuning)
                return;
            else
            {
                Thread seller = new Thread(ThrSeller);
                seller.Start();
            }
        }
        private void ThrSeller(object obj)
        {
            for (int i = 1; i < 11 ; i++)
            {
                if (lstFruit.Where(q => q.ID == i).First().StoreExist < 400 )
                {
                    if(lstFruit.Where(q=>q.ID == i).First().SellerExist >0)
                    {
                        lstFruit.Where(q=>q.ID == i).First().SellerExist = lstFruit.Where(q=>q.ID == i).First().SellerExist - 200;
                        if (lstFruit.Where(q => q.ID == i).First().SellerExist >= 0)
                            lstFruit.Where(q => q.ID == i).First().StoreExist += 200;
                        else
                        {
                            lstFruit.Where(q => q.ID == i).First().StoreExist += lstFruit.Where(q => q.ID == i).First().SellerExist;
                            lstFruit.Where(q => q.ID == i).First().SellerExist = 0;
                        }
                    }
                }
            }
            SetTextSeller(lstFruit);
        }
        delegate void SetTextCallbackSeller(List<Entity.Fruit> text);
        private void SetTextSeller(List<Entity.Fruit> lstfruit)
        {
            try
            {
                if (this.GridSeller.InvokeRequired)
                {
                    SetTextCallbackSeller d = new SetTextCallbackSeller(SetTextSeller);
                    this.Invoke(d, new object[] { lstfruit });
                }
                else
                {
                    if (lstfruit.Count != 0)
                    {
                        this.GridSeller.DataSource = null;
                        var binding = new BindingSource();
                        binding.DataSource = lstfruit;
                        GridSeller.DataSource = binding;
                        GridSeller.Refresh();
                        GridSeller.Refetch();
                    }
                    else
                    {
                        this.GridSeller.DataSource = null;
                        GridSeller.Refresh();
                        GridSeller.Refetch();
                    }
                }
            }
            catch
            { }
        }

        #endregion

        #region[ Store ]

        private void btnStore_Click(object sender, EventArgs e)
        {
            GridStore.RootTable.Columns["StoreExist"].EditType = Janus.Windows.GridEX.EditType.NoEdit;

            Store = new System.Timers.Timer();
            Store.Interval = 1 * 1 * 1000;
            Store.Elapsed += TickStore;
            Store.Start();

            btnStore.Enabled = false;
        }
        private void TickStore(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!bkwStore.IsBusy)
            {
                bkwStore.RunWorkerAsync();
            }
        }
        private void bkwStore_DoWork(object sender, DoWorkEventArgs e)
        {
            if (StoreRuning)
                return;
            else
            {
                Thread store = new Thread(ThrStore);
                store.Start();
            }
        }
        private void ThrStore(object obj)
        {
            SetTextStore(lstFruit);
        }
        delegate void SetTextCallbackStore(List<Entity.Fruit> text);
        private void SetTextStore(List<Entity.Fruit> lstfruit)
        {
            try
            {
                if (this.GridStore.InvokeRequired)
                {
                    SetTextCallbackStore d = new SetTextCallbackStore(SetTextStore);
                    this.Invoke(d, new object[] { lstfruit });
                }
                else
                {
                    if (lstfruit.Count != 0)
                    {
                        this.GridStore.DataSource = null;
                        var binding = new BindingSource();
                        binding.DataSource = lstfruit;
                        GridStore.DataSource = binding;
                        GridStore.Refresh();
                        GridStore.Refetch();
                    }
                    else
                    {
                        this.GridStore.DataSource = null;
                        GridStore.Refresh();
                        GridStore.Refetch();
                    }
                }
            }
            catch
            { }
        }

        #endregion

        #region[ Buy ]

        private void TickBuy(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!bkwBuy.IsBusy)
            {
                bkwBuy.RunWorkerAsync();
            }
        }
        private void bkwBuy_DoWork(object sender, DoWorkEventArgs e)
        {
            if (BuyRuning)
                return;
            else
            {
                Thread buy = new Thread(ThrBuy);
                buy.Start();
            }
        }
        private void ThrBuy(object obj)
        {
            Random rnID = new Random();
            Random rnCount = new Random();

            Entity.Fruit fruit = new Entity.Fruit();
            fruit.ID = rnID.Next(1, 11);
            fruit.Sold = rnCount.Next(1, 11) * 10;

            if (fruit.ID == 1)
                fruit.FruitType = "سیب";
            else if (fruit.ID == 2)
                fruit.FruitType = "گلابی";
            else if (fruit.ID == 3)
                fruit.FruitType = "هلو";
            else if (fruit.ID == 4)
                fruit.FruitType = "نارنگی";
            else if (fruit.ID == 5)
                fruit.FruitType = "انار";
            else if (fruit.ID == 6)
                fruit.FruitType = "خیار";
            else if (fruit.ID == 7)
                fruit.FruitType = "انگور";
            else if (fruit.ID == 8)
                fruit.FruitType = "پرتقال";
            else if (fruit.ID == 9)
                fruit.FruitType = "موز";
            else if (fruit.ID == 10)
                fruit.FruitType = "کیوی";
            else
                fruit.FruitType = "";

            lstFruit2.Add(fruit);
            SetTextBuy(lstFruit2);

            if (lstFruit.Where(q => q.ID == fruit.ID).First().StoreExist > fruit.Sold)
            {
                lstFruit.Where(q => q.ID == fruit.ID).First().Sold = lstFruit.Where(q => q.ID == fruit.ID).First().Sold + fruit.Sold;
                lstFruit.Where(q => q.ID == fruit.ID).First().StoreExist = lstFruit.Where(q => q.ID == fruit.ID).First().StoreExist - fruit.Sold;
            }
            


            //lstFruit2.Remove(fruit);
            SetTextBuy(lstFruit2);
        }

        delegate void SetTextCallbackBuy(List<Entity.Fruit> text);
        private void SetTextBuy(List<Entity.Fruit> lstfruit)
        {
            try
            {
                if (this.GridBuy.InvokeRequired)
                {
                    SetTextCallbackBuy d = new SetTextCallbackBuy(SetTextBuy);
                    this.Invoke(d, new object[] { lstfruit });
                }
                else
                {
                    if (lstfruit.Count != 0)
                    {
                        this.GridBuy.DataSource = null;
                        var binding = new BindingSource();
                        binding.DataSource = lstfruit;
                        GridBuy.DataSource = binding;
                        GridBuy.Refresh();
                    }
                    else
                    {
                        this.GridBuy.DataSource = null;
                        GridBuy.Refresh();
                    }
                }
            }
            catch
            { }
        }

        #endregion

        #region[ Rep ]

        private void TickRep(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!bkwRep.IsBusy)
            {
                bkwRep.RunWorkerAsync();
            }
        }
        private void bkwRep_DoWork_1(object sender, DoWorkEventArgs e)
        {
            if (BuyRuning)
                return;
            else
            {
                Thread rep = new Thread(ThrRep);
                rep.Start();
            }
        }
        private void ThrRep(object obj)
        {
            SetTextRep(lstFruit);
        }
        delegate void SetTextCallbackRep(List<Entity.Fruit> text);
        private void SetTextRep(List<Entity.Fruit> lstfruit)
        {
            try
            {
                if (this.GridRep.InvokeRequired)
                {
                    SetTextCallbackRep d = new SetTextCallbackRep(SetTextRep);
                    this.Invoke(d, new object[] { lstfruit });
                }
                else
                {
                    if (lstfruit.Count != 0)
                    {
                        //List<Entity.Fruit> lst = new List<Entity.Fruit>();
                        //this.GridRep.DataSource = lst;
                        this.GridRep.DataSource = null;
                        var binding = new BindingSource();
                        binding.DataSource = lstfruit;
                        GridRep.DataSource = binding;
                        GridRep.Refresh();
                        GridRep.Refetch();
                    }
                    else
                    {
                        //List<Entity.Fruit> lst = new List<Entity.Fruit>();
                        //this.GridRep.DataSource = lst;
                        this.GridRep.DataSource = null;
                        GridRep.Refresh();
                        GridRep.Refetch();
                    }
                }
            }
            catch
            { }
        }

        #endregion

        private void GridBuy_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

    }
}
