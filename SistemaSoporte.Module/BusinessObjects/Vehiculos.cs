using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace SistemaSoporte.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Vehiculos : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Vehiculos(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        [Association]
        public Clientes ClienteId
        {
            get => clienteId;
            set => SetPropertyValue(nameof(ClienteId), ref clienteId, value);
        }


        MarcaModelos marcaModeloId;
        MarcaVehiculo marcaVehiculoId;
        Clientes clienteId;
        string placa;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Placa
        {
            get => placa;
            set => SetPropertyValue(nameof(Placa), ref placa, value);
        }

        [XafDisplayName("Marca")]
        public MarcaVehiculo MarcaVehiculoId
        {
            get => marcaVehiculoId;
            set => SetPropertyValue(nameof(MarcaVehiculoId), ref marcaVehiculoId, value);
        }

        [XafDisplayName("Modelo")]
        [DataSourceProperty("MarcaVehiculoId.ModelosVehiculo")]
        public MarcaModelos MarcaModeloId
        {
            get => marcaModeloId;
            set => SetPropertyValue(nameof(MarcaModeloId), ref marcaModeloId, value);
        }



        [Association, DevExpress.Xpo.Aggregated]
        public XPCollection<VehiculosMantenimiento> MantenimientoVehiculos
        {
            get
            {
                return GetCollection<VehiculosMantenimiento>(nameof(MantenimientoVehiculos));
            }
        }
    }
}