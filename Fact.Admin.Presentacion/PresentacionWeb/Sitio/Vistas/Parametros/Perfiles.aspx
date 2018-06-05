<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Perfiles.aspx.cs" Inherits="PresentacionWeb.Sitio.Vistas.Parametros.Perfiles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
     <div class="container">
    <asp:UpdatePanel ID="upnlPage" runat="server">
        <ContentTemplate>                  
        <div runat="server" id="pnlList">
            <fieldset>
                                <legend>
                                    <h4 class="moveback">
                                        Perfiles</h4>
                                </legend>
                               <h4 class="moveback">
                                  <asp:Button ID="btnNuevo" class="btn btn-default" runat="server" Text="Nuevo Perfil" OnClick="btnNuevo_Click" CausesValidation="False"/>
                               </h4>
                                <%--<div class="row">
                                    <div class="col-sm-3 nopadding">
                                      <div class="form-group">
                                        <asp:DropDownList class="form-control" ID="cmbEmpresas" runat="server"></asp:DropDownList>                              
                                      </div>
                                    </div>                                    
                                </div>--%>
                                <div>                                    
                                    <div id="no-more-gridView">
                                        <asp:GridView ID="grdListaPerfiles" CssClass="table table-hover table-striped grid" runat="server" Width="100%" EmptyDataText="No Records found" AutoGenerateColumns="False" DataKeyNames="roin_rol_id" OnRowCommand="grdListaPerfiles_RowCommand" OnRowDataBound="grdListaPerfiles_RowDataBound">
                                            
                                            <Columns>
                                                <asp:BoundField DataField="rovc_nombre_rol" HeaderText="Rol" />
                                                <asp:ButtonField ButtonType="Image" CommandName="EDITAR" ImageUrl="~/UI/img/file_edit.png" Text="Editar">
                                                <ControlStyle Width="16px" />
                                                <ItemStyle HorizontalAlign="Center" Width="20px" />
                                                </asp:ButtonField>
                                                <asp:ButtonField ButtonType="Image" CommandName="ELIMINAR" ImageUrl="~/UI/img/file_delete.png" Text="Eliminar">
                                                <ControlStyle Width="16px" />
                                                <ItemStyle HorizontalAlign="Center" Width="20px" />
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
                        <h4><asp:Label ID="lblTitle" runat="server" Text="Creacion de una nuevo perfil"></asp:Label></h4>
                      </div>
                    </div>
                    <div class="panel-body">
          
                      <div class="form form-vertical">
                        
                        <div class="control-group">
                          <label>Nombre de Perfil
                              <asp:RequiredFieldValidator ID="rfvNombrePerfil" runat="server" ControlToValidate="txtNombrePerfil" ErrorMessage="Debe escribir el nombre de la empresa" Text="*" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>                              
                          </label>
                          &nbsp;<div class="controls">                            
                            <asp:TextBox ID="txtNombrePerfil" CssClass="form-control" runat="server" placeholder="Ingrese el Nombre del Perfil"></asp:TextBox>
                          </div>
                        </div>  

                        <div class="control-group">
                          <label></label>
                          <div class="controls">
                               <asp:Button ID="btGuardar" class="btn btn-primary" runat="server" Text="Guardar" OnClientClick="if (Page_ClientValidate()) showLoader('Registrando Perfil...');" OnClick="btGuardar_Click"/>
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
