﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace WSEstudiante
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="WSEstudiante.WebService1Soap")>  _
    Public Interface WebService1Soap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function HelloWorld() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorldAsync() As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ListarFaculdates", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ListarFaculdates() As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ListarFaculdates", ReplyAction:="*")>  _
        Function ListarFaculdatesAsync() As System.Threading.Tasks.Task(Of System.Data.DataTable)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ListarEstudiantes", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ListarEstudiantes() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ListarEstudiantes", ReplyAction:="*")>  _
        Function ListarEstudiantesAsync() As System.Threading.Tasks.Task(Of System.Data.DataSet)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/BuscarEstudiantes", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function BuscarEstudiantes(ByVal cedula As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/BuscarEstudiantes", ReplyAction:="*")>  _
        Function BuscarEstudiantesAsync(ByVal cedula As String) As System.Threading.Tasks.Task(Of System.Data.DataSet)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/BuscarCarreras", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function BuscarCarreras(ByVal facultad As String) As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/BuscarCarreras", ReplyAction:="*")>  _
        Function BuscarCarrerasAsync(ByVal facultad As String) As System.Threading.Tasks.Task(Of System.Data.DataTable)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/CrearEstudiantes", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CrearEstudiantes(ByVal estudiante As WSEstudiante.modeloEstudiante) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/CrearEstudiantes", ReplyAction:="*")>  _
        Function CrearEstudiantesAsync(ByVal estudiante As WSEstudiante.modeloEstudiante) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ActualizarEstudiantes", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ActualizarEstudiantes(ByVal estudiante As WSEstudiante.modeloEstudiante) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ActualizarEstudiantes", ReplyAction:="*")>  _
        Function ActualizarEstudiantesAsync(ByVal estudiante As WSEstudiante.modeloEstudiante) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/EliminarEstudiantes", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function EliminarEstudiantes(ByVal cedula As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/EliminarEstudiantes", ReplyAction:="*")>  _
        Function EliminarEstudiantesAsync(ByVal cedula As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Validarcorreo", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Validarcorreo(ByVal value As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Validarcorreo", ReplyAction:="*")>  _
        Function ValidarcorreoAsync(ByVal value As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ValidarLetras", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ValidarLetras(ByVal value As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ValidarLetras", ReplyAction:="*")>  _
        Function ValidarLetrasAsync(ByVal value As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ValidarNumero", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ValidarNumero(ByVal value As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ValidarNumero", ReplyAction:="*")>  _
        Function ValidarNumeroAsync(ByVal value As String) As System.Threading.Tasks.Task(Of Boolean)
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class modeloEstudiante
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private cedulaField As String
        
        Private nombreField As String
        
        Private apellidoField As String
        
        Private direccionField As String
        
        Private celularField As String
        
        Private correoField As String
        
        Private cod_facultadField As String
        
        Private cod_carreraField As String
        
        Private indice_academicoField As String
        
        Private sexoField As String
        
        Private estatusField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property Cedula() As String
            Get
                Return Me.cedulaField
            End Get
            Set
                Me.cedulaField = value
                Me.RaisePropertyChanged("Cedula")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property Nombre() As String
            Get
                Return Me.nombreField
            End Get
            Set
                Me.nombreField = value
                Me.RaisePropertyChanged("Nombre")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>  _
        Public Property Apellido() As String
            Get
                Return Me.apellidoField
            End Get
            Set
                Me.apellidoField = value
                Me.RaisePropertyChanged("Apellido")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>  _
        Public Property Direccion() As String
            Get
                Return Me.direccionField
            End Get
            Set
                Me.direccionField = value
                Me.RaisePropertyChanged("Direccion")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>  _
        Public Property celular() As String
            Get
                Return Me.celularField
            End Get
            Set
                Me.celularField = value
                Me.RaisePropertyChanged("celular")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>  _
        Public Property correo() As String
            Get
                Return Me.correoField
            End Get
            Set
                Me.correoField = value
                Me.RaisePropertyChanged("correo")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>  _
        Public Property cod_facultad() As String
            Get
                Return Me.cod_facultadField
            End Get
            Set
                Me.cod_facultadField = value
                Me.RaisePropertyChanged("cod_facultad")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>  _
        Public Property cod_carrera() As String
            Get
                Return Me.cod_carreraField
            End Get
            Set
                Me.cod_carreraField = value
                Me.RaisePropertyChanged("cod_carrera")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>  _
        Public Property indice_academico() As String
            Get
                Return Me.indice_academicoField
            End Get
            Set
                Me.indice_academicoField = value
                Me.RaisePropertyChanged("indice_academico")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>  _
        Public Property sexo() As String
            Get
                Return Me.sexoField
            End Get
            Set
                Me.sexoField = value
                Me.RaisePropertyChanged("sexo")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>  _
        Public Property estatus() As String
            Get
                Return Me.estatusField
            End Get
            Set
                Me.estatusField = value
                Me.RaisePropertyChanged("estatus")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface WebService1SoapChannel
        Inherits WSEstudiante.WebService1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WebService1SoapClient
        Inherits System.ServiceModel.ClientBase(Of WSEstudiante.WebService1Soap)
        Implements WSEstudiante.WebService1Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function HelloWorld() As String Implements WSEstudiante.WebService1Soap.HelloWorld
            Return MyBase.Channel.HelloWorld
        End Function
        
        Public Function HelloWorldAsync() As System.Threading.Tasks.Task(Of String) Implements WSEstudiante.WebService1Soap.HelloWorldAsync
            Return MyBase.Channel.HelloWorldAsync
        End Function
        
        Public Function ListarFaculdates() As System.Data.DataTable Implements WSEstudiante.WebService1Soap.ListarFaculdates
            Return MyBase.Channel.ListarFaculdates
        End Function
        
        Public Function ListarFaculdatesAsync() As System.Threading.Tasks.Task(Of System.Data.DataTable) Implements WSEstudiante.WebService1Soap.ListarFaculdatesAsync
            Return MyBase.Channel.ListarFaculdatesAsync
        End Function
        
        Public Function ListarEstudiantes() As System.Data.DataSet Implements WSEstudiante.WebService1Soap.ListarEstudiantes
            Return MyBase.Channel.ListarEstudiantes
        End Function
        
        Public Function ListarEstudiantesAsync() As System.Threading.Tasks.Task(Of System.Data.DataSet) Implements WSEstudiante.WebService1Soap.ListarEstudiantesAsync
            Return MyBase.Channel.ListarEstudiantesAsync
        End Function
        
        Public Function BuscarEstudiantes(ByVal cedula As String) As System.Data.DataSet Implements WSEstudiante.WebService1Soap.BuscarEstudiantes
            Return MyBase.Channel.BuscarEstudiantes(cedula)
        End Function
        
        Public Function BuscarEstudiantesAsync(ByVal cedula As String) As System.Threading.Tasks.Task(Of System.Data.DataSet) Implements WSEstudiante.WebService1Soap.BuscarEstudiantesAsync
            Return MyBase.Channel.BuscarEstudiantesAsync(cedula)
        End Function
        
        Public Function BuscarCarreras(ByVal facultad As String) As System.Data.DataTable Implements WSEstudiante.WebService1Soap.BuscarCarreras
            Return MyBase.Channel.BuscarCarreras(facultad)
        End Function
        
        Public Function BuscarCarrerasAsync(ByVal facultad As String) As System.Threading.Tasks.Task(Of System.Data.DataTable) Implements WSEstudiante.WebService1Soap.BuscarCarrerasAsync
            Return MyBase.Channel.BuscarCarrerasAsync(facultad)
        End Function
        
        Public Function CrearEstudiantes(ByVal estudiante As WSEstudiante.modeloEstudiante) As Boolean Implements WSEstudiante.WebService1Soap.CrearEstudiantes
            Return MyBase.Channel.CrearEstudiantes(estudiante)
        End Function
        
        Public Function CrearEstudiantesAsync(ByVal estudiante As WSEstudiante.modeloEstudiante) As System.Threading.Tasks.Task(Of Boolean) Implements WSEstudiante.WebService1Soap.CrearEstudiantesAsync
            Return MyBase.Channel.CrearEstudiantesAsync(estudiante)
        End Function
        
        Public Function ActualizarEstudiantes(ByVal estudiante As WSEstudiante.modeloEstudiante) As Boolean Implements WSEstudiante.WebService1Soap.ActualizarEstudiantes
            Return MyBase.Channel.ActualizarEstudiantes(estudiante)
        End Function
        
        Public Function ActualizarEstudiantesAsync(ByVal estudiante As WSEstudiante.modeloEstudiante) As System.Threading.Tasks.Task(Of Boolean) Implements WSEstudiante.WebService1Soap.ActualizarEstudiantesAsync
            Return MyBase.Channel.ActualizarEstudiantesAsync(estudiante)
        End Function
        
        Public Function EliminarEstudiantes(ByVal cedula As String) As Boolean Implements WSEstudiante.WebService1Soap.EliminarEstudiantes
            Return MyBase.Channel.EliminarEstudiantes(cedula)
        End Function
        
        Public Function EliminarEstudiantesAsync(ByVal cedula As String) As System.Threading.Tasks.Task(Of Boolean) Implements WSEstudiante.WebService1Soap.EliminarEstudiantesAsync
            Return MyBase.Channel.EliminarEstudiantesAsync(cedula)
        End Function
        
        Public Function Validarcorreo(ByVal value As String) As Boolean Implements WSEstudiante.WebService1Soap.Validarcorreo
            Return MyBase.Channel.Validarcorreo(value)
        End Function
        
        Public Function ValidarcorreoAsync(ByVal value As String) As System.Threading.Tasks.Task(Of Boolean) Implements WSEstudiante.WebService1Soap.ValidarcorreoAsync
            Return MyBase.Channel.ValidarcorreoAsync(value)
        End Function
        
        Public Function ValidarLetras(ByVal value As String) As Boolean Implements WSEstudiante.WebService1Soap.ValidarLetras
            Return MyBase.Channel.ValidarLetras(value)
        End Function
        
        Public Function ValidarLetrasAsync(ByVal value As String) As System.Threading.Tasks.Task(Of Boolean) Implements WSEstudiante.WebService1Soap.ValidarLetrasAsync
            Return MyBase.Channel.ValidarLetrasAsync(value)
        End Function
        
        Public Function ValidarNumero(ByVal value As String) As Boolean Implements WSEstudiante.WebService1Soap.ValidarNumero
            Return MyBase.Channel.ValidarNumero(value)
        End Function
        
        Public Function ValidarNumeroAsync(ByVal value As String) As System.Threading.Tasks.Task(Of Boolean) Implements WSEstudiante.WebService1Soap.ValidarNumeroAsync
            Return MyBase.Channel.ValidarNumeroAsync(value)
        End Function
    End Class
End Namespace