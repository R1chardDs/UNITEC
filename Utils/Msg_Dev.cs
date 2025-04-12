namespace Calculadora_de_Salarios.Utils
{
    public enum TipoMensaje
    {
        EnDesarrollo = 1,
        EnReparacion = 2
    }

    public static class Mensajes
    {
        public static void Mostrar(TipoMensaje tipo)
        {
            string mensaje = "";
            string titulo = "";

            switch (tipo)
            {
                case TipoMensaje.EnDesarrollo:
                    mensaje = "Esta funcionalidad está en desarrollo. Espere futuras actualizaciones.";
                    titulo = "En desarrollo";
                    break;
                case TipoMensaje.EnReparacion:
                    mensaje = "Esta funcionalidad está fuera de servicio temporalmente.";
                    titulo = "En reparación";
                    break;
            }

            System.Windows.Forms.MessageBox.Show(
                mensaje,
                titulo,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
