using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CtyHongPhat.Utility;
using CtyHongPhatDatabase.Table;

namespace CtyHongPhat
{
    public partial class FormInputOrder : Form
    {
        ArrayList partnerInfos;
        ArrayList itemInfos;
        ArrayList priceInfos = new ArrayList();
        BindingList<InputDetail> orderDetailList = new BindingList<InputDetail>();

        private string employeeName = "";
        Database database = new Database();

        static readonly ListItem defaultItem = new ListItem { Text = "<Tên Mặt Hàng>", Value = null};
        static readonly ListItem defaultParner = new ListItem { Text = "<Tên Đối Tác>", Value = null };
        
        public FormInputOrder()
        {
            InitializeComponent();
            FormInit();
        }

        public FormInputOrder(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;

            FormInit();
        }

        public void FormInit()
        {
            dataGridViewListItem.AutoGenerateColumns = false;
            comboBoxListAgentName.DisplayMember = "Text";
            comboBoxListAgentName.ValueMember = "Value";
            cbbListItem.DisplayMember = "Text";
            cbbListItem.ValueMember = "Value";

            orderDetailList.ListChanged += new ListChangedEventHandler(orderDetailList_ListChanged);
            dataGridViewListItem.DataSource = orderDetailList;

            DataInit();
        }

        void orderDetailList_ListChanged(object sender, ListChangedEventArgs e)
        {
            textBoxTotalAmount.Text = NumberViewer.InsertComma(orderDetailList.Select(c => c.Total).Sum().ToString());
            groupBoxInforAgent.Enabled = orderDetailList.Count == 0;
        }

        private void DataInit()
        {
            orderDetailList.Clear();

            List <ListItem> parnerList = new List<ListItem>();
            parnerList.Add(defaultParner);
            partnerInfos = database.PartnersGetAll();
            parnerList.AddRange(
                partnerInfos.Cast<PartnersInfo>()
                            .Select(c => new ListItem { Text = c.PartnerName, Value = c })
            );
            comboBoxListAgentName.DataSource = parnerList;
            comboBoxListAgentName.SelectedIndex = 0;

            List<ListItem> itemList = new List<ListItem>();
            itemList.Add(defaultItem);
            cbbListItem.DataSource = itemList;
            cbbListItem.SelectedIndex = 0;

            priceInfos = new ArrayList();
        }

        private void comboBoxListAgentName_SelectedValueChanged(object sender, EventArgs e)
        {
            List<ListItem> listItem = new List<ListItem>();
            listItem.Add(defaultItem);


            var partner = comboBoxListAgentName.SelectedValue as PartnersInfo;
            if (partner == null || partner.PartnerId == 0) {
                priceInfos = new ArrayList();
                labelTotalDebt.Text = "<Số tiền nợ>";
            } else {
                try {
                    labelTotalDebt.Text = NumberViewer.InsertComma("0"); // TODO: query so tien no
                    priceInfos = database.BuyPriceGetByPartner(partner.PartnerId);
                    itemInfos = database.ItemGetByPartner(partner.PartnerId);
                    listItem.AddRange(
                        itemInfos.Cast<ItemInfo>()
                                 .Select(c => new ListItem { Text = c.ItemName, Value = c })
                    );

                    var debtInfo = database.DebtGetByCustomerId(partner.PartnerId);
                    labelTotalDebt.Text = NumberViewer.InsertComma(debtInfo.CurrentDebtValue.ToString());
                } catch (Exception ex) {
                    //TODO: catch database exception
                }
            }

            cbbListItem.DataSource = listItem;
            cbbListItem.SelectedIndex = 0;
        }

        private void cbbListItem_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = cbbListItem.SelectedValue as ItemInfo;
            var partner = comboBoxListAgentName.SelectedValue as PartnersInfo;
            if (item == null || partner == null || item.ItemId == 0 || partner.PartnerId == 0) {
                inputBuyPrice.Value = 0;
            } else {
                BuyPriceInfo price = null;
                try {
                    price = priceInfos.Cast<BuyPriceInfo>()
                        .Where(p => p.ItemId == item.ItemId)
                        .SingleOrDefault();
                } catch (Exception) {                    
                }

                inputBuyPrice.Value = price == null ? 0 : price.BuyPrice;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var item = cbbListItem.SelectedValue as ItemInfo;
            var partner = comboBoxListAgentName.SelectedValue as PartnersInfo;
            BuyPriceInfo price = null;
            

            if (item == null || partner == null) {

            } else {
                price = priceInfos.Cast<BuyPriceInfo>()
                    .Where(p => p.ItemId == item.ItemId)
                    .SingleOrDefault();


                InputDetail detail = new InputDetail {
                    OrderItemId = item.ItemId,
                    OrderItemName = item.ItemName,
                    Quantity = inputQuantity.Value,
                    Measurement = item.Measurement,
                    Price = inputBuyPrice.Value,
                    PriceInfo = price
                };

                orderDetailList.Add(detail);
                cbbListItem.SelectedIndex = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = orderDetailList.Count() - 1; i >= 0; i--) {
                if (i < orderDetailList.Count && orderDetailList[i].Deleted) {
                    orderDetailList.RemoveAt(i);
                }
            }
        }

        private class InputDetail
        {
            public bool Deleted { get; set; }
            public int OrderItemId { get; set; }
            public string OrderItemName { get; set; }
            public decimal Quantity { get; set; }
            public string Measurement { get; set; }
            public decimal Price { get; set; }
            public decimal Total
            {
                get
                {
                    return Quantity * Price;
                }
            }
            public BuyPriceInfo PriceInfo { get; set; }

            public string TotalView
            {
                get
                {
                    return NumberViewer.InsertComma(Total.ToString());
                }
            }

            public string PriceView
            {
                get
                {
                    return NumberViewer.InsertComma(Price.ToString());
                }
            }
        }


    }
}
