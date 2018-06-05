<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CreaEmpresa.aspx.cs" Inherits="PresentacionWeb.Sitio.Vistas.Administracion.CreaEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
  <div class="container">
    <asp:UpdatePanel ID="upnlPage" runat="server">
        <ContentTemplate>                  
        <div runat="server" id="pnlList">
            <fieldset>
                                <legend>
                                    <h4 class="moveback">
                                        EMPRESAS</h4>
                                </legend>
                               <h4 class="moveback">
                                  <asp:Button ID="btnNuevo" class="btn btn-default" runat="server" Text="Nueva Empresa" OnClick="btnNuevo_Click" />
                               </h4>
                                <div class="row">
                                    <div class="col-sm-3 nopadding">
                                      <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtBuscaNombreEmpresa" runat="server" placeholder="Nombre de Empresa"></asp:TextBox>                                
                                      </div>
                                    </div>
                                    <div class="col-sm-2">
                                        <div class="form-group">
                                          <asp:Button ID="btnBuscar" class="btn btn-primary" runat="server" OnClientClick="showLoader('Buscando Empresa...');"  Text="Buscar" OnClick="btnBuscar_Click" />                                         
                                        </div>
                                    </div>
                                </div>
                                <div>                                    
                                    <div id="no-more-gridView">
                                        <asp:GridView ID="grdListaEmpresas" CssClass="table table-hover table-striped grid" runat="server" Width="100%" EmptyDataText="No Records found" AutoGenerateColumns="False" DataKeyNames="embi_empresa_id" OnRowCommand="grdListaEmpresas_RowCommand" OnRowDataBound="grdListaEmpresas_RowDataBound">
                                            
                                            <Columns>
                                                <asp:BoundField DataField="emvc_nombre_empresa" HeaderText="Empresa" />
                                                <asp:BoundField DataField="emvc_sucursal_empresa" HeaderText="Sucursal" />
                                                <asp:BoundField DataField="emvc_direccion_empresa" HeaderText="Direccion" />
                                                <asp:BoundField DataField="lxvc_ciudad" HeaderText="Ciudad" />
                                                <asp:BoundField DataField="emvc_telefono_empresa" HeaderText="Telefono" />
                                                <asp:BoundField DataField="emvc_cel_empresa" HeaderText="Celular" />
                                                <asp:BoundField DataField="emvc_nit_empresa" HeaderText="Nit Empresa" />
                                                <asp:ButtonField ButtonType="Image" CommandName="EDITAR" ImageUrl="~/UI/img/file_edit.png" Text="Editar">
                                                <ControlStyle Width="16px" />
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:ButtonField>
                                                <asp:ButtonField ButtonType="Image" CommandName="ELIMINAR" ImageUrl="~/UI/img/file_delete.png" Text="Eliminar">
                                                <ControlStyle Width="16px" />
                                                <ItemStyle HorizontalAlign="Center" />
                                                </asp:ButtonField>
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                  </div>
                            </fieldset>
        </div>

         <div runat="server" id="pnlForm">
              <div class="panel panel-default">
                    <div class="panel-heading">
                      <div class="panel-title">
                        <i class="glyphicon glyphicon-wrench pull-right"></i>
                        <h4><asp:Label ID="lblTitle" runat="server" Text="Creacion de una nueva empresa"></asp:Label></h4>
                      </div>
                    </div>
                    <div class="panel-body">
          
                      <div class="form form-vertical">
                        
                        <div class="control-group">
                          <label>Nombre de Empresa
                              <asp:RequiredFieldValidator ID="rfvNombreEmpresa" runat="server" ControlToValidate="txtNombreEmpresa" ErrorMessage="Debe escribir el nombre de la empresa" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>                              
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtNombreEmpresa" CssClass="form-control" runat="server" placeholder="Ingrese el Nombre de la empresa"></asp:TextBox>
                          </div>
                        </div>  

                        <div class="control-group">
                          <label>Sucursal Empresa
                              <asp:RequiredFieldValidator ID="rfvSucursalEmpresa" runat="server" ControlToValidate="txtSucursal" ErrorMessage="Debe escribir el nombre de la Sucursal" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>                              
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtSucursal" CssClass="form-control" runat="server" placeholder="Ingrese el Nombre de la sucursal"></asp:TextBox>
                          </div>
                        </div>  

                        <div class="control-group">
                          <label>Nit Empresa
                              <asp:RequiredFieldValidator ID="rfvNitEmpresa" runat="server" ControlToValidate="txtNit" ErrorMessage="Debe escribir el nit" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>                              
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtNit" CssClass="form-control" runat="server" placeholder="Ingrese el numero de nit"></asp:TextBox>
                          </div>
                        </div> 

                        <div class="control-group">
                          <label>Direccion Empresa
                              <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Debe escribir la Direccion" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>                              
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server" placeholder="Ingrese la direccion de la empresa"></asp:TextBox>
                          </div>
                        </div> 

                        <div class="control-group">
                          <label>Telefono Empresa
                              <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Debe escribir el Telefono" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>                              
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" placeholder="Ingrese el telefono de la empresa"></asp:TextBox>
                          </div>
                        </div> 

                        <div class="control-group">
                          <label>Celular Empresa
                              <asp:RequiredFieldValidator ID="rfvCelular" runat="server" ControlToValidate="txtCelular" ErrorMessage="Debe escribir el numero de Celular" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>                              
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtCelular" CssClass="form-control" runat="server" placeholder="Ingrese el numero de celular"></asp:TextBox>
                          </div>
                        </div> 
                        <div class="control-group">
                          <label>Ciudad Empresa
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCelular" ErrorMessage="Debe escribir el numero de Celular" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>                              
                          </label>
                          &nbsp;<div class="controls">          
                              <asp:DropDownList ID="cmbCiudad" CssClass="form-control" runat="server"></asp:DropDownList>                  
                           <%-- <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Ingrese el numero de celular"></asp:TextBox>--%>
                          </div>
                        </div> 

                        <%--<div class="control-group">
                          <label>Valor Asegurado
                              <asp:RequiredFieldValidator ID="rfvAplicativo" runat="server" ControlToValidate="txtValorAsegurado" ErrorMessage="Debe escribir el valor asegurado" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="revAplicativo" runat="server" ControlToValidate="txtValorAsegurado" ErrorMessage="El valor no es valido" Text="*" ForeColor="Red" Font-Size="Large" ValidationExpression="^[0-9]+(\.[0-9]+)?$">*</asp:RegularExpressionValidator>
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtValorAsegurado" CssClass="form-control" runat="server" placeholder="Ingrese el valor asegurado"></asp:TextBox>
                          </div>
                        </div>  
                            
                        <div class="control-group">
                          <label>Porcentaje Cobertura
                              <asp:RequiredFieldValidator ID="rfvPorcentaje" runat="server" ControlToValidate="txtPorcentajeCobertura" ErrorMessage="Debe escribir el Porcentaje de cobertura" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="revPorcentaje" runat="server" ControlToValidate="txtPorcentajeCobertura" ErrorMessage="El valor no es valido" Text="*" ForeColor="Red" Font-Size="Large" ValidationExpression="^[0-9]+(\.[0-9]+)?$">*</asp:RegularExpressionValidator> 
                          </label>
                          <div class="controls">
                              <asp:TextBox id="txtPorcentajeCobertura" CssClass="form-control" runat="server" placeholder="Ingrese el Porcentaje de cobertura"/>
                          </div>
                        </div> 
                          
                          <div class="control-group">
                          <label>Condicion
                              <asp:RequiredFieldValidator ID="rfvCondicion" runat="server" ControlToValidate="txtCondicion" ErrorMessage="Debe escribir la descripcion" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtCondicion" CssClass="form-control" runat="server" placeholder="Ingrese la condicion del cambio"></asp:TextBox>
                          </div>
                        </div> --%>

                        <div class="control-group">
                          <label></label>
                          <div class="controls">
                               <asp:Button ID="btGuardar" class="btn btn-primary" runat="server" Text="Guardar" OnClientClick="if (Page_ClientValidate()) showLoader('Registrando Empresa...');" OnClick="btGuardar_Click"/>
                               <asp:Button ID="btnCancelar" class="btn btn-default" runat="server" Text="Cancelar" CausesValidation ="False" OnClick="btnCancelar_Click" />
                          </div>
                        </div>   
            
                      </div>
                    </div><!--/panel content-->
                  </div>
        </div> 
        </ContentTemplate>
    </asp:UpdatePanel>
  </div>

</asp:Content>
