using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboratorio1
{
    public partial class Form1 : Form
    {
        // Constructor del formulario
        public Form1()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        #region "DATOS INICIALES - Cargar ComboBox con las unidades"

        private void CargarDatosIniciales()
        {
            // MONEDA - Cargar opciones en los ComboBox
            string[] monedas = {
                "Dólar estadounidense (USD)",
                "Euro (EUR)",
                "Peso mexicano (MXN)",
                "Libra esterlina (GBP)",
                "Yen japonés (JPY)",
                "Franco suizo (CHF)",
                "Dólar canadiense (CAD)",
                "Yuan chino (CNY)",
                "Peso argentino (ARS)",
                "Real brasileño (BRL)"
            };

            // LONGITUD - Cargar opciones en los ComboBox
            string[] longitudes = {
                "Metro (m)",
                "Centímetro (cm)",
                "Milímetro (mm)",
                "Kilómetro (km)",
                "Pulgada (in)",
                "Pie (ft)",
                "Yarda (yd)",
                "Milla (mi)",
                "Micrón (μm)",
                "Año luz"
            };

            // VOLUMEN - Cargar opciones en los ComboBox  
            string[] volumenes = {
                "Litro (L)",
                "Mililitro (mL)",
                "Metro cúbico (m³)",
                "Centímetro cúbico (cm³)",
                "Galón estadounidense (gal)",
                "Galón imperial (imp gal)",
                "Cuarto (qt)",
                "Pinta (pt)",
                "Onza líquida (fl oz)",
                "Barril (bbl)"
            };

            // ALMACENAMIENTO - Cargar opciones en los ComboBox
            string[] almacenamientos = {
                "Byte (B)",
                "Kilobyte (KB)",
                "Megabyte (MB)",
                "Gigabyte (GB)",
                "Terabyte (TB)",
                "Petabyte (PB)",
                "Bit (bit)",
                "Kilobit (Kb)",
                "Megabit (Mb)",
                "Gigabit (Gb)"
            };

            // TIEMPO - Cargar opciones en los ComboBox
            string[] tiempos = {
                "Segundo (s)",
                "Minuto (min)",
                "Hora (h)",
                "Día (d)",
                "Semana (sem)",
                "Mes (mes)",
                "Año (año)",
                "Milisegundo (ms)",
                "Microsegundo (μs)",
                "Nanosegundo (ns)"
            };

            // MASA - Cargar opciones en los ComboBox
            string[] masas = {
                "Kilogramo (kg)",
                "Gramo (g)",
                "Miligramo (mg)",
                "Tonelada (t)",
                "Libra (lb)",
                "Onza (oz)",
                "Piedra (st)",
                "Quilate (ct)",
                "Grano (gr)",
                "Arroba (@)"
            };

            // Cargar datos en todos los ComboBox de Moneda
            cboDeMoneda.Items.AddRange(monedas);
            cboAMoneda.Items.AddRange(monedas);

            // Cargar datos en todos los ComboBox de Longitud
            cboDeLongitud.Items.AddRange(longitudes);
            cboALongitud.Items.AddRange(longitudes);

            // Cargar datos en todos los ComboBox de Volumen
            cboDeVolumen.Items.AddRange(volumenes);
            cboAVolumen.Items.AddRange(volumenes);

            // Cargar datos en todos los ComboBox de Almacenamiento
            cboDeAlmacen.Items.AddRange(almacenamientos);
            cboAAlmacen.Items.AddRange(almacenamientos);

            // Cargar datos en todos los ComboBox de Tiempo
            cboDeTiempo.Items.AddRange(tiempos);
            cboATiempo.Items.AddRange(tiempos);

            // Cargar datos en todos los ComboBox de Masa
            cboDeMasa.Items.AddRange(masas);
            cboAMasa.Items.AddRange(masas);

            // Establecer valores por defecto (opcional)
            cboDeMoneda.SelectedIndex = 0;
            cboAMoneda.SelectedIndex = 1;
            cboDeLongitud.SelectedIndex = 0;
            cboALongitud.SelectedIndex = 1;
            cboDeVolumen.SelectedIndex = 0;
            cboAVolumen.SelectedIndex = 1;
            cboDeAlmacen.SelectedIndex = 0;
            cboAAlmacen.SelectedIndex = 1;
            cboDeTiempo.SelectedIndex = 0;
            cboATiempo.SelectedIndex = 1;
            cboDeMasa.SelectedIndex = 0;
            cboAMasa.SelectedIndex = 1;
        }

        #endregion

        #region "EVENTO CLICK - BOTÓN CONVERTIR MONEDA"

        private void btnConvertirMoneda_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado un valor numérico
                if (!double.TryParse(txtMoneda.Text, out double valor))
                {
                    lblRMoneda.Text = "Error: Ingrese un valor numérico válido";
                    return;
                }

                // Validar que se hayan seleccionado las unidades
                if (cboDeMoneda.SelectedIndex == -1 || cboAMoneda.SelectedIndex == -1)
                {
                    lblRMoneda.Text = "Error: Seleccione las unidades de conversión";
                    return;
                }

                // Obtener los índices de las monedas seleccionadas
                int monedaOrigen = cboDeMoneda.SelectedIndex;
                int monedaDestino = cboAMoneda.SelectedIndex;

                // Tasas de cambio base (todas convertidas a USD como referencia)
                double[] tasasAUSD = { 1.0, 1.08, 0.059, 1.27, 0.0067, 1.10, 0.74, 0.14, 0.0011, 0.18 };

                // Convertir: primero a USD, luego a la moneda destino
                double valorEnUSD = valor * tasasAUSD[monedaOrigen];
                double resultado = valorEnUSD / tasasAUSD[monedaDestino];

                // Mostrar el resultado con formato adecuado
                lblRMoneda.Text = $"{resultado:F4}";
            }
            catch (Exception ex)
            {
                lblRMoneda.Text = $"Error: {ex.Message}";
            }
        }

        #endregion

        #region "EVENTO CLICK - BOTÓN CONVERTIR LONGITUD"

        private void btnConvertirLongitud_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado un valor numérico
                if (!double.TryParse(txtLongitud.Text, out double valor))
                {
                    lblRLongitud.Text = "Error: Ingrese un valor numérico válido";
                    return;
                }

                // Validar que se hayan seleccionado las unidades
                if (cboDeLongitud.SelectedIndex == -1 || cboALongitud.SelectedIndex == -1)
                {
                    lblRLongitud.Text = "Error: Seleccione las unidades de conversión";
                    return;
                }

                // Obtener los índices de las unidades seleccionadas
                int unidadOrigen = cboDeLongitud.SelectedIndex;
                int unidadDestino = cboALongitud.SelectedIndex;

                // Factores de conversión a metros (unidad base)
                double[] factoresAMetros = { 1.0, 0.01, 0.001, 1000.0, 0.0254, 0.3048, 0.9144, 1609.34, 0.000001, 9.461e15 };

                // Convertir: primero a metros, luego a la unidad destino
                double valorEnMetros = valor * factoresAMetros[unidadOrigen];
                double resultado = valorEnMetros / factoresAMetros[unidadDestino];

                // Mostrar el resultado
                lblRLongitud.Text = $"{resultado:F6}";
            }
            catch (Exception ex)
            {
                lblRLongitud.Text = $"Error: {ex.Message}";
            }
        }

        #endregion

        #region "EVENTO CLICK - BOTÓN CONVERTIR VOLUMEN"

        private void btnConvertirVolumen_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entrada numérica
                if (!double.TryParse(txtVolumen.Text, out double valor))
                {
                    lblRVolumen.Text = "Error: Ingrese un valor numérico válido";
                    return;
                }

                // Validar selección de unidades
                if (cboDeVolumen.SelectedIndex == -1 || cboAVolumen.SelectedIndex == -1)
                {
                    lblRVolumen.Text = "Error: Seleccione las unidades de conversión";
                    return;
                }

                int unidadOrigen = cboDeVolumen.SelectedIndex;
                int unidadDestino = cboAVolumen.SelectedIndex;

                // Factores de conversión a litros (unidad base)
                double[] factoresALitros = { 1.0, 0.001, 1000.0, 0.001, 3.78541, 4.54609, 0.946353, 0.473176, 0.0295735, 158.987 };

                // Proceso de conversión
                double valorEnLitros = valor * factoresALitros[unidadOrigen];
                double resultado = valorEnLitros / factoresALitros[unidadDestino];

                lblRVolumen.Text = $"{resultado:F6}";
            }
            catch (Exception ex)
            {
                lblRVolumen.Text = $"Error: {ex.Message}";
            }
        }

        #endregion

        #region "EVENTO CLICK - BOTÓN CONVERTIR ALMACENAMIENTO"

        private void btnConvertirAlmacenamiento_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entrada numérica
                if (!double.TryParse(txtAlmacen.Text, out double valor))
                {
                    lblRAlmacen.Text = "Error: Ingrese un valor numérico válido";
                    return;
                }

                // Validar selección de unidades
                if (cboDeAlmacen.SelectedIndex == -1 || cboAAlmacen.SelectedIndex == -1)
                {
                    lblRAlmacen.Text = "Error: Seleccione las unidades de conversión";
                    return;
                }

                int unidadOrigen = cboDeAlmacen.SelectedIndex;
                int unidadDestino = cboAAlmacen.SelectedIndex;

                // Factores de conversión a bytes (unidad base)
                double[] factoresABytes = { 1.0, 1024.0, 1048576.0, 1073741824.0, 1099511627776.0, 1125899906842624.0, 0.125, 128.0, 131072.0, 134217728.0 };

                // Proceso de conversión
                double valorEnBytes = valor * factoresABytes[unidadOrigen];
                double resultado = valorEnBytes / factoresABytes[unidadDestino];

                lblRAlmacen.Text = $"{resultado:F6}";
            }
            catch (Exception ex)
            {
                lblRAlmacen.Text = $"Error: {ex.Message}";
            }
        }

        #endregion

        #region "EVENTO CLICK - BOTÓN CONVERTIR TIEMPO"

        private void btnConvertirTiempo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entrada numérica
                if (!double.TryParse(txtTiempo.Text, out double valor))
                {
                    lblRTiempo.Text = "Error: Ingrese un valor numérico válido";
                    return;
                }

                // Validar selección de unidades
                if (cboDeTiempo.SelectedIndex == -1 || cboATiempo.SelectedIndex == -1)
                {
                    lblRTiempo.Text = "Error: Seleccione las unidades de conversión";
                    return;
                }

                int unidadOrigen = cboDeTiempo.SelectedIndex;
                int unidadDestino = cboATiempo.SelectedIndex;

                // Factores de conversión a segundos (unidad base)
                double[] factoresASegundos = { 1.0, 60.0, 3600.0, 86400.0, 604800.0, 2629746.0, 31556952.0, 0.001, 0.000001, 0.000000001 };

                // Proceso de conversión
                double valorEnSegundos = valor * factoresASegundos[unidadOrigen];
                double resultado = valorEnSegundos / factoresASegundos[unidadDestino];

                lblRTiempo.Text = $"{resultado:F6}";
            }
            catch (Exception ex)
            {
                lblRTiempo.Text = $"Error: {ex.Message}";
            }
        }

        #endregion

        #region "EVENTO CLICK - BOTÓN CONVERTIR MASA"

        private void btnConvertirMasa_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entrada numérica
                if (!double.TryParse(txtMasa.Text, out double valor))
                {
                    lblRMasa.Text = "Error: Ingrese un valor numérico válido";
                    return;
                }

                // Validar selección de unidades
                if (cboDeMasa.SelectedIndex == -1 || cboAMasa.SelectedIndex == -1)
                {
                    lblRMasa.Text = "Error: Seleccione las unidades de conversión";
                    return;
                }

                int unidadOrigen = cboDeMasa.SelectedIndex;
                int unidadDestino = cboAMasa.SelectedIndex;

                // Factores de conversión a kilogramos (unidad base)
                double[] factoresAKilogramos = { 1.0, 0.001, 0.000001, 1000.0, 0.453592, 0.0283495, 6.35029, 0.0002, 0.0000648, 11.502 };

                // Proceso de conversión
                double valorEnKilogramos = valor * factoresAKilogramos[unidadOrigen];
                double resultado = valorEnKilogramos / factoresAKilogramos[unidadDestino];

                lblRMasa.Text = $"{resultado:F6}";
            }
            catch (Exception ex)
            {
                lblRMasa.Text = $"Error: {ex.Message}";
            }
        }

        #endregion

        #region "MÉTODOS AUXILIARES - Limpiar campos"

        // Método para limpiar todos los campos de moneda
        private void LimpiarMoneda()
        {
            txtMoneda.Text = "";
            lblRMoneda.Text = "0";
            cboDeMoneda.SelectedIndex = -1;
            cboAMoneda.SelectedIndex = -1;
        }

        // Método para limpiar todos los campos de longitud
        private void LimpiarLongitud()
        {
            txtLongitud.Text = "";
            lblRLongitud.Text = "0";
            cboDeLongitud.SelectedIndex = -1;
            cboALongitud.SelectedIndex = -1;
        }

        // Método para limpiar todos los campos de volumen
        private void LimpiarVolumen()
        {
            txtVolumen.Text = "";
            lblRVolumen.Text = "0";
            cboDeVolumen.SelectedIndex = -1;
            cboAVolumen.SelectedIndex = -1;
        }

        // Método para limpiar todos los campos de almacenamiento
        private void LimpiarAlmacenamiento()
        {
            txtAlmacen.Text = "";
            lblRAlmacen.Text = "0";
            cboDeAlmacen.SelectedIndex = -1;
            cboAAlmacen.SelectedIndex = -1;
        }

        // Método para limpiar todos los campos de tiempo
        private void LimpiarTiempo()
        {
            txtTiempo.Text = "";
            lblRTiempo.Text = "0";
            cboDeTiempo.SelectedIndex = -1;
            cboATiempo.SelectedIndex = -1;
        }

        // Método para limpiar todos los campos de masa
        private void LimpiarMasa()
        {
            txtMasa.Text = "";
            lblRMasa.Text = "0";
            cboDeMasa.SelectedIndex = -1;
            cboAMasa.SelectedIndex = -1;
        }

        #endregion
    }
}

