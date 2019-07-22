using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicadaI.UI.Registros
{
    public partial class rVentas : Form
    {
        decimal ITBIS = 0;
        decimal Total = 0;
        Expression<Func<Ventas, bool>> filtral = x => 1 == 1;

        public rVentas()
        {
            InitializeComponent();
        }

        


    }
}
