﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Negocio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void crearNegocio(object sender, EventArgs e) {
        msgError.Text = "";
        string patterCorreo = "[a-zA-Z0-9_\\-]+@gmail.com";
        string patterCelular = "\\+[0-9]+";
        string patterTelefono = "[0-9]+";
        string patterNombre = "[a-zA-Z]+";
        
        try
        {
            string nombre = (nombreTxt.Text).Trim();
            string codigo = (codigoTxt.Text).Trim();
            string descripcion=(descripcionTxt.Text).Trim();
           
            if (nombre.Equals("") || codigo.Equals("") || descripcion.Equals("") ) {
                msgError.Text = "Ingrese todos los campos";
                return;
            }
            if (nombre.Equals("")) {
                msgError.Text = "Ingrese un Nombre";
                return;

            }
            if (codigo.Equals(""))
            {
                msgError.Text = "Ingrese un Nombre";
                return;

            }
            if (descripcion.Equals(""))
            {
                msgError.Text = "Ingrese un Nombre";
                return;

            }
            if (pass.Equals(""))
            {
                msgError.Text = "Ingrese un Nombre";
                return;

            }
            if (telefono.Equals(""))
            {
                msgError.Text = "Ingrese un Nombre";
                return;

            }
            if (celular.Equals(""))
            {
                msgError.Text = "Ingrese un Nombre";
                return;

            }
            if (direccion.Equals(""))
            {
                msgError.Text = "Ingrese un Nombre";
                return;

            }
            if (!Regex.IsMatch(correo, patterCorreo)) {
                msgError.Text = "Ingrese un correo valido example@gmail.com";
                return;
            }
            if (pass.Length < 7) {
                msgError.Text = "la contraseña tiene que ser mayor a 6 digitos";
                return;
            }
            if (!Regex.IsMatch(celular, patterCelular) && celular.Length > 7) {
                msgError.Text = "Ingrese un numero de celular valido +591 5564...";
                return;
            }
            if (!Regex.IsMatch(telefono, patterTelefono) && celular.Length > 7) {
                msgError.Text = "Ingrese un numero de telefono valido";
                return;
            }
            if (!Regex.IsMatch(nombre, patterNombre) ) {
                msgError.Text = "el nombre solo puede contener letras";
                return;
            }
            if (!UsuarioDto.getVerificacionCorreo(correo)) {
                msgError.Text = "Registre otro correo";
                return;
            }
            UsuarioDAO usuario = new UsuarioDAO();
            usuario.Nombre = nombre;
            usuario.Telefono = Int32.Parse(telefono);
            usuario.correo = correo;
            usuario.Celular = celular;
            usuario.Contrasena = pass;
            usuario.codigoConfirmacion = UsuarioDto.numeroAleatorio();
            usuario.activa = false;
            usuario.Usuario = user;
            usuario.Direccion = direccion;
            vaciar();
            UsuarioDto.insertCorreo(usuario);
            Response.Redirect("Login.aspx");


        }
        catch (Exception E) {
            
            msgError.Text = "Error al optener los datos";
        }
    }
    public void vaciar() {
        nombreTxt.Text = "";
        userTxt.Text = "";
        correoTxt.Text = "";
        passText.Text = "";
        telefonoTxt.Text = "";
        celTxt.Text = "";
        dirTxt.Text = "";
        msgError.Text = "";
    }
}