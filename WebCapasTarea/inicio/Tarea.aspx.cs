﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCapasTarea.inicio
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Números pares e impares
            int txtNum = 0;
            txtNum = int.Parse(this.txtNum.Text);
            if (txtNum % 2 == 0)
                this.lblResultnum.Text = "El número es par";
            else
                this.lblResultnum.Text = "El número es impar";

            //Nombre del mes ingresado por parametro
            int txtNmes = 0;
            txtNmes = int.Parse(this.txtNmes.Text);
            if (txtNmes == 1)
                this.lblResultnmes.Text = "El número del mes es Enero";
            if (txtNmes == 2)
                this.lblResultnmes.Text = "El número del mes es Febrero";
            if (txtNmes == 3)
                this.lblResultnmes.Text = "El número del mes es Marzo";
            if (txtNmes == 4)
                this.lblResultnmes.Text = "El número del mes es Abril";
            if (txtNmes == 5)
                this.lblResultnmes.Text = "El número del mes es Mayo";
            if (txtNmes == 6)
                this.lblResultnmes.Text = "El número del mes es Junio";
            if (txtNmes == 7)
                this.lblResultnmes.Text = "El número del mes es Julio";
            if (txtNmes == 8)
                this.lblResultnmes.Text = "El número del mes es Agosto";
            if (txtNmes == 9)
                this.lblResultnmes.Text = "El número del mes es Septiembre";
            if (txtNmes == 10)
                this.lblResultnmes.Text = "El número del mes es Octubre";
            if (txtNmes == 11)
                this.lblResultnmes.Text = "El número del mes es Noviembre";
            if (txtNmes == 12)
                this.lblResultnmes.Text = "El número del mes es Diciembre";
            if (txtNmes < 1 || txtNmes > 12)
                this.lblResultnmes.Text = "Valor fuera de rango";
        }
    }
}