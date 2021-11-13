using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Buoi10
{
    public static class Extension
    {
        public static DataTable ToDataTable<T>(this List<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public static Bitmap GenerateQR(string text)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCode qrcode = new QRCode(qr.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q));
            return qrcode.GetGraphic(2, Color.Black, Color.White, false);
        }
    }
}
