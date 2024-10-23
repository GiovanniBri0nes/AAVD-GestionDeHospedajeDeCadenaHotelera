using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using GestionDeHospedajeDeCadenaHotelera.Properties;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data;





namespace GestionDeHospedajeDeCadenaHotelera
{
    public class ManagementCassandra
    {
       static private string _CassandraHome { get; set; }
       static private string _Keyspace { get; set; }
       static private Cluster _cluster { get; set; }
        static private ISession _session { get; set; }

        static private ManagementCassandra _instance;

        private ManagementCassandra()
        {
            if (Conectar())
            {
                _session = _cluster.Connect(_Keyspace);
            }
            else
            {
                // Handle connection failure, throw an exception, log an error, etc.
                throw new Exception("Failed to connect to Cassandra.");
            }
        }

        static public ManagementCassandra getInstance()
        {
            if (_instance == null)
            {
                _instance = new ManagementCassandra();
            }
            return _instance;
        }
        static private bool Conectar()
        {

            try
            {
                _CassandraHome = ConfigurationSettings.AppSettings["cassandra_home"].ToString();

                _Keyspace = ConfigurationSettings.AppSettings["keyspace"].ToString();

                _cluster = Cluster.Builder().AddContactPoint(_CassandraHome)
                .WithSocketOptions(new SocketOptions().SetConnectTimeoutMillis(30000)).Build();

                //_cluster = Cluster.Builder().AddContactPoint(_CassandraHome).Build();

                _session = _cluster.Connect(_Keyspace);
                return true;
            }
            catch
            {
                return false;
            }

        }


