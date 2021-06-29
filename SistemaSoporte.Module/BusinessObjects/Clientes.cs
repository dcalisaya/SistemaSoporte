using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SistemaSoporte.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Soporte")]
    [ImageName("BO_Contact")]
    [DefaultProperty("RazonSocial")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]

    public class Clientes : XPObject
    {

        public Clientes(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            int nextSecuencia = DistributedIdGeneratorHelper.Generate(this.Session.DataLayer, this.GetType().FullName, string.Empty);
            NumCliente = string.Format("C{0:D5}", nextSecuencia);

        }

        // esta información de clientes debe tener: Num, Identifacion, Razon Social, Email, Direccion, Telefono

        string observaciones;
        string telefono;
        string direccion;
        string email;
        string identifcacion;
        string numCliente;
        string razonSocial;


        [Size(50)]
        [ModelDefault("AllowEdit", "False")]
        public string NumCliente
        {
            get => numCliente;
            set => SetPropertyValue(nameof(NumCliente), ref numCliente, value);
        }

        [Size(250)]
        [RuleRequiredField]
        [XafDisplayName("Razón Social")]
        public string RazonSocial
        {
            get => razonSocial;
            set => SetPropertyValue(nameof(RazonSocial), ref razonSocial, value);
        }


        [Size(50)]
        [RuleRequiredField]
        public string Identifcacion
        {
            get => identifcacion;
            set => SetPropertyValue(nameof(Identifcacion), ref identifcacion, value);
        }

        public const string EmailRegularExpression = "^[A-Za-z0-9_\\+-]+(\\.[A-Za-z0-9_\\+-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9-]+)*\\.([A-Za-z]{2,4})$";

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [RuleRequiredField]
        [RuleRegularExpression(EmailRegularExpression, CustomMessageTemplate = "El Correo debe ser válido!")]
        [XafDisplayName("Correo Electrónico")]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }


        [Size(250)]
        public string Direccion
        {
            get => direccion;
            set => SetPropertyValue(nameof(Direccion), ref direccion, value);
        }


        [Size(250)]
        public string Telefono
        {
            get => telefono;
            set => SetPropertyValue(nameof(Telefono), ref telefono, value);
        }


        [Size(-1)]
        public string Observaciones
        {
            get => observaciones;
            set => SetPropertyValue(nameof(Observaciones), ref observaciones, value);
        }


    }
}