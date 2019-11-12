﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistroLineaNegocio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void registrarLineaNegocio(object sender, EventArgs e) {
        msgError.Text = "";
   
     
        
        try
        {
            string nombre = (nombreTxt.Text).Trim();
            string descripcion = (descripcionTxt.Text).Trim();
            
            
           
            if (nombre.Equals("")) {
                msgError.Text = "Ingrese un Nombre";
                return;

            }
            if (descripcion.Equals(""))
            {
                msgError.Text = "Ingrese la descripcion";
                return;

            }
            if (LineaNegocio_ProductoTxt.Equals(""))
            {
                msgError.Text = "Ingrese una Emrpesa";
                return;

            }
            if (descripcion.Length < 15 ) {
                msgError.Text = "la descripcion tiene que ser mayor a 15 ";
                return;
            }
           
            
            LineaNegocioDAO producto = new LineaNegocioDAO();
            producto.nombre = nombre;
            producto.descripcion = descripcion;
            producto.Empresa_LineaNegocio = Convert.ToInt32(LineaNegocio_ProductoTxt.SelectedValue);

           
            LineaNegocioDto.InsertLineaNegocio(producto);
            Response.Redirect("index.aspx");


        }
        catch (Exception E) {
            
            msgError.Text = "Error al optener los datos";
        }
    }
    public void vaciar() {
        nombreTxt.Text = "";
        descripcionTxt.Text = "";
        LineaNegocio_ProductoTxt.Text = "";
      
        msgError.Text = "";
    }
}