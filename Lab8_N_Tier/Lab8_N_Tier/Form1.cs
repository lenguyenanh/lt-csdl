using DataAccess;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_N_Tier
{
    public partial class Form1 : Form
    {
        List<Category> listCategory = new List<Category>();
        List<Food> listFood = new List<Food>();
        List<Account> listAccount = new List<Account>();
        List<Bills> listBills = new List<Bills>();
        List<Table> listTable = new List<Table>();
        Food foodCurrent = new Food();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearFood_Click(object sender, EventArgs e)
        {
            txtNameFood.Text = "";
            txtPriceFood.Text = "0";
            txtUnitFood.Text = "";
            txtNotesFood.Text = "";
            if (cbbCategory.Items.Count > 0)
                cbbCategory.SelectedIndex = 0;
        }

        private void LoadFoodDataToListView()
        {
            FoodBL foodBL = new FoodBL();
            listFood = foodBL.GetAll();
            int count = 1;
            lvFood.Items.Clear();
            foreach (var food in listFood)
            {
                ListViewItem item = lvFood.Items.Add(count.ToString());
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());
                string foodName = listCategory.Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodName);
                item.SubItems.Add(food.Notes);
                count++;
            }
        }

        private void LoadAccountDataToListView()
        {
            AccountBL accountBL = new AccountBL();
            listAccount = accountBL.GetAll();
            lvAccount.Items.Clear();
            foreach (var acc in listAccount)
            {
                ListViewItem item = lvAccount.Items.Add(acc.AccountName);
                item.SubItems.Add(acc.Password);
                item.SubItems.Add(acc.FullName);
                item.SubItems.Add(acc.Email);
                item.SubItems.Add(acc.Tell);
                item.SubItems.Add(acc.DateCreated.ToString());
            }
        }

        private void LoadBillsDataToListView()
        {
            BillsBL billsBL = new BillsBL();
            listBills = billsBL.GetAll();
            int count = 1;
            lvBills.Items.Clear();
            foreach (var bill in listBills)
            {
                ListViewItem item = lvBills.Items.Add(count.ToString());
                item.SubItems.Add(bill.Name);
                //string TableID = listTable.Find(x => x.ID == bill.TableID).Name;
                item.SubItems.Add(bill.TableID.ToString());
                item.SubItems.Add(bill.Amount.ToString());
                item.SubItems.Add(bill.Discount.ToString());
                item.SubItems.Add(bill.Tax.ToString());
                item.SubItems.Add(bill.Status.ToString());
                item.SubItems.Add(bill.CheckoutDate.ToString());
                item.SubItems.Add(bill.Account);
                count++;
            }
        }

        private void LoadTableDataToListView()
        {
            TableBL tableBL = new TableBL();
            listTable = tableBL.GetAll();
            int count = 1;
            lvTable.Items.Clear();
            foreach (var tb in listTable)
            {
                ListViewItem item = lvTable.Items.Add(count.ToString());
                item.SubItems.Add(tb.Name);
                item.SubItems.Add(tb.Status.ToString());
                item.SubItems.Add(tb.Capacity.ToString());
                count++;
            }
        }

        private void LoadCategory()
        {
            CategoryBL categoryBL = new CategoryBL();
            listCategory = categoryBL.GetAll();
            cbbCategory.DataSource = listCategory;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }


        public int InsertFood()
        {
            Food food = new Food();
            food.ID = 0;
            if (txtNameFood.Text == "" || txtUnitFood.Text == "" | txtPriceFood.Text == "")
                MessageBox.Show("Vui lòng nhập dữ liệu đầy đủ");
            else
            {
                food.Name = txtNameFood.Text;
                food.Unit = txtUnitFood.Text;
                food.Notes = txtNotesFood.Text;
                int price = 0;
                try
                {
                    price = int.Parse(txtPriceFood.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                FoodBL foodBL = new FoodBL();
                return foodBL.Insert(food);
            }
            return -1;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int kq = InsertFood();
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadFoodDataToListView();
            }
            else
                MessageBox.Show("Thêm dữ liệu thất bại");
        }

        public int UpdateFood()
        {
            Food food = foodCurrent;
            if (txtNameFood.Text == "" || txtUnitFood.Text == "" || txtPriceFood.Text == "")
                MessageBox.Show("Vui lòng nhập dữ liệu đầy đủ");
            else
            {
                food.Name = txtNameFood.Text;
                food.Unit = txtUnitFood.Text;
                food.Notes = txtNotesFood.Text;
                int price = 0;
                try
                {
                    price = int.Parse(txtPriceFood.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                FoodBL foodBL = new FoodBL();
                return foodBL.Update(food);
            }
            return -1;
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            int kq = UpdateFood();
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadFoodDataToListView();
            }
            else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FoodBL foodBL = new FoodBL();
                if (foodBL.Delete(foodCurrent) > 0)
                {
                    MessageBox.Show("Xóa món ăn thành công");
                    LoadFoodDataToListView();
                }
                else
                    MessageBox.Show("Xóa món ăn thất bại");
            }
        }

        private void btnExitFood_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodDataToListView();
            LoadAccountDataToListView();
            LoadBillsDataToListView();
            LoadTableDataToListView();
        }

        private void lvFood_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvFood.Items.Count; i++)
            {
                if (lvFood.Items[i].Selected)
                {
                    foodCurrent = listFood[i];
                    txtNameFood.Text = foodCurrent.Name;
                    txtUnitFood.Text = foodCurrent.Unit;
                    txtPriceFood.Text = foodCurrent.Price.ToString();
                    txtNotesFood.Text = foodCurrent.Notes;
                    cbbCategory.SelectedIndex = listCategory.FindIndex(x => x.ID == foodCurrent.FoodCategoryID);
                }
            }
        }

        private void danhSáchVaiTròToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleAccount dialog = new RoleAccount();
            ListViewItem item = lvAccount.SelectedItems[0];
            string accountName = item.SubItems[0].Text;
            dialog.LoadRoleAccount(accountName);
            dialog.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
