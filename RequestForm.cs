using BikeStore.HelperClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class RequestForm : Form
    {
        AddProductsPage aParentForm;
        DB db = new DB();
        LoadSettings settings = new LoadSettings();
        AdminHelper ah = new AdminHelper();

        public RequestForm(AddProductsPage aParentForm)
        {
            InitializeComponent();

            


            string[] permissionNames = ah.GetPermissionNames();


            foreach (string permissionName in permissionNames)
            {
                string fieldVal = "";
                ah.GetStrFieldValueAtIndex(ah.GetIDXIndex(permissionName), AdminHelper.GetFieldName(EPermissionFields.Shop), ref fieldVal);

                string shopName = db.GetShopName(settings.GetLogin());  // not checking in db for login
                if (string.Equals(fieldVal, shopName))
                {
                    RequestsListBox.Items.Add(permissionName);
                }

            }

            this.aParentForm = aParentForm;
        }

        private void OpenRequestButton_Click(object sender, EventArgs e)
        {
            int SelectedIndex = RequestsListBox.SelectedIndex;
            int index = ah.GetIDXIndex(RequestsListBox.Items[SelectedIndex].ToString());

            string fieldValue = "";
            string dateVal = "";
            string shopName = "";
            string action = "";
            string itemName = "";
            string itemDescription = "";
            string price = "";
            string amountInStock = "";
            string category = "";
            string imgPath = "";

            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Date), ref fieldValue))
            {
                dateVal = fieldValue.Replace(":", "/");
                dateVal = $"Дата: {dateVal}\t";
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Time), ref fieldValue))
            {
                dateVal += $"Время: {fieldValue}";
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Shop), ref fieldValue))
            {
                shopName = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.Action), ref fieldValue))
            {
                action = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.item_name), ref fieldValue))
            {
                itemName = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.item_description), ref fieldValue))
            {
                itemDescription = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.price), ref fieldValue))
            {
                price = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.amount_in_stock), ref fieldValue))
            {
                amountInStock = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.category), ref fieldValue))
            {
                category = fieldValue;
            }
            if (ah.GetFieldValueAtIndex(index, AdminHelper.GetFieldName(EPermissionFields.item_image), ref fieldValue))
            {
                imgPath = fieldValue;
            }
            
            
            aParentForm.FillParameters(
                itemName,
                itemDescription,
                price,
                amountInStock,
                category,
                imgPath);
            
        }
    }
}
