Proceso registro
	definir datos,obtenerdatos como texto
	dimension datos[5]
	Dimension  obtenerdatos[5]
	
	datos[0] = "Nombre"
	datos[1]="Apellido"
	datos[2]="Cedula"
	datos[3]="telefono"
	datos[4]="Cargo"
	
	 imprimir "Ingresar datos para registrar a el Cliente" 
	 Para x <- 0 Hasta Longitud(datos) Hacer
		 secuencia_de_acciones
	 Fin Para
	Imprimir  datos[0]
FinProceso
