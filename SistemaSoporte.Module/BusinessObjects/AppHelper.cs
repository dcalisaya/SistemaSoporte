using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System;
using System.Linq;

namespace SistemaSoporte.Module.BusinessObjects
{

    public enum Area
    {
        Gerencia, Bodega, Comunicaciones, Hotel
    }

    public enum TipoSoporte
    {
        Interno, Externo, Otros
    }

    public enum Priority
    {
        [ImageName("State_Priority_Low")]
        Low = 0,
        [ImageName("State_Priority_Normal")]
        Normal = 1,
        [ImageName("State_Priority_High")]
        High = 2
    }
    public enum ProformaStatus
    {
        [ImageName("State_Task_NotStarted")]
        Borrador = 0,
        [ImageName("State_Task_InProgress")]
        Revision = 1,
        [ImageName("State_Validation_Valid")]
        Enviada = 2,
        [ImageName("Action_Grant")]
        Acepdata = 3,
        [ImageName("State_Task_Deferred")]
        Facturada = 4,
        [ImageName("BO_Attention")]
        NoEjetutado = 5
    }

    public enum EstadoServicio
    {
        [ImageName("State_Task_NotStarted")]
        Inactivo = 0,

        [ImageName("State_Validation_Valid")]
        Activo = 1,

        [ImageName("State_Task_Deferred")]
        EsperaConfirmacion = 2

    }
    public enum FacturaStatus
    {
        [ImageName("State_Task_NotStarted")]
        Borrador = 0,
        [ImageName("State_Task_InProgress")]
        Enviado = 1,
        [ImageName("State_Validation_Skipped")]
        Recibida = 3,
        [ImageName("State_Validation_Valid")]
        Pagado = 2,
        [ImageName("State_Validation_Invalid")]
        Anulada = 4

    }

    public enum TicketStatus
    {
        [ImageName("State_Task_NotStarted")]
        NotStarted = 0,
        [ImageName("State_Task_InProgress")]
        InProgress = 1,
        [ImageName("State_Validation_Valid")]
        Completed = 2,
        [ImageName("State_Task_Deferred")]
        Deferred = 3
    }

    public enum TipoTrabajo
    {
        Diseno, Television, Radio, Web, Fotografia, SocialNetwork, Otros
    }
    public enum TipoIRF
    {
        IVA, Alimentacion, Salud, Educacion, Vivienda, Vestimenta
    }

    public enum ListadoFrecuencias { Mensual, Trimestral, Semestral, Anual }

    public enum ListadoMeses { Enero = 1, Febrero = 2, Marzo = 3, Abril = 4, Mayo = 5, Junio = 6, Julio = 7, Agosto = 8, Septiembre = 9, Octubre = 10, Noviembre = 11, Diciembre = 12, NA = 0 }

    public enum TipoCuenta { Ahorros, Corriente }
    public enum TipoDocumento { Ningua, Factura, Retencion, NotaCredito, Otros }
    public enum TipoComprobante { FacturaVenta, FacturaCompra, ComprobateRetencion, Otros }

    public enum TipoServicio
    {
        [XafDisplayName("Ninguna")]
        Ninguna,
        [XafDisplayName("Dominio")]
        Dominio,
        [XafDisplayName("Hosting")]
        Hosting,
        [XafDisplayName("Mantenimiento")]
        DominioHosting,
        [XafDisplayName("SSL")]
        SSL
    }

    public enum QuoteTerms
    {
        [XafDisplayName("On Deliver")]
        OnDeliver = 0,
        [XafDisplayName("8 Days")]
        Days8 = 1,
        [XafDisplayName("15 Days")]
        Days15 = 2,
        [XafDisplayName("30 Days")]
        Days30 = 3,
        [XafDisplayName("45 Days")]
        Days45 = 4

    }


}
