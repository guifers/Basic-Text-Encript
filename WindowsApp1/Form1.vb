Imports System.IO

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Para encriptar se coge la equivalencia del carácter introducido en ASCII y se le suma un número aleatorio
        'generado(volare) y con dicho resultado se genera el nuevo caracter
        Dim Longitud As Integer
        Dim A As String
        A = TextBox1.Text
        Longitud = A.Length
        Dim array(Longitud) As String
        Dim array2(Longitud) As String
        Dim array3(Longitud) As String
        Dim array4(Longitud) As String
        Dim array5(Longitud) As String
        Dim numeroAleatorio As New Random()
        Dim volare As Integer
        Dim ruta As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\4decript.txt" 'Probar a saltar restriccion para crear file en C;/
        Dim escritor As New System.IO.StreamWriter(ruta)

        For i = 1 To Longitud Step 1
            array(i) = Mid(A, i, 1)
            TextBox2.Text = array(i)

        Next

        For Z = 1 To 1 Step 1


            For I = 1 To Longitud Step 1
                volare = numeroAleatorio.Next(1, 10)
                escritor.WriteLine(volare)
                array2(Z) = AscW(array(I))
                'MsgBox(array2(Z)) #Ver porque no worka esto -EN Z ES UN SOLO LOOP
                array3(I) = array2(Z) + volare
                array4(I) = ChrW(array3(I))
                'MsgBox(volare)
                'MsgBox(array2(Z))
                'MsgBox(array3(I))
                'MsgBox(array4(I))


            Next
        Next
        escritor.Close()
        array5(Longitud) = String.Join("", array4)
        TextBox2.Text = array5(Longitud)

        'MsgBox(array4.Length)
        'MsgBox(array5.Length)


        'Dim Hello As String
        'Dim C As Integer
        'Hello = array(1)
        'MsgBox(Hello)
        'Dim B As Object
        'B = AscW(Hello)
        'MsgBox(array.Length - 1)
        'MsgBox(A.Length)
        'MsgBox(Chr(array(1)))
        'For z = 1 To Longitud Step 1
        'array2(z) = Chr(array(z))
        'MsgBox(array2(z))
        'Next
        'Dim FirstWord As String = Mid(A, 1, 1)
        'Label2.Text = array





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Para desencriptar se precisa del fichero 4decript que contiene los numeros aleatorios generados en el proceso
        'de encriptado.
        Dim rutita As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\4decript.txt" 'Probar a saltar restriccion para crear file en C;/
        Dim lector As New StreamReader(rutita)
        Dim lector2 As New StreamReader(rutita) 'El cabron no me dejaba volver a leerlo con el mismo lector

        Dim Longitud As Integer
        Dim B = TextBox4.Text
        Longitud = B.Length


        Dim contador = 0
        'Dim linea = lector.ReadLine ' Cuando el método ReadLine alcanza el final del archivo, devuelve Nothing.
        If File.Exists(rutita) Then
            MsgBox("FILE FOUND!")
            While lector.Peek <> -1 'devuelve -1 es que no leyo nah

                contador = contador + 1
                Dim linea = lector.ReadLine ' Cuando el método ReadLine alcanza el final del archivo, devuelve Nothing.
                'MsgBox(linea)

            End While
            lector.Close()
            Dim arrayconverse(contador) As String
            Dim arrayconverse2(contador) As String
            Dim array(contador) As String
            Dim array2(contador) As String
            Dim arrayspec(contador) As String
            Dim arrayline(contador) As String
            Dim arrayfinal(contador) As String
            Dim array57(contador) As String
            For i = 1 To contador Step 1
                array(i) = Mid(B, i, 1)
                'MsgBox(array(i))
            Next
            'While lector.EndOfStream ¿Como tomar el control del programa para meterle datos?
            'While lector2.Peek <> -1 'devuelve -1 es que no leyo nah
            'Dim linea = lector2.ReadLine ' Cuando el método ReadLine alcanza el final del archivo, devuelve Nothing.
            'MsgBox(linea)
            For R = 1 To contador Step 1
                If lector2.Peek <> -1 Then
                    Dim linea = lector2.ReadLine
                    arrayline(R) = linea
                    'MsgBox(arrayline(R))
                Else
                    Exit For
                End If
            Next
            Dim suma As Integer
            For v = 1 To contador Step 1
                For X = 1 To contador Step 1
                    array2(v) = AscW(array(X))
                    'MsgBox(array2(v))
                    suma = arrayline(X)
                    arrayspec(X) = array2(v) - suma
                    array57(v) = ChrW(arrayspec(v)) 'Lo cambie por X
                    'MsgBox(array57(v))
                Next

            Next

            'End While
            lector2.Close()
            'MsgBox(contador)
            arrayfinal(contador) = String.Join("", array57)
            'MsgBox(array57(1))
            'MsgBox(array57(2))


            TextBox3.Text = arrayfinal(contador)





        Else
                MsgBox("4decript.txt NOT FOUND", MsgBoxStyle.Critical)

        End If



    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("1- File 4decript.txt must stay in the desktop", MsgBoxStyle.Information)
        MsgBox("2- You can encrypt and decrypt anytime, but .txt will be replaced so save it", MsgBoxStyle.Information)
    End Sub
End Class
