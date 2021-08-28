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
    public class Ticket : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Ticket(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            int nextSecuencia = DistributedIdGeneratorHelper.Generate(this.Session.DataLayer, this.GetType().FullName, string.Empty);
            NumTicket = string.Format("T{0:D5}", nextSecuencia);
        }


        TipoSoporte tipoSoporte;
        string resolucion;
        string detalle;
        string asunto;
        Priority prioridad;
        TicketStatus estado;
        DateTime fechaSolucion;
        DateTime fechaRequerida;
        DateTime fechaSolicitud;
        string numTicket;
        Clientes clienteId;

        [Association]
        [XafDisplayName("Usuario Solicitante")]
        public Clientes ClienteId
        {
            get => clienteId;
            set => SetPropertyValue(nameof(ClienteId), ref clienteId, value);
        }

        
        public TipoSoporte TipoSoporte
        {
            get => tipoSoporte;
            set => SetPropertyValue(nameof(TipoSoporte), ref tipoSoporte, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [ReadOnly(true)]
        public string NumTicket
        {
            get => numTicket;
            set => SetPropertyValue(nameof(NumTicket), ref numTicket, value);
        }


        public DateTime FechaSolicitud
        {
            get => fechaSolicitud;
            set => SetPropertyValue(nameof(FechaSolicitud), ref fechaSolicitud, value);
        }


        public DateTime FechaRequerida
        {
            get => fechaRequerida;
            set => SetPropertyValue(nameof(FechaRequerida), ref fechaRequerida, value);
        }

        [XafDisplayName("Fecha y Hora")]
        public DateTime FechaSolucion
        {
            get => fechaSolucion;
            set => SetPropertyValue(nameof(FechaSolucion), ref fechaSolucion, value);
        }


        public TicketStatus Estado
        {
            get => estado;
            set => SetPropertyValue(nameof(Estado), ref estado, value);
        }



        public Priority Prioridad
        {
            get => prioridad;
            set => SetPropertyValue(nameof(Prioridad), ref prioridad, value);
        }


        [Size(250)]
        public string Asunto
        {
            get => asunto;
            set => SetPropertyValue(nameof(Asunto), ref asunto, value);
        }


        [Size(-1)]
        public string Detalle
        {
            get => detalle;
            set => SetPropertyValue(nameof(Detalle), ref detalle, value);
        }



        [Size(-1)]
        public string Resolucion
        {
            get => resolucion;
            set => SetPropertyValue(nameof(Resolucion), ref resolucion, value);
        }

        private TimeSpan tiempo;
        public TimeSpan Tiempo
        {
            get { return tiempo; }
            set { SetPropertyValue(nameof(Tiempo), ref tiempo, value); }
        }

        FileData archivo;

        public FileData Archivo
        {
            get { return archivo; }
            set
            {
                SetPropertyValue(nameof(Archivo), ref archivo, value);
            }
        }

        FileData archivoSolucion;

        public FileData ArchivoSolucion
        {
            get { return archivoSolucion; }
            set
            {
                SetPropertyValue(nameof(ArchivoSolucion), ref archivoSolucion, value);
            }
        }






    }
}