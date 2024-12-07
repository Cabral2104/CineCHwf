using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CineCHwf
{
    public partial class Form1 : Form
    {
        // Variable global para almacenar el ID del usuario autenticado
        private int idUsuarioAutenticado = -1;

        public Form1()
        {
            InitializeComponent();
            // Al iniciar, solo mostramos la pestaña de inicio de sesión
            tabControl1.SelectedIndex = 0;  

           
            tabControl1.TabPages[1].Enabled = false;  

            // Captura el evento para no permitir el cambio de pestaña si no se ha iniciado sesión
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // Configuración de sucursales en el ComboBox
            cmbSucursal.Items.Add(new { Text = "Cine Pape", Value = 1 });
            cmbSucursal.Items.Add(new { Text = "Cine Frontera", Value = 2 });
            cmbSucursal.Items.Add(new { Text = "Cine Castaños", Value = 3 });
            cmbSucursal.DisplayMember = "Text";
            cmbSucursal.ValueMember = "Value";
            cmbSucursal.SelectedIndex = 0; // Selecciona la primera opción por defecto
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Conexión EXITOSA");

                // Llamar al método de autenticación
                if (!AutenticarUsuario(connection))
                {
                    lblError.Text = "Autenticación fallida. Intenta nuevamente.";
                    return;
                }

                connection.Close(); // Cerrar la conexión

                // Si la autenticación es exitosa, habilitar las demás pestañas
                tabControl1.TabPages[1].Enabled = true;  
                idUsuarioAutenticado = 1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
        // Evento que se ejecuta cuando se intenta cambiar de pestaña
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el usuario no está autenticado, bloqueamos el cambio de pestaña
            if (idUsuarioAutenticado == -1 && tabControl1.SelectedIndex != 0)
            {
                // Volver a la pestaña de inicio de sesión (índice 0)
                MessageBox.Show("Debes iniciar sesión primero.");
                tabControl1.SelectedIndex = 0;
            }
        }
        // Método para autenticar al usuario
        private bool AutenticarUsuario(SqlConnection connection)
        {
            string username = txtUsername.Text;  // txtUsername es el TextBox donde se ingresa el usuario
            string password = txtPassword.Text;  // txtPassword es el TextBox donde se ingresa la contraseña

            string query = "SELECT id FROM Usuario WHERE username = @username AND password = @password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();  // Leer el primer (y único) registro
                    idUsuarioAutenticado = (int)reader["id"];  // Almacenar el ID del usuario autenticado
                    MessageBox.Show("¡Bienvenido, " + username + "!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar: " + ex.Message);
                return false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos están llenos
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) ||
                string.IsNullOrEmpty(txtRFC.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Cadena de conexión
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando para insertar un nuevo cliente
                    string query = "INSERT INTO Cliente (nombres, apellidos, RFC, telefono, email, fecha_registro, status, id_Usuario_crea) " +
                                   "VALUES (@nombres, @apellidos, @RFC, @telefono, @email, @fecha_registro, @status, @id_Usuario_crea)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignamos los valores de los TextBox a los parámetros del SQL
                        command.Parameters.AddWithValue("@nombres", txtNombres.Text);
                        command.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                        command.Parameters.AddWithValue("@RFC", txtRFC.Text);
                        command.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text ?? (object)DBNull.Value); // Si el email es vacío, lo dejamos como NULL
                        command.Parameters.AddWithValue("@fecha_registro", DateTime.Now); // La fecha de registro será la actual
                        command.Parameters.AddWithValue("@status", 1); // Estado activo (1)
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioAutenticado); 

                        // Ejecutamos el comando
                        command.ExecuteNonQuery();

                        MessageBox.Show("Cliente agregado exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }
            }
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            // Cadena de conexión
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            // Consulta SQL para obtener todos los clientes
            string query = "SELECT id, nombres, apellidos, RFC, telefono, email, status FROM Cliente"; // Filtramos solo clientes activos

            try
            {
                // Crear una nueva conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Crear el comando con la consulta
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Crear un DataTable para almacenar los resultados
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos de la base de datos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView para mostrar los datos
                    dgvClientes.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si algo falla
                MessageBox.Show("Ocurrió un error al cargar los clientes: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Cadena de conexión
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            // Verificamos que haya un cliente seleccionado
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente para editar.");
                return;
            }

            // Obtenemos el ID del cliente seleccionado
            int clienteId = (int)dgvClientes.SelectedRows[0].Cells["id"].Value;

            // Recuperamos los nuevos datos de los campos de texto
            string nombre = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string rfc = txtRFC.Text;
            string email = txtEmail.Text;
            bool status = chkStatus.Checked; // El nuevo estado (activo/inactivo)

            int idUsuarioEdita = idUsuarioAutenticado;

            List<string> setClauses = new List<string>();

            // Variables para saber qué campos han sido editados
            bool nombreEditado = !string.IsNullOrEmpty(nombre);
            bool apellidosEditado = !string.IsNullOrEmpty(apellidos);
            bool telefonoEditado = !string.IsNullOrEmpty(telefono);
            bool rfcEditado = !string.IsNullOrEmpty(rfc);
            bool emailEditado = !string.IsNullOrEmpty(email);
            bool statusEditado = status != Convert.ToBoolean(dgvClientes.SelectedRows[0].Cells["status"].Value);

            // Siempre actualizamos el id_Usuario_edita
            setClauses.Add("id_Usuario_edita = @idUsuarioEdita");

            // Construimos el query de actualización, solo actualizando los campos editados
            StringBuilder queryBuilder = new StringBuilder("UPDATE Cliente SET ");

            if (nombreEditado)
                queryBuilder.Append("nombres = @nombres, ");
            if (apellidosEditado)
                queryBuilder.Append("apellidos = @apellidos, ");
            if (telefonoEditado)
                queryBuilder.Append("telefono = @telefono, ");
            if (rfcEditado)
                queryBuilder.Append("RFC = @rfc, ");
            if (emailEditado)
                queryBuilder.Append("email = @email, ");
            if (statusEditado)
                queryBuilder.Append("status = @status, ");

            // Eliminamos la última coma y agregamos la condición WHERE
            string query = queryBuilder.ToString().TrimEnd(',', ' ') + " WHERE id = @id";

           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Pasamos los parámetros solo si los campos fueron editados
                        if (nombreEditado)
                            command.Parameters.AddWithValue("@nombres", nombre);
                        if (apellidosEditado)
                            command.Parameters.AddWithValue("@apellidos", apellidos);
                        if (telefonoEditado)
                            command.Parameters.AddWithValue("@telefono", telefono);
                        if (rfcEditado)
                            command.Parameters.AddWithValue("@rfc", rfc);
                        if (emailEditado)
                            command.Parameters.AddWithValue("@email", email);
                        if (statusEditado)
                            command.Parameters.AddWithValue("@status", status);

                        // ID del cliente a editar
                        command.Parameters.AddWithValue("@id", clienteId);

                        // Ejecutar la actualización
                        command.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Cliente editado correctamente.");

                        
                        CargarClientes(); // Llama a una función para recargar el DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el cliente: " + ex.Message);
                }
            }
        }

        private void CargarClientes()
        {
            // Cadena de conexión
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            string query = "SELECT id, nombres, apellidos, RFC, telefono, email, status FROM Cliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgvClientes.DataSource = dataTable;  // Asignar los datos al DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }

        private void btnAgrergarBoleto_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrEmpty(txtFechaCompra.Text) || string.IsNullOrEmpty(txtPrecio.Text) ||
                string.IsNullOrEmpty(txtIdCliente.Text) || string.IsNullOrEmpty(txtIdTipoBoleto.Text))  // Agregado: validar id_Tipo_boleto
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Obtener los valores de los campos
            DateTime fechaCompra = DateTime.Parse(txtFechaCompra.Text);
            int precio = int.Parse(txtPrecio.Text);
            int idCliente = int.Parse(txtIdCliente.Text);
            int idTipoBoleto = int.Parse(txtIdTipoBoleto.Text);  // Obtener el id del tipo de boleto
            int idUsuarioCreador = idUsuarioAutenticado;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Boleto (fecha_compra, precio, id_cliente, id_Tipo_boleto, id_Usuario_crea) " +
                                   "VALUES (@fechaCompra, @precio, @idCliente, @idTipoBoleto, @idUsuarioCreador)";  // Modificado para incluir id_Tipo_boleto

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fechaCompra", fechaCompra);
                        command.Parameters.AddWithValue("@precio", precio);
                        command.Parameters.AddWithValue("@idCliente", idCliente);
                        command.Parameters.AddWithValue("@idTipoBoleto", idTipoBoleto);  // Agregado para el tipo de boleto
                        command.Parameters.AddWithValue("@idUsuarioCreador", idUsuarioCreador);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Boleto agregado exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar boleto: " + ex.Message);
                }
            }
        }

        private void btnEditarBoleto_Click(object sender, EventArgs e)
        {
            // Verificar que haya un boleto seleccionado
            if (dgvBoletos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un boleto para editar.");
                return;
            }

            // Obtener el ID del boleto seleccionado
            int boletoId = (int)dgvBoletos.SelectedRows[0].Cells["id"].Value;

            // Obtener los nuevos valores de los campos
            DateTime nuevaFechaCompra = DateTime.Parse(txtFechaCompra.Text);
            int nuevoPrecio = int.Parse(txtPrecio.Text);
            int nuevoIdCliente = int.Parse(txtIdCliente.Text);
            int nuevoIdTipoBoleto = int.Parse(txtIdTipoBoleto.Text);  // Obtener el nuevo id del tipo de boleto
            int nuevoStatus = chkStatus.Checked ? 0 : 1;
            int idUsuarioEdita = idUsuarioAutenticado;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Boleto SET fecha_compra = @nuevaFechaCompra, precio = @nuevoPrecio, id_cliente = @nuevoIdCliente, " +
                                   "id_Tipo_boleto = @nuevoIdTipoBoleto, status = @nuevoStatus, id_Usuario_edita = @idUsuarioEdita " +
                                   "WHERE id = @boletoId";  // Modificado para incluir id_Tipo_boleto

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nuevaFechaCompra", nuevaFechaCompra);
                        command.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
                        command.Parameters.AddWithValue("@nuevoIdCliente", nuevoIdCliente);
                        command.Parameters.AddWithValue("@nuevoIdTipoBoleto", nuevoIdTipoBoleto);  // Agregado para el tipo de boleto
                        command.Parameters.AddWithValue("@nuevoStatus", nuevoStatus);
                        command.Parameters.AddWithValue("@idUsuarioEdita", idUsuarioEdita);
                        command.Parameters.AddWithValue("@boletoId", boletoId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Boleto editado correctamente.");
                            CargarBoletos(); // Llama a una función para recargar el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No se pudo editar el boleto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el boleto: " + ex.Message);
                }
            }
        }
        private void CargarBoletos()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            string query = "SELECT b.id, b.fecha_compra, b.precio, c.nombres, c.apellidos, b.status, b.id_Tipo_boleto " +  // Agregado id_Tipo_boleto
                           "FROM Boleto b " +
                           "JOIN Cliente c ON b.id_cliente = c.id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgvBoletos.DataSource = dataTable;

                    // Opcional: Si deseas cambiar el nombre de la columna 'id_Tipo_boleto' para que sea más amigable, puedes hacerlo aquí.
                    dgvBoletos.Columns["id_Tipo_boleto"].HeaderText = "Tipo de Boleto ID"; // Cambiar el nombre de la columna
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar boletos: " + ex.Message);
            }
        }

        private void btnVerBoletos_Click(object sender, EventArgs e)
        {
            CargarBoletos();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos ni contengan solo espacios
            if (string.IsNullOrWhiteSpace(txtMonto.Text) ||
                string.IsNullOrWhiteSpace(txtMetodoPago.Text) ||
                string.IsNullOrWhiteSpace(txtIdClientePago.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            // Validar que el monto sea un número válido
            if (!int.TryParse(txtMonto.Text, out int monto))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                return;
            }

            // Validar que el ID del cliente sea un número válido
            if (!int.TryParse(txtIdClientePago.Text, out int idCliente))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
                return;
            }

            // Si pasa todas las validaciones, continúa con la conexión y ejecución
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Pago (fecha_pago, monto, metodo_pago, id_cliente, status, id_Usuario_crea) " +
                                   "VALUES (@fecha_pago, @monto, @metodo_pago, @id_cliente, @status, @id_Usuario_crea)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fecha_pago", dtpFechaPago.Value);
                        command.Parameters.AddWithValue("@monto", monto);
                        command.Parameters.AddWithValue("@metodo_pago", txtMetodoPago.Text.Trim());
                        command.Parameters.AddWithValue("@id_cliente", idCliente);
                        command.Parameters.AddWithValue("@status", 1); // Activo
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioAutenticado);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Pago agregado correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el pago: " + ex.Message);
                }
            }
            CargarPagos();
        }

        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id, fecha_pago, monto, metodo_pago, id_cliente, status FROM Pago";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgvPagos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pagos: " + ex.Message);
            }
        }

        private void btnEditarPago_Click(object sender, EventArgs e)
        {
            if (dgvPagos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un pago para editar.");
                return;
            }

            int pagoId = (int)dgvPagos.SelectedRows[0].Cells["id"].Value;
            string metodoPago = txtMetodoPago.Text;
            int monto = int.Parse(txtMonto.Text);
            int idCliente = int.Parse(txtIdClientePago.Text);
            bool status = chkPagoActivo.Checked;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Pago SET fecha_pago = @fecha_pago, monto = @monto, metodo_pago = @metodo_pago, id_cliente = @id_cliente, status = @status, id_Usuario_edita = @id_Usuario_edita WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fecha_pago", dtpFechaPago.Value);
                        command.Parameters.AddWithValue("@monto", monto);
                        command.Parameters.AddWithValue("@metodo_pago", metodoPago);
                        command.Parameters.AddWithValue("@id_cliente", idCliente);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@id_Usuario_edita", idUsuarioAutenticado);
                        command.Parameters.AddWithValue("@id", pagoId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Pago editado correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el pago: " + ex.Message);
                }
            }
            CargarPagos();
        }

        private void CargarPagos()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id, fecha_pago, monto, metodo_pago, id_cliente, status FROM Pago";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvPagos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los pagos: " + ex.Message);
                }
            }
        }

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos ni contengan solo espacios
            if (string.IsNullOrWhiteSpace(txtIdClienteReserva.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            // Validar que el ID del cliente sea un número válido
            if (!int.TryParse(txtIdClienteReserva.Text, out int idCliente))
            {
                MessageBox.Show("Por favor, ingrese un ID de cliente válido.");
                return;
            }

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Reserva (fecha_reserva, id_cliente, status, id_Usuario_crea) " +
                                   "VALUES (@fecha_reserva, @id_cliente, @status, @id_Usuario_crea)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fecha_reserva", dtpFechaReserva.Value);
                        command.Parameters.AddWithValue("@id_cliente", idCliente);
                        command.Parameters.AddWithValue("@status", 1); // Activo
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioAutenticado);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Reserva agregada correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la reserva: " + ex.Message);
                }
            }

            // Actualizar el DataGridView
            CargarReservas();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una reserva para editar.");
                return;
            }

            int reservaId = (int)dgvReservas.SelectedRows[0].Cells["id"].Value;
            DateTime fechaReserva = dtpFechaReserva.Value;
            int idCliente = int.Parse(txtIdClienteReserva.Text);
            bool status = chkStatusReserva.Checked;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Reserva SET fecha_reserva = @fecha_reserva, id_cliente = @id_cliente, status = @status, id_Usuario_edita = @id_Usuario_edita WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Se añaden los parámetros para la consulta SQL
                        command.Parameters.AddWithValue("@fecha_reserva", fechaReserva);
                        command.Parameters.AddWithValue("@id_cliente", idCliente);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@id_Usuario_edita", idUsuarioAutenticado);
                        command.Parameters.AddWithValue("@id", reservaId);

                        // Ejecutamos la consulta
                        command.ExecuteNonQuery();
                        MessageBox.Show("Reserva editada correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar la reserva: " + ex.Message);
                }
            }

            // Actualizamos el DataGridView con los cambios
            CargarReservas();
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void CargarReservas()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id, fecha_reserva, id_cliente, status FROM Reserva";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvReservas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las reservas: " + ex.Message);
                }
            }
        }

        private void btnAgregarPromocion_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar descuento (debe ser un número válido)
            if (!int.TryParse(txtDescuento.Text, out int descuento))
            {
                MessageBox.Show("Por favor, ingrese un descuento válido.");
                return;
            }

            // Obtener valores de los controles
            string descripcion = txtDescripcion.Text;
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            bool status = chkStatusPromocion.Checked; // Estado activo (1) o inactivo (0)
            int idUsuarioCrea = idUsuarioAutenticado;

            // Cadena de conexión
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            // Conexión y comando SQL para agregar la promoción
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Promocion (descripcion, fecha_inicio, fecha_fin, descuento, status, id_Usuario_crea) " +
                                   "VALUES (@descripcion, @fecha_inicio, @fecha_fin, @descuento, @status, @id_Usuario_crea)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                        command.Parameters.AddWithValue("@fecha_fin", fechaFin);
                        command.Parameters.AddWithValue("@descuento", descuento);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioCrea);

                        // Ejecutar comando
                        command.ExecuteNonQuery();
                        MessageBox.Show("Promoción agregada exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la promoción: " + ex.Message);
                }
            }

            // Recargar promociones
            CargarPromociones();

        }

        private void btnVerPromocion_Click(object sender, EventArgs e)
        {
            CargarPromociones();
        }

        private void btnEditarPromocion_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvPromociones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una promoción para editar.");
                return;
            }

            // Obtener el ID de la promoción seleccionada
            int promocionId = (int)dgvPromociones.SelectedRows[0].Cells["id"].Value;

            // Obtener los valores actuales de la promoción seleccionada para no modificarlos si el campo está vacío
            string descripcion = dgvPromociones.SelectedRows[0].Cells["descripcion"].Value.ToString();
            DateTime fechaInicio = (DateTime)dgvPromociones.SelectedRows[0].Cells["fecha_inicio"].Value;
            DateTime fechaFin = (DateTime)dgvPromociones.SelectedRows[0].Cells["fecha_fin"].Value;
            int descuento = (int)dgvPromociones.SelectedRows[0].Cells["descuento"].Value;
            bool status = (bool)dgvPromociones.SelectedRows[0].Cells["status"].Value;

            // Verificar campos que el usuario haya llenado
            if (!string.IsNullOrWhiteSpace(txtDescripcion.Text))
                descripcion = txtDescripcion.Text;

            if (!string.IsNullOrWhiteSpace(txtDescuento.Text) && int.TryParse(txtDescuento.Text, out int newDescuento))
                descuento = newDescuento;

            if (dtpFechaInicio.Value != fechaInicio)
                fechaInicio = dtpFechaInicio.Value;

            if (dtpFechaFin.Value != fechaFin)
                fechaFin = dtpFechaFin.Value;

            if (chkStatusPromocion.Checked != status)
                status = chkStatusPromocion.Checked;

            // Cadena de conexión
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Promocion SET descripcion = @descripcion, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, " +
                                   "descuento = @descuento, status = @status, id_Usuario_edita = @id_Usuario_edita WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar parámetros solo si han sido modificados
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                        command.Parameters.AddWithValue("@fecha_fin", fechaFin);
                        command.Parameters.AddWithValue("@descuento", descuento);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@id_Usuario_edita", idUsuarioAutenticado);
                        command.Parameters.AddWithValue("@id", promocionId);

                        // Ejecutar la actualización
                        command.ExecuteNonQuery();
                        MessageBox.Show("Promoción editada correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar la promoción: " + ex.Message);
                }
            }

            // Recargar promociones
            CargarPromociones();
        }
        private void CargarPromociones()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            string query = "SELECT id, descripcion, fecha_inicio, fecha_fin, descuento, status FROM Promocion";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvPromociones.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las promociones: " + ex.Message);
                }
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos están llenos
            if (string.IsNullOrEmpty(txtNombreProveedor.Text) || string.IsNullOrEmpty(txtTelefonoProveedor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Cadena de conexión
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando para insertar un nuevo proveedor
                    string query = "INSERT INTO Proveedor (nombre, telefono, email, status, id_Usuario_crea) " +
                                   "VALUES (@nombre, @telefono, @email, @status, @id_Usuario_crea)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignamos los valores de los TextBox a los parámetros del SQL
                        command.Parameters.AddWithValue("@nombre", txtNombreProveedor.Text);
                        command.Parameters.AddWithValue("@telefono", txtTelefonoProveedor.Text);
                        command.Parameters.AddWithValue("@email", txtEmailProveedor.Text ?? (object)DBNull.Value); // Si el email es vacío, lo dejamos como NULL
                        command.Parameters.AddWithValue("@status", 1); // Estado activo (1)
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioAutenticado); // ID del usuario que crea

                        // Ejecutamos el comando
                        command.ExecuteNonQuery();

                        MessageBox.Show("Proveedor agregado exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar proveedor: " + ex.Message);
                }
            }

            // Recargar el DataGridView
            CargarProveedores();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            // Verificamos que haya un proveedor seleccionado
            if (dgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un proveedor para editar.");
                return;
            }

            // Obtenemos el ID del proveedor seleccionado
            int proveedorId = (int)dgvProveedores.SelectedRows[0].Cells["id"].Value;

            // Verificamos que al menos uno de los campos a editar tenga datos
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) && string.IsNullOrWhiteSpace(txtTelefonoProveedor.Text) && string.IsNullOrWhiteSpace(txtEmailProveedor.Text))
            {
                MessageBox.Show("Por favor, ingrese al menos un campo para editar.");
                return;
            }

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comienza la construcción de la consulta
                    string query = "UPDATE Proveedor SET ";

                    // Verificamos qué campos fueron editados y construimos el query de forma dinámica
                    List<string> setClauses = new List<string>();
                    if (!string.IsNullOrWhiteSpace(txtNombreProveedor.Text))
                        setClauses.Add("nombre = @nombre");
                    if (!string.IsNullOrWhiteSpace(txtTelefonoProveedor.Text))
                        setClauses.Add("telefono = @telefono");
                    if (!string.IsNullOrWhiteSpace(txtEmailProveedor.Text))
                        setClauses.Add("email = @email");
                    setClauses.Add("id_Usuario_edita = @id_Usuario_edita");

                    // Agregar el campo `status` a la consulta si fue modificado
                    setClauses.Add("status = @status");

                    // Concatenamos las condiciones SET de forma dinámica
                    query += string.Join(", ", setClauses) + " WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregamos los parámetros solo si los campos fueron modificados
                        if (!string.IsNullOrWhiteSpace(txtNombreProveedor.Text))
                            command.Parameters.AddWithValue("@nombre", txtNombreProveedor.Text);
                        if (!string.IsNullOrWhiteSpace(txtTelefonoProveedor.Text))
                            command.Parameters.AddWithValue("@telefono", txtTelefonoProveedor.Text);
                        if (!string.IsNullOrWhiteSpace(txtEmailProveedor.Text))
                            command.Parameters.AddWithValue("@email", txtEmailProveedor.Text);
                        command.Parameters.AddWithValue("@id_Usuario_edita", idUsuarioAutenticado);
                        command.Parameters.AddWithValue("@status", chkStatusProveedor.Checked ? 1 : 0);  // Cambiar el estado según el CheckBox
                        command.Parameters.AddWithValue("@id", proveedorId);

                        // Ejecutamos el comando
                        command.ExecuteNonQuery();

                        MessageBox.Show("Proveedor editado exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el proveedor: " + ex.Message);
                }
            }

            // Recargar el DataGridView
            CargarProveedores();
        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }
        private void CargarProveedores()
        {
            // Cadena de conexión
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";

            // Consulta SQL para obtener todos los proveedores
            string query = "SELECT id, nombre, telefono, email, status FROM Proveedor";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgvProveedores.DataSource = dataTable;  // Asignar los datos al DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar proveedores: " + ex.Message);
                }
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Registro_ventas (id_Cliente, id_Sucursal, id_Pago, fecha_venta, total, status, id_Usuario_crea) " +
                                   "VALUES (@id_Cliente, @id_Sucursal, @id_Pago, @fecha_venta, @total, @status, @id_Usuario_crea)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_Cliente", int.Parse(txtIdClienteVenta.Text));
                        command.Parameters.AddWithValue("@id_Sucursal", ((dynamic)cmbSucursal.SelectedItem).Value);
                        command.Parameters.AddWithValue("@id_Pago", int.Parse(txtIdPagoVenta.Text));
                        command.Parameters.AddWithValue("@fecha_venta", dtpFechaVenta.Value);
                        command.Parameters.AddWithValue("@total", int.Parse(txtTotalVenta.Text));
                        command.Parameters.AddWithValue("@status", chkVentaActiva.Checked);
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioAutenticado);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Venta registrada correctamente.");
                    }
                }
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la venta: " + ex.Message);
            }
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una venta para editar.");
                return;
            }

            int idVenta = (int)dgvVentas.SelectedRows[0].Cells["id"].Value;

            try
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Registro_ventas SET id_Cliente = @id_Cliente, id_Sucursal = @id_Sucursal, id_Pago = @id_Pago, " +
                                   "fecha_venta = @fecha_venta, total = @total, status = @status, id_Usuario_edita = @id_Usuario_edita WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_Cliente", int.Parse(txtIdClienteVenta.Text));
                        command.Parameters.AddWithValue("@id_Sucursal", ((dynamic)cmbSucursal.SelectedItem).Value);
                        command.Parameters.AddWithValue("@id_Pago", int.Parse(txtIdPagoVenta.Text));
                        command.Parameters.AddWithValue("@fecha_venta", dtpFechaVenta.Value);
                        command.Parameters.AddWithValue("@total", int.Parse(txtTotalVenta.Text));
                        command.Parameters.AddWithValue("@status", chkVentaActiva.Checked);
                        command.Parameters.AddWithValue("@id_Usuario_edita", idUsuarioAutenticado);
                        command.Parameters.AddWithValue("@id", idVenta);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Venta editada correctamente.");
                    }
                }
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la venta: " + ex.Message);
            }
        }

        private void CargarVentas()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id, id_Cliente, id_Sucursal, id_Pago, fecha_venta, total, status FROM Registro_ventas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvVentas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las ventas: " + ex.Message);
                }
            }
        }

        private void btnVerVenta_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnAgregarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Factura (id_Registro_ventas, fecha_factura, total, IVA, cliente_emisor, status, id_Usuario_crea) " +
                                   "VALUES (@id_Registro_ventas, @fecha_factura, @total, @IVA, @cliente_emisor, @status, @id_Usuario_crea)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_Registro_ventas", int.Parse(txtIdRegistroVentas.Text));
                        command.Parameters.AddWithValue("@fecha_factura", dtpFechaFactura.Value);
                        command.Parameters.AddWithValue("@total", int.Parse(txtTotalFactura.Text));
                        command.Parameters.AddWithValue("@IVA", int.Parse(txtIVA.Text));
                        command.Parameters.AddWithValue("@cliente_emisor", txtClienteEmisor.Text);
                        command.Parameters.AddWithValue("@status", chkFacturaActiva.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioAutenticado);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Factura agregada correctamente.");
                    }
                }
                CargarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la factura: " + ex.Message);
            }
        }

        private void btnEditarFactura_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una factura para editar.");
                return;
            }

            int idFactura = (int)dgvFacturas.SelectedRows[0].Cells["id"].Value;

            try
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Factura SET id_Registro_ventas = @id_Registro_ventas, fecha_factura = @fecha_factura, total = @total, " +
                                   "IVA = @IVA, cliente_emisor = @cliente_emisor, status = @status, id_Usuario_edita = @id_Usuario_edita WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_Registro_ventas", int.Parse(txtIdRegistroVentas.Text));
                        command.Parameters.AddWithValue("@fecha_factura", dtpFechaFactura.Value);
                        command.Parameters.AddWithValue("@total", int.Parse(txtTotalFactura.Text));
                        command.Parameters.AddWithValue("@IVA", int.Parse(txtIVA.Text));
                        command.Parameters.AddWithValue("@cliente_emisor", txtClienteEmisor.Text);
                        command.Parameters.AddWithValue("@status", chkFacturaActiva.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@id_Usuario_edita", idUsuarioAutenticado);
                        command.Parameters.AddWithValue("@id", idFactura);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Factura editada correctamente.");
                    }
                }
                CargarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la factura: " + ex.Message);
            }
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }
        private void CargarFacturas()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id, id_Registro_ventas, fecha_factura, total, IVA, cliente_emisor, status FROM Factura";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvFacturas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las facturas: " + ex.Message);
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtTipoProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.");
                    return;
                }

                string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Producto (nombre_producto, tipo, precio, status, id_Usuario_crea) " +
                                   "VALUES (@nombre_producto, @tipo, @precio, @status, @id_Usuario_crea)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre_producto", txtNombreProducto.Text);
                        command.Parameters.AddWithValue("@tipo", txtTipoProducto.Text);
                        command.Parameters.AddWithValue("@precio", int.Parse(txtPrecioProducto.Text));
                        command.Parameters.AddWithValue("@status", chkProductoActivo.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioAutenticado);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Producto agregado correctamente.");
                    }
                }
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.");
                return;
            }

            int idProducto = (int)dgvProductos.SelectedRows[0].Cells["id"].Value;

            try
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Producto SET nombre_producto = @nombre_producto, tipo = @tipo, " +
                                   "precio = @precio, status = @status, id_Usuario_edita = @id_Usuario_edita WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre_producto", txtNombreProducto.Text);
                        command.Parameters.AddWithValue("@tipo", txtTipoProducto.Text);
                        command.Parameters.AddWithValue("@precio", int.Parse(txtPrecioProducto.Text));
                        command.Parameters.AddWithValue("@status", chkProductoActivo.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@id_Usuario_edita", idUsuarioAutenticado);
                        command.Parameters.AddWithValue("@id", idProducto);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Producto editado correctamente.");
                    }
                }
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el producto: " + ex.Message);
            }
        }
        private void CargarProductos()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id, nombre_producto, tipo, precio, status FROM Producto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvProductos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
            }
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnAgregarTipoBoleto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcionTipoBoleto.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.");
                    return;
                }

                string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Tipo_boleto (descripcion, status, id_Usuario_crea) " +
                                   "VALUES (@descripcion, @status, @id_Usuario_crea)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@descripcion", txtDescripcionTipoBoleto.Text);
                        command.Parameters.AddWithValue("@status", chkStatusTipoBoleto.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@id_Usuario_crea", idUsuarioAutenticado);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Tipo de boleto agregado correctamente.");
                    }
                }
                CargarTiposBoleto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tipo de boleto: " + ex.Message);
            }
        }

        private void btnEditarTipoBoleto_Click(object sender, EventArgs e)
        {
            if (dgvTipoBoleto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un tipo de boleto para editar.");
                return;
            }

            int idTipoBoleto = (int)dgvTipoBoleto.SelectedRows[0].Cells["id"].Value;

            try
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Tipo_boleto SET descripcion = @descripcion, status = @status, " +
                                   "id_Usuario_edita = @id_Usuario_edita WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@descripcion", txtDescripcionTipoBoleto.Text);
                        command.Parameters.AddWithValue("@status", chkStatusTipoBoleto.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@id_Usuario_edita", idUsuarioAutenticado);
                        command.Parameters.AddWithValue("@id", idTipoBoleto);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Tipo de boleto editado correctamente.");
                    }
                }
                CargarTiposBoleto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el tipo de boleto: " + ex.Message);
            }
        }
        private void CargarTiposBoleto()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CineCH;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT id, descripcion, status FROM Tipo_boleto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvTipoBoleto.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de boleto: " + ex.Message);
                }
            }
        }

        private void btnVerTiposBoletos_Click(object sender, EventArgs e)
        {
            CargarTiposBoleto();
        }
    }
}
