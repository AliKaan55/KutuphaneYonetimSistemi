using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using KutuphaneYonetimSistemi.Class;
namespace KutuphaneYonetimSistemi.Class
{
    public class SqlVariable
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L8F1FGT\\SQLEXPRESS01;Initial Catalog=KutuphaneYonetimDb;Integrated Security=True;Trust Server Certificate=True");
        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            {
            }
        }
    }
}