/* 
 * INSTRUCCIONES DE USO:
 * 
 * 1. Este código debe ir en el archivo Form1.cs de tu proyecto de Windows Forms
 * 
 * 2. Los nombres de los controles que debes usar en tu formulario son:
 *    - MONEDA: txtMoneda, cboDeMoneda, cboAMoneda, lblRMoneda, btnConvertirMoneda
 *    - LONGITUD: txtLongitud, cboDeLongitud, cboALongitud, lblRLongitud, btnConvertirLongitud  
 *    - VOLUMEN: txtVolumen, cboDeVolumen, cboAVolumen, lblRVolumen, btnConvertirVolumen
 *    - ALMACENAMIENTO: txtAlmacenamiento, cboDeAlmacenamiento, cboAAlmacenamiento, lblRAlmacenamiento, btnConvertirAlmacenamiento
 *    - TIEMPO: txtTiempo, cboDeTiempo, cboATiempo, lblRTiempo, btnConvertirTiempo
 *    - MASA: txtMasa, cboDeMasa, cboAMasa, lblRMasa, btnConvertirMasa
 * 
 * 3. Asegúrate de conectar cada botón con su evento correspondiente en el diseñador de Visual Studio
 * 
 * 4. El código incluye validaciones de entrada y manejo de errores
 * 
 * 5. Los factores de conversión están organizados por categoría y son precisos
 * 
 * 6. Para las monedas, ten en cuenta que las tasas de cambio cambian constantemente,
 *    por lo que deberías actualizar estos valores regularmente o conectarte a una API de tipos de cambio
 */
