﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListProductos.aspx.cs" Inherits="ListProductos" %>

<!DOCTYPE html>

<html>
<head>
 <meta charset='utf-8'>
        <title>Lista Producto</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"> 
        <link href="../App_Themes/Default/A.bootstrap.min.css" type="text/css" rel="stylesheet" />
        <link href="../App_Themes/Default/B.style.css" type="text/css" rel="stylesheet" />
        <link href="../App_Themes/Default/css/fontawesome-all.min.css" type="text/css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>

            
    <div class="row">
        <div class="col-12">
            <h1>Lista de Productos</h1>
            <asp:HyperLink runat="server" NavigateUrl="RegistroProducto.aspx" CssClass="btn btn-primary">
                Nuevo Producto
            </asp:HyperLink>
            <br /><br />
        </div>
    </div>
    <div class="row">
        <div class="col-12">
            
            <asp:GridView ID="ProductosGridView" runat="server" CssClass="table" 
                GridLines="None" AutoGenerateColumns="false"
                OnRowCommand="ProductosGridView_RowCommand"> 
                <Columns>
                    <asp:TemplateField HeaderText="Editar">
                        <ItemTemplate>
                            <asp:LinkButton ID="EditBtn" runat="server" CommandName="Editar"
                                CommandArgument='<%# Eval("idProducto") %>'>
                                <i class="fas fa-edit"></i>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Eliminar">
                        <ItemTemplate>
                            <asp:LinkButton ID="DeleteBtn" runat="server" CommandName="Eliminar"
                                OnClientClick="return confirm('¿Esta seguro que desea eliminar este producto?')"
                                CommandArgument='<%# Eval("idProducto") %>'>
                                <i class="fas fa-trash-alt text-danger"></i>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                    <asp:BoundField HeaderText="Negocio" DataField="LineaNegocio_Producto" />
                </Columns>
            </asp:GridView>


        </div>
    </div>


        </div>
    </form>

     <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
     <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
     <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>


</body>
</html>