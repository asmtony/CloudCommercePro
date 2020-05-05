using CloudCommercePro.Constants;
using CloudCommercePro.Helper;
using CloudCommercePro.Interfaces;
using CloudCommercePro.Models.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CloudCommercePro.Data.JSONData
{
    public class ContactJSON : IContactData
    {
        public List<DataContacts> Get()
        {
            DataTable dt = ConvertCSVtoDataTable(AssemblyHelper.GetCsvPath());

            List<DataContacts> contacts = new List<DataContacts>();
            DataContacts contact;
            for (int i = 0; i < dt.Rows.Count; i++)
            { 
                contact = new DataContacts { Name = dt.Rows[i][0].ToString(), Address = new DataAddress { Line1 = dt.Rows[i][1].ToString(), Line2 = dt.Rows[i][2].ToString() } };
                contacts.Add(contact);
            }          
            return contacts;// new DataContacts();
        }

        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            string[] headers = sr.ReadLine().Split(',');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            while (!sr.EndOfStream)
            {
                string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

    }

    public static class ExtensionMethods
    {
        /// <summary>
        /// Converts a List to a datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();
            for (int i = 0; i < properties.Count; i++)
            {
                PropertyDescriptor property = properties[i];
                dt.Columns.Add(property.Name, property.PropertyType);
            }
            object[] values = new object[properties.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }
    }
}
