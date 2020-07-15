SubProceso x <- buscarEnBaseDeDatos(user,pass)
	Definir USER_ADMIN,PASS_ADMIN,x Como Caracter
	USER_ADMIN <- 'admin123'
	PASS_ADMIN <- '123abc'
	Si user=USER_ADMIN Y pass=PASS_ADMIN Entonces
		x <- 'Este es un usuario Administrador'
	SiNo
		x <- 'este es un Usuario común '
	FinSi
FinSubProceso

Proceso Login
	Definir usuario,clave,rango Como Caracter
	Definir vacio Como Caracter
	vacio <- ''
	Repetir
		Escribir ' Ingrese su usuario '
		Leer usuario
		Escribir ' Ingrese su Clave '
		Leer clave
		Si usuario=vacio O clave=vacio Entonces
			Borrar Pantalla
			Escribir 'Ingrese datos completos en los campos'
			Esperar Tecla
		SiNo
			Si usuario='0' O clave='0' Entonces
				Borrar Pantalla
				Escribir 'Ingrese datos completos en los campos'
				Esperar 3 Segundos
			SiNo
				Borrar Pantalla
				Escribir ' El Usuario es : ',usuario
				Escribir '   La Clave es : ',clave
				Escribir ' Y el Rango es : ',buscarEnBaseDeDatos(usuario,clave)
				Esperar 3 Segundos
			FinSi
		FinSi
	Hasta Que usuario<>vacio Y clave<>vacio
FinProceso
