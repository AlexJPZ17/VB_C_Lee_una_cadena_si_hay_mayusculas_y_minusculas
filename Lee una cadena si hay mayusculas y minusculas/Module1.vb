Module Module1
    Sub Main()
        'Declaramos las variable 
        Dim texto As String
        Dim mayuscula As Integer
        Dim minuscula As Integer
        'Mensage
        Console.WriteLine("Introduzca un texto")
        'Método para extraer el texto ingresado des de la consola 
        texto = (Console.ReadLine())
        'Inicializamos las variables 
        mayuscula = 0
        minuscula = 0
        ' Ciclo for para obtener la longitud de la cadena texto 
        For i = 1 To Len(texto) 'El comando Len se usa para saber la longitud de una cadena
            ' Condicion para evaluar la cadena que ingresemos por la consola 
            'función Asc para devolver los códigos de carácter ósea letra por letra 
            'función Mid  sirve para extraer una determinada cantidad de caracteres de una cadena ósea una palabra
            'En la ASCII imprimibles 65 = A hasta 90 = Z
            If Asc(Mid(texto, i, 1)) >= 65 And Asc(Mid(texto, i, 1)) <= 90 Then
                'Incrementamos la variable  Mayúsculas
                mayuscula = mayuscula + 1
            End If
            'En la ASCII imprimibles 97 = a hasta 122 = z
            If Asc(Mid(texto, i, 1)) >= 97 And Asc(Mid(texto, i, 1)) <= 122 Then
                'Incrementamos la variable  Minuscula 
                minuscula = minuscula + 1
            End If
        Next
        'Mensaje para desplegar el resultado de la cadena de texto
        Console.WriteLine("La palabra " + texto + " Coniene " + CStr(mayuscula) +
                          "Mayusculas " + CStr(minuscula) + " Minusculas")
        Console.ReadLine()
    End Sub

End Module
