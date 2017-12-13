﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Frm_BajaModificar.aspx.vb" Inherits="Aplicacion_Web.aspx___VB.Frm_BajaModificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Alta Persona</title>

    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous" />
</head>
<body>






    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo03" aria-controls="navbarTogglerDemo03" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <a class="navbar-brand" href="#">ABML</a>

        <div class="collapse navbar-collapse" id="navbarTogglerDemo03">
            <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                <li class="nav-item active">
                    <a class="nav-link" href="Frm_ABMLPerona.aspx">Alta<span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="Frm_BajaModificar.aspx">Baja/Modificación</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="Frm_BajaModificar.aspx">Lista</a>
                </li>
            </ul>
            
        </div>
    </nav>

    <div class="text-center">
        <h1>BAJA/MODIFICAR Persona</h1>
    </div>
    <div class="container">
        <div class="row justify-content-md-center">
            <div class="col-10">
                <form runat="server" id="form1">


                     <div class="table-responsive">
                           <table id="tabla" class="table table-striped" style="background-color:white;">
                               <tr>
                                <th>Id_Persona</th>
                                <th>Nombre y apellido</th> 
                                <th>Fecha Nacimiento</th>
                                 <th>Edad</th>
                                <th>Sexo</th>
                                <th>Modificar</th>
                                <th>Eliminar</th>
                               </tr>
                            <asp:Repeater ID="repeater" runat="server" > 
                                <ItemTemplate>
                                    <tr>
                                     <td><%# Container.DataItem("id_persona")%></td>
                                    <td><%# Container.DataItem("NombreApellido")%></td>
                                    <td><%# Container.DataItem("fNacimiento")%></td>
                                    <td><%# Container.DataItem("edad")%></td>
                                    <td><%#Container.DataItem("sexo")%></td>
                                  
                                    
                                    <td><a href="javascript:$('#modificar').modal('show');
                                        $('#id_persona').val('<%#Container.DataItem("id_persona")%>');
                                        $('#nombreApellido').val('<%#Container.DataItem("NombreApellido")%>');
                                        var date = new Date('<%#Container.DataItem("fNacimiento")%>');
                                        var currentDate = date.toISOString().slice(0,10);
                                        document.getElementById('fechaNacimiento').value = currentDate;                                 
                                        $('#edad').val('<%#Container.DataItem("edad")%>');
                                        $('#masculino1').attr('checked', 'checked');
                                        ">MODIFICAR</a></td>

                               


                                     <td><a href="javascript:$('#baja').modal('show');$('#Text1').val('<%#Container.DataItem("id_persona")%>');
                                        $('#labe').html('Esta seguro que desea dar de baja la persona: <%#Container.DataItem("nombreApellido")%> ??');
                                        ">ELIMINAR</a></td>
                                    </tr>
                                </ItemTemplate>
                                
     
                             </asp:Repeater>
                                 
                            </table>
                          
                    </div>    









                     <div class="modal fade" id="modificar" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                      <div class="modal-dialog" role="document">
                        <div class="modal-content">
                          <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                              <h4>Modificar</h4>
                            <input style="display:none" type="text" class="modal-title" runat="server" id="id_persona"/>
                          </div>
                          <div class="modal-body">
                             <div class="form-group row">
                        <label for="inputEmail3" class="col-sm-12 col-form-label">Nombre y apellido completo</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="nombreApellido" placeholder="Nombre y apellido" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="nombreApellido" runat="server"
                                ErrorMessage="Campo vacio" ValidationGroup="grupo1"></asp:RequiredFieldValidator>
                        </div>
                    </div>


                    <div class="form-group row">
                        <label for="fechaN" class="col-sm-12 col-form-label">Fecha de nacimiento</label>
                        <div class="col-sm-9">
                            <input type="date" class="form-control" id="fechaNacimiento" placeholder="Fecha de nacimiento"  />

                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="edad" class="col-sm-12 col-form-label">Edad</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="edad" placeholder="Edad" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="edad" runat="server"
                                ErrorMessage="Campo vacio" ValidationGroup="grupo1"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator2" runat="server"
                                ControlToValidate="edad" ErrorMessage="Ingrese solo números"
                                Operator="DataTypeCheck" Type="Integer" ValidationGroup="grupo1"></asp:CompareValidator>
                        </div>
                    </div>

                    <fieldset class="form-group">
                        <div class="row">
                            <legend class="col-form-legend col-sm-3">Sexo</legend>
                            <div class="col-sm-9">
                                <div class="form-check">
                                    <label class="form-check-label">
                                        <input class="form-check-input" runat="server" type="radio" name="gridRadios" id="femenino1" value="option1" cheked=""/>
                                        FEMENINO
                                    </label>
                                </div>

                                <div class="form-check">
                                    <label class="form-check-label">
                                        <input class="form-check-input" runat="server" type="radio" name="gridRadios" id="masculino1" value="option2" />
                                        MASCULINO
                                    </label>
                                </div>
                            </div>
                        </div>
                    </fieldset>

                                <div class="form-group row" <%--style="display:none;"--%>>

                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="fechaN" runat="server" />
                          

                        </div>
                    </div>

                   

                              
                          </div>
                          <div class="modal-footer">
                                  <button type="submit" onmouseover="#" id="btnModificar" class="btn btn-primary" runat="server" validationgroup="grupo1">ACEPTAR</button>
                
                          </div>
                        </div>
                      </div>
                    </div>































                    <%--MODAL BAJA--%>
                    <div class="modal fade" id="baja" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                          <div class="modal-dialog" role="document">
                            <div class="modal-content">
                              <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                  <h4>Eliminar Persona</h4>
                                <input style="display:none" type="text" class="modal-title" runat="server" id="Text1"/>
                              </div>
                              <div class="modal-body">
                               <label runat="server" id="labe" style="color:inherit;"></label>
               

                              </div>
                              <div class="modal-footer">
                                <button type="button" id="baja1" runat="server" class="btn btn-default" data-dismiss="modal">Aceptar</button>
                
                              </div>
                            </div>
                          </div>
                        </div>
























                </form>
            </div>
        </div>
    </div>


     <script>

        document.getElementById("fechaNacimiento").addEventListener("change", myFunction);

        function myFunction() {
            var x = document.getElementById("edad");
            var f = document.getElementById("fechaN");

            var edad = new Date($("#fechaNacimiento").val());
            var hoy = new Date();



            edad.setDate(edad.getDate() + 1);





            f.value = edad.toDateString();

            var anio = hoy.getFullYear() - edad.getFullYear();

            if (edad.getMonth() > hoy.getMonth()) {
                x.value = anio - 1;

            }
            else {
                if (edad.getMonth() === hoy.getMonth()) {
                    if (edad.getDate() + 1 > hoy.getDate()) {

                        x.value = anio - 1;
                    }
                    else {
                        x.value = anio;
                    }
                }
                else {
                    x.value = anio;
                }

            }


        }
    </script>

   







    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>



</body>
</html>
