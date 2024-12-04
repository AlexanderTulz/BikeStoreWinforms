using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.HelperClasses
{
    enum PermissionAction
    { 
        AddItem,
        DeleteItem,
        ChangeItem,
        AddShop,
        DeleteShop,
    };

    enum EPermissionFields
    {
        Date,
        Time,
        Shop,
        Action,
        Permission,
        Status,
        item_name,
        item_description,
        price,
        amount_in_stock,
        category,
        item_image
    }


    internal class AdminHelper
    {
        static string BasePath = @"X:\Unik\AlgorithmsAndDataStructure\BikeStore";
        static string FolderName = @"Permissions\";
        static string FullPath = BasePath + @"\" + FolderName;
        string IndexFile = "IDX_Main";
        static string IndexFileKey = "IDX_";
        public static readonly string NoImageFoundPicturePath = BasePath + @"\Images\NoImageFound.png";

        private static readonly string[] StrFields = { 
            "Shop",
            "item_name",
            "item_description",
            "category",
            "item_image"
        };

        const string PermissionParametersBase =
            "Date = \n" +
            "Time = \n" + 
            "Shop = {}\n" + 
            "Action = \n" + 
            "Permission = \n" +
            "Status = \n";

        const string PermissionParametersAddItem =
            "item_name = {}\n" +
            "item_description = {}\n" +
            "price = \n" +
            "amount_in_stock = \n" +
            "category = {}\n" +
            "item_image = {}\n";


        public AdminHelper() { CreateIndexing(); }

        private void CreateIndexing() 
        {
            if(File.Exists(FullPath + IndexFile))
            {
                return;
            }
            // Check for folder

            using (FileStream fs = File.OpenWrite(FullPath + IndexFile))
            {
                byte[] title = new UTF8Encoding(true).GetBytes("0");
                fs.Write(title, 0, title.Length);
                fs.Close();
            }
        }

        private int GetIndex()
        {
            int index = -1;
            using(StreamReader sr = File.OpenText(FullPath + IndexFile))
            {
                string buffer = sr.ReadLine();
                if(buffer != null)
                {
                    index = Convert.ToInt32(buffer);
                    sr.Close();
                }
            }

            return index;
        }

        private void SetNextIndex()
        {
            int index = GetIndex();
            ++index;

            if(index < 0)
            {
                MessageBox.Show("No indexing file!");   // Might be error
                return;
            }

            using(FileStream fs = new FileStream(FullPath + IndexFile, FileMode.Truncate))
            {
                string IndexValue = index.ToString();
                byte[] title = new UTF8Encoding(true).GetBytes(IndexValue);
                fs.Write(title, 0, title.Length);
                fs.Close();
            }

        }

        public bool SendShopAction(PermissionAction Action, string shopName)
        {
            if(Action == PermissionAction.AddItem || 
                Action == PermissionAction.DeleteItem ||
                Action == PermissionAction.ChangeItem)
            {
                return false;
            }

            string SetParameter = PermissionParametersBase;

            string DateString = DateTime.Now.ToString("dd:MM:yyyy");
            string TimeString = DateTime.Now.ToString("HH:mm");

            SetParameter = SetFieldValue("Date", SetParameter, DateString);                  // Date
            SetParameter = SetFieldValue("Time", SetParameter, TimeString);                  // Time 
            SetParameter = SetFieldValue("Shop", SetParameter, shopName);                    // Shop name 
            SetParameter = SetFieldValue("Action", SetParameter, Action.ToString());         // Action
            SetParameter = SetFieldValue("Permission", SetParameter, "no");                  // Permission
            SetParameter = SetFieldValue("Status", SetParameter, "sent");                    // Status

            // kinda send function
            using (FileStream fs = File.OpenWrite(FullPath + IndexFileKey + GetIndex()))
            {
                byte[] title = new UTF8Encoding(true).GetBytes(SetParameter);
                fs.Write(title, 0, title.Length);
                fs.Close();
            }

            return true;
        }

        public bool SendItemPermission(
            PermissionAction Action,
            string itemName,
            string itemDescription,
            double price,
            int amountInStock,
            string category,
            string itemIMGPath,
            string shopName)
        {
            if(Action == PermissionAction.DeleteShop || 
                Action == PermissionAction.AddShop)
            {
                return false;
            }

            string bufferIDX = PermissionParametersBase + PermissionParametersAddItem;
            string SetParameter = bufferIDX;

            string DateString = DateTime.Now.ToString("dd:MM:yyyy");
            string TimeString = DateTime.Now.ToString("HH:mm");

            SetParameter = SetFieldValue("Date", SetParameter, DateString);                  // Date
            SetParameter = SetFieldValue("Time", SetParameter, TimeString);                  // Time 
            SetParameter = SetFieldValue("Shop", SetParameter, shopName);                    // Shop name 
            SetParameter = SetFieldValue("Action", SetParameter, Action.ToString());         // Action
            SetParameter = SetFieldValue("Permission", SetParameter, "no");                  // Permission
            SetParameter = SetFieldValue("Status", SetParameter, "sent");                    // Status

            SetParameter = SetFieldValue("item_name", SetParameter, itemName);
            SetParameter = SetFieldValue("item_description", SetParameter, itemDescription);
            SetParameter = SetFieldValue("price", SetParameter, price.ToString());
            SetParameter = SetFieldValue("amount_in_stock", SetParameter, amountInStock.ToString());
            SetParameter = SetFieldValue("category", SetParameter, category);
            SetParameter = SetFieldValue("item_image", SetParameter, itemIMGPath);

            // kinda send function
            using(FileStream fs = File.OpenWrite(FullPath + IndexFileKey + GetIndex()))
            {
                byte[] title = new UTF8Encoding(true).GetBytes(SetParameter);
                fs.Write(title, 0, title.Length);
                fs.Close();
            }

            SetNextIndex();

            return true;
        }

        private string SetFieldValue(string fieldName, string parametersToChange, string value)
        {
            bool StringParameter = false;

            foreach(string field in StrFields)
            {
                if(string.Equals(field, fieldName))
                {
                    StringParameter = true;
                    break;
                }
            }

            if(StringParameter)
            {
                return SetStrFieldValue(fieldName, parametersToChange, value);
            }

            return SetNonStrFieldValue(fieldName, parametersToChange, value);
        }
        
        public string SetStrFieldValue(string fieldName, string parametersToChange, string value)   // make private
        {
            fieldName += " = ";

            for(int i = 0, j = 0; i < parametersToChange.Length; ++i)
            {

                if(j == fieldName.Length - 1)
                {
                    while(parametersToChange[i] != '{')     // might be infinit loop
                    {
                        if (parametersToChange[i] == '\n' || parametersToChange[i] == null) return parametersToChange;
                        ++i;
                    }

                    //while (parametersToChange[i] != '}')
                    //{
                    //    parametersToChange.Insert(i, value);
                    //    ++i;
                    //}     // No need for now


                    string res = parametersToChange.Insert(++i, value);
                    return res;
                }

                if (parametersToChange[i] == fieldName[j])
                {
                    ++j;
                }
                else
                {
                    j = 0;

                    while (parametersToChange[++i] != '\n')
                    { }
                }
            }

            return parametersToChange;
        }

        public string SetNonStrFieldValue(string fieldName, string parametersToChange, string value)    // make private
        {
            fieldName += " = ";

            for (int i = 0, j = 0; i < parametersToChange.Length; ++i)
            {

                if (j == fieldName.Length - 1)
                {
                    string res = parametersToChange.Insert(++i, value);
                    return res;
                }

                if (parametersToChange[i] == fieldName[j])
                {
                    ++j;
                }
                else
                {
                    j = 0;

                    while (parametersToChange[++i] != '\n')
                    { }
                }
            }

            return parametersToChange;
        }

        public bool GetParametersAtIndex(int index, ref string parameters)
        {
            string FileToOpen = FullPath + IndexFileKey + index.ToString();

            parameters = "";

            try
            {
                if(!File.Exists(FileToOpen))
                {
                    return false;
                }
                
                using(StreamReader sr = File.OpenText(FileToOpen))
                {
                    string buffer = "";

                    while((buffer = sr.ReadLine()) != null)
                    {
                        parameters += buffer + "\n";
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public bool GetFieldValueAtIndex(int index, string fieldName, ref string value)
        {
            bool IsStrField = false;
            foreach(string field in StrFields)
            {
                if(string.Equals(field, fieldName))
                {
                    IsStrField = true;
                    break;
                }
            }

            if(IsStrField)
            {
                return GetStrFieldValueAtIndex(index, fieldName, ref value);
            }

            return GetNonStrFieldValueAtIndex(index, fieldName, ref value);
        }

        public bool GetStrFieldValueAtIndex(int index, string fieldName, ref string value) //it's only for string value
        {
            fieldName += " = ";

            string parameters = "";
            value = "";

            if(!GetParametersAtIndex(index, ref parameters))
            {
                return false;
            }

            for(int i = 0, j = 0; i < parameters.Length; ++i)
            {
                if(j == fieldName.Length - 1)
                {
                    while (parameters[++i] != '{')
                    { }

                    while (parameters[++i] != '}')
                    {
                        value += parameters[i];
                    }

                    return true;
                }

                if (parameters[i] == fieldName[j++])
                { }
                else
                {
                    j = 0;

                    while (parameters[++i] != '\n')
                    { }
                }
            }

            return false;
        }

        public bool GetNonStrFieldValueAtIndex(int index, string fieldName, ref string value)
        {
            fieldName += " = ";

            string parameters = "";
            value = "";

            if (!GetParametersAtIndex(index, ref parameters))
            {
                return false;
            }

            for (int i = 0, j = 0; i < parameters.Length; ++i)
            {
                if (j == fieldName.Length - 1)
                {
                    while (parameters[++i] != '\n')
                    {
                        value += parameters[i];
                    }

                    return true;
                }

                if (parameters[i] == fieldName[j++])
                { }
                else
                {
                    j = 0;

                    while (parameters[++i] != '\n')
                    { }
                }
            }

            return false;
        }

        public string[] GetPermissionNames()
        {
            //string[] fileIndexes = new string[];

            string[] fileNames = Directory.GetFiles(FullPath);
            List<string> indexes = new List<string>();
            
            foreach(string fileName in fileNames)
            {
                string buffer = fileName.Replace($"{FullPath}", "");

                indexes.Add(buffer);
            }

            indexes.Remove(IndexFile);
            indexes.Remove("IDX_Example");
            indexes.Remove("IDX_Read_Example");
            indexes.Reverse();

            string[] retVal = indexes.ToArray();

            return retVal;
        }

        public int[] GetPermissionIndexes()
        {
            string[] indexNames = GetPermissionNames();
            List<int> indexes = new List<int>();


            foreach(string indexName in indexNames)
            {
                string indexStr = indexName.Remove(0, IndexFileKey.Length);

                indexes.Add(Int32.Parse(indexStr));
            }

            return indexes.ToArray();
        }

        public int GetIDXIndex(string fileName)
        {
            int index = Int32.Parse(fileName.Remove(0, IndexFileKey.Length));

            return index;
        }

        public static string GetFieldName(EPermissionFields field)
        {
            if (field == null) return "";

            return field.ToString();
        }
    }
}