        public void insertUsuario(string cor, string con, string nom, string numnom, DateTime Fecha, string dom, string tel1, string tel2)
        {
            string query = String.Format("INSERT INTO hotel_keyspace.administrador (correo1, contrasena1, nombre_completo1, numero_nomina1, " +
                                 "fecha_nacimiento1, domicilio1, telefono_casa1, telefono_celular1) " +
                                 "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                                 cor, con, nom, numnom, Fecha.ToString("yyyy-MM-dd"), dom, tel1, tel2);
            _session.Execute(query);
        }

        public void insertOperador(string cor, string con, string nom, string numnom, DateTime Fecha, string dom, string tel1, string tel2)
        {
            string query = String.Format("INSERT INTO hotel_keyspace.operativo (correo, contrasena, nombre_completo, numero_nomina, " +
                                 "fecha_nacimiento, domicilio, telefono_casa, telefono_celular, estado) " +
                                 "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}','{8}');",
                                 cor, con, nom, numnom, Fecha.ToString("yyyy-MM-dd"), dom, tel1, tel2, "ACTIVO");
            _session.Execute(query);
        }

        public void insertHoteles(string nomHo,string ciu, string est, string pai, string dom, int numPi, int numHab,
        string zona, string servi, string carac,string correo,DateTime Fecha)
        {

            string query = String.Format("INSERT INTO hotel_keyspace.hoteles (hotel_id, nombre_hotel, ubicacion_ciudad, " +
                "ubicacion_estado, ubicacion_pais, domicilio, numero_pisos, cantidad_habitaciones, zona_turistica," +
                " servicios_adicionales, caracteristicas_ubicacion, usuario_que_registro, fecha_registro, " +
                "fecha_inicio_operaciones) " +
                "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6}, {7}, '{8}', '{9}', '{10}', '{11}', toTimestamp(now()), '{12}');",
            Guid.NewGuid(),
            nomHo,
            ciu,
            est,
            pai,
            dom,
            numPi,
            numHab,
            zona,
            servi,
            carac,
            correo,
            Fecha.ToString("yyyy-MM-dd"));


            _session.Execute(query);
        }

        public void insertHabitaciones(string hote,int numC,string tipocama,float precio,string nivel,int capac,string carac,
          string corruser)
        {
            
            string queryInsert = string.Format("INSERT INTO hotel_keyspace.habitaciones (habitacion_id, hotel_name, numero_camas, tipos_cama, " +
    "precio_noche_por_persona, nivel_habitacion, capacidad_personas, caracteristicas, usuario_registro, " +
    "fecha_registro, estado_habitacion) " +
    "VALUES ({0}, '{1}', {2}, '{3}', {4}, '{5}', {6}, '{7}', '{8}', toTimestamp(now()), '{9}');",
    Guid.NewGuid(),
    hote,
    numC,
    tipocama,
    precio,
    nivel,
    capac,
    carac,
    corruser,
    "Disponible");

            _session.Execute(queryInsert);

        }





        public void insertClientes(string nombreCompleto,string ap, string am,string domicilio,string rfc,string correoElectronico,
            string telefonoCasa, string telefonoCelular,string referenciaHotel,DateTime fechaNacimiento,
           string estadoCivil,string usuarioModificacion )
        {

            string queryInsertCliente = string.Format("INSERT INTO hotel_keyspace.clientes " +
      "(cliente_id, nombre,a_paterno, a_materno, domicilio, rfc, correo_electronico, telefono_casa, " +
      "telefono_celular, referencia_hotel, fecha_nacimiento, estado_civil, fecha_hora_registro, usuario_modificacion) " +
      "VALUES ({0}, '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', toTimestamp(now()), '{12}');",
      Guid.NewGuid(),
      nombreCompleto,
      ap,
      am,
      domicilio,
      rfc,
      correoElectronico,
      telefonoCasa,
      telefonoCelular,
      referenciaHotel,
      fechaNacimiento.ToString("yyyy-MM-dd"),
      estadoCivil,
      usuarioModificacion);
            _session.Execute(queryInsertCliente);

        }


        public Guid InsertarReserva(string nombre, string apellidoPaterno, string apellidoMaterno, string ciudad, string nombreHotel, string numHab, float precio, DateTime fechaInicio, DateTime fechaFin, float anticipo, string metodoPago, string usuarioRegistro)
        {
            // Genera un nuevo UUID para reserva_id y codigo_reservacion
            Guid reservaId = Guid.NewGuid();
            Guid codigoReservacion = Guid.NewGuid();

            // Convierte DateTime a LocalDate usando el constructor
            LocalDate localFechaInicio = new LocalDate(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day);
            LocalDate localFechaFin = new LocalDate(fechaFin.Year, fechaFin.Month, fechaFin.Day);

            // Crea la consulta INSERT
            string query = "INSERT INTO hotel_keyspace.reservas " +
                           "(reserva_id, nombre, ap, am, ciudad, hotel_name, num_hab, precio, fecha_inicio, fecha_fin, anticipo, metodo_pago, codigo_reservacion, usuario_registro, fecha_registro, estado_reserva) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, toTimestamp(now()), '0');";

            // Prepara y ejecuta la consulta
            var preparedStatement = _session.Prepare(query);
            var boundStatement = preparedStatement.Bind(
                reservaId, nombre, apellidoPaterno, apellidoMaterno, ciudad, nombreHotel, numHab, precio, localFechaInicio, localFechaFin, anticipo, metodoPago, codigoReservacion, usuarioRegistro);

            _session.Execute(boundStatement);

            return codigoReservacion;
        }



        public void ActualizarEstadoReservacion(string codigoReservacion)
        {
            try
            {
                // Convertir el string a un objeto Guid (UUID)
                Guid codigoReservacionGuid = Guid.Parse(codigoReservacion);

                // Realiza la consulta UPDATE para actualizar el estado de la reservación
                string query = "UPDATE hotel_keyspace.reservas SET estado_reserva = ? WHERE reserva_id = ?;";
                var preparedStatement = _session.Prepare(query);

                // Enlaza los parámetros a la consulta preparada
                var boundStatement = preparedStatement.Bind("1", codigoReservacionGuid); // 1 para estado "confirmado"

                // Ejecuta la consulta
                _session.Execute(boundStatement);
            }
            catch (FormatException ex)
            {
                // Manejar la excepción si el formato del UUID es incorrecto
                Console.WriteLine("Error al convertir el código de reservación a UUID: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                Console.WriteLine("Error al actualizar el estado de la reservación: " + ex.Message);
            }
        }


        public void ActualizarEstadoReservacionOut(string codigoReservacion)
        {
            try
            {
                // Convertir el string a un objeto Guid (UUID)
                Guid codigoReservacionGuid = Guid.Parse(codigoReservacion);

                // Realiza la consulta UPDATE para actualizar el estado de la reservación
                string query = "UPDATE hotel_keyspace.reservas SET estado_reserva = ? WHERE reserva_id = ?;";
                var preparedStatement = _session.Prepare(query);

                // Enlaza los parámetros a la consulta preparada
                var boundStatement = preparedStatement.Bind("2", codigoReservacionGuid); // 1 para estado "confirmado"

                // Ejecuta la consulta
                _session.Execute(boundStatement);
            }
            catch (FormatException ex)
            {
                // Manejar la excepción si el formato del UUID es incorrecto
                Console.WriteLine("Error al convertir el código de reservación a UUID: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                Console.WriteLine("Error al actualizar el estado de la reservación: " + ex.Message);
            }
        }



        public void InsertCancelacion(string reservaId, string usuarioAdministrador, string motivoCancelacion)
        {
            // Generar un nuevo UUID para la cancelación
            Guid cancelacionId = Guid.NewGuid();
            // Convertir el ID de reserva a UUID
            Guid reservaUuid = Guid.Parse(reservaId);

            // Consulta INSERT usando parámetros
            string insertQuery = "INSERT INTO hotel_keyspace.cancelaciones (cancelacion_id, reserva_id, usuario_administrador, fecha_cancelacion, motivo_cancelacion) " +
                                 "VALUES (?, ?, ?, toTimestamp(now()), ?);";
            var insertPreparedStatement = _session.Prepare(insertQuery);
            var insertBoundStatement = insertPreparedStatement.Bind(cancelacionId, reservaUuid, usuarioAdministrador, motivoCancelacion);
            _session.Execute(insertBoundStatement);

            // Construye la consulta UPDATE usando parámetros
            string updateQuery = "UPDATE hotel_keyspace.reservas SET estado_reserva = ? WHERE reserva_id = ?;";
            var updatePreparedStatement = _session.Prepare(updateQuery);
            var updateBoundStatement = updatePreparedStatement.Bind("3", reservaUuid); // Cambia a "3" como string
            _session.Execute(updateBoundStatement);
        }




        public DataTable SelectUsuarios()
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT
            string query = "SELECT nombre_completo1 FROM hotel_keyspace.administrador ALLOW FILTERING;";
            var resultSet = _session.Execute(query);

            // Llena el DataTable con los resultados
            foreach (var row in resultSet)
            {
                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    foreach (var column in resultSet.Columns)
                    {
                        dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                    }
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                foreach (var column in resultSet.Columns)
                {
                    dataRow[column.Name] = row[column.Name];
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }

        public DataTable SelectPrecioHabitacion(string nombreHotel, int numeroCamas)
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT con parámetros
            string query = "SELECT precio_noche_por_persona FROM hotel_keyspace.habitaciones WHERE hotel_name = ? AND numero_camas = ? ALLOW FILTERING;";
            var preparedStatement = _session.Prepare(query);

            // Enlaza los parámetros a la consulta preparada
            var boundStatement = preparedStatement.Bind(nombreHotel, numeroCamas);
            // Ejecuta la consulta
            var resultSet = _session.Execute(boundStatement);

            // Llena el DataTable con los resultados
            foreach (var row in resultSet)
            {
                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    foreach (var column in resultSet.Columns)
                    {
                        dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                    }
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                foreach (var column in resultSet.Columns)
                {
                    dataRow[column.Name] = row[column.Name];
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }



        public DataTable SelectNumHabitacion(string nombreHotel)
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT con parámetros
            string query = "SELECT numero_camas FROM hotel_keyspace.habitaciones WHERE hotel_name = ? ALLOW FILTERING;";
            var preparedStatement = _session.Prepare(query);

            // Enlaza los parámetros a la consulta preparada
            var boundStatement = preparedStatement.Bind(nombreHotel);
            // Ejecuta la consulta
            var resultSet = _session.Execute(boundStatement);

            // Llena el DataTable con los resultados
            foreach (var row in resultSet)
            {
                if (dt.Columns.Count == 0)
                {
                    // Agrega la columna 'numero_camas' al DataTable
                    dt.Columns.Add("numero_camas", typeof(int)); // Especifica explícitamente el tipo de datos como 'int'
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                dataRow["numero_camas"] = row["numero_camas"];
                dt.Rows.Add(dataRow);
            }

            return dt;
        }




        public DataTable SelectCiudadess()
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT
            string query = "SELECT ubicacion_ciudad FROM hotel_keyspace.hoteles ALLOW FILTERING;";
            var resultSet = _session.Execute(query);

            // Llena el DataTable con los resultados
            foreach (var row in resultSet)
            {
                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    foreach (var column in resultSet.Columns)
                    {
                        dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                    }
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                foreach (var column in resultSet.Columns)
                {
                    dataRow[column.Name] = row[column.Name];
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }


        public DataTable SelectHoteles()
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT
            string query = "SELECT nombre_hotel FROM hotel_keyspace.hoteles ALLOW FILTERING;";
            var resultSet = _session.Execute(query);

            // Llena el DataTable con los resultados
            foreach (var row in resultSet)
            {
                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    foreach (var column in resultSet.Columns)
                    {
                        dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                    }
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                foreach (var column in resultSet.Columns)
                {
                    dataRow[column.Name] = row[column.Name];
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }


        public DataTable SelectUsuarios2(int param,string parametro1)
        {
            DataTable dt = new DataTable();
            if (param == 1)
            { // Realiza la consulta SELECT con parámetros
                string query = "SELECT nombre,a_paterno,a_materno FROM hotel_keyspace.clientes WHERE a_paterno = ? ALLOW FILTERING;";
                var preparedStatement = _session.Prepare(query);

                // Enlaza los parámetros a la consulta preparada
                var boundStatement = preparedStatement.Bind(parametro1);
                // Ejecuta la consulta
                var resultSet = _session.Execute(boundStatement);

                // Llena el DataTable con los resultados
                foreach (var row in resultSet)
                {
                    if (dt.Columns.Count == 0)
                    {
                        // Agrega las columnas al DataTable en la primera iteración
                        foreach (var column in resultSet.Columns)
                        {
                            dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                        }
                    }

                    // Agrega las filas al DataTable
                    DataRow dataRow = dt.NewRow();
                    foreach (var column in resultSet.Columns)
                    {
                        dataRow[column.Name] = row[column.Name];
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            if (param == 2)
            { // Realiza la consulta SELECT con parámetros
                string query = "SELECT nombre,a_paterno,a_materno FROM hotel_keyspace.clientes WHERE rfc = ? ALLOW FILTERING;";
                var preparedStatement = _session.Prepare(query);

                // Enlaza los parámetros a la consulta preparada
                var boundStatement = preparedStatement.Bind(parametro1);
                // Ejecuta la consulta
                var resultSet = _session.Execute(boundStatement);

                // Llena el DataTable con los resultados
                foreach (var row in resultSet)
                {
                    if (dt.Columns.Count == 0)
                    {
                        // Agrega las columnas al DataTable en la primera iteración
                        foreach (var column in resultSet.Columns)
                        {
                            dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                        }
                    }

                    // Agrega las filas al DataTable
                    DataRow dataRow = dt.NewRow();
                    foreach (var column in resultSet.Columns)
                    {
                        dataRow[column.Name] = row[column.Name];
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            if (param == 3)
            { // Realiza la consulta SELECT con parámetros
                string query = "SELECT nombre,a_paterno,a_materno FROM hotel_keyspace.clientes WHERE correo_electronico = ? ALLOW FILTERING;";
                var preparedStatement = _session.Prepare(query);

                // Enlaza los parámetros a la consulta preparada
                var boundStatement = preparedStatement.Bind(parametro1);
                // Ejecuta la consulta
                var resultSet = _session.Execute(boundStatement);

                // Llena el DataTable con los resultados
                foreach (var row in resultSet)
                {
                    if (dt.Columns.Count == 0)
                    {
                        // Agrega las columnas al DataTable en la primera iteración
                        foreach (var column in resultSet.Columns)
                        {
                            dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                        }
                    }

                    // Agrega las filas al DataTable
                    DataRow dataRow = dt.NewRow();
                    foreach (var column in resultSet.Columns)
                    {
                        dataRow[column.Name] = row[column.Name];
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }


        public DataTable SelectCodigosReservacionPorApellidos(string apellidoPaterno, string apellidoMaterno)
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT con parámetros
            string query = "SELECT reserva_id FROM hotel_keyspace.reservas WHERE ap = ? AND am = ? ALLOW FILTERING;";
            var preparedStatement = _session.Prepare(query);

            // Enlaza los parámetros a la consulta preparada
            var boundStatement = preparedStatement.Bind(apellidoPaterno, apellidoMaterno);
            // Ejecuta la consulta
            var resultSet = _session.Execute(boundStatement);

            // Llena el DataTable con los resultados
            foreach (var row in resultSet)
            {
                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    dt.Columns.Add("reserva_id", typeof(string)); // Agrega solo la columna de código de reservación
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                dataRow["reserva_id"] = row["reserva_id"].ToString(); // Añade el código de reservación
                dt.Rows.Add(dataRow);
            }

            return dt;
        }


        public DataTable SelectReservasPorApellidos(string apellidoPaterno, string apellidoMaterno)
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT con parámetros
            string query = "SELECT reserva_id, nombre, ap, am, ciudad, hotel_name, estado_reserva FROM hotel_keyspace.reservas WHERE ap = ? AND am = ? ALLOW FILTERING;";
            var preparedStatement = _session.Prepare(query);

            // Enlaza los parámetros a la consulta preparada
            var boundStatement = preparedStatement.Bind(apellidoPaterno, apellidoMaterno);
            // Ejecuta la consulta
            var resultSet = _session.Execute(boundStatement);

            // Llena el DataTable con los resultados, excluyendo las reservaciones con estado_reserva igual a 2
            foreach (var row in resultSet)
            {
                // Verifica si el estado_reserva es igual a 2 (estado "cancelado")
                if (row["estado_reserva"] != null && row["estado_reserva"].ToString() == "2")
                {
                    // Si el estado_reserva es igual a 2, continua con la siguiente iteración
                    continue;
                }

                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    foreach (var column in resultSet.Columns)
                    {
                        dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                    }
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                foreach (var column in resultSet.Columns)
                {
                    dataRow[column.Name] = row[column.Name];
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }



        public DataTable SelectReservasPorApellidosCompleto(string apellidoPaterno, string apellidoMaterno)
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT con parámetros
            string query = "SELECT reserva_id, nombre, ap, am, ciudad, hotel_name, num_hab, precio, fecha_inicio, fecha_fin, anticipo, metodo_pago, codigo_reservacion, usuario_registro, fecha_registro, estado_reserva FROM hotel_keyspace.reservas WHERE ap = ? AND am = ? ALLOW FILTERING;";
            var preparedStatement = _session.Prepare(query);

            // Enlaza los parámetros a la consulta preparada
            var boundStatement = preparedStatement.Bind(apellidoPaterno, apellidoMaterno);
            // Ejecuta la consulta
            var resultSet = _session.Execute(boundStatement);

            // Llena el DataTable con los resultados, excluyendo las reservaciones con estado_reserva igual a 2
            foreach (var row in resultSet)
            {
                // Verifica si el estado_reserva es igual a 2 (estado "cancelado")
                if (row["estado_reserva"] != null && row["estado_reserva"].ToString() == "2")
                {
                    // Si el estado_reserva es igual a 2, continua con la siguiente iteración
                    continue;
                }

                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    foreach (var column in resultSet.Columns)
                    {
                        dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                    }
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                foreach (var column in resultSet.Columns)
                {
                    dataRow[column.Name] = row[column.Name];
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }



        public DataTable SelectHoteles(string parametro1)
        {
            DataTable dt = new DataTable();
   
            // Realiza la consulta SELECT con parámetros
                string query = "SELECT nombre_hotel FROM hotel_keyspace.hoteles WHERE ubicacion_ciudad = ? ALLOW FILTERING;";
                var preparedStatement = _session.Prepare(query);

                // Enlaza los parámetros a la consulta preparada
                var boundStatement = preparedStatement.Bind(parametro1);
                // Ejecuta la consulta
                var resultSet = _session.Execute(boundStatement);

                // Llena el DataTable con los resultados
                foreach (var row in resultSet)
                {
                    if (dt.Columns.Count == 0)
                    {
                        // Agrega las columnas al DataTable en la primera iteración
                        foreach (var column in resultSet.Columns)
                        {
                            dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                        }
                    }

                    // Agrega las filas al DataTable
                    DataRow dataRow = dt.NewRow();
                    foreach (var column in resultSet.Columns)
                    {
                        dataRow[column.Name] = row[column.Name];
                    }
                    dt.Rows.Add(dataRow);
                }
            
            return dt;
        }

        public DataTable SelectHabitaciones(int parametro1,string parametro2)
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT con parámetros
            string query = "SELECT numero_camas ,tipos_cama,precio_noche_por_persona,nivel_habitacion,caracteristicas FROM hotel_keyspace.habitaciones WHERE capacidad_personas = ? and hotel_name = ?  ALLOW FILTERING;";
            var preparedStatement = _session.Prepare(query);

            // Enlaza los parámetros a la consulta preparada
            var boundStatement = preparedStatement.Bind(parametro1,parametro2);
            // Ejecuta la consulta
            var resultSet = _session.Execute(boundStatement);

            // Llena el DataTable con los resultados
            foreach (var row in resultSet)
            {
                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    foreach (var column in resultSet.Columns)
                    {
                        dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                    }
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                foreach (var column in resultSet.Columns)
                {
                    dataRow[column.Name] = row[column.Name];
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }

        public DataTable SelectHabitacionesPorHotel(string nombreHotel)
        {
            DataTable dt = new DataTable();

            // Realiza la consulta SELECT con parámetros
            string query = "SELECT numero_camas, tipos_cama, precio_noche_por_persona, nivel_habitacion, caracteristicas FROM hotel_keyspace.habitaciones WHERE hotel_name = ? ALLOW FILTERING;";
            var preparedStatement = _session.Prepare(query);

            // Enlaza los parámetros a la consulta preparada
            var boundStatement = preparedStatement.Bind(nombreHotel);
            // Ejecuta la consulta
            var resultSet = _session.Execute(boundStatement);

            // Llena el DataTable con los resultados
            foreach (var row in resultSet)
            {
                if (dt.Columns.Count == 0)
                {
                    // Agrega las columnas al DataTable en la primera iteración
                    foreach (var column in resultSet.Columns)
                    {
                        dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                    }
                }

                // Agrega las filas al DataTable
                DataRow dataRow = dt.NewRow();
                foreach (var column in resultSet.Columns)
                {
                    dataRow[column.Name] = row[column.Name];
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }



        public DataTable LoginUsuarios(string param, string parametro1,string parametro2)
        {
            DataTable dt = new DataTable();
            if (param == "Administrador")
            { // Realiza la consulta SELECT con parámetros
                string query = "SELECT correo1,contrasena1 FROM hotel_keyspace.administrador WHERE  correo1 = ? AND contrasena1 = ? ALLOW FILTERING;";
                var preparedStatement = _session.Prepare(query);

                // Enlaza los parámetros a la consulta preparada
                var boundStatement = preparedStatement.Bind(parametro1,parametro2);
                // Ejecuta la consulta
                var resultSet = _session.Execute(boundStatement);

                // Llena el DataTable con los resultados
                foreach (var row in resultSet)
                {
                    if (dt.Columns.Count == 0)
                    {
                        // Agrega las columnas al DataTable en la primera iteración
                        foreach (var column in resultSet.Columns)
                        {
                            dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                        }
                    }

                    // Agrega las filas al DataTable
                    DataRow dataRow = dt.NewRow();
                    foreach (var column in resultSet.Columns)
                    {
                        dataRow[column.Name] = row[column.Name];
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            if (param == "Operativo")
            { // Realiza la consulta SELECT con parámetros
                string query = "SELECT correo,contrasena FROM hotel_keyspace.operativo WHERE correo = ? AND contrasena = ?  ALLOW FILTERING;";
                var preparedStatement = _session.Prepare(query);

                // Enlaza los parámetros a la consulta preparada
                var boundStatement = preparedStatement.Bind(parametro1,parametro2);
                // Ejecuta la consulta
                var resultSet = _session.Execute(boundStatement);

                // Llena el DataTable con los resultados
                foreach (var row in resultSet)
                {
                    if (dt.Columns.Count == 0)
                    {
                        // Agrega las columnas al DataTable en la primera iteración
                        foreach (var column in resultSet.Columns)
                        {
                            dt.Columns.Add(column.Name, typeof(object)); // Asume el tipo de datos como 'object'
                        }
                    }

                    // Agrega las filas al DataTable
                    DataRow dataRow = dt.NewRow();
                    foreach (var column in resultSet.Columns)
                    {
                        dataRow[column.Name] = row[column.Name];
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }

    }








}

//CODIGO PARAR HACER SELECTS
//public List<Colores> GetColores()
//{
//    List<Colores> coloresList = new List<Colores>();

//    // Ejemplo de consulta SELECT para obtener datos de la tabla colores.
//    string query = "SELECT id_color, nombre FROM colores;";

//    // Ejecutar la consulta y obtener el resultado.
//    var resultSet = _session.Execute(query);

//    // Mapear los resultados a objetos Colores.
//    foreach (var row in resultSet)
//    {
//        Colores color = new Colores
//        {
//            IdColor = row["id_color"] != null ? row["id_color"].ToString() : "",
//            Nombre = row["nombre"] != null ? row["nombre"].ToString() : ""
//        };

//        coloresList.Add(color);
//    }

//    return coloresList;
//}
//    }

//    // Clase para representar los datos de la tabla colores.
//    public class Colores
//{
//    public string IdColor { get; set; }
//    public string Nombre { get; set; }
//}